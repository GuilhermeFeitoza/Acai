using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Unidade
    {
        public static string instrucaoSql;

        private int _CodigoUnidade;
        private string _NomeUnidade;
        private string _Abreviacao;


        


        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();

        public int CodigoUnidade
        {
            get
            {
                return _CodigoUnidade;
            }

            set
            {
                _CodigoUnidade = value;
            }
        }

        public string NomeUnidade
        {
            get
            {
                return _NomeUnidade;
            }

            set
            {
                _NomeUnidade = value;
            }
        }

        public string Abreviacao
        {
            get
            {
                return _Abreviacao;
            }

            set
            {
                _Abreviacao = value;
            }
        }

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoUnidade",SqlDbType.Int) {Value = CodigoUnidade },
                   new SqlParameter("@NomeUnidade",SqlDbType.VarChar) {Value = NomeUnidade },
                   new SqlParameter("@Abreviacao",SqlDbType.Char) {Value = _Abreviacao },
                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbUnidade ( NomeUnidade, Abreviacao) VALUES ( @NomeUnidade, @Abreviacao)";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AlterarComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoUnidade",SqlDbType.Int) {Value = CodigoUnidade },
                   new SqlParameter("@NomeUnidade",SqlDbType.VarChar) {Value = NomeUnidade },
                   new SqlParameter("@Abreviacao",SqlDbType.Char) {Value = _Abreviacao }
                };

                instrucaoSql = "UPDATE tbUnidade SET NomeUnidade=@NomeUnidade, Abreviacao=@Abreviacao, WHERE CodigoUnidade=@CodigoUnidade";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);



            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Excluir()
        {
            try
            {
                instrucaoSql = "DELETE FROM tbUnidade  WHERE CodigoUnidade=" + CodigoUnidade;
                c.ExecutarComando(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Listar(string parteNome, byte tipostatus)
        {
            try
            {
                instrucaoSql = "SELECT * FROM tbUnidade";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE NomeUnidade LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
                }
                return c.RetornarDataSet(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }














    }
}
