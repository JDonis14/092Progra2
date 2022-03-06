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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.TextDiashospitalizados = New System.Windows.Forms.TextBox()
        Me.TextHonorarios = New System.Windows.Forms.TextBox()
        Me.Groupdatos = New System.Windows.Forms.GroupBox()
        Me.Radioprivada = New System.Windows.Forms.RadioButton()
        Me.Radiosemiprivada = New System.Windows.Forms.RadioButton()
        Me.Radionoprivada = New System.Windows.Forms.RadioButton()
        Me.Grouphabitacion = New System.Windows.Forms.GroupBox()
        Me.Checkencamamiento = New System.Windows.Forms.CheckBox()
        Me.Checkoperacion = New System.Windows.Forms.CheckBox()
        Me.Checkmaternidad = New System.Windows.Forms.CheckBox()
        Me.Groupservicios = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboPago = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Grouppago = New System.Windows.Forms.GroupBox()
        Me.Menubotones = New System.Windows.Forms.MenuStrip()
        Me.LimpiarDatosDeEntradaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarListboxvectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarAplicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListNombre = New System.Windows.Forms.ListBox()
        Me.ListNit = New System.Windows.Forms.ListBox()
        Me.Listhospitalizados = New System.Windows.Forms.ListBox()
        Me.Listhabitacion = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Listservicios = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Listpago = New System.Windows.Forms.ListBox()
        Me.Listsubtotal = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Listdescuentos = New System.Windows.Forms.ListBox()
        Me.Listtotal = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Groupresultados = New System.Windows.Forms.GroupBox()
        Me.TextNit = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Groupdatos.SuspendLayout()
        Me.Grouphabitacion.SuspendLayout()
        Me.Groupservicios.SuspendLayout()
        Me.Grouppago.SuspendLayout()
        Me.Menubotones.SuspendLayout()
        Me.Groupresultados.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Paciente "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No. Días Hospitalizado "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 133)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Honorarios de Médico "
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(194, 30)
        Me.TextNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(132, 24)
        Me.TextNombre.TabIndex = 4
        '
        'TextDiashospitalizados
        '
        Me.TextDiashospitalizados.Location = New System.Drawing.Point(194, 96)
        Me.TextDiashospitalizados.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextDiashospitalizados.Name = "TextDiashospitalizados"
        Me.TextDiashospitalizados.Size = New System.Drawing.Size(132, 24)
        Me.TextDiashospitalizados.TabIndex = 6
        '
        'TextHonorarios
        '
        Me.TextHonorarios.Location = New System.Drawing.Point(194, 130)
        Me.TextHonorarios.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextHonorarios.Name = "TextHonorarios"
        Me.TextHonorarios.Size = New System.Drawing.Size(132, 24)
        Me.TextHonorarios.TabIndex = 7
        '
        'Groupdatos
        '
        Me.Groupdatos.Controls.Add(Me.Label15)
        Me.Groupdatos.Controls.Add(Me.TextNit)
        Me.Groupdatos.Controls.Add(Me.Label1)
        Me.Groupdatos.Controls.Add(Me.TextHonorarios)
        Me.Groupdatos.Controls.Add(Me.TextDiashospitalizados)
        Me.Groupdatos.Controls.Add(Me.Label3)
        Me.Groupdatos.Controls.Add(Me.Label4)
        Me.Groupdatos.Controls.Add(Me.TextNombre)
        Me.Groupdatos.Location = New System.Drawing.Point(170, 100)
        Me.Groupdatos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Groupdatos.Name = "Groupdatos"
        Me.Groupdatos.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Groupdatos.Size = New System.Drawing.Size(342, 187)
        Me.Groupdatos.TabIndex = 8
        Me.Groupdatos.TabStop = False
        Me.Groupdatos.Text = "DATOS DEL PACIENTE "
        '
        'Radioprivada
        '
        Me.Radioprivada.AutoSize = True
        Me.Radioprivada.Location = New System.Drawing.Point(15, 32)
        Me.Radioprivada.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Radioprivada.Name = "Radioprivada"
        Me.Radioprivada.Size = New System.Drawing.Size(76, 23)
        Me.Radioprivada.TabIndex = 9
        Me.Radioprivada.TabStop = True
        Me.Radioprivada.Text = "Privada "
        Me.Radioprivada.UseVisualStyleBackColor = True
        '
        'Radiosemiprivada
        '
        Me.Radiosemiprivada.AutoSize = True
        Me.Radiosemiprivada.Location = New System.Drawing.Point(15, 65)
        Me.Radiosemiprivada.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Radiosemiprivada.Name = "Radiosemiprivada"
        Me.Radiosemiprivada.Size = New System.Drawing.Size(106, 23)
        Me.Radiosemiprivada.TabIndex = 10
        Me.Radiosemiprivada.TabStop = True
        Me.Radiosemiprivada.Text = "Semiprivada "
        Me.Radiosemiprivada.UseVisualStyleBackColor = True
        '
        'Radionoprivada
        '
        Me.Radionoprivada.AutoSize = True
        Me.Radionoprivada.Location = New System.Drawing.Point(15, 98)
        Me.Radionoprivada.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Radionoprivada.Name = "Radionoprivada"
        Me.Radionoprivada.Size = New System.Drawing.Size(99, 23)
        Me.Radionoprivada.TabIndex = 11
        Me.Radionoprivada.TabStop = True
        Me.Radionoprivada.Text = "No Privada "
        Me.Radionoprivada.UseVisualStyleBackColor = True
        '
        'Grouphabitacion
        '
        Me.Grouphabitacion.Controls.Add(Me.Radiosemiprivada)
        Me.Grouphabitacion.Controls.Add(Me.Radionoprivada)
        Me.Grouphabitacion.Controls.Add(Me.Radioprivada)
        Me.Grouphabitacion.Location = New System.Drawing.Point(543, 98)
        Me.Grouphabitacion.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Grouphabitacion.Name = "Grouphabitacion"
        Me.Grouphabitacion.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Grouphabitacion.Size = New System.Drawing.Size(177, 135)
        Me.Grouphabitacion.TabIndex = 12
        Me.Grouphabitacion.TabStop = False
        Me.Grouphabitacion.Text = "TIPO DE HABITACIÓN "
        '
        'Checkencamamiento
        '
        Me.Checkencamamiento.AutoSize = True
        Me.Checkencamamiento.Location = New System.Drawing.Point(38, 20)
        Me.Checkencamamiento.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Checkencamamiento.Name = "Checkencamamiento"
        Me.Checkencamamiento.Size = New System.Drawing.Size(123, 23)
        Me.Checkencamamiento.TabIndex = 13
        Me.Checkencamamiento.Text = "Encamamiento "
        Me.Checkencamamiento.UseVisualStyleBackColor = True
        '
        'Checkoperacion
        '
        Me.Checkoperacion.AutoSize = True
        Me.Checkoperacion.Location = New System.Drawing.Point(38, 52)
        Me.Checkoperacion.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Checkoperacion.Name = "Checkoperacion"
        Me.Checkoperacion.Size = New System.Drawing.Size(96, 23)
        Me.Checkoperacion.TabIndex = 14
        Me.Checkoperacion.Text = "Operación "
        Me.Checkoperacion.UseVisualStyleBackColor = True
        '
        'Checkmaternidad
        '
        Me.Checkmaternidad.AutoSize = True
        Me.Checkmaternidad.Location = New System.Drawing.Point(38, 84)
        Me.Checkmaternidad.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Checkmaternidad.Name = "Checkmaternidad"
        Me.Checkmaternidad.Size = New System.Drawing.Size(103, 23)
        Me.Checkmaternidad.TabIndex = 15
        Me.Checkmaternidad.Text = "Maternidad "
        Me.Checkmaternidad.UseVisualStyleBackColor = True
        '
        'Groupservicios
        '
        Me.Groupservicios.Controls.Add(Me.Checkmaternidad)
        Me.Groupservicios.Controls.Add(Me.Checkoperacion)
        Me.Groupservicios.Controls.Add(Me.Checkencamamiento)
        Me.Groupservicios.Location = New System.Drawing.Point(741, 98)
        Me.Groupservicios.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Groupservicios.Name = "Groupservicios"
        Me.Groupservicios.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Groupservicios.Size = New System.Drawing.Size(191, 135)
        Me.Groupservicios.TabIndex = 16
        Me.Groupservicios.TabStop = False
        Me.Groupservicios.Text = "TIPO DE SERVICIO "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(430, 46)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(364, 32)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "HOSPITAL LA BENDICIÓN "
        '
        'ComboPago
        '
        Me.ComboPago.FormattingEnabled = True
        Me.ComboPago.Items.AddRange(New Object() {"Efectivo ", "Cheque ", "Tarjeta de debito", "Tarjeta de credito "})
        Me.ComboPago.Location = New System.Drawing.Point(81, 21)
        Me.ComboPago.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ComboPago.Name = "ComboPago"
        Me.ComboPago.Size = New System.Drawing.Size(98, 27)
        Me.ComboPago.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 24)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 19)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "PAGO "
        '
        'Grouppago
        '
        Me.Grouppago.Controls.Add(Me.Label6)
        Me.Grouppago.Controls.Add(Me.ComboPago)
        Me.Grouppago.Location = New System.Drawing.Point(639, 239)
        Me.Grouppago.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Grouppago.Name = "Grouppago"
        Me.Grouppago.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Grouppago.Size = New System.Drawing.Size(201, 63)
        Me.Grouppago.TabIndex = 20
        Me.Grouppago.TabStop = False
        Me.Grouppago.Text = "TIPO DE PAGO "
        '
        'Menubotones
        '
        Me.Menubotones.BackColor = System.Drawing.Color.Yellow
        Me.Menubotones.Font = New System.Drawing.Font("Segoe UI Emoji", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menubotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarDatosDeEntradaToolStripMenuItem, Me.LimpiarListboxvectoresToolStripMenuItem, Me.CalcularToolStripMenuItem, Me.CerrarAplicaciónToolStripMenuItem})
        Me.Menubotones.Location = New System.Drawing.Point(0, 0)
        Me.Menubotones.Name = "Menubotones"
        Me.Menubotones.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.Menubotones.Size = New System.Drawing.Size(1148, 28)
        Me.Menubotones.TabIndex = 21
        Me.Menubotones.Text = "MenuStrip1"
        '
        'LimpiarDatosDeEntradaToolStripMenuItem
        '
        Me.LimpiarDatosDeEntradaToolStripMenuItem.Name = "LimpiarDatosDeEntradaToolStripMenuItem"
        Me.LimpiarDatosDeEntradaToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.LimpiarDatosDeEntradaToolStripMenuItem.Text = "Limpiar datos de entrada "
        '
        'LimpiarListboxvectoresToolStripMenuItem
        '
        Me.LimpiarListboxvectoresToolStripMenuItem.Name = "LimpiarListboxvectoresToolStripMenuItem"
        Me.LimpiarListboxvectoresToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
        Me.LimpiarListboxvectoresToolStripMenuItem.Text = "Limpiar listbox/vectores "
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.CalcularToolStripMenuItem.Text = "Calcular "
        '
        'CerrarAplicaciónToolStripMenuItem
        '
        Me.CerrarAplicaciónToolStripMenuItem.Name = "CerrarAplicaciónToolStripMenuItem"
        Me.CerrarAplicaciónToolStripMenuItem.Size = New System.Drawing.Size(135, 24)
        Me.CerrarAplicaciónToolStripMenuItem.Text = "Cerrar Aplicación"
        '
        'ListNombre
        '
        Me.ListNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListNombre.FormattingEnabled = True
        Me.ListNombre.ItemHeight = 19
        Me.ListNombre.Location = New System.Drawing.Point(26, 51)
        Me.ListNombre.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ListNombre.Name = "ListNombre"
        Me.ListNombre.Size = New System.Drawing.Size(75, 118)
        Me.ListNombre.TabIndex = 22
        '
        'ListNit
        '
        Me.ListNit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListNit.FormattingEnabled = True
        Me.ListNit.ItemHeight = 19
        Me.ListNit.Location = New System.Drawing.Point(123, 51)
        Me.ListNit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ListNit.Name = "ListNit"
        Me.ListNit.Size = New System.Drawing.Size(68, 118)
        Me.ListNit.TabIndex = 23
        '
        'Listhospitalizados
        '
        Me.Listhospitalizados.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Listhospitalizados.FormattingEnabled = True
        Me.Listhospitalizados.ItemHeight = 19
        Me.Listhospitalizados.Location = New System.Drawing.Point(219, 51)
        Me.Listhospitalizados.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Listhospitalizados.Name = "Listhospitalizados"
        Me.Listhospitalizados.Size = New System.Drawing.Size(74, 118)
        Me.Listhospitalizados.TabIndex = 24
        '
        'Listhabitacion
        '
        Me.Listhabitacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Listhabitacion.FormattingEnabled = True
        Me.Listhabitacion.ItemHeight = 19
        Me.Listhabitacion.Location = New System.Drawing.Point(339, 51)
        Me.Listhabitacion.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Listhabitacion.Name = "Listhabitacion"
        Me.Listhabitacion.Size = New System.Drawing.Size(74, 118)
        Me.Listhabitacion.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 19)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nombre Paciente "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(144, 29)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 19)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "NIT "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(195, 29)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 19)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Dias Hospitalizados "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(327, 29)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 19)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Tipo Habitacion "
        '
        'Listservicios
        '
        Me.Listservicios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Listservicios.FormattingEnabled = True
        Me.Listservicios.ItemHeight = 19
        Me.Listservicios.Location = New System.Drawing.Point(462, 51)
        Me.Listservicios.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Listservicios.Name = "Listservicios"
        Me.Listservicios.Size = New System.Drawing.Size(70, 118)
        Me.Listservicios.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(440, 29)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 19)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Tipo de Servicio "
        '
        'Listpago
        '
        Me.Listpago.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Listpago.FormattingEnabled = True
        Me.Listpago.ItemHeight = 19
        Me.Listpago.Location = New System.Drawing.Point(569, 51)
        Me.Listpago.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Listpago.Name = "Listpago"
        Me.Listpago.Size = New System.Drawing.Size(73, 118)
        Me.Listpago.TabIndex = 32
        '
        'Listsubtotal
        '
        Me.Listsubtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Listsubtotal.FormattingEnabled = True
        Me.Listsubtotal.ItemHeight = 19
        Me.Listsubtotal.Location = New System.Drawing.Point(658, 51)
        Me.Listsubtotal.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Listsubtotal.Name = "Listsubtotal"
        Me.Listsubtotal.Size = New System.Drawing.Size(74, 118)
        Me.Listsubtotal.TabIndex = 33
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(559, 29)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 19)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Tipo de Pago "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(657, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 19)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "SUBTOTAL"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(739, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 19)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "DESCUENTOS "
        '
        'Listdescuentos
        '
        Me.Listdescuentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Listdescuentos.FormattingEnabled = True
        Me.Listdescuentos.ItemHeight = 19
        Me.Listdescuentos.Location = New System.Drawing.Point(752, 51)
        Me.Listdescuentos.Name = "Listdescuentos"
        Me.Listdescuentos.Size = New System.Drawing.Size(71, 118)
        Me.Listdescuentos.TabIndex = 36
        '
        'Listtotal
        '
        Me.Listtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Listtotal.FormattingEnabled = True
        Me.Listtotal.ItemHeight = 19
        Me.Listtotal.Location = New System.Drawing.Point(848, 51)
        Me.Listtotal.Name = "Listtotal"
        Me.Listtotal.Size = New System.Drawing.Size(83, 118)
        Me.Listtotal.TabIndex = 37
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(860, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 19)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "TOTAL "
        '
        'Groupresultados
        '
        Me.Groupresultados.Controls.Add(Me.Label14)
        Me.Groupresultados.Controls.Add(Me.Listtotal)
        Me.Groupresultados.Controls.Add(Me.Listdescuentos)
        Me.Groupresultados.Controls.Add(Me.Label13)
        Me.Groupresultados.Controls.Add(Me.Label12)
        Me.Groupresultados.Controls.Add(Me.Listsubtotal)
        Me.Groupresultados.Controls.Add(Me.Label11)
        Me.Groupresultados.Controls.Add(Me.Listpago)
        Me.Groupresultados.Controls.Add(Me.Label10)
        Me.Groupresultados.Controls.Add(Me.Listservicios)
        Me.Groupresultados.Controls.Add(Me.Label9)
        Me.Groupresultados.Controls.Add(Me.Label8)
        Me.Groupresultados.Controls.Add(Me.Label7)
        Me.Groupresultados.Controls.Add(Me.Label2)
        Me.Groupresultados.Controls.Add(Me.Listhabitacion)
        Me.Groupresultados.Controls.Add(Me.Listhospitalizados)
        Me.Groupresultados.Controls.Add(Me.ListNit)
        Me.Groupresultados.Controls.Add(Me.ListNombre)
        Me.Groupresultados.Location = New System.Drawing.Point(76, 319)
        Me.Groupresultados.Name = "Groupresultados"
        Me.Groupresultados.Size = New System.Drawing.Size(1029, 179)
        Me.Groupresultados.TabIndex = 39
        Me.Groupresultados.TabStop = False
        Me.Groupresultados.Text = "CALCULOS "
        '
        'TextNit
        '
        Me.TextNit.Location = New System.Drawing.Point(194, 63)
        Me.TextNit.Name = "TextNit"
        Me.TextNit.Size = New System.Drawing.Size(132, 24)
        Me.TextNit.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 66)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 21)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "No. de NIT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201900978_HOSPITAL.My.Resources.Resources.tarea_4_progra
        Me.ClientSize = New System.Drawing.Size(1148, 544)
        Me.Controls.Add(Me.Groupresultados)
        Me.Controls.Add(Me.Grouppago)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Groupservicios)
        Me.Controls.Add(Me.Grouphabitacion)
        Me.Controls.Add(Me.Groupdatos)
        Me.Controls.Add(Me.Menubotones)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.Menubotones
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Groupdatos.ResumeLayout(False)
        Me.Groupdatos.PerformLayout()
        Me.Grouphabitacion.ResumeLayout(False)
        Me.Grouphabitacion.PerformLayout()
        Me.Groupservicios.ResumeLayout(False)
        Me.Groupservicios.PerformLayout()
        Me.Grouppago.ResumeLayout(False)
        Me.Grouppago.PerformLayout()
        Me.Menubotones.ResumeLayout(False)
        Me.Menubotones.PerformLayout()
        Me.Groupresultados.ResumeLayout(False)
        Me.Groupresultados.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents TextDiashospitalizados As TextBox
    Friend WithEvents TextHonorarios As TextBox
    Friend WithEvents Groupdatos As GroupBox
    Friend WithEvents Radioprivada As RadioButton
    Friend WithEvents Radiosemiprivada As RadioButton
    Friend WithEvents Radionoprivada As RadioButton
    Friend WithEvents Grouphabitacion As GroupBox
    Friend WithEvents Checkencamamiento As CheckBox
    Friend WithEvents Checkoperacion As CheckBox
    Friend WithEvents Checkmaternidad As CheckBox
    Friend WithEvents Groupservicios As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboPago As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Grouppago As GroupBox
    Friend WithEvents Menubotones As MenuStrip
    Friend WithEvents LimpiarDatosDeEntradaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarListboxvectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarAplicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListNombre As ListBox
    Friend WithEvents ListNit As ListBox
    Friend WithEvents Listhospitalizados As ListBox
    Friend WithEvents Listhabitacion As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Listservicios As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Listpago As ListBox
    Friend WithEvents Listsubtotal As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Listdescuentos As ListBox
    Friend WithEvents Listtotal As ListBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Groupresultados As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextNit As TextBox
End Class
