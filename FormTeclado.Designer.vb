<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FormTeclado
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
        Me.tbRes = New System.Windows.Forms.TextBox
        Me.labPrimera = New System.Windows.Forms.Label
        Me.labModo = New System.Windows.Forms.Label
        Me.but1 = New System.Windows.Forms.Button
        Me.but2 = New System.Windows.Forms.Button
        Me.but3 = New System.Windows.Forms.Button
        Me.butSimb = New System.Windows.Forms.Button
        Me.butC = New System.Windows.Forms.Button
        Me.but6 = New System.Windows.Forms.Button
        Me.but5 = New System.Windows.Forms.Button
        Me.but4 = New System.Windows.Forms.Button
        Me.butAst = New System.Windows.Forms.Button
        Me.but9 = New System.Windows.Forms.Button
        Me.but8 = New System.Windows.Forms.Button
        Me.but7 = New System.Windows.Forms.Button
        Me.but0 = New System.Windows.Forms.Button
        Me.butCancelar = New System.Windows.Forms.Button
        Me.butAceptar = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer
        Me.LabEstado = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'tbRes
        '
        Me.tbRes.Location = New System.Drawing.Point(4, 4)
        Me.tbRes.Name = "tbRes"
        Me.tbRes.Size = New System.Drawing.Size(140, 21)
        Me.tbRes.TabIndex = 0
        '
        'labPrimera
        '
        Me.labPrimera.Location = New System.Drawing.Point(151, 4)
        Me.labPrimera.Name = "labPrimera"
        Me.labPrimera.Size = New System.Drawing.Size(31, 20)
        '
        'labModo
        '
        Me.labModo.Location = New System.Drawing.Point(189, 4)
        Me.labModo.Name = "labModo"
        Me.labModo.Size = New System.Drawing.Size(51, 20)
        '
        'but1
        '
        Me.but1.Location = New System.Drawing.Point(4, 32)
        Me.but1.Name = "but1"
        Me.but1.Size = New System.Drawing.Size(50, 50)
        Me.but1.TabIndex = 3
        Me.but1.Text = "1"
        '
        'but2
        '
        Me.but2.Location = New System.Drawing.Point(60, 32)
        Me.but2.Name = "but2"
        Me.but2.Size = New System.Drawing.Size(50, 50)
        Me.but2.TabIndex = 4
        Me.but2.Text = "2 abc"
        '
        'but3
        '
        Me.but3.Location = New System.Drawing.Point(116, 32)
        Me.but3.Name = "but3"
        Me.but3.Size = New System.Drawing.Size(50, 50)
        Me.but3.TabIndex = 5
        Me.but3.Text = "3 def"
        '
        'butSimb
        '
        Me.butSimb.Location = New System.Drawing.Point(172, 32)
        Me.butSimb.Name = "butSimb"
        Me.butSimb.Size = New System.Drawing.Size(50, 50)
        Me.butSimb.TabIndex = 6
        Me.butSimb.Text = "SIMB"
        '
        'butC
        '
        Me.butC.Location = New System.Drawing.Point(172, 88)
        Me.butC.Name = "butC"
        Me.butC.Size = New System.Drawing.Size(50, 50)
        Me.butC.TabIndex = 10
        Me.butC.Text = "C"
        '
        'but6
        '
        Me.but6.Location = New System.Drawing.Point(116, 88)
        Me.but6.Name = "but6"
        Me.but6.Size = New System.Drawing.Size(50, 50)
        Me.but6.TabIndex = 9
        Me.but6.Text = "6 mno"
        '
        'but5
        '
        Me.but5.Location = New System.Drawing.Point(60, 88)
        Me.but5.Name = "but5"
        Me.but5.Size = New System.Drawing.Size(50, 50)
        Me.but5.TabIndex = 8
        Me.but5.Text = "5 jkl"
        '
        'but4
        '
        Me.but4.Location = New System.Drawing.Point(4, 88)
        Me.but4.Name = "but4"
        Me.but4.Size = New System.Drawing.Size(50, 50)
        Me.but4.TabIndex = 7
        Me.but4.Text = "4 ghi"
        '
        'butAst
        '
        Me.butAst.Location = New System.Drawing.Point(172, 144)
        Me.butAst.Name = "butAst"
        Me.butAst.Size = New System.Drawing.Size(50, 50)
        Me.butAst.TabIndex = 14
        Me.butAst.Text = "*"
        '
        'but9
        '
        Me.but9.Location = New System.Drawing.Point(116, 144)
        Me.but9.Name = "but9"
        Me.but9.Size = New System.Drawing.Size(50, 50)
        Me.but9.TabIndex = 13
        Me.but9.Text = "9 wxyz"
        '
        'but8
        '
        Me.but8.Location = New System.Drawing.Point(60, 144)
        Me.but8.Name = "but8"
        Me.but8.Size = New System.Drawing.Size(50, 50)
        Me.but8.TabIndex = 12
        Me.but8.Text = "8 tuv"
        '
        'but7
        '
        Me.but7.Location = New System.Drawing.Point(4, 144)
        Me.but7.Name = "but7"
        Me.but7.Size = New System.Drawing.Size(50, 50)
        Me.but7.TabIndex = 11
        Me.but7.Text = "7 pqrs"
        '
        'but0
        '
        Me.but0.Location = New System.Drawing.Point(4, 200)
        Me.but0.Name = "but0"
        Me.but0.Size = New System.Drawing.Size(50, 50)
        Me.but0.TabIndex = 17
        Me.but0.Text = "0"
        '
        'butCancelar
        '
        Me.butCancelar.Location = New System.Drawing.Point(60, 200)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(80, 50)
        Me.butCancelar.TabIndex = 18
        Me.butCancelar.Text = "CANCELAR"
        '
        'butAceptar
        '
        Me.butAceptar.Location = New System.Drawing.Point(142, 200)
        Me.butAceptar.Name = "butAceptar"
        Me.butAceptar.Size = New System.Drawing.Size(80, 50)
        Me.butAceptar.TabIndex = 19
        Me.butAceptar.Text = "ACEPTAR"
        '
        'Timer1
        '
        Me.Timer1.Interval = 750
        '
        'LabEstado
        '
        Me.LabEstado.Location = New System.Drawing.Point(189, 4)
        Me.LabEstado.Name = "LabEstado"
        Me.LabEstado.Size = New System.Drawing.Size(48, 20)
        '
        'FormTeclado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.LabEstado)
        Me.Controls.Add(Me.butAceptar)
        Me.Controls.Add(Me.butCancelar)
        Me.Controls.Add(Me.but0)
        Me.Controls.Add(Me.butAst)
        Me.Controls.Add(Me.but9)
        Me.Controls.Add(Me.but8)
        Me.Controls.Add(Me.but7)
        Me.Controls.Add(Me.butC)
        Me.Controls.Add(Me.but6)
        Me.Controls.Add(Me.but5)
        Me.Controls.Add(Me.but4)
        Me.Controls.Add(Me.butSimb)
        Me.Controls.Add(Me.but3)
        Me.Controls.Add(Me.but2)
        Me.Controls.Add(Me.but1)
        Me.Controls.Add(Me.labModo)
        Me.Controls.Add(Me.labPrimera)
        Me.Controls.Add(Me.tbRes)
        Me.Menu = Me.mainMenu1
        Me.Name = "FormTeclado"
        Me.Text = "FormTeclado"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbRes As System.Windows.Forms.TextBox
    Friend WithEvents labPrimera As System.Windows.Forms.Label
    Friend WithEvents labModo As System.Windows.Forms.Label
    Friend WithEvents but1 As System.Windows.Forms.Button
    Friend WithEvents but2 As System.Windows.Forms.Button
    Friend WithEvents but3 As System.Windows.Forms.Button
    Friend WithEvents butSimb As System.Windows.Forms.Button
    Friend WithEvents butC As System.Windows.Forms.Button
    Friend WithEvents but6 As System.Windows.Forms.Button
    Friend WithEvents but5 As System.Windows.Forms.Button
    Friend WithEvents but4 As System.Windows.Forms.Button
    Friend WithEvents butAst As System.Windows.Forms.Button
    Friend WithEvents but9 As System.Windows.Forms.Button
    Friend WithEvents but8 As System.Windows.Forms.Button
    Friend WithEvents but7 As System.Windows.Forms.Button
    Friend WithEvents but0 As System.Windows.Forms.Button
    Friend WithEvents butCancelar As System.Windows.Forms.Button
    Friend WithEvents butAceptar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LabEstado As System.Windows.Forms.Label
End Class
