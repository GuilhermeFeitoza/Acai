using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace BLL
{
    public class Conta
    {
        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();
       public static string instrucaoSql;
       private int _CodigoConta;
       private int _CodigoTitulo;
       private DateTime _DataVencimento;
       private decimal _ValorConta;
       private byte _StatusPagTitulo;
       private DateTime _DataPagamento;
       private decimal _ValorPagamento;
       private int _CodigoUsuario;

        public int CodigoConta
        {
            get
            {
                return _CodigoConta;
            }

            set
            {
                _CodigoConta = value;
            }
        }

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

        public DateTime DataVencimento
        {
            get
            {
                return _DataVencimento;
            }

            set
            {
                _DataVencimento = value;
            }
        }

        public decimal ValorConta
        {
            get
            {
                return _ValorConta;
            }

            set
            {
                _ValorConta = value;
            }
        }

        public byte StatusPagTitulo
        {
            get
            {
                return _StatusPagTitulo;
            }

            set
            {
                _StatusPagTitulo = value;
            }
        }

        public DateTime DataPagamento
        {
            get
            {
                return _DataPagamento;
            }

            set
            {
                _DataPagamento = value;
            }
        }

        public decimal ValorPagamento
        {
            get
            {
                return _ValorPagamento;
            }

            set
            {
                _ValorPagamento = value;
            }
        }

        public int CodigoUsuario
        {
            get
            {
                return _CodigoUsuario;
            }

            set
            {
                _CodigoUsuario = value;
            }
        }

        public void Incluir()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@codtit", SqlDbType.Int) {Value=CodigoTitulo},
                    new SqlParameter("@datavenc", SqlDbType.DateTime){Value =DataVencimento},
                    new SqlParameter("@ValorConta", SqlDbType.Decimal) {Value=_ValorConta},
                    new SqlParameter("@codusu", SqlDbType.Int) {Value=CodigoUsuario}

                };
                instrucaoSql = "INSERT INTO tbConta (CodigoTitulo, DataVencimento, ValorConta, StatusPagTitulo, CodigoUsuario) VALUES (@codtit, @datavenc, @ValorConta, 0, @codusu)";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Atualizar()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@codlanc", SqlDbType.Int){Value =CodigoConta},
                    new SqlParameter("@codtit", SqlDbType.Int) {Value=CodigoTitulo},
                    new SqlParameter("@datavenc", SqlDbType.DateTime){Value =DataVencimento},
                    new SqlParameter("@ValorConta", SqlDbType.Decimal) {Value=_ValorConta},
                    new SqlParameter("@status", SqlDbType.Bit){Value =StatusPagTitulo},
                    new SqlParameter("@datapag", SqlDbType.DateTime) {Value=DataPagamento},
                    new SqlParameter("@valorpag", SqlDbType.Decimal){Value =ValorPagamento},
                    new SqlParameter("@codigousuario", SqlDbType.Int) {Value=CodigoUsuario}
                };

                instrucaoSql = "UPDATE tbConta SET CodigoTitulo=@codtit, DataVencimento=@datavenc, ValorConta=@ValorConta, StatusPagTitulo=@status, DataPagamento=@datapag, ValorPagamento=@valorpag, CodigoUsuario=@codigousuario WHERE CodigoConta=@codlanc";
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
                SqlParameter[] listaComParametros = {new SqlParameter("@CodigoConta",SqlDbType.Int) {Value = CodigoConta }
                };
                instrucaoSql = "DELETE FROM tbConta WHERE CodigoConta=@CodigoConta AND StatusPagTitulo=0";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Pagar()
        {
            try
            {
                //pin não é atualizado
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@codlanc", SqlDbType.Int){Value =CodigoConta},
                    new SqlParameter("@codtit", SqlDbType.Int) {Value=CodigoTitulo},
                    new SqlParameter("@datavenc", SqlDbType.DateTime){Value =DataVencimento},
                    new SqlParameter("@ValorConta", SqlDbType.Decimal) {Value=ValorConta},

                    new SqlParameter("@status", SqlDbType.Bit){Value =1},
                    new SqlParameter("@datapag", SqlDbType.DateTime) {Value=DataPagamento},
                    new SqlParameter("@valorpag", SqlDbType.Decimal){Value =ValorPagamento},
                    new SqlParameter("@codigousuario", SqlDbType.Int) {Value=CodigoUsuario}

                };


                instrucaoSql = "UPDATE tbConta SET CodigoTitulo=@codtit, DataVencimento=@datavenc, ValorConta=@ValorConta, StatusPagTitulo=@status, DataPagamento=@datapag, ValorPagamento=@valorpag WHERE CodigoConta=@codlanc";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CancelarPagamento()
        {
            try
            {
                //pin não é atualizado
                SqlParameter[] listaComParametros = {
                    new SqlParameter("@codlanc", SqlDbType.Int){Value =CodigoConta},
                    new SqlParameter("@codtit", SqlDbType.Int) {Value=CodigoTitulo},
                    new SqlParameter("@datavenc", SqlDbType.DateTime){Value =DataVencimento},
                    new SqlParameter("@ValorConta", SqlDbType.Decimal) {Value=ValorConta},

                    new SqlParameter("@status", SqlDbType.Bit){Value =0},
                    new SqlParameter("@datapag", SqlDbType.DateTime) {Value= DBNull.Value },
                    new SqlParameter("@valorpag", SqlDbType.Decimal){Value = 0 },
                    new SqlParameter("@codigousuario", SqlDbType.Int) {Value= 0 }

                };


                instrucaoSql = "UPDATE tbConta SET CodigoTitulo=@codtit, DataVencimento=@datavenc, ValorConta=@ValorConta, StatusPagTitulo=@status, DataPagamento=@datapag, ValorPagamento=@valorpag, CodigoUsuario=@codigousuario WHERE CodigoConta=@codlanc";
                c.ExecutarComandoParametro(instrucaoSql, listaComParametros);

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
                instrucaoSql = "SELECT * FROM tbConta WHERE CodigoConta=" + CodigoConta;
                return c.RetornarDataReader(instrucaoSql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public double ValorContas(byte tipostatus, DateTime datainicial, DateTime datafinal)
        {
            try
            {
                instrucaoSql = "SELECT sum(ValorConta) from tbConta WHERE StatusPagTitulo=" + tipostatus + " AND (DataVencimento BETWEEN '" + datainicial + "' and '" + datafinal + "')";
                return c.RetornarTotal(instrucaoSql);



                //SqlDataReader ddr;
                //    ddr=c.RetornarDataReader(instrucaoSql);
                //    ddr.Read();
                //    if (ddr.HasRows)
                //    {
                //        return Convert.ToDouble(ddr[0].ToString());
                //    }
                //    else
                //    {
                //        return 0;
                //    }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public DataSet ListarContas(byte tipostatus, DateTime datainicial, DateTime datafinal)
        {
            try
            {
                if (tipostatus == 0) //não pagas
                {
                    instrucaoSql = "SELECT l.DataVencimento, t.DescricaoTitulo,  l.ValorConta, l.StatusPagTitulo, l.DataPagamento, l.ValorPagamento, l.Codigotitulo, l.CodigoConta FROM tbTipoTitulo as t INNER JOIN tbConta as l ON t.CodigoTitulo=l.CodigoTitulo WHERE l.StatusPagTitulo = 0 AND (DataVencimento BETWEEN '" + datainicial + "' and '" + datafinal + "') ORDER by l.DataVencimento, t.DescricaoTitulo";

                }
                else if (tipostatus == 1) //pagas
                {
                    instrucaoSql = "SELECT l.DataVencimento, t.DescricaoTitulo,  l.ValorConta, l.StatusPagTitulo, l.DataPagamento, l.ValorPagamento, l.Codigotitulo,  l.CodigoConta FROM tbTipoTitulo as t INNER JOIN tbConta as l ON t.CodigoTitulo=l.CodigoTitulo WHERE l.StatusPagTitulo = 1 AND (DataVencimento BETWEEN '" + datainicial + "' and '" + datafinal + "') ORDER by l.DataVencimento, t.DescricaoTitulo";

                }
                else //tudo
                {
                    instrucaoSql = "SELECT l.DataVencimento, t.DescricaoTitulo,  l.ValorConta, l.StatusPagTitulo, l.DataPagamento, l.ValorPagamento, l.Codigotitulo,  l.CodigoConta FROM tbTipoTitulo as t INNER JOIN tbConta as l ON t.CodigoTitulo=l.CodigoTitulo WHERE (DataVencimento BETWEEN '" + datainicial + "' and '" + datafinal + "') ORDER by l.DataVencimento, t.DescricaoTitulo";
                }

                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ListarTitulosEmAberto(int codigoTipoTitulo)
        {
            try
            {
                instrucaoSql = "SELECT DataVencimento, ValorConta from tbConta where codigotitulo = " + codigoTipoTitulo + " and StatusPagTitulo = 0 ORDER by DataVencimento";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public SqlDataReader ObterTituloEmAberto(SqlDateTime DataLimite)
        {
            try
            {
                instrucaoSql = "SELECT Count(DataVencimento) As Qtde, Sum(ValorConta) As ValorTotal, Min(DataVencimento) As PrimeiraData from tbConta where StatusPagTitulo = 0 AND dataVencimento > '" + DataLimite + "'";
                return c.RetornarDataReader(instrucaoSql);
            }
            catch (Exception)
            {

                throw;
            }
        }

















    }
}
