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
        Me.Radioavioneta = New System.Windows.Forms.RadioButton()
        Me.Radiojet = New System.Windows.Forms.RadioButton()
        Me.Radiohelicoptero = New System.Windows.Forms.RadioButton()
        Me.Grouptipo = New System.Windows.Forms.GroupBox()
        Me.Checkcosta = New System.Windows.Forms.CheckBox()
        Me.Checkizabal = New System.Windows.Forms.CheckBox()
        Me.Checkpeten = New System.Windows.Forms.CheckBox()
        Me.Groupdestinos = New System.Windows.Forms.GroupBox()
        Me.Textpeten = New System.Windows.Forms.TextBox()
        Me.Textizabal = New System.Windows.Forms.TextBox()
        Me.Textcosta = New System.Windows.Forms.TextBox()
        Me.Buttoncalcular = New System.Windows.Forms.Button()
        Me.Buttonlimpiar = New System.Windows.Forms.Button()
        Me.Buttonsalir = New System.Windows.Forms.Button()
        Me.TextBoxAC = New System.Windows.Forms.TextBox()
        Me.TextBoxJS = New System.Windows.Forms.TextBox()
        Me.TextBoxHC = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxAI = New System.Windows.Forms.TextBox()
        Me.TextBoxJI = New System.Windows.Forms.TextBox()
        Me.TextBoxHI = New System.Windows.Forms.TextBox()
        Me.TextBoxAP = New System.Windows.Forms.TextBox()
        Me.TextBoxJP = New System.Windows.Forms.TextBox()
        Me.TextBoxHP = New System.Windows.Forms.TextBox()
        Me.Groupprecio = New System.Windows.Forms.GroupBox()
        Me.TextBoxSubT = New System.Windows.Forms.TextBox()
        Me.TextBoxDes1 = New System.Windows.Forms.TextBox()
        Me.TextBoxDes2 = New System.Windows.Forms.TextBox()
        Me.Textboxtotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Grouptotales = New System.Windows.Forms.GroupBox()
        Me.Grouptipo.SuspendLayout()
        Me.Groupdestinos.SuspendLayout()
        Me.Groupprecio.SuspendLayout()
        Me.Grouptotales.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(318, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CONTROL DE VUELOS "
        '
        'Radioavioneta
        '
        Me.Radioavioneta.AutoSize = True
        Me.Radioavioneta.Location = New System.Drawing.Point(44, 25)
        Me.Radioavioneta.Name = "Radioavioneta"
        Me.Radioavioneta.Size = New System.Drawing.Size(70, 17)
        Me.Radioavioneta.TabIndex = 1
        Me.Radioavioneta.TabStop = True
        Me.Radioavioneta.Text = "Avioneta "
        Me.Radioavioneta.UseVisualStyleBackColor = True
        '
        'Radiojet
        '
        Me.Radiojet.AutoSize = True
        Me.Radiojet.Location = New System.Drawing.Point(44, 48)
        Me.Radiojet.Name = "Radiojet"
        Me.Radiojet.Size = New System.Drawing.Size(44, 17)
        Me.Radiojet.TabIndex = 2
        Me.Radiojet.TabStop = True
        Me.Radiojet.Text = "JET"
        Me.Radiojet.UseVisualStyleBackColor = True
        '
        'Radiohelicoptero
        '
        Me.Radiohelicoptero.AutoSize = True
        Me.Radiohelicoptero.Location = New System.Drawing.Point(44, 71)
        Me.Radiohelicoptero.Name = "Radiohelicoptero"
        Me.Radiohelicoptero.Size = New System.Drawing.Size(79, 17)
        Me.Radiohelicoptero.TabIndex = 3
        Me.Radiohelicoptero.TabStop = True
        Me.Radiohelicoptero.Text = "Helicóptero"
        Me.Radiohelicoptero.UseVisualStyleBackColor = True
        '
        'Grouptipo
        '
        Me.Grouptipo.Controls.Add(Me.Radiohelicoptero)
        Me.Grouptipo.Controls.Add(Me.Radiojet)
        Me.Grouptipo.Controls.Add(Me.Radioavioneta)
        Me.Grouptipo.Location = New System.Drawing.Point(35, 46)
        Me.Grouptipo.Name = "Grouptipo"
        Me.Grouptipo.Size = New System.Drawing.Size(200, 116)
        Me.Grouptipo.TabIndex = 4
        Me.Grouptipo.TabStop = False
        Me.Grouptipo.Text = "TIPO DE AERONAVE "
        '
        'Checkcosta
        '
        Me.Checkcosta.AutoSize = True
        Me.Checkcosta.Location = New System.Drawing.Point(25, 26)
        Me.Checkcosta.Name = "Checkcosta"
        Me.Checkcosta.Size = New System.Drawing.Size(75, 17)
        Me.Checkcosta.TabIndex = 5
        Me.Checkcosta.Text = "Costa Sur "
        Me.Checkcosta.UseVisualStyleBackColor = True
        '
        'Checkizabal
        '
        Me.Checkizabal.AutoSize = True
        Me.Checkizabal.Location = New System.Drawing.Point(25, 52)
        Me.Checkizabal.Name = "Checkizabal"
        Me.Checkizabal.Size = New System.Drawing.Size(54, 17)
        Me.Checkizabal.TabIndex = 6
        Me.Checkizabal.Text = "Izabal"
        Me.Checkizabal.UseVisualStyleBackColor = True
        '
        'Checkpeten
        '
        Me.Checkpeten.AutoSize = True
        Me.Checkpeten.Location = New System.Drawing.Point(25, 78)
        Me.Checkpeten.Name = "Checkpeten"
        Me.Checkpeten.Size = New System.Drawing.Size(54, 17)
        Me.Checkpeten.TabIndex = 7
        Me.Checkpeten.Text = "Petén"
        Me.Checkpeten.UseVisualStyleBackColor = True
        '
        'Groupdestinos
        '
        Me.Groupdestinos.Controls.Add(Me.Textpeten)
        Me.Groupdestinos.Controls.Add(Me.Textizabal)
        Me.Groupdestinos.Controls.Add(Me.Textcosta)
        Me.Groupdestinos.Controls.Add(Me.Checkpeten)
        Me.Groupdestinos.Controls.Add(Me.Checkizabal)
        Me.Groupdestinos.Controls.Add(Me.Checkcosta)
        Me.Groupdestinos.Location = New System.Drawing.Point(265, 46)
        Me.Groupdestinos.Name = "Groupdestinos"
        Me.Groupdestinos.Size = New System.Drawing.Size(312, 137)
        Me.Groupdestinos.TabIndex = 8
        Me.Groupdestinos.TabStop = False
        Me.Groupdestinos.Text = "DESTINOS"
        '
        'Textpeten
        '
        Me.Textpeten.Location = New System.Drawing.Point(97, 75)
        Me.Textpeten.Name = "Textpeten"
        Me.Textpeten.Size = New System.Drawing.Size(100, 20)
        Me.Textpeten.TabIndex = 10
        '
        'Textizabal
        '
        Me.Textizabal.Location = New System.Drawing.Point(97, 49)
        Me.Textizabal.Name = "Textizabal"
        Me.Textizabal.Size = New System.Drawing.Size(100, 20)
        Me.Textizabal.TabIndex = 9
        '
        'Textcosta
        '
        Me.Textcosta.Location = New System.Drawing.Point(97, 23)
        Me.Textcosta.Name = "Textcosta"
        Me.Textcosta.Size = New System.Drawing.Size(100, 20)
        Me.Textcosta.TabIndex = 8
        '
        'Buttoncalcular
        '
        Me.Buttoncalcular.Location = New System.Drawing.Point(184, 382)
        Me.Buttoncalcular.Name = "Buttoncalcular"
        Me.Buttoncalcular.Size = New System.Drawing.Size(75, 23)
        Me.Buttoncalcular.TabIndex = 9
        Me.Buttoncalcular.Text = "CALCULAR"
        Me.Buttoncalcular.UseVisualStyleBackColor = True
        '
        'Buttonlimpiar
        '
        Me.Buttonlimpiar.Location = New System.Drawing.Point(265, 382)
        Me.Buttonlimpiar.Name = "Buttonlimpiar"
        Me.Buttonlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.Buttonlimpiar.TabIndex = 10
        Me.Buttonlimpiar.Text = "LIMPIAR"
        Me.Buttonlimpiar.UseVisualStyleBackColor = True
        '
        'Buttonsalir
        '
        Me.Buttonsalir.Location = New System.Drawing.Point(348, 382)
        Me.Buttonsalir.Name = "Buttonsalir"
        Me.Buttonsalir.Size = New System.Drawing.Size(75, 23)
        Me.Buttonsalir.TabIndex = 11
        Me.Buttonsalir.Text = "SALIR"
        Me.Buttonsalir.UseVisualStyleBackColor = True
        '
        'TextBoxAC
        '
        Me.TextBoxAC.Location = New System.Drawing.Point(107, 43)
        Me.TextBoxAC.Name = "TextBoxAC"
        Me.TextBoxAC.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAC.TabIndex = 12
        '
        'TextBoxJS
        '
        Me.TextBoxJS.Location = New System.Drawing.Point(107, 76)
        Me.TextBoxJS.Name = "TextBoxJS"
        Me.TextBoxJS.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxJS.TabIndex = 13
        '
        'TextBoxHC
        '
        Me.TextBoxHC.Location = New System.Drawing.Point(107, 109)
        Me.TextBoxHC.Name = "TextBoxHC"
        Me.TextBoxHC.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHC.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Precio Avioneta "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Precio Jet "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Precio Helicóptero "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(136, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Costa Sur "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(258, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Izabal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(378, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Petén"
        '
        'TextBoxAI
        '
        Me.TextBoxAI.Location = New System.Drawing.Point(230, 43)
        Me.TextBoxAI.Name = "TextBoxAI"
        Me.TextBoxAI.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAI.TabIndex = 21
        '
        'TextBoxJI
        '
        Me.TextBoxJI.Location = New System.Drawing.Point(230, 76)
        Me.TextBoxJI.Name = "TextBoxJI"
        Me.TextBoxJI.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxJI.TabIndex = 22
        '
        'TextBoxHI
        '
        Me.TextBoxHI.Location = New System.Drawing.Point(230, 109)
        Me.TextBoxHI.Name = "TextBoxHI"
        Me.TextBoxHI.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHI.TabIndex = 23
        '
        'TextBoxAP
        '
        Me.TextBoxAP.Location = New System.Drawing.Point(347, 43)
        Me.TextBoxAP.Name = "TextBoxAP"
        Me.TextBoxAP.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAP.TabIndex = 24
        '
        'TextBoxJP
        '
        Me.TextBoxJP.Location = New System.Drawing.Point(347, 76)
        Me.TextBoxJP.Name = "TextBoxJP"
        Me.TextBoxJP.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxJP.TabIndex = 25
        '
        'TextBoxHP
        '
        Me.TextBoxHP.Location = New System.Drawing.Point(347, 109)
        Me.TextBoxHP.Name = "TextBoxHP"
        Me.TextBoxHP.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHP.TabIndex = 26
        '
        'Groupprecio
        '
        Me.Groupprecio.Controls.Add(Me.TextBoxHP)
        Me.Groupprecio.Controls.Add(Me.TextBoxJP)
        Me.Groupprecio.Controls.Add(Me.TextBoxAP)
        Me.Groupprecio.Controls.Add(Me.TextBoxHI)
        Me.Groupprecio.Controls.Add(Me.TextBoxJI)
        Me.Groupprecio.Controls.Add(Me.TextBoxAI)
        Me.Groupprecio.Controls.Add(Me.Label7)
        Me.Groupprecio.Controls.Add(Me.Label6)
        Me.Groupprecio.Controls.Add(Me.Label5)
        Me.Groupprecio.Controls.Add(Me.Label4)
        Me.Groupprecio.Controls.Add(Me.Label3)
        Me.Groupprecio.Controls.Add(Me.Label2)
        Me.Groupprecio.Controls.Add(Me.TextBoxHC)
        Me.Groupprecio.Controls.Add(Me.TextBoxJS)
        Me.Groupprecio.Controls.Add(Me.TextBoxAC)
        Me.Groupprecio.Location = New System.Drawing.Point(35, 189)
        Me.Groupprecio.Name = "Groupprecio"
        Me.Groupprecio.Size = New System.Drawing.Size(516, 178)
        Me.Groupprecio.TabIndex = 27
        Me.Groupprecio.TabStop = False
        Me.Groupprecio.Text = "Precios de Vuelos "
        '
        'TextBoxSubT
        '
        Me.TextBoxSubT.Location = New System.Drawing.Point(87, 34)
        Me.TextBoxSubT.Name = "TextBoxSubT"
        Me.TextBoxSubT.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSubT.TabIndex = 28
        '
        'TextBoxDes1
        '
        Me.TextBoxDes1.Location = New System.Drawing.Point(87, 64)
        Me.TextBoxDes1.Name = "TextBoxDes1"
        Me.TextBoxDes1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDes1.TabIndex = 29
        '
        'TextBoxDes2
        '
        Me.TextBoxDes2.Location = New System.Drawing.Point(87, 97)
        Me.TextBoxDes2.Name = "TextBoxDes2"
        Me.TextBoxDes2.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDes2.TabIndex = 30
        '
        'Textboxtotal
        '
        Me.Textboxtotal.Location = New System.Drawing.Point(87, 129)
        Me.Textboxtotal.Name = "Textboxtotal"
        Me.Textboxtotal.Size = New System.Drawing.Size(100, 20)
        Me.Textboxtotal.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Subtotal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Descuento 1 "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Descuento 2 "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "TOTAL"
        '
        'Grouptotales
        '
        Me.Grouptotales.Controls.Add(Me.Label11)
        Me.Grouptotales.Controls.Add(Me.Label10)
        Me.Grouptotales.Controls.Add(Me.Label9)
        Me.Grouptotales.Controls.Add(Me.Label8)
        Me.Grouptotales.Controls.Add(Me.Textboxtotal)
        Me.Grouptotales.Controls.Add(Me.TextBoxDes2)
        Me.Grouptotales.Controls.Add(Me.TextBoxDes1)
        Me.Grouptotales.Controls.Add(Me.TextBoxSubT)
        Me.Grouptotales.Location = New System.Drawing.Point(557, 189)
        Me.Grouptotales.Name = "Grouptotales"
        Me.Grouptotales.Size = New System.Drawing.Size(213, 188)
        Me.Grouptotales.TabIndex = 36
        Me.Grouptotales.TabStop = False
        Me.Grouptotales.Text = "Precio Total "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201900978_VUELOS.My.Resources.Resources._5f5b7e5f60758fbf6e0df674_comparador_vuelos
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Grouptotales)
        Me.Controls.Add(Me.Groupprecio)
        Me.Controls.Add(Me.Buttonsalir)
        Me.Controls.Add(Me.Buttonlimpiar)
        Me.Controls.Add(Me.Buttoncalcular)
        Me.Controls.Add(Me.Groupdestinos)
        Me.Controls.Add(Me.Grouptipo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Grouptipo.ResumeLayout(False)
        Me.Grouptipo.PerformLayout()
        Me.Groupdestinos.ResumeLayout(False)
        Me.Groupdestinos.PerformLayout()
        Me.Groupprecio.ResumeLayout(False)
        Me.Groupprecio.PerformLayout()
        Me.Grouptotales.ResumeLayout(False)
        Me.Grouptotales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Radioavioneta As RadioButton
    Friend WithEvents Radiojet As RadioButton
    Friend WithEvents Radiohelicoptero As RadioButton
    Friend WithEvents Grouptipo As GroupBox
    Friend WithEvents Checkcosta As CheckBox
    Friend WithEvents Checkizabal As CheckBox
    Friend WithEvents Checkpeten As CheckBox
    Friend WithEvents Groupdestinos As GroupBox
    Friend WithEvents Textpeten As TextBox
    Friend WithEvents Textizabal As TextBox
    Friend WithEvents Textcosta As TextBox
    Friend WithEvents Buttoncalcular As Button
    Friend WithEvents Buttonlimpiar As Button
    Friend WithEvents Buttonsalir As Button
    Friend WithEvents TextBoxAC As TextBox
    Friend WithEvents TextBoxJS As TextBox
    Friend WithEvents TextBoxHC As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxAI As TextBox
    Friend WithEvents TextBoxJI As TextBox
    Friend WithEvents TextBoxHI As TextBox
    Friend WithEvents TextBoxAP As TextBox
    Friend WithEvents TextBoxJP As TextBox
    Friend WithEvents TextBoxHP As TextBox
    Friend WithEvents Groupprecio As GroupBox
    Friend WithEvents TextBoxSubT As TextBox
    Friend WithEvents TextBoxDes1 As TextBox
    Friend WithEvents TextBoxDes2 As TextBox
    Friend WithEvents Textboxtotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Grouptotales As GroupBox
End Class
