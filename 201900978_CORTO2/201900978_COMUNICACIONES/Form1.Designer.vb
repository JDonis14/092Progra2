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
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextEMPLEADO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextSALARIO = New System.Windows.Forms.TextBox()
        Me.TextNO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioTABLET = New System.Windows.Forms.RadioButton()
        Me.RadioDRONE = New System.Windows.Forms.RadioButton()
        Me.RadioCELULAR = New System.Windows.Forms.RadioButton()
        Me.RadioTELEVISOR = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListNOMBRE = New System.Windows.Forms.ListBox()
        Me.ListSALARIO = New System.Windows.Forms.ListBox()
        Me.ListNO = New System.Windows.Forms.ListBox()
        Me.ListTIPO = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListCOMISION = New System.Windows.Forms.ListBox()
        Me.ListBONO = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListSUELDO = New System.Windows.Forms.ListBox()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.CalcularToolStripMenuItem.Text = "Calcular "
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Vectores "
        '
        'TextEMPLEADO
        '
        Me.TextEMPLEADO.Location = New System.Drawing.Point(159, 25)
        Me.TextEMPLEADO.Name = "TextEMPLEADO"
        Me.TextEMPLEADO.Size = New System.Drawing.Size(100, 20)
        Me.TextEMPLEADO.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NOMBRE DEL EMPLEADO "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SALARIO "
        '
        'TextSALARIO
        '
        Me.TextSALARIO.Location = New System.Drawing.Point(159, 51)
        Me.TextSALARIO.Name = "TextSALARIO"
        Me.TextSALARIO.Size = New System.Drawing.Size(100, 20)
        Me.TextSALARIO.TabIndex = 4
        '
        'TextNO
        '
        Me.TextNO.Location = New System.Drawing.Point(159, 77)
        Me.TextNO.Name = "TextNO"
        Me.TextNO.Size = New System.Drawing.Size(100, 20)
        Me.TextNO.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ARTICULOS A COMPRAR "
        '
        'RadioTABLET
        '
        Me.RadioTABLET.AutoSize = True
        Me.RadioTABLET.Location = New System.Drawing.Point(20, 27)
        Me.RadioTABLET.Name = "RadioTABLET"
        Me.RadioTABLET.Size = New System.Drawing.Size(66, 17)
        Me.RadioTABLET.TabIndex = 7
        Me.RadioTABLET.TabStop = True
        Me.RadioTABLET.Text = "TABLET"
        Me.RadioTABLET.UseVisualStyleBackColor = True
        '
        'RadioDRONE
        '
        Me.RadioDRONE.AutoSize = True
        Me.RadioDRONE.Location = New System.Drawing.Point(20, 50)
        Me.RadioDRONE.Name = "RadioDRONE"
        Me.RadioDRONE.Size = New System.Drawing.Size(64, 17)
        Me.RadioDRONE.TabIndex = 8
        Me.RadioDRONE.TabStop = True
        Me.RadioDRONE.Text = "DRONE"
        Me.RadioDRONE.UseVisualStyleBackColor = True
        '
        'RadioCELULAR
        '
        Me.RadioCELULAR.AutoSize = True
        Me.RadioCELULAR.Location = New System.Drawing.Point(20, 73)
        Me.RadioCELULAR.Name = "RadioCELULAR"
        Me.RadioCELULAR.Size = New System.Drawing.Size(77, 17)
        Me.RadioCELULAR.TabIndex = 9
        Me.RadioCELULAR.TabStop = True
        Me.RadioCELULAR.Text = "CELULAR "
        Me.RadioCELULAR.UseVisualStyleBackColor = True
        '
        'RadioTELEVISOR
        '
        Me.RadioTELEVISOR.AutoSize = True
        Me.RadioTELEVISOR.Location = New System.Drawing.Point(20, 96)
        Me.RadioTELEVISOR.Name = "RadioTELEVISOR"
        Me.RadioTELEVISOR.Size = New System.Drawing.Size(85, 17)
        Me.RadioTELEVISOR.TabIndex = 10
        Me.RadioTELEVISOR.TabStop = True
        Me.RadioTELEVISOR.Text = "TELEVISOR"
        Me.RadioTELEVISOR.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextNO)
        Me.GroupBox1.Controls.Add(Me.TextSALARIO)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextEMPLEADO)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 136)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DE INGRESO "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioTELEVISOR)
        Me.GroupBox2.Controls.Add(Me.RadioCELULAR)
        Me.GroupBox2.Controls.Add(Me.RadioDRONE)
        Me.GroupBox2.Controls.Add(Me.RadioTABLET)
        Me.GroupBox2.Location = New System.Drawing.Point(346, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 130)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TIPO DE ARTICULO "
        '
        'ListNOMBRE
        '
        Me.ListNOMBRE.FormattingEnabled = True
        Me.ListNOMBRE.Location = New System.Drawing.Point(53, 291)
        Me.ListNOMBRE.Name = "ListNOMBRE"
        Me.ListNOMBRE.Size = New System.Drawing.Size(66, 95)
        Me.ListNOMBRE.TabIndex = 11
        '
        'ListSALARIO
        '
        Me.ListSALARIO.FormattingEnabled = True
        Me.ListSALARIO.Location = New System.Drawing.Point(137, 291)
        Me.ListSALARIO.Name = "ListSALARIO"
        Me.ListSALARIO.Size = New System.Drawing.Size(66, 95)
        Me.ListSALARIO.TabIndex = 13
        '
        'ListNO
        '
        Me.ListNO.FormattingEnabled = True
        Me.ListNO.Location = New System.Drawing.Point(220, 291)
        Me.ListNO.Name = "ListNO"
        Me.ListNO.Size = New System.Drawing.Size(66, 95)
        Me.ListNO.TabIndex = 14
        '
        'ListTIPO
        '
        Me.ListTIPO.FormattingEnabled = True
        Me.ListTIPO.Location = New System.Drawing.Point(325, 291)
        Me.ListTIPO.Name = "ListTIPO"
        Me.ListTIPO.Size = New System.Drawing.Size(66, 95)
        Me.ListTIPO.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "NOMBRE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(140, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "SALARIO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(209, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "NO. ARTICULOS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(305, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "TIPO DE ARTICULO "
        '
        'ListCOMISION
        '
        Me.ListCOMISION.FormattingEnabled = True
        Me.ListCOMISION.Location = New System.Drawing.Point(421, 291)
        Me.ListCOMISION.Name = "ListCOMISION"
        Me.ListCOMISION.Size = New System.Drawing.Size(66, 95)
        Me.ListCOMISION.TabIndex = 20
        '
        'ListBONO
        '
        Me.ListBONO.FormattingEnabled = True
        Me.ListBONO.Location = New System.Drawing.Point(506, 291)
        Me.ListBONO.Name = "ListBONO"
        Me.ListBONO.Size = New System.Drawing.Size(66, 95)
        Me.ListBONO.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(427, 275)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "COMISION"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(518, 275)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "BONO "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(585, 275)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "SUELDO FINAL "
        '
        'ListSUELDO
        '
        Me.ListSUELDO.FormattingEnabled = True
        Me.ListSUELDO.Location = New System.Drawing.Point(597, 291)
        Me.ListSUELDO.Name = "ListSUELDO"
        Me.ListSUELDO.Size = New System.Drawing.Size(66, 95)
        Me.ListSUELDO.TabIndex = 25
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar entradas "
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.SalirToolStripMenuItem.Text = "Salir "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201900978_COMUNICACIONES.My.Resources.Resources.istockphoto_668127272_1024x1024
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListSUELDO)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ListBONO)
        Me.Controls.Add(Me.ListCOMISION)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListTIPO)
        Me.Controls.Add(Me.ListNO)
        Me.Controls.Add(Me.ListSALARIO)
        Me.Controls.Add(Me.ListNOMBRE)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextEMPLEADO As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextSALARIO As TextBox
    Friend WithEvents TextNO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioTABLET As RadioButton
    Friend WithEvents RadioDRONE As RadioButton
    Friend WithEvents RadioCELULAR As RadioButton
    Friend WithEvents RadioTELEVISOR As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListNOMBRE As ListBox
    Friend WithEvents ListSALARIO As ListBox
    Friend WithEvents ListNO As ListBox
    Friend WithEvents ListTIPO As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListCOMISION As ListBox
    Friend WithEvents ListBONO As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ListSUELDO As ListBox
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
