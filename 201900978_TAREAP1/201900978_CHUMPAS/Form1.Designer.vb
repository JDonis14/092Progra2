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
        Me.RadSmall = New System.Windows.Forms.RadioButton()
        Me.RadMedium = New System.Windows.Forms.RadioButton()
        Me.RadLarge = New System.Windows.Forms.RadioButton()
        Me.GroupTamaño = New System.Windows.Forms.GroupBox()
        Me.TextAlgodon = New System.Windows.Forms.TextBox()
        Me.TextSeda = New System.Windows.Forms.TextBox()
        Me.TextLona = New System.Windows.Forms.TextBox()
        Me.GroupTipo = New System.Windows.Forms.GroupBox()
        Me.CheckLona = New System.Windows.Forms.RadioButton()
        Me.CheckSeda = New System.Windows.Forms.RadioButton()
        Me.CheckAlgodon = New System.Windows.Forms.RadioButton()
        Me.LabelAlgodon = New System.Windows.Forms.Label()
        Me.labelSeda = New System.Windows.Forms.Label()
        Me.LabelLona = New System.Windows.Forms.Label()
        Me.TextalgodonC = New System.Windows.Forms.TextBox()
        Me.TextSedaC = New System.Windows.Forms.TextBox()
        Me.TextLonaC = New System.Windows.Forms.TextBox()
        Me.GroupCosto = New System.Windows.Forms.GroupBox()
        Me.LabelChumpaV = New System.Windows.Forms.Label()
        Me.LabelSedaV = New System.Windows.Forms.Label()
        Me.LabelLonaV = New System.Windows.Forms.Label()
        Me.TextalgodonV = New System.Windows.Forms.TextBox()
        Me.TextSedaV = New System.Windows.Forms.TextBox()
        Me.TextLonaV = New System.Windows.Forms.TextBox()
        Me.GroupVenta = New System.Windows.Forms.GroupBox()
        Me.LabelTOTAL = New System.Windows.Forms.Label()
        Me.TextTOTAL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.GroupTamaño.SuspendLayout()
        Me.GroupTipo.SuspendLayout()
        Me.GroupCosto.SuspendLayout()
        Me.GroupVenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadSmall
        '
        Me.RadSmall.AutoSize = True
        Me.RadSmall.Location = New System.Drawing.Point(25, 19)
        Me.RadSmall.Name = "RadSmall"
        Me.RadSmall.Size = New System.Drawing.Size(50, 17)
        Me.RadSmall.TabIndex = 0
        Me.RadSmall.TabStop = True
        Me.RadSmall.Text = "Small"
        Me.RadSmall.UseVisualStyleBackColor = True
        '
        'RadMedium
        '
        Me.RadMedium.AutoSize = True
        Me.RadMedium.Location = New System.Drawing.Point(25, 44)
        Me.RadMedium.Name = "RadMedium"
        Me.RadMedium.Size = New System.Drawing.Size(62, 17)
        Me.RadMedium.TabIndex = 1
        Me.RadMedium.TabStop = True
        Me.RadMedium.Text = "Medium"
        Me.RadMedium.UseVisualStyleBackColor = True
        '
        'RadLarge
        '
        Me.RadLarge.AutoSize = True
        Me.RadLarge.Location = New System.Drawing.Point(25, 67)
        Me.RadLarge.Name = "RadLarge"
        Me.RadLarge.Size = New System.Drawing.Size(55, 17)
        Me.RadLarge.TabIndex = 2
        Me.RadLarge.TabStop = True
        Me.RadLarge.Text = "Large "
        Me.RadLarge.UseVisualStyleBackColor = True
        '
        'GroupTamaño
        '
        Me.GroupTamaño.Controls.Add(Me.RadLarge)
        Me.GroupTamaño.Controls.Add(Me.RadMedium)
        Me.GroupTamaño.Controls.Add(Me.RadSmall)
        Me.GroupTamaño.Location = New System.Drawing.Point(150, 64)
        Me.GroupTamaño.Name = "GroupTamaño"
        Me.GroupTamaño.Size = New System.Drawing.Size(123, 89)
        Me.GroupTamaño.TabIndex = 3
        Me.GroupTamaño.TabStop = False
        Me.GroupTamaño.Text = "Tamaño de Chumpa"
        '
        'TextAlgodon
        '
        Me.TextAlgodon.Location = New System.Drawing.Point(101, 22)
        Me.TextAlgodon.Name = "TextAlgodon"
        Me.TextAlgodon.Size = New System.Drawing.Size(100, 20)
        Me.TextAlgodon.TabIndex = 7
        '
        'TextSeda
        '
        Me.TextSeda.Location = New System.Drawing.Point(101, 48)
        Me.TextSeda.Name = "TextSeda"
        Me.TextSeda.Size = New System.Drawing.Size(100, 20)
        Me.TextSeda.TabIndex = 8
        '
        'TextLona
        '
        Me.TextLona.Location = New System.Drawing.Point(101, 74)
        Me.TextLona.Name = "TextLona"
        Me.TextLona.Size = New System.Drawing.Size(100, 20)
        Me.TextLona.TabIndex = 9
        '
        'GroupTipo
        '
        Me.GroupTipo.Controls.Add(Me.CheckLona)
        Me.GroupTipo.Controls.Add(Me.CheckSeda)
        Me.GroupTipo.Controls.Add(Me.CheckAlgodon)
        Me.GroupTipo.Controls.Add(Me.TextLona)
        Me.GroupTipo.Controls.Add(Me.TextSeda)
        Me.GroupTipo.Controls.Add(Me.TextAlgodon)
        Me.GroupTipo.Location = New System.Drawing.Point(372, 64)
        Me.GroupTipo.Name = "GroupTipo"
        Me.GroupTipo.Size = New System.Drawing.Size(226, 124)
        Me.GroupTipo.TabIndex = 10
        Me.GroupTipo.TabStop = False
        Me.GroupTipo.Text = "Tipo de material "
        '
        'CheckLona
        '
        Me.CheckLona.AutoSize = True
        Me.CheckLona.Location = New System.Drawing.Point(5, 77)
        Me.CheckLona.Name = "CheckLona"
        Me.CheckLona.Size = New System.Drawing.Size(49, 17)
        Me.CheckLona.TabIndex = 12
        Me.CheckLona.TabStop = True
        Me.CheckLona.Text = "Lona"
        Me.CheckLona.UseVisualStyleBackColor = True
        '
        'CheckSeda
        '
        Me.CheckSeda.AutoSize = True
        Me.CheckSeda.Location = New System.Drawing.Point(5, 51)
        Me.CheckSeda.Name = "CheckSeda"
        Me.CheckSeda.Size = New System.Drawing.Size(50, 17)
        Me.CheckSeda.TabIndex = 11
        Me.CheckSeda.TabStop = True
        Me.CheckSeda.Text = "Seda"
        Me.CheckSeda.UseVisualStyleBackColor = True
        '
        'CheckAlgodon
        '
        Me.CheckAlgodon.AutoSize = True
        Me.CheckAlgodon.Location = New System.Drawing.Point(5, 25)
        Me.CheckAlgodon.Name = "CheckAlgodon"
        Me.CheckAlgodon.Size = New System.Drawing.Size(64, 17)
        Me.CheckAlgodon.TabIndex = 10
        Me.CheckAlgodon.TabStop = True
        Me.CheckAlgodon.Text = "Algodon"
        Me.CheckAlgodon.UseVisualStyleBackColor = True
        '
        'LabelAlgodon
        '
        Me.LabelAlgodon.AutoSize = True
        Me.LabelAlgodon.Location = New System.Drawing.Point(8, 26)
        Me.LabelAlgodon.Name = "LabelAlgodon"
        Me.LabelAlgodon.Size = New System.Drawing.Size(78, 13)
        Me.LabelAlgodon.TabIndex = 11
        Me.LabelAlgodon.Text = "Precio algodon"
        '
        'labelSeda
        '
        Me.labelSeda.AutoSize = True
        Me.labelSeda.Location = New System.Drawing.Point(8, 49)
        Me.labelSeda.Name = "labelSeda"
        Me.labelSeda.Size = New System.Drawing.Size(68, 13)
        Me.labelSeda.TabIndex = 12
        Me.labelSeda.Text = "Precio Seda "
        '
        'LabelLona
        '
        Me.LabelLona.AutoSize = True
        Me.LabelLona.Location = New System.Drawing.Point(8, 71)
        Me.LabelLona.Name = "LabelLona"
        Me.LabelLona.Size = New System.Drawing.Size(67, 13)
        Me.LabelLona.TabIndex = 13
        Me.LabelLona.Text = "Precio Lona "
        '
        'TextalgodonC
        '
        Me.TextalgodonC.Enabled = False
        Me.TextalgodonC.Location = New System.Drawing.Point(93, 23)
        Me.TextalgodonC.Name = "TextalgodonC"
        Me.TextalgodonC.Size = New System.Drawing.Size(100, 20)
        Me.TextalgodonC.TabIndex = 14
        '
        'TextSedaC
        '
        Me.TextSedaC.Enabled = False
        Me.TextSedaC.Location = New System.Drawing.Point(93, 46)
        Me.TextSedaC.Name = "TextSedaC"
        Me.TextSedaC.Size = New System.Drawing.Size(100, 20)
        Me.TextSedaC.TabIndex = 15
        '
        'TextLonaC
        '
        Me.TextLonaC.Enabled = False
        Me.TextLonaC.Location = New System.Drawing.Point(93, 68)
        Me.TextLonaC.Name = "TextLonaC"
        Me.TextLonaC.Size = New System.Drawing.Size(100, 20)
        Me.TextLonaC.TabIndex = 16
        '
        'GroupCosto
        '
        Me.GroupCosto.Controls.Add(Me.TextLonaC)
        Me.GroupCosto.Controls.Add(Me.TextSedaC)
        Me.GroupCosto.Controls.Add(Me.TextalgodonC)
        Me.GroupCosto.Controls.Add(Me.LabelLona)
        Me.GroupCosto.Controls.Add(Me.labelSeda)
        Me.GroupCosto.Controls.Add(Me.LabelAlgodon)
        Me.GroupCosto.Location = New System.Drawing.Point(139, 194)
        Me.GroupCosto.Name = "GroupCosto"
        Me.GroupCosto.Size = New System.Drawing.Size(227, 108)
        Me.GroupCosto.TabIndex = 17
        Me.GroupCosto.TabStop = False
        Me.GroupCosto.Text = "Precio Costo de Material"
        Me.GroupCosto.Visible = False
        '
        'LabelChumpaV
        '
        Me.LabelChumpaV.AutoSize = True
        Me.LabelChumpaV.Location = New System.Drawing.Point(18, 22)
        Me.LabelChumpaV.Name = "LabelChumpaV"
        Me.LabelChumpaV.Size = New System.Drawing.Size(79, 13)
        Me.LabelChumpaV.TabIndex = 18
        Me.LabelChumpaV.Text = "Precio Algodon"
        '
        'LabelSedaV
        '
        Me.LabelSedaV.AutoSize = True
        Me.LabelSedaV.Location = New System.Drawing.Point(18, 49)
        Me.LabelSedaV.Name = "LabelSedaV"
        Me.LabelSedaV.Size = New System.Drawing.Size(65, 13)
        Me.LabelSedaV.TabIndex = 19
        Me.LabelSedaV.Text = "Precio Seda"
        '
        'LabelLonaV
        '
        Me.LabelLonaV.AutoSize = True
        Me.LabelLonaV.Location = New System.Drawing.Point(18, 74)
        Me.LabelLonaV.Name = "LabelLonaV"
        Me.LabelLonaV.Size = New System.Drawing.Size(67, 13)
        Me.LabelLonaV.TabIndex = 20
        Me.LabelLonaV.Text = "Precio Lona "
        '
        'TextalgodonV
        '
        Me.TextalgodonV.Enabled = False
        Me.TextalgodonV.Location = New System.Drawing.Point(103, 19)
        Me.TextalgodonV.Name = "TextalgodonV"
        Me.TextalgodonV.Size = New System.Drawing.Size(100, 20)
        Me.TextalgodonV.TabIndex = 21
        '
        'TextSedaV
        '
        Me.TextSedaV.Enabled = False
        Me.TextSedaV.Location = New System.Drawing.Point(103, 45)
        Me.TextSedaV.Name = "TextSedaV"
        Me.TextSedaV.Size = New System.Drawing.Size(100, 20)
        Me.TextSedaV.TabIndex = 22
        '
        'TextLonaV
        '
        Me.TextLonaV.Enabled = False
        Me.TextLonaV.Location = New System.Drawing.Point(103, 71)
        Me.TextLonaV.Name = "TextLonaV"
        Me.TextLonaV.Size = New System.Drawing.Size(100, 20)
        Me.TextLonaV.TabIndex = 23
        '
        'GroupVenta
        '
        Me.GroupVenta.Controls.Add(Me.TextLonaV)
        Me.GroupVenta.Controls.Add(Me.TextSedaV)
        Me.GroupVenta.Controls.Add(Me.TextalgodonV)
        Me.GroupVenta.Controls.Add(Me.LabelLonaV)
        Me.GroupVenta.Controls.Add(Me.LabelSedaV)
        Me.GroupVenta.Controls.Add(Me.LabelChumpaV)
        Me.GroupVenta.Location = New System.Drawing.Point(372, 194)
        Me.GroupVenta.Name = "GroupVenta"
        Me.GroupVenta.Size = New System.Drawing.Size(237, 108)
        Me.GroupVenta.TabIndex = 24
        Me.GroupVenta.TabStop = False
        Me.GroupVenta.Text = "Precio de Venta "
        Me.GroupVenta.Visible = False
        '
        'LabelTOTAL
        '
        Me.LabelTOTAL.AutoSize = True
        Me.LabelTOTAL.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelTOTAL.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTOTAL.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelTOTAL.Location = New System.Drawing.Point(255, 336)
        Me.LabelTOTAL.Name = "LabelTOTAL"
        Me.LabelTOTAL.Size = New System.Drawing.Size(111, 21)
        Me.LabelTOTAL.TabIndex = 25
        Me.LabelTOTAL.Text = "TOTAL FINAL"
        Me.LabelTOTAL.Visible = False
        '
        'TextTOTAL
        '
        Me.TextTOTAL.Enabled = False
        Me.TextTOTAL.Location = New System.Drawing.Point(372, 336)
        Me.TextTOTAL.Name = "TextTOTAL"
        Me.TextTOTAL.Size = New System.Drawing.Size(100, 20)
        Me.TextTOTAL.TabIndex = 26
        Me.TextTOTAL.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(196, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(340, 36)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "PEDIDOS DE CHUMPAS "
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.BackColor = System.Drawing.Color.Yellow
        Me.ButtonCalcular.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCalcular.Location = New System.Drawing.Point(214, 374)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(115, 28)
        Me.ButtonCalcular.TabIndex = 28
        Me.ButtonCalcular.Text = "CALCULAR"
        Me.ButtonCalcular.UseVisualStyleBackColor = False
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonLimpiar.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLimpiar.Location = New System.Drawing.Point(334, 374)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(96, 28)
        Me.ButtonLimpiar.TabIndex = 29
        Me.ButtonLimpiar.Text = "LIMPIAR"
        Me.ButtonLimpiar.UseVisualStyleBackColor = False
        '
        'ButtonSalir
        '
        Me.ButtonSalir.BackColor = System.Drawing.Color.Red
        Me.ButtonSalir.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSalir.Location = New System.Drawing.Point(436, 374)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(85, 28)
        Me.ButtonSalir.TabIndex = 30
        Me.ButtonSalir.Text = "SALIR "
        Me.ButtonSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201900978_CHUMPAS.My.Resources.Resources.TiendaRopa
        Me.ClientSize = New System.Drawing.Size(714, 432)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonLimpiar)
        Me.Controls.Add(Me.ButtonCalcular)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextTOTAL)
        Me.Controls.Add(Me.LabelTOTAL)
        Me.Controls.Add(Me.GroupVenta)
        Me.Controls.Add(Me.GroupCosto)
        Me.Controls.Add(Me.GroupTipo)
        Me.Controls.Add(Me.GroupTamaño)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupTamaño.ResumeLayout(False)
        Me.GroupTamaño.PerformLayout()
        Me.GroupTipo.ResumeLayout(False)
        Me.GroupTipo.PerformLayout()
        Me.GroupCosto.ResumeLayout(False)
        Me.GroupCosto.PerformLayout()
        Me.GroupVenta.ResumeLayout(False)
        Me.GroupVenta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadSmall As RadioButton
    Friend WithEvents RadMedium As RadioButton
    Friend WithEvents RadLarge As RadioButton
    Friend WithEvents GroupTamaño As GroupBox
    Friend WithEvents TextAlgodon As TextBox
    Friend WithEvents TextSeda As TextBox
    Friend WithEvents TextLona As TextBox
    Friend WithEvents GroupTipo As GroupBox
    Friend WithEvents LabelAlgodon As Label
    Friend WithEvents labelSeda As Label
    Friend WithEvents LabelLona As Label
    Friend WithEvents TextalgodonC As TextBox
    Friend WithEvents TextSedaC As TextBox
    Friend WithEvents TextLonaC As TextBox
    Friend WithEvents GroupCosto As GroupBox
    Friend WithEvents LabelChumpaV As Label
    Friend WithEvents LabelSedaV As Label
    Friend WithEvents LabelLonaV As Label
    Friend WithEvents TextalgodonV As TextBox
    Friend WithEvents TextSedaV As TextBox
    Friend WithEvents TextLonaV As TextBox
    Friend WithEvents GroupVenta As GroupBox
    Friend WithEvents LabelTOTAL As Label
    Friend WithEvents TextTOTAL As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents CheckLona As RadioButton
    Friend WithEvents CheckSeda As RadioButton
    Friend WithEvents CheckAlgodon As RadioButton
End Class
