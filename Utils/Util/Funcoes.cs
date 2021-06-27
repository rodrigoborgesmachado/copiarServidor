using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class Funcoes
    {
        /// <summary>
        /// Método que valida se o texto pode ser convertido para decimal
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static bool ValidaDecimal(string texto)
        {
            bool retorno = false;

            decimal d = decimal.Zero;
            retorno = decimal.TryParse(texto, out d);

            return retorno;
        }

        /// <summary>
        /// Método que valida se o texto pode ser convertido para decimal
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static bool ValidaInteiro(string texto)
        {
            bool retorno = false;

            int d = 0;
            retorno = int.TryParse(texto, out d);

            return retorno;
        }

        /// <summary>
        /// Método que trata o texto para ser colocado no banco
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static string TrataTexto(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                texto = string.Empty;
            return texto.Replace("'", "''");
        }

        /// <summary>
        /// Método que retorna o texto do mês referente ao número
        /// </summary>
        /// <param name="mes"></param>
        /// <returns></returns>
        public static string RetornaMes(int mes)
        {
            string mesTexto = string.Empty;

            switch (mes)
            {
                case 1:
                    mesTexto = "janeiro";
                    break;

                case 2:
                    mesTexto = "fevereiro";
                    break;

                case 3:
                    mesTexto = "março";
                    break;

                case 4:
                    mesTexto = "abril";
                    break;

                case 5:
                    mesTexto = "maio";
                    break;

                case 6:
                    mesTexto = "junho";
                    break;

                case 7:
                    mesTexto = "julho";
                    break;

                case 8:
                    mesTexto = "agosto";
                    break;

                case 9:
                    mesTexto = "setembro";
                    break;

                case 10:
                    mesTexto = "outubro";
                    break;

                case 11:
                    mesTexto = "novembro";
                    break;

                case 12:
                    mesTexto = "dezembro";
                    break;
            }

            return mesTexto;
        }

        /// <summary>
        /// Método que retorna o número da semana
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int RetornaNumeroSemana(DateTime date)
        {
            DateTime tempdate = date.AddDays(-date.Day + 1);
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNumStart = ciCurr.Calendar.GetWeekOfYear(tempdate, CalendarWeekRule.FirstFourDayWeek, ciCurr.DateTimeFormat.FirstDayOfWeek);
            int weekNum = ciCurr.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, ciCurr.DateTimeFormat.FirstDayOfWeek);
            return weekNum - weekNumStart + 1;
        }

        /// <summary>
        /// Método que calcula o juros composto
        /// </summary>
        /// <param name="montante"></param>
        /// <param name="juros"></param>
        /// <param name="tempo"></param>
        /// <returns></returns>
        public static decimal CalculaJurosCompostos(decimal montante, decimal juros, decimal tempo)
        {
            double retorno = 0;
            double j = double.Parse((juros/100).ToString("0.00"));
            double i = double.Parse(tempo.ToString("0.00"));
            double m = double.Parse(montante.ToString("0.00"));

            retorno = m * Math.Pow(1 + j, i);

            return decimal.Parse(retorno.ToString("0.00"));
        }

        /// <summary>
        /// Método que retorna uma string com o valor do número decimal a partir do número de casas
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="numeroCasas"></param>
        /// <returns></returns>
        public static string RetornaStringDeDecimal(decimal valor, int numeroCasas)
        {
            string retorno = string.Empty;

            string baseString = string.Empty;

            while (numeroCasas-- > 0)
            {
                baseString += "0";
            }

            if (string.IsNullOrEmpty(baseString))
            {
                baseString = "0";
            }

            retorno = valor.ToString("0." + baseString);

            return retorno;
        }

        /// <summary>
        /// Método que valida se o CNPJ está correto
        /// </summary>
        /// <param name="cnpj"></param>
        /// <returns></returns>
        public static bool ValidaCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
                return false;

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        /// <summary>
        /// Método que valida se é cpf
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public static bool ValidaCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        /// <summary>
        /// Método que sobe para o servidor o arquivo
        /// </summary>
        /// <param name="fileOrigem"></param>
        /// <param name="caminhoDestino"></param>
        /// <returns></returns>
        public static bool SubirParaServidor(string fileOrigem, string caminhoDestino)
        {
            bool retorno = true;
            try
            {
                FileInfo arquivoInfo = new FileInfo(fileOrigem);
                string url = caminhoDestino + arquivoInfo.Name;

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(url));
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(Global.usuarioFtp, Global.senhaFtp);
                request.UseBinary = true;
                request.ContentLength = arquivoInfo.Length;
                using (FileStream fs = arquivoInfo.OpenRead())
                {
                    byte[] buffer = new byte[2048];
                    int bytesSent = 0;
                    int bytes = 0;

                    using (Stream stream = request.GetRequestStream())
                    {
                        while (bytesSent < arquivoInfo.Length)
                        {
                            bytes = fs.Read(buffer, 0, buffer.Length);
                            stream.Write(buffer, 0, bytes);
                            bytesSent += bytes;
                        }
                    }

                }
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Erro: " + e.Message, Global.TipoLog.SIMPLES);
                retorno = false;
            }

            return retorno;
        }
    }
}
