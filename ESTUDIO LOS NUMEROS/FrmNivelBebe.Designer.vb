<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNivelBebe
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNivelBebe))
        Me.AxwSonidoNumero = New AxWMPLib.AxWindowsMediaPlayer()
        Me.TimerNumero = New System.Windows.Forms.Timer(Me.components)
        Me.lbNumero = New System.Windows.Forms.Label()
        Me.txtEscribirNumero = New System.Windows.Forms.TextBox()
        Me.pbRepasarNumeros = New System.Windows.Forms.PictureBox()
        Me.pbSonido = New System.Windows.Forms.PictureBox()
        Me.pbEscribirNumeros = New System.Windows.Forms.PictureBox()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.Lbfinal = New System.Windows.Forms.Label()
        Me.Lbiniciar = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSonido = New System.Windows.Forms.Button()
        Me.btnCangurito = New System.Windows.Forms.Button()
        Me.TimerCangurito = New System.Windows.Forms.Timer(Me.components)
        Me.LbEtiquetaGenero = New System.Windows.Forms.Label()
        Me.lbcangurito = New System.Windows.Forms.Label()
        Me.lbJuego = New System.Windows.Forms.Label()
        Me.Lbidioma = New System.Windows.Forms.Label()
        CType(Me.AxwSonidoNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRepasarNumeros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSonido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEscribirNumeros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxwSonidoNumero
        '
        Me.AxwSonidoNumero.Enabled = True
        Me.AxwSonidoNumero.Location = New System.Drawing.Point(297, 12)
        Me.AxwSonidoNumero.Name = "AxwSonidoNumero"
        Me.AxwSonidoNumero.OcxState = CType(resources.GetObject("AxwSonidoNumero.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxwSonidoNumero.Size = New System.Drawing.Size(235, 34)
        Me.AxwSonidoNumero.TabIndex = 0
        Me.AxwSonidoNumero.Visible = False
        '
        'TimerNumero
        '
        Me.TimerNumero.Interval = 4000
        '
        'lbNumero
        '
        Me.lbNumero.BackColor = System.Drawing.Color.Transparent
        Me.lbNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 200.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumero.ForeColor = System.Drawing.Color.Yellow
        Me.lbNumero.Location = New System.Drawing.Point(48, 69)
        Me.lbNumero.Name = "lbNumero"
        Me.lbNumero.Size = New System.Drawing.Size(723, 302)
        Me.lbNumero.TabIndex = 1
        Me.lbNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEscribirNumero
        '
        Me.txtEscribirNumero.BackColor = System.Drawing.Color.Gray
        Me.txtEscribirNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 195.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEscribirNumero.ForeColor = System.Drawing.Color.Yellow
        Me.txtEscribirNumero.Location = New System.Drawing.Point(49, 69)
        Me.txtEscribirNumero.MaxLength = 4
        Me.txtEscribirNumero.Name = "txtEscribirNumero"
        Me.txtEscribirNumero.Size = New System.Drawing.Size(722, 302)
        Me.txtEscribirNumero.TabIndex = 2
        Me.txtEscribirNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbRepasarNumeros
        '
        Me.pbRepasarNumeros.BackColor = System.Drawing.Color.Transparent
        Me.pbRepasarNumeros.Image = Global.ESTUDIO_LOS_NUMEROS.My.Resources.Resources.NiñosEstudiando4
        Me.pbRepasarNumeros.Location = New System.Drawing.Point(799, 23)
        Me.pbRepasarNumeros.Name = "pbRepasarNumeros"
        Me.pbRepasarNumeros.Size = New System.Drawing.Size(100, 96)
        Me.pbRepasarNumeros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRepasarNumeros.TabIndex = 3
        Me.pbRepasarNumeros.TabStop = False
        '
        'pbSonido
        '
        Me.pbSonido.BackColor = System.Drawing.Color.Transparent
        Me.pbSonido.Image = Global.ESTUDIO_LOS_NUMEROS.My.Resources.Resources.BOMBINAS4
        Me.pbSonido.Location = New System.Drawing.Point(799, 125)
        Me.pbSonido.Name = "pbSonido"
        Me.pbSonido.Size = New System.Drawing.Size(100, 96)
        Me.pbSonido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSonido.TabIndex = 4
        Me.pbSonido.TabStop = False
        Me.pbSonido.Visible = False
        '
        'pbEscribirNumeros
        '
        Me.pbEscribirNumeros.BackColor = System.Drawing.Color.Transparent
        Me.pbEscribirNumeros.Image = Global.ESTUDIO_LOS_NUMEROS.My.Resources.Resources.LAPIZ4
        Me.pbEscribirNumeros.Location = New System.Drawing.Point(798, 23)
        Me.pbEscribirNumeros.Name = "pbEscribirNumeros"
        Me.pbEscribirNumeros.Size = New System.Drawing.Size(100, 96)
        Me.pbEscribirNumeros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEscribirNumeros.TabIndex = 5
        Me.pbEscribirNumeros.TabStop = False
        '
        'txtnum
        '
        Me.txtnum.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtnum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnum.Enabled = False
        Me.txtnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnum.ForeColor = System.Drawing.Color.Gray
        Me.txtnum.Location = New System.Drawing.Point(535, 427)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(58, 13)
        Me.txtnum.TabIndex = 6
        Me.txtnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbfinal
        '
        Me.Lbfinal.BackColor = System.Drawing.Color.Transparent
        Me.Lbfinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbfinal.ForeColor = System.Drawing.Color.Gray
        Me.Lbfinal.Location = New System.Drawing.Point(346, 425)
        Me.Lbfinal.Name = "Lbfinal"
        Me.Lbfinal.Size = New System.Drawing.Size(43, 15)
        Me.Lbfinal.TabIndex = 24
        Me.Lbfinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbiniciar
        '
        Me.Lbiniciar.BackColor = System.Drawing.Color.Transparent
        Me.Lbiniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbiniciar.ForeColor = System.Drawing.Color.Gray
        Me.Lbiniciar.Location = New System.Drawing.Point(272, 425)
        Me.Lbiniciar.Name = "Lbiniciar"
        Me.Lbiniciar.Size = New System.Drawing.Size(43, 15)
        Me.Lbiniciar.TabIndex = 23
        Me.Lbiniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(321, 424)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "al"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(116, 424)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Este juego inicia del : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSonido
        '
        Me.btnSonido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSonido.Location = New System.Drawing.Point(812, 389)
        Me.btnSonido.Name = "btnSonido"
        Me.btnSonido.Size = New System.Drawing.Size(75, 23)
        Me.btnSonido.TabIndex = 25
        Me.btnSonido.Text = "SONIDO"
        Me.btnSonido.UseVisualStyleBackColor = True
        Me.btnSonido.Visible = False
        '
        'btnCangurito
        '
        Me.btnCangurito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCangurito.Location = New System.Drawing.Point(799, 417)
        Me.btnCangurito.Name = "btnCangurito"
        Me.btnCangurito.Size = New System.Drawing.Size(104, 23)
        Me.btnCangurito.TabIndex = 27
        Me.btnCangurito.Text = "CANGURITO"
        Me.btnCangurito.UseVisualStyleBackColor = True
        '
        'TimerCangurito
        '
        Me.TimerCangurito.Interval = 4000
        '
        'LbEtiquetaGenero
        '
        Me.LbEtiquetaGenero.BackColor = System.Drawing.Color.Transparent
        Me.LbEtiquetaGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEtiquetaGenero.ForeColor = System.Drawing.Color.Gray
        Me.LbEtiquetaGenero.Location = New System.Drawing.Point(394, 425)
        Me.LbEtiquetaGenero.Name = "LbEtiquetaGenero"
        Me.LbEtiquetaGenero.Size = New System.Drawing.Size(86, 15)
        Me.LbEtiquetaGenero.TabIndex = 29
        Me.LbEtiquetaGenero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbcangurito
        '
        Me.lbcangurito.BackColor = System.Drawing.Color.Transparent
        Me.lbcangurito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcangurito.ForeColor = System.Drawing.Color.Gray
        Me.lbcangurito.Location = New System.Drawing.Point(486, 425)
        Me.lbcangurito.Name = "lbcangurito"
        Me.lbcangurito.Size = New System.Drawing.Size(43, 15)
        Me.lbcangurito.TabIndex = 28
        Me.lbcangurito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbJuego
        '
        Me.lbJuego.BackColor = System.Drawing.Color.Transparent
        Me.lbJuego.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbJuego.ForeColor = System.Drawing.Color.Gray
        Me.lbJuego.Location = New System.Drawing.Point(12, 11)
        Me.lbJuego.Name = "lbJuego"
        Me.lbJuego.Size = New System.Drawing.Size(781, 55)
        Me.lbJuego.TabIndex = 32
        Me.lbJuego.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbidioma
        '
        Me.Lbidioma.BackColor = System.Drawing.Color.Transparent
        Me.Lbidioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbidioma.ForeColor = System.Drawing.Color.Gray
        Me.Lbidioma.Location = New System.Drawing.Point(612, 427)
        Me.Lbidioma.Name = "Lbidioma"
        Me.Lbidioma.Size = New System.Drawing.Size(86, 15)
        Me.Lbidioma.TabIndex = 33
        Me.Lbidioma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmNivelBebe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ESTUDIO_LOS_NUMEROS.My.Resources.Resources.fondoFrmRepasar
        Me.ClientSize = New System.Drawing.Size(912, 450)
        Me.Controls.Add(Me.Lbidioma)
        Me.Controls.Add(Me.lbJuego)
        Me.Controls.Add(Me.LbEtiquetaGenero)
        Me.Controls.Add(Me.lbcangurito)
        Me.Controls.Add(Me.btnCangurito)
        Me.Controls.Add(Me.btnSonido)
        Me.Controls.Add(Me.Lbfinal)
        Me.Controls.Add(Me.Lbiniciar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.pbEscribirNumeros)
        Me.Controls.Add(Me.pbSonido)
        Me.Controls.Add(Me.pbRepasarNumeros)
        Me.Controls.Add(Me.lbNumero)
        Me.Controls.Add(Me.AxwSonidoNumero)
        Me.Controls.Add(Me.txtEscribirNumero)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNivelBebe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MODO APRENDIZAJE"
        CType(Me.AxwSonidoNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRepasarNumeros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSonido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEscribirNumeros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AxwSonidoNumero As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents TimerNumero As Timer
    Friend WithEvents lbNumero As Label
    Friend WithEvents txtEscribirNumero As TextBox
    Friend WithEvents pbRepasarNumeros As PictureBox
    Friend WithEvents pbSonido As PictureBox
    Friend WithEvents pbEscribirNumeros As PictureBox
    Friend WithEvents txtnum As TextBox
    Friend WithEvents Lbfinal As Label
    Friend WithEvents Lbiniciar As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSonido As Button
    Friend WithEvents btnCangurito As Button
    Friend WithEvents TimerCangurito As Timer
    Friend WithEvents LbEtiquetaGenero As Label
    Friend WithEvents lbcangurito As Label
    Friend WithEvents lbJuego As Label
    Friend WithEvents Lbidioma As Label
End Class
