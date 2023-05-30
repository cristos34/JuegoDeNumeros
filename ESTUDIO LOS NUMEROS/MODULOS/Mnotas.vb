Module Mnotas
    'Dastos de donde debo copiar la url del pc que lo va a USAR para porder vender el juego

    ' CREAR CARPETAS PARA AUDIOS EN INGLES Y EN ESPAÑOL Y UNA CARPETA PARA LOS AUDIOS DE LAS IMAGENE 

    ' EJEMPLOS: "AUDIOS JUEGOS DE NUMEROS"-"AUDIOS ESPAÑOL"-"AUDIOS INGLES"-"AUDIOS IMAGENES GIF" .........................
    '__________________________________________________________________________________________________

    ' EN EL FORMULARIO FrmCangurito 
    ' -EN EL PICTURE BOX pbEsconderNumero EN EL EVENTO CLIK
    '-EN EL TEXTBOX txtnumeroSistema EN EL EVENTO CHANGE
    '-EN EL PICTURE BOX pbEsconderNumero EN EL EVENTO HOVER

    '-EN EL BOTON PROBAR SE DEBE CAMBIAR LA URL DEL LAS IMAGENES BTNprobar.Click...........................................................

    '__________________________________________________________________________________________________
    '-Private Sub FrmDictado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '-EN EL FORMULARIO FrmDictado 
    '-EN EL PICTURE BOX pbEsconderNumero EN EL EVENTO CLIK
    '-EN EL TEXTBOX txtnumeroSistema EN EL EVENTO CHANGE
    '-EN EL PICTURE BOX pbEsconderNumero EN EL EVENTO HOVER
    '-EN EL BOTON btnRepetir_Click 
    '-EN EL BOTON PROBAR SE DEBE CAMBIAR LA URL DEL LAS IMAGEN
    '__________________________________________________________________________________________________________
    '- Private Sub FrmGenero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '-EN EL CARGADOR load del formulario FrmGenero : se encuentra el audio de escoge tu personaje
    '-EN EL PICTUREBOX pbGeneroNiña SE ENCUENTRA EL SONIDO DE ESPADA NIÑA
    '-______________________________________________________________________________________________________________

    '- Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '--EN EL CARGADOR load del formulario FrmMenu : se encuentra el audio de Iniciar juegos



    '"RESTA DE UNA CIFRA"
    ' "RESTA DE DOS CIFRA"

    '"CANGURITO ESPAÑOL"

    '"DICTADO ESPAÑOL"

    '"NIVEL BEBÉ INGLES"

    '"CANGURITO INGLES"

    '"DICTADO INGLES"

    '_______________________________________________________________________________________________________________
    'Buscar la ruta donde se encuntra el audio
    'MsgBox(My.Application.Info.DirectoryPath & "\docs\4E.mpeg")
    'My.Application.Info.DirectoryPath & "\docs\4E.mpeg"


End Module
