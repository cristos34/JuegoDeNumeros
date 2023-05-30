<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEscogerOperacion
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
        Me.GBJUEGOS = New System.Windows.Forms.GroupBox()
        Me.BtnTresCifra = New System.Windows.Forms.Button()
        Me.BtnDosCifra = New System.Windows.Forms.Button()
        Me.BtnUnaCifra = New System.Windows.Forms.Button()
        Me.GBJUEGOS.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBJUEGOS
        '
        Me.GBJUEGOS.Controls.Add(Me.BtnTresCifra)
        Me.GBJUEGOS.Controls.Add(Me.BtnDosCifra)
        Me.GBJUEGOS.Controls.Add(Me.BtnUnaCifra)
        Me.GBJUEGOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBJUEGOS.Location = New System.Drawing.Point(9, 3)
        Me.GBJUEGOS.Name = "GBJUEGOS"
        Me.GBJUEGOS.Size = New System.Drawing.Size(200, 175)
        Me.GBJUEGOS.TabIndex = 0
        Me.GBJUEGOS.TabStop = False
        Me.GBJUEGOS.Text = "JUEGOS"
        '
        'BtnTresCifra
        '
        Me.BtnTresCifra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTresCifra.Location = New System.Drawing.Point(46, 131)
        Me.BtnTresCifra.Name = "BtnTresCifra"
        Me.BtnTresCifra.Size = New System.Drawing.Size(103, 23)
        Me.BtnTresCifra.TabIndex = 3
        Me.BtnTresCifra.Text = "TRES CIFRA"
        Me.BtnTresCifra.UseVisualStyleBackColor = True
        '
        'BtnDosCifra
        '
        Me.BtnDosCifra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDosCifra.Location = New System.Drawing.Point(46, 82)
        Me.BtnDosCifra.Name = "BtnDosCifra"
        Me.BtnDosCifra.Size = New System.Drawing.Size(103, 23)
        Me.BtnDosCifra.TabIndex = 2
        Me.BtnDosCifra.Text = "DOS CIFRA"
        Me.BtnDosCifra.UseVisualStyleBackColor = True
        '
        'BtnUnaCifra
        '
        Me.BtnUnaCifra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUnaCifra.Location = New System.Drawing.Point(46, 31)
        Me.BtnUnaCifra.Name = "BtnUnaCifra"
        Me.BtnUnaCifra.Size = New System.Drawing.Size(103, 23)
        Me.BtnUnaCifra.TabIndex = 1
        Me.BtnUnaCifra.Text = "UNA CIFRA"
        Me.BtnUnaCifra.UseVisualStyleBackColor = True
        '
        'frmEscogerOperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 187)
        Me.Controls.Add(Me.GBJUEGOS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEscogerOperacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JUEGOS MATEMATICOS"
        Me.GBJUEGOS.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBJUEGOS As GroupBox
    Friend WithEvents BtnUnaCifra As Button
    Friend WithEvents BtnDosCifra As Button
    Friend WithEvents BtnTresCifra As Button
End Class
