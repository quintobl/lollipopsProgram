﻿' *****************************************************************************************
' Brad Quinton
' July 31, 2020
' Final Project - Lollipops4me Company Payroll
' This form is the "hourly" form for this assignment.  It allows the HR rep to enter
' wage info for the employee, and it outputs the weekly payment info for that employee.
' *****************************************************************************************


Public Class frmHourly
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' This button closes this program.
        Close()

    End Sub




    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' This changes all text boxes to white backcolor in case they are yellow.  They will become
        ' yellow when the user enters something into the textbox that is not validated.
        txtFirstName.BackColor = Color.White
        txtLastName.BackColor = Color.White
        txtHourlyWage.BackColor = Color.White
        txtHoursWorked.BackColor = Color.White
        txtGrossPayToDate.BackColor = Color.White

        ' Clears out the list box control.
        lstOutput.Items.Clear()

        ' Clears out text box controls when "Clear" button is clicked.
        txtFirstName.Clear()
        txtLastName.Clear()
        txtHourlyWage.Clear()
        txtHoursWorked.Clear()
        txtGrossPayToDate.Clear()

        ' Sets the focus into the first text box (i.e., the one for first name) when "Clear" 
        ' button is clicked.
        txtFirstName.Focus()

        ' This makes the "Indiana" radio button the default radio button when the "Clear" button is clicked.
        radIndiana.Checked = True

    End Sub




    ' This function validates the input in each textbox on this form.  If one of the inputs is invalidated, then no
    ' calculations will take place.
    Function ValidateInput(ByRef FirstName As String, ByRef LastName As String, ByRef HourlyWage As Double,
                           ByRef HoursWorked As Double, ByRef GrossPayToDate As Double) As Boolean

        If ValidateFirstName(FirstName) = True Then
            If ValidateLastName(LastName) = True Then
                If ValidateHourlyWage(HourlyWage) = True Then
                    If ValidateHoursWorked(HoursWorked) Then
                        If ValidateGrossPayToDate(GrossPayToDate) = True Then
                            Return True
                        Else
                            Return False
                        End If
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function




    Function ValidateFirstName(ByRef FirstName As String) As Boolean

        ' This validates whether a string is entered into the first text box (i.e., the text box for
        ' the first name).  The data type is string.  If nothing is entered, a message box will pop
        ' up asking the user to enter a first name.
        If txtFirstName.Text = String.Empty Then
            MessageBox.Show("Please enter first name.") ' Error message box pops up.
            txtFirstName.BackColor = Color.Yellow ' Changes the back color on text box to yellow with error.
            txtFirstName.Focus() ' This puts the focus in the textbox with the error preserved.
            Return False
        Else
            FirstName = txtFirstName.Text ' This puts the string into the text box.
            Return True
        End If

    End Function




    Function ValidateLastName(ByRef LastName As String) As Boolean

        ' This validates whether a string is entered into the second text box (i.e., the text box for
        ' the last name).  The data type is string.  If nothing is entered, a message box will pop
        ' up asking the user to enter a last name.
        If txtLastName.Text = String.Empty Then
            MessageBox.Show("Please enter last name.") ' Error message box pops up.
            txtLastName.BackColor = Color.Yellow ' Changes the back color on text box to yellow with error.
            txtLastName.Focus() ' This puts the focus in the textbox with the error preserved.
            Return False
        Else
            LastName = txtLastName.Text ' This puts the string into the text box.
            Return True
        End If

    End Function




    Function ValidateHourlyWage(ByRef HourlyWage As Double) As Boolean

        ' This validates whether a number is entered into textbox 3 (i.e., "Hourly Wage" box),
        ' and whether the number is greater than or equal to 0.  The data type is numeric.  If something 
        ' other than a number is entered, a message box will pop.  If the number entered is less than 0,
        ' another error message will pop.
        If IsNumeric(txtHourlyWage.Text) Then ' Checks whether what is entered into the textbox is a number.
            If txtHourlyWage.Text < 0 Then
                MessageBox.Show("Please enter number greater than or equal to 0.") ' Error message pops up.
                txtHourlyWage.BackColor = Color.Yellow ' This changes back color of textbox to yellow if error.
                txtHourlyWage.Focus() ' This puts the focus in the textbox with the error preserved.
                Return False ' This will ensure that validation of the hourly wage does not occur if value entered is less than 0.
            Else
                HourlyWage = txtHourlyWage.Text ' Puts what gets entered into the textbox into the variable.
                Return True ' This will ensure that validation of the hourly wage occurs if value entered is greater than/eqaul to 0.
            End If
        ElseIf txtHourlyWage.Text = String.Empty Then
            MessageBox.Show("Please enter numbers only.") ' Error message box pops up.
            txtHourlyWage.BackColor = Color.Yellow ' Changes the back color on text box to yellow with error.
            txtHourlyWage.Focus() ' This puts the focus in the textbox with the error preserved.
            Return False ' This will ensure that validation of the hourly wage does not occur if nothing is entered into the textbox.
        Else
            MessageBox.Show("Please enter numbers only.") ' Error message pops up.
            txtHourlyWage.BackColor = Color.Yellow ' This changes back color of textbox to yellow if error.
            txtHourlyWage.Focus() ' This puts the focus in the textbox with the error preserved.
            Return False ' This will ensure that validation of the hourly wage does not occur if something other than a number is entered.
        End If

    End Function




    Function ValidateHoursWorked(ByRef HoursWorked As Double) As Boolean

        ' This validates whether a number is entered into textbox 4 (i.e., "Hours Worked" box),
        ' and whether the number is greater than or equal to 0.  The data type is numeric.  If something 
        ' other than a number is entered, a message box will pop.  If the number entered is less than 0,
        ' another error message will pop.
        If IsNumeric(txtHoursWorked.Text) Then ' Checks whether what is entered into the textbox is a number.
            If txtHoursWorked.Text < 0 Then
                MessageBox.Show("Please enter number greater than or equal to 0.") ' Error message pops up.
                txtHoursWorked.BackColor = Color.Yellow ' This changes back color of textbox to yellow if error.
                txtHoursWorked.Focus() ' This puts the focus in the textbox with the error preserved.
                Return False ' This will ensure that validation of the hours worked does not occur if value entered is less than 0.
            Else
                HoursWorked = txtHoursWorked.Text ' Puts what gets entered into the textbox into the variable.
                Return True ' This will ensure that validation of the hours worked occurs if value entered is greater than/eqaul to 0.
            End If
        ElseIf txtHoursWorked.Text = String.Empty Then
            MessageBox.Show("Please enter numbers only.") ' Error message box pops up.
            txtHoursWorked.BackColor = Color.Yellow ' Changes the back color on text box to yellow with error.
            txtHoursWorked.Focus() ' This puts the focus in the textbox with the error preserved.
            Return False ' This will ensure that validation of the hours worked does not occur if nothing is entered into the textbox.
        Else
            MessageBox.Show("Please enter numbers only.") ' Error message pops up.
            txtHoursWorked.BackColor = Color.Yellow ' This changes back color of textbox to yellow if error.
            txtHoursWorked.Focus() ' This puts the focus in the textbox with the error preserved.
            Return False ' This will ensure that validation of the hours worked does not occur if something other than a number is entered.
        End If

    End Function




    Function ValidateGrossPayToDate(ByRef GrossPayToDate As Double) As Boolean

        ' This validates whether a number is entered into textbox 5 (i.e., "Gross Pay To Date" box),
        ' and whether the number is greater than or equal to 0.  The data type is numeric.  If something 
        ' other than a number is entered, a message box will pop.  If the number entered is less than 0,
        ' another error message will pop.
        If IsNumeric(txtGrossPayToDate.Text) Then ' Checks whether what is entered into the textbox is a number.
            If txtGrossPayToDate.Text < 0 Then
                MessageBox.Show("Please enter number greater than or equal to 0.") ' Error message pops up.
                txtGrossPayToDate.BackColor = Color.Yellow ' This changes back color of textbox to yellow if error.
                txtGrossPayToDate.Focus() ' This puts the focus in the textbox with the error preserved.
                Return False ' This will ensure that validation of the gross pay to date does not occur if value entered is less than 0.
            Else
                GrossPayToDate = txtGrossPayToDate.Text ' Puts what gets entered into the textbox into the variable.
                Return True ' This will ensure that validation of the gross pay to date occurs if value entered is greater than/eqaul to 0.
            End If
        ElseIf txtGrossPayToDate.Text = String.Empty Then
            MessageBox.Show("Please enter numbers only.") ' Error message box pops up.
            txtGrossPayToDate.BackColor = Color.Yellow ' Changes the back color on text box to yellow with error.
            txtGrossPayToDate.Focus() ' This puts the focus in the textbox with the error preserved.
            Return False ' This will ensure that validation of the gross pay to date does not occur if nothing is entered into the textbox.
        Else
            MessageBox.Show("Please enter numbers only.") ' Error message pops up.
            txtGrossPayToDate.BackColor = Color.Yellow ' This changes back color of textbox to yellow if error.
            txtGrossPayToDate.Focus() ' This puts the focus in the textbox with the error preserved.
            Return False ' This will ensure that validation of the gross pay to date does not occur if something other than a number is entered.
        End If

    End Function




    ' This function calculates the gross pay per week for an hourly employee.
    Function CalcGrossPay(ByVal HourlyWage As Double, ByVal HoursWorked As Double) As Double

        ' This creates the variable for the weekly gross pay.
        Dim dblGrossPay As Double

        ' This calculates the employee's weekly gross pay by taking the hours worked and multiplying by
        ' the wage.  This also takes into account any overtime that the employee works.  If the employee
        ' works over 40 hours per week, the employee will be paid time-and-a-half for all hours worked
        ' over 40.
        If HoursWorked <= 40 Then
            dblGrossPay = HourlyWage * HoursWorked
        Else
            dblGrossPay = (HourlyWage * 40) + ((HourlyWage + (HourlyWage / 2)) * (HoursWorked - 40))
        End If

        ' This returns the value for the weekly gross pay.
        Return dblGrossPay

    End Function




    ' This function calculates the state tax, based on requirements in the assignment.
    Function CalcStateTax(ByVal GrossPay As Double) As Double

        ' This creates the variable for the state tax.
        Dim dblStateTax As Double

        ' This calculates the state tax for each state in the group box on the form.
        If radIndiana.Checked = True Then
            dblStateTax = GrossPay * dblIndianaTaxRate
        ElseIf radKentucky.Checked = True Then
            dblStateTax = GrossPay * dblKentuckyTaxRate
        ElseIf radOhio.Checked = True Then
            dblStateTax = GrossPay * dblOhioTaxRate
        End If

        ' This returns the state tax amount.
        Return dblStateTax

    End Function




    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' This creates the variables local to this particular private sub.             
        Dim dblGrossPay As Double
        Dim dblSocialSecurity As Double
        Dim dblMedicare As Double
        Dim dblFICA As Double
        Dim dblStateTax As Double
        Dim dblFederalTotal As Double
        Dim dblNetPay As Double
        Dim dblHourlyWage As Double
        Dim dblHoursWorked As Double


        ' This changes all text boxes to white backcolor in case they are yellow.  They will become
        ' yellow when the user enters something into the textbox that is not validated.
        txtFirstName.BackColor = Color.White
        txtLastName.BackColor = Color.White
        txtHourlyWage.BackColor = Color.White
        txtHoursWorked.BackColor = Color.White
        txtGrossPayToDate.BackColor = Color.White

        ' This if statement validates the input in each textbox on this form.  If the input is not validated,
        ' then none of the calculations will take place.  Each calculation function from this form and the module
        ' is called in this if statement.
        If ValidateInput(strFirstName, strLastName, dblHourlyWage, dblHoursWorked, dblGrossPayToDate) = True Then

            ' This calculates the weekly gross pay.
            dblGrossPay = CalcGrossPay(dblHourlyWage, dblHoursWorked)

            ' This calculates the Social Security tax.
            dblSocialSecurity = CalcSocialSecurity(dblGrossPay, dblGrossPayToDate)

            ' This calculates the Medicare tax.
            dblMedicare = CalcMedicare(dblGrossPay)

            ' This calculates the FICA tax, which is the sum of the Social Security and Medicare taxes.
            dblFICA = CalcFICA(dblSocialSecurity, dblMedicare)

            ' The calculates the state tax.
            dblStateTax = CalcStateTax(dblGrossPay)

            ' This calculates the federal tax.
            dblFederalTotal = CalcFederal(dblGrossPay)

            ' This calculates the net pay.
            dblNetPay = CalcNetPay(dblGrossPay, dblFICA, dblStateTax, dblFederalTotal)

            ' This ensures that the net pay, FICA, state tax, federal tax, and gross pay will display in the list box.
            Display(dblNetPay, dblFICA, dblStateTax, dblFederalTotal, dblGrossPay)

        End If

    End Sub




    Private Sub Display(ByVal NetPay As Double, ByVal FICA As Double, ByVal State As Double, ByVal Federal As Double,
                        ByVal GrossPay As Double)

        ' This displays the hourly wage and gross pay to date values as currency on the form in the textboxes.
        txtHourlyWage.Text = FormatCurrency(txtHourlyWage.Text)
        txtGrossPayToDate.Text = FormatCurrency(txtGrossPayToDate.Text)

        ' This displays the amounts formatted with headers and separaters, in the listbox on the form.  I left enough white
        ' space on the right of each calculated amount in the listbox, in case the values entered got to be really large.
        lstOutput.Items.Add("Net Pay:" & vbTab & vbTab & vbTab & vbTab & vbTab & NetPay.ToString("c"))
        lstOutput.Items.Add("")
        lstOutput.Items.Add("FICA:" & vbTab & vbTab & vbTab & vbTab & vbTab & FICA.ToString("c"))
        lstOutput.Items.Add("")
        lstOutput.Items.Add("State Tax:" & vbTab & vbTab & vbTab & vbTab & State.ToString("c"))
        lstOutput.Items.Add("")
        lstOutput.Items.Add("Federal Tax:" & vbTab & vbTab & vbTab & vbTab & Federal.ToString("c"))
        lstOutput.Items.Add("")
        lstOutput.Items.Add("Gross Pay:" & vbTab & vbTab & vbTab & vbTab & GrossPay.ToString("c"))
        lstOutput.Items.Add("")
        lstOutput.Items.Add("-------------------------------------------------------------------------------------------------------------------------")

    End Sub




    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click

        ' This calls the Clear button subroutine.
        btnClear_Click(sender, e)

    End Sub




    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        ' This calls the Exit button subroutine.
        btnExit_Click(sender, e)

    End Sub




    Private Sub CalculateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateToolStripMenuItem.Click

        ' This calls the Calculate button subroutine
        btnCalculate_Click(sender, e)

    End Sub

End Class