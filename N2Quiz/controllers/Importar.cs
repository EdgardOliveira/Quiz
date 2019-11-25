using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace N2Quiz.controllers
{
    class Importar
    {
        
        public string CaminhoArquivo { get; set; }
        public List<Pergunta> ListaPerguntas { get; set; }
        
        /// <summary>
        /// Método para ler o arquivo e carregar em um DataTable
        /// </summary>
        /// <param name="CaminhoArquivo">Caminho onde o arquivo está localizado</param>
        public Importar(string Diretorio, string Arquivo)
        {
            this.CaminhoArquivo = Path.Combine(Diretorio, Arquivo);
        }
        public DataTable CarregarDados()
        {
            //instanciando uma tabela de dados
            DataTable dataTable = new DataTable();

            //verificando se o arquivo existe
            if (!File.Exists(CaminhoArquivo))
            {
                MessageBox.Show("O arquivo de perguntas não foi encontrado em " + CaminhoArquivo);
            }
            else
            {
                //lendo o conteúdo do arquivo e armazenando na memória
                StreamReader streamReader = new StreamReader(CaminhoArquivo);
                {
                    //lendo uma linha da memória
                    string linha = streamReader.ReadLine();

                    //procura pelo caracter separador e separa
                    string[] arrayPergunta = linha.Split(';');

                    //percorre as colunas
                    foreach (string value in arrayPergunta)
                    {
                        dataTable.Columns.Add(value.Trim());
                    }
                    //criando dados de linha
                    DataRow dataRow = dataTable.NewRow();

                    while (streamReader.Peek() >= 0)
                    {
                        //lê uma linha da memória
                        linha = streamReader.ReadLine();

                        //procura pelo caractere separador e separa
                        arrayPergunta = linha.Split(';');

                        //adiciona o array na tabela
                        dataTable.Rows.Add(arrayPergunta);
                    }
                }
            }

            //retorna a tabela de dados
            return dataTable;
        }

        /// <summary>
        /// Método para converter um datatable em uma lista
        /// </summary>
        /// <param name="dataTable">Recebe a tabela de dados</param>
        public void ConvertDataTableToList (DataTable dataTable)
        {
            //instanciando uma lista de perguntas
            ListaPerguntas = new List<Pergunta>();

            //percorrendo a tabela até o fim
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                //instanciando a classe pergunta
                Pergunta pergunta = new Pergunta();

                //convertendo o que precisa e populando os dados
                pergunta.Numero = Convert.ToInt32(dataTable.Rows[i]["Numero"]);
                pergunta.Questao = dataTable.Rows[i]["Pergunta"].ToString();
                pergunta.AlternativaA = dataTable.Rows[i]["AlternativaA"].ToString();
                pergunta.AlternativaB = dataTable.Rows[i]["AlternativaB"].ToString();
                pergunta.AlternativaC = dataTable.Rows[i]["AlternativaC"].ToString();
                pergunta.AlternativaD = dataTable.Rows[i]["AlternativaD"].ToString();
                pergunta.Resposta     = dataTable.Rows[i]["Resposta"].ToString();
                
                //adiciona a pergunta a lista de perguntas
                ListaPerguntas.Add(pergunta);
            }
        }
    }
}
