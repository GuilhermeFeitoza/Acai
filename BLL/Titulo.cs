using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class Titulo
    {

        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();
        public static string instrucaoSql;
        private int _CodigoTitulo;
        private String _DescricaoTitulo;
        private byte _StatusTitulo;

        public int CodigoTitulo
        {
            get
            {
                return _CodigoTitulo;
            }

            set
            {
                _CodigoTitulo = value;
            }
        }

        public string DescricaoTitulo
        {
            get
            {
                return _DescricaoTitulo;
            }

            set
            {
                _DescricaoTitulo = value;
            }
        }

        public byte StatusTitulo
        {
            get
            {
                return _StatusTitulo;
            }

            set
            {
                _StatusTitulo = value;
            }
        }


        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@DescricaoTitulo",SqlDbType.VarChar) {Value = _DescricaoTitulo }

                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbTipoTitulo (DescricaoTitulo, StatusTitulo) VALUES (@DescricaoTitulo,1)";

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
                SqlParameter[] listaComParametros = {new SqlParameter("@CodigoTitulo",SqlDbType.Int) {Value = _CodigoTitulo },
                   new SqlParameter("@DescricaoTitulo",SqlDbType.VarChar) {Value = _DescricaoTitulo }

                };

                instrucaoSql = "UPDATE tbTipoTitulo SET DescricaoTitulo=@DescricaoTitulo WHERE CodigoTitulo=@CodigoTitulo";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);



            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Ativar()
        {
            try
            {
                instrucaoSql = "UPDATE tbTipoTitulo SET StatusTitulo=1   WHERE CodigoTitulo=" + _CodigoTitulo;
                c.ExecutarComando(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Desativar()
        {
            try
            {
                instrucaoSql = "UPDATE tbTipoTitulo SET StatusTitulo=0  WHERE CodigoTitulo=" + _CodigoTitulo;
                c.ExecutarComando(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public SqlDataReader Consultar()
        {
            try
            {
                instrucaoSql = "SELECT * FROM tbTipoTitulo  WHERE CodigoTitulo=" + _CodigoTitulo;
                return c.RetornarDataReader(instrucaoSql);
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
                instrucaoSql = "SELECT * FROM tbTipoTitulo";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE DescricaoTitulo LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
                }
                return c.RetornarDataSet(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ListarAtivos()
        {
            try
            {
                instrucaoSql = "SELECT *FROM tbTipoTitulo WHERE StatusTitulo=1";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ListarInativos()
        {
            try
            {
                instrucaoSql = "SELECT *FROM tbTipoTitulo WHERE StatusTitulo=0";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }







    }
}
