Option Explicit On
Option Strict On

Imports System.IO

' Convierte imagenes BMP a otros formatos
Public Class frmConversionImagenes

    ' Comvierte un Archivo en Particular
    Private Sub btnConvierteImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvierteImagen.Click
        ConvierteImagen(txtArchivoOrigen.Text, cmbFormatoDestino.Text)
    End Sub

    ' Convierte un lote de archivos de imagen BMP a otro formato
    Private Sub btnConvierteLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvierteLote.Click
        ' Borra los ListBox
        lstArchivosBMP.Items.Clear()
        lstArchivosConvertidos.Items.Clear()
        ' Convierte todos los archivos .BMP
        ConvierteLoteImagenes(cmbFormatoDestino.Text)
    End Sub

    ' Limpiar el formulario
    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        txtArchivoOrigen.Text = ""
        lstArchivosBMP.Items.Clear()
        lstArchivosConvertidos.Items.Clear()
    End Sub


    ' Convierte un archivo de imagen BMP a otro formato
    Private Sub ConvierteImagen(ByVal pAO As String, ByVal pFD As String)
        ' Declaración de variables
        Dim miFormatoOrigen As String
        Dim miArchivoDestino As String

        ' Cambia el directorio a la carpeta de trabajo
        ChDir("C:\ConvierteImagen")

        ' Inicialización de formato origen y archivo destino
        miFormatoOrigen = Mid(pAO, Len(pAO) - 2, 3)
        miArchivoDestino = Mid(pAO, 1, Len(pAO) - 3) + pFD

        ' Hace la conversion
        If miFormatoOrigen = "bmp" Then
            Dim oBitmap As New Bitmap(pAO)

            ' Convierte a JPG
            If pFD = "jpg" Then
                ChDir("C:\ConvierteImagen\JPG")
                oBitmap.Save(miArchivoDestino, Imaging.ImageFormat.Jpeg)
                ChDir("C:\ConvierteImagen")
            End If
            ' Convierte a PNG
            If pFD = "png" Then
                ChDir("C:\ConvierteImagen\PNG")
                oBitmap.Save(miArchivoDestino, Imaging.ImageFormat.Png)
                ChDir("C:\ConvierteImagen")
            End If
            ' Convierte a GIF
            If pFD = "gif" Then
                ChDir("C:\ConvierteImagen\GIF")
                oBitmap.Save(miArchivoDestino, Imaging.ImageFormat.Gif)
                ChDir("C:\ConvierteImagen")
            End If
            ' Convierte a TIFF
            If pFD = "tiff" Then
                ChDir("C:\ConvierteImagen\TIFF")
                oBitmap.Save(miArchivoDestino, Imaging.ImageFormat.Tiff)
                ChDir("C:\ConvierteImagen")
            End If
        End If
    End Sub


    ' Convierte un lote de archivos de imagen BMP a otro formato
    Private Sub ConvierteLoteImagenes(ByVal pFD As String)
        ' Declaración de variables
        Dim miArchivoDestino As String

        ' Obtener todos los archivos .exe del directorio windows ( inclyendo subdirectorios )  
        For Each archivos As String In Directory.GetFiles("C:\ConvierteImagen", "*.bmp", SearchOption.TopDirectoryOnly)
            ' extraer el nombre de la ruta  
            archivos = archivos.Substring(archivos.LastIndexOf("\") + 1).ToString

            ' Convierte el archivo
            ConvierteImagen(archivos, pFD)

            ' Agregar los valores a los listbox
            lstArchivosBMP.Items.Add(archivos.ToString)
            miArchivoDestino = Mid(archivos, 1, Len(archivos) - 3) + pFD
            lstArchivosConvertidos.Items.Add(miArchivoDestino)
        Next
    End Sub

End Class
