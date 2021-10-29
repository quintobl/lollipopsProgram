' *****************************************************************************************
' Brad Quinton
' July 31, 2020
' Final Project - Lollipops4me Company Payroll
' This form is the "module" form for this assignment.  It serves as a place where 
' functions that are used on multiple forms can be stored.
' *****************************************************************************************

Module LollipopsModule

    ' This section is for the creation of public variables that can be seen on all forms.

    ' These are for gross pay and gross pay to date.
    Public dblGrossPay As Double
    Public dblGrossPayToDate As Double

    ' These are for the State taxes.
    Public dblIndianaTaxRate As Double = 0.055
    Public dblKentuckyTaxRate As Double = 0.06
    Public dblOhioTaxRate As Double = 0.065
    Public dblStateTax As Double

    ' These are for Federal taxes.
    Public intFederalTaxTopTierTotal As Double = 845
    Public intFederalTaxMiddleTierTotal As Double = 345
    Public intFederalTaxLowTierTotal As Double = 45
    Public dblFederalTax25PercentRate As Double = 0.25
    Public dblFederalTax20PercentRate As Double = 0.2
    Public dblFederalTax15PercentRate As Double = 0.15
    Public dblFederalTax10PercentRate As Double = 0.1
    Public dblFederalTotal As Double

    ' These are for first and last name strings.
    Public strFirstName As String
    Public strLastName As String

    ' This is for the yearly salary.      
    Public dblYearlySalary As Double




    ' This public function calculates Social Security taxes on the gross pay.  It is public because it needs
    ' to be seen on the salary and hourly forms.
    Public Function CalcSocialSecurity(ByVal GrossPay As Double, ByVal GrossPayToDate As Double) As Double

        ' This creates variables local to this function.
        Const dblSocialSecurityTaxRate As Double = 0.062
        Const intSocialSecurityMaximum As Integer = 125000
        Dim dblSocialSecurity As Double

        ' This if/else-statement returns the social security tax.  If the gross pay to date is less than $125,000,
        ' then the program will check if this week's paycheck gross pay + the gross pay to date is less than $125,000.
        ' If that sum is less than $125,000, then the Social Security tax will be given by multiplying the Social
        ' Security rate of 6.2% by this week's gross pay.  If that sum, however, is greater than or equal to
        ' $125,000, then the Social Security tax will be given by multiplying the Social Security rate of 6.2% by
        ' the difference between the maximum of $125,000 and the gross pay to date.  If the gross pay to date is
        ' greater than or equal to the maximum of $125,000, then the Social Security tax will be $0.00.
        If GrossPayToDate < intSocialSecurityMaximum Then
            If (GrossPay + GrossPayToDate) < intSocialSecurityMaximum Then
                dblSocialSecurity = dblSocialSecurityTaxRate * GrossPay
            ElseIf (GrossPay + GrossPayToDate) >= intSocialSecurityMaximum Then
                dblSocialSecurity = dblSocialSecurityTaxRate * (intSocialSecurityMaximum - GrossPayToDate)
            End If
        ElseIf GrossPayToDate >= intSocialSecurityMaximum Then
            dblSocialSecurity = 0
        End If

        ' This returns the calculated Social Security tax figure.
        Return dblSocialSecurity

    End Function




    ' This public function calculates Medicare tax on the gross pay.  It is public because it needs
    ' to be seen on the hourly and salary forms.
    Public Function CalcMedicare(ByVal GrossPay As Double) As Double

        Const dblMedicareTaxRate As Double = 0.0145
        Dim dblMedicare As Double

        ' This calculates the Medicare tax the employee pays on his/her gross pay.
        dblMedicare = GrossPay * dblMedicareTaxRate

        ' This returns the calculated Medicare tax figure.
        Return dblMedicare

    End Function




    ' This public function calculates FICA on the gross pay (FICA is the sum of Social Security tax and Medicare tax).
    ' It is public because it needs to be seen on the hourly and salary forms.
    Public Function CalcFICA(ByVal SocialSecurity As Double, ByVal Medicare As Double) As Double

        Dim dblFICA As Double

        ' This calculates the FICA total.
        dblFICA = SocialSecurity + Medicare

        ' This returns the calculated FICA figure.
        Return dblFICA

    End Function



    ' This public function calculates the Federal tax.  ' It is public because it needs to be seen on the 
    ' hourly and salary forms.
    Public Function CalcFederal(ByVal GrossPay As Double) As Double

        ' This creates the variables local to this function.  The tax tier totals are the constant dollar amounts
        ' that get added to each tax amount in each separate tax tier.  The rates are percentages of certain 
        ' dollar amounts, based on requirements.
        Dim dblFederalTotal As Double
        Const intFederalTaxTopTierTotal As Double = 845
        Const intFederalTaxMiddleTierTotal As Double = 345
        Const intFederalTaxLowTierTotal As Double = 45
        Const dblFederalTax25PercentRate As Double = 0.25
        Const dblFederalTax20PercentRate As Double = 0.2
        Const dblFederalTax15PercentRate As Double = 0.15
        Const dblFederalTax10PercentRate As Double = 0.1

        ' These if/elseif statements calculate the federal tax based on tiered requirements.
        If GrossPay > 5000 Then
            dblFederalTotal = intFederalTaxTopTierTotal + (dblFederalTax25PercentRate * (GrossPay - 5000))
        ElseIf GrossPay > 2500 Then
            dblFederalTotal = intFederalTaxMiddleTierTotal + (dblFederalTax20PercentRate * (GrossPay - 2500))
        ElseIf GrossPay > 500 Then
            dblFederalTotal = intFederalTaxLowTierTotal + (dblFederalTax15PercentRate * (GrossPay - 500))
        ElseIf GrossPay > 50 Then
            dblFederalTotal = (dblFederalTax10PercentRate * (GrossPay - 51))
        Else
            dblFederalTotal = 0

        End If

        ' This returns the Federal tax.
        Return dblFederalTotal

    End Function



    ' This public function calculates the net pay for the employee.  It is public because it needs to be seen on the 
    ' hourly and salary forms.
    Public Function CalcNetPay(ByVal GrossPay As Double, ByVal FICA As Double, ByVal State As Double,
                               ByVal Federal As Double) As Double

        ' This creates the variable for the net pay.
        Dim dblNetPay As Double

        ' This calculates the net pay, based on the requirements.
        dblNetPay = GrossPay - (FICA + State + Federal)

        ' This returns the net pay amount.
        Return dblNetPay

    End Function

End Module
