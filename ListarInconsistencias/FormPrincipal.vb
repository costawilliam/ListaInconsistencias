
Imports System.IO

Public Class FormPrincipal
    Dim _Metodos As New Metodos
    Dim Conexao As String
    Dim Query As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbConectar.Text = "Conectar"
        LbConectar.Visible = True
        LbStatus.Text = "Desconectado"
        DesabilitarBotoes()
        TxtCaminho.ReadOnly = True
        TxtCaminho.Visible = False
        LbCaminho.Visible = False

    End Sub

    Public Sub Inicializar(c As String)
        Conexao = _Metodos.CriaStringConexaoAccess(c)
        If Conexao = "" Then
            MsgBox("Psec.dat não encontrado!", vbCritical)
            DesabilitarBotoes()
            LbConectar.Text = "Conectar"
        Else
            Conexao = _Metodos.CriaStringConexaoAccess(c)
            dgDados.DataSource = Nothing
            LbConectar.Text = "Desconectar"
            LbStatus.Text = "Conectado"
            HabilitarBotoes()
        End If
    End Sub

    Public Sub AtualizaDatagrid(Consulta, Conexao)
        dgDados.DataSource = Nothing
        dgDados.DataSource = _Metodos.Selecionar(Consulta, Conexao)
    End Sub

    Private Sub LbConectar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LbConectar.LinkClicked
        If LbConectar.Text = "Conectar" Then
            LerArquivoOpenFile()
            TxtCaminho.Visible = True
            LbCaminho.Visible = True
            dgDados.Visible = True
            MoveItem(600, 0)
        Else
            TxtCaminho.Visible = False
            LbCaminho.Visible = False
            dgDados.DataSource = Nothing
            dgDados.Visible = False
            MoveItem(600, 0)
            DesabilitarBotoes()
            Conexao = ""
            LbConectar.Text = "Conectar"
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
                            TxtCaminho.Text = OpenFile.FileName
                        Else
                            TxtCaminho.Text = ""
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
        BtnFuncionarios.Enabled = False
        BtnUsuarios.Enabled = False
        BtnBatidas.Enabled = False
        BtnCalculos.Enabled = False
        BtnJustificativas.Enabled = False
        BtnFiscais.Enabled = False
        BtnEventos.Enabled = False
        BtnFuncoes.Enabled = False
    End Sub


    Public Sub HabilitarBotoes()
        BtnFuncionarios.Enabled = True
        BtnUsuarios.Enabled = True
        BtnBatidas.Enabled = True
        BtnCalculos.Enabled = True
        BtnJustificativas.Enabled = True
        BtnFiscais.Enabled = True
        BtnEventos.Enabled = True
        BtnFuncoes.Enabled = True
        dgDados.Visible = True
    End Sub

    Private Sub BtnFuncionarios_Click(sender As Object, e As EventArgs) Handles BtnFuncionarios.Click
        TxtQuery.Text = ""
        Query = _Metodos.Querys("Funcionarios")
        AtualizaDatagrid(Query, Conexao)
        TxtQuery.Text = Query
        If (dgDados.Rows.Count = 0) Then
            MsgBox("Não há inconsistências em Funcionários", vbInformation)
        End If
    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        TxtQuery.Text = ""
        Query = _Metodos.Querys("Usuarios")
        AtualizaDatagrid(Query, Conexao)
        TxtQuery.Text = Query
        If (dgDados.Rows.Count = 0) Then
            MsgBox("Não há inconsistências em Usuários", vbInformation)
        End If

    End Sub

    Private Sub BtnBatidas_Click(sender As Object, e As EventArgs) Handles BtnBatidas.Click
        TxtQuery.Text = ""
        Query = _Metodos.Querys("Batidas")
        AtualizaDatagrid(Query, Conexao)
        TxtQuery.Text = Query
        If (dgDados.Rows.Count = 0) Then
            MsgBox("Não há inconsistências em Batidas", vbInformation)
        End If
    End Sub

    Private Sub BtnCalculos_Click(sender As Object, e As EventArgs) Handles BtnCalculos.Click
        TxtQuery.Text = ""
        Query = _Metodos.Querys("Calculos")
        AtualizaDatagrid(Query, Conexao)
        TxtQuery.Text = Query
        If (dgDados.Rows.Count = 0) Then
            MsgBox("Não há inconsistências em Cálculos", vbInformation)
        End If
    End Sub

    Private Sub BtnJustificativas_Click(sender As Object, e As EventArgs) Handles BtnJustificativas.Click
        TxtQuery.Text = ""
        Query = _Metodos.Querys("Justificativas")
        AtualizaDatagrid(Query, Conexao)
        TxtQuery.Text = Query
        If (dgDados.Rows.Count = 0) Then
            MsgBox("Não há inconsistências em Justificativas Lançadas", vbInformation)
        End If
    End Sub

    Private Sub BtnFiscais_Click(sender As Object, e As EventArgs) Handles BtnFiscais.Click
        TxtQuery.Text = ""
        Query = _Metodos.Querys("Fiscais")
        AtualizaDatagrid(Query, Conexao)
        TxtQuery.Text = Query
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

    Private Sub BtnEventos_Click(sender As Object, e As EventArgs) Handles BtnEventos.Click
        TxtQuery.Text = ""
        Query = _Metodos.Querys("registro_eventos")
        AtualizaDatagrid(Query, Conexao)
        TxtQuery.Text = Query
        If (dgDados.Rows.Count = 0) Then
            MsgBox("Não há inconsistências em Lançamento de Eventos", vbInformation)
        End If
    End Sub

    Private Sub btnFuncoes_Click(sender As Object, e As EventArgs) Handles BtnFuncoes.Click
        TxtQuery.Text = ""
        Query = _Metodos.Querys("registros_funcoes")
        AtualizaDatagrid(Query, Conexao)
        TxtQuery.Text = Query
        If (dgDados.Rows.Count = 0) Then
            MsgBox("Não há inconsistências em Registro de Funções", vbInformation)
        End If
    End Sub

    Public Sub MoveItem(x As Integer, y As Integer)
        If LbConectar.Location.X = 22 Then
            LbConectar.Location = New Point(LbConectar.Location.X + (x), LbConectar.Location.Y + (y))
        Else
            LbConectar.Location = New Point(LbConectar.Location.X - (x), LbConectar.Location.Y - (y))
        End If
    End Sub

End Class
