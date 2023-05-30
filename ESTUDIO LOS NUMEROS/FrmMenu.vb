Public Class FrmMenu
    Dim int As Integer
    Dim acier As Integer
    Dim errro As Integer
    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DgridResuldos.Columns.Add("JUEGo", "JUEGOS")
        DgridResuldos.Columns.Add("PREMISa", "PREMISA")
        DgridResuldos.Columns.Add("RESPUESTAs", "RESPUESTAS")

        Try
            reproducirr("C:\Users\USUARIO\source\repos\ESTUDIO LOS NUMEROS\Audios\AudiosImagenes\IniciarJuego.mp3")
        Catch ex As Exception
            MsgBox("No posee audio")
        End Try
    End Sub
    Sub reproducirr(ByVal ruta As String)
        Try

            axwpSonidoMenu.URL = ruta
        Catch ex As Exception
            MsgBox("No existe el audio del numero " + ex.ToString)
        End Try

    End Sub

    Private Sub pbNivelBebeEspañol_Click(sender As Object, e As EventArgs) Handles pbNivelBebeEspañol.Click
        Dim inicial As Long
        Dim fin As Long
        Me.GBnivelBebeE.Visible = True
        FrmEscogerLimites.LBjuego.Text = "NIVEL BEBÉ"
        FrmEscogerLimites.LbIdioma.Text = "E"
        FrmEscogerLimites.ShowDialog()

        Try
            inicial = LBnBeDE.Text
            fin = LBnBeA.Text

            'inicial = InputBox("Ingrese el numero con el que decea iniciar ", "Numero Inicial")
            'fin = InputBox("Ingrese hasta que numero decea ", "Numero final")

            If inicial >= fin Then
                MsgBox("El numero inicial, simpre debe ser menor al numero final")

            Else
                If IsNumeric(inicial) Then
                    FrmGenero.Lbiniciar.Text = inicial
                Else
                    FrmGenero.Lbiniciar.Text = 0
                End If


                If IsNumeric(fin) Then
                    FrmGenero.Lbfinal.Text = fin
                Else
                    FrmGenero.Lbfinal.Text = 100
                End If
                FrmGenero.lbJuego.Text = "NIVEL BEBÉ"
                FrmGenero.LbEtiquetaGenero.Text = "Nivel bebé"
                FrmGenero.Lbidioma.Text = "Español"
                FrmGenero.ShowDialog()
                'FrmDdiezenDiez.Show()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub pbCangurito_Click(sender As Object, e As EventArgs) Handles pbCangurito.Click
        Dim inicial As Long
        Dim fin As Long
        Dim intervalo As Long

        Me.GBcanguritoE.Visible = True
        FrmEscogerLimites.LBjuego.Text = "CANGURITO"
        FrmEscogerLimites.LbIdioma.Text = "E"
        FrmEscogerLimites.txtCangurito.Enabled = True
        FrmEscogerLimites.ShowDialog()
        axwpSonidoMenu.Ctlcontrols.stop()

        Try
            inicial = LBcangEde.Text
            fin = LBcangEA.Text
            intervalo = LbIntervaloE.Text

            'inicial = InputBox("Ingrese el numero con el que decea iniciar ", "Numero Inicial")
            'fin = InputBox("Ingrese hasta que numero decea ", "Numero final")
            'intervalo = InputBox("Ingrese el numero cangurito con el que decea jugar ", "Numero Cangurito")

            If inicial >= fin Then
                MsgBox("El numero inicial, simpre debe ser menor al numero final")

            Else
                If IsNumeric(inicial) Then
                    FrmGenero.Lbiniciar.Text = inicial
                Else
                    FrmGenero.Lbiniciar.Text = 0
                End If

                If IsNumeric(fin) Then
                    FrmGenero.Lbfinal.Text = fin
                Else
                    FrmGenero.Lbfinal.Text = 100
                End If


                If IsNumeric(intervalo) Then
                    If intervalo > fin Then
                        MsgBox("Debe ingresar otro numero cangurito ya que el ingresado anteriormente es mayor que numero final ")

                        Exit Sub

                    Else
                        FrmGenero.lbcangurito.Text = intervalo
                    End If

                Else
                    FrmGenero.lbcangurito.Text = 10
                End If

                FrmGenero.lbJuego.Text = "CANGURITO"
                FrmGenero.LbEtiquetaGenero.Text = "Cangurito"
                FrmGenero.Lbidioma.Text = "Español"

                FrmGenero.ShowDialog()
                'FrmDdiezenDiez.Show()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub pbDictadoEspañol_Click(sender As Object, e As EventArgs) Handles pbDictadoEspañol.Click
        Dim inicial As Long
        Dim fin As Long

        Me.GBDictadoE.Visible = True
        FrmEscogerLimites.LBjuego.Text = "DICTADO"
        FrmEscogerLimites.LbIdioma.Text = "E"
        FrmEscogerLimites.ShowDialog()

        Try
            inicial = LBDictaEde.Text
            fin = LBDictaEa.Text

            'inicial = InputBox("Ingrese el numero con el que decea iniciar ", "Numero Inicial")
            'fin = InputBox("Ingrese hasta que numero decea ", "Numero final")

            If inicial >= fin Then
                MsgBox("El numero inicial, simpre debe ser menor al numero final")

            Else
                If IsNumeric(inicial) Then
                    FrmGenero.Lbiniciar.Text = inicial
                Else
                    FrmGenero.Lbiniciar.Text = 0
                End If


                If IsNumeric(fin) Then
                    FrmGenero.Lbfinal.Text = fin
                Else
                    FrmGenero.Lbfinal.Text = 100
                End If

                FrmGenero.lbJuego.Text = "DICTADO"
                FrmGenero.LbEtiquetaGenero.Text = "Dictado"
                FrmGenero.Lbidioma.Text = "Español"

                FrmGenero.ShowDialog()
                'FrmDdiezenDiez.Show()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub pbSuma_Click(sender As Object, e As EventArgs) Handles pbSuma.Click
        frmEscogerOperacion.GBJUEGOS.Text = "JUEGOS DE SUMAS"
        frmEscogerOperacion.ShowDialog()
    End Sub

    Private Sub pbNivelBebeIngles_Click(sender As Object, e As EventArgs) Handles pbNivelBebeIngles.Click
        Dim inicial As Long
        Dim fin As Long
        Me.GBnivelBebeI.Visible = True
        FrmEscogerLimites.LBjuego.Text = "NIVEL BEBÉ"
        FrmEscogerLimites.LbIdioma.Text = "I"
        FrmEscogerLimites.ShowDialog()

        Try
            inicial = LBnBiDE.Text
            fin = LBnBiA.Text

            'inicial = InputBox("Ingrese el numero con el que decea iniciar ", "Numero Inicial")
            'fin = InputBox("Ingrese hasta que numero decea ", "Numero final")

            If inicial >= fin Then
                MsgBox("El numero inicial, simpre debe ser menor al numero final")

            Else
                If IsNumeric(inicial) Then
                    FrmGenero.Lbiniciar.Text = inicial
                Else
                    FrmGenero.Lbiniciar.Text = 0
                End If


                If IsNumeric(fin) Then
                    FrmGenero.Lbfinal.Text = fin
                Else
                    FrmGenero.Lbfinal.Text = 100
                End If
                FrmGenero.lbJuego.Text = "NIVEL BEBÉ"
                FrmGenero.LbEtiquetaGenero.Text = "Nivel bebé"
                FrmGenero.Lbidioma.Text = "Ingles"
                FrmGenero.ShowDialog()
                'FrmDdiezenDiez.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub pbCanguritoIngles_Click(sender As Object, e As EventArgs) Handles pbCanguritoIngles.Click
        Dim inicial As Long
        Dim fin As Long
        Dim intervalo As Long

        Me.GBcanguritoI.Visible = True
        FrmEscogerLimites.LBjuego.Text = "CANGURITO"
        FrmEscogerLimites.LbIdioma.Text = "I"
        FrmEscogerLimites.txtCangurito.Enabled = True
        FrmEscogerLimites.ShowDialog()

        Try
            inicial = LBcangiDe.Text
            fin = LBcangiA.Text
            intervalo = LbIntervaloI.Text

            'inicial = InputBox("Ingrese el numero con el que decea iniciar ", "Numero Inicial")
            'fin = InputBox("Ingrese hasta que numero decea ", "Numero final")
            'intervalo = InputBox("Ingrese el numero cangurito con el que decea jugar ", "Numero Cangurito")

            If inicial >= fin Then
                MsgBox("El numero inicial, simpre debe ser menor al numero final")

            Else
                If IsNumeric(inicial) Then
                    FrmGenero.Lbiniciar.Text = inicial
                Else
                    FrmGenero.Lbiniciar.Text = 0
                End If

                If IsNumeric(fin) Then
                    FrmGenero.Lbfinal.Text = fin
                Else
                    FrmGenero.Lbfinal.Text = 100
                End If


                If IsNumeric(intervalo) Then
                    If intervalo > fin Then
                        MsgBox("Debe ingresar otro numero cangurito ya que el ingresado anteriormente es mayor que numero final ")

                        Exit Sub

                    Else
                        FrmGenero.lbcangurito.Text = intervalo
                    End If

                Else
                    FrmGenero.lbcangurito.Text = 10
                End If

                FrmGenero.lbJuego.Text = "CANGURITO"
                FrmGenero.LbEtiquetaGenero.Text = "Cangurito"
                FrmGenero.Lbidioma.Text = "Ingles"

                FrmGenero.ShowDialog()
                'FrmDdiezenDiez.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub pbDictadoIngles_Click(sender As Object, e As EventArgs) Handles pbDictadoIngles.Click
        Dim inicial As Long
        Dim fin As Long

        Me.GBDictadoI.Visible = True
        FrmEscogerLimites.LBjuego.Text = "DICTADO"
        FrmEscogerLimites.LbIdioma.Text = "I"
        FrmEscogerLimites.ShowDialog()

        Try
            inicial = LBDictaide.Text
            fin = LBDictaiA.Text

            'inicial = InputBox("Ingrese el numero con el que decea iniciar ", "Numero Inicial")
            'fin = InputBox("Ingrese hasta que numero decea ", "Numero final")

            If inicial >= fin Then
                MsgBox("El numero inicial, simpre debe ser menor al numero final")

            Else
                If IsNumeric(inicial) Then
                    FrmGenero.Lbiniciar.Text = inicial
                Else
                    FrmGenero.Lbiniciar.Text = 0
                End If


                If IsNumeric(fin) Then
                    FrmGenero.Lbfinal.Text = fin
                Else
                    FrmGenero.Lbfinal.Text = 100
                End If

                FrmGenero.lbJuego.Text = "DICTADO"
                FrmGenero.LbEtiquetaGenero.Text = "Dictado"
                FrmGenero.Lbidioma.Text = "Ingles"

                FrmGenero.ShowDialog()
                'FrmDdiezenDiez.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub pbResta_Click(sender As Object, e As EventArgs) Handles pbResta.Click

        frmEscogerOperacion.GBJUEGOS.Text = "JUEGOS DE RESTAS"
        frmEscogerOperacion.ShowDialog()

    End Sub

    Private Sub pbSuma_MouseHover(sender As Object, e As EventArgs) Handles pbSuma.MouseHover
        pbSuma.Size = New Size(width:=104, height:=100)
    End Sub

    Private Sub pbSuma_MouseLeave(sender As Object, e As EventArgs) Handles pbSuma.MouseLeave
        pbSuma.Size = New Size(width:=100, height:=96)
    End Sub

    Private Sub pbNivelBebeIngles_MouseHover(sender As Object, e As EventArgs) Handles pbNivelBebeIngles.MouseHover
        pbNivelBebeIngles.Size = New Size(width:=104, height:=100)
    End Sub

    Private Sub pbNivelBebeIngles_MouseLeave(sender As Object, e As EventArgs) Handles pbNivelBebeIngles.MouseLeave
        pbNivelBebeIngles.Size = New Size(width:=100, height:=96)
    End Sub

    Private Sub pbCanguritoIngles_MouseHover(sender As Object, e As EventArgs) Handles pbCanguritoIngles.MouseHover
        pbCanguritoIngles.Size = New Size(width:=104, height:=100)
    End Sub

    Private Sub pbCanguritoIngles_MouseLeave(sender As Object, e As EventArgs) Handles pbCanguritoIngles.MouseLeave
        pbCanguritoIngles.Size = New Size(width:=100, height:=96)
    End Sub

    Private Sub pbDictadoIngles_MouseHover(sender As Object, e As EventArgs) Handles pbDictadoIngles.MouseHover
        pbDictadoIngles.Size = New Size(width:=104, height:=100)
    End Sub

    Private Sub pbDictadoIngles_MouseLeave(sender As Object, e As EventArgs) Handles pbDictadoIngles.MouseLeave
        pbDictadoIngles.Size = New Size(width:=100, height:=96)
    End Sub

    Private Sub pbResta_MouseHover(sender As Object, e As EventArgs) Handles pbResta.MouseHover
        pbResta.Size = New Size(width:=104, height:=100)
    End Sub

    Private Sub pbResta_MouseLeave(sender As Object, e As EventArgs) Handles pbResta.MouseLeave
        pbResta.Size = New Size(width:=100, height:=96)
    End Sub

    Private Sub pbCangurito_MouseHover(sender As Object, e As EventArgs) Handles pbCangurito.MouseHover
        pbCangurito.Size = New Size(width:=104, height:=100)
    End Sub

    Private Sub pbCangurito_MouseLeave(sender As Object, e As EventArgs) Handles pbCangurito.MouseLeave
        pbCangurito.Size = New Size(width:=100, height:=96)
    End Sub

    Private Sub pbDictadoEspañol_MouseHover(sender As Object, e As EventArgs) Handles pbDictadoEspañol.MouseHover
        pbDictadoEspañol.Size = New Size(width:=104, height:=100)
    End Sub

    Private Sub pbDictadoEspañol_MouseLeave(sender As Object, e As EventArgs) Handles pbDictadoEspañol.MouseLeave
        pbDictadoEspañol.Size = New Size(width:=100, height:=96)
    End Sub

    Private Sub pbNivelBebeEspañol_MouseHover(sender As Object, e As EventArgs) Handles pbNivelBebeEspañol.MouseHover
        pbNivelBebeEspañol.Size = New Size(width:=104, height:=100)
    End Sub

    Private Sub pbNivelBebeEspañol_MouseLeave(sender As Object, e As EventArgs) Handles pbNivelBebeEspañol.MouseLeave
        pbNivelBebeEspañol.Size = New Size(width:=100, height:=96)
    End Sub

    Private Sub LBintentos_Click(sender As Object, e As EventArgs) Handles LBintentos.Click

    End Sub
End Class