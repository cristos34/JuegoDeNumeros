<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRestaTresCifras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRestaTresCifras))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GPimagens = New System.Windows.Forms.GroupBox()
        Me.PBfelizPQgane = New System.Windows.Forms.PictureBox()
        Me.PblloroPQperdi = New System.Windows.Forms.PictureBox()
        Me.AxmpNumero = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbResultado = New System.Windows.Forms.Label()
        Me.lbRespuestaSifraDos = New System.Windows.Forms.Label()
        Me.lbRespuestaSifraUno = New System.Windows.Forms.Label()
        Me.GBRESTA = New System.Windows.Forms.GroupBox()
        Me.LBSegundaCifraPrimerNumero = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnComprobar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnJugar = New System.Windows.Forms.Button()
        Me.txtLlevaTres = New System.Windows.Forms.TextBox()
        Me.LBPrimeracifraPrimerNumero = New System.Windows.Forms.Label()
        Me.txtLlevaDos = New System.Windows.Forms.TextBox()
        Me.LBSegundaCifraSegundoNumero = New System.Windows.Forms.Label()
        Me.LBPrimeracifraSegundoNumero = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBSegundaCifraTercerNumero = New System.Windows.Forms.Label()
        Me.LBPrimeracifraTercerNumero = New System.Windows.Forms.Label()
        Me.txtRespuestaUno = New System.Windows.Forms.TextBox()
        Me.txtRespuestaDos = New System.Windows.Forms.TextBox()
        Me.txtRespuestaTres = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GPimagens.SuspendLayout()
        CType(Me.PBfelizPQgane, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PblloroPQperdi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxmpNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBRESTA.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.GPimagens)
        Me.GroupBox2.Controls.Add(Me.AxmpNumero)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.LbResultado)
        Me.GroupBox2.Controls.Add(Me.lbRespuestaSifraDos)
        Me.GroupBox2.Controls.Add(Me.lbRespuestaSifraUno)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox2.Location = New System.Drawing.Point(399, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(290, 504)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RESPUESTA"
        '
        'GPimagens
        '
        Me.GPimagens.BackColor = System.Drawing.Color.Transparent
        Me.GPimagens.Controls.Add(Me.PBfelizPQgane)
        Me.GPimagens.Controls.Add(Me.PblloroPQperdi)
        Me.GPimagens.Location = New System.Drawing.Point(44, 315)
        Me.GPimagens.Name = "GPimagens"
        Me.GPimagens.Size = New System.Drawing.Size(200, 160)
        Me.GPimagens.TabIndex = 21
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
        'AxmpNumero
        '
        Me.AxmpNumero.Enabled = True
        Me.AxmpNumero.Location = New System.Drawing.Point(42, 473)
        Me.AxmpNumero.Name = "AxmpNumero"
        Me.AxmpNumero.OcxState = CType(resources.GetObject("AxmpNumero.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxmpNumero.Size = New System.Drawing.Size(203, 23)
        Me.AxmpNumero.TabIndex = 20
        Me.AxmpNumero.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(11, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 73)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "-"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbResultado
        '
        Me.LbResultado.BackColor = System.Drawing.Color.Transparent
        Me.LbResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LbResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbResultado.ForeColor = System.Drawing.Color.Yellow
        Me.LbResultado.Location = New System.Drawing.Point(16, 226)
        Me.LbResultado.Name = "LbResultado"
        Me.LbResultado.Size = New System.Drawing.Size(258, 87)
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
        Me.lbRespuestaSifraDos.Size = New System.Drawing.Size(258, 87)
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
        Me.lbRespuestaSifraUno.Size = New System.Drawing.Size(258, 87)
        Me.lbRespuestaSifraUno.TabIndex = 15
        Me.lbRespuestaSifraUno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GBRESTA
        '
        Me.GBRESTA.BackColor = System.Drawing.Color.Transparent
        Me.GBRESTA.Controls.Add(Me.LBSegundaCifraPrimerNumero)
        Me.GBRESTA.Controls.Add(Me.GroupBox1)
        Me.GBRESTA.Controls.Add(Me.txtLlevaTres)
        Me.GBRESTA.Controls.Add(Me.LBPrimeracifraPrimerNumero)
        Me.GBRESTA.Controls.Add(Me.txtLlevaDos)
        Me.GBRESTA.Controls.Add(Me.LBSegundaCifraSegundoNumero)
        Me.GBRESTA.Controls.Add(Me.LBPrimeracifraSegundoNumero)
        Me.GBRESTA.Controls.Add(Me.Label5)
        Me.GBRESTA.Controls.Add(Me.LBSegundaCifraTercerNumero)
        Me.GBRESTA.Controls.Add(Me.LBPrimeracifraTercerNumero)
        Me.GBRESTA.Controls.Add(Me.txtRespuestaUno)
        Me.GBRESTA.Controls.Add(Me.txtRespuestaDos)
        Me.GBRESTA.Controls.Add(Me.txtRespuestaTres)
        Me.GBRESTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBRESTA.ForeColor = System.Drawing.Color.Silver
        Me.GBRESTA.Location = New System.Drawing.Point(8, 9)
        Me.GBRESTA.Name = "GBRESTA"
        Me.GBRESTA.Size = New System.Drawing.Size(380, 502)
        Me.GBRESTA.TabIndex = 18
        Me.GBRESTA.TabStop = False
        Me.GBRESTA.Text = "RESTA"
        '
        'LBSegundaCifraPrimerNumero
        '
        Me.LBSegundaCifraPrimerNumero.BackColor = System.Drawing.Color.Transparent
        Me.LBSegundaCifraPrimerNumero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBSegundaCifraPrimerNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBSegundaCifraPrimerNumero.ForeColor = System.Drawing.Color.Yellow
        Me.LBSegundaCifraPrimerNumero.Location = New System.Drawing.Point(265, 189)
        Me.LBSegundaCifraPrimerNumero.Name = "LBSegundaCifraPrimerNumero"
        Me.LBSegundaCifraPrimerNumero.Size = New System.Drawing.Size(70, 116)
        Me.LBSegundaCifraPrimerNumero.TabIndex = 13
        Me.LBSegundaCifraPrimerNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnComprobar)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnJugar)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 436)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 47)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'BtnComprobar
        '
        Me.BtnComprobar.ForeColor = System.Drawing.Color.Black
        Me.BtnComprobar.Location = New System.Drawing.Point(244, 16)
        Me.BtnComprobar.Name = "BtnComprobar"
        Me.BtnComprobar.Size = New System.Drawing.Size(75, 23)
        Me.BtnComprobar.TabIndex = 0
        Me.BtnComprobar.Text = "PROBAR"
        Me.BtnComprobar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpiar.Location = New System.Drawing.Point(142, 16)
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
        Me.btnJugar.Location = New System.Drawing.Point(39, 16)
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.Size = New System.Drawing.Size(75, 23)
        Me.btnJugar.TabIndex = 2
        Me.btnJugar.Text = "JUGAR"
        Me.btnJugar.UseVisualStyleBackColor = True
        '
        'txtLlevaTres
        '
        Me.txtLlevaTres.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLlevaTres.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLlevaTres.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLlevaTres.ForeColor = System.Drawing.Color.Yellow
        Me.txtLlevaTres.Location = New System.Drawing.Point(114, 37)
        Me.txtLlevaTres.MaxLength = 1
        Me.txtLlevaTres.Name = "txtLlevaTres"
        Me.txtLlevaTres.Size = New System.Drawing.Size(30, 17)
        Me.txtLlevaTres.TabIndex = 10
        Me.txtLlevaTres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBPrimeracifraPrimerNumero
        '
        Me.LBPrimeracifraPrimerNumero.BackColor = System.Drawing.Color.Transparent
        Me.LBPrimeracifraPrimerNumero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBPrimeracifraPrimerNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBPrimeracifraPrimerNumero.ForeColor = System.Drawing.Color.Yellow
        Me.LBPrimeracifraPrimerNumero.Location = New System.Drawing.Point(265, 68)
        Me.LBPrimeracifraPrimerNumero.Name = "LBPrimeracifraPrimerNumero"
        Me.LBPrimeracifraPrimerNumero.Size = New System.Drawing.Size(70, 116)
        Me.LBPrimeracifraPrimerNumero.TabIndex = 12
        Me.LBPrimeracifraPrimerNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLlevaDos
        '
        Me.txtLlevaDos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLlevaDos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLlevaDos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLlevaDos.ForeColor = System.Drawing.Color.Yellow
        Me.txtLlevaDos.Location = New System.Drawing.Point(205, 37)
        Me.txtLlevaDos.MaxLength = 1
        Me.txtLlevaDos.Name = "txtLlevaDos"
        Me.txtLlevaDos.Size = New System.Drawing.Size(30, 17)
        Me.txtLlevaDos.TabIndex = 11
        Me.txtLlevaDos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBSegundaCifraSegundoNumero
        '
        Me.LBSegundaCifraSegundoNumero.BackColor = System.Drawing.Color.Transparent
        Me.LBSegundaCifraSegundoNumero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBSegundaCifraSegundoNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBSegundaCifraSegundoNumero.ForeColor = System.Drawing.Color.Yellow
        Me.LBSegundaCifraSegundoNumero.Location = New System.Drawing.Point(187, 189)
        Me.LBSegundaCifraSegundoNumero.Name = "LBSegundaCifraSegundoNumero"
        Me.LBSegundaCifraSegundoNumero.Size = New System.Drawing.Size(70, 116)
        Me.LBSegundaCifraSegundoNumero.TabIndex = 6
        Me.LBSegundaCifraSegundoNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBPrimeracifraSegundoNumero
        '
        Me.LBPrimeracifraSegundoNumero.BackColor = System.Drawing.Color.Transparent
        Me.LBPrimeracifraSegundoNumero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBPrimeracifraSegundoNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBPrimeracifraSegundoNumero.ForeColor = System.Drawing.Color.Yellow
        Me.LBPrimeracifraSegundoNumero.Location = New System.Drawing.Point(187, 68)
        Me.LBPrimeracifraSegundoNumero.Name = "LBPrimeracifraSegundoNumero"
        Me.LBPrimeracifraSegundoNumero.Size = New System.Drawing.Size(70, 116)
        Me.LBPrimeracifraSegundoNumero.TabIndex = 4
        Me.LBPrimeracifraSegundoNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(6, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 73)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "-"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBSegundaCifraTercerNumero
        '
        Me.LBSegundaCifraTercerNumero.BackColor = System.Drawing.Color.Transparent
        Me.LBSegundaCifraTercerNumero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBSegundaCifraTercerNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBSegundaCifraTercerNumero.ForeColor = System.Drawing.Color.Yellow
        Me.LBSegundaCifraTercerNumero.Location = New System.Drawing.Point(109, 189)
        Me.LBSegundaCifraTercerNumero.Name = "LBSegundaCifraTercerNumero"
        Me.LBSegundaCifraTercerNumero.Size = New System.Drawing.Size(70, 116)
        Me.LBSegundaCifraTercerNumero.TabIndex = 7
        Me.LBSegundaCifraTercerNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBPrimeracifraTercerNumero
        '
        Me.LBPrimeracifraTercerNumero.BackColor = System.Drawing.Color.Transparent
        Me.LBPrimeracifraTercerNumero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBPrimeracifraTercerNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBPrimeracifraTercerNumero.ForeColor = System.Drawing.Color.Yellow
        Me.LBPrimeracifraTercerNumero.Location = New System.Drawing.Point(109, 68)
        Me.LBPrimeracifraTercerNumero.Name = "LBPrimeracifraTercerNumero"
        Me.LBPrimeracifraTercerNumero.Size = New System.Drawing.Size(70, 116)
        Me.LBPrimeracifraTercerNumero.TabIndex = 5
        Me.LBPrimeracifraTercerNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRespuestaUno
        '
        Me.txtRespuestaUno.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRespuestaUno.ForeColor = System.Drawing.Color.Red
        Me.txtRespuestaUno.Location = New System.Drawing.Point(264, 311)
        Me.txtRespuestaUno.MaxLength = 1
        Me.txtRespuestaUno.Name = "txtRespuestaUno"
        Me.txtRespuestaUno.Size = New System.Drawing.Size(71, 116)
        Me.txtRespuestaUno.TabIndex = 0
        Me.txtRespuestaUno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRespuestaDos
        '
        Me.txtRespuestaDos.Enabled = False
        Me.txtRespuestaDos.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRespuestaDos.ForeColor = System.Drawing.Color.Red
        Me.txtRespuestaDos.Location = New System.Drawing.Point(187, 311)
        Me.txtRespuestaDos.MaxLength = 1
        Me.txtRespuestaDos.Name = "txtRespuestaDos"
        Me.txtRespuestaDos.Size = New System.Drawing.Size(70, 116)
        Me.txtRespuestaDos.TabIndex = 1
        Me.txtRespuestaDos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRespuestaTres
        '
        Me.txtRespuestaTres.Enabled = False
        Me.txtRespuestaTres.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRespuestaTres.ForeColor = System.Drawing.Color.Red
        Me.txtRespuestaTres.Location = New System.Drawing.Point(106, 311)
        Me.txtRespuestaTres.MaxLength = 2
        Me.txtRespuestaTres.Name = "txtRespuestaTres"
        Me.txtRespuestaTres.Size = New System.Drawing.Size(72, 116)
        Me.txtRespuestaTres.TabIndex = 2
        Me.txtRespuestaTres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmRestaTresCifras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ESTUDIO_LOS_NUMEROS.My.Resources.Resources.fondoFrmRepasar
        Me.ClientSize = New System.Drawing.Size(394, 521)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GBRESTA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRestaTresCifras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESTA DE TRES CIFRAS"
        Me.GroupBox2.ResumeLayout(False)
        Me.GPimagens.ResumeLayout(False)
        CType(Me.PBfelizPQgane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PblloroPQperdi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxmpNumero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBRESTA.ResumeLayout(False)
        Me.GBRESTA.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LbResultado As Label
    Friend WithEvents lbRespuestaSifraDos As Label
    Friend WithEvents lbRespuestaSifraUno As Label
    Friend WithEvents GBRESTA As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnComprobar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnJugar As Button
    Friend WithEvents txtLlevaTres As TextBox
    Friend WithEvents txtLlevaDos As TextBox
    Friend WithEvents LBSegundaCifraSegundoNumero As Label
    Friend WithEvents LBPrimeracifraSegundoNumero As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LBSegundaCifraTercerNumero As Label
    Friend WithEvents LBPrimeracifraTercerNumero As Label
    Friend WithEvents txtRespuestaUno As TextBox
    Friend WithEvents txtRespuestaDos As TextBox
    Friend WithEvents txtRespuestaTres As TextBox
    Friend WithEvents LBSegundaCifraPrimerNumero As Label
    Friend WithEvents LBPrimeracifraPrimerNumero As Label
    Friend WithEvents AxmpNumero As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents GPimagens As GroupBox
    Friend WithEvents PBfelizPQgane As PictureBox
    Friend WithEvents PblloroPQperdi As PictureBox
End Class
