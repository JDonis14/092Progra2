<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Cliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Compra = New System.Windows.Forms.CheckBox()
        Me.Venta = New System.Windows.Forms.CheckBox()
        Me.QuetzalesC = New System.Windows.Forms.TextBox()
        Me.QuetzalesV = New System.Windows.Forms.TextBox()
        Me.DolarC = New System.Windows.Forms.RadioButton()
        Me.PesosC = New System.Windows.Forms.RadioButton()
        Me.EurosC = New System.Windows.Forms.RadioButton()
        Me.ColonC = New System.Windows.Forms.RadioButton()
        Me.DolarV = New System.Windows.Forms.RadioButton()
        Me.PesosV = New System.Windows.Forms.RadioButton()
        Me.EuroV = New System.Windows.Forms.RadioButton()
        Me.ColonV = New System.Windows.Forms.RadioButton()
        Me.GrupoV = New System.Windows.Forms.GroupBox()
        Me.GrupoC = New System.Windows.Forms.GroupBox()
        Me.GrupoCV = New System.Windows.Forms.GroupBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.GrupoV.SuspendLayout()
        Me.GrupoC.SuspendLayout()
        Me.GrupoCV.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cliente
        '
        Me.Cliente.Location = New System.Drawing.Point(138, 23)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(100, 23)
        Me.Cliente.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(67, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente"
        '
        'Compra
        '
        Me.Compra.AutoSize = True
        Me.Compra.Location = New System.Drawing.Point(28, 38)
        Me.Compra.Name = "Compra"
        Me.Compra.Size = New System.Drawing.Size(72, 19)
        Me.Compra.TabIndex = 2
        Me.Compra.Text = "Compra "
        Me.Compra.UseVisualStyleBackColor = True
        '
        'Venta
        '
        Me.Venta.AutoSize = True
        Me.Venta.Location = New System.Drawing.Point(28, 65)
        Me.Venta.Name = "Venta"
        Me.Venta.Size = New System.Drawing.Size(58, 19)
        Me.Venta.TabIndex = 3
        Me.Venta.Text = "Venta "
        Me.Venta.UseVisualStyleBackColor = True
        '
        'QuetzalesC
        '
        Me.QuetzalesC.Location = New System.Drawing.Point(106, 34)
        Me.QuetzalesC.Name = "QuetzalesC"
        Me.QuetzalesC.Size = New System.Drawing.Size(100, 23)
        Me.QuetzalesC.TabIndex = 4
        '
        'QuetzalesV
        '
        Me.QuetzalesV.Location = New System.Drawing.Point(107, 65)
        Me.QuetzalesV.Name = "QuetzalesV"
        Me.QuetzalesV.Size = New System.Drawing.Size(99, 23)
        Me.QuetzalesV.TabIndex = 5
        '
        'DolarC
        '
        Me.DolarC.AutoSize = True
        Me.DolarC.Location = New System.Drawing.Point(6, 21)
        Me.DolarC.Name = "DolarC"
        Me.DolarC.Size = New System.Drawing.Size(53, 19)
        Me.DolarC.TabIndex = 6
        Me.DolarC.TabStop = True
        Me.DolarC.Text = "Dolar"
        Me.DolarC.UseVisualStyleBackColor = True
        '
        'PesosC
        '
        Me.PesosC.AutoSize = True
        Me.PesosC.Location = New System.Drawing.Point(6, 46)
        Me.PesosC.Name = "PesosC"
        Me.PesosC.Size = New System.Drawing.Size(115, 19)
        Me.PesosC.TabIndex = 7
        Me.PesosC.TabStop = True
        Me.PesosC.Text = "Pesos Mexicanos"
        Me.PesosC.UseVisualStyleBackColor = True
        '
        'EurosC
        '
        Me.EurosC.AutoSize = True
        Me.EurosC.Location = New System.Drawing.Point(6, 71)
        Me.EurosC.Name = "EurosC"
        Me.EurosC.Size = New System.Drawing.Size(54, 19)
        Me.EurosC.TabIndex = 8
        Me.EurosC.TabStop = True
        Me.EurosC.Text = "Euros"
        Me.EurosC.UseVisualStyleBackColor = True
        '
        'ColonC
        '
        Me.ColonC.AutoSize = True
        Me.ColonC.Location = New System.Drawing.Point(6, 96)
        Me.ColonC.Name = "ColonC"
        Me.ColonC.Size = New System.Drawing.Size(131, 19)
        Me.ColonC.TabIndex = 9
        Me.ColonC.TabStop = True
        Me.ColonC.Text = "Colon Costarricense"
        Me.ColonC.UseVisualStyleBackColor = True
        '
        'DolarV
        '
        Me.DolarV.AutoSize = True
        Me.DolarV.Location = New System.Drawing.Point(6, 26)
        Me.DolarV.Name = "DolarV"
        Me.DolarV.Size = New System.Drawing.Size(56, 19)
        Me.DolarV.TabIndex = 10
        Me.DolarV.TabStop = True
        Me.DolarV.Text = "Dolar "
        Me.DolarV.UseVisualStyleBackColor = True
        '
        'PesosV
        '
        Me.PesosV.AutoSize = True
        Me.PesosV.Location = New System.Drawing.Point(6, 51)
        Me.PesosV.Name = "PesosV"
        Me.PesosV.Size = New System.Drawing.Size(115, 19)
        Me.PesosV.TabIndex = 11
        Me.PesosV.TabStop = True
        Me.PesosV.Text = "Pesos Mexicanos"
        Me.PesosV.UseVisualStyleBackColor = True
        '
        'EuroV
        '
        Me.EuroV.AutoSize = True
        Me.EuroV.Location = New System.Drawing.Point(6, 76)
        Me.EuroV.Name = "EuroV"
        Me.EuroV.Size = New System.Drawing.Size(54, 19)
        Me.EuroV.TabIndex = 12
        Me.EuroV.TabStop = True
        Me.EuroV.Text = "Euros"
        Me.EuroV.UseVisualStyleBackColor = True
        '
        'ColonV
        '
        Me.ColonV.AutoSize = True
        Me.ColonV.Location = New System.Drawing.Point(6, 101)
        Me.ColonV.Name = "ColonV"
        Me.ColonV.Size = New System.Drawing.Size(131, 19)
        Me.ColonV.TabIndex = 13
        Me.ColonV.TabStop = True
        Me.ColonV.Text = "Colon Costarricense"
        Me.ColonV.UseVisualStyleBackColor = True
        '
        'GrupoV
        '
        Me.GrupoV.BackColor = System.Drawing.SystemColors.Info
        Me.GrupoV.Controls.Add(Me.ColonV)
        Me.GrupoV.Controls.Add(Me.EuroV)
        Me.GrupoV.Controls.Add(Me.PesosV)
        Me.GrupoV.Controls.Add(Me.DolarV)
        Me.GrupoV.Location = New System.Drawing.Point(348, 154)
        Me.GrupoV.Name = "GrupoV"
        Me.GrupoV.Size = New System.Drawing.Size(152, 138)
        Me.GrupoV.TabIndex = 14
        Me.GrupoV.TabStop = False
        Me.GrupoV.Text = "Venta "
        Me.GrupoV.Visible = False
        '
        'GrupoC
        '
        Me.GrupoC.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GrupoC.Controls.Add(Me.ColonC)
        Me.GrupoC.Controls.Add(Me.EurosC)
        Me.GrupoC.Controls.Add(Me.PesosC)
        Me.GrupoC.Controls.Add(Me.DolarC)
        Me.GrupoC.Location = New System.Drawing.Point(348, 23)
        Me.GrupoC.Name = "GrupoC"
        Me.GrupoC.Size = New System.Drawing.Size(148, 125)
        Me.GrupoC.TabIndex = 15
        Me.GrupoC.TabStop = False
        Me.GrupoC.Text = "Compra "
        Me.GrupoC.Visible = False
        '
        'GrupoCV
        '
        Me.GrupoCV.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GrupoCV.Controls.Add(Me.QuetzalesV)
        Me.GrupoCV.Controls.Add(Me.QuetzalesC)
        Me.GrupoCV.Controls.Add(Me.Venta)
        Me.GrupoCV.Controls.Add(Me.Compra)
        Me.GrupoCV.Location = New System.Drawing.Point(67, 96)
        Me.GrupoCV.Name = "GrupoCV"
        Me.GrupoCV.Size = New System.Drawing.Size(244, 121)
        Me.GrupoCV.TabIndex = 16
        Me.GrupoCV.TabStop = False
        Me.GrupoCV.Text = "Compra/Venta "
        '
        'Calcular
        '
        Me.Calcular.BackColor = System.Drawing.Color.Yellow
        Me.Calcular.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Calcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Calcular.Location = New System.Drawing.Point(68, 230)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 32)
        Me.Calcular.TabIndex = 6
        Me.Calcular.Text = "Calcular "
        Me.Calcular.UseVisualStyleBackColor = False
        '
        'Limpiar
        '
        Me.Limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Limpiar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Limpiar.Location = New System.Drawing.Point(149, 230)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(75, 32)
        Me.Limpiar.TabIndex = 7
        Me.Limpiar.Text = "Limpiar "
        Me.Limpiar.UseVisualStyleBackColor = False
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.Red
        Me.Salir.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Salir.Location = New System.Drawing.Point(230, 230)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 32)
        Me.Salir.TabIndex = 17
        Me.Salir.Text = "Salir "
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201900978_CASACAMBIOS.My.Resources.Resources.mONEDA_TAREA_3_
        Me.ClientSize = New System.Drawing.Size(553, 334)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.GrupoCV)
        Me.Controls.Add(Me.GrupoC)
        Me.Controls.Add(Me.GrupoV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cliente)
        Me.Name = "Form1"
        Me.Text = "COMPRA Y VENTA DE MONEDAS "
        Me.GrupoV.ResumeLayout(False)
        Me.GrupoV.PerformLayout()
        Me.GrupoC.ResumeLayout(False)
        Me.GrupoC.PerformLayout()
        Me.GrupoCV.ResumeLayout(False)
        Me.GrupoCV.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Compra As CheckBox
    Friend WithEvents Venta As CheckBox
    Friend WithEvents QuetzalesC As TextBox
    Friend WithEvents QuetzalesV As TextBox
    Friend WithEvents DolarC As RadioButton
    Friend WithEvents PesosC As RadioButton
    Friend WithEvents EurosC As RadioButton
    Friend WithEvents ColonC As RadioButton
    Friend WithEvents DolarV As RadioButton
    Friend WithEvents PesosV As RadioButton
    Friend WithEvents EuroV As RadioButton
    Friend WithEvents ColonV As RadioButton
    Friend WithEvents GrupoV As GroupBox
    Friend WithEvents GrupoC As GroupBox
    Friend WithEvents GrupoCV As GroupBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents Salir As Button
End Class
