using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class Venda
    {

        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();
        private static string instrucaoSql;
        private int _CodigoVenda;
        private DateTime _DataVenda;
        private Decimal _ValorTotal;
        private byte _StatusVenda;
        private int _CodigoCliente;
        

        public static string InstrucaoSql
        {
            get
            {
                return instrucaoSql;
            }

            set
            {
                instrucaoSql = value;
            }
        }

        public int CodigoVenda
        {
            get
            {
                return _CodigoVenda;
            }

            set
            {
                _CodigoVenda = value;
            }
        }

        public DateTime DataVenda
        {
            get
            {
                return _DataVenda;
            }

            set
            {
                _DataVenda = value;
            }
        }

        public byte StatusVenda
        {
            get
            {
                return _StatusVenda;
            }

            set
            {
                _StatusVenda = value;
            }
        }

        public decimal ValorTotal
        {
            get
            {
                return _ValorTotal;
            }

            set
            {
                _ValorTotal = value;
            }
        }

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

        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@CodigoCliente",SqlDbType.Int) {Value = CodigoCliente },
                   new SqlParameter("@DataVenda",SqlDbType.DateTime) {Value = _DataVenda },
                   new SqlParameter("@ValorTotal",SqlDbType.Decimal) {Value = _ValorTotal }
               
                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbVenda (CodigoCliente,DataVenda, ValorTotal) VALUES (@CodigoCliente, @DataVenda, @ValorTotal)";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet ListarVendas(string parteNome)
        {
            try
            {
                instrucaoSql = " SELECT tbVenda.CodigoVenda,tbVenda.ValorTotal,tbVenda.DataVenda, Cliente.CodigoCliente, Cliente.NomeCliente As  Nome_cliente FROM tbCliente as Cliente INNER JOIN tbVenda ON tbVenda.CodigoCliente = Cliente.CodigoCliente   Order by CodigoVenda";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE Cliente.Nome LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
                }
                return c.RetornarDataSet(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public int RetornarVenda()
        {
            try
            {
                instrucaoSql = "Select max(CodigoVenda)from tbVenda";
                return c.RetornarExecuteScalar(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




        public DataSet ListarItensVenda(int CodigoVenda)
        {

            try
            {

                instrucaoSql = "SELECT tbItem_Venda.CodigoProduto , tbProduto.NomeProduto, ValorProduto FROM tbVenda  INNER JOIN tbItem_Venda ON tbVenda.CodigoVenda=tbItem_Venda.CodigoVenda INNER JOIN tbProduto  ON tbItem_Venda.CodigoProduto = tbProduto.CodigoProduto   WHERE  tbVenda.CodigoVenda = " + CodigoVenda;
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }









    }
}
