<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgDados = New System.Windows.Forms.DataGridView()
        Me.LbConectar = New System.Windows.Forms.LinkLabel()
        Me.BtnFuncionarios = New System.Windows.Forms.Button()
        Me.BtnUsuarios = New System.Windows.Forms.Button()
        Me.BtnBatidas = New System.Windows.Forms.Button()
        Me.BtnFiscais = New System.Windows.Forms.Button()
        Me.BtnJustificativas = New System.Windows.Forms.Button()
        Me.BtnCalculos = New System.Windows.Forms.Button()
        Me.LbCaminho = New System.Windows.Forms.Label()
        Me.TxtCaminho = New System.Windows.Forms.TextBox()
        Me.LbStatus = New System.Windows.Forms.Label()
        Me.BtnEventos = New System.Windows.Forms.Button()
        Me.BtnFuncoes = New System.Windows.Forms.Button()
        Me.TxtQuery = New System.Windows.Forms.TextBox()
        Me.LbQuery = New System.Windows.Forms.Label()
        CType(Me.dgDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgDados
        '
        Me.dgDados.AllowUserToAddRows = False
        Me.dgDados.AllowUserToDeleteRows = False
        Me.dgDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDados.Location = New System.Drawing.Point(160, 35)
        Me.dgDados.Name = "dgDados"
        Me.dgDados.ReadOnly = True
        Me.dgDados.Size = New System.Drawing.Size(532, 260)
        Me.dgDados.TabIndex = 0
        '
        'LbConectar
        '
        Me.LbConectar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbConectar.AutoSize = True
        Me.LbConectar.Location = New System.Drawing.Point(22, 12)
        Me.LbConectar.Name = "LbConectar"
        Me.LbConectar.Size = New System.Drawing.Size(68, 13)
        Me.LbConectar.TabIndex = 5
        Me.LbConectar.TabStop = True
        Me.LbConectar.Text = "Desconectar"
        '
        'BtnFuncionarios
        '
        Me.BtnFuncionarios.Location = New System.Drawing.Point(12, 37)
        Me.BtnFuncionarios.Name = "BtnFuncionarios"
        Me.BtnFuncionarios.Size = New System.Drawing.Size(142, 23)
        Me.BtnFuncionarios.TabIndex = 6
        Me.BtnFuncionarios.Text = "Funcionários"
        Me.BtnFuncionarios.UseVisualStyleBackColor = True
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.Location = New System.Drawing.Point(12, 66)
        Me.BtnUsuarios.Name = "BtnUsuarios"
        Me.BtnUsuarios.Size = New System.Drawing.Size(142, 23)
        Me.BtnUsuarios.TabIndex = 7
        Me.BtnUsuarios.Text = "Usuários"
        Me.BtnUsuarios.UseVisualStyleBackColor = True
        '
        'BtnBatidas
        '
        Me.BtnBatidas.Location = New System.Drawing.Point(12, 95)
        Me.BtnBatidas.Name = "BtnBatidas"
        Me.BtnBatidas.Size = New System.Drawing.Size(142, 23)
        Me.BtnBatidas.TabIndex = 8
        Me.BtnBatidas.Text = "Batidas"
        Me.BtnBatidas.UseVisualStyleBackColor = True
        '
        'BtnFiscais
        '
        Me.BtnFiscais.Location = New System.Drawing.Point(12, 243)
        Me.BtnFiscais.Name = "BtnFiscais"
        Me.BtnFiscais.Size = New System.Drawing.Size(142, 23)
        Me.BtnFiscais.TabIndex = 11
        Me.BtnFiscais.Text = "Fiscais"
        Me.BtnFiscais.UseVisualStyleBackColor = True
        '
        'BtnJustificativas
        '
        Me.BtnJustificativas.Location = New System.Drawing.Point(12, 214)
        Me.BtnJustificativas.Name = "BtnJustificativas"
        Me.BtnJustificativas.Size = New System.Drawing.Size(142, 23)
        Me.BtnJustificativas.TabIndex = 10
        Me.BtnJustificativas.Text = "Justificativas"
        Me.BtnJustificativas.UseVisualStyleBackColor = True
        '
        'BtnCalculos
        '
        Me.BtnCalculos.Location = New System.Drawing.Point(12, 125)
        Me.BtnCalculos.Name = "BtnCalculos"
        Me.BtnCalculos.Size = New System.Drawing.Size(142, 23)
        Me.BtnCalculos.TabIndex = 9
        Me.BtnCalculos.Text = "Cálculos"
        Me.BtnCalculos.UseVisualStyleBackColor = True
        '
        'LbCaminho
        '
        Me.LbCaminho.AutoSize = True
        Me.LbCaminho.Location = New System.Drawing.Point(100, 12)
        Me.LbCaminho.Name = "LbCaminho"
        Me.LbCaminho.Size = New System.Drawing.Size(54, 13)
        Me.LbCaminho.TabIndex = 12
        Me.LbCaminho.Text = "Caminho: "
        '
        'TxtCaminho
        '
        Me.TxtCaminho.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCaminho.Location = New System.Drawing.Point(160, 8)
        Me.TxtCaminho.Name = "TxtCaminho"
        Me.TxtCaminho.Size = New System.Drawing.Size(463, 20)
        Me.TxtCaminho.TabIndex = 13
        '
        'LbStatus
        '
        Me.LbStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbStatus.AutoSize = True
        Me.LbStatus.Location = New System.Drawing.Point(163, 299)
        Me.LbStatus.Name = "LbStatus"
        Me.LbStatus.Size = New System.Drawing.Size(77, 13)
        Me.LbStatus.TabIndex = 14
        Me.LbStatus.Text = "Desconectado"
        '
        'BtnEventos
        '
        Me.BtnEventos.Location = New System.Drawing.Point(12, 154)
        Me.BtnEventos.Name = "BtnEventos"
        Me.BtnEventos.Size = New System.Drawing.Size(142, 23)
        Me.BtnEventos.TabIndex = 15
        Me.BtnEventos.Text = "Eventos"
        Me.BtnEventos.UseVisualStyleBackColor = True
        '
        'BtnFuncoes
        '
        Me.BtnFuncoes.Location = New System.Drawing.Point(12, 183)
        Me.BtnFuncoes.Name = "BtnFuncoes"
        Me.BtnFuncoes.Size = New System.Drawing.Size(142, 23)
        Me.BtnFuncoes.TabIndex = 16
        Me.BtnFuncoes.Text = "Funções Equipamento"
        Me.BtnFuncoes.UseVisualStyleBackColor = True
        '
        'TxtQuery
        '
        Me.TxtQuery.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtQuery.Location = New System.Drawing.Point(160, 323)
        Me.TxtQuery.Multiline = True
        Me.TxtQuery.Name = "TxtQuery"
        Me.TxtQuery.ReadOnly = True
        Me.TxtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtQuery.Size = New System.Drawing.Size(532, 104)
        Me.TxtQuery.TabIndex = 17
        '
        'LbQuery
        '
        Me.LbQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbQuery.AutoSize = True
        Me.LbQuery.Location = New System.Drawing.Point(73, 326)
        Me.LbQuery.Name = "LbQuery"
        Me.LbQuery.Size = New System.Drawing.Size(81, 13)
        Me.LbQuery.TabIndex = 18
        Me.LbQuery.Text = "Query Utilizada:"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 444)
        Me.Controls.Add(Me.LbQuery)
        Me.Controls.Add(Me.TxtQuery)
        Me.Controls.Add(Me.BtnFuncoes)
        Me.Controls.Add(Me.BtnEventos)
        Me.Controls.Add(Me.LbStatus)
        Me.Controls.Add(Me.TxtCaminho)
        Me.Controls.Add(Me.LbCaminho)
        Me.Controls.Add(Me.BtnFiscais)
        Me.Controls.Add(Me.BtnJustificativas)
        Me.Controls.Add(Me.BtnCalculos)
        Me.Controls.Add(Me.BtnBatidas)
        Me.Controls.Add(Me.BtnUsuarios)
        Me.Controls.Add(Me.BtnFuncionarios)
        Me.Controls.Add(Me.LbConectar)
        Me.Controls.Add(Me.dgDados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPrincipal"
        Me.Text = "Listar Inconsistências"
        CType(Me.dgDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgDados As DataGridView
    Friend WithEvents LbConectar As LinkLabel
    Friend WithEvents BtnFuncionarios As Button
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents BtnBatidas As Button
    Friend WithEvents BtnFiscais As Button
    Friend WithEvents BtnJustificativas As Button
    Friend WithEvents BtnCalculos As Button
    Friend WithEvents LbCaminho As Label
    Friend WithEvents TxtCaminho As TextBox
    Friend WithEvents LbStatus As Label
    Friend WithEvents BtnEventos As Button
    Friend WithEvents BtnFuncoes As Button
    Friend WithEvents TxtQuery As TextBox
    Friend WithEvents LbQuery As Label
End Class
