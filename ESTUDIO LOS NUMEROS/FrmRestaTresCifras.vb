Imports System.ComponentModel

Public Class FrmRestaTresCifras
    Dim pCifra As Long
    Dim sCifra As Long
    Dim pCifraUNo As Long
    Dim pCifraDos As Long
    Dim pCifraTres As Long
    Dim sCifraUno As Long
    Dim sCifraDos As Long
    Dim sCifraTres As Long
    Dim Prueba As Long
    Dim RespuestaAprendis As Long
    Private Sub FrmRestaTresCifras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmEscogerOperacion.Close()
        AxmpNumero.Ctlcontrols.stop()
        LLamarPcifraNumeroUno()
        LLamarPcifraNumeroDos()
        LLamarPcifraNumeroTres()
        LLamarScifraNumeroUno()
        LLamarScifraNumeroDos()
        LLamarScifraNumeroTres()

        LBPrimeracifraPrimerNumero.Text = sCifraUno
        LBPrimeracifraSegundoNumero.Text = sCifraDos
        LBPrimeracifraTercerNumero.Text = sCifraTres

        LBSegundaCifraTercerNumero.Text = pCifraTres
        LBSegundaCifraSegundoNumero.Text = pCifraDos
        LBSegundaCifraPrimerNumero.Text = pCifraUNo

        GPimagens.Visible = False

        txtRespuestaUno.Text = ""
        txtRespuestaDos.Text = ""

        txtLlevaDos.Text = ""
        txtLlevaTres.Text = ""


        'MsgBox(pCifraUNo & " pCifraUNo 1")
        'MsgBox(pCifraDos & " pCifraDos 2")
        'MsgBox(sCifraUno & " sCifraUno 1")
        'MsgBox(sCifraDos & " sCifraDos 2")

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
    Sub LLamarPcifraNumeroTres()
        Dim dmin As Byte
        Dim amax As Byte
        Dim NumAleatorio As Integer
        dmin = 0
        amax = 9

        NumAleatorio = numAleatorioEntre(dmin, amax)
        pCifraTres = NumAleatorio
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
    Sub LLamarScifraNumeroTres()
        Dim dmin As Byte
        Dim amax As Byte
        Dim NumAleatorio As Integer
        dmin = pCifraTres
        amax = 9

        NumAleatorio = numAleatorioEntre(dmin, amax)
        sCifraTres = NumAleatorio
    End Sub
    Sub reproducir(ByVal ruta As String)

        Try
            AxmpNumero.URL = ruta
        Catch ex As Exception
            MsgBox("No existe el audio del numero" + ex.ToString)
        End Try

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        AxmpNumero.Ctlcontrols.stop()
        lbRespuestaSifraUno.Text = ""
        lbRespuestaSifraDos.Text = ""
        LbResultado.Text = ""

        txtRespuestaDos.Text = ""
        txtRespuestaUno.Text = ""
        txtRespuestaTres.Text = ""
        txtLlevaDos.Text = ""
        txtLlevaTres.Text = ""
        GPimagens.Visible = False

        BtnComprobar.Enabled = True
        btnJugar.Enabled = False
        Me.Size = New Size(width:=410, height:=560)
        txtRespuestaUno.Enabled = True
        txtRespuestaUno.Focus()
    End Sub

    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        AxmpNumero.Ctlcontrols.stop()
        LLamarPcifraNumeroUno()
        LLamarPcifraNumeroDos()
        LLamarPcifraNumeroTres()
        LLamarScifraNumeroUno()
        LLamarScifraNumeroDos()
        LLamarScifraNumeroTres()

        LBPrimeracifraPrimerNumero.Text = sCifraUno
        LBPrimeracifraSegundoNumero.Text = sCifraDos
        LBPrimeracifraTercerNumero.Text = sCifraTres

        LBSegundaCifraTercerNumero.Text = pCifraTres
        LBSegundaCifraSegundoNumero.Text = pCifraDos
        LBSegundaCifraPrimerNumero.Text = pCifraUNo

        GPimagens.Visible = False

        txtRespuestaUno.Text = ""
        txtRespuestaDos.Text = ""
        txtRespuestaTres.Text = ""
        txtLlevaDos.Text = ""
        txtLlevaTres.Text = ""

        BtnComprobar.Enabled = True
        btnJugar.Enabled = False
        Me.Size = New Size(width:=410, height:=560)
        txtRespuestaUno.Enabled = True
        txtRespuestaUno.Focus()

    End Sub

    Private Sub BtnComprobar_Click(sender As Object, e As EventArgs) Handles BtnComprobar.Click
        'Me.Size = New Size(width:=410, height:=560)

        If (txtRespuestaTres.Text & txtRespuestaDos.Text & txtRespuestaUno.Text) = "" Then
            MsgBox("Debes dar Tu respuestas")
            txtRespuestaUno.Focus()
            BtnComprobar.Enabled = True
        Else

            pCifra = LBPrimeracifraTercerNumero.Text & LBPrimeracifraSegundoNumero.Text & LBPrimeracifraPrimerNumero.Text
            sCifra = LBSegundaCifraTercerNumero.Text & LBSegundaCifraSegundoNumero.Text & LBSegundaCifraPrimerNumero.Text
            Prueba = pCifra - sCifra

            RespuestaAprendis = Val(txtRespuestaTres.Text) & Val(txtRespuestaDos.Text) & Val(txtRespuestaUno.Text)

            lbRespuestaSifraUno.Text = pCifra
            lbRespuestaSifraDos.Text = sCifra
            LbResultado.Text = Prueba

            If Prueba = RespuestaAprendis Then
                Me.Size = New Size(width:=717, height:=560)
                txtRespuestaUno.Enabled = False
                txtRespuestaDos.Enabled = False
                txtRespuestaTres.Enabled = False
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

                ' MsgBox("MUY BIEN PELAO")
                BtnComprobar.Enabled = False
                btnJugar.Enabled = True

            Else
                Me.Size = New Size(width:=717, height:=560)
                txtRespuestaUno.Enabled = True
                txtRespuestaDos.Enabled = False
                txtRespuestaTres.Enabled = False
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
                    datosDeErrores("SUMA DE DOS CIFRA", pCifra & " + " & sCifra, txtRespuestaUno.Text)
                Catch ex As Exception
                    MsgBox("No posee audio")
                End Try

                'MsgBox("TU PUEDES MEJORAR, ERES UN GRAN ALUMNO")
                txtRespuestaUno.Focus()
                BtnComprobar.Enabled = False

            End If
        End If
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
            Me.Size = New Size(width:=410, height:=560)

        End If
    End Sub

    Private Sub txtRespuestaDos_TextChanged(sender As Object, e As EventArgs) Handles txtRespuestaDos.TextChanged
        If txtRespuestaDos.Text <> "" Then
            txtRespuestaTres.Enabled = True
            txtRespuestaTres.Focus()
        Else
            txtRespuestaTres.Enabled = False
            txtRespuestaTres.Text = ""
            txtRespuestaDos.Focus()

            lbRespuestaSifraUno.Text = ""
            lbRespuestaSifraDos.Text = ""
            LbResultado.Text = ""

            'txtRespuestaDos.Text = ""
            'txtRespuestaUno.Text = ""
            'txtLlevaUno.Text = ""
            'txtLlevaDos.Text = ""
            'txtRespuestaUno.Focus()
            BtnComprobar.Enabled = True
            Me.Size = New Size(width:=410, height:=560)

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
            txtRespuestaTres.Focus()

        End If
    End Sub

    Private Sub txtRespuestaTres_TextChanged(sender As Object, e As EventArgs) Handles txtRespuestaTres.TextChanged
        BtnComprobar.PerformClick()
    End Sub

    Private Sub txtRespuestaTres_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRespuestaTres.KeyPress
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

    Private Sub FrmRestaTresCifras_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        AxmpNumero.Ctlcontrols.stop()
    End Sub
End Class