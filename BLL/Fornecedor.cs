using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class Fornecedor
    {

        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();
        private static string instrucaoSql;
        private int _CodigoFornecedor;
        private string _RazaoSocial;
        private string _NomeFantasia;
        private string _CEP;
        private string _Numero;
        private string _Complemento;
        private byte _StatusFornecedor;

        
        public int CodigoFornecedor
        {
            get
            {
                return _CodigoFornecedor;
            }

            set
            {
                _CodigoFornecedor = value;
            }
        }

        public string RazaoSocial
        {
            get
            {
                return _RazaoSocial;
            }

            set
            {
                _RazaoSocial = value;
            }
        }

        public string NomeFantasia
        {
            get
            {
                return _NomeFantasia;
            }

            set
            {
                _NomeFantasia = value;
            }
        }

        public string CEP
        {
            get
            {
                return _CEP;
            }

            set
            {
                _CEP = value;
            }
        }

        public string Numero
        {
            get
            {
                return _Numero;
            }

            set
            {
                _Numero = value;
            }
        }

        public string Complemento
        {
            get
            {
                return _Complemento;
            }

            set
            {
                _Complemento = value;
            }
        }

        public byte StatusFornecedor
        {
            get
            {
                return _StatusFornecedor;
            }

            set
            {
                _StatusFornecedor = value;
            }
        }


        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                  new SqlParameter("@RazaoSocial",SqlDbType.VarChar) {Value = _RazaoSocial },
                  new SqlParameter("@NomeFantasia",SqlDbType.VarChar) {Value = _NomeFantasia },
                  new SqlParameter("@CEP",SqlDbType.VarChar) {Value = _CEP },
                  new SqlParameter("@Numero",SqlDbType.VarChar) {Value = _Numero },
                  new SqlParameter("@Complemento",SqlDbType.VarChar) {Value = _Complemento },
                  new SqlParameter("@StatusFornecedor",SqlDbType.Bit) {Value = _StatusFornecedor }

                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbFornecedor (RazaoSocial, NomeFantasia,CEP,Numero,Complemento,StatusFornecedor) VALUES (@RazaoSocial, @NomeFantasia,@CEP,@Numero,@Complemento,@StatusFornecedor)";
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
                  new SqlParameter("@CodigoFornecedor",SqlDbType.Int) {Value = _CodigoFornecedor },
                  new SqlParameter("@RazaoSocial",SqlDbType.VarChar) {Value = _RazaoSocial },
                  new SqlParameter("@NomeFantasia",SqlDbType.VarChar) {Value = _NomeFantasia },
                  new SqlParameter("@CEP",SqlDbType.VarChar) {Value = _CEP },
                  new SqlParameter("@Numero",SqlDbType.VarChar) {Value = _Numero },
                  new SqlParameter("@Complemento",SqlDbType.VarChar) {Value = _Complemento },
                  new SqlParameter("@StatusFornecedor",SqlDbType.Bit) {Value = _StatusFornecedor }

                };


                instrucaoSql = "UPDATE tbFornecedor SET RazaoSocial=@RazaoSocial,@NomeFantasia=@NomeFantasia,CEP=@CEP,Numero=@Numero,Complemento =@Complemento WHERE CodigoFornecedor=@CodigoFornecedor";
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
                instrucaoSql = "UPDATE tbFornecedor SET StatusFornecedor=1   WHERE CodigoFornecedor=" + _CodigoFornecedor;
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
                instrucaoSql = "UPDATE tbFornecedor SET StatusFornecedor=0  WHERE CodigoFornecedor=" + _CodigoFornecedor;
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
                instrucaoSql = "SELECT * FROM tbFornecedor  WHERE CodigoFornecedor=" + _CodigoFornecedor;
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
                instrucaoSql = "SELECT * FROM tbFornecedor";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE NomeFornecedor LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
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
                instrucaoSql = "SELECT *FROM tbForncedor WHERE StatusForncedor=1";
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
                instrucaoSql = "SELECT *FROM tbForncedor WHERE StatusForncedor=0";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }














    }
}
