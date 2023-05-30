Public Class FrmCangurito
    Dim idiomas As String
    Private Sub FrmCangurito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnumeroSistema.Text = txtintervalo.Text

        txtRespuesta.Focus()
        pbGanaste.Visible = False
        pbEsconderNumero.Visible = True
        txtRespuesta.Text = ""
        txtRespuesta.ReadOnly = False
        BTNprobar.Enabled = True

        idiomas = Lbidioma.Text

    End Sub
    Sub reproducir(ByVal ruta As String)

        Try
            AxmpNumero.URL = ruta
        Catch ex As Exception
            MsgBox("No existe el audio del numero" + ex.ToString)
        End Try

    End Sub


    Private Sub pbEsconderNumero_Click(sender As Object, e As EventArgs) Handles pbEsconderNumero.Click
        Dim idio As String

        If idiomas = "Español" Then
            idio = "E"
            Try
                'reproducir("C:\Users\USUARIO\source\repos\JUEGO DE NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + ".mp3")
                reproducir("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + idio + ".mpeg")
                '  reproducir(My.Application.Info.DirectoryPath & "\docs\ " + txtnumeroSistema.Text + idio + ".mpeg")


            Catch ex As Exception
                MsgBox("El numero " + txtnumeroSistema.Text + " no posee audio")
            End Try
        ElseIf idiomas = "Ingles" Then
            idio = "I"
            Try
                'reproducir("C:\Users\USUARIO\source\repos\JUEGO DE NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + ".mp3")
                reproducir("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + idio + ".mpeg")

                '  reproducir(My.Application.Info.DirectoryPath & "\docs\ " + txtnumeroSistema.Text + idio + ".mpeg")

            Catch ex As Exception
                MsgBox("El numero " + txtnumeroSistema.Text + " no posee audio")
            End Try
        End If

    End Sub

    Private Sub txtnumeroSistema_TextChanged(sender As Object, e As EventArgs) Handles txtnumeroSistema.TextChanged
        Dim idio As String
        If idiomas = "Español" Then
            idio = "E"
        ElseIf idiomas = "Ingles" Then
            idio = "I"
        End If
        Try
            '  reproducir("C:\Users\USUARIO\source\repos\JUEGO DE NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + ".mp3")
            reproducir("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + idio + ".mpeg")
            '     reproducir(My.Application.Info.DirectoryPath & "\docs\ " + txtnumeroSistema.Text + idio + ".mpeg")

        Catch ex As Exception
            MsgBox("El numero " + txtnumeroSistema.Text + " no posee audio")
        End Try
    End Sub

    Private Sub pbGanaste_Click(sender As Object, e As EventArgs) Handles pbGanaste.Click
        'Dim sum As Long
        pbGanaste.Visible = False
        pbEsconderNumero.Visible = True
        txtRespuesta.Text = ""
        txtRespuesta.Focus()
        txtRespuesta.ReadOnly = False
        BTNprobar.Enabled = True


        txtnumeroSistema.Text = Val(txtnumeroSistema.Text) + Val(txtintervalo.Text)
        ''sum = Val(txtintervalo.Text) + Val(txtnumeroSistema.Text) + Val(Lbfinal.Text)
        ''MsgBox(sum)
        'Try
        '    If (Val(txtintervalo.Text) + Val(txtnumeroSistema.Text)) > Val(Lbfinal.Text) Then
        '        MsgBox("esta no")
        '        Exit Sub
        '    Else
        '        If Val(txtnumeroSistema.Text) <> "" Then
        '            MsgBox("esta si")
        '            txtnumeroSistema.Text += Val(txtintervalo.Text)

        '        ElseIf Val(txtnumeroSistema.Text) = "" Then
        '            txtnumeroSistema.Text = Val(txtintervalo.Text)
        '            MsgBox("esta igual")
        '        End If
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex)
        'End Try


    End Sub

    Private Sub pbperdiste_Click(sender As Object, e As EventArgs) Handles pbperdiste.Click
        'Dim sum As Long
        pbperdiste.Visible = False
        pbEsconderNumero.Visible = True
        txtRespuesta.Text = ""
        txtRespuesta.Focus()
        txtRespuesta.ReadOnly = False
        BTNprobar.Enabled = True

        txtnumeroSistema.Text = Val(txtnumeroSistema.Text) + Val(txtintervalo.Text)




    End Sub
    Private Sub pbSuspenso_MouseHover(sender As Object, e As EventArgs) Handles pbSuspenso.MouseHover
        pbSuspenso.Size = New Size(width:=163, height:=155)
    End Sub

    Private Sub pbSuspenso_MouseLeave(sender As Object, e As EventArgs) Handles pbSuspenso.MouseLeave
        pbSuspenso.Size = New Size(width:=158, height:=150)
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

                ' reproducir(My.Application.Info.DirectoryPath & "\docs\ " + txtnumeroSistema.Text + idio + ".mpeg")

            Catch ex As Exception
                MsgBox("El numero " + txtnumeroSistema.Text + " no posee audio")
            End Try
        ElseIf idiomas = "Ingles" Then
            idio = "I"
            Try
                'reproducir("C:\Users\USUARIO\source\repos\JUEGO DE NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + ".mp3")
                reproducir("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosNumeros\" + txtnumeroSistema.Text + idio + ".mpeg")

                '     reproducir(My.Application.Info.DirectoryPath & "\docs\ " + txtnumeroSistema.Text + idio + ".mpeg")

            Catch ex As Exception
                MsgBox("El numero " + txtnumeroSistema.Text + " no posee audio")
            End Try
        End If
    End Sub

    Private Sub pbEsconderNumero_MouseLeave(sender As Object, e As EventArgs) Handles pbEsconderNumero.MouseLeave
        pbEsconderNumero.Size = New Size(width:=222, height:=159)
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

            Try
                reproducir("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosImagenes\Ganaste.mp3")

                'reproducir(My.Application.Info.DirectoryPath & "\docs\Audios\AudiosImagenes\Ganaste.mp3")

            Catch ex As Exception
                MsgBox("No posee audio")
            End Try
        Else
            pbperdiste.Visible = True
            pbEsconderNumero.Visible = False
            txtRespuesta.ReadOnly = True
            BTNprobar.Enabled = False
            txtRespuesta.Focus()
            FrmMenu.LBintentos.Text = FrmMenu.LBintentos.Text + 1
            FrmMenu.LBerrores.Text = FrmMenu.LBerrores.Text + 1
            Try
                reproducir("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosImagenes\perdiNiños.mp3")

                'reproducir(My.Application.Info.DirectoryPath & "\Audios\AudiosImagenes\perdiNiños.mp3")
                'MsgBox(My.Application.Info.DirectoryPath & "\Audios\AudiosImagenes\perdiNiños.mp3")

                datosDeErrores("CANGURITO ESPAÑOL", "(DE " & Lbiniciar.Text & " a " & Lbfinal.Text & ", Cangurito " & txtintervalo.Text & ")     = " & txtnumeroSistema.Text, txtRespuesta.Text)
            Catch ex As Exception
                MsgBox("No posee audio")
            End Try
        End If
    End Sub

End Class