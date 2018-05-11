<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoCliente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.alumno = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GridAlum = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuMetroTextbox2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BTRegistrar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PcModi = New System.Windows.Forms.PictureBox()
        Me.TBemail = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBTelef = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.CBCurso = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBDirec = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.RBMujer = New System.Windows.Forms.RadioButton()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.RBVaron = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBDni = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBApellido = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.TBNombre = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataFecha = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.alumno.SuspendLayout()
        CType(Me.GridAlum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PcModi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'alumno
        '
        Me.alumno.BackColor = System.Drawing.Color.White
        Me.alumno.Controls.Add(Me.Label4)
        Me.alumno.Controls.Add(Me.Label14)
        Me.alumno.Controls.Add(Me.Label3)
        Me.alumno.Controls.Add(Me.Label8)
        Me.alumno.Dock = System.Windows.Forms.DockStyle.Top
        Me.alumno.Location = New System.Drawing.Point(0, 0)
        Me.alumno.Name = "alumno"
        Me.alumno.Size = New System.Drawing.Size(1386, 48)
        Me.alumno.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(611, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 22)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Lista de Clientes"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DimGray
        Me.Label14.Location = New System.Drawing.Point(309, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(180, 22)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Datos del vehiculo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1174, 11)
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
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(20, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 22)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Datos del Cliente"
        '
        'GridAlum
        '
        Me.GridAlum.AllowUserToAddRows = False
        Me.GridAlum.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridAlum.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridAlum.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.GridAlum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridAlum.CausesValidation = False
        Me.GridAlum.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridAlum.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridAlum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GridAlum.DoubleBuffered = True
        Me.GridAlum.EnableHeadersVisualStyles = False
        Me.GridAlum.GridColor = System.Drawing.Color.Gainsboro
        Me.GridAlum.HeaderBgColor = System.Drawing.Color.WhiteSmoke
        Me.GridAlum.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GridAlum.Location = New System.Drawing.Point(642, 63)
        Me.GridAlum.Name = "GridAlum"
        Me.GridAlum.ReadOnly = True
        Me.GridAlum.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GridAlum.Size = New System.Drawing.Size(456, 475)
        Me.GridAlum.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel2.Controls.Add(Me.BunifuMetroTextbox2)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.BunifuMetroTextbox1)
        Me.Panel2.Controls.Add(Me.BTRegistrar)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PcModi)
        Me.Panel2.Controls.Add(Me.TBemail)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.TBTelef)
        Me.Panel2.Controls.Add(Me.CBCurso)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TBDirec)
        Me.Panel2.Controls.Add(Me.RBMujer)
        Me.Panel2.Controls.Add(Me.BunifuSeparator1)
        Me.Panel2.Controls.Add(Me.RBVaron)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TBDni)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.TBApellido)
        Me.Panel2.Controls.Add(Me.TBNombre)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.DataFecha)
        Me.Panel2.Location = New System.Drawing.Point(12, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(594, 534)
        Me.Panel2.TabIndex = 26
        '
        'BunifuMetroTextbox2
        '
        Me.BunifuMetroTextbox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.LightSkyBlue
        Me.BunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.LightSkyBlue
        Me.BunifuMetroTextbox2.BorderThickness = 1
        Me.BunifuMetroTextbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox2.isPassword = False
        Me.BunifuMetroTextbox2.Location = New System.Drawing.Point(317, 161)
        Me.BunifuMetroTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox2.MaxLength = 32767
        Me.BunifuMetroTextbox2.Name = "BunifuMetroTextbox2"
        Me.BunifuMetroTextbox2.Size = New System.Drawing.Size(232, 72)
        Me.BunifuMetroTextbox2.TabIndex = 34
        Me.BunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(313, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(198, 21)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Descripcion del vehiculo"
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.LightSkyBlue
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.LightSkyBlue
        Me.BunifuMetroTextbox1.BorderThickness = 1
        Me.BunifuMetroTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(317, 94)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox1.MaxLength = 32767
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(83, 35)
        Me.BunifuMetroTextbox1.TabIndex = 32
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTRegistrar
        '
        Me.BTRegistrar.Active = False
        Me.BTRegistrar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BTRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTRegistrar.BorderRadius = 0
        Me.BTRegistrar.ButtonText = "Registrar"
        Me.BTRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTRegistrar.DisabledColor = System.Drawing.Color.Gray
        Me.BTRegistrar.Iconcolor = System.Drawing.Color.Transparent
        Me.BTRegistrar.Iconimage = Nothing
        Me.BTRegistrar.Iconimage_right = Nothing
        Me.BTRegistrar.Iconimage_right_Selected = Nothing
        Me.BTRegistrar.Iconimage_Selected = Nothing
        Me.BTRegistrar.IconMarginLeft = 0
        Me.BTRegistrar.IconMarginRight = 0
        Me.BTRegistrar.IconRightVisible = True
        Me.BTRegistrar.IconRightZoom = 0R
        Me.BTRegistrar.IconVisible = True
        Me.BTRegistrar.IconZoom = 90.0R
        Me.BTRegistrar.IsTab = False
        Me.BTRegistrar.Location = New System.Drawing.Point(308, 276)
        Me.BTRegistrar.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BTRegistrar.Name = "BTRegistrar"
        Me.BTRegistrar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BTRegistrar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BTRegistrar.OnHoverTextColor = System.Drawing.Color.White
        Me.BTRegistrar.selected = False
        Me.BTRegistrar.Size = New System.Drawing.Size(272, 40)
        Me.BTRegistrar.TabIndex = 25
        Me.BTRegistrar.Text = "Registrar"
        Me.BTRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTRegistrar.Textcolor = System.Drawing.Color.White
        Me.BTRegistrar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(313, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 21)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Patente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(326, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 21)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Llaves disponibles"
        '
        'PcModi
        '
        Me.PcModi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PcModi.Location = New System.Drawing.Point(301, 38)
        Me.PcModi.Name = "PcModi"
        Me.PcModi.Size = New System.Drawing.Size(24, 26)
        Me.PcModi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcModi.TabIndex = 30
        Me.PcModi.TabStop = False
        '
        'TBemail
        '
        Me.TBemail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TBemail.BorderColorFocused = System.Drawing.Color.LightSkyBlue
        Me.TBemail.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBemail.BorderColorMouseHover = System.Drawing.Color.LightSkyBlue
        Me.TBemail.BorderThickness = 1
        Me.TBemail.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TBemail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBemail.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TBemail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBemail.isPassword = False
        Me.TBemail.Location = New System.Drawing.Point(24, 461)
        Me.TBemail.Margin = New System.Windows.Forms.Padding(4)
        Me.TBemail.MaxLength = 32767
        Me.TBemail.Name = "TBemail"
        Me.TBemail.Size = New System.Drawing.Size(232, 35)
        Me.TBemail.TabIndex = 29
        Me.TBemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DimGray
        Me.Label15.Location = New System.Drawing.Point(21, 436)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 21)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Email"
        '
        'TBTelef
        '
        Me.TBTelef.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TBTelef.BorderColorFocused = System.Drawing.Color.LightSkyBlue
        Me.TBTelef.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBTelef.BorderColorMouseHover = System.Drawing.Color.LightSkyBlue
        Me.TBTelef.BorderThickness = 1
        Me.TBTelef.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TBTelef.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBTelef.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TBTelef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBTelef.isPassword = False
        Me.TBTelef.Location = New System.Drawing.Point(25, 398)
        Me.TBTelef.Margin = New System.Windows.Forms.Padding(4)
        Me.TBTelef.MaxLength = 32767
        Me.TBTelef.Name = "TBTelef"
        Me.TBTelef.Size = New System.Drawing.Size(232, 35)
        Me.TBTelef.TabIndex = 24
        Me.TBTelef.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'CBCurso
        '
        Me.CBCurso.BackColor = System.Drawing.Color.Gainsboro
        Me.CBCurso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CBCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBCurso.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CBCurso.FormattingEnabled = True
        Me.CBCurso.Location = New System.Drawing.Point(330, 39)
        Me.CBCurso.Margin = New System.Windows.Forms.Padding(4)
        Me.CBCurso.Name = "CBCurso"
        Me.CBCurso.Size = New System.Drawing.Size(228, 25)
        Me.CBCurso.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(22, 373)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 21)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Telefono"
        '
        'TBDirec
        '
        Me.TBDirec.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TBDirec.BorderColorFocused = System.Drawing.Color.LightSkyBlue
        Me.TBDirec.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBDirec.BorderColorMouseHover = System.Drawing.Color.LightSkyBlue
        Me.TBDirec.BorderThickness = 1
        Me.TBDirec.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TBDirec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBDirec.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TBDirec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBDirec.isPassword = False
        Me.TBDirec.Location = New System.Drawing.Point(26, 334)
        Me.TBDirec.Margin = New System.Windows.Forms.Padding(4)
        Me.TBDirec.MaxLength = 32767
        Me.TBDirec.Name = "TBDirec"
        Me.TBDirec.Size = New System.Drawing.Size(232, 35)
        Me.TBDirec.TabIndex = 22
        Me.TBDirec.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'RBMujer
        '
        Me.RBMujer.AutoSize = True
        Me.RBMujer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBMujer.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBMujer.ForeColor = System.Drawing.Color.DimGray
        Me.RBMujer.Location = New System.Drawing.Point(151, 291)
        Me.RBMujer.Name = "RBMujer"
        Me.RBMujer.Size = New System.Drawing.Size(71, 25)
        Me.RBMujer.TabIndex = 20
        Me.RBMujer.Text = "Mujer"
        Me.RBMujer.UseVisualStyleBackColor = True
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(284, 3)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(23, 528)
        Me.BunifuSeparator1.TabIndex = 19
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'RBVaron
        '
        Me.RBVaron.AutoSize = True
        Me.RBVaron.Checked = True
        Me.RBVaron.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBVaron.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBVaron.ForeColor = System.Drawing.Color.DimGray
        Me.RBVaron.Location = New System.Drawing.Point(55, 291)
        Me.RBVaron.Name = "RBVaron"
        Me.RBVaron.Size = New System.Drawing.Size(75, 25)
        Me.RBVaron.TabIndex = 18
        Me.RBVaron.TabStop = True
        Me.RBVaron.Text = "Varon"
        Me.RBVaron.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(21, 309)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 21)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Direccion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(23, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Fecha de Nacimiento"
        '
        'TBDni
        '
        Me.TBDni.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TBDni.BorderColorFocused = System.Drawing.Color.LightSkyBlue
        Me.TBDni.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBDni.BorderColorMouseHover = System.Drawing.Color.LightSkyBlue
        Me.TBDni.BorderThickness = 1
        Me.TBDni.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TBDni.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBDni.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TBDni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBDni.isPassword = False
        Me.TBDni.Location = New System.Drawing.Point(25, 29)
        Me.TBDni.Margin = New System.Windows.Forms.Padding(4)
        Me.TBDni.MaxLength = 32767
        Me.TBDni.Name = "TBDni"
        Me.TBDni.Size = New System.Drawing.Size(232, 35)
        Me.TBDni.TabIndex = 0
        Me.TBDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(21, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "D.N.I *"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(23, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nombre *"
        '
        'TBApellido
        '
        Me.TBApellido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TBApellido.BorderColorFocused = System.Drawing.Color.LightSkyBlue
        Me.TBApellido.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBApellido.BorderColorMouseHover = System.Drawing.Color.LightSkyBlue
        Me.TBApellido.BorderThickness = 1
        Me.TBApellido.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TBApellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBApellido.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TBApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBApellido.isPassword = False
        Me.TBApellido.Location = New System.Drawing.Point(25, 94)
        Me.TBApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.TBApellido.MaxLength = 32767
        Me.TBApellido.Name = "TBApellido"
        Me.TBApellido.Size = New System.Drawing.Size(232, 35)
        Me.TBApellido.TabIndex = 1
        Me.TBApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TBNombre
        '
        Me.TBNombre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TBNombre.BorderColorFocused = System.Drawing.Color.LightSkyBlue
        Me.TBNombre.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBNombre.BorderColorMouseHover = System.Drawing.Color.LightSkyBlue
        Me.TBNombre.BorderThickness = 1
        Me.TBNombre.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TBNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TBNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TBNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TBNombre.isPassword = False
        Me.TBNombre.Location = New System.Drawing.Point(26, 161)
        Me.TBNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombre.MaxLength = 32767
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(232, 35)
        Me.TBNombre.TabIndex = 2
        Me.TBNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(21, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Apellido *"
        '
        'DataFecha
        '
        Me.DataFecha.BackColor = System.Drawing.Color.SteelBlue
        Me.DataFecha.BorderRadius = 0
        Me.DataFecha.ForeColor = System.Drawing.Color.White
        Me.DataFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataFecha.FormatCustom = Nothing
        Me.DataFecha.Location = New System.Drawing.Point(26, 236)
        Me.DataFecha.Name = "DataFecha"
        Me.DataFecha.Size = New System.Drawing.Size(232, 36)
        Me.DataFecha.TabIndex = 3
        Me.DataFecha.Value = New Date(2017, 3, 19, 21, 29, 36, 576)
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Active = False
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Registrar"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(301, 354)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(272, 40)
        Me.BunifuFlatButton1.TabIndex = 36
        Me.BunifuFlatButton1.Text = "Registrar"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'NuevoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 650)
        Me.Controls.Add(Me.alumno)
        Me.Controls.Add(Me.GridAlum)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NuevoCliente"
        Me.Text = "NuevoCliente"
        Me.alumno.ResumeLayout(False)
        Me.alumno.PerformLayout()
        CType(Me.GridAlum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PcModi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents alumno As Panel
    '  Friend WithEvents TBBuscaAlumnos As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GridAlum As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TBemail As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label15 As Label
    Friend WithEvents TBTelef As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents TBDirec As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents RBMujer As RadioButton
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents RBVaron As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TBDni As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TBApellido As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents TBNombre As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataFecha As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BTRegistrar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PcModi As PictureBox
    Friend WithEvents CBCurso As ComboBox
    Friend WithEvents BunifuMetroTextbox2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
End Class
