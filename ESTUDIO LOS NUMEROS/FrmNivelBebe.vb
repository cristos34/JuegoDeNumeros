Imports System.ComponentModel

Public Class FrmNivelBebe

    Dim intervalo As Long
    Dim idiomas As String

    Private Sub FrmNivelBebe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbRepasarNumeros.Visible = False
        pbEscribirNumeros.Visible = True
        lbNumero.Visible = True
        txtEscribirNumero.Text = ""
        txtEscribirNumero.Visible = False
        TimerNumero.Enabled = True
        btnCangurito.Visible = True
        idiomas = Lbidioma.Text
    End Sub
    Private Sub FrmNivelBebe_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        TimerNumero.Enabled = False
        TimerCangurito.Enabled = False
        pbEscribirNumeros.Visible = False
        pbRepasarNumeros.Visible = True
        txtEscribirNumero.Visible = True
        pbSonido.Visible = True
        TimerNumero.Enabled = False
        lbNumero.Text = ""
        txtnum.Text = ""
        lbNumero.Visible = False
        txtEscribirNumero.Focus()
    End Sub
    Sub LLamarNumero()
        Dim dmin As Byte
        Dim amax As Byte
        Dim NumAleatorio As Integer
        dmin = Lbiniciar.Text
        amax = Lbfinal.Text
        'dmin = 3
        'amax = 10

        NumAleatorio = numAleatorioEntre(dmin, amax + 1)
        lbNumero.Text = NumAleatorio
        txtnum.Text = NumAleatorio

    End Sub


    Sub reproducirr(ByVal ruta As String)
        Try
            AxwSonidoNumero.URL = ruta
        Catch ex As Exception
            MsgBox("No existe el audio del numero" + ex.ToString)
        End Try

    End Sub



    Private Sub TimerNumero_Tick(sender As Object, e As EventArgs) Handles TimerNumero.Tick
        Call LLamarNumero()
    End Sub

    Private Sub lbNumero_Click(sender As Object, e As EventArgs) Handles lbNumero.Click

    End Sub
    Private Sub pbEscribirNumeros_Click(sender As Object, e As EventArgs) Handles pbEscribirNumeros.Click
        pbEscribirNumeros.Visible = False
        pbRepasarNumeros.Visible = True
        txtEscribirNumero.Visible = True
        pbSonido.Visible = True
        TimerNumero.Enabled = False
        TimerCangurito.Enabled = False
        lbNumero.Text = ""
        txtnum.Text = ""
        lbNumero.Visible = False
        btnCangurito.Visible = False
        txtEscribirNumero.Focus()

    End Sub

    Private Sub pbRepasarNumeros_Click(sender As Object, e As EventArgs) Handles pbRepasarNumeros.Click
        pbRepasarNumeros.Visible = False
        pbEscribirNumeros.Visible = True
        lbNumero.Visible = True
        txtEscribirNumero.Text = ""
        TimerNumero.Enabled = True
        txtEscribirNumero.Visible = False
        pbSonido.Visible = False
        btnCangurito.Visible = True

        Call LLamarNumero()
        TimerNumero.Enabled = True

    End Sub

    Private Sub pbSonido_Click(sender As Object, e As EventArgs) Handles pbSonido.Click
        Dim idio As String

        If idiomas = "Español" Then
            idio = "E"
        ElseIf idiomas = "Ingles" Then
            idio = "I"
        End If
        Try
            'reproducir("C:\Users\USUARIO\source\repos\JUEGO DE NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + ".mp3")
            reproducirr("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosNumeros\" + txtEscribirNumero.Text + idio + ".mpeg")
        Catch ex As Exception
            MsgBox("El numero " + txtEscribirNumero.Text + " no posee audio")
        End Try

    End Sub

    Private Sub btnSonido_Click(sender As Object, e As EventArgs) Handles btnSonido.Click
        Dim idio As String

        If idiomas = "Español" Then
            idio = "E"
        ElseIf idiomas = "Ingles" Then
            idio = "I"
        End If
        Try
            'reproducir("C:\Users\USUARIO\source\repos\JUEGO DE NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + ".mp3")
            reproducirr("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosNumeros\" + txtEscribirNumero.Text + idio + ".mpeg")
        Catch ex As Exception
            MsgBox("El numero " + txtEscribirNumero.Text + " no posee audio")
        End Try

    End Sub

    Private Sub btnCangurito_Click(sender As Object, e As EventArgs) Handles btnCangurito.Click
        Select Case lbJuego.Text
            Case "CANGURITO"
                TimerCangurito.Enabled = False
                lbNumero.Text = ""
                TimerNumero.Enabled = True
                txtnum.Text = ""
                lbcangurito.Text = ""
                intervalo = 0
                lbJuego.Text = "NIVEL BEBÉ"
                LbEtiquetaGenero.Text = "Nivel Bebé"
                TimerCangurito.Enabled = True
                btnCangurito.Text = "CANGURITO"

            Case "NIVEL BEBÉ"
                TimerNumero.Enabled = False
                lbNumero.Text = ""
                TimerCangurito.Enabled = True
                txtnum.Text = ""
                lbJuego.Text = "CANGURITO"
                LbEtiquetaGenero.Text = "Cangurito"
                intervalo = InputBox("Ingrese el numero cangurito con el que decea jugar ", "Numero Cangurito")
                lbcangurito.Text = intervalo
                btnCangurito.Text = "NIVEL BEBE"
        End Select



    End Sub

    Private Sub txtEscribirNumero_TextChanged(sender As Object, e As EventArgs) Handles txtEscribirNumero.TextChanged
        If txtEscribirNumero.Text <> "" Then
            btnSonido.Visible = True
        Else
            btnSonido.Visible = False
        End If

    End Sub

    Private Sub txtEscribirNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEscribirNumero.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 13 Then
            btnSonido.PerformClick()
        End If

    End Sub

    Private Sub txtnum_TextChanged(sender As Object, e As EventArgs) Handles txtnum.TextChanged
        Dim idio As String

        If idiomas = "Español" Then
            idio = "E"
        ElseIf idiomas = "Ingles" Then
            idio = "I"
        End If
        Try
            'reproducir("C:\Users\USUARIO\source\repos\JUEGO DE NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + ".mp3")
            reproducirr("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosNumeros\" + txtnum.Text + idio + ".mpeg")
        Catch ex As Exception
            MsgBox("El numero " + txtnum.Text + " no posee audio")
        End Try

    End Sub

    Private Sub pbEscribirNumeros_MouseHover(sender As Object, e As EventArgs) Handles pbEscribirNumeros.MouseHover
        pbEscribirNumeros.Size = New Size(width:=104, height:=100)
    End Sub

    Private Sub pbEscribirNumeros_MouseLeave(sender As Object, e As EventArgs) Handles pbEscribirNumeros.MouseLeave
        pbEscribirNumeros.Size = New Size(width:=100, height:=96)
    End Sub

    Private Sub pbRepasarNumeros_MouseHover(sender As Object, e As EventArgs) Handles pbRepasarNumeros.MouseHover
        pbRepasarNumeros.Size = New Size(width:=104, height:=100)
    End Sub

    Private Sub pbRepasarNumeros_MouseLeave(sender As Object, e As EventArgs) Handles pbRepasarNumeros.MouseLeave
        pbRepasarNumeros.Size = New Size(width:=100, height:=96)
    End Sub

    Private Sub pbSonido_MouseHover(sender As Object, e As EventArgs) Handles pbSonido.MouseHover
        pbSonido.Size = New Size(width:=104, height:=100)
        Dim idio As String

        If idiomas = "Español" Then
            idio = "E"
        ElseIf idiomas = "Ingles" Then
            idio = "I"
        End If
        Try
            'reproducir("C:\Users\USUARIO\source\repos\JUEGO DE NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + ".mp3")
            reproducirr("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosNumeros\" + txtEscribirNumero.Text + idio + ".mpeg")
        Catch ex As Exception
            MsgBox("El numero " + txtEscribirNumero.Text + " no posee audio")
        End Try

    End Sub

    Private Sub pbSonido_MouseLeave(sender As Object, e As EventArgs) Handles pbSonido.MouseLeave
        pbSonido.Size = New Size(width:=100, height:=96)
    End Sub

    Private Sub TimerCangurito_Tick(sender As Object, e As EventArgs) Handles TimerCangurito.Tick

        '  intervalo = txtintervalo.Text

        'reinicia = txtnumeroSistema.Text + txtintervalo.Text
        '' MsgBox(reinicia)
        If Val(lbNumero.Text) + intervalo > Lbfinal.Text Then
            Exit Sub
        Else
            If lbNumero.Text <> "" Then
                lbNumero.Text += intervalo
                txtnum.Text = lbNumero.Text
            Else
                lbNumero.Text = intervalo
                txtnum.Text = lbNumero.Text
            End If
        End If



    End Sub
End Class