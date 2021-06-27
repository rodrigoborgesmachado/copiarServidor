using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Util
{
    /// <summary>
    /// Class to implement file's configuration 
    /// </summary>
    public class CL_Files
    {
        #region Atributes
        StreamWriter writeFile = null;
        /// <summary>
        /// FileManager openned for writtring
        /// </summary>
        public StreamWriter WriteFile
        {
            get
            {
                return this.writeFile;
            }
        }

        /// <summary>
        /// FileManager opened for reading
        /// </summary>
        StreamReader fileRead = null;

        public StreamReader FileRead
        {
            get
            {
                return fileRead;
            }
        }

        string filesdir;
        /// <summary>
        /// Caminho do arquivo
        /// </summary>
        public string FilesDir
        {
            get
            {
                return filesdir;
            }
        }

        #endregion Atributes

        #region Construtores

        public CL_Files(string filedir)
        {
            this.filesdir = filedir;
        }

        #endregion Construtores

        #region Methods

        /// <summary>
        /// Method how delete files
        /// </summary>
        /// <param name="directory">Directory from the archive that will be delete</param>
        /// <returns>True - Sucess; False - Error</returns>
        public static bool DeleteArchive(string directory)
        {
            if (Exists(directory))
            {
                try
                {
                    File.Delete(directory);
                }
                catch
                {
                    return false;
                }

            }
            return true;
        }

        /// <summary>
        /// Method that write on the end of the file and put a line on the end
        /// </summary>
        /// <param name="messagem">Message to be writen</param>
        public void WriteOnTheEndWithLine(string messagem)
        {
            try
            {
                File.AppendAllText(FilesDir, messagem + "\n");
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Exception: " + e.Message);
            }
        }

        /// <summary>
        /// Method that write on the end of the file and don't put a line on the end
        /// </summary>
        /// <param name="messagem">Message to be writen</param>
        public void WriteOnTheEnd(string messagem)
        {
            try
            {
                File.AppendAllText(FilesDir, messagem);
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Exception: " + e.Message);
            }
        }

        /// <summary>
        /// Method main directories of the system
        /// </summary>
        public static void DropMainDiretories()
        {
            if (Directory.Exists(Global.app_main_directoty))
                Directory.Delete(Global.app_main_directoty, true);
            if (Directory.Exists(Global.app_temp_directory))
                Directory.Delete(Global.app_temp_directory, true);
            if (Directory.Exists(Global.app_logs_directoty))
                Directory.Delete(Global.app_logs_directoty, true);
            if (Directory.Exists(Global.app_base_directory))
                Directory.Delete(Global.app_base_directory, true);
            if (Directory.Exists(Global.app_base_directory))
                Directory.Delete(Global.app_backup_directory, true);
            
        }

        /// <summary>
        /// Method that create the main directories
        /// </summary>
        public static void CreateMainDirectories()
        {
            if (!Directory.Exists(Global.app_main_directoty))
                Directory.CreateDirectory(Global.app_main_directoty);
            if (!Directory.Exists(Global.app_temp_directory))
                Directory.CreateDirectory(Global.app_temp_directory);
            if (!Directory.Exists(Global.app_logs_directoty))
                Directory.CreateDirectory(Global.app_logs_directoty);
            if (!Directory.Exists(Global.app_base_directory))
                Directory.CreateDirectory(Global.app_base_directory);
            if (!Directory.Exists(Global.app_backup_directory))
                Directory.CreateDirectory(Global.app_backup_directory);
        }

        /// <summary>
        /// Method how copie the file A to the directorie B
        /// </summary>
        /// <param name="from">File to be copied</param>
        /// <param name="to">File of destiny</param>
        /// <returns>True - Sucess; False - Fail</returns>
        public static bool CopyFile(string from, string to)
        {
            if (!Exists(from))
            {
                return false;
            }

            File.Copy(from, to, true);
            return true;
        }

        /// <summary>
        /// Method that replace the name of the file
        /// </summary>
        /// <param name="arq">File to be renamed</param>
        /// <param name="newname">New name of the file</param>
        /// <returns>True - Sucess; False- Fail</returns>
        public static bool Rename(string arq, string newname)
        {
            return CopyFile(arq, newname);
        }

        /// <summary>
        /// Method that read the archive and returns a List of string with witch line
        /// </summary>
        /// <param name="messageError">String by references that put some possible error during the reader</param>
        /// <returns>A list of strings os witch line in the archive</returns>
        public List<string> ReadArchive()
        {
            List<string> linhas = new List<string>();

            if (!Exists(FilesDir))
            {
                return null;
            }
            StreamReader reader = new StreamReader(filesdir);

            while (!reader.EndOfStream)
            {
                try
                {
                    string linha = reader.ReadLine();
                    linhas.Add(linha);
                }
                catch (Exception e)
                {
                    WriteOnTheLog("Error: " + e.Message, Global.TipoLog.SIMPLES);
                    return null;
                }

            }
            reader.Close();
            return linhas;
        }

        /// <summary>
        /// Method that verify the exists of the file
        /// </summary>
        /// <param name="Directory">directory of the file</param>
        /// <returns>True - Exists; False - Don't exists</returns>
        static public bool Exists(string Directory)
        {
            try
            {
                return System.IO.File.Exists(Directory);
            }
            catch
            {
                return true;
            }
        }

        /// <summary>
        /// Método que copia e cria a pasta com as imagens
        /// </summary>
        public static void CopiaImagens()
        {
            if (Directory.Exists(Util.Global.app_temp_directory))
            {
                if (Directory.Exists(Util.Global.app_temp_directory + "files\\"))
                    Directory.Delete(Util.Global.app_temp_directory + "files\\", true);

                Directory.CreateDirectory(Util.Global.app_temp_directory + "files\\");

                foreach (string file in Directory.GetFiles(Util.Global.app_Img_directory))
                {
                    FileInfo ff = new FileInfo(file);
                    File.Copy(file, Util.Global.app_temp_directory + "files\\" + ff.Name);
                }
            }
        }

        /// <summary>
        /// Method that write on the log
        /// </summary>
        /// <param name="message"></param>
        public static void WriteOnTheLog(string message, Global.TipoLog tipoLog)
        {
            if(Global.log_system != Global.TipoLog.DETALHADO && tipoLog == Global.TipoLog.DETALHADO)
            {
                return;
            }

            string directory_ach = Global.app_logs_directoty;

            if (DateTime.Now.Day < 10)
            {
                directory_ach += "0" + DateTime.Now.Day;
            }
            else
            {
                directory_ach += DateTime.Now.Day;
            }

            if (DateTime.Now.Month < 10)
            {
                directory_ach += "0" + DateTime.Now.Month;
            }
            else
            {
                directory_ach += DateTime.Now.Month;
            }


            directory_ach += DateTime.Now.Year + ".log";

            CL_Files file = new CL_Files(directory_ach);
            file.WriteOnTheEnd(DateTime.Now.ToString() + "- " + (tipoLog == Global.TipoLog.DETALHADO ? "DETALHADO -" : "SIMPLES -") + message + "\n");
            file = null;
        }
        
        /// <summary>
        /// Método que faz backup do banco de dados e apaga os logs passados
        /// </summary>
        /// <param name="numeroDiasManter"></param>
        public static void FazBackup(int numeroDiasManter)
        {
            try
            {
                /*if ((Util.Enumerator.BancoDados)JSON.Geral.InstanciaConexao().TipoConexao == Enumerator.BancoDados.SQLite)
                {
                    if(!File.Exists(Util.Global.app_backup_directory + DateTime.Now.ToShortDateString().Replace(':', '-')))
                    {
                        CopyFile(Util.JSON.Geral.InstanciaConexao().DataBase, Util.Global.app_backup_directory + DateTime.Now.ToShortDateString().Replace('/', '-') + DateTime.Now.ToShortTimeString().Replace(':', '-'));
                    }
                }*/

                foreach (string file in Directory.GetFiles(Util.Global.app_backup_directory))
                {
                    FileInfo info = new FileInfo(file);
                    if (info.CreationTime < DateTime.Now.AddDays((-1) * numeroDiasManter))
                    {
                        info.Delete();
                    }
                }

                foreach (string file in Directory.GetFiles(Util.Global.app_logs_directoty))
                {
                    FileInfo info = new FileInfo(file);
                    if (info.CreationTime < DateTime.Now.AddDays((-1) * numeroDiasManter))
                    {
                        info.Delete();
                    }
                }
            }
            catch(Exception e)
            {
                WriteOnTheLog("Error: " + e.Message, Global.TipoLog.SIMPLES);
            }
        }

        /// <summary>
        /// Método que executa o arquivo
        /// </summary>
        /// <param name="file"></param>
        /// <param name="waitFinalizar"></param>
        /// <returns></returns>
        public static bool Execute(string file, bool waitFinalizar)
        {
            try
            {
                while (!System.Diagnostics.Process.Start(file).HasExited) if (!waitFinalizar) break;
            }
            catch(Exception e)
            {
                WriteOnTheLog("Erro: " + e.Message, Global.TipoLog.SIMPLES);
                return false;
            }

            return true;
        }

        #endregion Methods        
    }
}
