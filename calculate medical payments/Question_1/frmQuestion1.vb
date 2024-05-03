REM EXAMINATION NUMBER:____________
REM WORKSTATION NUMBER:____________
REM EXAMINATION   DATE:____________

Option Explicit On
Option Strict On

Public Class frmQuestion1

    Private Sub btnClearMedScheme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearMedScheme.Click
        'clear all the medical scheme values
        txtAge.Text = ""
        txtNoDependants.Text = ""
        radCopper.Checked = True

    End Sub

    Private Sub btnCalcMedicalPayments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcMedicalPayments.Click

        '-----
        ' Question 1.1.1 - declare variables to be used
        '-----
        Dim intAge As Integer
        Dim intNumberofDependents As Integer
        Dim decMonthlyInstallment As Decimal
        Dim decDependentPercentage As Decimal
        Dim decFP As Decimal




        '----
        ' Question 1.1.2 - validate input (user must enter a value for both age and dependents
        '----

        If txtAge.Text = "" Then
            MessageBox.Show("please enter your Age", "ERROR")


        ElseIf txtNoDependants.Text = "" Then
            MessageBox.Show("please enter Number of Dependents", "ERROR")
        End If

        '---
        ' Question 1.1.3 - convert the supplied inputs to integer values
        '---
        ' Convert the supplied inputs to integer values
        If Not Integer.TryParse(txtAge.Text, intAge) OrElse Not Integer.TryParse(txtNoDependants.Text, intNumberofDependents) Then
            MessageBox.Show("Invalid input for age or number of dependents. Please enter correct integer values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        intAge = CInt(txtAge.Text)
        intNumberofDependents = CInt(txtNoDependants.Text)

        ' Question 1.1.4 - Nested IF's to calculate final medical scheme payment
        '---
        If radGold.Checked Then
            If intAge < 35 Then
                decMonthlyInstallment = 1500D
                decDependentPercentage = 0.45D
            Else
                decMonthlyInstallment = 1800D
                decDependentPercentage = 0.45D
            End If
        ElseIf radSilver.Checked Then
            If intAge < 35 Then
                decMonthlyInstallment = 1100D
                decDependentPercentage = 0.35D
            Else
                decMonthlyInstallment = 1400D
                decDependentPercentage = 0.35D
            End If
        ElseIf radCopper.Checked Then
            If intAge < 35 Then
                decMonthlyInstallment = 750D
                decDependentPercentage = 0.25D
            Else
                decMonthlyInstallment = 900D
                decDependentPercentage = 0.25D
            End If
        End If
        '---
        decFP = decMonthlyInstallment + (decMonthlyInstallment * decDependentPercentage) * intNumberofDependents
        MessageBox.Show("Final Monthly Installment: R" & decFP.ToString("C2"), "Monthly Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub




    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmQuestion1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class
