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
        Me.lbConectar = New System.Windows.Forms.LinkLabel()
        Me.btnFuncionarios = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnBatidas = New System.Windows.Forms.Button()
        Me.btnFiscais = New System.Windows.Forms.Button()
        Me.btnJustificativas = New System.Windows.Forms.Button()
        Me.btnCalculos = New System.Windows.Forms.Button()
        Me.lbCaminho = New System.Windows.Forms.Label()
        Me.txtCaminho = New System.Windows.Forms.TextBox()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.btnEventos = New System.Windows.Forms.Button()
        Me.btnFuncoes = New System.Windows.Forms.Button()
        Me.txtQuery = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        'lbConectar
        '
        Me.lbConectar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbConectar.AutoSize = True
        Me.lbConectar.Location = New System.Drawing.Point(22, 12)
        Me.lbConectar.Name = "lbConectar"
        Me.lbConectar.Size = New System.Drawing.Size(68, 13)
        Me.lbConectar.TabIndex = 5
        Me.lbConectar.TabStop = True
        Me.lbConectar.Text = "Desconectar"
        '
        'btnFuncionarios
        '
        Me.btnFuncionarios.Location = New System.Drawing.Point(12, 37)
        Me.btnFuncionarios.Name = "btnFuncionarios"
        Me.btnFuncionarios.Size = New System.Drawing.Size(142, 23)
        Me.btnFuncionarios.TabIndex = 6
        Me.btnFuncionarios.Text = "Funcionários"
        Me.btnFuncionarios.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Location = New System.Drawing.Point(12, 66)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(142, 23)
        Me.btnUsuarios.TabIndex = 7
        Me.btnUsuarios.Text = "Usuários"
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'btnBatidas
        '
        Me.btnBatidas.Location = New System.Drawing.Point(12, 95)
        Me.btnBatidas.Name = "btnBatidas"
        Me.btnBatidas.Size = New System.Drawing.Size(142, 23)
        Me.btnBatidas.TabIndex = 8
        Me.btnBatidas.Text = "Batidas"
        Me.btnBatidas.UseVisualStyleBackColor = True
        '
        'btnFiscais
        '
        Me.btnFiscais.Location = New System.Drawing.Point(12, 243)
        Me.btnFiscais.Name = "btnFiscais"
        Me.btnFiscais.Size = New System.Drawing.Size(142, 23)
        Me.btnFiscais.TabIndex = 11
        Me.btnFiscais.Text = "Fiscais"
        Me.btnFiscais.UseVisualStyleBackColor = True
        '
        'btnJustificativas
        '
        Me.btnJustificativas.Location = New System.Drawing.Point(12, 214)
        Me.btnJustificativas.Name = "btnJustificativas"
        Me.btnJustificativas.Size = New System.Drawing.Size(142, 23)
        Me.btnJustificativas.TabIndex = 10
        Me.btnJustificativas.Text = "Justificativas"
        Me.btnJustificativas.UseVisualStyleBackColor = True
        '
        'btnCalculos
        '
        Me.btnCalculos.Location = New System.Drawing.Point(12, 125)
        Me.btnCalculos.Name = "btnCalculos"
        Me.btnCalculos.Size = New System.Drawing.Size(142, 23)
        Me.btnCalculos.TabIndex = 9
        Me.btnCalculos.Text = "Cálculos"
        Me.btnCalculos.UseVisualStyleBackColor = True
        '
        'lbCaminho
        '
        Me.lbCaminho.AutoSize = True
        Me.lbCaminho.Location = New System.Drawing.Point(100, 12)
        Me.lbCaminho.Name = "lbCaminho"
        Me.lbCaminho.Size = New System.Drawing.Size(54, 13)
        Me.lbCaminho.TabIndex = 12
        Me.lbCaminho.Text = "Caminho: "
        '
        'txtCaminho
        '
        Me.txtCaminho.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCaminho.Location = New System.Drawing.Point(160, 8)
        Me.txtCaminho.Name = "txtCaminho"
        Me.txtCaminho.Size = New System.Drawing.Size(463, 20)
        Me.txtCaminho.TabIndex = 13
        '
        'lbStatus
        '
        Me.lbStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Location = New System.Drawing.Point(163, 299)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(77, 13)
        Me.lbStatus.TabIndex = 14
        Me.lbStatus.Text = "Desconectado"
        '
        'btnEventos
        '
        Me.btnEventos.Location = New System.Drawing.Point(12, 154)
        Me.btnEventos.Name = "btnEventos"
        Me.btnEventos.Size = New System.Drawing.Size(142, 23)
        Me.btnEventos.TabIndex = 15
        Me.btnEventos.Text = "Eventos"
        Me.btnEventos.UseVisualStyleBackColor = True
        '
        'btnFuncoes
        '
        Me.btnFuncoes.Location = New System.Drawing.Point(12, 183)
        Me.btnFuncoes.Name = "btnFuncoes"
        Me.btnFuncoes.Size = New System.Drawing.Size(142, 23)
        Me.btnFuncoes.TabIndex = 16
        Me.btnFuncoes.Text = "Funções Equipamento"
        Me.btnFuncoes.UseVisualStyleBackColor = True
        '
        'txtQuery
        '
        Me.txtQuery.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuery.Location = New System.Drawing.Point(160, 323)
        Me.txtQuery.Multiline = True
        Me.txtQuery.Name = "txtQuery"
        Me.txtQuery.ReadOnly = True
        Me.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtQuery.Size = New System.Drawing.Size(532, 104)
        Me.txtQuery.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Query Utilizada:"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 444)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtQuery)
        Me.Controls.Add(Me.btnFuncoes)
        Me.Controls.Add(Me.btnEventos)
        Me.Controls.Add(Me.lbStatus)
        Me.Controls.Add(Me.txtCaminho)
        Me.Controls.Add(Me.lbCaminho)
        Me.Controls.Add(Me.btnFiscais)
        Me.Controls.Add(Me.btnJustificativas)
        Me.Controls.Add(Me.btnCalculos)
        Me.Controls.Add(Me.btnBatidas)
        Me.Controls.Add(Me.btnUsuarios)
        Me.Controls.Add(Me.btnFuncionarios)
        Me.Controls.Add(Me.lbConectar)
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
    Friend WithEvents lbConectar As LinkLabel
    Friend WithEvents btnFuncionarios As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnBatidas As Button
    Friend WithEvents btnFiscais As Button
    Friend WithEvents btnJustificativas As Button
    Friend WithEvents btnCalculos As Button
    Friend WithEvents lbCaminho As Label
    Friend WithEvents txtCaminho As TextBox
    Friend WithEvents lbStatus As Label
    Friend WithEvents btnEventos As Button
    Friend WithEvents btnFuncoes As Button
    Friend WithEvents txtQuery As TextBox
    Friend WithEvents Label2 As Label
End Class
