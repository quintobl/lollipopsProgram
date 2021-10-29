' ************************************************************************************
' Brad Quinton
' July 31, 2020
' Final Project - Lollipops4me Company Payroll
' This form is the "main" form for this assignment.  It allows the HR rep to choose
' to go to the salary employee form or the hourly employee form.
' ************************************************************************************


Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' This button closes the main program.
        Close()

    End Sub




    Private Sub btnSalary_Click(sender As Object, e As EventArgs) Handles btnSalary.Click

        ' This creates a new instance of frmSalaried.
        Dim Salaried As New frmSalaried

        ' This shows the new instance of frmSalaried form modally (i.e., the new instance stays in
        ' the forefront on the screen until the form is exited).
        Salaried.ShowDialog()

    End Sub




    Private Sub btnHourly_Click(sender As Object, e As EventArgs) Handles btnHourly.Click

        ' This creates a new instance of frmHourly.
        Dim Hourly As New frmHourly

        ' This shows the new instance of frmHourly form modally (i.e., the new instance stays in
        ' the forefront on the screen until the form is exited).
        Hourly.ShowDialog()

    End Sub




    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        ' This calls the Exit button subroutine.
        btnExit_Click(sender, e)

    End Sub




    Private Sub SalariedEmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalariedEmployeesToolStripMenuItem.Click

        ' This calls the Salaried Employees button subroutine.
        btnSalary_Click(sender, e)

    End Sub




    Private Sub HourlyEmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HourlyEmployeesToolStripMenuItem.Click

        ' This calls the Hourly Employees button subroutine.
        btnHourly_Click(sender, e)

    End Sub

End Class
