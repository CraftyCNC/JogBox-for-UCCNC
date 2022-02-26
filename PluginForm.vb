Imports System.Drawing
Imports System.Threading
Imports System.Windows.Forms
Imports System.Runtime.InteropServices


Friend Class JogBox

#Region "window snap stuff"
    'https://www.codeproject.com/Articles/15314/A-NET-Snap-To-Screen-Form

    Private Const mSnapOffset As Integer = 35
    Private Const WM_WINDOWPOSCHANGING As Integer = &H46

    <StructLayout(LayoutKind.Sequential)>
    Public Structure WINDOWPOS
        Public hwnd As IntPtr
        Public hwndInsertAfter As IntPtr
        Public x As Integer
        Public y As Integer
        Public cx As Integer
        Public cy As Integer
        Public flags As Integer
    End Structure

    Protected Overrides Sub WndProc(ByRef m As Message)
        ' Listen for operating system messages
        Select Case m.Msg
            Case WM_WINDOWPOSCHANGING
                SnapToDesktopBorder(Me, m.LParam, 0)
        End Select

        MyBase.WndProc(m)
    End Sub

    Public Shared Sub SnapToDesktopBorder(ByVal clientForm As Form, ByVal LParam As IntPtr, ByVal widthAdjustment As Integer)
        If clientForm Is Nothing Then
            ' Satisfies rule: Validate parameters
            Throw New ArgumentNullException("clientForm")
        End If

        ' Snap client to the top, left, bottom or right desktop border
        ' as the form is moved near that border.

        Try
            ' Marshal the LPARAM value which is a WINDOWPOS struct
            Dim NewPosition As New WINDOWPOS
            NewPosition = CType(Runtime.InteropServices.Marshal.PtrToStructure(
                LParam, GetType(WINDOWPOS)), WINDOWPOS)

            If NewPosition.y = 0 OrElse NewPosition.x = 0 Then
                Return ' Nothing to do!
            End If

            ' Adjust the client size for borders and caption bar
            Dim ClientRect As Rectangle = clientForm.RectangleToScreen(clientForm.ClientRectangle)
            ClientRect.Width += SystemInformation.FrameBorderSize.Width - widthAdjustment
            ClientRect.Height += (SystemInformation.FrameBorderSize.Height + SystemInformation.CaptionHeight)

            ' Now get the screen working area (without taskbar)
            Dim WorkingRect As Rectangle = Screen.GetWorkingArea(clientForm.ClientRectangle)

            ' Left border
            If NewPosition.x >= WorkingRect.X - mSnapOffset AndAlso
                NewPosition.x <= WorkingRect.X + mSnapOffset Then
                NewPosition.x = WorkingRect.X
            End If

            ' Get screen bounds and taskbar height (when taskbar is horizontal)
            Dim ScreenRect As Rectangle = Screen.GetBounds(Screen.PrimaryScreen.Bounds)
            Dim TaskbarHeight As Integer = ScreenRect.Height - WorkingRect.Height

            ' Top border (check if taskbar is on top or bottom via WorkingRect.Y)
            If NewPosition.y >= -mSnapOffset AndAlso
                (WorkingRect.Y > 0 AndAlso NewPosition.y <= (TaskbarHeight + mSnapOffset)) OrElse
                (WorkingRect.Y <= 0 AndAlso NewPosition.y <= (mSnapOffset)) Then
                If TaskbarHeight > 0 Then
                    NewPosition.y = WorkingRect.Y ' Horizontal Taskbar
                Else
                    NewPosition.y = 0 ' Vertical Taskbar
                End If
            End If

            ' Right border
            If NewPosition.x + ClientRect.Width <= WorkingRect.Right + mSnapOffset AndAlso
                NewPosition.x + ClientRect.Width >= WorkingRect.Right - mSnapOffset Then
                NewPosition.x = WorkingRect.Right - (ClientRect.Width + SystemInformation.FrameBorderSize.Width)
            End If

            ' Bottom border
            If NewPosition.y + ClientRect.Height <= WorkingRect.Bottom + mSnapOffset AndAlso
                NewPosition.y + ClientRect.Height >= WorkingRect.Bottom - mSnapOffset Then
                NewPosition.y = WorkingRect.Bottom - (ClientRect.Height + SystemInformation.FrameBorderSize.Height)
            End If

            ' Marshal it back
            Runtime.InteropServices.Marshal.StructureToPtr(NewPosition, LParam, True)
        Catch ex As ArgumentException
        End Try
    End Sub

