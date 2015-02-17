Public Class FormTeclado
    Inherits System.Windows.Forms.Form

    Private sSimb() As Char
    Private sButAnt As Integer = -1
    Private arrTexto(9) As String
    Private iIndModo As Integer
    Private iModos() As Integer
    Private colDestino As Collection
    Public Const MODO_MIN = 0
    Public Const MODO_MAY = 1
    Public Const MODO_NUM = 2
    Public Const MODO_SIM = 3

    Private sSQLFiltro As String

    'Mostrar el formulario
    Public Sub Mostrar(ByVal sTitulo As String, ByVal colDest As Collection, ByVal iModosOpt() As Integer)
        sSQLFiltro = ""
        colDestino = colDest
        iModos = iModosOpt
        Modo(0)
        butSimb.Enabled = iModos(iModos.Length - 1) = 3
        Dim c As Control = colDest(1)
        tbRes.Text = c.Text
        'Caben aproximadamente 15 caracteres
        Me.Text = sTitulo
        Me.Show()
    End Sub

    'Mostrar el formulario como paso previo a un filtro
    Public Sub MostrarFiltro(ByVal sTitulo As String, ByVal sSQL As String, ByVal colDest As Collection, ByVal iModosOpt() As Integer)
        sSQLFiltro = sSQL
        colDestino = colDest
        iModos = iModosOpt
        Modo(0)
        butSimb.Enabled = iModos(iModos.Length - 1) = 3
        'Caben aproximadamente 15 caracteres
        Me.Text = sTitulo
        Me.Show()
    End Sub

    'Evento al pulsar un botón
    Private Sub butClick(ByVal index As Integer)
        Timer1.Enabled = False
        If sSimb Is Nothing Then
            Construir(index)
            PonerUltimo()
        Else
            If sButAnt = index Then
                If sSimb.Length > 1 Then
                    sSimb = Rotar(sSimb)
                Else
                    PonerUltimo()
                End If
            Else
                PonerUltimo()
                Timer1_Tick(Nothing, Nothing)
                Construir(index)
                '''''''''''''''
                'Construir(index)
                'PonerUltimo()
                'Timer1_Tick(Nothing, Nothing)

            End If
        End If
        'QuitarUltimo()
        'PonerUltimo()
        If sSimb <> Nothing Then
            CambiarUltimo()
            labEstado.Text = CarAStr(sSimb)
            labPrimera.Text = sSimb(0)
        End If
        sButAnt = index
        Timer1.Enabled = True
    End Sub
    'Quita el último carácter del texto
    Private Sub QuitarUltimo()
        Dim sTmp As String = tbRes.Text
        If sTmp.Length > 0 Then
            tbRes.Text = sTmp.Substring(0, sTmp.Length - 1)
        End If
    End Sub
    'Agrega el carácter actual al texto
    Private Sub PonerUltimo()
        Dim sTmp As String = tbRes.Text
        If sTmp.Length = 0 Then
            tbRes.Text = Char.ToUpper(sSimb(0))
        Else
            tbRes.Text = sTmp + sSimb(0)
        End If
    End Sub
    'Cambia el último carácter del texto por el actual
    Private Sub CambiarUltimo()
        Dim sTmp As String = tbRes.Text
        If Char.IsUpper(sTmp.Chars(sTmp.Length - 1)) Then
            tbRes.Text = sTmp.Substring(0, sTmp.Length - 1) + Char.ToUpper(sSimb(0))
        Else
            tbRes.Text = sTmp.Substring(0, sTmp.Length - 1) + sSimb(0)
        End If
    End Sub

    'Construir el array de símbolos
    Private Sub Construir(ByVal index As Integer)
        Dim sTmp As String = arrTexto(index)
        sSimb = Dividir(sTmp)
        'If sTmp.Length > 0 Then
        '    sSimb = Dividir(sTmp)
        '    'ElseIf sTmp = "0" Then
        '    '    ReDim sSimb(2)
        '    '    sSimb(0) = " "
        '    '    sSimb(1) = "0"
        '    'ElseIf sTmp = "1" Then
        '    '    ReDim sSimb(2)
        '    '    sSimb(0) = "."
        '    '    sSimb(1) = "1"
        'Else
        '    ReDim sSimb(0)
        '    sSimb(0) = CStr(index)
        'End If
    End Sub
    'Pasar el array a una cadena
    Private Function CarAStr(ByVal car As Char()) As String
        CarAStr = ""
        Dim i As Integer
        For i = 1 To car.Length - 1
            CarAStr = CarAStr + car(i)
        Next
    End Function
    'Dividir una cadena en el array
    Private Function Dividir(ByVal sTmp As String) As Char()
        Dim i As Integer
        Dim iLen As Integer = sTmp.Length
        Dim sRes(iLen - 1) As Char
        'sRes(iLen - 2) = sTmp.Substring(0, 1).Chars(0)
        'sRes(iLen) = CStr(index)
        'sTmp = sTmp.Substring(2)
        For i = 0 To sTmp.Length - 1
            sRes(i) = sTmp.Chars(i)
        Next
        Dividir = sRes
    End Function
    'Rotar el array
    Private Function Rotar(ByVal car As Char()) As Char()
        Dim i As Integer
        Dim copia(car.Length - 1) As Char
        For i = 1 To car.Length - 1
            copia(i - 1) = car(i)
        Next
        copia(copia.Length - 1) = car(0)
        Rotar = copia
    End Function

    Private Sub but0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles but0.Click
        butClick(0)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        labEstado.Text = ""
        labPrimera.Text = ""
        sSimb = Nothing
        Timer1.Enabled = False
    End Sub

    Private Sub butC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butC.Click
        QuitarUltimo()
        Timer1_Tick(Nothing, Nothing)
    End Sub

    'Cambia el modo del teclado
    Private Sub Modo(ByVal modo As Integer)
        If modo >= iModos.Length Then
            iIndModo = 0
        Else
            iIndModo = modo
        End If
        Select Case iModos(iIndModo)
            Case MODO_MIN
                arrTexto(0) = " 0"
                arrTexto(1) = ".,*1"
                arrTexto(2) = "abc2"
                arrTexto(3) = "def3"
                arrTexto(4) = "ghi4"
                arrTexto(5) = "jkl5"
                arrTexto(6) = "mnño6"
                arrTexto(7) = "pqrs7"
                arrTexto(8) = "tuv8"
                arrTexto(9) = "wxyz9"
                but0.Text = "ESP 0"
                but1.Text = ".,* 1"
                but2.Text = "abc 2"
                but3.Text = "def 3"
                but4.Text = "ghi 4"
                but5.Text = "jkl 5"
                but6.Text = "mnño 6"
                but7.Text = "pqrs 7"
                but8.Text = "tuv 8"
                but9.Text = "wxyz 9"
                labModo.Text = "abc"
            Case MODO_MAY
                arrTexto(0) = " 0"
                arrTexto(1) = ".,*1"
                arrTexto(2) = "ABC2"
                arrTexto(3) = "DEF3"
                arrTexto(4) = "GHI4"
                arrTexto(5) = "JKL5"
                arrTexto(6) = "MNÑO6"
                arrTexto(7) = "PQRS7"
                arrTexto(8) = "TUV8"
                arrTexto(9) = "WXYZ9"
                but0.Text = "ESP 0"
                but1.Text = ".,* 1"
                but2.Text = "ABC 2"
                but3.Text = "DEF 3"
                but4.Text = "GHI 4"
                but5.Text = "JKL 5"
                but6.Text = "MNÑO 6"
                but7.Text = "PQRS 7"
                but8.Text = "TUV 8"
                but9.Text = "WXYZ 9"
                labModo.Text = "ABC"
            Case MODO_NUM
                arrTexto(0) = "0"
                arrTexto(1) = "1"
                arrTexto(2) = "2"
                arrTexto(3) = "3"
                arrTexto(4) = "4"
                arrTexto(5) = "5"
                arrTexto(6) = "6"
                arrTexto(7) = "7"
                arrTexto(8) = "8"
                arrTexto(9) = "9"
                but0.Text = "0"
                but1.Text = "1"
                but2.Text = "2"
                but3.Text = "3"
                but4.Text = "4"
                but5.Text = "5"
                but6.Text = "6"
                but7.Text = "7"
                but8.Text = "8"
                but9.Text = "9"
                labModo.Text = "123"
            Case MODO_SIM
                arrTexto(0) = "ESP 0"
                arrTexto(1) = ".,;:1"
                arrTexto(2) = "_\2"
                arrTexto(3) = "¿?¡!3"
                arrTexto(4) = """" + "'4"
                arrTexto(5) = "+-*/=5"
                arrTexto(6) = "@6"
                arrTexto(7) = "()[]{}7"
                arrTexto(8) = "&%€$|8"
                arrTexto(9) = "#~9"
                but0.Text = "0 "
                but1.Text = "1.,;:"
                but2.Text = "2_\"
                but3.Text = "3¿?¡!"
                but4.Text = "4" + """" + "'"
                but5.Text = "5+-*/="
                but6.Text = "6@"
                but7.Text = "7()[]{}"
                but8.Text = "8&%€$|"
                but9.Text = "9#~"
                labModo.Text = "@#€$"
        End Select
    End Sub

    Private Sub butAst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAst.Click
        Timer1_Tick(Nothing, Nothing)
        Modo(iIndModo + 1)
    End Sub

    Private Sub butSimb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSimb.Click
        Modo(iModos.Length - 1)
    End Sub

    Private Sub butCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCancelar.Click
        Me.Close()
    End Sub

    Private Sub butAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAceptar.Click
        If sSQLFiltro <> "" Then
            'Dim formT As New FormTecladoBG
            'formT.Mostrar(Me.Text, sSQLFiltro.Replace("@Campo", tbRes.Text), colDestino)
        Else
            'bDestino.Text = tbRes.Text
            Dim i As Integer
            Dim c As Control
            For i = 1 To colDestino.Count
                c = colDestino(i)
                c.Text = tbRes.Text
            Next
        End If
        Me.Close()
    End Sub

    Private Sub FormTeclado_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Timer1_Tick(Nothing, Nothing)
    End Sub

    Private Sub but1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but1.Click
        butClick(1)
    End Sub

    Private Sub but2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but2.Click
        butClick(2)
    End Sub

    Private Sub but3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but3.Click
        butClick(3)
    End Sub

    Private Sub but4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but4.Click
        butClick(4)
    End Sub

    Private Sub but5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but5.Click
        butClick(5)
    End Sub

    Private Sub but6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but6.Click
        butClick(6)
    End Sub

    Private Sub but7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but7.Click
        butClick(7)
    End Sub

    Private Sub but8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but8.Click
        butClick(8)
    End Sub

    Private Sub but9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but9.Click
        butClick(9)
    End Sub
End Class