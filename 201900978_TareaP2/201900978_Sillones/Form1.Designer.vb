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
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARGRIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioSofa = New System.Windows.Forms.RadioButton()
        Me.RadioIndividual = New System.Windows.Forms.RadioButton()
        Me.RadioDoble = New System.Windows.Forms.RadioButton()
        Me.TextCantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboTipotela = New System.Windows.Forms.ComboBox()
        Me.GroupDatos = New System.Windows.Forms.GroupBox()
        Me.GroupTsillon = New System.Windows.Forms.GroupBox()
        Me.GroupTtela = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataCliente = New System.Windows.Forms.DataGridView()
        Me.NoVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantSillones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipSillon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupDatos.SuspendLayout()
        Me.GroupTsillon.SuspendLayout()
        Me.GroupTtela.SuspendLayout()
        CType(Me.DataCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.MenuStrip1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARGRIDToolStripMenuItem, Me.SALIRToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(995, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(102, 24)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR "
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(173, 24)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'LIMPIARGRIDToolStripMenuItem
        '
        Me.LIMPIARGRIDToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LIMPIARGRIDToolStripMenuItem.Name = "LIMPIARGRIDToolStripMenuItem"
        Me.LIMPIARGRIDToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.LIMPIARGRIDToolStripMenuItem.Text = "LIMPIAR GRID"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.BackColor = System.Drawing.Color.Red
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.SALIRToolStripMenuItem.Text = "SALIR "
        '
        'LIMPIARVECTORESToolStripMenuItem1
        '
        Me.LIMPIARVECTORESToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LIMPIARVECTORESToolStripMenuItem1.Name = "LIMPIARVECTORESToolStripMenuItem1"
        Me.LIMPIARVECTORESToolStripMenuItem1.Size = New System.Drawing.Size(172, 24)
        Me.LIMPIARVECTORESToolStripMenuItem1.Text = "LIMPIAR VECTORES"
        '
        'TextNo
        '
        Me.TextNo.Location = New System.Drawing.Point(152, 33)
        Me.TextNo.Margin = New System.Windows.Forms.Padding(4)
        Me.TextNo.Name = "TextNo"
        Me.TextNo.Size = New System.Drawing.Size(132, 28)
        Me.TextNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Número de venta "
        '
        'RadioSofa
        '
        Me.RadioSofa.AutoSize = True
        Me.RadioSofa.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioSofa.Location = New System.Drawing.Point(40, 20)
        Me.RadioSofa.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioSofa.Name = "RadioSofa"
        Me.RadioSofa.Size = New System.Drawing.Size(66, 23)
        Me.RadioSofa.TabIndex = 3
        Me.RadioSofa.TabStop = True
        Me.RadioSofa.Text = "SOFÁ "
        Me.RadioSofa.UseVisualStyleBackColor = True
        '
        'RadioIndividual
        '
        Me.RadioIndividual.AutoSize = True
        Me.RadioIndividual.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioIndividual.Location = New System.Drawing.Point(40, 51)
        Me.RadioIndividual.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioIndividual.Name = "RadioIndividual"
        Me.RadioIndividual.Size = New System.Drawing.Size(109, 23)
        Me.RadioIndividual.TabIndex = 4
        Me.RadioIndividual.TabStop = True
        Me.RadioIndividual.Text = "INDIVIDUAL "
        Me.RadioIndividual.UseVisualStyleBackColor = True
        '
        'RadioDoble
        '
        Me.RadioDoble.AutoSize = True
        Me.RadioDoble.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioDoble.Location = New System.Drawing.Point(40, 82)
        Me.RadioDoble.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioDoble.Name = "RadioDoble"
        Me.RadioDoble.Size = New System.Drawing.Size(74, 23)
        Me.RadioDoble.TabIndex = 5
        Me.RadioDoble.TabStop = True
        Me.RadioDoble.Text = "DOBLE "
        Me.RadioDoble.UseVisualStyleBackColor = True
        '
        'TextCantidad
        '
        Me.TextCantidad.Location = New System.Drawing.Point(152, 65)
        Me.TextCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.TextCantidad.Name = "TextCantidad"
        Me.TextCantidad.Size = New System.Drawing.Size(132, 28)
        Me.TextCantidad.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cantidad de sillones "
        '
        'ComboTipotela
        '
        Me.ComboTipotela.FormattingEnabled = True
        Me.ComboTipotela.Items.AddRange(New Object() {"CUERO ", "CUERINA "})
        Me.ComboTipotela.Location = New System.Drawing.Point(6, 44)
        Me.ComboTipotela.Name = "ComboTipotela"
        Me.ComboTipotela.Size = New System.Drawing.Size(121, 30)
        Me.ComboTipotela.TabIndex = 8
        '
        'GroupDatos
        '
        Me.GroupDatos.BackColor = System.Drawing.SystemColors.Info
        Me.GroupDatos.Controls.Add(Me.Label2)
        Me.GroupDatos.Controls.Add(Me.TextCantidad)
        Me.GroupDatos.Controls.Add(Me.Label1)
        Me.GroupDatos.Controls.Add(Me.TextNo)
        Me.GroupDatos.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDatos.Location = New System.Drawing.Point(130, 112)
        Me.GroupDatos.Name = "GroupDatos"
        Me.GroupDatos.Size = New System.Drawing.Size(315, 122)
        Me.GroupDatos.TabIndex = 9
        Me.GroupDatos.TabStop = False
        Me.GroupDatos.Text = "DATOS"
        '
        'GroupTsillon
        '
        Me.GroupTsillon.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupTsillon.Controls.Add(Me.RadioDoble)
        Me.GroupTsillon.Controls.Add(Me.RadioIndividual)
        Me.GroupTsillon.Controls.Add(Me.RadioSofa)
        Me.GroupTsillon.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupTsillon.Location = New System.Drawing.Point(451, 112)
        Me.GroupTsillon.Name = "GroupTsillon"
        Me.GroupTsillon.Size = New System.Drawing.Size(167, 122)
        Me.GroupTsillon.TabIndex = 10
        Me.GroupTsillon.TabStop = False
        Me.GroupTsillon.Text = "TIPO DE SILLÓN "
        '
        'GroupTtela
        '
        Me.GroupTtela.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupTtela.Controls.Add(Me.ComboTipotela)
        Me.GroupTtela.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupTtela.Location = New System.Drawing.Point(624, 112)
        Me.GroupTtela.Name = "GroupTtela"
        Me.GroupTtela.Size = New System.Drawing.Size(149, 122)
        Me.GroupTtela.TabIndex = 11
        Me.GroupTtela.TabStop = False
        Me.GroupTtela.Text = "TIPO DE TELA "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(319, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(389, 39)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "FABRICA  DE SILLONES "
        '
        'DataCliente
        '
        Me.DataCliente.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoVenta, Me.CantSillones, Me.TipSillon, Me.Column1, Me.Column2, Me.Column3})
        Me.DataCliente.GridColor = System.Drawing.SystemColors.Control
        Me.DataCliente.Location = New System.Drawing.Point(130, 277)
        Me.DataCliente.Name = "DataCliente"
        Me.DataCliente.Size = New System.Drawing.Size(643, 220)
        Me.DataCliente.TabIndex = 13
        '
        'NoVenta
        '
        Me.NoVenta.HeaderText = "No. Venta "
        Me.NoVenta.Name = "NoVenta"
        '
        'CantSillones
        '
        Me.CantSillones.HeaderText = "Cantidad de Sillones "
        Me.CantSillones.Name = "CantSillones"
        '
        'TipSillon
        '
        Me.TipSillon.HeaderText = "Tipo de Sillón"
        Me.TipSillon.Name = "TipSillon"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Tipo Tela "
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Precio Costo "
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Precio Venta "
        Me.Column3.Name = "Column3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201900978_Sillones.My.Resources.Resources.tarea_preparatoria_2
        Me.ClientSize = New System.Drawing.Size(995, 658)
        Me.Controls.Add(Me.DataCliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupTtela)
        Me.Controls.Add(Me.GroupTsillon)
        Me.Controls.Add(Me.GroupDatos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupDatos.ResumeLayout(False)
        Me.GroupDatos.PerformLayout()
        Me.GroupTsillon.ResumeLayout(False)
        Me.GroupTsillon.PerformLayout()
        Me.GroupTtela.ResumeLayout(False)
        CType(Me.DataCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARGRIDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioSofa As RadioButton
    Friend WithEvents RadioIndividual As RadioButton
    Friend WithEvents RadioDoble As RadioButton
    Friend WithEvents TextCantidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboTipotela As ComboBox
    Friend WithEvents GroupDatos As GroupBox
    Friend WithEvents GroupTsillon As GroupBox
    Friend WithEvents GroupTtela As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataCliente As DataGridView
    Friend WithEvents NoVenta As DataGridViewTextBoxColumn
    Friend WithEvents CantSillones As DataGridViewTextBoxColumn
    Friend WithEvents TipSillon As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem1 As ToolStripMenuItem
End Class
