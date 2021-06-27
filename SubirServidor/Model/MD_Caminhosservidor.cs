using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// [CaminhosServidor] Tabela da classe
    /// </summary>
    public class MD_Caminhosservidor 
    {
        #region Atributos e Propriedades

        /// <summary>
        /// DAO que representa a classe
        /// </summary>
        public DAO.MD_Caminhosservidor DAO = null;


        #endregion Atributos e Propriedades

        #region Construtores

        public MD_Caminhosservidor(int codigo)
        {
            Util.CL_Files.WriteOnTheLog("MD_Caminhosservidor()", Util.Global.TipoLog.DETALHADO);
            this.DAO = new DAO.MD_Caminhosservidor( codigo);
        }


        #endregion Construtores

        #region Métodos

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Model.MD_Caminhosservidor> RetornaTodos()
        {
            Util.CL_Files.WriteOnTheLog("MD_Caminhosservidor().RetornaTodos()", Util.Global.TipoLog.DETALHADO);

            string sentenca = new DAO.MD_Caminhosservidor().table.CreateCommandSQLTable();

            List<Model.MD_Caminhosservidor> servidores = new List<MD_Caminhosservidor>();
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            while (reader.Read())
            {
                servidores.Add(new MD_Caminhosservidor(int.Parse(reader["CODIGO"].ToString())));
            }
            reader.Close();

            return servidores;
        }

        #endregion Métodos

    }
}
