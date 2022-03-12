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
        Me.Textcarnet = New System.Windows.Forms.TextBox()
        Me.Textnombre = New System.Windows.Forms.TextBox()
        Me.Textfecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Checkviernes = New System.Windows.Forms.CheckBox()
        Me.Checksabado = New System.Windows.Forms.CheckBox()
        Me.Comboidioma = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Radioefectivo = New System.Windows.Forms.RadioButton()
        Me.Radiocheque = New System.Windows.Forms.RadioButton()
        Me.Groupdatos = New System.Windows.Forms.GroupBox()
        Me.Groupidiomaydia = New System.Windows.Forms.GroupBox()
        Me.Grouppago = New System.Windows.Forms.GroupBox()
        Me.Menubotones = New System.Windows.Forms.MenuStrip()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARDATOSDEENTRADAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARMATRIZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Datacompleta = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Groupdatos.SuspendLayout()
        Me.Groupidiomaydia.SuspendLayout()
        Me.Grouppago.SuspendLayout()
        Me.Menubotones.SuspendLayout()
        CType(Me.Datacompleta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Textcarnet
        '
        Me.Textcarnet.Location = New System.Drawing.Point(255, 36)
        Me.Textcarnet.Name = "Textcarnet"
        Me.Textcarnet.Size = New System.Drawing.Size(100, 26)
        Me.Textcarnet.TabIndex = 0
        '
        'Textnombre
        '
        Me.Textnombre.Location = New System.Drawing.Point(255, 68)
        Me.Textnombre.Name = "Textnombre"
        Me.Textnombre.Size = New System.Drawing.Size(100, 26)
        Me.Textnombre.TabIndex = 1
        '
        'Textfecha
        '
        Me.Textfecha.Location = New System.Drawing.Point(255, 100)
        Me.Textfecha.Name = "Textfecha"
        Me.Textfecha.Size = New System.Drawing.Size(100, 26)
        Me.Textfecha.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(156, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CARNET "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NOMBRE DE ESTUDIANTE "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "FECHA INSCRIPCIÓN"
        '
        'Checkviernes
        '
        Me.Checkviernes.AutoSize = True
        Me.Checkviernes.Location = New System.Drawing.Point(166, 78)
        Me.Checkviernes.Name = "Checkviernes"
        Me.Checkviernes.Size = New System.Drawing.Size(107, 24)
        Me.Checkviernes.TabIndex = 6
        Me.Checkviernes.Text = "VIERNES"
        Me.Checkviernes.UseVisualStyleBackColor = True
        '
        'Checksabado
        '
        Me.Checksabado.AutoSize = True
        Me.Checksabado.Location = New System.Drawing.Point(166, 101)
        Me.Checksabado.Name = "Checksabado"
        Me.Checksabado.Size = New System.Drawing.Size(102, 24)
        Me.Checksabado.TabIndex = 7
        Me.Checksabado.Text = "SABADO"
        Me.Checksabado.UseVisualStyleBackColor = True
        '
        'Comboidioma
        '
        Me.Comboidioma.FormattingEnabled = True
        Me.Comboidioma.Items.AddRange(New Object() {"INGLÉS ", "PORTUGUÉS ", "FRANCÉS "})
        Me.Comboidioma.Location = New System.Drawing.Point(117, 41)
        Me.Comboidioma.Name = "Comboidioma"
        Me.Comboidioma.Size = New System.Drawing.Size(121, 28)
        Me.Comboidioma.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "IDIOMAS"
        '
        'Radioefectivo
        '
        Me.Radioefectivo.AutoSize = True
        Me.Radioefectivo.Location = New System.Drawing.Point(29, 19)
        Me.Radioefectivo.Name = "Radioefectivo"
        Me.Radioefectivo.Size = New System.Drawing.Size(115, 24)
        Me.Radioefectivo.TabIndex = 10
        Me.Radioefectivo.TabStop = True
        Me.Radioefectivo.Text = "EFECTIVO"
        Me.Radioefectivo.UseVisualStyleBackColor = True
        '
        'Radiocheque
        '
        Me.Radiocheque.AutoSize = True
        Me.Radiocheque.Location = New System.Drawing.Point(29, 42)
        Me.Radiocheque.Name = "Radiocheque"
        Me.Radiocheque.Size = New System.Drawing.Size(102, 24)
        Me.Radiocheque.TabIndex = 11
        Me.Radiocheque.TabStop = True
        Me.Radiocheque.Text = "CHEQUE"
        Me.Radiocheque.UseVisualStyleBackColor = True
        '
        'Groupdatos
        '
        Me.Groupdatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Groupdatos.Controls.Add(Me.Label3)
        Me.Groupdatos.Controls.Add(Me.Label2)
        Me.Groupdatos.Controls.Add(Me.Label1)
        Me.Groupdatos.Controls.Add(Me.Textfecha)
        Me.Groupdatos.Controls.Add(Me.Textnombre)
        Me.Groupdatos.Controls.Add(Me.Textcarnet)
        Me.Groupdatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Groupdatos.Location = New System.Drawing.Point(42, 96)
        Me.Groupdatos.Name = "Groupdatos"
        Me.Groupdatos.Size = New System.Drawing.Size(421, 138)
        Me.Groupdatos.TabIndex = 12
        Me.Groupdatos.TabStop = False
        Me.Groupdatos.Text = "DATOS DEL ESTUDIANTE "
        '
        'Groupidiomaydia
        '
        Me.Groupidiomaydia.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Groupidiomaydia.Controls.Add(Me.Label4)
        Me.Groupidiomaydia.Controls.Add(Me.Comboidioma)
        Me.Groupidiomaydia.Controls.Add(Me.Checksabado)
        Me.Groupidiomaydia.Controls.Add(Me.Checkviernes)
        Me.Groupidiomaydia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Groupidiomaydia.Location = New System.Drawing.Point(487, 96)
        Me.Groupidiomaydia.Name = "Groupidiomaydia"
        Me.Groupidiomaydia.Size = New System.Drawing.Size(352, 138)
        Me.Groupidiomaydia.TabIndex = 13
        Me.Groupidiomaydia.TabStop = False
        Me.Groupidiomaydia.Text = "IDIOMA Y DIA QUE DESEA ESTUDIAR"
        '
        'Grouppago
        '
        Me.Grouppago.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Grouppago.Controls.Add(Me.Radiocheque)
        Me.Grouppago.Controls.Add(Me.Radioefectivo)
        Me.Grouppago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grouppago.Location = New System.Drawing.Point(377, 292)
        Me.Grouppago.Name = "Grouppago"
        Me.Grouppago.Size = New System.Drawing.Size(221, 68)
        Me.Grouppago.TabIndex = 14
        Me.Grouppago.TabStop = False
        Me.Grouppago.Text = "TIPO DE PAGO "
        '
        'Menubotones
        '
        Me.Menubotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.LIMPIARDATOSDEENTRADAToolStripMenuItem, Me.LIMPIARMATRIZToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.Menubotones.Location = New System.Drawing.Point(0, 0)
        Me.Menubotones.Name = "Menubotones"
        Me.Menubotones.Size = New System.Drawing.Size(1002, 24)
        Me.Menubotones.TabIndex = 15
        Me.Menubotones.Text = "MenuStrip1"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR "
        '
        'LIMPIARDATOSDEENTRADAToolStripMenuItem
        '
        Me.LIMPIARDATOSDEENTRADAToolStripMenuItem.Name = "LIMPIARDATOSDEENTRADAToolStripMenuItem"
        Me.LIMPIARDATOSDEENTRADAToolStripMenuItem.Size = New System.Drawing.Size(174, 20)
        Me.LIMPIARDATOSDEENTRADAToolStripMenuItem.Text = "LIMPIAR DATOS DE ENTRADA"
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
        'Datacompleta
        '
        Me.Datacompleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datacompleta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.Datacompleta.Location = New System.Drawing.Point(12, 366)
        Me.Datacompleta.Name = "Datacompleta"
        Me.Datacompleta.Size = New System.Drawing.Size(934, 150)
        Me.Datacompleta.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.HeaderText = "CARNET"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOMBRE"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "IDIOMA "
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "FECHA INSCRIPCIÓN "
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "DIAS A RECIBIR "
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "HORAS A CURSAR "
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "TIPO PAGO "
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "SUBTOTAL"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "DESCUENTO 1 "
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "DESCUENTO 2 "
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "TOTAL A PAGAR "
        Me.Column11.Name = "Column11"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(330, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(343, 36)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ACADEMIA DE IDIOMAS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201900978_IDIOMAS.My.Resources.Resources.tarea_5
        Me.ClientSize = New System.Drawing.Size(1002, 577)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Datacompleta)
        Me.Controls.Add(Me.Grouppago)
        Me.Controls.Add(Me.Groupidiomaydia)
        Me.Controls.Add(Me.Groupdatos)
        Me.Controls.Add(Me.Menubotones)
        Me.MainMenuStrip = Me.Menubotones
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Groupdatos.ResumeLayout(False)
        Me.Groupdatos.PerformLayout()
        Me.Groupidiomaydia.ResumeLayout(False)
        Me.Groupidiomaydia.PerformLayout()
        Me.Grouppago.ResumeLayout(False)
        Me.Grouppago.PerformLayout()
        Me.Menubotones.ResumeLayout(False)
        Me.Menubotones.PerformLayout()
        CType(Me.Datacompleta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Textcarnet As TextBox
    Friend WithEvents Textnombre As TextBox
    Friend WithEvents Textfecha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Checkviernes As CheckBox
    Friend WithEvents Checksabado As CheckBox
    Friend WithEvents Comboidioma As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Radioefectivo As RadioButton
    Friend WithEvents Radiocheque As RadioButton
    Friend WithEvents Groupdatos As GroupBox
    Friend WithEvents Groupidiomaydia As GroupBox
    Friend WithEvents Grouppago As GroupBox
    Friend WithEvents Menubotones As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARDATOSDEENTRADAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARMATRIZToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Datacompleta As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
End Class
