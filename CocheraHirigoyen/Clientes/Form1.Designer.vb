<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CBCurso = New System.Windows.Forms.ComboBox()
        Me.GridAlum = New System.Windows.Forms.DataGridView()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.alumno = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Lnom = New System.Windows.Forms.Label()
        Me.Lleg = New System.Windows.Forms.Label()
        Me.Ldni = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.GridAlum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.alumno.SuspendLayout()
        Me.SuspendLayout()
        '
        'CBCurso
        '
        Me.CBCurso.BackColor = System.Drawing.Color.Gainsboro
        Me.CBCurso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CBCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBCurso.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CBCurso.FormattingEnabled = True
        Me.CBCurso.Location = New System.Drawing.Point(505, 88)
        Me.CBCurso.Margin = New System.Windows.Forms.Padding(4)
        Me.CBCurso.Name = "CBCurso"
        Me.CBCurso.Size = New System.Drawing.Size(232, 25)
        Me.CBCurso.TabIndex = 25
        '
        'GridAlum
        '
        Me.GridAlum.AllowUserToAddRows = False
        Me.GridAlum.AllowUserToDeleteRows = False
        Me.GridAlum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridAlum.Location = New System.Drawing.Point(28, 88)
        Me.GridAlum.Name = "GridAlum"
        Me.GridAlum.ReadOnly = True
        Me.GridAlum.Size = New System.Drawing.Size(425, 368)
        Me.GridAlum.TabIndex = 26
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Registrar"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(533, 379)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(173, 48)
        Me.BunifuFlatButton1.TabIndex = 27
        Me.BunifuFlatButton1.Text = "Registrar"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'alumno
        '
        Me.alumno.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.alumno.Controls.Add(Me.Label3)
        Me.alumno.Controls.Add(Me.Label8)
        Me.alumno.Dock = System.Windows.Forms.DockStyle.Top
        Me.alumno.Location = New System.Drawing.Point(0, 0)
        Me.alumno.Name = "alumno"
        Me.alumno.Size = New System.Drawing.Size(755, 48)
        Me.alumno.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(699, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "X"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(20, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(172, 22)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Datos del Alumno"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(501, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 22)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "D.N.I:"
        '
        'Lnom
        '
        Me.Lnom.AutoSize = True
        Me.Lnom.BackColor = System.Drawing.Color.Transparent
        Me.Lnom.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lnom.ForeColor = System.Drawing.Color.DimGray
        Me.Lnom.Location = New System.Drawing.Point(501, 206)
        Me.Lnom.Name = "Lnom"
        Me.Lnom.Size = New System.Drawing.Size(183, 21)
        Me.Lnom.TabIndex = 32
        Me.Lnom.Text = "Victor Facundo Pelozo"
        '
        'Lleg
        '
        Me.Lleg.AutoSize = True
        Me.Lleg.BackColor = System.Drawing.Color.Transparent
        Me.Lleg.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lleg.ForeColor = System.Drawing.Color.DimGray
        Me.Lleg.Location = New System.Drawing.Point(556, 143)
        Me.Lleg.Name = "Lleg"
        Me.Lleg.Size = New System.Drawing.Size(55, 21)
        Me.Lleg.TabIndex = 31
        Me.Lleg.Text = "31110"
        '
        'Ldni
        '
        Me.Ldni.AutoSize = True
        Me.Ldni.BackColor = System.Drawing.Color.Transparent
        Me.Ldni.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ldni.ForeColor = System.Drawing.Color.DimGray
        Me.Ldni.Location = New System.Drawing.Point(562, 174)
        Me.Ldni.Name = "Ldni"
        Me.Ldni.Size = New System.Drawing.Size(82, 21)
        Me.Ldni.TabIndex = 30
        Me.Ldni.Text = "32488885"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(501, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 22)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Leg:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(755, 491)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Lnom)
        Me.Controls.Add(Me.Lleg)
        Me.Controls.Add(Me.Ldni)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.alumno)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.GridAlum)
        Me.Controls.Add(Me.CBCurso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GridAlum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.alumno.ResumeLayout(False)
        Me.alumno.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBCurso As ComboBox
    Friend WithEvents GridAlum As DataGridView
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents alumno As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Lnom As Label
    Friend WithEvents Lleg As Label
    Friend WithEvents Ldni As Label
    Friend WithEvents Label5 As Label
End Class
