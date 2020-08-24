using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class Usuario
    {
        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();
        private static string instrucaoSql;
        private int    _CodigoUsuario;
        private string _SenhaUsuario;
        private string _NomeUsuario;

        private int _CodigoNivelAcesso;
        private byte _StatusUsuario;

        
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

        public string SenhaUsuario
        {
            get
            {
                return _SenhaUsuario;
            }

            set
            {
                _SenhaUsuario = value;
            }
        }

        public string NomeUsuario
        {
            get
            {
                return _NomeUsuario;
            }

            set
            {
                _NomeUsuario = value;
            }
        }

        public int CodigoNivelAcesso
        {
            get
            {
                return _CodigoNivelAcesso;
            }

            set
            {
                _CodigoNivelAcesso = value;
            }
        }

        public byte StatusUsuario
        {
            get
            {
                return _StatusUsuario;
            }

            set
            {
                _StatusUsuario = value;
            }
        }



        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@NomeUsuario",SqlDbType.VarChar) {Value = _NomeUsuario },
                   new  SqlParameter("@SenhaUsuario",SqlDbType.VarChar) {Value = _SenhaUsuario },
                  
                   new SqlParameter("@CodigoNivelAcesso",SqlDbType.Int) {Value = _CodigoNivelAcesso },
                    new SqlParameter("@StatusUsuario",SqlDbType.Bit) {Value = _StatusUsuario }

                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbUsuario (NomeUsuario, SenhaUsuario, CodigoNivelAcesso,StatusUsuario) VALUES (@NomeUsuario,@SenhaUsuario,@CodigoNivelAcesso,@StatusUsuario)";
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
                     new SqlParameter("@CodigoUsuario",SqlDbType.Int) {Value = _CodigoUsuario },
                   new SqlParameter("@NomeUsuario",SqlDbType.VarChar) {Value = _NomeUsuario },
                   new  SqlParameter("@SenhaUsuario",SqlDbType.VarChar) {Value = _SenhaUsuario },
                   new SqlParameter("@CodigoNivelAcesso",SqlDbType.Int) {Value = _CodigoNivelAcesso },
                   new SqlParameter("@StatusUsuario",SqlDbType.Bit) {Value = _StatusUsuario }

                };

                instrucaoSql = "UPDATE tbUsuario SET NomeUsuario=@NomeUsuario,SenhaUsuario=@SenhaUsuario,CodigoNivelAcesso=@CodigoNivelAcesso,StatusUsuario=@StatusUsuario WHERE CodigoUsuario=@CodigoUsuario";
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
                instrucaoSql = "UPDATE tbUsuario SET StatusUsuario=1   WHERE CodigoUsuario=" + _CodigoUsuario;
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
                instrucaoSql = "UPDATE tbUsuario SET StatusUsuario=0   WHERE CodigoUsuario=" + _CodigoUsuario;
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
                instrucaoSql = "SELECT * FROM tbUsuario  WHERE CodigoUsuario=" + _CodigoUsuario;
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
                instrucaoSql = " SELECT CodigoUsuario,NomeUsuario,SenhaUsuario,CodigoNivelAcesso,NomeNivelAcesso,StatusUsuario FROM tbUsuario INNER JOIN tbNivel ON tbUsuario.CodigoNivelAcesso = tbNivel.CodigoNivel";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE NomeUsuario LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
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
                instrucaoSql = "SELECT * FROM tbUsuario WHERE StatusUsuario=1";

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
                instrucaoSql = "SELECT * FROM tbUsuario WHERE StatusUsuario=0";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public int Logar()
        {
            try
            {
                //instrucaoSql = "SELECT NomeUsuario, SenhaUsuario, CodigoUsuario, StatusUsuario FROM tbusuario WHERE NomeUsuario='" + _NomeUsuario + "'  AND  SenhaUsuario='" + _SenhaUsuario + "'  AND StatusUsuario=1";
                instrucaoSql = "SELECT NomeUsuario, SenhaUsuario, CodigoUsuario,CodigoNivelAcesso, StatusUsuario FROM tbusuario WHERE NomeUsuario='" + _NomeUsuario + "'  AND  SenhaUsuario='" + _SenhaUsuario + "'  AND StatusUsuario=1";
                SqlDataReader dr;
                dr = c.RetornarDataReader(instrucaoSql);
                dr.Read();
                if (dr.HasRows)
                {
                    _StatusUsuario = Convert.ToByte(dr["StatusUsuario"]);

                    _CodigoUsuario = Convert.ToInt32(dr["CodigoUsuario"]);
                    _CodigoNivelAcesso = Convert.ToInt32(dr["CodigoNivelAcesso"]);
                     AlterarComParametro();
                    return Convert.ToInt32(dr["CodigoUsuario"]);
                }
                else
                {
                    return 0;
                }
                //return dr.HasRows;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }































    }
}
