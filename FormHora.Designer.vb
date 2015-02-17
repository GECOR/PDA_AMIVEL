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
        Me.butHoraMas = New System.Windows.Forms.Button
        Me.butMinMas = New System.Windows.Forms.Button
        Me.butHoraMenos = New System.Windows.Forms.Button
        Me.butMinMenos = New System.Windows.Forms.Button
        Me.labTitHora = New System.Windows.Forms.Label
        Me.labHora = New System.Windows.Forms.Label
        Me.labTitMin = New System.Windows.Forms.Label
        Me.labMin = New System.Windows.Forms.Label
        Me.labPuntos = New System.Windows.Forms.Label
        Me.FormMsg_panel_botones = New System.Windows.Forms.Panel
        Me.butCancelar = New System.Windows.Forms.Button
        Me.butAceptar = New System.Windows.Forms.Button
        Me.FormMsg_panel_botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'butHoraMas
        '
        Me.butHoraMas.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.butHoraMas.Location = New System.Drawing.Point(3, 3)
        Me.butHoraMas.Name = "butHoraMas"
        Me.butHoraMas.Size = New System.Drawing.Size(110, 50)
        Me.butHoraMas.TabIndex = 0
        Me.butHoraMas.Text = "+"
        '
        'butMinMas
        '
        Me.butMinMas.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.butMinMas.Location = New System.Drawing.Point(127, 3)
        Me.butMinMas.Name = "butMinMas"
        Me.butMinMas.Size = New System.Drawing.Size(110, 50)
        Me.butMinMas.TabIndex = 1
        Me.butMinMas.Text = "+"
        '
        'butHoraMenos
        '
        Me.butHoraMenos.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold)
        Me.butHoraMenos.Location = New System.Drawing.Point(3, 157)
        Me.butHoraMenos.Name = "butHoraMenos"
        Me.butHoraMenos.Size = New System.Drawing.Size(110, 50)
        Me.butHoraMenos.TabIndex = 2
        Me.butHoraMenos.Text = "-"
        '
        'butMinMenos
        '
        Me.butMinMenos.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold)
        Me.butMinMenos.Location = New System.Drawing.Point(127, 157)
        Me.butMinMenos.Name = "butMinMenos"
        Me.butMinMenos.Size = New System.Drawing.Size(110, 50)
        Me.butMinMenos.TabIndex = 3
        Me.butMinMenos.Text = "-"
        '
        'labTitHora
        '
        Me.labTitHora.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.labTitHora.Location = New System.Drawing.Point(0, 82)
        Me.labTitHora.Name = "labTitHora"
        Me.labTitHora.Size = New System.Drawing.Size(110, 30)
        Me.labTitHora.Text = "Horas:"
        Me.labTitHora.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'labHora
        '
        Me.labHora.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.labHora.Location = New System.Drawing.Point(3, 112)
        Me.labHora.Name = "labHora"
        Me.labHora.Size = New System.Drawing.Size(110, 30)
        Me.labHora.Text = "1"
        Me.labHora.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'labTitMin
        '
        Me.labTitMin.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.labTitMin.Location = New System.Drawing.Point(127, 82)
        Me.labTitMin.Name = "labTitMin"
        Me.labTitMin.Size = New System.Drawing.Size(108, 30)
        Me.labTitMin.Text = "Minutos:"
        Me.labTitMin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'labMin
        '
        Me.labMin.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.labMin.Location = New System.Drawing.Point(127, 112)
        Me.labMin.Name = "labMin"
        Me.labMin.Size = New System.Drawing.Size(108, 30)
        Me.labMin.Text = "50"
        Me.labMin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'labPuntos
        '
        Me.labPuntos.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.labPuntos.Location = New System.Drawing.Point(111, 112)
        Me.labPuntos.Name = "labPuntos"
        Me.labPuntos.Size = New System.Drawing.Size(10, 30)
        Me.labPuntos.Text = ":"
        Me.labPuntos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FormMsg_panel_botones
        '
        Me.FormMsg_panel_botones.Controls.Add(Me.butCancelar)
        Me.FormMsg_panel_botones.Controls.Add(Me.butAceptar)
        Me.FormMsg_panel_botones.Location = New System.Drawing.Point(3, 223)
        Me.FormMsg_panel_botones.Name = "FormMsg_panel_botones"
        Me.FormMsg_panel_botones.Size = New System.Drawing.Size(234, 42)
        '
        'butCancelar
        '
        Me.butCancelar.Location = New System.Drawing.Point(122, 4)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(109, 35)
        Me.butCancelar.TabIndex = 1
        Me.butCancelar.Text = "Cancelar"
        '
        'butAceptar
        '
        Me.butAceptar.Location = New System.Drawing.Point(3, 4)
        Me.butAceptar.Name = "butAceptar"
        Me.butAceptar.Size = New System.Drawing.Size(113, 35)
        Me.butAceptar.TabIndex = 0
        Me.butAceptar.Text = "Aceptar"
        '
        'FormHora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.FormMsg_panel_botones)
        Me.Controls.Add(Me.labPuntos)
        Me.Controls.Add(Me.labMin)
        Me.Controls.Add(Me.labTitMin)
        Me.Controls.Add(Me.labHora)
        Me.Controls.Add(Me.labTitHora)
        Me.Controls.Add(Me.butMinMenos)
        Me.Controls.Add(Me.butHoraMenos)
        Me.Controls.Add(Me.butMinMas)
        Me.Controls.Add(Me.butHoraMas)
        Me.Menu = Me.mainMenu1
        Me.Name = "FormHora"
        Me.Text = "FormHora"
        Me.FormMsg_panel_botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents butHoraMas As System.Windows.Forms.Button
    Friend WithEvents butMinMas As System.Windows.Forms.Button
    Friend WithEvents butHoraMenos As System.Windows.Forms.Button
    Friend WithEvents butMinMenos As System.Windows.Forms.Button
    Friend WithEvents labTitHora As System.Windows.Forms.Label
    Friend WithEvents labHora As System.Windows.Forms.Label
    Friend WithEvents labTitMin As System.Windows.Forms.Label
    Friend WithEvents labMin As System.Windows.Forms.Label
    Friend WithEvents labPuntos As System.Windows.Forms.Label
    Friend WithEvents FormMsg_panel_botones As System.Windows.Forms.Panel
    Friend WithEvents butCancelar As System.Windows.Forms.Button
    Friend WithEvents butAceptar As System.Windows.Forms.Button
End Class
