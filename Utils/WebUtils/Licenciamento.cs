using System;
using System.IO;
using System.Net;
using System.Text;

namespace Util.WebUtil
{ 
    public static class Licenciamento
    {

        /// <summary>
        /// Método que insere na API
        /// </summary>
        public static bool AtualizaAPI(string chave, string ativo)
        {
            try
            {
                string dadosPOST = "chaveGuid=" + chave;
                dadosPOST += "&ativo=" + ativo;

                var dados = Encoding.UTF8.GetBytes(dadosPOST);

                var requisicaoWeb = WebRequest.CreateHttp("http://www.sunsalesystem.com.br/php/verificadorAtualiza.php");
                requisicaoWeb.Method = "POST";
                requisicaoWeb.ContentType = "application/x-www-form-urlencoded";
                requisicaoWeb.ContentLength = dados.Length;
                requisicaoWeb.UserAgent = "RequisicaoSunSalePro";

                using (var stream = requisicaoWeb.GetRequestStream())
                {
                    stream.Write(dados, 0, dados.Length);
                    stream.Close();
                }
                using (var resposta = requisicaoWeb.GetResponse())
                {
                    var streamDados = resposta.GetResponseStream();
                    StreamReader reader = new StreamReader(streamDados);

                    object objResponse = reader.ReadToEnd();
                    Util.CL_Files.WriteOnTheLog("Chave: " + objResponse.ToString(), Util.Global.TipoLog.SIMPLES);

                    streamDados.Close();
                    resposta.Close();
                }
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                return false;
            }
            return true;
        }
    }
}
