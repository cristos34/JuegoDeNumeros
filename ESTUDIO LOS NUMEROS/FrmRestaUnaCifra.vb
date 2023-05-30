Imports System.ComponentModel

Public Class FrmRestaUnaCifra
    Dim pCifra As Long
    Dim sCifra As Long
    Dim pCifraUNo As Long
    Dim sCifraUno As Long
    Dim Prueba As Long
    Dim RespuestaAprendis As Long
    Private Sub FrmRestaUnaCifra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxmpNumero.Ctlcontrols.stop()
        LLamarPcifraNumeroUno()
        LLamarScifraNumeroUno()

        LBPrimeracifraPrimerNumero.Text = sCifraUno
        LBSegundaCifraPrimer.Text = pCifraUNo

        txtRespuestaUno.Text = ""
        txtRespuestaUno.Focus()
        BtnComprobar.Enabled = True
        btnLimpiar.Enabled = True
    End Sub
    Sub LLamarPcifraNumeroUno()
        Dim dmin As Byte
        Dim amax As Byte
        Dim NumAleatorio As Integer
        dmin = 0
        amax = 9

        NumAleatorio = numAleatorioEntre(dmin, amax)
        pCifraUNo = NumAleatorio
    End Sub
    Sub LLamarScifraNumeroUno()
        Dim dmin As Byte
        Dim amax As Byte
        Dim NumAleatorio As Integer
        dmin = pCifraUNo
        amax = 9

        NumAleatorio = numAleatorioEntre(dmin, amax)
        sCifraUno = NumAleatorio
    End Sub
    Sub reproducir(ByVal ruta As String)

        Try
            AxmpNumero.URL = ruta
        Catch ex As Exception
            MsgBox("No existe el audio del numero" + ex.ToString)
        End Try

    End Sub

    Private Sub txtRespuestaUno_TextChanged(sender As Object, e As EventArgs) Handles txtRespuestaUno.TextChanged
        BtnComprobar.PerformClick()
    End Sub

    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        LLamarPcifraNumeroUno()
        LLamarScifraNumeroUno()

        AxmpNumero.Ctlcontrols.stop()
        LBPrimeracifraPrimerNumero.Text = sCifraUno
        LBSegundaCifraPrimer.Text = pCifraUNo
        txtRespuestaUno.Enabled = True
        txtRespuestaUno.Text = ""

        lbRespuestaSifraUno.Text = ""
        lbRespuestaSifraDos.Text = ""
        LbResultado.Text = ""
        txtRespuestaUno.Focus()
        GPimagens.Visible = False
        BtnComprobar.Enabled = True
        Me.Size = New Size(width:=417, height:=565)

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        AxmpNumero.Ctlcontrols.stop()
        txtRespuestaUno.Enabled = True
        txtRespuestaUno.Text = ""
        lbRespuestaSifraUno.Text = ""
        lbRespuestaSifraDos.Text = ""
        LbResultado.Text = ""
        txtRespuestaUno.Focus()
        BtnComprobar.Enabled = True
        GPimagens.Visible = False
        Me.Size = New Size(width:=417, height:=565)

    End Sub

    Private Sub BtnComprobar_Click(sender As Object, e As EventArgs) Handles BtnComprobar.Click

        If txtRespuestaUno.Text = "" Then
            MsgBox("Debes dar Tu respuestas")
            txtRespuestaUno.Focus()
            BtnComprobar.Enabled = True
        Else

            pCifra = LBPrimeracifraPrimerNumero.Text
            sCifra = LBSegundaCifraPrimer.Text
            Prueba = pCifra - sCifra

            RespuestaAprendis = Val(txtRespuestaUno.Text)

            lbRespuestaSifraUno.Text = pCifra
            lbRespuestaSifraDos.Text = sCifra
            LbResultado.Text = Prueba

            If Prueba = RespuestaAprendis Then
                Me.Size = New Size(width:=683, height:=565)
                txtRespuestaUno.Enabled = False
                GPimagens.Visible = True
                PblloroPQperdi.SendToBack()
                PBfelizPQgane.BringToFront()
                FrmMenu.LBintentos.Text = FrmMenu.LBintentos.Text + 1
                FrmMenu.LBaciertos.Text = FrmMenu.LBaciertos.Text + 1
                btnLimpiar.Enabled = False
                btnJugar.Enabled = True
                Try
                    reproducir("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosImagenes\Ganaste.mp3")
                Catch ex As Exception
                    MsgBox("No posee audio")
                End Try

                'MsgBox("MUY BIEN PELAO")

                BtnComprobar.Enabled = False
            Else
                Me.Size = New Size(width:=683, height:=565)
                txtRespuestaUno.Enabled = False
                GPimagens.Visible = True
                PBfelizPQgane.SendToBack()
                PblloroPQperdi.BringToFront()
                FrmMenu.LBintentos.Text = FrmMenu.LBintentos.Text + 1
                FrmMenu.LBerrores.Text = FrmMenu.LBerrores.Text + 1
                BtnComprobar.Enabled = True
                btnJugar.Enabled = False
                btnLimpiar.Enabled = True
                Try
                    reproducir("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosImagenes\perdiNiños.mp3")
                    datosDeErrores("RESTA DE UNA CIFRA", pCifra & " - " & sCifra, txtRespuestaUno.Text)
                Catch ex As Exception
                    MsgBox("No posee audio")
                End Try
                ' MsgBox("TU PUEDES MEJORAR ERES UN GRAN ALUMNO")
                BtnComprobar.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtRespuestaUno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRespuestaUno.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 13 Then
            BtnComprobar.PerformClick()

        End If
    End Sub

    Private Sub FrmRestaUnaCifra_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        AxmpNumero.Ctlcontrols.stop()
        LBPrimeracifraPrimerNumero.Text = ""
        LBSegundaCifraPrimer.Text = ""
        txtRespuestaUno.Enabled = True
        txtRespuestaUno.Text = ""
        lbRespuestaSifraUno.Text = ""
        lbRespuestaSifraDos.Text = ""
        LbResultado.Text = ""
        txtRespuestaUno.Focus()
        GPimagens.Visible = False
        BtnComprobar.Enabled = True
        Me.Size = New Size(width:=417, height:=565)
    End Sub
End Class