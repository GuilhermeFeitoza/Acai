using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    public class CEP
    {
        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();
        private string _NumeroCep;
        private String _UF;
        private String _Descricao;
        private string _Cidade;
        private string _Bairro;
        private static string instrucaoSql;

       

        public string UF
        {
            get
            {
                return _UF;
            }

            set
            {
                _UF = value;
            }
        }

        public string Descricao
        {
            get
            {
                return _Descricao;
            }

            set
            {
                _Descricao = value;
            }
        }

        public string Cidade
        {
            get
            {
                return _Cidade;
            }

            set
            {
                _Cidade = value;
            }
        }

        public string Bairro
        {
            get
            {
                return _Bairro;
            }

            set
            {
                _Bairro = value;
            }
        }

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

        public string NumeroCep
        {
            get
            {
                return _NumeroCep;
            }

            set
            {
                _NumeroCep = value;
            }
        }

        public SqlDataReader ConsultarCEP()
        {
            try
            {
                InstrucaoSql = "SELECT * FROM CEP  WHERE CEP=" + _NumeroCep;
                return c.RetornarDataReader(InstrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




    }
}
