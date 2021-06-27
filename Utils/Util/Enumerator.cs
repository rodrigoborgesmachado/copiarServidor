using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class Enumerator
    {

        public enum SimNao
        {
            NÃO = 0,
            SIM = 1
        }

        public enum TipoMudanca
        {
            CORRECAO = 0,
            MUDANCA = 1
        }

        public enum PagamentoDespesa
        {
            DINHEIRO_CAIXA = 0,
            DINHEIRO_FORA = 1
        }

        public enum Tipo_Respostas
        {
            CONSULTA_SIM_NAO = 0,
            STRING = 5,
            DECIMAL = 10,
            INTEGER = 15
        }

        public enum Status_Caixa
        {
            FECHADO = 0,
            ABERTO = 1
        }

        public enum Tarefa_Tela
        {
            INSERINDO = 0,
            EDITANDO = 1
        }

        public enum Condicao_Pagamento
        {
            A_VISTA = 0,
            PARCELADO = 1
        }

        public enum TIPO_PAGAMENTO
        {
            PEDIDO = 0,
            TITULO = 1
        }

        public enum Status_Titulo_Cliente
        {
            ABERTO = 0,
            FECHADO = 1
        }

        public enum Sexo
        {
            FEMININO = 0,
            MASCULINO = 1
        }

        public enum FILTRO_TITULOS
        {
            ABERTOS = 0,
            NEGOCIADOS = 1,
            VENCIDOS = 2,
            TODOS = 3
        }

        public enum Filtro_Gerencia_Caixa
        {
            DATA = 0,
            COMPLETO = 1
        }

        /// <summary>
        /// Enumerator do tipo do banco
        /// </summary>
        public enum BancoDados
        {
            SQL_SERVER = 0,
            SQLite = 1,
            ORACLE = 2
        }

        /// <summary>
        /// Método que retorna o banco de dados a partir do código do mesmo
        /// </summary>
        /// <param name="codigo">Código do tipo do banco</param>
        /// <returns>Tipo do banco</returns>
        public static BancoDados BancoDeDadosPorCodigo(int codigo)
        {
            return (BancoDados)codigo;
        }

        /// <summary>
        /// Enum referente à tela a ser aberta
        /// </summary>
        public enum Telas
        {
            BRANCO = -1,
            CADASTRO_CLIENTES = 0,
            CADASTRO_PRODUTOS = 1,
            CADASTRO_GRUPO = 2,
            CADASTRO_MARCA = 3,
            CADASTRO_TAMANHO = 4,
            CADASTRO_TABELAPRECO = 5,
            CADASTRO_FORMATABELA = 6,
            CADASTRO_CONDICAOPAGAMENTO = 7,
            CADASTRO_MURAL= 8,
            CADASTRO_TIPO_INFORMACAO = 9,
            CADASTRO_TITULOS_CLIENTE = 10,
            CAIXA = 11,
            CONTROLE_ESTOQUE = 12,
            GERENCIA_CAIXA = 13,
            INTERESSES_CLIENTE = 14,
            NOVO_PEDIDOS = 15,
            TELA_CLIENTES = 16,
            TELA_RELATORIO_PEDIDOS = 17,
            TELA_RELATORIO_PRODUTOS = 18,
            TELA_RELATORIO_TITULO_CLIENTES = 19,
            CADASTRO_FORMAPAGAMENTO = 20,
            LISTAGEM_PRODUTOS = 21,
            CADASTRO_USUARIO = 22,
            CADASTRO_PERFIL = 23,
            PARAMETROS = 24,
            LOGIN_USUARIOS = 25,
            NEGOCIACAO_TITULO = 26,
            CADASTRO_CHAMADO = 27,
            LISTAR_TODOS_CHAMADOS = 28,
            LISTAR_CHAMADO = 29,
            FILTRO_RELATORIOSMENSAIS = 30,
            FILTRO_RELATORIOSSEMANAAIS = 31,
            FILTRO_RELATORIOCOMPLETO = 32,
            FILTRO_RELATORIOPRODUTOSCADASTRADOS = 33,
            FILTRO_RELATORIOCAIXAS = 34,
            FILTRO_RELATORIOVENDAS = 35,
            FILTRO_RELATORIOTITULOS = 36,
            CADASTRO_PARCELAS = 37,
            CADASTRO_TIPODESPESA = 38,
            GERENCIAMENTO_DESPESAS = 39,
            RELATORIO_DESPESAS = 40,
            CADASTRO_RECEITA = 41,
            RELATORIO_RECEITAS = 42,
            CONTROLE_BOTOESCADASTRO = 43,
            CONTROLE_CREDIARIO = 44,
            FILTRO_RELATORIOMARCAS = 45,
            FILTRO_RELATORIOGRUPOS = 46,
            FILTRO_RELATORIOCLIENTESCOMPRADORES = 47,
            LISTAGEM_VERSOES = 48,
            CONFIGURACAO_EMAIL = 49,
            LISTAGEM_EMAILS = 50,
            CONFIGURACAO_DADOS_LOJA = 51,
            PRODUTOS_CLIENTES_INTERESSADOS = 52
        }

        /// <summary>
        /// Tarefa sendo executada na tela
        /// </summary>
        public enum Tarefa
        {
            INCLUINDO = 0,
            EDITANDO = 1,
            EXCLUINDO = 2,
            VISUALIZANDO = 3
        }

        /// <summary>
        /// Enumerator for type of data
        /// </summary>
        public enum DataType
        {
            DATE = 1,
            INT = 2,
            STRING = 3,
            CHAR = 4,
            DECIMAL
        }

        public enum Status
        {
            // Status desativado
            DESATIVADO = 0,
            // Status ativado
            ATIVO = 1
        }

        public enum ArquivosGerados
        {
            // Arquivos da UTIL
            UTIL = 0,
            // Arquivos do Model
            MODEL = 1
        }
    }
}
