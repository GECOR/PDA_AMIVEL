Public Class Inicio

    Private iPag As Integer

    Private Sub Inicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        iPag = 0
        Botones(0)
    End Sub

    Private Sub Inicio_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = System.Windows.Forms.Keys.Up) Then
            'Up
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Down) Then
            'Down
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Left) Then
            'Left
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Right) Then
            'Right
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Enter) Then
            'Enter
        End If

    End Sub

    Private Sub Login_btn_usuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login_btn_usuario.Click
        Dim formTeclado As New FormTeclado
        Dim col As New Collection
        col.Add(sender)
        Dim modos(0) As Integer
        modos(0) = formTeclado.MODO_MIN
        formTeclado.Mostrar("Usuario", col, modos)
    End Sub

    Private Sub Login_btn_pass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login_btn_pass.Click
        Dim formTeclado As New FormTeclado
        Dim col As New Collection
        col.Add(sender)
        Dim modos(0) As Integer
        modos(0) = formTeclado.MODO_NUM
        formTeclado.Mostrar("Pass", col, modos)
    End Sub

    Private Sub butAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAtras.Click
        If (iPag = 1) Or (iPag = TabControl1.TabPages.Count) Then
            iPag = 0
        Else
            iPag = iPag - 1
            If iPag < 0 Then
                iPag = 0
            End If
        End If
        Botones(iPag)
    End Sub

    Private Sub Botones(ByVal index As Integer)
        Me.TabControl1.SelectedIndex = index

        butAtras.Enabled = (index > 0)
        butAdelante.Enabled = (index < TabControl1.TabPages.Count - 1)
        butGuardar.Enabled = index = TabControl1.TabPages.Count - 1
        'butBorrar.Enabled = (index = TabControl1.TabPages.Count - 1)

        If (butAtras.Enabled) Then
            butAtras.Text = "<---"
        Else
            butAtras.Text = ""
        End If
        If (butGuardar.Enabled) Then
            butGuardar.Text = "GUARDAR"
        Else
            butGuardar.Text = ""
        End If
        If (butAdelante.Enabled) Then
            butAdelante.Text = "--->"
        Else
            butAdelante.Text = ""
        End If
    End Sub

    Private Sub butAdelante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAdelante.Click
        If iPag > 0 Then
            iPag = iPag + 1
            If iPag >= TabControl1.TabPages.Count Then
                iPag = iPag - 1
            End If
            'iPag = Controlar(iPag)
            Botones(iPag)
        Else
            iPag = iPag + 1
            'iPag = Controlar(iPag)
            Botones(iPag)
            'Si es un parte ya existente hay que configurar el tipo de servicio
            'If TipoServicioID.Text <> "" Then
            '    ConfigurarTipoServicio(TipoServicioID.Text)
            'End If
        End If
    End Sub

    Private Sub nTicket1_btn_coste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nTicket1_btn_coste.Click
        Dim formTeclado As New FormTeclado
        Dim col As New Collection
        col.Add(sender)
        Dim modos(0) As Integer
        modos(0) = formTeclado.MODO_NUM
        formTeclado.Mostrar("COSTE", col, modos)
    End Sub

    Private Sub nTicket1_btn_tiempo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nTicket1_btn_tiempo.Click
        Dim formHora As New FormHora
        formHora.Mostrar("TIEMPO", sender, False)
    End Sub
End Class
