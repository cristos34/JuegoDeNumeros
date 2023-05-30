Public Class frmEscogerOperacion
    Private Sub frmEscogerOperacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnUnaCifra_Click(sender As Object, e As EventArgs) Handles BtnUnaCifra.Click
        Select Case Me.GBJUEGOS.Text
            Case "JUEGOS DE RESTAS"
                FrmRestaUnaCifra.ShowDialog()
                Me.Close()
            Case "JUEGOS DE SUMAS"
                FrmSumaUnaCifra.ShowDialog()
                Me.Close()
                'MsgBox("Juego en mantenimiento")

        End Select
    End Sub

    Private Sub BtnDosCifra_Click(sender As Object, e As EventArgs) Handles BtnDosCifra.Click
        Select Case Me.GBJUEGOS.Text
            Case "JUEGOS DE RESTAS"
                FrmResta.txtRespuestaUno.Focus()
                FrmResta.ShowDialog()
                Me.Close()
            Case "JUEGOS DE SUMAS"
                FrmResta.txtRespuestaUno.Focus()
                FRMsuma.ShowDialog()
                Me.Close()
        End Select
    End Sub

    Private Sub BtnTresCifra_Click(sender As Object, e As EventArgs) Handles BtnTresCifra.Click
        Select Case Me.GBJUEGOS.Text
            Case "JUEGOS DE RESTAS"
                'MsgBox("Juego en mantenimiento")
                FrmRestaTresCifras.txtRespuestaUno.Focus()
                FrmRestaTresCifras.ShowDialog()
                Me.Close()
                'FrmResta.txtRespuestaUno.Focus()
                'FrmResta.ShowDialog()
                'Me.Close()
            Case "JUEGOS DE SUMAS"
                'MsgBox("Juego en mantenimiento")

                FrmSumaTresCifras.txtRespuestaUno.Focus()
                FrmSumaTresCifras.ShowDialog()
                Me.Close()
                'FrmResta.txtRespuestaUno.Focus()
                'FRMsuma.ShowDialog()
                'Me.Close()
        End Select
    End Sub
End Class