#End Region


    Private UC As Plugininterface.Entry
    Dim PluginMain As UCCNCplugin
    Dim MustClose As Boolean = False

    Dim strMoveCode As String ' Use to hold the 'g code' string to run

    Dim thrMyProc As Thread ' Main thread for any probing op

    'Flags to kill threads
    Dim IsMovingFlag As Boolean = False
    Friend abortflag As Boolean = False

    Dim xmaxVel, ymaxVel, zmaxVel As Double


    Dim lastEstopCond, curEstopCond As Boolean


    Public Sub New(CallerPluginMain As UCCNCplugin)
        Me.UC = CallerPluginMain.UC
        Me.PluginMain = CallerPluginMain
        InitializeComponent()
    End Sub

    Private Sub PluginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        nudJogStep.Value = My.Settings.StepVal
        nudJogVel.Value = My.Settings.VelVal
        nudGoTOVel.Value = My.Settings.GoVelVal


        cbOnTop.Checked = My.Settings.OnTop
        cbJogEnab.Checked = My.Settings.Enabled

        rbJogCont.Checked = True
    End Sub

    Private Sub PluginForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ' Do not close the form when the red X button is pressed
        ' But start a Thread which will stop the Loop call from the UCCNC
        ' to prevent the form closing while there is a GUI update in the Loop event
        If Not MustClose Then
            e.Cancel = True
            Dim thrClose As New Thread(Sub() Closeform())
            thrClose.CurrentCulture = Thread.CurrentThread.CurrentCulture ' Preserve regional settings
            thrClose.Start()
        Else
            ' Form is closing here...
        End If
    End Sub

    Public Sub Closeform()

        My.Settings.StepVal = nudJogStep.Value
        My.Settings.VelVal = nudJogVel.Value
        My.Settings.GoVelVal = nudGoTOVel.Value


        My.Settings.OnTop = cbOnTop.Checked
        My.Settings.Enabled = cbJogEnab.Checked

        My.Settings.Save()

        ' Stop the Loop event to update the GUI
        PluginMain.LoopStop = True
        ' Wait until the loop exited
        While (PluginMain.LoopWorking)
            Thread.Sleep(10)
        End While
        ' Set the mustclose variable to true and call the .Close() function to close the Form
        MustClose = True
        Me.Close()
    End Sub



    Private Function IsMoving() As Boolean
        Dim thrIsMoving As New Thread(Sub() CheckIsMoving())
        thrIsMoving.CurrentCulture = Thread.CurrentThread.CurrentCulture
        thrIsMoving.Start()
        While thrIsMoving.IsAlive
            Thread.Sleep(1)
        End While
        Return IsMovingFlag
    End Function



    Private Sub CheckIsMoving()
        IsMovingFlag = UC.IsMoving
    End Sub


    Sub rbJogStepSelected()
        If rbJogCont.Checked Then

            pnlJogBtn.Visible = True
            pnlGoTo.Visible = False

            nudJogStep.Visible = True
            nudJogVel.Visible = True
            'tbJogStepSize.Visible = False
            'tbJogVel.Visible = True
            lblStepSize.Visible = True
            lblJogVel.Visible = True

            btnJogUL.Enabled = True
            btnJogBR.Enabled = True
            btnJogBL.Enabled = True
            btnJogUR.Enabled = True




        ElseIf rbJogStep.Checked Then

            pnlJogBtn.Visible = True
            pnlGoTo.Visible = False

            nudJogStep.Visible = True
            nudJogVel.Visible = True
            'tbJogStepSize.Visible = True
            'tbJogVel.Visible = False
            lblStepSize.Visible = True
            lblJogVel.Visible = True


            btnJogUL.Enabled = False
            btnJogBR.Enabled = False
            btnJogBL.Enabled = False
            btnJogUR.Enabled = False

        ElseIf rbGoTo.Checked Then

            pnlJogBtn.Visible = False
            pnlGoTo.Visible = True
            pnlGoTo.BringToFront()

        End If
    End Sub



    Private Sub rbJogStep_CheckedChanged(sender As Object, e As EventArgs) Handles rbJogStep.CheckedChanged, rbJogCont.CheckedChanged, rbGoTo.CheckedChanged
        rbJogStepSelected()
    End Sub




    Private Sub btnGoTo_Click(sender As Object, e As EventArgs) Handles btnGoTo.Click

        If Not cbGoTORot.Checked AndAlso Not cbGoToX.Checked AndAlso Not cbGoToY.Checked AndAlso Not cbGoToZ.Checked Then

            MessageBox.Show(Me, "Appears no axis is set for moving, no move To make!")

            Return
        Else

            'If IsSpindleFlag = True And IsCamFlag = False Then
            '    Dim dobutton As DialogResult = MessageBox.Show("Camera is already active offset, continue?", "Proceed with offset?", MessageBoxButtons.YesNo)

            '    If dobutton = DialogResult.No Then
            '        Exit Sub
            '    Else

            '    End If

            'End If


            Try

                If thrMyProc Is Nothing Then

                    abortflag = False

                    thrMyProc = New Thread(AddressOf GoToThread)
                    thrMyProc.CurrentCulture = Thread.CurrentThread.CurrentCulture ' Stay in English
                    thrMyProc.Start()

                    ' Me.btnProbeGrid.Text = "STOP !"
                Else

                    'stop UCCNC first
                    UC.Stop()

                    abortflag = True

                    'thrMyProc.Abort() 'DONT DO THIS
                    thrMyProc = Nothing

                    ' Me.btnProbeGrid.Text = "Start Probing!"

                End If
            Catch ex As Exception
                MessageBox.Show(Me, "Didn't work....")
            End Try
        End If





    End Sub


    Private Sub btnGoToZero_Click(sender As Object, e As EventArgs) Handles btnGoToZero.Click

        If Not cbGoTORot.Checked AndAlso Not cbGoToX.Checked AndAlso Not cbGoToY.Checked AndAlso Not cbGoToZ.Checked Then
            Using New Centered_MessageBox(Me)
                MessageBox.Show(Me, "Appears no axis is set for moving, no move To make!")
            End Using

            Return
        Else



            Try

                If thrMyProc Is Nothing Then

                    abortflag = False

                    thrMyProc = New Thread(AddressOf GoToZeroThread)
                    thrMyProc.CurrentCulture = Thread.CurrentThread.CurrentCulture ' Stay in English
                    thrMyProc.Start()

                    ' Me.btnProbeGrid.Text = "STOP !"
                Else

                    'stop UCCNC first
                    UC.Stop()

                    abortflag = True

                    'thrMyProc.Abort() 'DONT DO THIS
                    thrMyProc = Nothing

                End If
            Catch ex As Exception
                MessageBox.Show(Me, "Didn't work....")
            End Try
        End If



    End Sub


    Public Sub GoToThread()

        Dim zstart, xstart, ystart, rotstart, feed, safe, zretract, zend, xend, yend, rotend, xpoint, ypoint, zpoint, rotpoint As Double

        Dim strMoveCode As String




        ' ABORT if needed to
        If UC.GetLED(25) Or UC.GetLED(36) Or UC.GetLED(217) Or abortflag Then ' Check for feedhold and cycle stop and reset
            Try
                Using New Centered_MessageBox(Me)

                    MessageBox.Show(Me, "Aborting offset 'Go To' move, UCCNC in reset!")
                End Using

                UC.AddStatusmessage("Aborting Go To move!")
                thrMyProc = Nothing
                Return
                'thrMyProc.Abort()

                Exit Sub
            Catch ex As Exception

            End Try

        End If





        ' ABORT if needed to

        xstart = UC.GetXpos
        ystart = UC.GetYpos
        zstart = UC.GetZpos

        Try

            If cbGoToX.Checked AndAlso tbGoToX.Text <> "" Then
                xpoint = Convert.ToDouble(tbGoToX.Text)

            End If

            If cbGoToY.Checked AndAlso tbGoToY.Text <> "" Then
                ypoint = Convert.ToDouble(tbGoToY.Text)

            End If


            If cbGoToZ.Checked AndAlso tbGoTOZ.Text <> "" Then
                zpoint = Convert.ToDouble(tbGoTOZ.Text)

            End If


            If cbGoTORot.Checked AndAlso tbGoToRot.Text <> "" Then
                rotpoint = Convert.ToDouble(tbGoToRot.Text)

            End If


            feed = nudGoTOVel.Value
        Catch ex As Exception

        End Try



        strMoveCode = "F" & feed

        'messagebox.show(me, strMoveCode)


        UC.Codesync(strMoveCode)
        While IsMoving()
            Thread.Sleep(5)
        End While

        ' Lift Z to safe height
        If cbZSafeLift.Checked Then

            GoToSafeZ()

        Else

        End If



        'Z First:



        If cbGoToZ.Checked AndAlso (zpoint > UC.GetZpos) Then

            If feed <> 0 Then
                strMoveCode = "G1 "
            Else
                strMoveCode = "G0 "
            End If

            strMoveCode = strMoveCode & " Z" & fn(zpoint)

            UC.Codesync(strMoveCode)

            While IsMoving()
                Thread.Sleep(5)
            End While

        End If


        'Move to location
        If feed <> 0 Then
            strMoveCode = "G1 "
        Else
            strMoveCode = "G0 "
        End If


        If cbGoToX.Checked Then
            strMoveCode = strMoveCode & " X" & fn(xpoint)
        End If

        If cbGoToY.Checked Then
            strMoveCode = strMoveCode & " Y" & fn(ypoint)
        End If








        UC.Codesync(strMoveCode)

        While IsMoving()
            Thread.Sleep(5)
        End While





        'strMoveCode = "G1 X" & fn(xpoint) & " Y" & fn(ypoint) & " F" & fn(feed)



        If (cbZSafeLift.Checked AndAlso cbZSafeReturn.Checked) Or (Not cbZSafeLift.Checked AndAlso Not cbZSafeReturn.Checked) Then
            If feed <> 0 Then

                If cbGoToZ.Checked Then
                    strMoveCode = "G31 z" & fn(zpoint) & " F" & fn(feed)
                Else
                    strMoveCode = "G31 z" & fn(zstart) & " F" & fn(feed)

                End If

            Else

                If cbGoToZ.Checked Then
                    strMoveCode = "G0 z" & fn(zpoint)
                Else
                    strMoveCode = "G0 z" & fn(zstart)

                End If

            End If

            UC.Codesync(strMoveCode)

            While IsMoving()
                Thread.Sleep(5)
            End While
        End If



        thrMyProc = Nothing



        Exit Sub




    End Sub


    Public Sub GoToZeroThread()

        Dim zstart, xstart, ystart, rotstart, feed, safe, zretract, zend, xend, yend, rotend, xpoint, ypoint, zpoint, rotpoint As Double

        Dim strMoveCode As String




        ' ABORT if needed to
        If UC.GetLED(25) Or UC.GetLED(36) Or UC.GetLED(217) Or abortflag Then ' Check for feedhold and cycle stop and reset
            Try
                Using New Centered_MessageBox(Me)

                    MessageBox.Show(Me, "Aborting Go To Zero move, UCCNC in reset!")
                End Using

                UC.AddStatusmessage("Aborting Go TO Zero move!")
                thrMyProc = Nothing
                Return
                'thrMyProc.Abort()

                Exit Sub
            Catch ex As Exception

            End Try

        End If





        ' ABORT if needed to

        xstart = UC.GetXpos
        ystart = UC.GetYpos
        zstart = UC.GetZpos

        Try

            If cbGoToX.Checked Then
                xpoint = 0

            End If

            If cbGoToY.Checked Then
                ypoint = 0

            End If


            If cbGoToZ.Checked Then
                zpoint = 0

            End If


            If cbGoTORot.Checked Then
                rotpoint = 0

            End If


            feed = nudGoTOVel.Value
        Catch ex As Exception

        End Try



        strMoveCode = "F" & feed

        'messagebox.show(me, strMoveCode)


        UC.Codesync(strMoveCode)
        While IsMoving()
            Thread.Sleep(5)
        End While

        ' Lift Z to safe height
        If cbZSafeLift.Checked Then

            GoToSafeZ()

        Else

        End If



        'Z First:



        If cbGoToZ.Checked AndAlso (zpoint > UC.GetZpos) Then

            If feed <> 0 Then
                strMoveCode = "G1 "
            Else
                strMoveCode = "G0 "
            End If

            strMoveCode = strMoveCode & " Z" & fn(zpoint)

            UC.Codesync(strMoveCode)

            While IsMoving()
                Thread.Sleep(5)
            End While

        End If


        'Move to location
        If feed <> 0 Then
            strMoveCode = "G1 "
        Else
            strMoveCode = "G0 "
        End If


        If cbGoToX.Checked Then
            strMoveCode = strMoveCode & " X" & fn(xpoint)
        End If

        If cbGoToY.Checked Then
            strMoveCode = strMoveCode & " Y" & fn(ypoint)
        End If


        'If cbGoToZ.Checked Then
        '    strMoveCode = strMoveCode
        'End If





        'strMoveCode = strMoveCode & " F" & fn(feed)

        UC.Codesync(strMoveCode)

        While IsMoving()
            Thread.Sleep(5)
        End While





        'strMoveCode = "G1 X" & fn(xpoint) & " Y" & fn(ypoint) & " F" & fn(feed)



        If (cbZSafeLift.Checked AndAlso cbZSafeReturn.Checked) Or (Not cbZSafeLift.Checked AndAlso Not cbZSafeReturn.Checked) Then
            If feed <> 0 Then

                If cbGoToZ.Checked Then
                    strMoveCode = "G31 z" & fn(zpoint) & " F" & fn(feed)
                Else
                    strMoveCode = "G31 z" & fn(zstart) & " F" & fn(feed)

                End If

            Else

                If cbGoToZ.Checked Then
                    strMoveCode = "G0 z" & fn(zpoint)
                Else
                    strMoveCode = "G0 z" & fn(zstart)

                End If

            End If

            UC.Codesync(strMoveCode)

            While IsMoving()
                Thread.Sleep(5)
            End While
        End If



        thrMyProc = Nothing


        Exit Sub




    End Sub


    Public Function FaultCheck_perim() As Boolean
        Dim errMsg As String
        FaultCheck_perim = False


        If UC.GetLED(25) Or UC.GetLED(36) Or UC.GetLED(217) Then ' Check for feedhold and cycle stop and reset
            Try

                FaultCheck_perim = True

                MessageBox.Show("Aborting!! EStop or Feedhold")


                abortflag = True

                thrMyProc = Nothing


            Catch ex As Exception

            End Try

        End If

        'NEW, 2.013
        If UC.GetLED(26) Then ' Check for limit switches
            Try

                FaultCheck_perim = True

                MessageBox.Show("Aborting!! Limit hit")

                abortflag = True

                thrMyProc = Nothing

            Catch ex As Exception

            End Try

        End If






    End Function





