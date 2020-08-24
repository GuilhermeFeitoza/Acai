using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FaleConosco
    {

        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();
        public static string instrucaoSql;
        private int _CodigoMensagem;
        private string _Nome;
        private string _Mensagem;
        private string _Email;
        private string _Telefone;
        private byte _StatusMensagem;

        public int CodigoMensagem
        {
            get
            {
                return _CodigoMensagem;
            }

            set
            {
                _CodigoMensagem = value;
            }
        }

        public string Mensagem
        {
            get
            {
                return _Mensagem;
            }

            set
            {
                _Mensagem = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public string Telefone
        {
            get
            {
                return _Telefone;
            }

            set
            {
                _Telefone = value;
            }
        }

        public byte StatusMensagem
        {
            get
            {
                return _StatusMensagem;
            }

            set
            {
                _StatusMensagem = value;
            }
        }

        public string Nome
        {
            get
            {
                return _Nome;
            }

            set
            {
                _Nome = value;
            }
        }



        public DataSet Listar()
        {
            try
            {
                instrucaoSql = "SELECT * FROM tbFaleConosco";
                
                return c.RetornarDataSet(instrucaoSql);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }






    }
}
