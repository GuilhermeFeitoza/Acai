﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Cargo
    {
        DAO.ClasseParaManipularBancoDeDados c = new DAO.ClasseParaManipularBancoDeDados();
        public static string instrucaoSql;


        private int _CodigoCargo;
        private string _Descricao;
        private byte StatusCargo;

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

        public byte StatusCargo1
        {
            get
            {
                return StatusCargo;
            }

            set
            {
                StatusCargo = value;
            }
        }




        public void IncluirComParametro()
        {
            try
            {
                SqlParameter[] listaComParametros = {
                   new SqlParameter("@NomeCargo",SqlDbType.VarChar) {Value = _Descricao }
                 
                };
                //criar o objeto 'listaComParametros' a partir da classe 'sqlparameter' definida como uma lista '[]'. Foi instanciado 'new' o objeto 'listaComParametros' com 4 itens/parametros.  Cada parametro foi definido com a identificação '@....' + um tipo de dado 'SqlDbType' +  um valor '{Value = _.....}'
                instrucaoSql = "INSERT INTO tbCargo (Descricao, StatusCargo) VALUES (@NomeCargo,1)";

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
                SqlParameter[] listaComParametros = {new SqlParameter("@CodigoCargo",SqlDbType.Int) {Value = _CodigoCargo },
                   new SqlParameter("@NomeCargo",SqlDbType.VarChar) {Value = _Descricao }
                  
                };

                instrucaoSql = "UPDATE tbCargo SET Descricao=@NomeCargo WHERE CodigoCargo=@CodigoCargo";
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
                instrucaoSql = "UPDATE tbCargo SET StatusCargo=1   WHERE CodigoCargo=" + _CodigoCargo;
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
                instrucaoSql = "UPDATE tbCargo SET StatusCargo=0   WHERE CodigoCargo=" + _CodigoCargo;
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
                instrucaoSql = "SELECT * FROM tbCargo  WHERE CodigoCargo=" + _CodigoCargo;
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
                instrucaoSql = "SELECT * FROM tbCargo";
                if (parteNome.Length != 0)
                {
                    instrucaoSql = instrucaoSql + " WHERE Descricao LIKE '%" + parteNome + "%'"; //avisado sobre comportamento
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
                instrucaoSql = "SELECT CodigoCargo, Descricao, StatusCargo FROM tbCargo WHERE StatusCargo=1";
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
                instrucaoSql = "SELECT CodigoCargo, Descricao FROM tbCargo WHERE StatusCargo=0";
                return c.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }








    }
}
