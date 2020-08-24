using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
   public class Nivel
    {
        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();
        private static string instrucaoSql;
        private int _CodigoNivel;
        private string _NomeNivelAcesso;
        private byte _StatusNivel;

       
        public int CodigoNivel
        {
            get
            {
                return _CodigoNivel;
            }

            set
            {
                _CodigoNivel = value;
            }
        }

        public string NomeNivelAcesso
        {
            get
            {
                return _NomeNivelAcesso;
            }

            set
            {
                _NomeNivelAcesso = value;
            }
        }

        public byte StatusNivel
        {
            get
            {
                return _StatusNivel;
            }

            set
            {
                _StatusNivel = value;
            }
        }

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@NomeNivelAcesso",SqlDbType.VarChar) {Value = _NomeNivelAcesso }

                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbNivel (NomeNivelAcesso, StatusNivel) VALUES (@NomeNivelAcesso,1)";

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
                   new SqlParameter("@NomeNivelAcesso",SqlDbType.VarChar) {Value = _NomeNivelAcesso },
                   new SqlParameter("@CodigoNivel",SqlDbType.Int) {Value = _CodigoNivel }

                };

                instrucaoSql = "UPDATE tbNivel SET NomeNivelAcesso=@NomeNivelAcesso WHERE CodigoNivel=@CodigoNivel";
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
                instrucaoSql = "UPDATE tbNivel SET StatusNivel=1   WHERE CodigoNivel=" + _CodigoNivel;
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
                instrucaoSql = "UPDATE tbNivel SET StatusNivel=0  WHERE CodigoNivel=" + _CodigoNivel;
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
                instrucaoSql = "SELECT * FROM tbNivel  WHERE CodigoNivel=" + _CodigoNivel;
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
                instrucaoSql = "SELECT * FROM tbNivel";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE NomeNivelAcesso LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
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
                instrucaoSql = "SELECT *FROM tbNivel WHERE StatusNivel=1";
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
                instrucaoSql = "SELECT *FROM tbNivel WHERE StatusNivel=0";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }








    }
}
