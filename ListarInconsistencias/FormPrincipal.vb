
Imports System.IO

Public Class FormPrincipal
    Dim _Metodos As New Metodos
    Dim Conexao As String
    Dim Query As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbConectar.Text = "Conectar"
        lbConectar.Visible = True
        lbStatus.Text = "Desconectado"
        DesabilitarBotoes()
        txtCaminho.ReadOnly = True
        txtCaminho.Visible = False
        lbCaminho.Visible = False

    End Sub

    Public Sub Inicializar(c As String)
        Conexao = _Metodos.CriaStringConexaoAccess(c)
        If Conexao = "" Then
            MsgBox("Psec.dat não encontrado!", vbCritical)
            DesabilitarBotoes()
            lbConectar.Text = "Conectar"
        Else
            Conexao = _Metodos.CriaStringConexaoAccess(c)
            dgDados.DataSource = Nothing
            lbConectar.Text = "Desconectar"
            lbStatus.Text = "Conectado"
            HabilitarBotoes()
        End If
    End Sub

    Public Sub AtualizaDatagrid(Consulta, Conexao)
        dgDados.DataSource = Nothing
        dgDados.DataSource = _Metodos.Selecionar(Consulta, Conexao)
    End Sub

    Private Sub lbConectar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbConectar.LinkClicked
        If lbConectar.Text = "Conectar" Then
            LerArquivoOpenFile()
            txtCaminho.Visible = True
            lbCaminho.Visible = True
            dgDados.Visible = True
            MoveItem(600, 0)
        Else
            txtCaminho.Visible = False
            lbCaminho.Visible = False
            dgDados.DataSource = Nothing
            dgDados.Visible = False
            MoveItem(600, 0)
            DesabilitarBotoes()
            Conexao = ""
            lbConectar.Text = "Conectar"
        End If

    End Sub

    Public Sub LerArquivoOpenFile()
        Using OpenFile As New OpenFileDialog
            OpenFile.Multiselect = False
            OpenFile.Filter = "Banco de dados (*.dat;*.bak)|*.dat;*.bak"
            OpenFile.InitialDirectory = CurDir()

            Dim resultado As DialogResult = OpenFile.ShowDialog()

            If resultado = System.Windows.Forms.DialogResult.OK Then
                Try
                    Using abrir As New IO.StreamReader(OpenFile.FileName)
                        Dim TestaArquivo As String = abrir.ReadLine
                        If (TestaArquivo.Contains("Standard Jet DB")) Then
                            Inicializar(OpenFile.FileName)
                            txtCaminho.Text = OpenFile.FileName
                        Else
                            txtCaminho.Text = ""
                            MsgBox("Arquivo selecionado não é válido!", vbExclamation)
                        End If

                    End Using
                Catch ex As Exception
                    MessageBox.Show("Houve um erro ao abrir o arquivo! " + vbCrLf + ex.Message,
                                    "Erro ao abrir o arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Public Sub DesabilitarBotoes()
        dgDados.Visible = False
        btnFuncionarios.Enabled = False
        btnUsuarios.Enabled = False
        btnBatidas.Enabled = False
        btnCalculos.Enabled = False
        btnJustificativas.Enabled = False
        btnFiscais.Enabled = False
        btnEventos.Enabled = False
        btnFuncoes.Enabled = False
    End Sub


    Public Sub HabilitarBotoes()
        btnFuncionarios.Enabled = True
        btnUsuarios.Enabled = True
        btnBatidas.Enabled = True
        btnCalculos.Enabled = True
        btnJustificativas.Enabled = True
        btnFiscais.Enabled = True
        btnEventos.Enabled = True
        btnFuncoes.Enabled = True
        dgDados.Visible = True
    End Sub

    Private Sub btnFuncionarios_Click(sender As Object, e As EventArgs) Handles btnFuncionarios.Click
        txtQuery.Text = ""
        Query = _Metodos.Querys("Funcionarios")
        AtualizaDatagrid(Query, Conexao)
        txtQuery.Text = Query
        If (dgDados.Rows.Count = 0) Then
            MsgBox("Não há inconsistências em Funcionários", vbInformation)
        End If
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        txtQuery.Text = ""
        Query = _Metodos.Querys("Usuarios")
        AtualizaDatagrid(Query, Conexao)
        txtQuery.Text = Query
        If (dgDados.Rows.Count = 0) Then
            MsgBox("Não há inconsistências em Usuários", vbInformation)
        End If

    End Sub

    Private Sub btnBatidas_Click(sender As Object, e As EventArgs) Handles btnBatidas.Click
        txtQuery.Text = ""
        Query = _Metodos.Querys("Batidas")
        AtualizaDatagrid(Query, Conexao)
        txtQuery.Text = Query
        If (dgDados.Rows.Count = 0) Then
            MsgBox("Não há inconsistências em Batidas", vbInformation)
        End If
    End Sub

    Private Sub btnCalculos_Click(sender As Object, e As EventArgs) Handles btnCalculos.Click
        txtQuery.Text = ""
        Query = _Metodos.Querys("Calculos")
        AtualizaDatagrid(Query, Conexao)
        txtQuery.Text = Query
        If (dgDados.Rows.Count = 0) Then
            MsgBox("Não há inconsistências em Cálculos", vbInformation)
        End If
    End Sub

    Private Sub btnJustificativas_Click(sender As Object, e As EventArgs) Handles btnJustificativas.Click
        txtQuery.Text = ""
        Query = _Metodos.Querys("Justificativas")
        AtualizaDatagrid(Query, Conexao)
        txtQuery.Text = Query
        If (dgDados.Rows.Count = 0) Then
            MsgBox("Não há inconsistências em Justificativas Lançadas", vbInformation)
        End If
    End Sub

    Private Sub btnFiscais_Click(sender As Object, e As EventArgs) Handles btnFiscais.Click
        txtQuery.Text = ""
        Query = _Metodos.Querys("Fiscais")
        AtualizaDatagrid(Query, Conexao)
        txtQuery.Text = Query
        If (dgDados.Rows.Count = 0) Then
            MsgBox("Não há inconsistências em Arquivos Fiscais", vbInformation)
        Else
            Dim resultado As DialogResult = MsgBox("Existem inconsistências, deseja excluir?", MsgBoxStyle.YesNo)

            If (resultado = DialogResult.Yes) Then
                Query = _Metodos.Querys("Fiscais-Delete")

                Dim retorno As String = _Metodos.DeletarInformacoes(Query, Conexao)

                If (retorno = "OK") Then
                    MsgBox("Registros inconsistentes excluídos com êxito", vbInformation)
                Else
                    MsgBox(retorno, vbCritical)
                End If
            Else
                MsgBox("Nenhum registro foi excluído", vbInformation)
            End If
        End If
    End Sub

    Private Sub btnEventos_Click(sender As Object, e As EventArgs) Handles btnEventos.Click
        txtQuery.Text = ""
        Query = _Metodos.Querys("registro_eventos")
        AtualizaDatagrid(Query, Conexao)
        txtQuery.Text = Query
        If (dgDados.Rows.Count = 0) Then
            MsgBox("Não há inconsistências em Lançamento de Eventos", vbInformation)
        End If
    End Sub

    Private Sub btnFuncoes_Click(sender As Object, e As EventArgs) Handles btnFuncoes.Click
        txtQuery.Text = ""
        Query = _Metodos.Querys("registros_funcoes")
        AtualizaDatagrid(Query, Conexao)
        txtQuery.Text = Query
        If (dgDados.Rows.Count = 0) Then
            MsgBox("Não há inconsistências em Registro de Funções", vbInformation)
        End If
    End Sub

    Public Sub MoveItem(x As Integer, y As Integer)
        If lbConectar.Location.X = 22 Then
            lbConectar.Location = New Point(lbConectar.Location.X + (x), lbConectar.Location.Y + (y))
        Else
            lbConectar.Location = New Point(lbConectar.Location.X - (x), lbConectar.Location.Y - (y))
        End If
    End Sub

End Class
