Module MResusltadosDeJuego
    Public Sub datosDeErrores(ByVal nombreOperacion As String, oper As String, respuest As String)
        Dim operac As AgregarAdataGridView = New AgregarAdataGridView()

        Select Case nombreOperacion
            Case "RESTA DE UNA CIFRA"
                operac.nombrejuego = "RESTA DE UNA CIFRA"
                operac.operacion = oper
                operac.respuesta = respuest
                FrmMenu.DgridResuldos.Rows.Insert(0, operac.nombrejuego, operac.operacion, operac.respuesta)
            Case "RESTA DE DOS CIFRA"
                operac.nombrejuego = "RESTA DE DOS CIFRA"
                operac.operacion = oper
                operac.respuesta = respuest
                FrmMenu.DgridResuldos.Rows.Insert(0, operac.nombrejuego, operac.operacion, operac.respuesta)
            Case "SUMA DE UNA CIFRA"
                operac.nombrejuego = "SUMA DE UNA CIFRA"
                operac.operacion = oper
                operac.respuesta = respuest
                FrmMenu.DgridResuldos.Rows.Insert(0, operac.nombrejuego, operac.operacion, operac.respuesta)
            Case "SUMA DE DOS CIFRA"
                operac.nombrejuego = "SUMA DE DOS CIFRA"
                operac.operacion = oper
                operac.respuesta = respuest
                FrmMenu.DgridResuldos.Rows.Insert(0, operac.nombrejuego, operac.operacion, operac.respuesta)

            Case "CANGURITO ESPAÑOL"
                operac.nombrejuego = "CANGURITO ESPAÑOL"
                operac.operacion = oper
                operac.respuesta = respuest
                FrmMenu.DgridResuldos.Rows.Insert(0, operac.nombrejuego, operac.operacion, operac.respuesta)

            Case "DICTADO ESPAÑOL"
                operac.nombrejuego = "DICTADO ESPAÑOL"
                operac.operacion = oper
                operac.respuesta = respuest
                FrmMenu.DgridResuldos.Rows.Insert(0, operac.nombrejuego, operac.operacion, operac.respuesta)

                'Case "NIVEL BEBÉ INGLES"
                '    operac.nombrejuego = "CANGURITO ESPAÑOL"
                '    operac.operacion = oper
                '    operac.respuesta = respuest
                '    FrmMenu.DgridResuldos.Rows.Insert(0, operac.nombrejuego, operac.operacion, operac.respuesta)

                'Case "CANGURITO INGLES"
                '    operac.nombrejuego = "CANGURITO INGLES"
                '    operac.operacion = oper
                '    operac.respuesta = respuest
                '    FrmMenu.DgridResuldos.Rows.Insert(0, operac.nombrejuego, operac.operacion, operac.respuesta)

                'Case "DICTADO INGLES"
                '    operac.nombrejuego = "DICTADO INGLES"
                '    operac.operacion = oper
                '    operac.respuesta = respuest
                '    FrmMenu.DgridResuldos.Rows.Insert(0, operac.nombrejuego, operac.operacion, operac.respuesta)
        End Select


    End Sub
End Module
