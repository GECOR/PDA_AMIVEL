Public Class FormHora
    Inherits System.Windows.Forms.Form

    Private fecha As DateTime
    Private cDestino As Control

    Public Sub Mostrar(ByVal sTitulo As String, ByVal cDes As Control, Optional ByVal habilitaHoraActual As Boolean = False)
        Me.Text = sTitulo
        cDestino = cDes
        If cDes.Text = "" Then
            fecha = Now
            If (habilitaHoraActual) Then
                fecha = CDate(CStr(fecha.Date) + " " + CStr(fecha.Hour) + ":" + CStr(fecha.Minute))
            Else
                fecha = CDate(CStr(fecha.Date) + " 0:30")
            End If
        Else
            fecha = CDate(cDes.Text)
        End If

        'butHoraMenos.Enabled = habilitaHora
        'butHoraMas.Enabled = habilitaHora
        'butMinMenos.Enabled = habilitaHora
        'butMinMas.Enabled = habilitaHora

        Me.Show()
    End Sub

    Private Sub FormFechaS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fecha = fecha.AddSeconds(-fecha.Second)
        labHora.Text = fecha.Hour
        labMin.Text = fecha.Minute
    End Sub

    Private Sub butHoraMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butHoraMenos.Click
        If fecha.Hour > 0 Then
            fecha = fecha.AddHours(-1)
        End If
        labHora.Text = fecha.Hour
    End Sub

    Private Sub butHoraMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butHoraMas.Click
        fecha = fecha.AddHours(1)
        If fecha.Hour = 0 Then
            fecha = fecha.AddHours(-1)
        End If
        labHora.Text = fecha.Hour
    End Sub

    Private Sub butMinMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butMinMenos.Click
        If fecha.Minute > 0 Then
            fecha = fecha.AddMinutes(-5)
        End If
        labMin.Text = fecha.Minute
    End Sub

    Private Sub butMinMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butMinMas.Click
        fecha = fecha.AddMinutes(5)
        If fecha.Minute = 0 Then
            'fecha = fecha.AddMinutes(-1)
            fecha = fecha.AddHours(-1)
        End If
        labMin.Text = fecha.Minute
    End Sub

    Private Sub butCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCancelar.Click
        Me.Close()
    End Sub

    Private Sub butAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAceptar.Click
        cDestino.Text = fecha.Hour.ToString + ":" + fecha.Minute.ToString
        Me.Close()
    End Sub
End Class