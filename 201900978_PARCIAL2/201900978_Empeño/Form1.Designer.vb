<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ACEPTARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARLISTBOXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARMATRIZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboPLAZO = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckTV = New System.Windows.Forms.CheckBox()
        Me.CheckTELEFONO = New System.Windows.Forms.CheckBox()
        Me.CheckLAPTOP = New System.Windows.Forms.CheckBox()
        Me.CheckREFRIGERADORA = New System.Windows.Forms.CheckBox()
        Me.TextNOMBRE = New System.Windows.Forms.TextBox()
        Me.TextDIRECCION = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListnNOMBRE = New System.Windows.Forms.ListBox()
        Me.ListDIRECCION = New System.Windows.Forms.ListBox()
        Me.ListCUI = New System.Windows.Forms.ListBox()
        Me.ListAPARATO = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListCOBRO = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListDESCUENTO = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListTOTAL = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Textcosto = New System.Windows.Forms.TextBox()
        Me.ListCOSTO = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ListPLAZO = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACEPTARToolStripMenuItem, Me.LIMPIARENTRADAToolStripMenuItem, Me.LIMPIARLISTBOXToolStripMenuItem, Me.LIMPIARMATRIZToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1005, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ACEPTARToolStripMenuItem
        '
        Me.ACEPTARToolStripMenuItem.Name = "ACEPTARToolStripMenuItem"
        Me.ACEPTARToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ACEPTARToolStripMenuItem.Text = "ACEPTAR "
        '
        'LIMPIARENTRADAToolStripMenuItem
        '
        Me.LIMPIARENTRADAToolStripMenuItem.Name = "LIMPIARENTRADAToolStripMenuItem"
        Me.LIMPIARENTRADAToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.LIMPIARENTRADAToolStripMenuItem.Text = "LIMPIAR ENTRADA "
        '
        'LIMPIARLISTBOXToolStripMenuItem
        '
        Me.LIMPIARLISTBOXToolStripMenuItem.Name = "LIMPIARLISTBOXToolStripMenuItem"
        Me.LIMPIARLISTBOXToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.LIMPIARLISTBOXToolStripMenuItem.Text = "LIMPIAR LISTBOX"
        '
        'LIMPIARMATRIZToolStripMenuItem
        '
        Me.LIMPIARMATRIZToolStripMenuItem.Name = "LIMPIARMATRIZToolStripMenuItem"
        Me.LIMPIARMATRIZToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.LIMPIARMATRIZToolStripMenuItem.Text = "LIMPIAR MATRIZ"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR "
        '
        'ComboPLAZO
        '
        Me.ComboPLAZO.FormattingEnabled = True
        Me.ComboPLAZO.Items.AddRange(New Object() {"CORTO ", "LARGO ", ""})
        Me.ComboPLAZO.Location = New System.Drawing.Point(102, 22)
        Me.ComboPLAZO.Name = "ComboPLAZO"
        Me.ComboPLAZO.Size = New System.Drawing.Size(121, 21)
        Me.ComboPLAZO.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TIPO DE PLAZO "
        '
        'CheckTV
        '
        Me.CheckTV.AutoSize = True
        Me.CheckTV.Location = New System.Drawing.Point(15, 16)
        Me.CheckTV.Name = "CheckTV"
        Me.CheckTV.Size = New System.Drawing.Size(40, 17)
        Me.CheckTV.TabIndex = 3
        Me.CheckTV.Text = "TV"
        Me.CheckTV.UseVisualStyleBackColor = True
        '
        'CheckTELEFONO
        '
        Me.CheckTELEFONO.AutoSize = True
        Me.CheckTELEFONO.Location = New System.Drawing.Point(15, 39)
        Me.CheckTELEFONO.Name = "CheckTELEFONO"
        Me.CheckTELEFONO.Size = New System.Drawing.Size(83, 17)
        Me.CheckTELEFONO.TabIndex = 4
        Me.CheckTELEFONO.Text = "TELEFONO"
        Me.CheckTELEFONO.UseVisualStyleBackColor = True
        '
        'CheckLAPTOP
        '
        Me.CheckLAPTOP.AutoSize = True
        Me.CheckLAPTOP.Location = New System.Drawing.Point(15, 62)
        Me.CheckLAPTOP.Name = "CheckLAPTOP"
        Me.CheckLAPTOP.Size = New System.Drawing.Size(68, 17)
        Me.CheckLAPTOP.TabIndex = 5
        Me.CheckLAPTOP.Text = "LAPTOP"
        Me.CheckLAPTOP.UseVisualStyleBackColor = True
        '
        'CheckREFRIGERADORA
        '
        Me.CheckREFRIGERADORA.AutoSize = True
        Me.CheckREFRIGERADORA.Location = New System.Drawing.Point(15, 85)
        Me.CheckREFRIGERADORA.Name = "CheckREFRIGERADORA"
        Me.CheckREFRIGERADORA.Size = New System.Drawing.Size(122, 17)
        Me.CheckREFRIGERADORA.TabIndex = 6
        Me.CheckREFRIGERADORA.Text = "REFRIGERADORA "
        Me.CheckREFRIGERADORA.UseVisualStyleBackColor = True
        '
        'TextNOMBRE
        '
        Me.TextNOMBRE.Location = New System.Drawing.Point(96, 41)
        Me.TextNOMBRE.Name = "TextNOMBRE"
        Me.TextNOMBRE.Size = New System.Drawing.Size(100, 20)
        Me.TextNOMBRE.TabIndex = 7
        '
        'TextDIRECCION
        '
        Me.TextDIRECCION.Location = New System.Drawing.Point(96, 79)
        Me.TextDIRECCION.Name = "TextDIRECCION"
        Me.TextDIRECCION.Size = New System.Drawing.Size(100, 20)
        Me.TextDIRECCION.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "NOMBRE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "DIRECCIÓN "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Textcosto)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextDIRECCION)
        Me.GroupBox1.Controls.Add(Me.TextNOMBRE)
        Me.GroupBox1.Location = New System.Drawing.Point(367, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 166)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DEL EMPEÑADOR "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.ComboPLAZO)
        Me.GroupBox2.Location = New System.Drawing.Point(468, 270)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(241, 57)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PLAZO"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckREFRIGERADORA)
        Me.GroupBox3.Controls.Add(Me.CheckLAPTOP)
        Me.GroupBox3.Controls.Add(Me.CheckTELEFONO)
        Me.GroupBox3.Controls.Add(Me.CheckTV)
        Me.GroupBox3.Location = New System.Drawing.Point(611, 98)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(150, 166)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "APARATO "
        '
        'ListnNOMBRE
        '
        Me.ListnNOMBRE.FormattingEnabled = True
        Me.ListnNOMBRE.Location = New System.Drawing.Point(132, 350)
        Me.ListnNOMBRE.Name = "ListnNOMBRE"
        Me.ListnNOMBRE.Size = New System.Drawing.Size(80, 95)
        Me.ListnNOMBRE.TabIndex = 14
        '
        'ListDIRECCION
        '
        Me.ListDIRECCION.FormattingEnabled = True
        Me.ListDIRECCION.Location = New System.Drawing.Point(218, 350)
        Me.ListDIRECCION.Name = "ListDIRECCION"
        Me.ListDIRECCION.Size = New System.Drawing.Size(80, 95)
        Me.ListDIRECCION.TabIndex = 15
        '
        'ListCUI
        '
        Me.ListCUI.FormattingEnabled = True
        Me.ListCUI.Location = New System.Drawing.Point(304, 350)
        Me.ListCUI.Name = "ListCUI"
        Me.ListCUI.Size = New System.Drawing.Size(80, 95)
        Me.ListCUI.TabIndex = 16
        '
        'ListAPARATO
        '
        Me.ListAPARATO.FormattingEnabled = True
        Me.ListAPARATO.Location = New System.Drawing.Point(390, 350)
        Me.ListAPARATO.Name = "ListAPARATO"
        Me.ListAPARATO.Size = New System.Drawing.Size(80, 95)
        Me.ListAPARATO.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(144, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "NOMBRE "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(224, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "DIRECCIÓN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(334, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "CUI"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Location = New System.Drawing.Point(399, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "APARATO "
        '
        'ListCOBRO
        '
        Me.ListCOBRO.FormattingEnabled = True
        Me.ListCOBRO.Location = New System.Drawing.Point(651, 350)
        Me.ListCOBRO.Name = "ListCOBRO"
        Me.ListCOBRO.Size = New System.Drawing.Size(80, 95)
        Me.ListCOBRO.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Location = New System.Drawing.Point(671, 334)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "COBRÓ"
        '
        'ListDESCUENTO
        '
        Me.ListDESCUENTO.FormattingEnabled = True
        Me.ListDESCUENTO.Location = New System.Drawing.Point(737, 350)
        Me.ListDESCUENTO.Name = "ListDESCUENTO"
        Me.ListDESCUENTO.Size = New System.Drawing.Size(80, 95)
        Me.ListDESCUENTO.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Location = New System.Drawing.Point(740, 334)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "DESCUENTO "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Location = New System.Drawing.Point(842, 334)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "TOTAL "
        '
        'ListTOTAL
        '
        Me.ListTOTAL.FormattingEnabled = True
        Me.ListTOTAL.Location = New System.Drawing.Point(823, 350)
        Me.ListTOTAL.Name = "ListTOTAL"
        Me.ListTOTAL.Size = New System.Drawing.Size(80, 95)
        Me.ListTOTAL.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(36, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "COSTO "
        '
        'Textcosto
        '
        Me.Textcosto.Location = New System.Drawing.Point(96, 120)
        Me.Textcosto.Name = "Textcosto"
        Me.Textcosto.Size = New System.Drawing.Size(100, 20)
        Me.Textcosto.TabIndex = 12
        '
        'ListCOSTO
        '
        Me.ListCOSTO.FormattingEnabled = True
        Me.ListCOSTO.Location = New System.Drawing.Point(565, 350)
        Me.ListCOSTO.Name = "ListCOSTO"
        Me.ListCOSTO.Size = New System.Drawing.Size(80, 95)
        Me.ListCOSTO.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label12.Location = New System.Drawing.Point(581, 334)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "COSTO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label13.Location = New System.Drawing.Point(496, 334)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "PLAZO"
        '
        'ListPLAZO
        '
        Me.ListPLAZO.FormattingEnabled = True
        Me.ListPLAZO.Location = New System.Drawing.Point(476, 350)
        Me.ListPLAZO.Name = "ListPLAZO"
        Me.ListPLAZO.Size = New System.Drawing.Size(80, 95)
        Me.ListPLAZO.TabIndex = 31
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201900978_Empeño.My.Resources.Resources.EMPEÑADORA
        Me.ClientSize = New System.Drawing.Size(1005, 640)
        Me.Controls.Add(Me.ListPLAZO)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ListCOSTO)
        Me.Controls.Add(Me.ListTOTAL)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ListDESCUENTO)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ListCOBRO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListAPARATO)
        Me.Controls.Add(Me.ListCUI)
        Me.Controls.Add(Me.ListDIRECCION)
        Me.Controls.Add(Me.ListnNOMBRE)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ACEPTARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARLISTBOXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARMATRIZToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboPLAZO As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckTV As CheckBox
    Friend WithEvents CheckTELEFONO As CheckBox
    Friend WithEvents CheckLAPTOP As CheckBox
    Friend WithEvents CheckREFRIGERADORA As CheckBox
    Friend WithEvents TextNOMBRE As TextBox
    Friend WithEvents TextDIRECCION As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ListnNOMBRE As ListBox
    Friend WithEvents ListDIRECCION As ListBox
    Friend WithEvents ListCUI As ListBox
    Friend WithEvents ListAPARATO As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListCOBRO As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ListDESCUENTO As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ListTOTAL As ListBox
    Friend WithEvents Textcosto As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ListCOSTO As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ListPLAZO As ListBox
End Class
