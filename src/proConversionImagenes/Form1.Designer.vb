<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConversionImagenes
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
        Me.btnConvierteImagen = New System.Windows.Forms.Button()
        Me.lstArchivosBMP = New System.Windows.Forms.ListBox()
        Me.lstArchivosConvertidos = New System.Windows.Forms.ListBox()
        Me.btnConvierteLote = New System.Windows.Forms.Button()
        Me.txtArchivoOrigen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbFormatoDestino = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnConvierteImagen
        '
        Me.btnConvierteImagen.Location = New System.Drawing.Point(347, 23)
        Me.btnConvierteImagen.Name = "btnConvierteImagen"
        Me.btnConvierteImagen.Size = New System.Drawing.Size(75, 23)
        Me.btnConvierteImagen.TabIndex = 0
        Me.btnConvierteImagen.Text = "Imagen"
        Me.btnConvierteImagen.UseVisualStyleBackColor = True
        '
        'lstArchivosBMP
        '
        Me.lstArchivosBMP.FormattingEnabled = True
        Me.lstArchivosBMP.Location = New System.Drawing.Point(12, 78)
        Me.lstArchivosBMP.Name = "lstArchivosBMP"
        Me.lstArchivosBMP.Size = New System.Drawing.Size(202, 251)
        Me.lstArchivosBMP.TabIndex = 1
        '
        'lstArchivosConvertidos
        '
        Me.lstArchivosConvertidos.FormattingEnabled = True
        Me.lstArchivosConvertidos.Location = New System.Drawing.Point(220, 78)
        Me.lstArchivosConvertidos.Name = "lstArchivosConvertidos"
        Me.lstArchivosConvertidos.Size = New System.Drawing.Size(202, 251)
        Me.lstArchivosConvertidos.TabIndex = 2
        '
        'btnConvierteLote
        '
        Me.btnConvierteLote.Location = New System.Drawing.Point(347, 335)
        Me.btnConvierteLote.Name = "btnConvierteLote"
        Me.btnConvierteLote.Size = New System.Drawing.Size(75, 23)
        Me.btnConvierteLote.TabIndex = 3
        Me.btnConvierteLote.Text = "Lote"
        Me.btnConvierteLote.UseVisualStyleBackColor = True
        '
        'txtArchivoOrigen
        '
        Me.txtArchivoOrigen.Location = New System.Drawing.Point(12, 25)
        Me.txtArchivoOrigen.Name = "txtArchivoOrigen"
        Me.txtArchivoOrigen.Size = New System.Drawing.Size(202, 20)
        Me.txtArchivoOrigen.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Archivo Origen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Formato Destino"
        '
        'cmbFormatoDestino
        '
        Me.cmbFormatoDestino.FormattingEnabled = True
        Me.cmbFormatoDestino.Items.AddRange(New Object() {"gif", "jpg", "png", "tiff"})
        Me.cmbFormatoDestino.Location = New System.Drawing.Point(220, 25)
        Me.cmbFormatoDestino.Name = "cmbFormatoDestino"
        Me.cmbFormatoDestino.Size = New System.Drawing.Size(121, 21)
        Me.cmbFormatoDestino.TabIndex = 8
        Me.cmbFormatoDestino.Text = "png"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Archivos de Origen *.BMP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(217, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Archivos Convertidos"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(139, 335)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 11
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'frmConversionImagenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 366)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbFormatoDestino)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtArchivoOrigen)
        Me.Controls.Add(Me.btnConvierteLote)
        Me.Controls.Add(Me.lstArchivosConvertidos)
        Me.Controls.Add(Me.lstArchivosBMP)
        Me.Controls.Add(Me.btnConvierteImagen)
        Me.Name = "frmConversionImagenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conversión de Imagenes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConvierteImagen As System.Windows.Forms.Button
    Friend WithEvents lstArchivosBMP As System.Windows.Forms.ListBox
    Friend WithEvents lstArchivosConvertidos As System.Windows.Forms.ListBox
    Friend WithEvents btnConvierteLote As System.Windows.Forms.Button
    Friend WithEvents txtArchivoOrigen As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbFormatoDestino As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button

End Class
