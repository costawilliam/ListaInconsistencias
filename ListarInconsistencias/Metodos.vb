Imports System.IO
Imports System.Data
Imports System.Data.OleDb


Public Class Metodos

    Public Function CriaStringConexaoAccess(Caminho As String) As String
        Dim StringConexao As String
        If (Caminho = "") Then
            If Not System.IO.File.Exists(Application.StartupPath & "\psec.dat") Then
                StringConexao = ""
            Else
                StringConexao = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" & Application.StartupPath & "\psec.dat"
            End If
        Else
            StringConexao = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" & Caminho
        End If
        Return StringConexao
    End Function

    Public Function Querys(tipo As String)
        If (tipo = "Funcionarios") Then
            Return "select id, nome, admissao, demissao, afast_data_ini, afast_data_fim, expedicao, nascimento, alt_data, provisorio_data_ini, provisorio_data_fim,  data_alteracao_portaria ,  web_data_fechamento, bh_inicio from funcionarios where admissao not between #01-01-1900# and #06-06-2079# or demissao not between #01-01-1900# and #06-06-2079# or afast_data_ini not between #01-01-1900# and #06-06-2079# or afast_data_fim not between #01-01-1900# and #06-06-2079# or expedicao not between #01-01-1900# and #06-06-2079# or nascimento not between #01-01-1900# and #06-06-2079# or alt_data not between #01-01-1900# and #06-06-2079# or provisorio_data_ini not between #01-01-1900# and #06-06-2079# or provisorio_data_fim not between #01-01-1900# and #06-06-2079# or data_alteracao_portaria not between #01-01-1900# and #06-06-2079# or web_data_fechamento not between #01-01-1900# and #06-06-2079# or bh_inicio not between #01-01-1900# and #06-06-2079# or admissao>demissao or afast_data_ini>afast_data_fim or provisorio_data_ini>provisorio_data_fim"
        ElseIf (tipo = "Batidas") Then
            Return "select b.id, b.data, f.nome, b.entrada1, b.saida1, b.entrada2, b.saida2, b.entrada3, b.saida3, b.entrada4, b.saida4, b.entrada5, b.saida5 from batidas b left join funcionarios f on b.funcionario_id = f.id where b.data not between #01-01-1900# and #06-06-2079# "
        ElseIf (tipo = "Usuarios") Then
            Return "select id, nome, validade_entrada from usuarios where validade_entrada not between #01-01-1900# and #06-06-2079#"
        ElseIf (tipo = "Justificativas") Then
            Return "select f.nome, j.data_inicio, j.data_fim, ju.nome, j.obs from ((justificativas_lancadas j left join justificativas ju on ju.id = j.justificativa_id) left join funcionarios f on f.id = j.funcionario_id) where j.data_inicio not between #01-01-1900# and #06-06-2079# or j.data_fim not between #01-01-1900# and #06-06-2079#"
        ElseIf (tipo = "Calculos") Then
            Return "select c.id, c.data, f.nome, c.btotal, c.bajuste, c.bajuste_obs from calculos c left join funcionarios f on f.id = c.funcionario_id where c.data not between #01-01-1900# and #06-06-2079#"
        ElseIf (tipo = "Fiscais") Then
            Return "select f.id, f.nsr,  f.data, f.hora, e.descricao, fu.nome, f.funcionario_pis, f.tipo_registro, f.motivo from ((fonte_dados f left join funcionarios fu on fu.id = f.funcionario_id) left join equipamentos e on e.id = f.equipamento_id) where f.data not between #01-01-1900# and #06-06-2079#"
        ElseIf (tipo = "Fiscais-Delete") Then
            Return "delete from fonte_dados where data not between #01-01-1900# and #06-06-2079#"
        ElseIf (tipo = "registros_funcoes") Then
            Return "select rf.id, f.nome, ef.descricao, rf.data, rf.hora from ((registros_funcoes rf inner join equipamentos_funcoes ef on ef.id = rf.funcao_id) inner join funcionarios f on f.id = rf.funcionario_id) where rf.data not between #01-01-1900# and #06-06-2079#"
        ElseIf (tipo = "registro_eventos") Then
            Return "select er.id, e.descricao, f.nome, er.data, er.obs, er.quantidade, er.unidade, er.total from ((eventos_registros er inner join funcionarios f on f.id = er.funcionario_id) inner join eventos e on e.id = er.evento_id) where er.data not between #01-01-1900# and #06-06-2079#"
        End If
    End Function


    Public Function Selecionar(query As String, stringconex As String) As DataTable
        Try

            Using conexao As New OleDbConnection
                conexao.ConnectionString = stringconex
                conexao.Open()

                Dim tabela As New DataTable

                Using comando As New OleDbCommand
                    comando.Connection = conexao
                    comando.CommandText = query

                    Using leitor = comando.ExecuteReader
                        tabela.Load(leitor)
                    End Using

                End Using
                Return tabela
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function DeletarInformacoes(query As String, stringconex As String) As String

        Try
            Using conexao As New OleDbConnection
                conexao.ConnectionString = stringconex
                conexao.Open()
                Using comando As New OleDbCommand
                    comando.Connection = conexao
                    comando.CommandText = query
                    comando.ExecuteNonQuery()
                End Using
            End Using
            Return "OK"
        Catch ex As Exception
            Return "Erro ao excluir informações: " & ex.Message
        End Try

    End Function


End Class