#Region "Jog Buttons"



#Region "JOGGING ENABLE"



    Private Sub cbJogEnab_CheckedChanged(sender As Object, e As EventArgs) Handles cbJogEnab.CheckedChanged
        jogenabchangecheck()
    End Sub



    Sub jogenabchangecheck()
        If cbJogEnab.Checked = True Then
            rbJogCont.Enabled = True
            rbJogStep.Enabled = True
            btnJogDn.Enabled = True
            btnJogUp.Enabled = True
            btnJogRight.Enabled = True
            btnJogLeft.Enabled = True
            btnjogZup.Enabled = True
            btnjogZdown.Enabled = True

            btnJogUL.Enabled = True
            btnJogBR.Enabled = True
            btnJogBL.Enabled = True
            btnJogUR.Enabled = True

        Else
            rbJogCont.Enabled = False
            rbJogStep.Enabled = False
            btnJogDn.Enabled = False
            btnJogUp.Enabled = False
            btnJogRight.Enabled = False
            btnJogLeft.Enabled = False
            btnjogZup.Enabled = False
            btnjogZdown.Enabled = False

            btnJogUL.Enabled = False
            btnJogBR.Enabled = False
            btnJogBL.Enabled = False
            btnJogUR.Enabled = False

        End If
    End Sub

