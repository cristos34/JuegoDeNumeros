<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCangurito
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCangurito))
        Me.pbGanaste = New System.Windows.Forms.PictureBox()
        Me.pbperdiste = New System.Windows.Forms.PictureBox()
        Me.pbEsconderNumero = New System.Windows.Forms.PictureBox()
        Me.AxmpNumero = New AxWMPLib.AxWindowsMediaPlayer()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
        Me.txtnumeroSistema = New System.Windows.Forms.TextBox()
        Me.BTNprobar = New System.Windows.Forms.Button()
        Me.pbSuspenso = New System.Windows.Forms.PictureBox()
        Me.TimerCangurito = New System.Windows.Forms.Timer(Me.components)
        Me.Lbfinal = New System.Windows.Forms.Label()
        Me.Lbiniciar = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtintervalo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbidioma = New System.Windows.Forms.Label()
        CType(Me.pbGanaste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbperdiste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEsconderNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxmpNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSuspenso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbGanaste
        '
        Me.pbGanaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbGanaste.Image = Global.ESTUDIO_LOS_NUMEROS.My.Resources.Resources.tenor
        Me.pbGanaste.Location = New System.Drawing.Point(300, 36)
        Me.pbGanaste.Name = "pbGanaste"
        Me.pbGanaste.Size = New System.Drawing.Size(200, 181)
        Me.pbGanaste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbGanaste.TabIndex = 14
        Me.pbGanaste.TabStop = False
        Me.pbGanaste.Visible = False
        '
        'pbperdiste
        '
        Me.pbperdiste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbperdiste.Image = Global.ESTUDIO_LOS_NUMEROS.My.Resources.Resources.emoji_smiley
        Me.pbperdiste.Location = New System.Drawing.Point(300, 36)
        Me.pbperdiste.Name = "pbperdiste"
        Me.pbperdiste.Size = New System.Drawing.Size(200, 181)
        Me.pbperdiste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbperdiste.TabIndex = 12
        Me.pbperdiste.TabStop = False
        Me.pbperdiste.Visible = False
        '
        'pbEsconderNumero
        '
        Me.pbEsconderNumero.BackColor = System.Drawing.Color.Transparent
        Me.pbEsconderNumero.Image = Global.ESTUDIO_LOS_NUMEROS.My.Resources.Resources.Esconder
        Me.pbEsconderNumero.Location = New System.Drawing.Point(46, 52)
        Me.pbEsconderNumero.Name = "pbEsconderNumero"
        Me.pbEsconderNumero.Size = New System.Drawing.Size(222, 159)
        Me.pbEsconderNumero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEsconderNumero.TabIndex = 15
        Me.pbEsconderNumero.TabStop = False
        '
        'AxmpNumero
        '
        Me.AxmpNumero.Enabled = True
        Me.AxmpNumero.Location = New System.Drawing.Point(273, 232)
        Me.AxmpNumero.Name = "AxmpNumero"
        Me.AxmpNumero.OcxState = CType(resources.GetObject("AxmpNumero.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxmpNumero.Size = New System.Drawing.Size(282, 37)
        Me.AxmpNumero.TabIndex = 17
        Me.AxmpNumero.Visible = False
        '
        'txtRespuesta
        '
        Me.txtRespuesta.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRespuesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRespuesta.ForeColor = System.Drawing.Color.Red
        Me.txtRespuesta.Location = New System.Drawing.Point(540, 78)
        Me.txtRespuesta.MaxLength = 4
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(222, 116)
        Me.txtRespuesta.TabIndex = 11
        Me.txtRespuesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnumeroSistema
        '
        Me.txtnumeroSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumeroSistema.Location = New System.Drawing.Point(46, 78)
        Me.txtnumeroSistema.Name = "txtnumeroSistema"
        Me.txtnumeroSistema.ReadOnly = True
        Me.txtnumeroSistema.Size = New System.Drawing.Size(222, 116)
        Me.txtnumeroSistema.TabIndex = 16
        Me.txtnumeroSistema.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTNprobar
        '
        Me.BTNprobar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNprobar.Location = New System.Drawing.Point(624, 203)
        Me.BTNprobar.Name = "BTNprobar"
        Me.BTNprobar.Size = New System.Drawing.Size(75, 23)
        Me.BTNprobar.TabIndex = 13
        Me.BTNprobar.Text = "PROBAR"
        Me.BTNprobar.UseVisualStyleBackColor = True
        '
        'pbSuspenso
        '
        Me.pbSuspenso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbSuspenso.Image = Global.ESTUDIO_LOS_NUMEROS.My.Resources.Resources.spongebob_bob_esponja
        Me.pbSuspenso.Location = New System.Drawing.Point(331, 61)
        Me.pbSuspenso.Name = "pbSuspenso"
        Me.pbSuspenso.Size = New System.Drawing.Size(158, 150)
        Me.pbSuspenso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSuspenso.TabIndex = 18
        Me.pbSuspenso.TabStop = False
        '
        'TimerCangurito
        '
        Me.TimerCangurito.Interval = 4000
        '
        'Lbfinal
        '
        Me.Lbfinal.BackColor = System.Drawing.Color.Transparent
        Me.Lbfinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbfinal.ForeColor = System.Drawing.Color.Gray
        Me.Lbfinal.Location = New System.Drawing.Point(371, 285)
        Me.Lbfinal.Name = "Lbfinal"
        Me.Lbfinal.Size = New System.Drawing.Size(43, 15)
        Me.Lbfinal.TabIndex = 29
        Me.Lbfinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbiniciar
        '
        Me.Lbiniciar.BackColor = System.Drawing.Color.Transparent
        Me.Lbiniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbiniciar.ForeColor = System.Drawing.Color.Gray
        Me.Lbiniciar.Location = New System.Drawing.Point(297, 285)
        Me.Lbiniciar.Name = "Lbiniciar"
        Me.Lbiniciar.Size = New System.Drawing.Size(43, 15)
        Me.Lbiniciar.TabIndex = 28
        Me.Lbiniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(346, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "al"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(141, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 15)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Este juego inicia del : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtintervalo
        '
        Me.txtintervalo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtintervalo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtintervalo.Enabled = False
        Me.txtintervalo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtintervalo.ForeColor = System.Drawing.Color.Gray
        Me.txtintervalo.Location = New System.Drawing.Point(492, 287)
        Me.txtintervalo.Name = "txtintervalo"
        Me.txtintervalo.Size = New System.Drawing.Size(37, 13)
        Me.txtintervalo.TabIndex = 30
        Me.txtintervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(420, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Cangurito"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbidioma
        '
        Me.Lbidioma.BackColor = System.Drawing.Color.Transparent
        Me.Lbidioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbidioma.ForeColor = System.Drawing.Color.Gray
        Me.Lbidioma.Location = New System.Drawing.Point(537, 286)
        Me.Lbidioma.Name = "Lbidioma"
        Me.Lbidioma.Size = New System.Drawing.Size(86, 15)
        Me.Lbidioma.TabIndex = 32
        Me.Lbidioma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmCangurito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ESTUDIO_LOS_NUMEROS.My.Resources.Resources.fondoFrmRepasar
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 387)
        Me.Controls.Add(Me.Lbidioma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtintervalo)
        Me.Controls.Add(Me.Lbfinal)
        Me.Controls.Add(Me.Lbiniciar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbGanaste)
        Me.Controls.Add(Me.pbperdiste)
        Me.Controls.Add(Me.pbEsconderNumero)
        Me.Controls.Add(Me.AxmpNumero)
        Me.Controls.Add(Me.txtRespuesta)
        Me.Controls.Add(Me.txtnumeroSistema)
        Me.Controls.Add(Me.BTNprobar)
        Me.Controls.Add(Me.pbSuspenso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCangurito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CANGURITOS"
        CType(Me.pbGanaste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbperdiste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEsconderNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxmpNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSuspenso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbGanaste As PictureBox
    Friend WithEvents pbperdiste As PictureBox
    Friend WithEvents pbEsconderNumero As PictureBox
    Friend WithEvents AxmpNumero As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents txtRespuesta As TextBox
    Friend WithEvents txtnumeroSistema As TextBox
    Friend WithEvents BTNprobar As Button
    Friend WithEvents pbSuspenso As PictureBox
    Friend WithEvents TimerCangurito As Timer
    Friend WithEvents Lbfinal As Label
    Friend WithEvents Lbiniciar As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtintervalo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Lbidioma As Label
End Class
