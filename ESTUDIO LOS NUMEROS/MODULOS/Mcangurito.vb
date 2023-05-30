Module Mcangurito
    Function contarcangurito(ByVal finn As Integer, ByVal intervalo As Integer) As Integer
        Dim respuesta As Integer

        If Val(FrmCangurito.txtnumeroSistema.Text) + intervalo > finn Then

            Exit Function
        Else
            If Val(FrmCangurito.txtnumeroSistema.Text) <> "" Then
                respuesta = FrmCangurito.txtnumeroSistema.Text
                respuesta += intervalo
                Return CLng(respuesta)
            ElseIf Val(FrmCangurito.txtnumeroSistema.Text) = "" Then
                respuesta = FrmCangurito.txtnumeroSistema.Text
                respuesta = intervalo
                Return CLng(respuesta)
            End If
        End If

    End Function

End Module
