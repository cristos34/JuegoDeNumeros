Imports System.ComponentModel

Public Class FrmEscogerLimites
    Private Sub FrmEscogerLimites_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIniciar.Focus()
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        If Val(txtIniciar.Text) >= Val(txtFinalizar.Text) Then
            txtIniciar.Text = ""
            txtFinalizar.Text = ""
            MsgBox("Numero inicial siempre debe ser mayor al numero final")
            txtIniciar.Focus()
        Else
            Select Case Me.LBjuego.Text & Me.LbIdioma.Text
                Case "NIVEL BEBÉE"
                    FrmMenu.LBnBeDE.Text = txtIniciar.Text
                    FrmMenu.LBnBeA.Text = txtFinalizar.Text
                    Me.Close()
                Case "CANGURITOE"
                    If (txtCangurito.Text >= txtIniciar.Text) And (txtCangurito.Text < txtFinalizar.Text) Then
                        FrmMenu.LBcangEde.Text = txtIniciar.Text
                        FrmMenu.LBcangEA.Text = txtFinalizar.Text
                        FrmMenu.LbIntervaloE.Text = txtCangurito.Text
                        Me.Close()
                    Else
                        txtCangurito.Text = ""
                        MsgBox("Este numero debe estar entre " & txtIniciar.Text & " hasta " & txtFinalizar.Text)

                        txtCangurito.Focus()
                    End If
'                 
                Case "DICTADOE"
                    FrmMenu.LBDictaEde.Text = txtIniciar.Text
                    FrmMenu.LBDictaEa.Text = txtFinalizar.Text
                    Me.Close()
                Case "NIVEL BEBÉI"
                    FrmMenu.LBnBiDE.Text = txtIniciar.Text
                    FrmMenu.LBnBiA.Text = txtFinalizar.Text
                    Me.Close()

                Case "CANGURITOI"

                    If (txtCangurito.Text >= txtIniciar.Text) And (txtCangurito.Text < txtFinalizar.Text) Then
                        FrmMenu.LBcangiDe.Text = txtIniciar.Text
                        FrmMenu.LBcangiA.Text = txtFinalizar.Text
                        FrmMenu.LbIntervaloI.Text = txtCangurito.Text
                        Me.Close()
                    Else
                        txtCangurito.Text = ""
                        MsgBox("Este numero debe estar entre " & txtIniciar.Text & " hasta " & txtFinalizar.Text)

                        txtCangurito.Focus()
                    End If


                Case "DICTADOI"
                    FrmMenu.LBDictaide.Text = txtIniciar.Text
                    FrmMenu.LBDictaiA.Text = txtFinalizar.Text
                    Me.Close()
            End Select

        End If


    End Sub

    Private Sub FrmEscogerLimites_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        txtCangurito.Text = ""
        txtFinalizar.Text = ""
        txtIniciar.Text = ""
        LbIdioma.Text = ""
        LBjuego.Text = ""

    End Sub

    Private Sub txtIniciar_TextChanged(sender As Object, e As EventArgs) Handles txtIniciar.TextChanged

    End Sub

    Private Sub txtFinalizar_TextChanged(sender As Object, e As EventArgs) Handles txtFinalizar.TextChanged

    End Sub

    Private Sub txtCangurito_TextChanged(sender As Object, e As EventArgs) Handles txtCangurito.TextChanged

    End Sub

    Private Sub txtIniciar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIniciar.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 13 Then
            txtFinalizar.Focus()

        End If
    End Sub

    Private Sub txtFinalizar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFinalizar.KeyPress
        If Not txtCangurito.Enabled = False Then
            If Not Char.IsNumber(e.KeyChar) Then
                e.Handled = True
            End If
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            End If
            If Asc(e.KeyChar) = 13 Then
                txtCangurito.Focus()

            End If
        Else
            If Not Char.IsNumber(e.KeyChar) Then
                e.Handled = True
            End If
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            End If
            If Asc(e.KeyChar) = 13 Then
                BtnEnviar.PerformClick()

            End If
        End If


    End Sub

    Private Sub txtCangurito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCangurito.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 13 Then
            BtnEnviar.PerformClick()
        End If
    End Sub

End Class