<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Inicio
    Inherits System.Windows.Forms.Form

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar con el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Login_btn_login = New System.Windows.Forms.Button
        Me.Login_lbl_pass = New System.Windows.Forms.Label
        Me.Login_btn_pass = New System.Windows.Forms.Button
        Me.Login_lbl_usuario = New System.Windows.Forms.Label
        Me.Login_btn_usuario = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Home_mMultas = New System.Windows.Forms.Button
        Me.Home_mTickets = New System.Windows.Forms.Button
        Me.Home_nTicket = New System.Windows.Forms.Button
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.nTicket1_lbl_coste = New System.Windows.Forms.Label
        Me.nTicket1_btn_coste = New System.Windows.Forms.Button
        Me.nTicket1_lbl_tiempo = New System.Windows.Forms.Label
        Me.nTicket1_btn_tiempo = New System.Windows.Forms.Button
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.nTicket2_lbl_devuelto = New System.Windows.Forms.Label
        Me.nTicket2_btn_devuelto = New System.Windows.Forms.Button
        Me.nTicket2_lbl_entregado = New System.Windows.Forms.Label
        Me.nTicket2_btn_entregado = New System.Windows.Forms.Button
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.nTicket3_lbl_desc = New System.Windows.Forms.Label
        Me.nTicket3_btn_desc = New System.Windows.Forms.Button
        Me.nTicket3_lbl_matricula = New System.Windows.Forms.Label
        Me.nTicket3_btn_matricula = New System.Windows.Forms.Button
        Me.nTicket3_lbl_plaza = New System.Windows.Forms.Label
        Me.nTicket3_btn_plaza = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Menu_lbl_usuario = New System.Windows.Forms.Label
        Me.Menu_lbl_hora = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.homa_LogOut = New System.Windows.Forms.Button
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.detalleTicket_descripcion = New System.Windows.Forms.Label
        Me.detalleTicket_matricula = New System.Windows.Forms.Label
        Me.detalleTicket_fecha = New System.Windows.Forms.Label
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.detalleTicket_btn_Terminar = New System.Windows.Forms.Button
        Me.detalleTicket_btn_multa = New System.Windows.Forms.Button
        Me.detalleMulta_btn_Cancelar_Multa = New System.Windows.Forms.Button
        Me.detalleMulta_fecha = New System.Windows.Forms.Label
        Me.detalleMulta_matricula = New System.Windows.Forms.Label
        Me.detalleMulta_descripcion = New System.Windows.Forms.Label
        Me.TabPage8 = New System.Windows.Forms.TabPage
        Me.cMulta_lbl_devuelto = New System.Windows.Forms.Label
        Me.cMulta_btn_devuelto = New System.Windows.Forms.Button
        Me.cMulta_lbl_entregado = New System.Windows.Forms.Label
        Me.cMulta_btn_entregado = New System.Windows.Forms.Button
        Me.cMulta_lbl_IC = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(240, 268)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Login_btn_login)
        Me.TabPage1.Controls.Add(Me.Login_lbl_pass)
        Me.TabPage1.Controls.Add(Me.Login_btn_pass)
        Me.TabPage1.Controls.Add(Me.Login_lbl_usuario)
        Me.TabPage1.Controls.Add(Me.Login_btn_usuario)
        Me.TabPage1.Location = New System.Drawing.Point(0, 0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(240, 245)
        Me.TabPage1.Text = "1_Login"
        '
        'Login_btn_login
        '
        Me.Login_btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Login_btn_login.Location = New System.Drawing.Point(4, 151)
        Me.Login_btn_login.Name = "Login_btn_login"
        Me.Login_btn_login.Size = New System.Drawing.Size(233, 49)
        Me.Login_btn_login.TabIndex = 7
        Me.Login_btn_login.Text = "LOGIN"
        '
        'Login_lbl_pass
        '
        Me.Login_lbl_pass.BackColor = System.Drawing.Color.Silver
        Me.Login_lbl_pass.Location = New System.Drawing.Point(5, 99)
        Me.Login_lbl_pass.Name = "Login_lbl_pass"
        Me.Login_lbl_pass.Size = New System.Drawing.Size(80, 20)
        Me.Login_lbl_pass.Text = "Pass"
        '
        'Login_btn_pass
        '
        Me.Login_btn_pass.BackColor = System.Drawing.Color.Silver
        Me.Login_btn_pass.Location = New System.Drawing.Point(4, 98)
        Me.Login_btn_pass.Name = "Login_btn_pass"
        Me.Login_btn_pass.Size = New System.Drawing.Size(233, 49)
        Me.Login_btn_pass.TabIndex = 6
        '
        'Login_lbl_usuario
        '
        Me.Login_lbl_usuario.BackColor = System.Drawing.Color.Silver
        Me.Login_lbl_usuario.Location = New System.Drawing.Point(5, 46)
        Me.Login_lbl_usuario.Name = "Login_lbl_usuario"
        Me.Login_lbl_usuario.Size = New System.Drawing.Size(80, 21)
        Me.Login_lbl_usuario.Text = "Usuario"
        '
        'Login_btn_usuario
        '
        Me.Login_btn_usuario.BackColor = System.Drawing.Color.Silver
        Me.Login_btn_usuario.Location = New System.Drawing.Point(4, 45)
        Me.Login_btn_usuario.Name = "Login_btn_usuario"
        Me.Login_btn_usuario.Size = New System.Drawing.Size(233, 49)
        Me.Login_btn_usuario.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.homa_LogOut)
        Me.TabPage2.Controls.Add(Me.Home_mMultas)
        Me.TabPage2.Controls.Add(Me.Home_mTickets)
        Me.TabPage2.Controls.Add(Me.Home_nTicket)
        Me.TabPage2.Location = New System.Drawing.Point(0, 0)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(232, 242)
        Me.TabPage2.Text = "2_Home"
        '
        'Home_mMultas
        '
        Me.Home_mMultas.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Home_mMultas.Location = New System.Drawing.Point(4, 118)
        Me.Home_mMultas.Name = "Home_mMultas"
        Me.Home_mMultas.Size = New System.Drawing.Size(233, 30)
        Me.Home_mMultas.TabIndex = 10
        Me.Home_mMultas.Text = "Mis Multas"
        '
        'Home_mTickets
        '
        Me.Home_mTickets.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Home_mTickets.Location = New System.Drawing.Point(4, 82)
        Me.Home_mTickets.Name = "Home_mTickets"
        Me.Home_mTickets.Size = New System.Drawing.Size(233, 30)
        Me.Home_mTickets.TabIndex = 9
        Me.Home_mTickets.Text = "Mis Tickets"
        '
        'Home_nTicket
        '
        Me.Home_nTicket.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Home_nTicket.Location = New System.Drawing.Point(4, 46)
        Me.Home_nTicket.Name = "Home_nTicket"
        Me.Home_nTicket.Size = New System.Drawing.Size(233, 30)
        Me.Home_nTicket.TabIndex = 8
        Me.Home_nTicket.Text = "Nuevo Ticket"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.nTicket1_lbl_coste)
        Me.TabPage3.Controls.Add(Me.nTicket1_btn_coste)
        Me.TabPage3.Controls.Add(Me.nTicket1_lbl_tiempo)
        Me.TabPage3.Controls.Add(Me.nTicket1_btn_tiempo)
        Me.TabPage3.Location = New System.Drawing.Point(0, 0)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(232, 242)
        Me.TabPage3.Text = "3_nTicket1"
        '
        'nTicket1_lbl_coste
        '
        Me.nTicket1_lbl_coste.BackColor = System.Drawing.Color.Silver
        Me.nTicket1_lbl_coste.Location = New System.Drawing.Point(4, 100)
        Me.nTicket1_lbl_coste.Name = "nTicket1_lbl_coste"
        Me.nTicket1_lbl_coste.Size = New System.Drawing.Size(80, 20)
        Me.nTicket1_lbl_coste.Text = "Coste"
        '
        'nTicket1_btn_coste
        '
        Me.nTicket1_btn_coste.BackColor = System.Drawing.Color.Silver
        Me.nTicket1_btn_coste.Location = New System.Drawing.Point(3, 99)
        Me.nTicket1_btn_coste.Name = "nTicket1_btn_coste"
        Me.nTicket1_btn_coste.Size = New System.Drawing.Size(233, 49)
        Me.nTicket1_btn_coste.TabIndex = 10
        '
        'nTicket1_lbl_tiempo
        '
        Me.nTicket1_lbl_tiempo.BackColor = System.Drawing.Color.Silver
        Me.nTicket1_lbl_tiempo.Location = New System.Drawing.Point(4, 47)
        Me.nTicket1_lbl_tiempo.Name = "nTicket1_lbl_tiempo"
        Me.nTicket1_lbl_tiempo.Size = New System.Drawing.Size(80, 21)
        Me.nTicket1_lbl_tiempo.Text = "Tiempo"
        '
        'nTicket1_btn_tiempo
        '
        Me.nTicket1_btn_tiempo.BackColor = System.Drawing.Color.Silver
        Me.nTicket1_btn_tiempo.Location = New System.Drawing.Point(3, 46)
        Me.nTicket1_btn_tiempo.Name = "nTicket1_btn_tiempo"
        Me.nTicket1_btn_tiempo.Size = New System.Drawing.Size(233, 49)
        Me.nTicket1_btn_tiempo.TabIndex = 9
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.nTicket2_lbl_devuelto)
        Me.TabPage4.Controls.Add(Me.nTicket2_btn_devuelto)
        Me.TabPage4.Controls.Add(Me.nTicket2_lbl_entregado)
        Me.TabPage4.Controls.Add(Me.nTicket2_btn_entregado)
        Me.TabPage4.Location = New System.Drawing.Point(0, 0)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(240, 245)
        Me.TabPage4.Text = "4_nTicket2"
        '
        'nTicket2_lbl_devuelto
        '
        Me.nTicket2_lbl_devuelto.BackColor = System.Drawing.Color.Silver
        Me.nTicket2_lbl_devuelto.Location = New System.Drawing.Point(4, 100)
        Me.nTicket2_lbl_devuelto.Name = "nTicket2_lbl_devuelto"
        Me.nTicket2_lbl_devuelto.Size = New System.Drawing.Size(80, 20)
        Me.nTicket2_lbl_devuelto.Text = "Devuelto"
        '
        'nTicket2_btn_devuelto
        '
        Me.nTicket2_btn_devuelto.BackColor = System.Drawing.Color.Silver
        Me.nTicket2_btn_devuelto.Location = New System.Drawing.Point(3, 99)
        Me.nTicket2_btn_devuelto.Name = "nTicket2_btn_devuelto"
        Me.nTicket2_btn_devuelto.Size = New System.Drawing.Size(233, 49)
        Me.nTicket2_btn_devuelto.TabIndex = 14
        '
        'nTicket2_lbl_entregado
        '
        Me.nTicket2_lbl_entregado.BackColor = System.Drawing.Color.Silver
        Me.nTicket2_lbl_entregado.Location = New System.Drawing.Point(4, 47)
        Me.nTicket2_lbl_entregado.Name = "nTicket2_lbl_entregado"
        Me.nTicket2_lbl_entregado.Size = New System.Drawing.Size(80, 21)
        Me.nTicket2_lbl_entregado.Text = "Entregado"
        '
        'nTicket2_btn_entregado
        '
        Me.nTicket2_btn_entregado.BackColor = System.Drawing.Color.Silver
        Me.nTicket2_btn_entregado.Location = New System.Drawing.Point(3, 46)
        Me.nTicket2_btn_entregado.Name = "nTicket2_btn_entregado"
        Me.nTicket2_btn_entregado.Size = New System.Drawing.Size(233, 49)
        Me.nTicket2_btn_entregado.TabIndex = 13
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.nTicket3_lbl_desc)
        Me.TabPage5.Controls.Add(Me.nTicket3_btn_desc)
        Me.TabPage5.Controls.Add(Me.nTicket3_lbl_matricula)
        Me.TabPage5.Controls.Add(Me.nTicket3_btn_matricula)
        Me.TabPage5.Controls.Add(Me.nTicket3_lbl_plaza)
        Me.TabPage5.Controls.Add(Me.nTicket3_btn_plaza)
        Me.TabPage5.Location = New System.Drawing.Point(0, 0)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(240, 245)
        Me.TabPage5.Text = "5_nTicket3"
        '
        'nTicket3_lbl_desc
        '
        Me.nTicket3_lbl_desc.BackColor = System.Drawing.Color.Silver
        Me.nTicket3_lbl_desc.Location = New System.Drawing.Point(4, 139)
        Me.nTicket3_lbl_desc.Name = "nTicket3_lbl_desc"
        Me.nTicket3_lbl_desc.Size = New System.Drawing.Size(80, 20)
        Me.nTicket3_lbl_desc.Text = "Descripcion"
        '
        'nTicket3_btn_desc
        '
        Me.nTicket3_btn_desc.BackColor = System.Drawing.Color.Silver
        Me.nTicket3_btn_desc.Location = New System.Drawing.Point(3, 138)
        Me.nTicket3_btn_desc.Name = "nTicket3_btn_desc"
        Me.nTicket3_btn_desc.Size = New System.Drawing.Size(233, 40)
        Me.nTicket3_btn_desc.TabIndex = 21
        '
        'nTicket3_lbl_matricula
        '
        Me.nTicket3_lbl_matricula.BackColor = System.Drawing.Color.Silver
        Me.nTicket3_lbl_matricula.Location = New System.Drawing.Point(4, 93)
        Me.nTicket3_lbl_matricula.Name = "nTicket3_lbl_matricula"
        Me.nTicket3_lbl_matricula.Size = New System.Drawing.Size(80, 20)
        Me.nTicket3_lbl_matricula.Text = "Matricula"
        '
        'nTicket3_btn_matricula
        '
        Me.nTicket3_btn_matricula.BackColor = System.Drawing.Color.Silver
        Me.nTicket3_btn_matricula.Location = New System.Drawing.Point(3, 92)
        Me.nTicket3_btn_matricula.Name = "nTicket3_btn_matricula"
        Me.nTicket3_btn_matricula.Size = New System.Drawing.Size(233, 40)
        Me.nTicket3_btn_matricula.TabIndex = 18
        '
        'nTicket3_lbl_plaza
        '
        Me.nTicket3_lbl_plaza.BackColor = System.Drawing.Color.Silver
        Me.nTicket3_lbl_plaza.Location = New System.Drawing.Point(4, 47)
        Me.nTicket3_lbl_plaza.Name = "nTicket3_lbl_plaza"
        Me.nTicket3_lbl_plaza.Size = New System.Drawing.Size(80, 21)
        Me.nTicket3_lbl_plaza.Text = "Plaza"
        '
        'nTicket3_btn_plaza
        '
        Me.nTicket3_btn_plaza.BackColor = System.Drawing.Color.Silver
        Me.nTicket3_btn_plaza.Location = New System.Drawing.Point(3, 46)
        Me.nTicket3_btn_plaza.Name = "nTicket3_btn_plaza"
        Me.nTicket3_btn_plaza.Size = New System.Drawing.Size(233, 40)
        Me.nTicket3_btn_plaza.TabIndex = 17
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(160, 204)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 40)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = ">>"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Location = New System.Drawing.Point(80, 204)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "GUARDAR"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(0, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "<<"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Menu_lbl_usuario)
        Me.Panel1.Controls.Add(Me.Menu_lbl_hora)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 40)
        '
        'Menu_lbl_usuario
        '
        Me.Menu_lbl_usuario.Location = New System.Drawing.Point(51, 4)
        Me.Menu_lbl_usuario.Name = "Menu_lbl_usuario"
        Me.Menu_lbl_usuario.Size = New System.Drawing.Size(97, 33)
        Me.Menu_lbl_usuario.Text = "USUARIO"
        Me.Menu_lbl_usuario.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Menu_lbl_hora
        '
        Me.Menu_lbl_hora.Location = New System.Drawing.Point(8, 4)
        Me.Menu_lbl_hora.Name = "Menu_lbl_hora"
        Me.Menu_lbl_hora.Size = New System.Drawing.Size(37, 33)
        Me.Menu_lbl_hora.Text = "HORA"
        Me.Menu_lbl_hora.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Red
        Me.Button4.Location = New System.Drawing.Point(154, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 34)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "CONFLICTO"
        '
        'homa_LogOut
        '
        Me.homa_LogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.homa_LogOut.Location = New System.Drawing.Point(154, 153)
        Me.homa_LogOut.Name = "homa_LogOut"
        Me.homa_LogOut.Size = New System.Drawing.Size(83, 30)
        Me.homa_LogOut.TabIndex = 11
        Me.homa_LogOut.Text = "Log out"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.detalleTicket_btn_multa)
        Me.TabPage6.Controls.Add(Me.detalleTicket_btn_Terminar)
        Me.TabPage6.Controls.Add(Me.detalleTicket_fecha)
        Me.TabPage6.Controls.Add(Me.detalleTicket_matricula)
        Me.TabPage6.Controls.Add(Me.detalleTicket_descripcion)
        Me.TabPage6.Location = New System.Drawing.Point(0, 0)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(240, 245)
        Me.TabPage6.Text = "6_detalleTicket"
        '
        'detalleTicket_descripcion
        '
        Me.detalleTicket_descripcion.Location = New System.Drawing.Point(7, 43)
        Me.detalleTicket_descripcion.Name = "detalleTicket_descripcion"
        Me.detalleTicket_descripcion.Size = New System.Drawing.Size(225, 20)
        Me.detalleTicket_descripcion.Text = "Descripcion"
        '
        'detalleTicket_matricula
        '
        Me.detalleTicket_matricula.Location = New System.Drawing.Point(7, 63)
        Me.detalleTicket_matricula.Name = "detalleTicket_matricula"
        Me.detalleTicket_matricula.Size = New System.Drawing.Size(225, 20)
        Me.detalleTicket_matricula.Text = "Matricula"
        '
        'detalleTicket_fecha
        '
        Me.detalleTicket_fecha.Location = New System.Drawing.Point(7, 83)
        Me.detalleTicket_fecha.Name = "detalleTicket_fecha"
        Me.detalleTicket_fecha.Size = New System.Drawing.Size(225, 20)
        Me.detalleTicket_fecha.Text = "Fecha"
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.detalleMulta_btn_Cancelar_Multa)
        Me.TabPage7.Controls.Add(Me.detalleMulta_fecha)
        Me.TabPage7.Controls.Add(Me.detalleMulta_matricula)
        Me.TabPage7.Controls.Add(Me.detalleMulta_descripcion)
        Me.TabPage7.Location = New System.Drawing.Point(0, 0)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(232, 242)
        Me.TabPage7.Text = "7_detalleMulta"
        '
        'detalleTicket_btn_Terminar
        '
        Me.detalleTicket_btn_Terminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.detalleTicket_btn_Terminar.Location = New System.Drawing.Point(7, 107)
        Me.detalleTicket_btn_Terminar.Name = "detalleTicket_btn_Terminar"
        Me.detalleTicket_btn_Terminar.Size = New System.Drawing.Size(225, 40)
        Me.detalleTicket_btn_Terminar.TabIndex = 5
        Me.detalleTicket_btn_Terminar.Text = "TERMINAR"
        '
        'detalleTicket_btn_multa
        '
        Me.detalleTicket_btn_multa.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.detalleTicket_btn_multa.Location = New System.Drawing.Point(7, 153)
        Me.detalleTicket_btn_multa.Name = "detalleTicket_btn_multa"
        Me.detalleTicket_btn_multa.Size = New System.Drawing.Size(225, 40)
        Me.detalleTicket_btn_multa.TabIndex = 6
        Me.detalleTicket_btn_multa.Text = "MULTA"
        '
        'detalleMulta_btn_Cancelar_Multa
        '
        Me.detalleMulta_btn_Cancelar_Multa.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.detalleMulta_btn_Cancelar_Multa.Location = New System.Drawing.Point(7, 107)
        Me.detalleMulta_btn_Cancelar_Multa.Name = "detalleMulta_btn_Cancelar_Multa"
        Me.detalleMulta_btn_Cancelar_Multa.Size = New System.Drawing.Size(225, 40)
        Me.detalleMulta_btn_Cancelar_Multa.TabIndex = 9
        Me.detalleMulta_btn_Cancelar_Multa.Text = "CANCELAR MULTA"
        '
        'detalleMulta_fecha
        '
        Me.detalleMulta_fecha.Location = New System.Drawing.Point(7, 83)
        Me.detalleMulta_fecha.Name = "detalleMulta_fecha"
        Me.detalleMulta_fecha.Size = New System.Drawing.Size(225, 20)
        Me.detalleMulta_fecha.Text = "Fecha"
        '
        'detalleMulta_matricula
        '
        Me.detalleMulta_matricula.Location = New System.Drawing.Point(7, 63)
        Me.detalleMulta_matricula.Name = "detalleMulta_matricula"
        Me.detalleMulta_matricula.Size = New System.Drawing.Size(225, 20)
        Me.detalleMulta_matricula.Text = "Matricula"
        '
        'detalleMulta_descripcion
        '
        Me.detalleMulta_descripcion.Location = New System.Drawing.Point(7, 43)
        Me.detalleMulta_descripcion.Name = "detalleMulta_descripcion"
        Me.detalleMulta_descripcion.Size = New System.Drawing.Size(225, 20)
        Me.detalleMulta_descripcion.Text = "Descripcion"
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.cMulta_lbl_IC)
        Me.TabPage8.Controls.Add(Me.cMulta_lbl_devuelto)
        Me.TabPage8.Controls.Add(Me.cMulta_btn_devuelto)
        Me.TabPage8.Controls.Add(Me.cMulta_lbl_entregado)
        Me.TabPage8.Controls.Add(Me.cMulta_btn_entregado)
        Me.TabPage8.Location = New System.Drawing.Point(0, 0)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(240, 245)
        Me.TabPage8.Text = "8_cMulta"
        '
        'cMulta_lbl_devuelto
        '
        Me.cMulta_lbl_devuelto.BackColor = System.Drawing.Color.Silver
        Me.cMulta_lbl_devuelto.Location = New System.Drawing.Point(5, 125)
        Me.cMulta_lbl_devuelto.Name = "cMulta_lbl_devuelto"
        Me.cMulta_lbl_devuelto.Size = New System.Drawing.Size(80, 20)
        Me.cMulta_lbl_devuelto.Text = "Devuelto"
        '
        'cMulta_btn_devuelto
        '
        Me.cMulta_btn_devuelto.BackColor = System.Drawing.Color.Silver
        Me.cMulta_btn_devuelto.Location = New System.Drawing.Point(4, 124)
        Me.cMulta_btn_devuelto.Name = "cMulta_btn_devuelto"
        Me.cMulta_btn_devuelto.Size = New System.Drawing.Size(233, 49)
        Me.cMulta_btn_devuelto.TabIndex = 18
        '
        'cMulta_lbl_entregado
        '
        Me.cMulta_lbl_entregado.BackColor = System.Drawing.Color.Silver
        Me.cMulta_lbl_entregado.Location = New System.Drawing.Point(5, 72)
        Me.cMulta_lbl_entregado.Name = "cMulta_lbl_entregado"
        Me.cMulta_lbl_entregado.Size = New System.Drawing.Size(80, 21)
        Me.cMulta_lbl_entregado.Text = "Entregado"
        '
        'cMulta_btn_entregado
        '
        Me.cMulta_btn_entregado.BackColor = System.Drawing.Color.Silver
        Me.cMulta_btn_entregado.Location = New System.Drawing.Point(4, 71)
        Me.cMulta_btn_entregado.Name = "cMulta_btn_entregado"
        Me.cMulta_btn_entregado.Size = New System.Drawing.Size(233, 49)
        Me.cMulta_btn_entregado.TabIndex = 17
        '
        'cMulta_lbl_IC
        '
        Me.cMulta_lbl_IC.Location = New System.Drawing.Point(4, 43)
        Me.cMulta_lbl_IC.Name = "cMulta_lbl_IC"
        Me.cMulta_lbl_IC.Size = New System.Drawing.Size(233, 25)
        Me.cMulta_lbl_IC.Text = "Impuesto de Cancelación:"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.KeyPreview = True
        Me.Menu = Me.mainMenu1
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Login_lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents Login_lbl_pass As System.Windows.Forms.Label
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Menu_lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents Menu_lbl_hora As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Login_btn_pass As System.Windows.Forms.Button
    Friend WithEvents Login_btn_usuario As System.Windows.Forms.Button
    Friend WithEvents Login_btn_login As System.Windows.Forms.Button
    Friend WithEvents Home_mMultas As System.Windows.Forms.Button
    Friend WithEvents Home_mTickets As System.Windows.Forms.Button
    Friend WithEvents Home_nTicket As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents nTicket1_lbl_coste As System.Windows.Forms.Label
    Friend WithEvents nTicket1_btn_coste As System.Windows.Forms.Button
    Friend WithEvents nTicket1_lbl_tiempo As System.Windows.Forms.Label
    Friend WithEvents nTicket1_btn_tiempo As System.Windows.Forms.Button
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents nTicket2_lbl_devuelto As System.Windows.Forms.Label
    Friend WithEvents nTicket2_btn_devuelto As System.Windows.Forms.Button
    Friend WithEvents nTicket2_lbl_entregado As System.Windows.Forms.Label
    Friend WithEvents nTicket2_btn_entregado As System.Windows.Forms.Button
    Friend WithEvents nTicket3_lbl_desc As System.Windows.Forms.Label
    Friend WithEvents nTicket3_btn_desc As System.Windows.Forms.Button
    Friend WithEvents nTicket3_lbl_matricula As System.Windows.Forms.Label
    Friend WithEvents nTicket3_btn_matricula As System.Windows.Forms.Button
    Friend WithEvents nTicket3_lbl_plaza As System.Windows.Forms.Label
    Friend WithEvents nTicket3_btn_plaza As System.Windows.Forms.Button
    Friend WithEvents homa_LogOut As System.Windows.Forms.Button
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents detalleTicket_descripcion As System.Windows.Forms.Label
    Friend WithEvents detalleTicket_fecha As System.Windows.Forms.Label
    Friend WithEvents detalleTicket_matricula As System.Windows.Forms.Label
    Friend WithEvents detalleTicket_btn_multa As System.Windows.Forms.Button
    Friend WithEvents detalleTicket_btn_Terminar As System.Windows.Forms.Button
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents detalleMulta_btn_Cancelar_Multa As System.Windows.Forms.Button
    Friend WithEvents detalleMulta_fecha As System.Windows.Forms.Label
    Friend WithEvents detalleMulta_matricula As System.Windows.Forms.Label
    Friend WithEvents detalleMulta_descripcion As System.Windows.Forms.Label
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents cMulta_lbl_IC As System.Windows.Forms.Label
    Friend WithEvents cMulta_lbl_devuelto As System.Windows.Forms.Label
    Friend WithEvents cMulta_btn_devuelto As System.Windows.Forms.Button
    Friend WithEvents cMulta_lbl_entregado As System.Windows.Forms.Label
    Friend WithEvents cMulta_btn_entregado As System.Windows.Forms.Button

End Class
