<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSelecionaProdutos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSelecionaProdutos))
        Me.BtnAlterar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnIncluir = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDeletar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnLimpar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnVoltar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAtualizar = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtProduto = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.TxtObservacao = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPreco = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtData = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DgProduto = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(Me.DgProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BtnAlterar.Location = New System.Drawing.Point(236, 622)
        Me.BtnAlterar.Name = "BtnAlterar"
        Me.BtnAlterar.Size = New System.Drawing.Size(104, 36)
        Me.BtnAlterar.TabIndex = 6
        Me.BtnAlterar.Text = "&Alterar"
        Me.BtnAlterar.UseTransparentBackground = True
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
        Me.BtnIncluir.Location = New System.Drawing.Point(126, 622)
        Me.BtnIncluir.Name = "BtnIncluir"
        Me.BtnIncluir.Size = New System.Drawing.Size(104, 36)
        Me.BtnIncluir.TabIndex = 5
        Me.BtnIncluir.Text = "&Incluir"
        Me.BtnIncluir.UseTransparentBackground = True
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
        Me.BtnDeletar.Location = New System.Drawing.Point(346, 622)
        Me.BtnDeletar.Name = "BtnDeletar"
        Me.BtnDeletar.Size = New System.Drawing.Size(104, 36)
        Me.BtnDeletar.TabIndex = 7
        Me.BtnDeletar.Text = "&Deletar"
        Me.BtnDeletar.UseTransparentBackground = True
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
        Me.BtnLimpar.Location = New System.Drawing.Point(456, 622)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(104, 36)
        Me.BtnLimpar.TabIndex = 8
        Me.BtnLimpar.Text = "&Limpar"
        Me.BtnLimpar.UseTransparentBackground = True
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
        Me.BtnVoltar.Location = New System.Drawing.Point(819, 619)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(104, 36)
        Me.BtnVoltar.TabIndex = 9
        Me.BtnVoltar.Text = "&Voltar"
        Me.BtnVoltar.UseTransparentBackground = True
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
        Me.BtnAtualizar.Location = New System.Drawing.Point(18, 622)
        Me.BtnAtualizar.Name = "BtnAtualizar"
        Me.BtnAtualizar.Size = New System.Drawing.Size(104, 36)
        Me.BtnAtualizar.TabIndex = 4
        Me.BtnAtualizar.Text = "&Atualizar"
        Me.BtnAtualizar.UseTransparentBackground = True
        '
        'TxtProduto
        '
        Me.TxtProduto.Animated = True
        Me.TxtProduto.AutoRoundedCorners = True
        Me.TxtProduto.BorderRadius = 17
        Me.TxtProduto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtProduto.DefaultText = ""
        Me.TxtProduto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtProduto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtProduto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtProduto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtProduto.FillColor = System.Drawing.SystemColors.Window
        Me.TxtProduto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtProduto.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProduto.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtProduto.Location = New System.Drawing.Point(99, 18)
        Me.TxtProduto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TxtProduto.Name = "TxtProduto"
        Me.TxtProduto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtProduto.PlaceholderText = ""
        Me.TxtProduto.SelectedText = ""
        Me.TxtProduto.Size = New System.Drawing.Size(203, 36)
        Me.TxtProduto.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(38, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Produto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Enabled = False
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "ID:"
        Me.Label4.Visible = False
        '
        'TxtID
        '
        Me.TxtID.BackColor = System.Drawing.Color.Red
        Me.TxtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtID.Location = New System.Drawing.Point(42, 4)
        Me.TxtID.Multiline = True
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(40, 21)
        Me.TxtID.TabIndex = 37
        Me.TxtID.Visible = False
        '
        'TxtObservacao
        '
        Me.TxtObservacao.Animated = True
        Me.TxtObservacao.AutoRoundedCorners = True
        Me.TxtObservacao.BackColor = System.Drawing.Color.Transparent
        Me.TxtObservacao.BorderRadius = 17
        Me.TxtObservacao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtObservacao.DefaultText = ""
        Me.TxtObservacao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtObservacao.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtObservacao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtObservacao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtObservacao.FillColor = System.Drawing.SystemColors.Info
        Me.TxtObservacao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtObservacao.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservacao.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtObservacao.Location = New System.Drawing.Point(99, 60)
        Me.TxtObservacao.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TxtObservacao.Name = "TxtObservacao"
        Me.TxtObservacao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtObservacao.PlaceholderText = ""
        Me.TxtObservacao.SelectedText = ""
        Me.TxtObservacao.Size = New System.Drawing.Size(824, 36)
        Me.TxtObservacao.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Observação:"
        '
        'TxtPreco
        '
        Me.TxtPreco.Animated = True
        Me.TxtPreco.AutoRoundedCorners = True
        Me.TxtPreco.BorderRadius = 17
        Me.TxtPreco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPreco.DefaultText = ""
        Me.TxtPreco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPreco.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPreco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPreco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPreco.FillColor = System.Drawing.SystemColors.Window
        Me.TxtPreco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPreco.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPreco.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPreco.Location = New System.Drawing.Point(360, 18)
        Me.TxtPreco.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TxtPreco.Name = "TxtPreco"
        Me.TxtPreco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPreco.PlaceholderText = ""
        Me.TxtPreco.SelectedText = ""
        Me.TxtPreco.Size = New System.Drawing.Size(110, 36)
        Me.TxtPreco.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(311, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Preço:"
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
        Me.DtData.Location = New System.Drawing.Point(487, 18)
        Me.DtData.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DtData.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DtData.Name = "DtData"
        Me.DtData.Size = New System.Drawing.Size(436, 36)
        Me.DtData.TabIndex = 2
        Me.DtData.UseTransparentBackground = True
        Me.DtData.Value = New Date(2023, 10, 19, 17, 13, 13, 557)
        '
        'DgProduto
        '
        Me.DgProduto.AllowUserToAddRows = False
        Me.DgProduto.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgProduto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgProduto.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgProduto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgProduto.ColumnHeadersHeight = 4
        Me.DgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgProduto.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgProduto.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgProduto.Location = New System.Drawing.Point(17, 110)
        Me.DgProduto.Name = "DgProduto"
        Me.DgProduto.ReadOnly = True
        Me.DgProduto.RowHeadersVisible = False
        Me.DgProduto.Size = New System.Drawing.Size(906, 497)
        Me.DgProduto.TabIndex = 45
        Me.DgProduto.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgProduto.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgProduto.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgProduto.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgProduto.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgProduto.ThemeStyle.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.DgProduto.ThemeStyle.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgProduto.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgProduto.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgProduto.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgProduto.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgProduto.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgProduto.ThemeStyle.HeaderStyle.Height = 4
        Me.DgProduto.ThemeStyle.ReadOnly = True
        Me.DgProduto.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgProduto.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgProduto.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgProduto.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgProduto.ThemeStyle.RowsStyle.Height = 22
        Me.DgProduto.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgProduto.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'FrmSelecionaProdutos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(941, 671)
        Me.ControlBox = False
        Me.Controls.Add(Me.DgProduto)
        Me.Controls.Add(Me.DtData)
        Me.Controls.Add(Me.TxtPreco)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtObservacao)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.TxtProduto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnAlterar)
        Me.Controls.Add(Me.BtnIncluir)
        Me.Controls.Add(Me.BtnDeletar)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.BtnVoltar)
        Me.Controls.Add(Me.BtnAtualizar)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmSelecionaProdutos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleciona Pedido"
        CType(Me.DgProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAlterar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnIncluir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDeletar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnLimpar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnVoltar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAtualizar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtProduto As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents TxtObservacao As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPreco As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DtData As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DgProduto As Guna.UI2.WinForms.Guna2DataGridView
End Class
