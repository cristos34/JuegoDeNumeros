<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDictado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDictado))
        Me.BTNprobar = New System.Windows.Forms.Button()
        Me.txtnumeroSistema = New System.Windows.Forms.TextBox()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
        Me.AxmpNumero = New AxWMPLib.AxWindowsMediaPlayer()
        Me.pbSuspenso = New System.Windows.Forms.PictureBox()
        Me.pbperdiste = New System.Windows.Forms.PictureBox()
        Me.pbEsconderNumero = New System.Windows.Forms.PictureBox()
        Me.pbGanaste = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbiniciar = New System.Windows.Forms.Label()
        Me.Lbfinal = New System.Windows.Forms.Label()
        Me.Lbidioma = New System.Windows.Forms.Label()
        Me.Gbcronometro = New System.Windows.Forms.GroupBox()
        Me.Cbtiempo = New System.Windows.Forms.ComboBox()
        Me.lbsegundos = New System.Windows.Forms.Label()
        Me.TIEMPOdictado = New System.Windows.Forms.Timer(Me.components)
        Me.CHEBOXcronometro = New System.Windows.Forms.CheckBox()
        CType(Me.AxmpNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSuspenso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbperdiste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEsconderNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGanaste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbcronometro.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNprobar
        '
        Me.BTNprobar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNprobar.Location = New System.Drawing.Point(621, 207)
        Me.BTNprobar.Name = "BTNprobar"
        Me.BTNprobar.Size = New System.Drawing.Size(75, 23)
        Me.BTNprobar.TabIndex = 1
        Me.BTNprobar.Text = "PROBAR"
        Me.BTNprobar.UseVisualStyleBackColor = True
        '
        'txtnumeroSistema
        '
        Me.txtnumeroSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumeroSistema.Location = New System.Drawing.Point(36, 65)
        Me.txtnumeroSistema.Name = "txtnumeroSistema"
        Me.txtnumeroSistema.ReadOnly = True
        Me.txtnumeroSistema.Size = New System.Drawing.Size(222, 116)
        Me.txtnumeroSistema.TabIndex = 7
        Me.txtnumeroSistema.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRespuesta
        '
        Me.txtRespuesta.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRespuesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRespuesta.ForeColor = System.Drawing.Color.Red
        Me.txtRespuesta.Location = New System.Drawing.Point(537, 72)
        Me.txtRespuesta.MaxLength = 4
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(222, 116)
        Me.txtRespuesta.TabIndex = 0
        Me.txtRespuesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AxmpNumero
        '
        Me.AxmpNumero.Enabled = True
        Me.AxmpNumero.Location = New System.Drawing.Point(270, 236)
        Me.AxmpNumero.Name = "AxmpNumero"
        Me.AxmpNumero.OcxState = CType(resources.GetObject("AxmpNumero.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxmpNumero.Size = New System.Drawing.Size(282, 37)
        Me.AxmpNumero.TabIndex = 9
        Me.AxmpNumero.Visible = False
        '
        'pbSuspenso
        '
        Me.pbSuspenso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbSuspenso.Image = Global.ESTUDIO_LOS_NUMEROS.My.Resources.Resources.spongebob_bob_esponja
        Me.pbSuspenso.Location = New System.Drawing.Point(303, 49)
        Me.pbSuspenso.Name = "pbSuspenso"
        Me.pbSuspenso.Size = New System.Drawing.Size(200, 181)
        Me.pbSuspenso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSuspenso.TabIndex = 10
        Me.pbSuspenso.TabStop = False
        '
        'pbperdiste
        '
        Me.pbperdiste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbperdiste.Image = Global.ESTUDIO_LOS_NUMEROS.My.Resources.Resources.emoji_smiley
        Me.pbperdiste.Location = New System.Drawing.Point(303, 49)
        Me.pbperdiste.Name = "pbperdiste"
        Me.pbperdiste.Size = New System.Drawing.Size(200, 181)
        Me.pbperdiste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbperdiste.TabIndex = 1
        Me.pbperdiste.TabStop = False
        Me.pbperdiste.Visible = False
        '
        'pbEsconderNumero
        '
        Me.pbEsconderNumero.BackColor = System.Drawing.Color.Transparent
        Me.pbEsconderNumero.Image = Global.ESTUDIO_LOS_NUMEROS.My.Resources.Resources.Esconder
        Me.pbEsconderNumero.Location = New System.Drawing.Point(36, 58)
        Me.pbEsconderNumero.Name = "pbEsconderNumero"
        Me.pbEsconderNumero.Size = New System.Drawing.Size(222, 159)
        Me.pbEsconderNumero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEsconderNumero.TabIndex = 4
        Me.pbEsconderNumero.TabStop = False
        '
        'pbGanaste
        '
        Me.pbGanaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbGanaste.Image = Global.ESTUDIO_LOS_NUMEROS.My.Resources.Resources.tenor
        Me.pbGanaste.Location = New System.Drawing.Point(303, 49)
        Me.pbGanaste.Name = "pbGanaste"
        Me.pbGanaste.Size = New System.Drawing.Size(200, 181)
        Me.pbGanaste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbGanaste.TabIndex = 3
        Me.pbGanaste.TabStop = False
        Me.pbGanaste.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(230, 317)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Este juego inicia del : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(435, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "al"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbiniciar
        '
        Me.Lbiniciar.BackColor = System.Drawing.Color.Transparent
        Me.Lbiniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbiniciar.ForeColor = System.Drawing.Color.Gray
        Me.Lbiniciar.Location = New System.Drawing.Point(386, 317)
        Me.Lbiniciar.Name = "Lbiniciar"
        Me.Lbiniciar.Size = New System.Drawing.Size(43, 15)
        Me.Lbiniciar.TabIndex = 14
        Me.Lbiniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbfinal
        '
        Me.Lbfinal.BackColor = System.Drawing.Color.Transparent
        Me.Lbfinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbfinal.ForeColor = System.Drawing.Color.Gray
        Me.Lbfinal.Location = New System.Drawing.Point(460, 317)
        Me.Lbfinal.Name = "Lbfinal"
        Me.Lbfinal.Size = New System.Drawing.Size(43, 15)
        Me.Lbfinal.TabIndex = 16
        Me.Lbfinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbidioma
        '
        Me.Lbidioma.BackColor = System.Drawing.Color.Transparent
        Me.Lbidioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbidioma.ForeColor = System.Drawing.Color.Gray
        Me.Lbidioma.Location = New System.Drawing.Point(509, 317)
        Me.Lbidioma.Name = "Lbidioma"
        Me.Lbidioma.Size = New System.Drawing.Size(86, 15)
        Me.Lbidioma.TabIndex = 26
        Me.Lbidioma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Gbcronometro
        '
        Me.Gbcronometro.BackColor = System.Drawing.Color.Transparent
        Me.Gbcronometro.Controls.Add(Me.Cbtiempo)
        Me.Gbcronometro.Controls.Add(Me.lbsegundos)
        Me.Gbcronometro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbcronometro.ForeColor = System.Drawing.Color.Lime
        Me.Gbcronometro.Location = New System.Drawing.Point(622, 9)
        Me.Gbcronometro.Name = "Gbcronometro"
        Me.Gbcronometro.Size = New System.Drawing.Size(135, 57)
        Me.Gbcronometro.TabIndex = 27
        Me.Gbcronometro.TabStop = False
        Me.Gbcronometro.Text = "TIME"
        Me.Gbcronometro.Visible = False
        '
        'Cbtiempo
        '
        Me.Cbtiempo.BackColor = System.Drawing.Color.Gray
        Me.Cbtiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbtiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbtiempo.ForeColor = System.Drawing.Color.Lime
        Me.Cbtiempo.FormattingEnabled = True
        Me.Cbtiempo.Location = New System.Drawing.Point(70, 17)
        Me.Cbtiempo.MaxLength = 2
        Me.Cbtiempo.Name = "Cbtiempo"
        Me.Cbtiempo.Size = New System.Drawing.Size(49, 32)
        Me.Cbtiempo.TabIndex = 28
        '
        'lbsegundos
        '
        Me.lbsegundos.BackColor = System.Drawing.Color.Transparent
        Me.lbsegundos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbsegundos.ForeColor = System.Drawing.Color.Lime
        Me.lbsegundos.Location = New System.Drawing.Point(6, 17)
        Me.lbsegundos.Name = "lbsegundos"
        Me.lbsegundos.Size = New System.Drawing.Size(44, 27)
        Me.lbsegundos.TabIndex = 32
        Me.lbsegundos.Text = "00"
        Me.lbsegundos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TIEMPOdictado
        '
        Me.TIEMPOdictado.Interval = 1000
        '
        'CHEBOXcronometro
        '
        Me.CHEBOXcronometro.AutoSize = True
        Me.CHEBOXcronometro.BackColor = System.Drawing.Color.Transparent
        Me.CHEBOXcronometro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHEBOXcronometro.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.CHEBOXcronometro.Location = New System.Drawing.Point(604, 316)
        Me.CHEBOXcronometro.Name = "CHEBOXcronometro"
        Me.CHEBOXcronometro.Size = New System.Drawing.Size(135, 20)
        Me.CHEBOXcronometro.TabIndex = 28
        Me.CHEBOXcronometro.Text = "CRONOMETRO"
        Me.CHEBOXcronometro.UseVisualStyleBackColor = False
        '
        'FrmDictado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.ESTUDIO_LOS_NUMEROS.My.Resources.Resources.fondoFrmRepasar
        Me.ClientSize = New System.Drawing.Size(800, 355)
        Me.Controls.Add(Me.CHEBOXcronometro)
        Me.Controls.Add(Me.Gbcronometro)
        Me.Controls.Add(Me.Lbidioma)
        Me.Controls.Add(Me.pbGanaste)
        Me.Controls.Add(Me.pbperdiste)
        Me.Controls.Add(Me.Lbfinal)
        Me.Controls.Add(Me.Lbiniciar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbEsconderNumero)
        Me.Controls.Add(Me.AxmpNumero)
        Me.Controls.Add(Me.txtRespuesta)
        Me.Controls.Add(Me.txtnumeroSistema)
        Me.Controls.Add(Me.BTNprobar)
        Me.Controls.Add(Me.pbSuspenso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDictado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DICTADO"
        CType(Me.AxmpNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSuspenso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbperdiste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEsconderNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGanaste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbcronometro.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbperdiste As PictureBox
    Friend WithEvents pbGanaste As PictureBox
    Friend WithEvents pbEsconderNumero As PictureBox
    Friend WithEvents BTNprobar As Button
    Friend WithEvents txtnumeroSistema As TextBox
    Friend WithEvents txtRespuesta As TextBox
    Friend WithEvents AxmpNumero As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents pbSuspenso As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Lbiniciar As Label
    Friend WithEvents Lbfinal As Label
    Friend WithEvents Lbidioma As Label
    Friend WithEvents Gbcronometro As GroupBox
    Friend WithEvents lbsegundos As Label
    Friend WithEvents TIEMPOdictado As Timer
    Friend WithEvents Cbtiempo As ComboBox
    Friend WithEvents CHEBOXcronometro As CheckBox
End Class
