﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMsuma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMsuma))
        Me.GBSUMA = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnComprobar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnJugar = New System.Windows.Forms.Button()
        Me.txtLlevaDos = New System.Windows.Forms.TextBox()
        Me.LBSegundaCifraPrimer = New System.Windows.Forms.Label()
        Me.LBPrimeracifraPrimerNumero = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBSegundaCifraSegundo = New System.Windows.Forms.Label()
        Me.LBPrimeracifraSegundoNumero = New System.Windows.Forms.Label()
        Me.txtRespuestaUno = New System.Windows.Forms.TextBox()
        Me.txtRespuestaDos = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AxmpNumero = New AxWMPLib.AxWindowsMediaPlayer()
        Me.GPimagens = New System.Windows.Forms.GroupBox()
        Me.PBfelizPQgane = New System.Windows.Forms.PictureBox()
        Me.PblloroPQperdi = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbResultado = New System.Windows.Forms.Label()
        Me.lbRespuestaSifraDos = New System.Windows.Forms.Label()
        Me.lbRespuestaSifraUno = New System.Windows.Forms.Label()
        Me.GBSUMA.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AxmpNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPimagens.SuspendLayout()
        CType(Me.PBfelizPQgane, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PblloroPQperdi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBSUMA
        '
        Me.GBSUMA.BackColor = System.Drawing.Color.Transparent
        Me.GBSUMA.Controls.Add(Me.GroupBox1)
        Me.GBSUMA.Controls.Add(Me.txtLlevaDos)
        Me.GBSUMA.Controls.Add(Me.LBSegundaCifraPrimer)
        Me.GBSUMA.Controls.Add(Me.LBPrimeracifraPrimerNumero)
        Me.GBSUMA.Controls.Add(Me.Label5)
        Me.GBSUMA.Controls.Add(Me.LBSegundaCifraSegundo)
        Me.GBSUMA.Controls.Add(Me.LBPrimeracifraSegundoNumero)
        Me.GBSUMA.Controls.Add(Me.txtRespuestaUno)
        Me.GBSUMA.Controls.Add(Me.txtRespuestaDos)
        Me.GBSUMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBSUMA.ForeColor = System.Drawing.Color.Silver
        Me.GBSUMA.Location = New System.Drawing.Point(11, 9)
        Me.GBSUMA.Name = "GBSUMA"
        Me.GBSUMA.Size = New System.Drawing.Size(380, 502)
        Me.GBSUMA.TabIndex = 1
        Me.GBSUMA.TabStop = False
        Me.GBSUMA.Text = "SUMA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnComprobar)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnJugar)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 436)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 47)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'BtnComprobar
        '
        Me.BtnComprobar.ForeColor = System.Drawing.Color.Black
        Me.BtnComprobar.Location = New System.Drawing.Point(239, 16)
        Me.BtnComprobar.Name = "BtnComprobar"
        Me.BtnComprobar.Size = New System.Drawing.Size(75, 23)
        Me.BtnComprobar.TabIndex = 0
        Me.BtnComprobar.Text = "PROBAR"
        Me.BtnComprobar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpiar.Location = New System.Drawing.Point(137, 16)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnJugar
        '
        Me.btnJugar.Enabled = False
        Me.btnJugar.ForeColor = System.Drawing.Color.Black
        Me.btnJugar.Location = New System.Drawing.Point(34, 16)
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.Size = New System.Drawing.Size(75, 23)
        Me.btnJugar.TabIndex = 2
        Me.btnJugar.Text = "JUGAR"
        Me.btnJugar.UseVisualStyleBackColor = True
        '
        'txtLlevaDos
        '
        Me.txtLlevaDos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLlevaDos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLlevaDos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLlevaDos.ForeColor = System.Drawing.Color.Yellow
        Me.txtLlevaDos.Location = New System.Drawing.Point(189, 37)
        Me.txtLlevaDos.MaxLength = 1
        Me.txtLlevaDos.Name = "txtLlevaDos"
        Me.txtLlevaDos.Size = New System.Drawing.Size(40, 17)
        Me.txtLlevaDos.TabIndex = 11
        Me.txtLlevaDos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBSegundaCifraPrimer
        '
        Me.LBSegundaCifraPrimer.BackColor = System.Drawing.Color.Transparent
        Me.LBSegundaCifraPrimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBSegundaCifraPrimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 80.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBSegundaCifraPrimer.ForeColor = System.Drawing.Color.Yellow
        Me.LBSegundaCifraPrimer.Location = New System.Drawing.Point(255, 188)
        Me.LBSegundaCifraPrimer.Name = "LBSegundaCifraPrimer"
        Me.LBSegundaCifraPrimer.Size = New System.Drawing.Size(91, 116)
        Me.LBSegundaCifraPrimer.TabIndex = 6
        Me.LBSegundaCifraPrimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBPrimeracifraPrimerNumero
        '
        Me.LBPrimeracifraPrimerNumero.BackColor = System.Drawing.Color.Transparent
        Me.LBPrimeracifraPrimerNumero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBPrimeracifraPrimerNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 80.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBPrimeracifraPrimerNumero.ForeColor = System.Drawing.Color.Yellow
        Me.LBPrimeracifraPrimerNumero.Location = New System.Drawing.Point(255, 67)
        Me.LBPrimeracifraPrimerNumero.Name = "LBPrimeracifraPrimerNumero"
        Me.LBPrimeracifraPrimerNumero.Size = New System.Drawing.Size(91, 116)
        Me.LBPrimeracifraPrimerNumero.TabIndex = 4
        Me.LBPrimeracifraPrimerNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(62, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 77)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "+"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBSegundaCifraSegundo
        '
        Me.LBSegundaCifraSegundo.BackColor = System.Drawing.Color.Transparent
        Me.LBSegundaCifraSegundo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBSegundaCifraSegundo.Font = New System.Drawing.Font("Microsoft Sans Serif", 80.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBSegundaCifraSegundo.ForeColor = System.Drawing.Color.Yellow
        Me.LBSegundaCifraSegundo.Location = New System.Drawing.Point(160, 188)
        Me.LBSegundaCifraSegundo.Name = "LBSegundaCifraSegundo"
        Me.LBSegundaCifraSegundo.Size = New System.Drawing.Size(91, 116)
        Me.LBSegundaCifraSegundo.TabIndex = 7
        Me.LBSegundaCifraSegundo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBPrimeracifraSegundoNumero
        '
        Me.LBPrimeracifraSegundoNumero.BackColor = System.Drawing.Color.Transparent
        Me.LBPrimeracifraSegundoNumero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBPrimeracifraSegundoNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 80.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBPrimeracifraSegundoNumero.ForeColor = System.Drawing.Color.Yellow
        Me.LBPrimeracifraSegundoNumero.Location = New System.Drawing.Point(160, 67)
        Me.LBPrimeracifraSegundoNumero.Name = "LBPrimeracifraSegundoNumero"
        Me.LBPrimeracifraSegundoNumero.Size = New System.Drawing.Size(91, 116)
        Me.LBPrimeracifraSegundoNumero.TabIndex = 5
        Me.LBPrimeracifraSegundoNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRespuestaUno
        '
        Me.txtRespuestaUno.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRespuestaUno.ForeColor = System.Drawing.Color.Red
        Me.txtRespuestaUno.Location = New System.Drawing.Point(254, 311)
        Me.txtRespuestaUno.MaxLength = 1
        Me.txtRespuestaUno.Name = "txtRespuestaUno"
        Me.txtRespuestaUno.Size = New System.Drawing.Size(92, 116)
        Me.txtRespuestaUno.TabIndex = 0
        Me.txtRespuestaUno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRespuestaDos
        '
        Me.txtRespuestaDos.Enabled = False
        Me.txtRespuestaDos.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRespuestaDos.ForeColor = System.Drawing.Color.Red
        Me.txtRespuestaDos.Location = New System.Drawing.Point(110, 311)
        Me.txtRespuestaDos.MaxLength = 2
        Me.txtRespuestaDos.Name = "txtRespuestaDos"
        Me.txtRespuestaDos.Size = New System.Drawing.Size(141, 116)
        Me.txtRespuestaDos.TabIndex = 1
        Me.txtRespuestaDos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.AxmpNumero)
        Me.GroupBox2.Controls.Add(Me.GPimagens)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.LbResultado)
        Me.GroupBox2.Controls.Add(Me.lbRespuestaSifraDos)
        Me.GroupBox2.Controls.Add(Me.lbRespuestaSifraUno)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox2.Location = New System.Drawing.Point(403, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(254, 504)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RESPUESTA"
        '
        'AxmpNumero
        '
        Me.AxmpNumero.Enabled = True
        Me.AxmpNumero.Location = New System.Drawing.Point(26, 20)
        Me.AxmpNumero.Name = "AxmpNumero"
        Me.AxmpNumero.OcxState = CType(resources.GetObject("AxmpNumero.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxmpNumero.Size = New System.Drawing.Size(203, 23)
        Me.AxmpNumero.TabIndex = 19
        Me.AxmpNumero.Visible = False
        '
        'GPimagens
        '
        Me.GPimagens.BackColor = System.Drawing.Color.Transparent
        Me.GPimagens.Controls.Add(Me.PBfelizPQgane)
        Me.GPimagens.Controls.Add(Me.PblloroPQperdi)
        Me.GPimagens.Location = New System.Drawing.Point(29, 324)
        Me.GPimagens.Name = "GPimagens"
        Me.GPimagens.Size = New System.Drawing.Size(200, 160)
        Me.GPimagens.TabIndex = 18
        Me.GPimagens.TabStop = False
        Me.GPimagens.Visible = False
        '
        'PBfelizPQgane
        '
        Me.PBfelizPQgane.Image = Global.ESTUDIO_LOS_NUMEROS.My.Resources.Resources.tenor
        Me.PBfelizPQgane.Location = New System.Drawing.Point(1, 8)
        Me.PBfelizPQgane.Name = "PBfelizPQgane"
        Me.PBfelizPQgane.Size = New System.Drawing.Size(198, 151)
        Me.PBfelizPQgane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBfelizPQgane.TabIndex = 18
        Me.PBfelizPQgane.TabStop = False
        '
        'PblloroPQperdi
        '
        Me.PblloroPQperdi.Image = Global.ESTUDIO_LOS_NUMEROS.My.Resources.Resources.crying_homer_sad
        Me.PblloroPQperdi.Location = New System.Drawing.Point(1, 8)
        Me.PblloroPQperdi.Name = "PblloroPQperdi"
        Me.PblloroPQperdi.Size = New System.Drawing.Size(198, 151)
        Me.PblloroPQperdi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PblloroPQperdi.TabIndex = 19
        Me.PblloroPQperdi.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(11, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 76)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "+"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LbResultado
        '
        Me.LbResultado.BackColor = System.Drawing.Color.Transparent
        Me.LbResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LbResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbResultado.ForeColor = System.Drawing.Color.Yellow
        Me.LbResultado.Location = New System.Drawing.Point(16, 226)
        Me.LbResultado.Name = "LbResultado"
        Me.LbResultado.Size = New System.Drawing.Size(224, 87)
        Me.LbResultado.TabIndex = 17
        Me.LbResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRespuestaSifraDos
        '
        Me.lbRespuestaSifraDos.BackColor = System.Drawing.Color.Transparent
        Me.lbRespuestaSifraDos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbRespuestaSifraDos.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRespuestaSifraDos.ForeColor = System.Drawing.Color.Yellow
        Me.lbRespuestaSifraDos.Location = New System.Drawing.Point(16, 127)
        Me.lbRespuestaSifraDos.Name = "lbRespuestaSifraDos"
        Me.lbRespuestaSifraDos.Size = New System.Drawing.Size(224, 87)
        Me.lbRespuestaSifraDos.TabIndex = 16
        Me.lbRespuestaSifraDos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbRespuestaSifraUno
        '
        Me.lbRespuestaSifraUno.BackColor = System.Drawing.Color.Transparent
        Me.lbRespuestaSifraUno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbRespuestaSifraUno.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRespuestaSifraUno.ForeColor = System.Drawing.Color.Yellow
        Me.lbRespuestaSifraUno.Location = New System.Drawing.Point(16, 34)
        Me.lbRespuestaSifraUno.Name = "lbRespuestaSifraUno"
        Me.lbRespuestaSifraUno.Size = New System.Drawing.Size(224, 87)
        Me.lbRespuestaSifraUno.TabIndex = 15
        Me.lbRespuestaSifraUno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRMsuma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(399, 526)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GBSUMA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMsuma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUMA DE 2 CIFRAS"
        Me.GBSUMA.ResumeLayout(False)
        Me.GBSUMA.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.AxmpNumero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPimagens.ResumeLayout(False)
        CType(Me.PBfelizPQgane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PblloroPQperdi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBSUMA As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnComprobar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnJugar As Button
    Friend WithEvents txtLlevaDos As TextBox
    Friend WithEvents LBSegundaCifraPrimer As Label
    Friend WithEvents LBPrimeracifraPrimerNumero As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LBSegundaCifraSegundo As Label
    Friend WithEvents LBPrimeracifraSegundoNumero As Label
    Friend WithEvents txtRespuestaUno As TextBox
    Friend WithEvents txtRespuestaDos As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LbResultado As Label
    Friend WithEvents lbRespuestaSifraDos As Label
    Friend WithEvents lbRespuestaSifraUno As Label
    Friend WithEvents GPimagens As GroupBox
    Friend WithEvents PBfelizPQgane As PictureBox
    Friend WithEvents PblloroPQperdi As PictureBox
    Friend WithEvents AxmpNumero As AxWMPLib.AxWindowsMediaPlayer
End Class
