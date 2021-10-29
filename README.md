# lollipopsProgram
Mult-form Windows application in VB for IT 101 (Programming 1) course at Cincinnati State

IT 101
Final Project

Problem Statement:
You have been asked to write a payroll program for the Lollipops4me Company.  Lollipops4me Company is located in Cincinnati, Ohio and has employees that live in Ohio, Indiana, and Kentucky.  The company has both salaried (management) and hourly employees.  The application should assist the payroll clerk in doing her weekly (52 times a year) payroll.  
The application must allow the clerk to state if the payroll is a salaried or an hourly employee.  Based on that selection, the clerk will gain access to the proper form to enter the first and last name of the employee and the necessary data for each type of employee to provide the necessary totals of:  Gross Pay, FICA, State Taxes, Federal Taxes, and Net Pay. 
Gross Pay for Salaried Employees:
•	The clerk will provide the yearly salary of the employee on the form.  Gross Pay will be determined based on the salary divided by the number of payrolls per year.
Gross Pay for Hourly Employees:  
•	The clerk will provide the hours worked for the pay period and their hourly wage.  Gross pay will be determined based on the hours worked and the hourly wage.  If the employee works over 40 hours in a week, they will be paid time and a half for all hours over 40.  
FICA:	
•	Sum of: 
o	6.2% of the first 125,000 of Yearly Gross Pay (Social Security tax).  After employee has amassed over $125,000 in yearly gross pay, they do not pay Social Security Tax. 
o	1.45% of total Gross Pay 

State Taxes:
•	For Ohio:  	6.5% of Weekly Gross Pay
•	For Kentucky: 6% of Weekly Gross Pay
•	For Indiana: 	5.5% of Weekly Gross Pay	

Federal Taxes:	
Weekly Gross Pay	Income Tax Withheld based on the Weekly Gross Pay
$0 to $50	$0
> $50 to $500	10%  over $51
> $500 to $2,500	$45.00 + 15% of amount over $500.00
> $2,500 to $5,000	$345.00 + 20% of amount over $2,500
Over $5,000	$845.00 + 25% of amount over $5,000

Net Pay:
•	Gross Pay – FICA – State Taxes – Federal Taxes

Instructions: 
•	This project should be a multi-form application that includes: 
•	A main form that allows the user to choose salaried or hourly employee.  
•	A  form to handle salaried employees 
•	A form to handle hourly employees.  
•	A module must be part of the application that includes common procedures/functions from both forms. 
•	Use proper controls for all necessary input. 
•	Validation is required for all textbox input.  For first and last name, ensure existence. For all numeric data, ensure for existence, numeric, and > 0. 
•	The formatted output on each form should be placed in a list box control as follows: 
•	A button should be included on the salaried and hourly form to clear the employee’s information and pay results for the next entry.
•	A button should be included on the salaried and hourly form to exit the form. 
•	A button should be included on the main form to exit the application. 
•	A menu must be included on each form that mimics the buttons on the form.  

Rubric:
•	Write the modularized solution based on your structure chart and Structured English that adheres to all requirements that produces the correct output based on the test cases and expected results.  – (70 points )
o	All programming logic is correct and works 100% - 50 points
o	Correct use of local and class level variables – 5 points (test if I need local-to-subroutine variables if I also have public global variables that are the same)
o	Procedures and functions are broken down to “one purpose” and called correctly – 10 points
o	Data is passed and received correctly (correct use of ByVal and ByRef) – 5 points
•	Incorporate a module for procedures or functions that are common between both of the forms. (10 points)
•	Document (comment) your program (5 points). 
o	All procedures and functions are documented that states purpose.
•	Use proper naming conventions (Hungarian notation) for all controls and variables (5 points) that will be referenced in code. 
•	Ensure your form is well designed by adhering to the following (10 points): 
•	Everything is aligned.  – 1 point
•	Proper controls are used for input. – 5 points
•	No wasted space on the form. – 1 point
•	Ensure buttons are same size and the group is centered. - 1 point
•	No misspellings. - 1 point
•	Focus is put to the correct control upon clearing. - 1 point



