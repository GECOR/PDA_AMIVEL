<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FormMsg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMsg))
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.FormMsg_icono_alerta = New System.Windows.Forms.PictureBox
        Me.FormMsg_mensaje = New System.Windows.Forms.Label
        Me.FormMsg_panel_botones = New System.Windows.Forms.Panel
        Me.FormMsg_btn_aceptar = New System.Windows.Forms.Button
        Me.FormMsg_btn_cancelar = New System.Windows.Forms.Button
        Me.FormMsg_panel_botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormMsg_icono_alerta
        '
        Me.FormMsg_icono_alerta.Image = CType(resources.GetObject("FormMsg_icono_alerta.Image"), System.Drawing.Image)
        Me.FormMsg_icono_alerta.Location = New System.Drawing.Point(3, 3)
        Me.FormMsg_icono_alerta.Name = "FormMsg_icono_alerta"
        Me.FormMsg_icono_alerta.Size = New System.Drawing.Size(60, 60)
        '
        'FormMsg_mensaje
        '
        Me.FormMsg_mensaje.Location = New System.Drawing.Point(70, 4)
        Me.FormMsg_mensaje.Name = "FormMsg_mensaje"
        Me.FormMsg_mensaje.Size = New System.Drawing.Size(167, 209)
        Me.FormMsg_mensaje.Text = "Mensaje de error"
        '
        'FormMsg_panel_botones
        '
        Me.FormMsg_panel_botones.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormMsg_panel_botones.Controls.Add(Me.FormMsg_btn_cancelar)
        Me.FormMsg_panel_botones.Controls.Add(Me.FormMsg_btn_aceptar)
        Me.FormMsg_panel_botones.Location = New System.Drawing.Point(3, 216)
        Me.FormMsg_panel_botones.Name = "FormMsg_panel_botones"
        Me.FormMsg_panel_botones.Size = New System.Drawing.Size(234, 42)
        '
        'FormMsg_btn_aceptar
        '
        Me.FormMsg_btn_aceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FormMsg_btn_aceptar.Location = New System.Drawing.Point(3, 4)
        Me.FormMsg_btn_aceptar.Name = "FormMsg_btn_aceptar"
        Me.FormMsg_btn_aceptar.Size = New System.Drawing.Size(113, 35)
        Me.FormMsg_btn_aceptar.TabIndex = 0
        Me.FormMsg_btn_aceptar.Text = "Aceptar"
        '
        'FormMsg_btn_cancelar
        '
        Me.FormMsg_btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FormMsg_btn_cancelar.Location = New System.Drawing.Point(122, 4)
        Me.FormMsg_btn_cancelar.Name = "FormMsg_btn_cancelar"
        Me.FormMsg_btn_cancelar.Size = New System.Drawing.Size(109, 35)
        Me.FormMsg_btn_cancelar.TabIndex = 1
        Me.FormMsg_btn_cancelar.Text = "Cancelar"
        '
        'FormMsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.FormMsg_panel_botones)
        Me.Controls.Add(Me.FormMsg_mensaje)
        Me.Controls.Add(Me.FormMsg_icono_alerta)
        Me.Menu = Me.mainMenu1
        Me.Name = "FormMsg"
        Me.Text = "FormMsg"
        Me.FormMsg_panel_botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormMsg_icono_alerta As System.Windows.Forms.PictureBox
    Friend WithEvents FormMsg_mensaje As System.Windows.Forms.Label
    Friend WithEvents FormMsg_panel_botones As System.Windows.Forms.Panel
    Friend WithEvents FormMsg_btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents FormMsg_btn_aceptar As System.Windows.Forms.Button
End Class
