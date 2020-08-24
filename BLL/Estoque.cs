using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
   public class Estoque
    {
        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();
        public static string instrucaoSql;

        private int _CodigoProduto;
        private int _QuantidadeAtual;
        private int _EstoqueMaximo;
        private int _EstoqueMinimo;

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

        public int QuantidadeAtual
        {
            get
            {
                return _QuantidadeAtual;
            }

            set
            {
                _QuantidadeAtual = value;
            }
        }

        public int EstoqueMaximo
        {
            get
            {
                return _EstoqueMaximo;
            }

            set
            {
                _EstoqueMaximo = value;
            }
        }

        public int EstoqueMinimo
        {
            get
            {
                return _EstoqueMinimo;
            }

            set
            {
                _EstoqueMinimo = value;
            }
        }

        public DataSet ExibirEstoque()
        {


           
                instrucaoSql = "Select tbProduto.CodigoProduto,NomeProduto,tbFornecedor.NomeFantasia as Fornecedor,tbEstoque.QuantidadeAtual as Quantidade_Atual from tbProduto INNER JOIN tbFornecedor ON tbProduto.CodigoFornecedor = tbFornecedor.CodigoFornecedor INNER JOIN tbEstoque ON tbProduto.CodigoProduto = tbEstoque.CodigoProduto  Order by tbProduto.CodigoProduto";
            
        

            return c.RetornarDataSet(instrucaoSql);


        }


        public void AtualizarEstoque()
        {

            // UPDATE produtos SET quantidade = quantidade+1 WHERE nome_produto = 'Tênis de Futebol'
            try
            {
                SqlParameter[] listaComParametros = {new SqlParameter("@CodigoProduto",SqlDbType.Int) {Value = _CodigoProduto },
                   new SqlParameter("@Quantidade",SqlDbType.Int) {Value = _QuantidadeAtual }

                };

                instrucaoSql = "UPDATE tbEstoque SET QuantidadeAtual=QuantidadeAtual+@Quantidade WHERE CodigoProduto=@CodigoProduto";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);



            }
            catch (Exception ex)
            {

                throw ex;
            }






        }

    }
}

