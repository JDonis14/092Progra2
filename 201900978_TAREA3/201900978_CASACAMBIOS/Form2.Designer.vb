<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormR
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ResultadoT As System.Windows.Forms.Button
        Me.ComisiónC = New System.Windows.Forms.TextBox()
        Me.ComisiónV = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Gruporesultados = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TotalVenta = New System.Windows.Forms.TextBox()
        Me.TotalCompra = New System.Windows.Forms.TextBox()
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Salir2 = New System.Windows.Forms.Button()
        ResultadoT = New System.Windows.Forms.Button()
        Me.Gruporesultados.SuspendLayout()
        Me.SuspendLayout()
        '
        'ResultadoT
        '
        ResultadoT.BackColor = System.Drawing.SystemColors.ActiveCaption
        ResultadoT.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        ResultadoT.Location = New System.Drawing.Point(243, 211)
        ResultadoT.Name = "ResultadoT"
        ResultadoT.Size = New System.Drawing.Size(88, 65)
        ResultadoT.TabIndex = 8
        ResultadoT.Text = "Resultado Total"
        ResultadoT.UseVisualStyleBackColor = False
        AddHandler ResultadoT.Click, AddressOf Me.Resultado_Click
        '
        'ComisiónC
        '
        Me.ComisiónC.Enabled = False
        Me.ComisiónC.Location = New System.Drawing.Point(138, 31)
        Me.ComisiónC.Name = "ComisiónC"
        Me.ComisiónC.Size = New System.Drawing.Size(100, 27)
        Me.ComisiónC.TabIndex = 0
        '
        'ComisiónV
        '
        Me.ComisiónV.Enabled = False
        Me.ComisiónV.Location = New System.Drawing.Point(138, 63)
        Me.ComisiónV.Name = "ComisiónV"
        Me.ComisiónV.Size = New System.Drawing.Size(100, 27)
        Me.ComisiónV.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Comisión Compra "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(6, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Comisión Venta"
        '
        'Total
        '
        Me.Total.Enabled = False
        Me.Total.Location = New System.Drawing.Point(231, 116)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(100, 27)
        Me.Total.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(148, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total Final"
        '
        'Gruporesultados
        '
        Me.Gruporesultados.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Gruporesultados.Controls.Add(Me.Label5)
        Me.Gruporesultados.Controls.Add(Me.Label4)
        Me.Gruporesultados.Controls.Add(Me.TotalVenta)
        Me.Gruporesultados.Controls.Add(Me.TotalCompra)
        Me.Gruporesultados.Controls.Add(Me.Label3)
        Me.Gruporesultados.Controls.Add(Me.Total)
        Me.Gruporesultados.Controls.Add(Me.Label2)
        Me.Gruporesultados.Controls.Add(Me.Label1)
        Me.Gruporesultados.Controls.Add(Me.ComisiónV)
        Me.Gruporesultados.Controls.Add(Me.ComisiónC)
        Me.Gruporesultados.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Gruporesultados.Location = New System.Drawing.Point(12, 29)
        Me.Gruporesultados.Name = "Gruporesultados"
        Me.Gruporesultados.Size = New System.Drawing.Size(505, 176)
        Me.Gruporesultados.TabIndex = 6
        Me.Gruporesultados.TabStop = False
        Me.Gruporesultados.Text = "Resultados "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(264, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total de Venta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(248, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total de Compra"
        '
        'TotalVenta
        '
        Me.TotalVenta.Enabled = False
        Me.TotalVenta.Location = New System.Drawing.Point(374, 63)
        Me.TotalVenta.Name = "TotalVenta"
        Me.TotalVenta.Size = New System.Drawing.Size(100, 27)
        Me.TotalVenta.TabIndex = 7
        '
        'TotalCompra
        '
        Me.TotalCompra.Enabled = False
        Me.TotalCompra.Location = New System.Drawing.Point(374, 34)
        Me.TotalCompra.Name = "TotalCompra"
        Me.TotalCompra.Size = New System.Drawing.Size(100, 27)
        Me.TotalCompra.TabIndex = 6
        '
        'Regresar
        '
        Me.Regresar.BackColor = System.Drawing.Color.Yellow
        Me.Regresar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Regresar.Location = New System.Drawing.Point(162, 227)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(75, 33)
        Me.Regresar.TabIndex = 7
        Me.Regresar.Text = "Regresar "
        Me.Regresar.UseVisualStyleBackColor = False
        '
        'Salir2
        '
        Me.Salir2.BackColor = System.Drawing.Color.Red
        Me.Salir2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Salir2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Salir2.Location = New System.Drawing.Point(337, 227)
        Me.Salir2.Name = "Salir2"
        Me.Salir2.Size = New System.Drawing.Size(75, 33)
        Me.Salir2.TabIndex = 10
        Me.Salir2.Text = "Salir "
        Me.Salir2.UseVisualStyleBackColor = False
        '
        'FormR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201900978_CASACAMBIOS.My.Resources.Resources.mONEDA_TAREA_3_
        Me.ClientSize = New System.Drawing.Size(539, 288)
        Me.ControlBox = False
        Me.Controls.Add(Me.Salir2)
        Me.Controls.Add(ResultadoT)
        Me.Controls.Add(Me.Regresar)
        Me.Controls.Add(Me.Gruporesultados)
        Me.Name = "FormR"
        Me.Text = "Resultado de Monedas "
        Me.Gruporesultados.ResumeLayout(False)
        Me.Gruporesultados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComisiónC As TextBox
    Friend WithEvents ComisiónV As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Total As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Gruporesultados As GroupBox
    Friend WithEvents Regresar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TotalVenta As TextBox
    Friend WithEvents TotalCompra As TextBox
    Friend WithEvents Salir2 As Button
End Class
