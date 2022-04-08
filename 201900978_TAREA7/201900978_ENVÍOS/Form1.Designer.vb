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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Textnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Textvalor = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AceptarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOSTRARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOSTRARESTADISTICASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Combotipopaquete = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Combotipoenvio = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Listnombre = New System.Windows.Forms.ListBox()
        Me.Listvalor = New System.Windows.Forms.ListBox()
        Me.Listpeso = New System.Windows.Forms.ListBox()
        Me.Listpaquete = New System.Windows.Forms.ListBox()
        Me.Listenvio = New System.Windows.Forms.ListBox()
        Me.Listimpuesto = New System.Windows.Forms.ListBox()
        Me.Listparcial = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Listtotal = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Textlociones = New System.Windows.Forms.TextBox()
        Me.Textplastico = New System.Windows.Forms.TextBox()
        Me.Textdocumentos = New System.Windows.Forms.TextBox()
        Me.Textropa = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del Cliente "
        '
        'Textnombre
        '
        Me.Textnombre.Location = New System.Drawing.Point(154, 36)
        Me.Textnombre.Name = "Textnombre"
        Me.Textnombre.Size = New System.Drawing.Size(100, 25)
        Me.Textnombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Valor de Paquete "
        '
        'Textvalor
        '
        Me.Textvalor.Location = New System.Drawing.Point(154, 63)
        Me.Textvalor.Name = "Textvalor"
        Me.Textvalor.Size = New System.Drawing.Size(100, 25)
        Me.Textvalor.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptarToolStripMenuItem, Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem, Me.MOSTRARVECTORESToolStripMenuItem, Me.MOSTRARESTADISTICASToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1337, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AceptarToolStripMenuItem
        '
        Me.AceptarToolStripMenuItem.Name = "AceptarToolStripMenuItem"
        Me.AceptarToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AceptarToolStripMenuItem.Text = "ACEPTAR"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS "
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR VECTORES "
        '
        'MOSTRARVECTORESToolStripMenuItem
        '
        Me.MOSTRARVECTORESToolStripMenuItem.Name = "MOSTRARVECTORESToolStripMenuItem"
        Me.MOSTRARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(133, 20)
        Me.MOSTRARVECTORESToolStripMenuItem.Text = "MOSTRAR VECTORES "
        '
        'MOSTRARESTADISTICASToolStripMenuItem
        '
        Me.MOSTRARESTADISTICASToolStripMenuItem.Name = "MOSTRARESTADISTICASToolStripMenuItem"
        Me.MOSTRARESTADISTICASToolStripMenuItem.Size = New System.Drawing.Size(144, 20)
        Me.MOSTRARESTADISTICASToolStripMenuItem.Text = "MOSTRAR RESULTADOS"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "TIPO DE PAQUETE "
        '
        'Combotipopaquete
        '
        Me.Combotipopaquete.FormattingEnabled = True
        Me.Combotipopaquete.Items.AddRange(New Object() {"Documentos ", "Ropa ", "Artículos Pedecederos ", "Artículo de Plástico ", "Lociones "})
        Me.Combotipopaquete.Location = New System.Drawing.Point(147, 23)
        Me.Combotipopaquete.Name = "Combotipopaquete"
        Me.Combotipopaquete.Size = New System.Drawing.Size(121, 27)
        Me.Combotipopaquete.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(299, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "TIPO DE ENVÍO"
        '
        'Combotipoenvio
        '
        Me.Combotipoenvio.FormattingEnabled = True
        Me.Combotipoenvio.Items.AddRange(New Object() {"Camion", "Moto"})
        Me.Combotipoenvio.Location = New System.Drawing.Point(411, 22)
        Me.Combotipoenvio.Name = "Combotipoenvio"
        Me.Combotipoenvio.Size = New System.Drawing.Size(121, 27)
        Me.Combotipoenvio.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Textvalor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Textnombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(284, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 101)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.Combotipoenvio)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Combotipopaquete)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(146, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(562, 66)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TIPOS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "CLIENTE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(114, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "VALOR "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(202, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "PESO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(266, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 19)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "TIPO PAQUETE"
        '
        'Listnombre
        '
        Me.Listnombre.FormattingEnabled = True
        Me.Listnombre.Location = New System.Drawing.Point(17, 33)
        Me.Listnombre.Name = "Listnombre"
        Me.Listnombre.Size = New System.Drawing.Size(77, 251)
        Me.Listnombre.TabIndex = 15
        '
        'Listvalor
        '
        Me.Listvalor.FormattingEnabled = True
        Me.Listvalor.Location = New System.Drawing.Point(100, 33)
        Me.Listvalor.Name = "Listvalor"
        Me.Listvalor.Size = New System.Drawing.Size(77, 251)
        Me.Listvalor.TabIndex = 16
        '
        'Listpeso
        '
        Me.Listpeso.FormattingEnabled = True
        Me.Listpeso.Location = New System.Drawing.Point(183, 33)
        Me.Listpeso.Name = "Listpeso"
        Me.Listpeso.Size = New System.Drawing.Size(77, 251)
        Me.Listpeso.TabIndex = 17
        '
        'Listpaquete
        '
        Me.Listpaquete.FormattingEnabled = True
        Me.Listpaquete.Location = New System.Drawing.Point(277, 33)
        Me.Listpaquete.Name = "Listpaquete"
        Me.Listpaquete.Size = New System.Drawing.Size(77, 251)
        Me.Listpaquete.TabIndex = 18
        '
        'Listenvio
        '
        Me.Listenvio.FormattingEnabled = True
        Me.Listenvio.Location = New System.Drawing.Point(397, 33)
        Me.Listenvio.Name = "Listenvio"
        Me.Listenvio.Size = New System.Drawing.Size(77, 251)
        Me.Listenvio.TabIndex = 19
        '
        'Listimpuesto
        '
        Me.Listimpuesto.FormattingEnabled = True
        Me.Listimpuesto.Location = New System.Drawing.Point(502, 33)
        Me.Listimpuesto.Name = "Listimpuesto"
        Me.Listimpuesto.Size = New System.Drawing.Size(77, 251)
        Me.Listimpuesto.TabIndex = 20
        '
        'Listparcial
        '
        Me.Listparcial.FormattingEnabled = True
        Me.Listparcial.Location = New System.Drawing.Point(608, 33)
        Me.Listparcial.Name = "Listparcial"
        Me.Listparcial.Size = New System.Drawing.Size(79, 251)
        Me.Listparcial.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(386, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 19)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "TIPO DE ENVIO "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(502, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 19)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "IMPUESTO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(710, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 19)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "PAGO TOTAL "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(595, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 19)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "PAGO PARCIAL"
        '
        'Listtotal
        '
        Me.Listtotal.FormattingEnabled = True
        Me.Listtotal.Location = New System.Drawing.Point(714, 33)
        Me.Listtotal.Name = "Listtotal"
        Me.Listtotal.Size = New System.Drawing.Size(79, 251)
        Me.Listtotal.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(26, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(357, 19)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Total (Q) de lo que se envió de los paquetes de Lociones."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(26, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(339, 19)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Cuántos paquetes de artículos de plástico se enviaron"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(26, 153)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(377, 19)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Total (Q) de lo que se envió de los paquetes de documentos"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(57, 216)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(273, 19)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Total de paquetes de ropa que se enviaron."
        '
        'Textlociones
        '
        Me.Textlociones.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textlociones.Location = New System.Drawing.Point(144, 53)
        Me.Textlociones.Name = "Textlociones"
        Me.Textlociones.Size = New System.Drawing.Size(119, 25)
        Me.Textlociones.TabIndex = 31
        '
        'Textplastico
        '
        Me.Textplastico.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textplastico.Location = New System.Drawing.Point(144, 125)
        Me.Textplastico.Name = "Textplastico"
        Me.Textplastico.Size = New System.Drawing.Size(119, 25)
        Me.Textplastico.TabIndex = 32
        '
        'Textdocumentos
        '
        Me.Textdocumentos.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textdocumentos.Location = New System.Drawing.Point(144, 188)
        Me.Textdocumentos.Name = "Textdocumentos"
        Me.Textdocumentos.Size = New System.Drawing.Size(119, 25)
        Me.Textdocumentos.TabIndex = 33
        '
        'Textropa
        '
        Me.Textropa.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textropa.Location = New System.Drawing.Point(144, 252)
        Me.Textropa.Name = "Textropa"
        Me.Textropa.Size = New System.Drawing.Size(119, 25)
        Me.Textropa.TabIndex = 34
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Textropa)
        Me.GroupBox3.Controls.Add(Me.Textdocumentos)
        Me.GroupBox3.Controls.Add(Me.Textplastico)
        Me.GroupBox3.Controls.Add(Me.Textlociones)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(848, 131)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(420, 299)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RESULTADOS "
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Listtotal)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Listparcial)
        Me.GroupBox4.Controls.Add(Me.Listimpuesto)
        Me.GroupBox4.Controls.Add(Me.Listenvio)
        Me.GroupBox4.Controls.Add(Me.Listpaquete)
        Me.GroupBox4.Controls.Add(Me.Listpeso)
        Me.GroupBox4.Controls.Add(Me.Listvalor)
        Me.GroupBox4.Controls.Add(Me.Listnombre)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(26, 302)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(816, 308)
        Me.GroupBox4.TabIndex = 36
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "LISTAS "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201900978_ENVÍOS.My.Resources.Resources.images
        Me.ClientSize = New System.Drawing.Size(1337, 709)
        Me.Controls.Add(Me.GroupBox4)
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
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Textnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Textvalor As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AceptarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Combotipopaquete As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Combotipoenvio As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Listnombre As ListBox
    Friend WithEvents Listparcial As ListBox
    Friend WithEvents Listvalor As ListBox
    Friend WithEvents Listpeso As ListBox
    Friend WithEvents Listpaquete As ListBox
    Friend WithEvents Listenvio As ListBox
    Friend WithEvents Listimpuesto As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Listtotal As ListBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Textlociones As TextBox
    Friend WithEvents Textplastico As TextBox
    Friend WithEvents Textdocumentos As TextBox
    Friend WithEvents Textropa As TextBox
    Friend WithEvents MOSTRARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOSTRARESTADISTICASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox4 As GroupBox
End Class
