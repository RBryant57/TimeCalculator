Imports System.Text.RegularExpressions

Imports local.YellowCaddis.TimeCalculator.Core
Imports local.YellowCaddis.TimeCalculator.Core.Constants

Namespace local.YellowCaddis.TimeCalculator.Console

    Public Class CalculatorConsole
        ' This class provides the UI for the time calculator. 
        ' It is a publically available form.
        '====================================================

#Region "Declarations"

        Private dayLabels As List(Of Control)

#End Region

#Region "Constructors"

        Public Sub New()
            ' The default constructor will order the event handlers properly.
            '================================================================

            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            AddHandler btnElapsedTime.Click, AddressOf Me.clearForm_TextChanged
            AddHandler btnElapsedTime.Click, AddressOf Me.btnElapsedTime_Click
            AddHandler btnMinus.Click, AddressOf Me.clearForm_TextChanged
            AddHandler btnMinus.Click, AddressOf Me.btnMinus_Click
            AddHandler btnPlus.Click, AddressOf Me.clearForm_TextChanged
            AddHandler btnPlus.Click, AddressOf Me.btnPlus_Click


            Me.dayLabels = New List(Of Control)
            Me.dayLabels.Add(Me.lblSundays)
            Me.dayLabels.Add(Me.lblMondays)
            Me.dayLabels.Add(Me.lblTuesdays)
            Me.dayLabels.Add(Me.lblWednesdays)
            Me.dayLabels.Add(Me.lblThursdays)
            Me.dayLabels.Add(Me.lblFridays)
            Me.dayLabels.Add(Me.lblSaturdays)

        End Sub

#End Region

#Region "Form Event Handlers"

        Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

            Me.Close()

        End Sub

        Private Sub btnPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Dim calc As New Calculator

            If Not Regex.IsMatch(Me.txtBeginningTime.Text, Constants.REGEX_TIME) Then
                Me.erpMain.SetError(Me.txtBeginningTime, Constants.TIME_ERROR)
                Me.txtBeginningTime.Focus()
                Return
            End If
            If Not Regex.IsMatch(Me.txtQuantityTime.Text, Constants.REGEX_TIME) Then
                Me.erpMain.SetError(Me.txtQuantityTime, Constants.TIME_ERROR)
                Me.txtQuantityTime.Focus()
                Return
            End If

            Try
                Me.txtResult.Text = Convert.ToString(calc.Add(Me.txtBeginningTime.Text, Me.txtQuantityTime.Text).ToLongTimeString)
            Catch ex As Exception
                MessageBox.Show(ex.Message, Constants.TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Sub

        Private Sub btnMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Dim calc As New Calculator

            If Not Regex.IsMatch(Me.txtBeginningTime.Text, Constants.REGEX_TIME) Then
                Me.erpMain.SetError(Me.txtBeginningTime, Constants.TIME_ERROR)
                Me.txtBeginningTime.Focus()
                Return
            End If
            If Not Regex.IsMatch(Me.txtQuantityTime.Text, Constants.REGEX_TIME) Then
                Me.erpMain.SetError(Me.txtQuantityTime, Constants.TIME_ERROR)
                Me.txtQuantityTime.Focus()
                Return
            End If

            Try
                Me.txtResult.Text = Convert.ToString(calc.Subtract(Me.txtBeginningTime.Text, Me.txtQuantityTime.Text).ToLongTimeString)
            Catch ex As Exception
                MessageBox.Show(ex.Message, Constants.TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Sub

        Private Sub clearForm_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtBeginningTime.TextChanged, txtQuantityTime.TextChanged, txtStartTime.TextChanged, txtEndTime.TextChanged

            Me.erpMain.Clear()

        End Sub

        Private Sub btnElapsedTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Dim calc As New Calculator

            If Not Regex.IsMatch(Me.txtStartTime.Text, Constants.REGEX_TIME) Then
                Me.erpMain.SetError(Me.txtStartTime, Constants.TIME_ERROR)
                Me.txtStartTime.Focus()

                Return
            End If
            If Not Regex.IsMatch(Me.txtEndTime.Text, Constants.REGEX_TIME) Then
                Me.erpMain.SetError(Me.txtEndTime, Constants.TIME_ERROR)
                Me.txtEndTime.Focus()
                Return
            End If

            Try
                Dim elapsedTime As String

                elapsedTime = calc.Elapsed(Me.txtStartTime.Text, Me.txtEndTime.Text)

                Me.txtElapsedTime.Text = elapsedTime

            Catch ex As Exception
                MessageBox.Show(ex.Message, Constants.TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Sub

        Private Sub btnElapsedDays_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElapsedDays.Click
            Dim span As TimeSpan = Me.dtpEndDate.Value - Me.dtpStartDate.Value
            Dim startDay As Integer = Me.dtpStartDate.Value.DayOfWeek
            Dim endDay As Integer = Me.dtpEndDate.Value.DayOfWeek
            Dim days As Integer = span.TotalDays

            Dim weeks As Integer = Math.Floor(days / 7)
            Dim partialWeeks As Integer = days Mod 7
            Dim weekdaySpan As Integer = endDay - partialWeeks

            If startDay > endDay Then
                For i = 0 To Me.dayLabels.Count - 1
                    If i <= endDay Then
                        Me.dayLabels(i).Text = weeks + 1
                    ElseIf i >= startDay Then
                        Me.dayLabels(i).Text = weeks + 1
                    Else
                        Me.dayLabels(i).Text = weeks
                    End If
                Next
            ElseIf startDay < endDay Then
                For i = 0 To Me.dayLabels.Count - 1
                    If i < startDay Then
                        Me.dayLabels(i).Text = weeks
                    ElseIf i >= startDay And i <= endDay Then
                        Me.dayLabels(i).Text = weeks + 1
                    Else
                        Me.dayLabels(i).Text = weeks
                    End If
                Next
            Else
                For i = 0 To Me.dayLabels.Count - 1
                    Me.dayLabels(i).Text = weeks
                Next
            End If

        End Sub

#End Region

    End Class

End Namespace