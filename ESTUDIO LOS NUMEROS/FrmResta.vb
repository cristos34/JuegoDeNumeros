Imports System.ComponentModel

Public Class FrmResta
    Dim pCifra As Long
    Dim sCifra As Long
    Dim pCifraUNo As Long
    Dim pCifraDos As Long
    Dim sCifraUno As Long
    Dim sCifraDos As Long
    Dim Prueba As Long
    Dim RespuestaAprendis As Long

    Private Sub FrmResta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AxmpNumero.Ctlcontrols.stop()
        frmEscogerOperacion.Close()
        LLamarPcifraNumeroUno()
        LLamarPcifraNumeroDos()
        LLamarScifraNumeroUno()
        LLamarScifraNumeroDos()

        LBPrimeracifraPrimerNumero.Text = sCifraUno
        LBPrimeracifraSegundoNumero.Text = sCifraDos
        LBSegundaCifraPrimer.Text = pCifraUNo
        LBSegundaCifraSegundo.Text = pCifraDos
        GPimagens.Visible = False

        txtRespuestaUno.Text = ""
        txtRespuestaDos.Text = ""

        txtLlevaUno.Text = ""
        txtLlevaDos.Text = ""

        'MsgBox(pCifraUNo & " pCifraUNo 1")
        'MsgBox(pCifraDos & " pCifraDos 2")
        'MsgBox(sCifraUno & " sCifraUno 1")
        'MsgBox(sCifraDos & " sCifraDos 2")
        btnJugar.PerformClick()

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
    Sub LLamarPcifraNumeroDos()
        Dim dmin As Byte
        Dim amax As Byte
        Dim NumAleatorio As Integer
        dmin = 0
        amax = 9

        NumAleatorio = numAleatorioEntre(dmin, amax)
        pCifraDos = NumAleatorio
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
    Sub LLamarScifraNumeroDos()
        Dim dmin As Byte
        Dim amax As Byte
        Dim NumAleatorio As Integer
        dmin = pCifraDos
        amax = 9

        NumAleatorio = numAleatorioEntre(dmin, amax)
        sCifraDos = NumAleatorio
    End Sub
    Sub reproducir(ByVal ruta As String)

        Try
            AxmpNumero.URL = ruta
        Catch ex As Exception
            MsgBox("No existe el audio del numero" + ex.ToString)
        End Try

    End Sub
    Private Sub BtnComprobar_Click(sender As Object, e As EventArgs) Handles BtnComprobar.Click

        If (txtRespuestaDos.Text & txtRespuestaUno.Text) = "" Then
            MsgBox("Debes dar Tu respuestas")
            txtRespuestaUno.Focus()
            BtnComprobar.Enabled = True
        Else

            pCifra = LBPrimeracifraSegundoNumero.Text & LBPrimeracifraPrimerNumero.Text
            sCifra = LBSegundaCifraSegundo.Text & LBSegundaCifraPrimer.Text
            Prueba = pCifra - sCifra

            RespuestaAprendis = Val(txtRespuestaDos.Text) & Val(txtRespuestaUno.Text)

            lbRespuestaSifraUno.Text = pCifra
            lbRespuestaSifraDos.Text = sCifra
            LbResultado.Text = Prueba

            If Prueba = RespuestaAprendis Then
                Me.Size = New Size(width:=683, height:=565)
                txtRespuestaUno.Enabled = False
                txtRespuestaDos.Enabled = False
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
                txtRespuestaUno.Enabled = True
                txtRespuestaDos.Enabled = False
                PblloroPQperdi.Visible = True
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
                    datosDeErrores("RESTA DE DOS CIFRA", pCifra & " - " & sCifra, txtRespuestaUno.Text)
                Catch ex As Exception
                    MsgBox("No posee audio")
                End Try
                ' MsgBox("TU PUEDES MEJORAR ERES UN GRAN ALUMNO")
                txtRespuestaUno.Focus()
                BtnComprobar.Enabled = False

            End If
        End If


    End Sub
    Private Sub lbRespuestaSifraDos_Click(sender As Object, e As EventArgs) Handles lbRespuestaSifraDos.Click

    End Sub

    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        LLamarPcifraNumeroUno()
        LLamarPcifraNumeroDos()
        LLamarScifraNumeroUno()
        LLamarScifraNumeroDos()

        AxmpNumero.Ctlcontrols.stop()
        LBPrimeracifraPrimerNumero.Text = sCifraUno
        LBPrimeracifraSegundoNumero.Text = sCifraDos
        LBSegundaCifraPrimer.Text = pCifraUNo
        LBSegundaCifraSegundo.Text = pCifraDos

        'lbRespuestaSifraUno.Text = ""
        'lbRespuestaSifraDos.Text = ""
        'LbResultado.Text = ""
        txtRespuestaUno.Enabled = True
        txtRespuestaDos.Enabled = False
        txtRespuestaDos.Text = ""
        txtRespuestaUno.Text = ""
        txtLlevaUno.Text = ""
        txtLlevaDos.Text = ""
        GPimagens.Visible = False

        txtRespuestaUno.Focus()
        BtnComprobar.Enabled = True
        Me.Size = New Size(width:=417, height:=565)

    End Sub

    Private Sub txtRespuestaUno_TextChanged(sender As Object, e As EventArgs) Handles txtRespuestaUno.TextChanged
        If txtRespuestaUno.Text <> "" Then
            txtRespuestaDos.Enabled = True
            txtRespuestaDos.Focus()
        Else
            txtRespuestaDos.Enabled = False
            txtRespuestaDos.Text = ""
            txtRespuestaUno.Focus()


            lbRespuestaSifraUno.Text = ""
            lbRespuestaSifraDos.Text = ""
            LbResultado.Text = ""

            'txtRespuestaDos.Text = ""
            'txtRespuestaUno.Text = ""
            'txtLlevaUno.Text = ""
            'txtLlevaDos.Text = ""
            'txtRespuestaUno.Focus()
            BtnComprobar.Enabled = True
            Me.Size = New Size(width:=417, height:=565)

        End If

    End Sub

    Private Sub txtRespuestaDos_TextChanged(sender As Object, e As EventArgs) Handles txtRespuestaDos.TextChanged
        Dim PPCIFRA As Long
        Dim ssCifra As Long
        Dim Pprueba As Long
        Dim RespuestaAprendiss As Long

        On Error Resume Next

        PPCIFRA = LBPrimeracifraSegundoNumero.Text & LBPrimeracifraPrimerNumero.Text
        ssCifra = LBSegundaCifraSegundo.Text & LBSegundaCifraPrimer.Text
        Pprueba = PPCIFRA - ssCifra
        RespuestaAprendiss = Val(txtRespuestaDos.Text) & Val(txtRespuestaUno.Text)

        If txtRespuestaUno.Text <> "" Then
            BtnComprobar.PerformClick()
        End If

    End Sub

    Private Sub txtLlevaUno_TextChanged(sender As Object, e As EventArgs) Handles txtLlevaUno.TextChanged

    End Sub

    Private Sub txtLlevaTres_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtLlevaDos_TextChanged(sender As Object, e As EventArgs) Handles txtLlevaDos.TextChanged

    End Sub

    Private Sub txtRespuestaTres_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtRespuestaUno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRespuestaUno.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 13 Then
            txtRespuestaDos.Focus()

        End If
    End Sub

    Private Sub txtRespuestaDos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRespuestaDos.KeyPress
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
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        AxmpNumero.Ctlcontrols.stop()
        lbRespuestaSifraUno.Text = ""
        lbRespuestaSifraDos.Text = ""
        LbResultado.Text = ""
        GPimagens.Visible = False
        txtRespuestaDos.Text = ""
        txtRespuestaUno.Text = ""
        txtLlevaUno.Text = ""
        txtLlevaDos.Text = ""
        txtRespuestaUno.Enabled = True
        txtRespuestaUno.Focus()

        BtnComprobar.Enabled = True
        Me.Size = New Size(width:=417, height:=565)

    End Sub

    Private Sub FrmResta_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        AxmpNumero.Ctlcontrols.stop()
        LBPrimeracifraPrimerNumero.Text = ""
        LBPrimeracifraSegundoNumero.Text = ""
        LBSegundaCifraPrimer.Text = ""
        LBSegundaCifraSegundo.Text = ""

        lbRespuestaSifraUno.Text = ""
        lbRespuestaSifraDos.Text = ""
        LbResultado.Text = ""

        txtRespuestaUno.Enabled = True
        txtRespuestaDos.Enabled = True
        txtRespuestaUno.Text = ""
        txtRespuestaDos.Text = ""
        txtLlevaUno.Text = ""
        txtLlevaDos.Text = ""
        txtRespuestaUno.Focus()

        BtnComprobar.Enabled = False
        Me.Size = New Size(width:=417, height:=565)
    End Sub

    Private Sub PblloroPQperdi_Click(sender As Object, e As EventArgs) Handles PblloroPQperdi.Click

    End Sub

    Private Sub PBfelizPQgane_Click(sender As Object, e As EventArgs) Handles PBfelizPQgane.Click

    End Sub
End Class