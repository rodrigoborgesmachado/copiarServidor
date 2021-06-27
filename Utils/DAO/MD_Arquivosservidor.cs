using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace DAO
{

    /// <summary>
    /// [ArquivosServidor] Tabela ArquivosServidor
    /// </summary>
    public class MD_Arquivosservidor : MDN_Model
    {
        #region Atributos e Propriedades

        private int codigo;
        /// <summary>
        /// [CODIGO] 
        /// <summary>
        public int Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }

        private string nomearquivo;
        /// <summary>
        /// [NOMEARQUIVO] 
        /// <summary>
        public string Nomearquivo
        {
            get
            {
                return this.nomearquivo;
            }
            set
            {
                this.nomearquivo = value;
            }
        }

        private string diretorioorigem;
        /// <summary>
        /// [DIRETORIOORIGEM] 
        /// <summary>
        public string Diretorioorigem
        {
            get
            {
                return this.diretorioorigem;
            }
            set
            {
                this.diretorioorigem = value;
            }
        }

        private int caminhodestino;
        /// <summary>
        /// [CAMINHODESTINO] 
        /// <summary>
        public int Caminhodestino
        {
            get
            {
                return this.caminhodestino;
            }
            set
            {
                this.caminhodestino = value;
            }
        }

        private string statuscopia;
        /// <summary>
        /// [STATUSCOPIA] 
        /// <summary>
        public string Statuscopia
        {
            get
            {
                return this.statuscopia;
            }
            set
            {
                this.statuscopia = value;
            }
        }


		#endregion Atributos e Propriedades

        #region Construtores

		/// <summary>
        /// Construtor Principal da classe
        /// </summary>
        public MD_Arquivosservidor()
            : base()
        {
            base.table = new MDN_Table("ArquivosServidor");
            this.table.Fields_Table.Add(new MDN_Campo("CODIGO", false, Util.Enumerator.DataType.INT, 0, true, false, 0, 0));
            this.table.Fields_Table.Add(new MDN_Campo("NOMEARQUIVO", true, Util.Enumerator.DataType.STRING, "-", false, false, 300, 0));
            this.table.Fields_Table.Add(new MDN_Campo("DIRETORIOORIGEM", true, Util.Enumerator.DataType.STRING, "-", false, false, 500, 0));
            this.table.Fields_Table.Add(new MDN_Campo("CAMINHODESTINO", true, Util.Enumerator.DataType.INT, 0, false, false, 500, 0));
            this.table.Fields_Table.Add(new MDN_Campo("STATUSCOPIA", false, Util.Enumerator.DataType.CHAR, "0", false, false, 1, 0));

            if (!base.table.ExistsTable())
                base.table.CreateTable(false);

            base.table.VerificaColunas();
        }

		/// <summary>
        /// Construtor Secundário da classe
        /// </summary>
        /// <param name="CODIGO">
        public MD_Arquivosservidor(int codigo)
            :this()
        {
            this.codigo = codigo;
            this.Load();
        }


		#endregion Construtores

        #region Métodos

		/// <summary>
        /// Método que faz o load da classe
        /// </summary>
        public override void Load()
        {
            Util.CL_Files.WriteOnTheLog("MD_Arquivosservidor.Load()", Util.Global.TipoLog.DETALHADO);

            string sentenca = base.table.CreateCommandSQLTable() + " WHERE CODIGO = " + Codigo + "";
            DbDataReader reader = DataBase.Connection.Select(sentenca);

            if (reader == null)
            {
                this.Empty = true;
            }
            else if (reader.Read())
            {
                this.Nomearquivo = reader["NOMEARQUIVO"].ToString();
                this.Diretorioorigem = reader["DIRETORIOORIGEM"].ToString();
                this.Caminhodestino = int.Parse(reader["CAMINHODESTINO"].ToString());
                this.Statuscopia = reader["STATUSCOPIA"].ToString();

                this.Empty = false;
                reader.Close();
            }
            else
            {
                this.Empty = true;
                reader.Close();
            }
        }

        /// <summary>
        /// Método que faz o delete da classe
        /// </summary>
        /// <returns>True - sucesso; False - erro</returns>
        public override bool Delete()
        {
            string sentenca = "DELETE FROM " + this.table.Table_Name + " WHERE CODIGO = " + Codigo + "";
            return DataBase.Connection.Delete(sentenca);
        }

        /// <summary>
        /// Método que faz o insert da classe
        /// </summary>
        /// <returns></returns>
        public override bool Insert()
        {
            string sentenca = string.Empty;

            sentenca = "INSERT INTO " + table.Table_Name + " (" + table.TodosCampos() + ")" + 
                              " VALUES (" + this.codigo + ",  '" + this.nomearquivo + "',  '" + this.diretorioorigem + "', " + this.caminhodestino + ",  '" + this.statuscopia + "')";
            if (DataBase.Connection.Insert(sentenca))
            {
                Empty = false;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método que faz o update da classe
        /// </summary>
        /// <returns>True - sucesso; False - erro</returns>
        public override bool Update()
        {
            string sentenca = string.Empty;

            sentenca = "UPDATE " + table.Table_Name + " SET " + 
                        "CODIGO = " + Codigo + ", NOMEARQUIVO = '" + Nomearquivo + "', DIRETORIOORIGEM = '" + Diretorioorigem + "', CAMINHODESTINO = " + Caminhodestino + ", STATUSCOPIA = '" + Statuscopia + "'" + 
                        " WHERE CODIGO = " + Codigo + "";

            return DataBase.Connection.Update(sentenca);
        }

		#endregion Métodos
    }
}
