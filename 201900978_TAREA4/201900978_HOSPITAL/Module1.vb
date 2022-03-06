Imports System.Math
Module Module1
    Public lista As Byte = 0
    Public Paciente(6) As String
    Public NIT(6) As String
    Public DHospitalizados(6) As Double
    Public THabitacion(6) As String
    Public TServicio(6) As String
    Public Tpago(6) As String
    Public Subtotal(6) As Double
    Public Descuento(6) As Double
    Public Total(6) As Double
    Public Const PrivadaEn = 350
    Public Const PrivadaOp = 550
    Public Const PrivadaMa = 450
    Public Const SemiEn = 250
    Public Const SemiOp = 400
    Public Const SemiMa = 350
    Public Const NoEncta = 150
    Public Const NoOpe = 300
    Public Const NoMa = 250
    Public Const ChequeEfectivo = 0.15
    Public Const Debito = 0.08
    Public Const Credito = 0.05


    Sub Limpiar_vectores()
        lista = 0
        Form1.ListNombre.Items.Clear()
        Form1.ListNit.Items.Clear()
        Form1.Listhabitacion.Items.Clear()
        Form1.Listhospitalizados.Items.Clear()
        Form1.Listservicios.Items.Clear()
        Form1.Listdescuentos.Items.Clear()
        Form1.Listpago.Items.Clear()
        Form1.Listsubtotal.Items.Clear()
        Form1.Listtotal.Items.Clear()

    End Sub

    Sub Limpiar_entradas()
        Form1.Checkencamamiento.Checked = 0
        Form1.Checkmaternidad.Checked = 0
        Form1.Checkoperacion.Checked = 0
        Form1.Radionoprivada.Checked = 0
        Form1.Radioprivada.Checked = 0
        Form1.Radiosemiprivada.Checked = 0
        Form1.ComboPago.Text = ""
        Form1.TextNombre.Clear()
        Form1.TextNit.Clear()
        Form1.TextHonorarios.Clear()
        Form1.TextDiashospitalizados.Clear()
        Form1.TextNombre.Focus()
    End Sub

    Sub Tiposervicio()
        If (Form1.Checkencamamiento.Checked) Or (Form1.Checkmaternidad.Checked) Or (Form1.Checkoperacion.Checked) Then
            If (Form1.Checkencamamiento.Checked) Or (Form1.Radionoprivada.Checked) Then
                Subtotal(lista) = NoEncta * DHospitalizados(lista)
            End If
            If (Form1.Checkencamamiento.Checked) Or (Form1.Radioprivada.Checked) Then
                Subtotal(lista) = PrivadaEn * DHospitalizados(lista)
            End If
            If (Form1.Checkencamamiento.Checked) Or (Form1.Radiosemiprivada.Checked) Then
                Subtotal(lista) = SemiEn * DHospitalizados(lista)
            End If
            If (Form1.Checkoperacion.Checked) Or (Form1.Radionoprivada.Checked) Then
                Subtotal(lista) = NoOpe * DHospitalizados(lista)
            End If
            If (Form1.Checkoperacion.Checked) Or (Form1.Radioprivada.Checked) Then
                Subtotal(lista) = PrivadaOp * DHospitalizados(lista)
            End If
            If (Form1.Checkoperacion.Checked) Or (Form1.Radiosemiprivada.Checked) Then
                Subtotal(lista) = SemiOp * DHospitalizados(lista)
            End If
            If (Form1.Checkmaternidad.Checked) Or (Form1.Radionoprivada.Checked) Then
                Subtotal(lista) = NoMa * DHospitalizados(lista)
            End If
            If (Form1.Checkmaternidad.Checked) Or (Form1.Radioprivada.Checked) Then
                Subtotal(lista) = PrivadaMa * DHospitalizados(lista)
            End If
            If (Form1.Checkmaternidad.Checked) Or (Form1.Radiosemiprivada.Checked) Then
                Subtotal(lista) = SemiMa * DHospitalizados(lista)
            End If
        Else
            MsgBox("ERROR, no selecciono tipo de servicio o habitación")
            Exit Sub
        End If
    End Sub

    Sub Desc()

        Select Case (Form1.ComboPago.SelectedIndex)
            Case 0
                Tpago(lista) = "Efectivo"
                Descuento(lista) = Subtotal(lista) * ChequeEfectivo
            Case 1
                Tpago(lista) = "Cheque"
                Descuento(lista) = Subtotal(lista) * ChequeEfectivo
            Case 2
                Tpago(lista) = "Tarjeta de debito"
                Descuento(lista) = Subtotal(lista) * Debito
            Case 3
                Tpago(lista) = "Tarjeta de credito"
                Descuento(lista) = Subtotal(lista) * -Credito
        End Select

    End Sub
    Sub Resultados()
        Form1.ListNombre.Items.Add(Paciente(lista))
        Form1.ListNit.Items.Add(NIT(lista))
        Form1.Listhospitalizados.Items.Add(Str(DHospitalizados(lista)))
        Form1.Listservicios.Items.Add(TServicio(lista))
        Form1.Listpago.Items.Add(Tpago(lista))
        Form1.Listhabitacion.Items.Add(THabitacion(lista))
        Form1.Listsubtotal.Items.Add(Str(Round(Subtotal(lista), 2)))
        Form1.Listdescuentos.Items.Add(Str(Round(Descuento(lista), 2)))
        Form1.Listtotal.Items.Add(Str(Round(Total(lista), 2)))

    End Sub
    Function total_todo() As Double
        total_todo = Subtotal(lista) + Descuento(lista)
        Return total_todo

    End Function
End Module
