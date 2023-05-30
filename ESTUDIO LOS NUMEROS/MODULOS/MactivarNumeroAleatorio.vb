Module MactivarNumeroAleatorio
    Function numAleatorioEntre(ByVal min As Integer, ByVal max As Integer) As Integer
        Randomize()
        Return CLng((min - max) * Rnd() + max)
    End Function

End Module
