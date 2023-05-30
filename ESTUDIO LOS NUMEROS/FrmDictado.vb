Imports System.ComponentModel

Public Class FrmDictado
    Dim idiomas As String
    Private Sub FrmDictado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lbsegundos.Text = Cbtiempo.Text
        Call LLamarNumero()

        Gbcronometro.Visible = False
        Cbtiempo.Enabled = False
        CHEBOXcronometro.Enabled = True
        CHEBOXcronometro.Visible = True
        CHEBOXcronometro.Checked = False

        'txtnumeroSistema.Text = 10
        txtRespuesta.Focus()
        pbGanaste.Visible = False
        pbEsconderNumero.Visible = True
        txtRespuesta.Text = ""
        txtRespuesta.ReadOnly = False
        BTNprobar.Enabled = True
        idiomas = Lbidioma.Text
    End Sub

    Private Sub pbEsconderNumero_Click(sender As Object, e As EventArgs) Handles pbEsconderNumero.Click
        Dim idio As String

        If idiomas = "Español" Then
            idio = "E"
            Try
                'reproducir("C:\Users\USUARIO\source\repos\JUEGO DE NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + ".mp3")
                reproducir("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + idio + ".mpeg")
            Catch ex As Exception
                MsgBox("El numero " + txtnumeroSistema.Text + " no posee audio")
            End Try
        ElseIf idiomas = "Ingles" Then
            idio = "I"
            Try
                'reproducir("C:\Users\USUARIO\source\repos\JUEGO DE NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + ".mp3")
                reproducir("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + idio + ".mpeg")
            Catch ex As Exception
                MsgBox("El numero " + txtnumeroSistema.Text + " no posee audio")
            End Try
        End If


    End Sub

    Private Sub txtRespuesta_TextChanged(sender As Object, e As EventArgs) Handles txtRespuesta.TextChanged
        If txtRespuesta.Text = "" Or txtnumeroSistema.Text = "" Then
            pbGanaste.Visible = False
            pbperdiste.Visible = False
            pbEsconderNumero.Visible = True

        End If

    End Sub

    Private Sub pbSuspenso_Click(sender As Object, e As EventArgs) Handles pbSuspenso.Click

    End Sub

    Private Sub pbperdiste_Click(sender As Object, e As EventArgs) Handles pbperdiste.Click
        pbperdiste.Visible = False
        pbEsconderNumero.Visible = True
        txtRespuesta.Text = ""
        txtRespuesta.Focus()
        txtRespuesta.ReadOnly = False
        BTNprobar.Enabled = True
        Call LLamarNumero()
        TIEMPOdictado.Enabled = True


    End Sub

    Private Sub pbGanaste_Click(sender As Object, e As EventArgs) Handles pbGanaste.Click
        pbGanaste.Visible = False
        pbEsconderNumero.Visible = True
        txtRespuesta.Text = ""
        txtRespuesta.Focus()
        txtRespuesta.ReadOnly = False
        BTNprobar.Enabled = True
        Call LLamarNumero()
        TIEMPOdictado.Enabled = True


    End Sub
    Private Sub txtnumeroSistema_TextChanged(sender As Object, e As EventArgs) Handles txtnumeroSistema.TextChanged
        Dim idio As String

        If idiomas = "Español" Then
            idio = "E"
            Try
                '  reproducir("C:\Users\USUARIO\source\repos\JUEGO DE NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + ".mp3")
                reproducir("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + idio + ".mpeg")
            Catch ex As Exception
                MsgBox("El numero " + txtnumeroSistema.Text + " no posee audio")
            End Try
        ElseIf idiomas = "Ingles" Then
            idio = "I"
            Try
                '  reproducir("C:\Users\USUARIO\source\repos\JUEGO DE NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + ".mp3")
                reproducir("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + idio + ".mpeg")
            Catch ex As Exception
                MsgBox("El numero " + txtnumeroSistema.Text + " no posee audio")
            End Try
        End If


    End Sub
    Sub LLamarNumero()
        Dim dmin As Byte
        Dim amax As Byte
        Dim NumAleatorio As Integer
        dmin = Lbiniciar.Text
        amax = Lbfinal.Text

        NumAleatorio = numAleatorioEntre(dmin, amax)
        txtnumeroSistema.Text = NumAleatorio

    End Sub
    Sub reproducir(ByVal ruta As String)

        Try
            AxmpNumero.URL = ruta
        Catch ex As Exception
            MsgBox("No existe el audio del numero" + ex.ToString)
        End Try

    End Sub

    Private Sub txtRespuesta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRespuesta.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 13 Then
            BTNprobar.PerformClick()
        End If

    End Sub

    Private Sub BTNprobar_Click(sender As Object, e As EventArgs) Handles BTNprobar.Click
        If txtRespuesta.Text = "" Or txtnumeroSistema.Text = "" Then
            pbGanaste.Visible = False
            pbperdiste.Visible = False
            MsgBox("Debe colocar un numero")
            txtRespuesta.Focus()
        ElseIf Val(txtnumeroSistema.Text) = Val(txtRespuesta.Text) Then
            pbGanaste.Visible = True
            pbEsconderNumero.Visible = False
            txtRespuesta.ReadOnly = True
            BTNprobar.Enabled = False
            txtRespuesta.Focus()
            FrmMenu.LBintentos.Text = FrmMenu.LBintentos.Text + 1
            FrmMenu.LBaciertos.Text = FrmMenu.LBaciertos.Text + 1

            lbsegundos.Text = Cbtiempo.Text
            TIEMPOdictado.Enabled = False
            Try
                reproducir("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosImagenes\Ganaste.mp3")
            Catch ex As Exception
                MsgBox("No posee audio")
            End Try

        Else
            pbperdiste.Visible = True
            pbEsconderNumero.Visible = False
            txtRespuesta.ReadOnly = True
            BTNprobar.Enabled = False
            txtRespuesta.Focus()

            'Try
            '    datosDeErrores(,,)
            'Catch ex As Exception
            '    MsgBox("No posee audio")
            'End Try
            FrmMenu.LBintentos.Text = FrmMenu.LBintentos.Text + 1
            FrmMenu.LBerrores.Text = FrmMenu.LBerrores.Text + 1

            lbsegundos.Text = Cbtiempo.Text
            TIEMPOdictado.Enabled = False
            Try
                reproducir("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosImagenes\perdiNiños.mp3")
                datosDeErrores("DICTADO ESPAÑOL", "(DE " & Lbiniciar.Text & " a " & Lbfinal.Text & ")    = " & txtnumeroSistema.Text, txtRespuesta.Text)
            Catch ex As Exception
                MsgBox("No posee audio")
            End Try
        End If

    End Sub

    Private Sub pbSuspenso_MouseHover(sender As Object, e As EventArgs) Handles pbSuspenso.MouseHover
        pbSuspenso.Size = New Size(width:=200, height:=181)

    End Sub

    Private Sub pbSuspenso_MouseLeave(sender As Object, e As EventArgs) Handles pbSuspenso.MouseLeave
        pbSuspenso.Size = New Size(width:=204, height:=185)
    End Sub

    Private Sub pbperdiste_MouseHover(sender As Object, e As EventArgs) Handles pbperdiste.MouseHover
        pbperdiste.Size = New Size(width:=200, height:=181)

    End Sub

    Private Sub pbperdiste_MouseLeave(sender As Object, e As EventArgs) Handles pbperdiste.MouseLeave
        pbperdiste.Size = New Size(width:=204, height:=185)
    End Sub

    Private Sub pbGanaste_MouseHover(sender As Object, e As EventArgs) Handles pbGanaste.MouseHover
        pbGanaste.Size = New Size(width:=200, height:=181)


    End Sub

    Private Sub pbGanaste_MouseLeave(sender As Object, e As EventArgs) Handles pbGanaste.MouseLeave
        pbGanaste.Size = New Size(width:=204, height:=185)
    End Sub

    Private Sub pbEsconderNumero_MouseHover(sender As Object, e As EventArgs) Handles pbEsconderNumero.MouseHover
        pbEsconderNumero.Size = New Size(width:=226, height:=163)

        Dim idio As String

        If idiomas = "Español" Then
            idio = "E"

            Try
                'reproducir("C:\Users\USUARIO\source\repos\JUEGO DE NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + ".mp3")
                reproducir("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + idio + ".mpeg")
            Catch ex As Exception
                MsgBox("El numero " + txtnumeroSistema.Text + " no posee audio")
            End Try
        ElseIf idiomas = "Ingles" Then
            idio = "I"

            Try
                'reproducir("C:\Users\USUARIO\source\repos\JUEGO DE NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + ".mp3")
                reproducir("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + idio + ".mpeg")
            Catch ex As Exception
                MsgBox("El numero " + txtnumeroSistema.Text + " no posee audio")
            End Try
        End If
    End Sub

    Private Sub pbEsconderNumero_MouseLeave(sender As Object, e As EventArgs) Handles pbEsconderNumero.MouseLeave
        pbEsconderNumero.Size = New Size(width:=222, height:=159)
    End Sub

    Private Sub btnRepetir_Click(sender As Object, e As EventArgs)
        Dim idio As String

        If idiomas = "Español" Then
            idio = "E"
            Try
                'reproducir("C:\Users\USUARIO\source\repos\JUEGO DE NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + ".mp3")
                reproducir("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + idio + ".mpeg")
            Catch ex As Exception
                MsgBox("El numero " + txtnumeroSistema.Text + " no posee audio")
            End Try
        ElseIf idiomas = "Ingles" Then
            idio = "I"
            Try
                'reproducir("C:\Users\USUARIO\source\repos\JUEGO DE NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + ".mp3")
                reproducir("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + idio + ".mpeg")
            Catch ex As Exception
                MsgBox("El numero " + txtnumeroSistema.Text + " no posee audio")
            End Try
        End If

    End Sub
    Private Sub TIEMPOdictado_Tick(sender As Object, e As EventArgs) Handles TIEMPOdictado.Tick
        'S = Convert.ToInt32(lbsegundos.Text)
        If lbsegundos.Text <> "" Then

            lbsegundos.Text = lbsegundos.Text - 1

            If lbsegundos.Text < 10 Or lbsegundos.Text = 0 Then
                lbsegundos.Text = "0" & lbsegundos.Text
                If lbsegundos.Text = "00" Then
                    TIEMPOdictado.Enabled = False
                    PERDISTEporTIEMPO()
                    'MsgBox("LISTO PERDISTE")
                End If

            End If
        End If


    End Sub
    Sub PERDISTEporTIEMPO()
        pbperdiste.Visible = True
        pbEsconderNumero.Visible = False
        txtRespuesta.ReadOnly = True
        BTNprobar.Enabled = False
        txtRespuesta.Focus()

        FrmMenu.LBintentos.Text = FrmMenu.LBintentos.Text + 1
        FrmMenu.LBerrores.Text = FrmMenu.LBerrores.Text + 1

        lbsegundos.Text = Cbtiempo.Text
        TIEMPOdictado.Enabled = False
        Try
            reproducir("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosImagenes\perdiNiños.mp3")
            datosDeErrores("DICTADO ESPAÑOL", "(DE " & Lbiniciar.Text & " a " & Lbfinal.Text & ")    = " & txtnumeroSistema.Text, txtRespuesta.Text & " - POR TIEMPO")
        Catch ex As Exception
            MsgBox("No posee audio")
        End Try
    End Sub

    Private Sub Cbtiempo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbtiempo.SelectedIndexChanged
        lbsegundos.Text = Cbtiempo.Text
        Gbcronometro.Size = New Size(width:=56, height:=57)

        Cbtiempo.Enabled = False
        TIEMPOdictado.Enabled = True
    End Sub

    Private Sub FrmDictado_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Cbtiempo.Items.Add("8")
        Cbtiempo.Items.Add("9")
        Cbtiempo.Items.Add("10")
        Cbtiempo.Items.Add("12")
        Cbtiempo.Items.Add("13")
        Cbtiempo.Items.Add("14")
        Cbtiempo.Items.Add("15")
        Cbtiempo.Items.Add("16")
        Cbtiempo.Items.Add("17")
        Cbtiempo.Items.Add("18")
        Cbtiempo.Items.Add("19")
        Cbtiempo.Items.Add("20")

    End Sub

    Private Sub Gbcronometro_Enter(sender As Object, e As EventArgs) Handles Gbcronometro.Enter

    End Sub

    Private Sub CHEBOXcronometro_CheckedChanged(sender As Object, e As EventArgs) Handles CHEBOXcronometro.CheckedChanged
        If CHEBOXcronometro.Checked = True Then
            Gbcronometro.Visible = True
            Cbtiempo.Enabled = True
            CHEBOXcronometro.Enabled = False
            CHEBOXcronometro.Visible = False
            lbsegundos.Text = ""
            Gbcronometro.Size = New Size(width:=135, height:=57)
            Cbtiempo.Text = ""

        ElseIf CHEBOXcronometro.Checked = False Then
            Gbcronometro.Visible = False
        End If

    End Sub

    Private Sub lbsegundos_Click(sender As Object, e As EventArgs) Handles lbsegundos.Click

    End Sub

    Private Sub FrmDictado_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        TIEMPOdictado.Enabled = False
    End Sub
End Class