#End Region


    ' X and Y Jogs

    'Y Up
    Private Sub btnJogUp_Click_1(sender As Object, e As EventArgs) Handles btnJogUp.MouseDown
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(1, False, yvelPCT(nudJogVel.Value))
        End If
        If rbJogStep.Checked Then
            UC100.AddLinearMoveRel(1, nudJogStep.Value, 1, yvelPCT(nudJogVel.Value), False)
        End If
    End Sub
    Private Sub btnJogUp_Click_1a(sender As Object, e As EventArgs) Handles btnJogUp.MouseUp
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(1, False, 0)
        End If
    End Sub


    'X Left
    Private Sub btnJogLeft_Click(sender As Object, e As EventArgs) Handles btnJogLeft.MouseDown
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(0, True, xvelPCT(nudJogVel.Value))
        End If
        If rbJogStep.Checked Then
            UC100.AddLinearMoveRel(0, nudJogStep.Value, 1, xvelPCT(nudJogVel.Value), True)
        End If
    End Sub
    Private Sub btnJogLeft_Click1(sender As Object, e As EventArgs) Handles btnJogLeft.MouseUp
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(0, True, 0)
        End If
    End Sub

    'X Right
    Private Sub btnJogRight_Click(sender As Object, e As EventArgs) Handles btnJogRight.MouseDown
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(0, False, xvelPCT(nudJogVel.Value))
        End If
        If rbJogStep.Checked Then
            UC100.AddLinearMoveRel(0, nudJogStep.Value, 1, xvelPCT(nudJogVel.Value), False)
        End If
    End Sub
    Private Sub btnJogRight_Click1(sender As Object, e As EventArgs) Handles btnJogRight.MouseUp
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(0, False, 0)
        End If

    End Sub

    'Y Down
    Private Sub btnJogDn_Click(sender As Object, e As EventArgs) Handles btnJogDn.MouseDown
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(1, True, yvelPCT(nudJogVel.Value))
        End If
        If rbJogStep.Checked Then
            UC100.AddLinearMoveRel(1, nudJogStep.Value, 1, yvelPCT(nudJogVel.Value), True)
        End If
    End Sub
    Private Sub btnJogDn_Click1(sender As Object, e As EventArgs) Handles btnJogDn.MouseUp
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(1, True, 0)
        End If

    End Sub

    'DIAGNALS



    'UL
    Private Sub btnUL(sender As Object, e As EventArgs) Handles btnJogUL.MouseDown
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(0, True, yvelPCT(nudJogVel.Value))
            UC100.JogOnSpeed(1, False, yvelPCT(nudJogVel.Value))
        End If
        If rbJogStep.Checked Then
            ' UC100.AddLinearMoveRel(1, nudJogStep.Value, 1, yvelPCT(nudJogVel.Value), True)
        End If
    End Sub
    Private Sub btnULup(sender As Object, e As EventArgs) Handles btnJogUL.MouseUp
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(0, True, 0)
            UC100.JogOnSpeed(1, True, 0)
        End If

    End Sub


    'UR
    Private Sub btnUR(sender As Object, e As EventArgs) Handles btnJogUR.MouseDown
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(0, False, yvelPCT(nudJogVel.Value))
            UC100.JogOnSpeed(1, False, yvelPCT(nudJogVel.Value))
        End If
        If rbJogStep.Checked Then
            ' UC100.AddLinearMoveRel(1, nudJogStep.Value, 1, yvelPCT(nudJogVel.Value), True)
        End If
    End Sub
    Private Sub btnURup(sender As Object, e As EventArgs) Handles btnJogUR.MouseUp
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(0, True, 0)
            UC100.JogOnSpeed(1, True, 0)
        End If

    End Sub


    'BL
    Private Sub btnBL(sender As Object, e As EventArgs) Handles btnJogBL.MouseDown
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(0, True, yvelPCT(nudJogVel.Value))
            UC100.JogOnSpeed(1, True, yvelPCT(nudJogVel.Value))
        End If
        If rbJogStep.Checked Then
            ' UC100.AddLinearMoveRel(1, nudJogStep.Value, 1, yvelPCT(nudJogVel.Value), True)
        End If
    End Sub
    Private Sub btnBLup(sender As Object, e As EventArgs) Handles btnJogBL.MouseUp
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(0, True, 0)
            UC100.JogOnSpeed(1, True, 0)
        End If

    End Sub


    'BR
    Private Sub btnBR(sender As Object, e As EventArgs) Handles btnJogBR.MouseDown
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(0, False, yvelPCT(nudJogVel.Value))
            UC100.JogOnSpeed(1, True, yvelPCT(nudJogVel.Value))
        End If
        If rbJogStep.Checked Then
            ' UC100.AddLinearMoveRel(1, nudJogStep.Value, 1, yvelPCT(nudJogVel.Value), True)
        End If
    End Sub
    Private Sub btnBRup(sender As Object, e As EventArgs) Handles btnJogBR.MouseUp
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(0, True, 0)
            UC100.JogOnSpeed(1, True, 0)
        End If

    End Sub


    ' Z Jogs
    Private Sub btnjogZup_Click(sender As Object, e As EventArgs) Handles btnjogZup.MouseDown
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(2, False, zvelPCT(nudJogVel.Value))
        End If
        If rbJogStep.Checked Then
            UC100.AddLinearMoveRel(2, nudJogStep.Value, 1, zvelPCT(nudJogVel.Value), False)
        End If
    End Sub
    Private Sub btnjogZup_Click2(sender As Object, e As EventArgs) Handles btnjogZup.MouseUp
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(2, False, 0)
        End If
    End Sub

    Private Sub btnjogZdown_Click(sender As Object, e As EventArgs) Handles btnjogZdown.MouseDown
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(2, True, zvelPCT(nudJogVel.Value))
        End If
        If rbJogStep.Checked Then
            UC100.AddLinearMoveRel(2, nudJogStep.Value, 1, zvelPCT(nudJogVel.Value), True)
        End If
    End Sub

    Private Sub btnjogZdown_Click2(sender As Object, e As EventArgs) Handles btnjogZdown.MouseUp
        If rbJogCont.Checked Then
            UC100.JogOnSpeed(2, True, 0)
        End If
    End Sub


    Sub GoToSafeZ()
        strMoveCode = "m216"
        UC.Codesync(strMoveCode)

        'UC.Callbutton(216) ' skips ahead...

        'While Not IsMoving()
        '    Thread.Sleep(5)
        'End While

        While IsMoving()
            Thread.Sleep(5)
        End While
    End Sub



    Private Function xvelPCT(ByVal xvel As Double) As Double

        'Convert speed in 'unit/min' to 'Jog %'
        If xmaxVel = 0 And ymaxVel = 0 Then
            xmaxVel = UC.Getfielddouble(True, 9)
            ymaxVel = UC.Getfielddouble(True, 24)
            zmaxVel = UC.Getfielddouble(True, 39)

        End If

        xvelPCT = xvel / xmaxVel * 100 ' Define velocity as a % of max axis velocity, as input to JogOnSpeed command.
        Return xvelPCT
    End Function

    Private Function yvelPCT(ByVal yvel As Double) As Double

        'Convert speed in 'unit/min' to 'Jog %'
        If xmaxVel = 0 And ymaxVel = 0 Then
            xmaxVel = UC.Getfielddouble(True, 9)
            ymaxVel = UC.Getfielddouble(True, 24)
            zmaxVel = UC.Getfielddouble(True, 39)

        End If

        yvelPCT = yvel / ymaxVel * 100 ' Define velocity as a % of max axis velocity, as input to JogOnSpeed command.
        Return yvelPCT
    End Function

    Private Function zvelPCT(ByVal zvel As Double) As Double

        'Convert speed in 'unit/min' to 'Jog %'
        If xmaxVel = 0 And ymaxVel = 0 Then
            xmaxVel = UC.Getfielddouble(True, 9)
            ymaxVel = UC.Getfielddouble(True, 24)
            zmaxVel = UC.Getfielddouble(True, 39)
        End If

        zvelPCT = zvel / zmaxVel * 100 ' Define velocity as a % of max axis velocity, as input to JogOnSpeed command.
        Return zvelPCT
    End Function



    Private Sub cbOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles cbOnTop.CheckedChanged

        If cbOnTop.Checked Then
            Me.BringToFront()
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        UC.Callbutton(144)
    End Sub

    Private Sub screenUpdateTimer_Tick(sender As Object, e As EventArgs) Handles screenUpdateTimer.Tick


        curEstopCond = UC.GetLED(25)

        If curEstopCond <> lastEstopCond Then
            If UC.GetLED(25) Then
                btnReset.BackColor = Color.DarkSalmon
            Else
                btnReset.BackColor = Color.LightGreen
            End If
        End If
        'Reset button LED

        lastEstopCond = curEstopCond
    End Sub
    Public Function fn(ByRef val As Double)
        Return String.Format("{0:F4}", val)
        'Return String.Format("f6", val)
    End Function
    Public Function fn2(ByRef val As Double)
        Return String.Format("{0:F2}", val)
        'Return String.Format("f6", val)
    End Function

    Public Function fn3(ByRef val As Double)
        Return String.Format("{0:F3}", val)
        'Return String.Format("f6", val)
    End Function
#End Region

End Class