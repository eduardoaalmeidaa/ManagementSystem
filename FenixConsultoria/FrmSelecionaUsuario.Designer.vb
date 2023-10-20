<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelecionaUsuario
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSelecionaUsuario))
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DgUsuario = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TxtUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtSenha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DtData = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.CmbEmail = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BtnAtualizar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnVoltar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnLimpar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDeletar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnIncluir = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAlterar = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(20, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Usuário:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Senha:"
        '
        'TxtID
        '
        Me.TxtID.BackColor = System.Drawing.Color.Red
        Me.TxtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtID.Location = New System.Drawing.Point(55, 9)
        Me.TxtID.Multiline = True
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(40, 21)
        Me.TxtID.TabIndex = 11
        Me.TxtID.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Enabled = False
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "ID:"
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(261, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Data:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(259, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Email:"
        '
        'DgUsuario
        '
        Me.DgUsuario.AllowUserToAddRows = False
        Me.DgUsuario.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgUsuario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgUsuario.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgUsuario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgUsuario.ColumnHeadersHeight = 4
        Me.DgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgUsuario.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgUsuario.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgUsuario.Location = New System.Drawing.Point(26, 131)
        Me.DgUsuario.Name = "DgUsuario"
        Me.DgUsuario.ReadOnly = True
        Me.DgUsuario.RowHeadersVisible = False
        Me.DgUsuario.Size = New System.Drawing.Size(679, 468)
        Me.DgUsuario.TabIndex = 19
        Me.DgUsuario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgUsuario.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgUsuario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgUsuario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgUsuario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgUsuario.ThemeStyle.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.DgUsuario.ThemeStyle.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgUsuario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgUsuario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgUsuario.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgUsuario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgUsuario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgUsuario.ThemeStyle.HeaderStyle.Height = 4
        Me.DgUsuario.ThemeStyle.ReadOnly = True
        Me.DgUsuario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgUsuario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgUsuario.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgUsuario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgUsuario.ThemeStyle.RowsStyle.Height = 22
        Me.DgUsuario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgUsuario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Animated = True
        Me.TxtUsuario.AutoRoundedCorners = True
        Me.TxtUsuario.BorderRadius = 17
        Me.TxtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtUsuario.DefaultText = ""
        Me.TxtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUsuario.FillColor = System.Drawing.SystemColors.Window
        Me.TxtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtUsuario.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtUsuario.Location = New System.Drawing.Point(78, 36)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtUsuario.PlaceholderText = ""
        Me.TxtUsuario.SelectedText = ""
        Me.TxtUsuario.Size = New System.Drawing.Size(139, 36)
        Me.TxtUsuario.TabIndex = 0
        '
        'TxtSenha
        '
        Me.TxtSenha.Animated = True
        Me.TxtSenha.AutoRoundedCorners = True
        Me.TxtSenha.BorderRadius = 17
        Me.TxtSenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSenha.DefaultText = ""
        Me.TxtSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSenha.FillColor = System.Drawing.SystemColors.Window
        Me.TxtSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSenha.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSenha.Location = New System.Drawing.Point(78, 78)
        Me.TxtSenha.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtSenha.PlaceholderText = ""
        Me.TxtSenha.SelectedText = ""
        Me.TxtSenha.Size = New System.Drawing.Size(139, 36)
        Me.TxtSenha.TabIndex = 1
        '
        'TxtEmail
        '
        Me.TxtEmail.Animated = True
        Me.TxtEmail.AutoRoundedCorners = True
        Me.TxtEmail.BorderRadius = 17
        Me.TxtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtEmail.DefaultText = ""
        Me.TxtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtEmail.FillColor = System.Drawing.SystemColors.Window
        Me.TxtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtEmail.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtEmail.Location = New System.Drawing.Point(307, 36)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtEmail.PlaceholderText = ""
        Me.TxtEmail.SelectedText = ""
        Me.TxtEmail.Size = New System.Drawing.Size(228, 36)
        Me.TxtEmail.TabIndex = 2
        '
        'DtData
        '
        Me.DtData.Animated = True
        Me.DtData.AutoRoundedCorners = True
        Me.DtData.BackColor = System.Drawing.Color.Transparent
        Me.DtData.BorderRadius = 17
        Me.DtData.Checked = True
        Me.DtData.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DtData.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtData.ForeColor = System.Drawing.SystemColors.Window
        Me.DtData.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DtData.Location = New System.Drawing.Point(305, 78)
        Me.DtData.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DtData.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DtData.Name = "DtData"
        Me.DtData.Size = New System.Drawing.Size(400, 36)
        Me.DtData.TabIndex = 21
        Me.DtData.UseTransparentBackground = True
        Me.DtData.Value = New Date(2023, 10, 19, 17, 13, 13, 557)
        '
        'CmbEmail
        '
        Me.CmbEmail.AutoRoundedCorners = True
        Me.CmbEmail.BackColor = System.Drawing.Color.Transparent
        Me.CmbEmail.BorderRadius = 17
        Me.CmbEmail.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEmail.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbEmail.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.CmbEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbEmail.ItemHeight = 30
        Me.CmbEmail.Items.AddRange(New Object() {"", "@gmail.com", "@yahoo.com", "@hotmail.com ", "@outlook.com", "@aol.com", "@icloud.com", "@yandex.com", "@mail.ru", "@protonmail.com", "@live.com", "@gmx.com"})
        Me.CmbEmail.Location = New System.Drawing.Point(540, 36)
        Me.CmbEmail.Name = "CmbEmail"
        Me.CmbEmail.Size = New System.Drawing.Size(165, 36)
        Me.CmbEmail.TabIndex = 22
        '
        'BtnAtualizar
        '
        Me.BtnAtualizar.Animated = True
        Me.BtnAtualizar.AutoRoundedCorners = True
        Me.BtnAtualizar.BackColor = System.Drawing.Color.Transparent
        Me.BtnAtualizar.BorderRadius = 17
        Me.BtnAtualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAtualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAtualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAtualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAtualizar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAtualizar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAtualizar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnAtualizar.IndicateFocus = True
        Me.BtnAtualizar.Location = New System.Drawing.Point(23, 614)
        Me.BtnAtualizar.Name = "BtnAtualizar"
        Me.BtnAtualizar.Size = New System.Drawing.Size(104, 36)
        Me.BtnAtualizar.TabIndex = 23
        Me.BtnAtualizar.Text = "&Atualizar"
        Me.BtnAtualizar.UseTransparentBackground = True
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Animated = True
        Me.BtnVoltar.AutoRoundedCorners = True
        Me.BtnVoltar.BackColor = System.Drawing.Color.Transparent
        Me.BtnVoltar.BorderRadius = 17
        Me.BtnVoltar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnVoltar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnVoltar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnVoltar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnVoltar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnVoltar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoltar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnVoltar.IndicateFocus = True
        Me.BtnVoltar.Location = New System.Drawing.Point(601, 614)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(104, 36)
        Me.BtnVoltar.TabIndex = 24
        Me.BtnVoltar.Text = "&Voltar"
        Me.BtnVoltar.UseTransparentBackground = True
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Animated = True
        Me.BtnLimpar.AutoRoundedCorners = True
        Me.BtnLimpar.BackColor = System.Drawing.Color.Transparent
        Me.BtnLimpar.BorderRadius = 17
        Me.BtnLimpar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnLimpar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnLimpar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnLimpar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnLimpar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnLimpar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnLimpar.IndicateFocus = True
        Me.BtnLimpar.Location = New System.Drawing.Point(466, 614)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(104, 36)
        Me.BtnLimpar.TabIndex = 25
        Me.BtnLimpar.Text = "&Limpar"
        Me.BtnLimpar.UseTransparentBackground = True
        '
        'BtnDeletar
        '
        Me.BtnDeletar.Animated = True
        Me.BtnDeletar.AutoRoundedCorners = True
        Me.BtnDeletar.BackColor = System.Drawing.Color.Transparent
        Me.BtnDeletar.BorderRadius = 17
        Me.BtnDeletar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDeletar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDeletar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDeletar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDeletar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnDeletar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeletar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnDeletar.IndicateFocus = True
        Me.BtnDeletar.Location = New System.Drawing.Point(356, 614)
        Me.BtnDeletar.Name = "BtnDeletar"
        Me.BtnDeletar.Size = New System.Drawing.Size(104, 36)
        Me.BtnDeletar.TabIndex = 26
        Me.BtnDeletar.Text = "&Deletar"
        Me.BtnDeletar.UseTransparentBackground = True
        '
        'BtnIncluir
        '
        Me.BtnIncluir.Animated = True
        Me.BtnIncluir.AutoRoundedCorners = True
        Me.BtnIncluir.BackColor = System.Drawing.Color.Transparent
        Me.BtnIncluir.BorderRadius = 17
        Me.BtnIncluir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnIncluir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnIncluir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnIncluir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnIncluir.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnIncluir.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIncluir.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnIncluir.IndicateFocus = True
        Me.BtnIncluir.Location = New System.Drawing.Point(136, 614)
        Me.BtnIncluir.Name = "BtnIncluir"
        Me.BtnIncluir.Size = New System.Drawing.Size(104, 36)
        Me.BtnIncluir.TabIndex = 27
        Me.BtnIncluir.Text = "&Incluir"
        Me.BtnIncluir.UseTransparentBackground = True
        '
        'BtnAlterar
        '
        Me.BtnAlterar.Animated = True
        Me.BtnAlterar.AutoRoundedCorners = True
        Me.BtnAlterar.BackColor = System.Drawing.Color.Transparent
        Me.BtnAlterar.BorderRadius = 17
        Me.BtnAlterar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAlterar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAlterar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAlterar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAlterar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAlterar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlterar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnAlterar.IndicateFocus = True
        Me.BtnAlterar.Location = New System.Drawing.Point(246, 614)
        Me.BtnAlterar.Name = "BtnAlterar"
        Me.BtnAlterar.Size = New System.Drawing.Size(104, 36)
        Me.BtnAlterar.TabIndex = 28
        Me.BtnAlterar.Text = "&Alterar"
        Me.BtnAlterar.UseTransparentBackground = True
        '
        'FrmSelecionaUsuario
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(730, 666)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnAlterar)
        Me.Controls.Add(Me.BtnIncluir)
        Me.Controls.Add(Me.BtnDeletar)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.BtnVoltar)
        Me.Controls.Add(Me.BtnAtualizar)
        Me.Controls.Add(Me.CmbEmail)
        Me.Controls.Add(Me.DtData)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtSenha)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.DgUsuario)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSelecionaUsuario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleciona Usuário"
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    '   Friend WithEvents FenixDataSet As FenixDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DgUsuario As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TxtUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtSenha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DtData As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents CmbEmail As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BtnAtualizar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnVoltar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnLimpar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDeletar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnIncluir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAlterar As Guna.UI2.WinForms.Guna2Button
    ' Friend WithEvents UsuariosTableAdapter As FenixDataSetTableAdapters.UsuariosTableAdapter
End Class
