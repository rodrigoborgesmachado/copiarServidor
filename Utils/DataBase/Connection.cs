using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Util.Enumerator;

namespace DataBase
{
    public class Connection
    {
        private static Banco banco = null;

        /// <summary>
        /// Abrir conexão
        /// </summary>
        /// <param name="conection"></param>
        /// <param name="bd"></param>
        /// <returns></returns>
        public static bool OpenConection(string conection, BancoDados bd)
        {
            bool retorno = false;
            try
            {
                if (bd == BancoDados.SQLite)
                {
                    banco = new BancoSQLite();
                }
                else if(bd == BancoDados.SQL_SERVER)
                {
                    banco = new BancoSQLServer();
                }

                banco.OpenConnection(conection);
                retorno = true;
            }
            catch(Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                retorno = false;
            }

            return retorno;
        }

        /// <summary>
        /// Método que fecha a conexão com o banco de dados
        /// </summary>
        /// <returns>True - fechado com sucesso; False - erro ao fechar conexão</returns>
        public static bool CloseConnection()
        {
            return banco.CloseConnection();
        }

        /// <summary>
        /// Método que faz select no banco
        /// </summary>
        /// <param name="sentenca"></param>
        public static DbDataReader Select(string sentenca)
        {
            return banco.Select(sentenca);
        }

        /// <summary>
        /// Método que faz o insert
        /// </summary>
        /// <param name="sentenca">string de comando</param>
        /// <returns>True - sucesso; False - erro</returns>
        public static bool Insert(string sentenca)
        {
            return banco.Insert(sentenca);
        }

        /// <summary>
        /// Método que faz o insert
        /// </summary>
        /// <param name="sentenca">string de comando</param>
        /// <returns>True - sucesso; False - erro</returns>
        public static bool Update(string sentenca)
        {
            return banco.Update(sentenca);
        }

        /// <summary>
        /// Método que faz o insert
        /// </summary>
        /// <param name="sentenca">string de comando</param>
        /// <returns>True - sucesso; False - erro</returns>
        public static bool Delete(string sentenca)
        {
            return banco.Delete(sentenca);
        }

        /// <summary>
        /// Método que faz a criação da tabela
        /// </summary>
        /// <param name="sentenca">Comando</param>
        /// <returns>True - sucesso; False - errado</returns>
        public static bool CreateTable(string sentenca)
        {
            return banco.CreateTable(sentenca);
        }

        /// <summary>
        /// Método que executa o comando no banco
        /// </summary>
        /// <param name="sentenca"></param>
        /// <returns></returns>
        public static bool Execute(string sentenca)
        {
            return banco.Execute(sentenca);
        }

        /// <summary>
        /// Método que verifica se a tabela existe
        /// </summary>
        /// <param name="tabela">Tabela para verificar</param>
        /// <returns>True - existe; False - não existe</returns>
        public static bool ExistsTable(string tabela)
        {
            return banco.ExistsTable(tabela);
        }

        /// <summary>
        /// Método que converte a data para inteiro
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static int Date_to_Int(DateTime date)
        {
            return banco.Date_to_Int(date);
        }

        /// <summary>
        /// Método que pega o incremental
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static int GetIncrement(string table)
        {
            return banco.GetIncrement(table);
        }

        /// <summary>
        /// Método que seta o tipo do log
        /// </summary>
        /// <param name="tipo">Tipo do log</param>
        public static void SetLog(Util.Global.TipoLog tipo)
        {
            banco.SetLog(tipo);
        }

        /// <summary>
        /// Método que retorna o log
        /// </summary>
        /// <returns>Tipo do log</returns>
        public static Util.Global.TipoLog GetLog()
        {
            return banco.GetLog();
        }

        /// <summary>
        /// Método que executa os comandos da versao
        /// </summary>
        public static void ExecutaCommands()
        {
            try
            {
                /*DbDataReader reader = Select(new DAO.MD_Scripts().table.CreateCommandSQLTable() + " WHERE EXECUTADO = '0'");

                if (reader.Read())
                {
                    Update(reader["COMANDO"].ToString());
                }
                reader.Close();

                Update("UPDATE " + new DAO.MD_Scripts().table.Table_Name + " SET EXECUTA = '1' WHERE EXECUTADO = '0'");*/
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Erro: " + e.Message, Util.Global.TipoLog.SIMPLES);
            }
        }

        /// <summary>
        /// Método verifica se a consulta retorna resultado
        /// </summary>
        /// <param name="sentenca"></param>
        /// <returns></returns>
        public static bool ExisteResultado(string sentenca)
        {
            DbDataReader reader = Select(sentenca);
            bool retorno = false;

            if (reader.Read())
            {
                retorno = true;
            }
            reader.Close();

            return retorno;
        }

    }
}
