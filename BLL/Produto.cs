using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Produto
    {
        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();
        public static string instrucaoSql;

        private int _CodigoProduto;
        private string _NomeProduto;
        private int _CodigoUnidade;
        private decimal _ValorProduto;
        private string _Categoria;
       
        private int _CodigoFornecedor;
        private DateTime _DataFabricacao;
        private DateTime _DataValidade;
        private DateTime _DataEntrada;
        private byte _StatusProduto;


        private int _Quantidade;
        public int CodigoProduto
        {
            get
            {
                return _CodigoProduto;
            }

            set
            {
                _CodigoProduto = value;
            }
        }

        public string NomeProduto
        {
            get
            {
                return _NomeProduto;
            }

            set
            {
                _NomeProduto = value;
            }
        }

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

        public decimal ValorProduto
        {
            get
            {
                return _ValorProduto;
            }

            set
            {
                _ValorProduto = value;
            }
        }

       

        
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

        public DateTime DataFabricacao
        {
            get
            {
                return _DataFabricacao;
            }

            set
            {
                _DataFabricacao = value;
            }
        }

        public DateTime DataValidade
        {
            get
            {
                return _DataValidade;
            }

            set
            {
                _DataValidade = value;
            }
        }

        public DateTime DataEntrada
        {
            get
            {
                return _DataEntrada;
            }

            set
            {
                _DataEntrada = value;
            }
        }

        public byte StatusProduto
        {
            get
            {
                return _StatusProduto;
            }

            set
            {
                _StatusProduto = value;
            }
        }

        public string Categoria
        {
            get
            {
                return _Categoria;
            }

            set
            {
                _Categoria = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return _Quantidade;
            }

            set
            {
                _Quantidade = value;
            }
        }

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametro =
                {
                    new SqlParameter("@NomeProduto",SqlDbType.VarChar) {Value = _NomeProduto },
                    new SqlParameter("@CodigoUnidade",SqlDbType.Int) {Value = _CodigoUnidade },
                    new SqlParameter("@ValorProduto",SqlDbType.Money) {Value = _ValorProduto },
                    new SqlParameter("@Categoria",SqlDbType.VarChar) {Value = _Categoria },
                    new SqlParameter("@CodigoFornecedor",SqlDbType.Int) {Value = _CodigoFornecedor },
                    new SqlParameter("@DataFabricacao",SqlDbType.DateTime) {Value = _DataFabricacao },
                    new SqlParameter("@DataValidade",SqlDbType.DateTime) {Value = _DataValidade },
                    new SqlParameter("@DataEntrada",SqlDbType.DateTime) {Value = _DataEntrada },
                    new SqlParameter("@StatusProduto",SqlDbType.Bit) {Value = _StatusProduto }
                };
                //Criar o Objeto 'listarComParametro' a partir da classe 'SqlParameter' definida como uma lista'[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros. Cada parametro foi definido com a identificação '@.....' + um tipo de dado' SqlDbType' + um valor '{Value = _....}'
                instrucaoSql = "INSERT INTO tbProduto (NomeProduto, CodigoUnidade, ValorProduto,CodigoFornecedor ,DataFabricacao , DataValidade, DataEntrada, StatusProduto, Categoria) Values (@NomeProduto, @CodigoUnidade,@ValorProduto,@CodigoFornecedor ,@DataFabricacao ,@DataValidade, @DataEntrada, @StatusProduto, @Categoria)";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametro);


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
                instrucaoSql = "UPDATE tbProduto SET StatusProduto = 0  WHERE CodigoProduto=" + _CodigoProduto;
                c.ExecutarComando(instrucaoSql);
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
                instrucaoSql = "UPDATE tbProduto SET StatusProduto =1   WHERE CodigoProduto=" + _CodigoProduto;
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
                instrucaoSql = "SELECT * FROM tbProduto";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE NomeProduto LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
                }
                return c.RetornarDataSet(instrucaoSql);

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
                instrucaoSql = "SELECT * FROM tbProduto  WHERE CodigoProduto=" + _CodigoProduto;
                return c.RetornarDataReader(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public SqlDataReader ListarProdComQuant(int Codigo, byte tipostatus)
        {


            instrucaoSql = "SELECT CodigoProduto,NomeProduto,ValorProduto FROM tbProduto where CodigoProduto = " + Codigo;
            return c.RetornarDataReader(instrucaoSql);



        }






        public void Alterar()
        {
            try
            {
                SqlParameter[] listaComParametro =
                {  new SqlParameter("@Codigoproduto",SqlDbType.Int) {Value = _CodigoProduto },
                    new SqlParameter("@NomeProduto",SqlDbType.VarChar) {Value = _NomeProduto },
                    new SqlParameter("@CodigoUnidade",SqlDbType.Int) {Value = _CodigoUnidade },
                    new SqlParameter("@ValorProduto",SqlDbType.Money) {Value = _ValorProduto },
                    new SqlParameter("@Categoria",SqlDbType.VarChar) {Value = _Categoria },
                    new SqlParameter("@CodigoFornecedor",SqlDbType.Int) {Value = _CodigoFornecedor },
                    new SqlParameter("@DataFabricacao",SqlDbType.DateTime) {Value = _DataFabricacao },
                    new SqlParameter("@DataValidade",SqlDbType.DateTime) {Value = _DataValidade },
                    new SqlParameter("@DataEntrada",SqlDbType.DateTime) {Value = _DataEntrada },
                    new SqlParameter("@StatusProduto",SqlDbType.Bit) {Value = _StatusProduto }
                };
                //Criar o Objeto 'listarComParametro' a partir da classe 'SqlParameter' definida como uma lista'[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros. Cada parametro foi definido com a identificação '@.....' + um tipo de dado' SqlDbType' + um valor '{Value = _....}'
                instrucaoSql = "UPDATE tbProduto SET NomeProduto=@NomeProduto,CodigoUnidade=@CodigoUnidade,ValorProduto=@ValorProduto,Categoria=@Categoria,CodigoFornecedor=@CodigoFornecedor,DataFabricacao=@DataFabricacao,DataValidade=@DataValidade,DataEntrada=@DataEntrada WHERE CodigoProduto=" + _CodigoProduto;
                c.ExecutarComandoParametro(instrucaoSql, listaComParametro);


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public int RetornarProduto()
        {
            try
            {
                instrucaoSql = "Select max(CodigoProduto)from tbProduto";
                return c.RetornarExecuteScalar(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




        public void NovoEstoque()
        {

            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoProduto",SqlDbType.Int) {Value = RetornarProduto() },
                   new SqlParameter("@Quantidade",SqlDbType.Int) {Value = Quantidade }


                };

                instrucaoSql = "INSERT INTO tbEstoque (CodigoProduto, QuantidadeAtual) VALUES (@CodigoProduto, @Quantidade)";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }



    }
}
