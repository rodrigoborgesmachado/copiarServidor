using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// [ArquivosServidor] Tabela da classe
    /// </summary>
    public class MD_Arquivosservidor 
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_Arquivosservidor DAO = null;


        #endregion Atributos e Propriedades

        #region Construtores

        public MD_Arquivosservidor(int codigo)
        {
            Util.CL_Files.WriteOnTheLog("MD_Arquivosservidor()", Util.Global.TipoLog.DETALHADO);
            this.DAO = new DAO.MD_Arquivosservidor( codigo);
        }


        #endregion Construtores

        #region Métodos

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Model.MD_Arquivosservidor> RetornaTodos()
        {
            Util.CL_Files.WriteOnTheLog("MD_Arquivosservidor().RetornaTodos()", Util.Global.TipoLog.DETALHADO);

            string sentenca = new DAO.MD_Arquivosservidor().table.CreateCommandSQLTable();

            List<Model.MD_Arquivosservidor> servidores = new List<MD_Arquivosservidor>();
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            while (reader.Read())
            {
                servidores.Add(new MD_Arquivosservidor(int.Parse(reader["CODIGO"].ToString())));
            }
            reader.Close();

            return servidores;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool VerificaExiste(string file, int codigoCaminhoSaida)
        {
            Util.CL_Files.WriteOnTheLog("MD_Arquivosservidor().RetornaTodos()", Util.Global.TipoLog.DETALHADO);

            string sentenca = new DAO.MD_Arquivosservidor().table.CreateCommandSQLTable() + " WHERE NOMEARQUIVO = '" + file + "' AND CAMINHODESTINO = " + codigoCaminhoSaida + " and STATUSCOPIA = 1";

            bool retorno = false;
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            if (reader.Read())
            {
                retorno = true;
            }
            reader.Close();

            return retorno;
        }

        #endregion Métodos

    }
}
