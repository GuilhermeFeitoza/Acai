using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace DAO
{
    public class ClasseParaManipularBancoDeDados
    {
        private static SqlConnection cn;
        //criar um objeto cn que representa a classe de conexao ao banco de dados sql server; Esse objeto irá precisar uma string de conexao ao banco de dados - caminho/pasta/endereço do banco de dados;
        private static SqlCommand cmd;
        //criar objeto cmd que irá executar as instruçoes (insert, update, delete) no banco de dados; Essas instruções podem ser strings (texto) ou procedimentos armazenados no banco de dados (stored procedures -> se fizermos esse uso será necessário criar parametros). Stored procedure é uma ´programação´ dentro do banco de dados.
        private static SqlDataAdapter da;
        //criar objeto da que representa a ligação (ponte) mundo conectado (banco de dados) com o desconectado (RAM)
        private static SqlDataReader dr;
        //criar objeto dr que representa um leitor de dados. usado para 1. ler rapidamente uma tabela no banco de dados para transferir o conteudo para um COMBOBOX OU LISTBOX    2. ler UUUMMMMAAAA linha de dados de uma tabela. ideal para fazer uma consulta (cenário CONSULTAR[saber] o endereço do aluno LUCIO rm 27056   e exibir em TEXTBOXs)
        private static DataSet ds;
        //criar objeto ds que representa as tabelas de um banco de dados na memória RAM. Pode conter todas as tabelas, uma ou nenhuma tabela. Para existir um DATASET é necessário um DATAADAPTER e para existir um DataAdapter é necessário um COMMAND e para existir um Command é necessário uma CONNECTION
        private static DataTable dt;
        //criar objeto dt que representa uma tabela de dados. Para existir um DATATABLE -> DataAdapter + Command + Connection
        private static string instrucaoSql;
        //a variavel INSTRUCAOSQL representa o texto do comando em linguagem Sql para INSERIR, ALTERAR, EXCLUIR, etc. os dados em uma tabela
        private static string stringConexao = "server=P3L3M08\\SQLEXPRESS;database=Acai;user id=sa;password=123456;";
        //Casa string = DESKTOP-5IDO44G
        //a variável STRINGCONEXAO é um texto onde informo o nome do servidor de banco de dados, o nome do banco de dados, o usuario que gerencia o banco de dados e a senha deste usuario; no site connectionstrings.com você pode saber mais sobre as diferentes variacoes de strings. De modo bem simples a string de conexao com o banco representa o caminho até o banco de dados
        public static SqlConnection ConectarBanco()
        {  
            try
            {
                cn = new SqlConnection(stringConexao);
                //faço a instância do objeto CN usando a variável STRINGCONEXAO como um parametro da classe SQLCONNECTION
                //Pergunta do aluno - Prooo como eu sei que é instância? 
                //quando na linha de código você tem = new
                //instanciar algo é 'fazer uma cópia'
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                //teste para saber o estado da conexão.Se o estado é fechado a conexão é aberta
                return cn;
                //retorna a conexão ... que nesse momento está aberta


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void FecharBanco(SqlConnection minhaConexao)
        {
            try
            {
                if (minhaConexao.State  ==  ConnectionState.Open)
                {
                    minhaConexao.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void FecharBanco2()
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void ExecutarComando(string meuComando)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(meuComando, cn);
                cmd.ExecuteReader();
                //= new    INSTANCIAR    COPIA
                //Execute o comando. para executar o comando é necessario o meuComando e uma conexao cn
                //o objeto 'cmd' tem tres metodos que  serão utilizados     (1)ExecuteScalar para totalizar/sumarizar dados em uma tabela.  'meuComando' conterá as funções de agrupamento  Min()  Max() Count()  Sum(). Convém lembrar que o resultado da execução deste método é uma UNICA COLUNA com UMA UNICA LINHA DE DADOS     (2)ExecuteNonQuery é utilizado para executar comandos de INSERT, UPDATE e DELETE na tabela     (3)ExecuteReader para selecionar (SELECT)   dados da tabela que podem ser 0 linha ou várias linha de dados

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int RetornarExecuteScalar(string meuComandoSql)
        {
            try
            {
                cmd = new SqlCommand(meuComandoSql, ConectarBanco());
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {

                throw ex;
            } }

        public SqlDataReader RetornarDataReader(string meuComandoSql)
        {
            try
            {
                cmd = new SqlCommand(meuComandoSql, ConectarBanco());
                dr = cmd.ExecuteReader();
                return dr;
                //esse metodo terá como retorno uma listagem dos dados da tabela

            }
            catch (Exception ex)
            {

                throw ex;
            } }

        public DataTable RetornarDataTable(string meuComandoSql)
        {
            try
            {
                dt = new DataTable();
                cmd = new SqlCommand(meuComandoSql, ConectarBanco());
                da = new SqlDataAdapter(cmd);
                da.Fill(dt); //o objeto 'da' preenche (FILL) o objeto 'dt' com as linhas de dados de UUUUUUMMMMMAAAAA tabela. O número de linhas podem ser 0 ou VAAARRRRIIIIAAAASSSS
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet RetornarDataSet(string meuComandoSql)
        {
            try
            {
                ds = new DataSet();
                ds.EnforceConstraints = false;//pode deixar operação  mais rápida
                cmd = new SqlCommand(meuComandoSql, ConectarBanco());
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int RetornarContagem(string meuComandoSql)
        {
            try
            {
                cmd = new SqlCommand(meuComandoSql, ConectarBanco());
                //objeto 'cmd' instanciado '= new'com o comando em sql que contém a função COUNT para contar o número de linhas em uma tabela de dados (AULA LIEC)
                return Convert.ToInt32(cmd.ExecuteScalar());
                //Convert.ToInt32 - converte o resultado do método 'executescalar' para um número inteiro de 32 bits
                //lembre-se esse método é para responder sobre quantidade. Quantos alunos temos na turma INF2DM? Resp.33    Quantos alunos da turma INF2DM tem o nome iniciado pela letra Z? Resp. 0

            }
            catch (Exception ex)
            {

                throw ex;
            } }

        public double RetornarTotal(string meuComandoSql)
        {
            try
            {
                cmd = new SqlCommand(meuComandoSql, ConectarBanco());
                return Convert.ToDouble(cmd.ExecuteScalar());
                //esse método usa um comando em Sql que faz a soma dos valores em um coluna da tabela. Qual a soma total de salários dos professores do itb? Resp. 115453,22

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public double RetornarMenorValor(string meuComandoSql)
        {
            try
            {
                cmd = new SqlCommand(meuComandoSql, ConectarBanco());
                //'meucomandosql' contém uma instrução com a função MIN ... aula de LIEC
                return Convert.ToDouble(cmd.ExecuteScalar());
                //esse método serve para saber o menor valor em uma coluna. Por exemplo: Qual a menor nota do aluno Breno no 1º trimestre?  Resp. 3,6
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public double RetornarMaiorValor(string meuComandoSql)
        {
            try
            {
                cmd = new SqlCommand(meuComandoSql, ConectarBanco());
                return Convert.ToDouble(cmd.ExecuteScalar());
                //'meucomandoSql' tem uma instrução MAX... aula de LIEC     esse método funciona para saber o maior valor em uma coluna de dados.  Exemplo: Qual é a maior nota do aluno Brenno no 2º trimestre?  Resp. 8,2
            }
            catch (Exception ex)
            {

                throw ex;
            } }

        public int RecuperarUltimoCodigoNumeracaoAutomatica(string meuComandoSql)
        {
            try
            {
                //Nesse método a entrada 'meucomandosql' contém uma instrução para inserir dados na tabela 'INSERT' aula de LIEC. A ideia aqui é recuperar o código da númeração automática quando inserimos uma linha na tabela
                cmd = new SqlCommand(meuComandoSql, ConectarBanco());
                //objeto 'cmd' instanciado '=new' com a variavel 'meucomandosql'
                cmd.ExecuteNonQuery();
                //objeto 'cmd' executa o comando para inserir a linha de dados
                cmd.CommandText = "SELECT @@Identity";
                //a propriedade texto do comando recebe a instrução para selecionar a autonumeração (aula LIEC)
                dr = cmd.ExecuteReader();
                //objeto 'dr' recebe do comando o resultado da leitura da execução do comando 'select @@identity'
                dr.Read();
                //objeto 'dr' faz a leitura
                return Convert.ToInt32(dr[0]);
                //retorna o código que está na coluna '0' que representa a numeração automatica

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public SqlParameter criarParametro(string nomeParametro, SqlDbType tipoParametro, object valorParametro)
        {
            try
            {
                //esse método possui 3 assinaturas: 'nomeParametro'...nome da variável  + 'tipoparametro'...tipo de dado da variavel + 'valorparametro'... valor da variável
                SqlParameter p = new SqlParameter();
                //criar objeto 'p'
                p.ParameterName = nomeParametro;
                p.SqlDbType = tipoParametro;
                //testar para valor nulo do parametro
                if ((valorParametro == null) || (tipoParametro == SqlDbType.Char && valorParametro.ToString().Length == 0))
                {
                    p.Value = DBNull.Value;
                    //propriedade 'value' do objeto 'p' recebe o valor nulo da classe 'dbnull'
                }
                else
                {
                    p.Value = valorParametro;
                }
                return p;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ExecutarComandoStoredProcedure(string nomeProcedure, SqlParameter[] listaParametros)
        {
            try
            {
                //esse método tem 2 assinaturas 'nomeprocedure' que representa o nome do programa feito dentro do banco de dados     e  a 'listaparametros' que são as variáveis usadas nesse programa feito no banco de dados
                cmd = new SqlCommand();
                cmd.CommandText = nomeProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                //testar a 'listaparametros' para ver se  não é nula, ou seja, foi informado algo para a lista
                if (listaParametros != null)
                {
                    foreach (SqlParameter item in listaParametros)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                cmd.Connection = ConectarBanco();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            } }

        public void ExecutarComandoParametro(string meuComandoSql, SqlParameter[] listaParametros)
        {
            try
            {
                //esse método tem 2 assinaturas 'nomeprocedure' que representa o nome do programa feito dentro do banco de dados     e  a 'listaparametros' que são as variáveis usadas nesse programa feito no banco de dados
                cmd = new SqlCommand();
                cmd.CommandText = meuComandoSql;
                cmd.CommandType = CommandType.Text;
                //testar a 'listaparametros' para ver se  não é nula, ou seja, foi informado algo para a lista
                if (listaParametros != null)
                {
                    foreach (SqlParameter item in listaParametros)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                cmd.Connection = ConectarBanco();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }






        //https://bit.ly/2Ky6um1   dois datagridview  pai-filhoS






    }
}
