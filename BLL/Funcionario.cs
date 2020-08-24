using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class Funcionario
    {


        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();
        public static string instrucaoSql;

        private int _CodigoFuncionario;
        private string _NomeFuncionario;
        private string _CpfFuncionario;
        private string _TelefoneFuncionario;
        private int _CodigoCargo;
        private byte _StatusFuncionario;

        public int CodigoFuncionario
        {
            get
            {
                return _CodigoFuncionario;
            }

            set
            {
                _CodigoFuncionario = value;
            }
        }

        public string NomeFuncionario
        {
            get
            {
                return _NomeFuncionario;
            }

            set
            {
                _NomeFuncionario = value;
            }
        }

        public string CpfFuncionario
        {
            get
            {
                return _CpfFuncionario;
            }

            set
            {
                _CpfFuncionario = value;
            }
        }

        public string TelefoneFuncionario
        {
            get
            {
                return _TelefoneFuncionario;
            }

            set
            {
                _TelefoneFuncionario = value;
            }
        }

        public int CodigoCargo
        {
            get
            {
                return _CodigoCargo;
            }

            set
            {
                _CodigoCargo = value;
            }
        }

        public byte StatusFuncionario
        {
            get
            {
                return _StatusFuncionario;
            }

            set
            {
                _StatusFuncionario = value;
            }
        }




        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@NomeFuncionario",SqlDbType.VarChar) {Value = _NomeFuncionario },
                   new  SqlParameter("@CpfFuncionario",SqlDbType.VarChar) {Value = _CpfFuncionario },
                   new SqlParameter("@TelefoneFuncionario",SqlDbType.VarChar) {Value = _TelefoneFuncionario },
                   new SqlParameter("@CodigoCargo",SqlDbType.Int) {Value = _CodigoCargo },
                    new SqlParameter("@StatusFuncionario",SqlDbType.Bit) {Value = _StatusFuncionario }

                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbFuncionario (NomeFuncionario, CpfFuncionario, TelefoneFuncionario,CodigoCargo,StatusFuncionario) VALUES (@NomeFuncionario, @CpfFuncionario, @TelefoneFuncionario,@CodigoCargo,@StatusFuncionario)";
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
                    new SqlParameter("@CodigoFuncionario",SqlDbType.VarChar) {Value = _CodigoFuncionario },
                    new SqlParameter("@NomeFuncionario",SqlDbType.VarChar) {Value = _NomeFuncionario },
                   new  SqlParameter("@CpfFuncionario",SqlDbType.VarChar) {Value = _CpfFuncionario },
                   new SqlParameter("@TelefoneFuncionario",SqlDbType.VarChar) {Value = _TelefoneFuncionario },
                   new SqlParameter("@CodigoCargo",SqlDbType.Int) {Value = _CodigoCargo },
                    new SqlParameter("@StatusFuncionario",SqlDbType.Bit) {Value = _StatusFuncionario }

                };

                instrucaoSql = "UPDATE tbFuncionario SET NomeFuncionario=@NomeFuncionario,CpfFuncionario=@CpfFuncionario,TelefoneFuncionario=@TelefoneFuncionario,CodigoCargo=@CodigoCargo,StatusFuncionario=@StatusFuncionario WHERE CodigoFuncionario=@CodigoFuncionario";
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
                instrucaoSql = "UPDATE tbFuncionario SET StatusFuncionario=1   WHERE CodigoFuncionario=" + _CodigoFuncionario;
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
                instrucaoSql = "UPDATE tbFuncionario SET StatusFuncionario=0   WHERE CodigoFuncionario=" + _CodigoFuncionario;
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
                instrucaoSql = "SELECT * FROM tbFuncionario  WHERE CodigoFuncionario=" + _CodigoFuncionario;
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
                instrucaoSql = "SELECT * FROM tbFuncionario";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE NomeFuncionario LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
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
                instrucaoSql = "SELECT * FROM tbFuncionario WHERE StatusFuncionario=1";

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
                instrucaoSql = "SELECT * FROM tbFuncionario WHERE StatusFuncionario=0";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




















    }






}
