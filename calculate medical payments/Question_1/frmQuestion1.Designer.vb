<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion1
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
        Me.grpMedicalScheme_Q1_1 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClearMedScheme = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radCopper = New System.Windows.Forms.RadioButton()
        Me.radSilver = New System.Windows.Forms.RadioButton()
        Me.radGold = New System.Windows.Forms.RadioButton()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblInfoQuestion1_2 = New System.Windows.Forms.Label()
        Me.txtNoDependants = New System.Windows.Forms.TextBox()
        Me.btnCalcMedicalPayments = New System.Windows.Forms.Button()
        Me.grpQuestion1_1 = New System.Windows.Forms.GroupBox()
        Me.lblQuestion1_1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpMedicalScheme_Q1_1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpQuestion1_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMedicalScheme_Q1_1
        '
        Me.grpMedicalScheme_Q1_1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.grpMedicalScheme_Q1_1.BackColor = System.Drawing.Color.Transparent
        Me.grpMedicalScheme_Q1_1.Controls.Add(Me.btnExit)
        Me.grpMedicalScheme_Q1_1.Controls.Add(Me.btnClearMedScheme)
        Me.grpMedicalScheme_Q1_1.Controls.Add(Me.GroupBox1)
        Me.grpMedicalScheme_Q1_1.Controls.Add(Me.txtAge)
        Me.grpMedicalScheme_Q1_1.Controls.Add(Me.Label1)
        Me.grpMedicalScheme_Q1_1.Controls.Add(Me.lblInfoQuestion1_2)
        Me.grpMedicalScheme_Q1_1.Controls.Add(Me.txtNoDependants)
        Me.grpMedicalScheme_Q1_1.Controls.Add(Me.btnCalcMedicalPayments)
        Me.grpMedicalScheme_Q1_1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMedicalScheme_Q1_1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.grpMedicalScheme_Q1_1.Location = New System.Drawing.Point(33, 184)
        Me.grpMedicalScheme_Q1_1.Name = "grpMedicalScheme_Q1_1"
        Me.grpMedicalScheme_Q1_1.Size = New System.Drawing.Size(602, 233)
        Me.grpMedicalScheme_Q1_1.TabIndex = 1
        Me.grpMedicalScheme_Q1_1.TabStop = False
        Me.grpMedicalScheme_Q1_1.Text = "Medical Scheme Options"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DarkGray
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(443, 173)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(135, 37)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClearMedScheme
        '
        Me.btnClearMedScheme.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnClearMedScheme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearMedScheme.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearMedScheme.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClearMedScheme.Location = New System.Drawing.Point(301, 173)
        Me.btnClearMedScheme.Name = "btnClearMedScheme"
        Me.btnClearMedScheme.Size = New System.Drawing.Size(139, 37)
        Me.btnClearMedScheme.TabIndex = 13
        Me.btnClearMedScheme.Text = "Clear All"
        Me.btnClearMedScheme.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radCopper)
        Me.GroupBox1.Controls.Add(Me.radSilver)
        Me.GroupBox1.Controls.Add(Me.radGold)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 61)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scheme Tiers"
        '
        'radCopper
        '
        Me.radCopper.AutoSize = True
        Me.radCopper.Checked = True
        Me.radCopper.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCopper.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radCopper.Location = New System.Drawing.Point(339, 23)
        Me.radCopper.Name = "radCopper"
        Me.radCopper.Size = New System.Drawing.Size(67, 20)
        Me.radCopper.TabIndex = 2
        Me.radCopper.TabStop = True
        Me.radCopper.Text = "Copper"
        Me.radCopper.UseVisualStyleBackColor = True
        '
        'radSilver
        '
        Me.radSilver.AutoSize = True
        Me.radSilver.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSilver.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radSilver.Location = New System.Drawing.Point(237, 23)
        Me.radSilver.Name = "radSilver"
        Me.radSilver.Size = New System.Drawing.Size(57, 20)
        Me.radSilver.TabIndex = 1
        Me.radSilver.TabStop = True
        Me.radSilver.Text = "Silver"
        Me.radSilver.UseVisualStyleBackColor = True
        '
        'radGold
        '
        Me.radGold.AutoSize = True
        Me.radGold.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radGold.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radGold.Location = New System.Drawing.Point(135, 23)
        Me.radGold.Name = "radGold"
        Me.radGold.Size = New System.Drawing.Size(57, 20)
        Me.radGold.TabIndex = 0
        Me.radGold.Text = "Gold "
        Me.radGold.UseVisualStyleBackColor = True
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(376, 40)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(125, 25)
        Me.txtAge.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(168, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Please specify your age (in years)"
        '
        'lblInfoQuestion1_2
        '
        Me.lblInfoQuestion1_2.AutoSize = True
        Me.lblInfoQuestion1_2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoQuestion1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblInfoQuestion1_2.Location = New System.Drawing.Point(134, 72)
        Me.lblInfoQuestion1_2.Name = "lblInfoQuestion1_2"
        Me.lblInfoQuestion1_2.Size = New System.Drawing.Size(240, 16)
        Me.lblInfoQuestion1_2.TabIndex = 9
        Me.lblInfoQuestion1_2.Text = "Number of dependants (enter 0 for none)"
        '
        'txtNoDependants
        '
        Me.txtNoDependants.Location = New System.Drawing.Point(376, 72)
        Me.txtNoDependants.Name = "txtNoDependants"
        Me.txtNoDependants.Size = New System.Drawing.Size(60, 25)
        Me.txtNoDependants.TabIndex = 8
        '
        'btnCalcMedicalPayments
        '
        Me.btnCalcMedicalPayments.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCalcMedicalPayments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalcMedicalPayments.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcMedicalPayments.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalcMedicalPayments.Location = New System.Drawing.Point(18, 173)
        Me.btnCalcMedicalPayments.Name = "btnCalcMedicalPayments"
        Me.btnCalcMedicalPayments.Size = New System.Drawing.Size(277, 37)
        Me.btnCalcMedicalPayments.TabIndex = 6
        Me.btnCalcMedicalPayments.Text = "Calculate Monthly Scheme Payment"
        Me.btnCalcMedicalPayments.UseVisualStyleBackColor = False
        '
        'grpQuestion1_1
        '
        Me.grpQuestion1_1.BackColor = System.Drawing.Color.White
        Me.grpQuestion1_1.Controls.Add(Me.lblQuestion1_1)
        Me.grpQuestion1_1.Location = New System.Drawing.Point(33, 11)
        Me.grpQuestion1_1.Name = "grpQuestion1_1"
        Me.grpQuestion1_1.Size = New System.Drawing.Size(602, 77)
        Me.grpQuestion1_1.TabIndex = 9
        Me.grpQuestion1_1.TabStop = False
        '
        'lblQuestion1_1
        '
        Me.lblQuestion1_1.AutoSize = True
        Me.lblQuestion1_1.Font = New System.Drawing.Font("Arial", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion1_1.Location = New System.Drawing.Point(43, 23)
        Me.lblQuestion1_1.Name = "lblQuestion1_1"
        Me.lblQuestion1_1.Size = New System.Drawing.Size(531, 40)
        Me.lblQuestion1_1.TabIndex = 1
        Me.lblQuestion1_1.Text = "Mzansi TVET Higher Health Clinic"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(362, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "HEALTH 4-ALL MEDICAL AID SCHEME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "-- Monthly Payment Calculator --"
        '
        'frmQuestion1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(675, 445)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grpQuestion1_1)
        Me.Controls.Add(Me.grpMedicalScheme_Q1_1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQuestion1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUESTION 1"
        Me.grpMedicalScheme_Q1_1.ResumeLayout(False)
        Me.grpMedicalScheme_Q1_1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpQuestion1_1.ResumeLayout(False)
        Me.grpQuestion1_1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpMedicalScheme_Q1_1 As GroupBox
    Friend WithEvents btnCalcMedicalPayments As Button
    Friend WithEvents grpQuestion1_2333 As GroupBox
    Friend WithEvents chkLoyaltyCard As CheckBox
    Friend WithEvents grpQuestion1_1 As GroupBox
    Friend WithEvents lblQuestion1_1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblInfoQuestion1_2 As Label
    Friend WithEvents txtNoDependants As TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radCopper As System.Windows.Forms.RadioButton
    Friend WithEvents radSilver As System.Windows.Forms.RadioButton
    Friend WithEvents radGold As System.Windows.Forms.RadioButton
    Friend WithEvents btnClearMedScheme As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
