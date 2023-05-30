Imports System.ComponentModel

Public Class FrmGenero
    Private Sub FrmGenero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            reproducirr("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosImagenes\EscogeTuPersonaje.mp3")
        Catch ex As Exception
            MsgBox("No posee audio")
        End Try

    End Sub

    Private Sub pbGeneroNiño_Click(sender As Object, e As EventArgs) Handles pbGeneroNiño.Click

        Select Case lbJuego.Text & Lbidioma.Text
                Case "CANGURITOEspañol"
                    FrmCangurito.Lbiniciar.Text = Me.Lbiniciar.Text
                    FrmCangurito.Lbfinal.Text = Me.Lbfinal.Text
                    FrmCangurito.txtintervalo.Text = Me.lbcangurito.Text
                    FrmCangurito.Lbidioma.Text = "Español"
                    Me.Close()
                    FrmCangurito.ShowDialog()

                Case "DICTADOEspañol"
                    FrmDictado.Lbiniciar.Text = Me.Lbiniciar.Text
                    FrmDictado.Lbfinal.Text = Me.Lbfinal.Text
                    FrmDictado.Lbidioma.Text = "Español"
                    Me.Close()
                    FrmDictado.ShowDialog()

                Case "NIVEL BEBÉEspañol"
                    FrmNivelBebe.Lbiniciar.Text = Me.Lbiniciar.Text
                    FrmNivelBebe.Lbfinal.Text = Me.Lbfinal.Text
                    FrmNivelBebe.lbJuego.Text = "NIVEL BEBÉ"
                    FrmNivelBebe.LbEtiquetaGenero.Text = "Nivel Bebé"
                    FrmNivelBebe.Lbidioma.Text = "Español"
                    Me.Close()
                FrmNivelBebe.ShowDialog()
            Case "CANGURITOIngles"
                FrmCangurito.Lbiniciar.Text = Me.Lbiniciar.Text
                FrmCangurito.Lbfinal.Text = Me.Lbfinal.Text
                FrmCangurito.txtintervalo.Text = Me.lbcangurito.Text
                FrmCangurito.Lbidioma.Text = "Ingles"
                Me.Close()
                FrmCangurito.ShowDialog()

            Case "DICTADOIngles"
                FrmDictado.Lbiniciar.Text = Me.Lbiniciar.Text
                FrmDictado.Lbfinal.Text = Me.Lbfinal.Text
                FrmDictado.Lbidioma.Text = "Ingles"
                Me.Close()
                FrmDictado.ShowDialog()

            Case "NIVEL BEBÉIngles"
                FrmNivelBebe.Lbiniciar.Text = Me.Lbiniciar.Text
                FrmNivelBebe.Lbfinal.Text = Me.Lbfinal.Text
                FrmNivelBebe.lbJuego.Text = "NIVEL BEBÉ"
                FrmNivelBebe.LbEtiquetaGenero.Text = "Nivel Bebé"
                FrmNivelBebe.Lbidioma.Text = "Ingles"
                Me.Close()
                FrmNivelBebe.ShowDialog()
        End Select


    End Sub

    Private Sub pbGeneroNiña_Click(sender As Object, e As EventArgs) Handles pbGeneroNiña.Click
        Try
            reproducirr("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosImagenes\EspadaNiña.mp3")
        Catch ex As Exception
            MsgBox("No posee audio")
        End Try
    End Sub
    Sub reproducirr(ByVal ruta As String)
        Try

            AxwpSaludos.URL = ruta
        Catch ex As Exception
            MsgBox("No existe el audio del numero " + ex.ToString)
        End Try

    End Sub

    Private Sub FrmGenero_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        lbcangurito.Text = ""
        lbJuego.Text = ""
        LbEtiquetaGenero.Text = ""
        Lbiniciar.Text = ""
        Lbfinal.Text = ""
        Lbidioma.Text = ""
        FrmMenu.LBnBeDE.Text = ""
        FrmMenu.LBnBeA.Text = ""
        FrmMenu.GBnivelBebeE.Visible = False
        FrmMenu.GBnivelBebeI.Visible = False
        FrmMenu.GBcanguritoE.Visible = False
        FrmMenu.GBcanguritoI.Visible = False
        FrmMenu.GBDictadoE.Visible = False
        FrmMenu.GBDictadoI.Visible = False
        FrmEscogerLimites.Close()
        frmEscogerOperacion.Close()

    End Sub
End Class