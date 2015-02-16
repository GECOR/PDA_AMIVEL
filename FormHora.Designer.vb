<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FormHora
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.FormMsg_panel_botones = New System.Windows.Forms.Panel
        Me.FormMsg_btn_cancelar = New System.Windows.Forms.Button
        Me.FormMsg_btn_aceptar = New System.Windows.Forms.Button
        Me.FormMsg_panel_botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "+"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(127, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 50)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "+"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(3, 157)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 50)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "-"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(127, 157)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 50)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "-"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(0, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 30)
        Me.Label1.Text = "Horas:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(3, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 30)
        Me.Label2.Text = "1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(127, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 30)
        Me.Label5.Text = "Minutos:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(127, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 30)
        Me.Label3.Text = "50"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(111, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 30)
        Me.Label4.Text = ":"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FormMsg_panel_botones
        '
        Me.FormMsg_panel_botones.Controls.Add(Me.FormMsg_btn_cancelar)
        Me.FormMsg_panel_botones.Controls.Add(Me.FormMsg_btn_aceptar)
        Me.FormMsg_panel_botones.Location = New System.Drawing.Point(3, 223)
        Me.FormMsg_panel_botones.Name = "FormMsg_panel_botones"
        Me.FormMsg_panel_botones.Size = New System.Drawing.Size(234, 42)
        '
        'FormMsg_btn_cancelar
        '
        Me.FormMsg_btn_cancelar.Location = New System.Drawing.Point(122, 4)
        Me.FormMsg_btn_cancelar.Name = "FormMsg_btn_cancelar"
        Me.FormMsg_btn_cancelar.Size = New System.Drawing.Size(109, 35)
        Me.FormMsg_btn_cancelar.TabIndex = 1
        Me.FormMsg_btn_cancelar.Text = "Cancelar"
        '
        'FormMsg_btn_aceptar
        '
        Me.FormMsg_btn_aceptar.Location = New System.Drawing.Point(3, 4)
        Me.FormMsg_btn_aceptar.Name = "FormMsg_btn_aceptar"
        Me.FormMsg_btn_aceptar.Size = New System.Drawing.Size(113, 35)
        Me.FormMsg_btn_aceptar.TabIndex = 0
        Me.FormMsg_btn_aceptar.Text = "Aceptar"
        '
        'FormHora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.FormMsg_panel_botones)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Menu = Me.mainMenu1
        Me.Name = "FormHora"
        Me.Text = "FormHora"
        Me.FormMsg_panel_botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FormMsg_panel_botones As System.Windows.Forms.Panel
    Friend WithEvents FormMsg_btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents FormMsg_btn_aceptar As System.Windows.Forms.Button
End Class
