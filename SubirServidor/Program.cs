using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubirServidor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Util.CL_Files.WriteOnTheLog("-------------------------------------------Iniciando Sistema-------------------------------------------", Util.Global.TipoLog.SIMPLES);
            Util.CL_Files.CreateMainDirectories();
            try
            {
                DataBase.Connection.OpenConection(Util.Global.app_File_config_BD, Util.Enumerator.BancoDados.SQLite);
                Application.Run(new Visao.FO_Principal());
            }
            catch(Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
            }
            finally
            {
                DataBase.Connection.CloseConnection();
                Util.CL_Files.WriteOnTheLog("-------------------------------------------Finalizando Sistema-------------------------------------------", Util.Global.TipoLog.SIMPLES);
            }

        }
    }
}
