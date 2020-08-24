using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Cliente
    {

        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();
        public static string instrucaoSql;

        private int _CodigoCliente;
        private string _NomeCliente;
        private string _CpfCliente;
        private string _TelefoneCliente;
        private string _EmailCliente;
        private byte _StatusCliente;

        public int CodigoCliente
        {
            get
            {
                return _CodigoCliente;
            }

            set
            {
                _CodigoCliente = value;
            }
        }

        public string NomeCliente
        {
            get
            {
                return _NomeCliente;
            }

            set
            {
                _NomeCliente = value;
            }
        }

        public string CpfCliente
        {
            get
            {
                return _CpfCliente;
            }

            set
            {
                _CpfCliente = value;
            }
        }

        public string TelefoneCliente
        {
            get
            {
                return _TelefoneCliente;
            }

            set
            {
                _TelefoneCliente = value;
            }
        }

        public string EmailCliente
        {
            get
            {
                return _EmailCliente;
            }

            set
            {
                _EmailCliente = value;
            }
        }

        public byte StatusCliente
        {
            get
            {
                return _StatusCliente;
            }

            set
            {
                _StatusCliente = value;
            }
        }

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@Nome",SqlDbType.VarChar) {Value = _NomeCliente },
                   new  SqlParameter("@Telefone",SqlDbType.VarChar) {Value = _TelefoneCliente },
                     new  SqlParameter("@Cpf",SqlDbType.VarChar) {Value = _CpfCliente },
                   new SqlParameter("@Email",SqlDbType.VarChar) {Value = _EmailCliente },
                   new SqlParameter("@StatusCliente",SqlDbType.Int) {Value = _StatusCliente }

                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbCliente (NomeCliente, TelefoneCliente,CpfCliente, EmailCliente,StatusCliente) VALUES (@Nome, @Telefone,@Cpf, @Email,@StatusCliente)";
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
                SqlParameter[] listaComParametros = {new SqlParameter("@CodigoCliente",SqlDbType.Int) {Value = _CodigoCliente },
                     new SqlParameter("@Nome",SqlDbType.VarChar) {Value = _NomeCliente },
                   new  SqlParameter("@Telefone",SqlDbType.VarChar) {Value = _TelefoneCliente },
                    new  SqlParameter("@Cpf",SqlDbType.VarChar) {Value = _CpfCliente },
                    new SqlParameter("@Email",SqlDbType.VarChar) {Value = _EmailCliente },
                   new SqlParameter("@StatusCliente",SqlDbType.Int) {Value = _StatusCliente }
                    };


                instrucaoSql = "UPDATE tbCliente SET NomeCliente=@Nome,TelefoneCliente=@Telefone,EmailCliente=@Email,StatusCliente=@StatusCliente,CpfCliente=@Cpf WHERE CodigoCliente=@CodigoCliente";
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
                instrucaoSql = "UPDATE tbCliente SET StatusCliente=1   WHERE CodigoCliente=" + _CodigoCliente;
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
                instrucaoSql = "UPDATE tbCliente SET StatusCliente=0  WHERE CodigoCliente=" + _CodigoCliente;
                c.ExecutarComando(instrucaoSql);
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
                instrucaoSql = "DELETE FROM tbCliente  WHERE CodigoCliente=" + _CodigoCliente;
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
                instrucaoSql = "SELECT * FROM tbCliente  WHERE CodigoCliente=" + _CodigoCliente;
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
                instrucaoSql = "SELECT * FROM tbCliente";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE Nome LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
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
                instrucaoSql = "SELECT CodigoCliente, Nome, StatusCliente FROM tbCliente WHERE StatusCliente=1";
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
                instrucaoSql = "SELECT CodigoCliente, Nome, StatusCliente FROM tbCliente WHERE StatusCliente=0";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
















    }
}
