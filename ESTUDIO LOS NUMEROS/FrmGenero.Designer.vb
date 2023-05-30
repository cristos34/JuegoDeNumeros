<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenero
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGenero))
        Me.pbGeneroNiña = New System.Windows.Forms.PictureBox()
        Me.pbGeneroNiño = New System.Windows.Forms.PictureBox()
        Me.Lbfinal = New System.Windows.Forms.Label()
        Me.Lbiniciar = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AxwpSaludos = New AxWMPLib.AxWindowsMediaPlayer()
        Me.lbJuego = New System.Windows.Forms.Label()
        Me.lbcangurito = New System.Windows.Forms.Label()
        Me.LbEtiquetaGenero = New System.Windows.Forms.Label()
        Me.Lbidioma = New System.Windows.Forms.Label()
        CType(Me.pbGeneroNiña, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGeneroNiño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxwpSaludos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbGeneroNiña
        '
        Me.pbGeneroNiña.BackColor = System.Drawing.Color.Transparent
        Me.pbGeneroNiña.Image = Global.ESTUDIO_LOS_NUMEROS.My.Resources.Resources.gifniña
        Me.pbGeneroNiña.Location = New System.Drawing.Point(439, 12)
        Me.pbGeneroNiña.Name = "pbGeneroNiña"
        Me.pbGeneroNiña.Size = New System.Drawing.Size(328, 451)
        Me.pbGeneroNiña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbGeneroNiña.TabIndex = 1
        Me.pbGeneroNiña.TabStop = False
        '
        'pbGeneroNiño
        '
        Me.pbGeneroNiño.BackColor = System.Drawing.Color.Transparent
        Me.pbGeneroNiño.Image = Global.ESTUDIO_LOS_NUMEROS.My.Resources.Resources.gifNiño
        Me.pbGeneroNiño.Location = New System.Drawing.Point(2, 12)
        Me.pbGeneroNiño.Name = "pbGeneroNiño"
        Me.pbGeneroNiño.Size = New System.Drawing.Size(353, 451)
        Me.pbGeneroNiño.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbGeneroNiño.TabIndex = 0
        Me.pbGeneroNiño.TabStop = False
        '
        'Lbfinal
        '
        Me.Lbfinal.BackColor = System.Drawing.Color.Transparent
        Me.Lbfinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbfinal.ForeColor = System.Drawing.Color.Gray
        Me.Lbfinal.Location = New System.Drawing.Point(365, 440)
        Me.Lbfinal.Name = "Lbfinal"
        Me.Lbfinal.Size = New System.Drawing.Size(43, 15)
        Me.Lbfinal.TabIndex = 20
        Me.Lbfinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbiniciar
        '
        Me.Lbiniciar.BackColor = System.Drawing.Color.Transparent
        Me.Lbiniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbiniciar.ForeColor = System.Drawing.Color.Gray
        Me.Lbiniciar.Location = New System.Drawing.Point(291, 440)
        Me.Lbiniciar.Name = "Lbiniciar"
        Me.Lbiniciar.Size = New System.Drawing.Size(43, 15)
        Me.Lbiniciar.TabIndex = 19
        Me.Lbiniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(340, 440)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "al"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(135, 440)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 15)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Este juego inicia del : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AxwpSaludos
        '
        Me.AxwpSaludos.Enabled = True
        Me.AxwpSaludos.Location = New System.Drawing.Point(263, 400)
        Me.AxwpSaludos.Name = "AxwpSaludos"
        Me.AxwpSaludos.OcxState = CType(resources.GetObject("AxwpSaludos.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxwpSaludos.Size = New System.Drawing.Size(261, 37)
        Me.AxwpSaludos.TabIndex = 21
        Me.AxwpSaludos.Visible = False
        '
        'lbJuego
        '
        Me.lbJuego.BackColor = System.Drawing.Color.Transparent
        Me.lbJuego.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbJuego.ForeColor = System.Drawing.Color.Gray
        Me.lbJuego.Location = New System.Drawing.Point(32, 12)
        Me.lbJuego.Name = "lbJuego"
        Me.lbJuego.Size = New System.Drawing.Size(710, 55)
        Me.lbJuego.TabIndex = 22
        Me.lbJuego.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbcangurito
        '
        Me.lbcangurito.BackColor = System.Drawing.Color.Transparent
        Me.lbcangurito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcangurito.ForeColor = System.Drawing.Color.Gray
        Me.lbcangurito.Location = New System.Drawing.Point(509, 440)
        Me.lbcangurito.Name = "lbcangurito"
        Me.lbcangurito.Size = New System.Drawing.Size(43, 15)
        Me.lbcangurito.TabIndex = 23
        Me.lbcangurito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbEtiquetaGenero
        '
        Me.LbEtiquetaGenero.BackColor = System.Drawing.Color.Transparent
        Me.LbEtiquetaGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEtiquetaGenero.ForeColor = System.Drawing.Color.Gray
        Me.LbEtiquetaGenero.Location = New System.Drawing.Point(417, 440)
        Me.LbEtiquetaGenero.Name = "LbEtiquetaGenero"
        Me.LbEtiquetaGenero.Size = New System.Drawing.Size(86, 15)
        Me.LbEtiquetaGenero.TabIndex = 24
        Me.LbEtiquetaGenero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbidioma
        '
        Me.Lbidioma.BackColor = System.Drawing.Color.Transparent
        Me.Lbidioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbidioma.ForeColor = System.Drawing.Color.Gray
        Me.Lbidioma.Location = New System.Drawing.Point(547, 440)
        Me.Lbidioma.Name = "Lbidioma"
        Me.Lbidioma.Size = New System.Drawing.Size(86, 15)
        Me.Lbidioma.TabIndex = 25
        Me.Lbidioma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmGenero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ESTUDIO_LOS_NUMEROS.My.Resources.Resources.WhatsApp_Image_2022_01_15_at_4_21_09_PM
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(779, 464)
        Me.Controls.Add(Me.Lbidioma)
        Me.Controls.Add(Me.LbEtiquetaGenero)
        Me.Controls.Add(Me.lbcangurito)
        Me.Controls.Add(Me.lbJuego)
        Me.Controls.Add(Me.AxwpSaludos)
        Me.Controls.Add(Me.Lbfinal)
        Me.Controls.Add(Me.Lbiniciar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbGeneroNiña)
        Me.Controls.Add(Me.pbGeneroNiño)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGenero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GENERO"
        CType(Me.pbGeneroNiña, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGeneroNiño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxwpSaludos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbGeneroNiño As PictureBox
    Friend WithEvents pbGeneroNiña As PictureBox
    Friend WithEvents Lbfinal As Label
    Friend WithEvents Lbiniciar As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AxwpSaludos As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents lbJuego As Label
    Friend WithEvents lbcangurito As Label
    Friend WithEvents LbEtiquetaGenero As Label
    Friend WithEvents Lbidioma As Label
End Class
