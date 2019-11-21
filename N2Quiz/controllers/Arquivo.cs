using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace N2Quiz.controllers
{
    class Arquivo
    {
        public Arquivo()
        {

        }

        public void SalvarRanking(Jogador jogador, string Diretorio, string Arquivo)
        {
            //Combinando diretório com o nome do arquivo
            string CaminhoCompleto = Path.Combine(Diretorio, Arquivo);
            bool CriarCabecalho = false;

            if (!File.Exists(CaminhoCompleto))
            {
                CriarCabecalho = true;                    
            }

            //Adicionando dados ao arquivo
            using (StreamWriter arquivo = File.AppendText(CaminhoCompleto))
            {
                string data = DateTime.Now.Date.ToString("dd/MM/yyyy");
                string hora = DateTime.Now.ToString("HH:mm:ss");               

                if (CriarCabecalho)
                    arquivo.WriteLine("Data;Hora;Jogador;Questoes;Pontuacao");

                arquivo.WriteLine("{0};{1};{2};{3};{4}",
                            data,                                   //0-Data
                            hora,                                   //1-Hora
                            jogador.Nome,                           //2-Nome do jogador
                            jogador.NumeroQuestoes.ToString(),      //3-Acertos
                            String.Format("{0:0.00}", jogador.Pontuacao)    //4-Pontuação (%)
                    );
            }
        }
        
        public bool SalvarPergunta(Pergunta pergunta, string Diretorio, string Arquivo)
        {
            bool status = false;
            //Combinando diretório com o nome do arquivo
            string CaminhoCompleto = Path.Combine(Diretorio, Arquivo);
            bool CriarCabecalho = false;
            int NumeroPerguntas = 0;

            if (!File.Exists(CaminhoCompleto))
            {
                CriarCabecalho = true;
            }
            else
            {
                //Lê a quantidade de linhas e supoe a quantidade de perguntas
                NumeroPerguntas = File.ReadLines(CaminhoCompleto).Count();
                Console.WriteLine("A quantidade de perguntas: " + NumeroPerguntas);
            }

            //Adicionando dados ao arquivo
            using (StreamWriter arquivo = File.AppendText(CaminhoCompleto))
            {

                if (CriarCabecalho)
                    arquivo.WriteLine("Numero;Pergunta;AlternativaA;AlternativaB;AlternativaC;AlternativaD;Resposta");

                arquivo.WriteLine("{0};{1};{2};{3};{4};{5};{6}",
                    NumeroPerguntas,
                    pergunta.Questao,
                    pergunta.AlternativaA,
                    pergunta.AlternativaB,
                    pergunta.AlternativaC,
                    pergunta.AlternativaD,
                    pergunta.Resposta
                );
                status = true;
            }

            return status;
        }

        public DataTable Abrir(string Diretorio, string Arquivo)
        {
            //Combinando o local do arquivo com o nome do arquivo
            string CaminhoCompleto = Path.Combine(Diretorio, Arquivo);
            
            //instanciando uma tabela de dados
            DataTable dataTable = new DataTable();
            
            if (File.Exists(CaminhoCompleto))
            {
                using (StreamReader arquivo = File.OpenText(CaminhoCompleto))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }

                //verificando se o arquivo existe
                if (!File.Exists(CaminhoCompleto))
                {
                    MessageBox.Show("O arquivo de ranking não foi encontrado em " + CaminhoCompleto);
                }
                else
                {
                    //lendo o conteúdo do arquivo e armazenando na memória
                    StreamReader streamReader = new StreamReader(CaminhoCompleto);
                    {
                        //lendo uma linha da memória
                        string linha = streamReader.ReadLine();
                        //procura pelo caracter separador e separa
                        string[] arrayRanking = linha.Split(';');

                        //percorre as colunas
                        foreach (string value in arrayRanking)
                        {
                            //adicionando as colunas
                            dataTable.Columns.Add(value.Trim());
                        }
                        //criando dados de linha
                        DataRow dataRow = dataTable.NewRow();

                        while (streamReader.Peek() >= 0)
                        {
                            //lê uma linha da memória
                            linha = streamReader.ReadLine();
                            //procura pelo caractere separador e separa
                            arrayRanking = linha.Split(';');
                            //adiciona o array na tabela
                            dataTable.Rows.Add(arrayRanking);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("O arquivo de ranking não existe.");
            }

            //retorna a tabela de dados
            return dataTable;
        }
    }
}
