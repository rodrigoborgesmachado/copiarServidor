using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Util
{
    public static class Global
    {
        public static string tempTable = "TESTE";

        public static int CodigoProjeto = 0;

        // Caminho principal da aplicação
        public static string app_main_directoty = System.IO.Directory.GetCurrentDirectory() + "\\";

        // Caminho do programa de configuração de conexão
        public static string app_config_file = app_main_directoty + "Conexao.exe";

        // Caminho da pasta de logs do sistema
        public static string app_logs_directoty = app_main_directoty + "Log\\";

        // Caminho da pasta de arquivos temporários
        public static string app_temp_directory = app_main_directoty + "Temp\\";

        // Nome do diretório do banco de dados
        public static string app_base_directory = app_main_directoty + "base\\";

        // Nome do diretório de backup de dados
        public static string app_backup_directory = app_main_directoty + "backup\\";

        // Nome do diretório do Img do html
        public static string app_Img_directory = app_main_directoty + "Img\\";

        // Nome do diretório de relatórios
        public static string app_rel_directory = app_main_directoty + "Relatorios\\";

        // Nome do diretório do Img do html
        public static string app_Files_directory = app_rel_directory + "Files\\";

        // Nome do arquivo de configuração com o banco de dados
        public static string app_File_config_BD = app_main_directoty + "db.config";

        // Nome do arquivo de banco de dados
        public static string app_File_conexao_BD = app_base_directory + "pckdb.db3";

        // Nome do arquivo html temporário
        public static string app_temp_html_file = app_temp_directory + "file_html.html";

        // Nome do arquivo de download
        public static string app_temp_instalacao_file = app_temp_directory + "sunsale.exe";

        // Nome do arquivo de atualização
        public static string app_atualizacao_file = app_main_directoty + "atualizacao.txt";

        public static string usuarioFtp = "ph20598337134";
        public static string senhaFtp = "qbj1ACjd**";
        public static string caminhoFtp = "ftp://50.62.169.121/testeCopia/";

        /// <summary>
        /// Enumerador referente ao tipo de log que o sistema irá persistir
        /// </summary>
        public enum TipoLog
        {
            DETALHADO = 0,
            SIMPLES = 1
        }

        /// <summary>
        /// Tipo mde log que o sistema está utilizando
        /// </summary>
        public static TipoLog log_system = TipoLog.SIMPLES;
    }
}
