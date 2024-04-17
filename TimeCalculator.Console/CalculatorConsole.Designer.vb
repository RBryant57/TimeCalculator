Namespace local.YellowCaddis.TimeCalculator.Console

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class CalculatorConsole
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalculatorConsole))
            Me.btnOK = New System.Windows.Forms.Button()
            Me.btnMinus = New System.Windows.Forms.Button()
            Me.btnPlus = New System.Windows.Forms.Button()
            Me.txtResult = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtQuantityTime = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtBeginningTime = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.erpMain = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.tabMain = New System.Windows.Forms.TabControl()
            Me.tbpClock = New System.Windows.Forms.TabPage()
            Me.tbpElapsed = New System.Windows.Forms.TabPage()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtStartTime = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.btnElapsedTime = New System.Windows.Forms.Button()
            Me.txtEndTime = New System.Windows.Forms.TextBox()
            Me.txtElapsedTime = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.tbpElapsedDays = New System.Windows.Forms.TabPage()
            Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
            Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
            Me.lblSaturdays = New System.Windows.Forms.Label()
            Me.lblFridays = New System.Windows.Forms.Label()
            Me.lblThursdays = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.lblWednesdays = New System.Windows.Forms.Label()
            Me.lblTuesdays = New System.Windows.Forms.Label()
            Me.lblMondays = New System.Windows.Forms.Label()
            Me.lblSundays = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.btnElapsedDays = New System.Windows.Forms.Button()
            CType(Me.erpMain, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabMain.SuspendLayout()
            Me.tbpClock.SuspendLayout()
            Me.tbpElapsed.SuspendLayout()
            Me.tbpElapsedDays.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnOK
            '
            Me.btnOK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnOK.Location = New System.Drawing.Point(202, 360)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(90, 23)
            Me.btnOK.TabIndex = 28
            Me.btnOK.Text = "&OK"
            Me.btnOK.UseVisualStyleBackColor = True
            '
            'btnMinus
            '
            Me.btnMinus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnMinus.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnMinus.Location = New System.Drawing.Point(365, 85)
            Me.btnMinus.Name = "btnMinus"
            Me.btnMinus.Size = New System.Drawing.Size(23, 23)
            Me.btnMinus.TabIndex = 27
            Me.btnMinus.Text = "-"
            Me.btnMinus.UseVisualStyleBackColor = True
            '
            'btnPlus
            '
            Me.btnPlus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnPlus.Location = New System.Drawing.Point(336, 85)
            Me.btnPlus.Name = "btnPlus"
            Me.btnPlus.Size = New System.Drawing.Size(23, 23)
            Me.btnPlus.TabIndex = 26
            Me.btnPlus.Text = "+"
            Me.btnPlus.UseVisualStyleBackColor = True
            '
            'txtResult
            '
            Me.txtResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtResult.Location = New System.Drawing.Point(104, 158)
            Me.txtResult.Name = "txtResult"
            Me.txtResult.ReadOnly = True
            Me.txtResult.Size = New System.Drawing.Size(198, 20)
            Me.txtResult.TabIndex = 32
            Me.txtResult.TabStop = False
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(57, 158)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(40, 13)
            Me.Label3.TabIndex = 31
            Me.Label3.Text = "Result:"
            '
            'txtQuantityTime
            '
            Me.txtQuantityTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtQuantityTime.Location = New System.Drawing.Point(104, 85)
            Me.txtQuantityTime.Name = "txtQuantityTime"
            Me.txtQuantityTime.Size = New System.Drawing.Size(198, 20)
            Me.txtQuantityTime.TabIndex = 25
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(23, 85)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(74, 13)
            Me.Label2.TabIndex = 30
            Me.Label2.Text = "Elapsed Time:"
            '
            'txtBeginningTime
            '
            Me.txtBeginningTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtBeginningTime.Location = New System.Drawing.Point(104, 44)
            Me.txtBeginningTime.Name = "txtBeginningTime"
            Me.txtBeginningTime.Size = New System.Drawing.Size(198, 20)
            Me.txtBeginningTime.TabIndex = 24
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(14, 44)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(83, 13)
            Me.Label1.TabIndex = 29
            Me.Label1.Text = "Beginning Time:"
            '
            'erpMain
            '
            Me.erpMain.ContainerControl = Me
            '
            'tabMain
            '
            Me.tabMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tabMain.Controls.Add(Me.tbpClock)
            Me.tabMain.Controls.Add(Me.tbpElapsed)
            Me.tabMain.Controls.Add(Me.tbpElapsedDays)
            Me.tabMain.Location = New System.Drawing.Point(37, 36)
            Me.tabMain.Name = "tabMain"
            Me.tabMain.SelectedIndex = 0
            Me.tabMain.Size = New System.Drawing.Size(420, 280)
            Me.tabMain.TabIndex = 33
            '
            'tbpClock
            '
            Me.tbpClock.Controls.Add(Me.Label1)
            Me.tbpClock.Controls.Add(Me.txtBeginningTime)
            Me.tbpClock.Controls.Add(Me.btnMinus)
            Me.tbpClock.Controls.Add(Me.Label2)
            Me.tbpClock.Controls.Add(Me.btnPlus)
            Me.tbpClock.Controls.Add(Me.txtQuantityTime)
            Me.tbpClock.Controls.Add(Me.txtResult)
            Me.tbpClock.Controls.Add(Me.Label3)
            Me.tbpClock.Location = New System.Drawing.Point(4, 22)
            Me.tbpClock.Name = "tbpClock"
            Me.tbpClock.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpClock.Size = New System.Drawing.Size(412, 254)
            Me.tbpClock.TabIndex = 0
            Me.tbpClock.Text = "ClockTimes"
            Me.tbpClock.UseVisualStyleBackColor = True
            '
            'tbpElapsed
            '
            Me.tbpElapsed.Controls.Add(Me.Label4)
            Me.tbpElapsed.Controls.Add(Me.txtStartTime)
            Me.tbpElapsed.Controls.Add(Me.Label5)
            Me.tbpElapsed.Controls.Add(Me.btnElapsedTime)
            Me.tbpElapsed.Controls.Add(Me.txtEndTime)
            Me.tbpElapsed.Controls.Add(Me.txtElapsedTime)
            Me.tbpElapsed.Controls.Add(Me.Label6)
            Me.tbpElapsed.Location = New System.Drawing.Point(4, 22)
            Me.tbpElapsed.Name = "tbpElapsed"
            Me.tbpElapsed.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpElapsed.Size = New System.Drawing.Size(412, 254)
            Me.tbpElapsed.TabIndex = 1
            Me.tbpElapsed.Text = "Elapsed Time"
            Me.tbpElapsed.UseVisualStyleBackColor = True
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(39, 44)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(58, 13)
            Me.Label4.TabIndex = 36
            Me.Label4.Text = "Start Time:"
            '
            'txtStartTime
            '
            Me.txtStartTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtStartTime.Location = New System.Drawing.Point(104, 44)
            Me.txtStartTime.Name = "txtStartTime"
            Me.txtStartTime.Size = New System.Drawing.Size(188, 20)
            Me.txtStartTime.TabIndex = 33
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(42, 85)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(55, 13)
            Me.Label5.TabIndex = 37
            Me.Label5.Text = "End Time:"
            '
            'btnElapsedTime
            '
            Me.btnElapsedTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnElapsedTime.Location = New System.Drawing.Point(312, 85)
            Me.btnElapsedTime.Name = "btnElapsedTime"
            Me.btnElapsedTime.Size = New System.Drawing.Size(70, 23)
            Me.btnElapsedTime.TabIndex = 35
            Me.btnElapsedTime.Text = "Calculate"
            Me.btnElapsedTime.UseVisualStyleBackColor = True
            '
            'txtEndTime
            '
            Me.txtEndTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtEndTime.Location = New System.Drawing.Point(104, 85)
            Me.txtEndTime.Name = "txtEndTime"
            Me.txtEndTime.Size = New System.Drawing.Size(188, 20)
            Me.txtEndTime.TabIndex = 34
            '
            'txtElapsedTime
            '
            Me.txtElapsedTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtElapsedTime.Location = New System.Drawing.Point(104, 158)
            Me.txtElapsedTime.Name = "txtElapsedTime"
            Me.txtElapsedTime.ReadOnly = True
            Me.txtElapsedTime.Size = New System.Drawing.Size(188, 20)
            Me.txtElapsedTime.TabIndex = 39
            Me.txtElapsedTime.TabStop = False
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(57, 158)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(40, 13)
            Me.Label6.TabIndex = 38
            Me.Label6.Text = "Result:"
            '
            'tbpElapsedDays
            '
            Me.tbpElapsedDays.BackColor = System.Drawing.Color.Transparent
            Me.tbpElapsedDays.Controls.Add(Me.dtpEndDate)
            Me.tbpElapsedDays.Controls.Add(Me.dtpStartDate)
            Me.tbpElapsedDays.Controls.Add(Me.lblSaturdays)
            Me.tbpElapsedDays.Controls.Add(Me.lblFridays)
            Me.tbpElapsedDays.Controls.Add(Me.lblThursdays)
            Me.tbpElapsedDays.Controls.Add(Me.Label18)
            Me.tbpElapsedDays.Controls.Add(Me.Label19)
            Me.tbpElapsedDays.Controls.Add(Me.Label20)
            Me.tbpElapsedDays.Controls.Add(Me.lblWednesdays)
            Me.tbpElapsedDays.Controls.Add(Me.lblTuesdays)
            Me.tbpElapsedDays.Controls.Add(Me.lblMondays)
            Me.tbpElapsedDays.Controls.Add(Me.lblSundays)
            Me.tbpElapsedDays.Controls.Add(Me.Label10)
            Me.tbpElapsedDays.Controls.Add(Me.Label9)
            Me.tbpElapsedDays.Controls.Add(Me.Label12)
            Me.tbpElapsedDays.Controls.Add(Me.Label11)
            Me.tbpElapsedDays.Controls.Add(Me.Label7)
            Me.tbpElapsedDays.Controls.Add(Me.Label8)
            Me.tbpElapsedDays.Controls.Add(Me.btnElapsedDays)
            Me.tbpElapsedDays.Location = New System.Drawing.Point(4, 22)
            Me.tbpElapsedDays.Name = "tbpElapsedDays"
            Me.tbpElapsedDays.Size = New System.Drawing.Size(412, 254)
            Me.tbpElapsedDays.TabIndex = 2
            Me.tbpElapsedDays.Text = "Elapsed Days"
            '
            'dtpEndDate
            '
            Me.dtpEndDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dtpEndDate.Location = New System.Drawing.Point(104, 87)
            Me.dtpEndDate.Name = "dtpEndDate"
            Me.dtpEndDate.Size = New System.Drawing.Size(188, 20)
            Me.dtpEndDate.TabIndex = 61
            '
            'dtpStartDate
            '
            Me.dtpStartDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dtpStartDate.Location = New System.Drawing.Point(104, 44)
            Me.dtpStartDate.Name = "dtpStartDate"
            Me.dtpStartDate.Size = New System.Drawing.Size(188, 20)
            Me.dtpStartDate.TabIndex = 60
            '
            'lblSaturdays
            '
            Me.lblSaturdays.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSaturdays.AutoSize = True
            Me.lblSaturdays.Location = New System.Drawing.Point(298, 175)
            Me.lblSaturdays.Name = "lblSaturdays"
            Me.lblSaturdays.Size = New System.Drawing.Size(0, 13)
            Me.lblSaturdays.TabIndex = 59
            '
            'lblFridays
            '
            Me.lblFridays.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblFridays.AutoSize = True
            Me.lblFridays.Location = New System.Drawing.Point(298, 162)
            Me.lblFridays.Name = "lblFridays"
            Me.lblFridays.Size = New System.Drawing.Size(0, 13)
            Me.lblFridays.TabIndex = 58
            '
            'lblThursdays
            '
            Me.lblThursdays.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblThursdays.AutoSize = True
            Me.lblThursdays.Location = New System.Drawing.Point(298, 149)
            Me.lblThursdays.Name = "lblThursdays"
            Me.lblThursdays.Size = New System.Drawing.Size(0, 13)
            Me.lblThursdays.TabIndex = 57
            '
            'Label18
            '
            Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label18.AutoSize = True
            Me.Label18.Location = New System.Drawing.Point(235, 175)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(57, 13)
            Me.Label18.TabIndex = 55
            Me.Label18.Text = "Saturdays:"
            '
            'Label19
            '
            Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(249, 162)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(43, 13)
            Me.Label19.TabIndex = 54
            Me.Label19.Text = "Fridays:"
            '
            'Label20
            '
            Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label20.AutoSize = True
            Me.Label20.Location = New System.Drawing.Point(233, 149)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(59, 13)
            Me.Label20.TabIndex = 53
            Me.Label20.Text = "Thursdays:"
            '
            'lblWednesdays
            '
            Me.lblWednesdays.AutoSize = True
            Me.lblWednesdays.Location = New System.Drawing.Point(147, 188)
            Me.lblWednesdays.Name = "lblWednesdays"
            Me.lblWednesdays.Size = New System.Drawing.Size(0, 13)
            Me.lblWednesdays.TabIndex = 52
            '
            'lblTuesdays
            '
            Me.lblTuesdays.AutoSize = True
            Me.lblTuesdays.Location = New System.Drawing.Point(147, 175)
            Me.lblTuesdays.Name = "lblTuesdays"
            Me.lblTuesdays.Size = New System.Drawing.Size(0, 13)
            Me.lblTuesdays.TabIndex = 51
            '
            'lblMondays
            '
            Me.lblMondays.AutoSize = True
            Me.lblMondays.Location = New System.Drawing.Point(147, 162)
            Me.lblMondays.Name = "lblMondays"
            Me.lblMondays.Size = New System.Drawing.Size(0, 13)
            Me.lblMondays.TabIndex = 50
            '
            'lblSundays
            '
            Me.lblSundays.AutoSize = True
            Me.lblSundays.Location = New System.Drawing.Point(147, 149)
            Me.lblSundays.Name = "lblSundays"
            Me.lblSundays.Size = New System.Drawing.Size(0, 13)
            Me.lblSundays.TabIndex = 49
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(69, 188)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(72, 13)
            Me.Label10.TabIndex = 48
            Me.Label10.Text = "Wednesdays:"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(85, 175)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(56, 13)
            Me.Label9.TabIndex = 47
            Me.Label9.Text = "Tuesdays:"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(88, 162)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(53, 13)
            Me.Label12.TabIndex = 46
            Me.Label12.Text = "Mondays:"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(90, 149)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(51, 13)
            Me.Label11.TabIndex = 45
            Me.Label11.Text = "Sundays:"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(39, 44)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(58, 13)
            Me.Label7.TabIndex = 43
            Me.Label7.Text = "Start Date:"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(42, 85)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(55, 13)
            Me.Label8.TabIndex = 44
            Me.Label8.Text = "End Date:"
            '
            'btnElapsedDays
            '
            Me.btnElapsedDays.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnElapsedDays.Location = New System.Drawing.Point(312, 85)
            Me.btnElapsedDays.Name = "btnElapsedDays"
            Me.btnElapsedDays.Size = New System.Drawing.Size(70, 23)
            Me.btnElapsedDays.TabIndex = 42
            Me.btnElapsedDays.Text = "Calculate"
            Me.btnElapsedDays.UseVisualStyleBackColor = True
            '
            'CalculatorConsole
            '
            Me.AcceptButton = Me.btnPlus
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnOK
            Me.ClientSize = New System.Drawing.Size(484, 439)
            Me.Controls.Add(Me.tabMain)
            Me.Controls.Add(Me.btnOK)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MinimumSize = New System.Drawing.Size(500, 475)
            Me.Name = "CalculatorConsole"
            Me.Text = "Time Calculator"
            CType(Me.erpMain, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabMain.ResumeLayout(False)
            Me.tbpClock.ResumeLayout(False)
            Me.tbpClock.PerformLayout()
            Me.tbpElapsed.ResumeLayout(False)
            Me.tbpElapsed.PerformLayout()
            Me.tbpElapsedDays.ResumeLayout(False)
            Me.tbpElapsedDays.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnOK As System.Windows.Forms.Button
        Friend WithEvents btnMinus As System.Windows.Forms.Button
        Friend WithEvents btnPlus As System.Windows.Forms.Button
        Friend WithEvents txtResult As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtQuantityTime As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtBeginningTime As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents erpMain As System.Windows.Forms.ErrorProvider
        Friend WithEvents tabMain As System.Windows.Forms.TabControl
        Friend WithEvents tbpClock As System.Windows.Forms.TabPage
        Friend WithEvents tbpElapsed As System.Windows.Forms.TabPage
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtStartTime As System.Windows.Forms.TextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents btnElapsedTime As System.Windows.Forms.Button
        Friend WithEvents txtEndTime As System.Windows.Forms.TextBox
        Friend WithEvents txtElapsedTime As System.Windows.Forms.TextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents tbpElapsedDays As System.Windows.Forms.TabPage
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents btnElapsedDays As System.Windows.Forms.Button
        Friend WithEvents lblSaturdays As System.Windows.Forms.Label
        Friend WithEvents lblFridays As System.Windows.Forms.Label
        Friend WithEvents lblThursdays As System.Windows.Forms.Label
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents lblWednesdays As System.Windows.Forms.Label
        Friend WithEvents lblTuesdays As System.Windows.Forms.Label
        Friend WithEvents lblMondays As System.Windows.Forms.Label
        Friend WithEvents lblSundays As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    End Class

End Namespace