<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnSalary = New System.Windows.Forms.Button()
        Me.btnHourly = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalariedEmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HourlyEmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalary
        '
        Me.btnSalary.Location = New System.Drawing.Point(36, 69)
        Me.btnSalary.Name = "btnSalary"
        Me.btnSalary.Size = New System.Drawing.Size(116, 78)
        Me.btnSalary.TabIndex = 0
        Me.btnSalary.Text = "Salaried Employees"
        Me.btnSalary.UseVisualStyleBackColor = True
        '
        'btnHourly
        '
        Me.btnHourly.Location = New System.Drawing.Point(266, 69)
        Me.btnHourly.Name = "btnHourly"
        Me.btnHourly.Size = New System.Drawing.Size(116, 78)
        Me.btnHourly.TabIndex = 1
        Me.btnHourly.Text = "Hourly Employees"
        Me.btnHourly.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(151, 207)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 78)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProjectToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(427, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(108, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ProjectToolStripMenuItem
        '
        Me.ProjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalariedEmployeesToolStripMenuItem, Me.HourlyEmployeesToolStripMenuItem})
        Me.ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem"
        Me.ProjectToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.ProjectToolStripMenuItem.Text = "Project"
        '
        'SalariedEmployeesToolStripMenuItem
        '
        Me.SalariedEmployeesToolStripMenuItem.Name = "SalariedEmployeesToolStripMenuItem"
        Me.SalariedEmployeesToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.SalariedEmployeesToolStripMenuItem.Text = "Salaried Employees"
        '
        'HourlyEmployeesToolStripMenuItem
        '
        Me.HourlyEmployeesToolStripMenuItem.Name = "HourlyEmployeesToolStripMenuItem"
        Me.HourlyEmployeesToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.HourlyEmployeesToolStripMenuItem.Text = "Hourly Employees"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 336)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHourly)
        Me.Controls.Add(Me.btnSalary)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Lollipops4me Payroll"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalary As Button
    Friend WithEvents btnHourly As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalariedEmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HourlyEmployeesToolStripMenuItem As ToolStripMenuItem
End Class
