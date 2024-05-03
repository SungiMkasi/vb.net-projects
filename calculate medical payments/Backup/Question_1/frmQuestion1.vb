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


        '----
        ' Question 1.1.2 - validate input (user must enter a value for both age and dependents
        '----
        


        '---
        ' Question 1.1.3 - convert the supplied inputs to integer values
        '---





        '---
        ' Question 1.1.4 - Nested IF's to calculate final medical scheme payment
        '---
        

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmQuestion1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
