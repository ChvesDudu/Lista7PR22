using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio1


            int quantidadeTotal = 0;
            double precoTotal = 0;

            while (true)
            {
                Console.WriteLine("Digite a quantidade de itens do produto (digite 0 ou um número negativo para encerrar): ");
                int quantidade = int.Parse(Console.ReadLine());

                if (quantidade <= 0)
                {
                    break;
                }

                Console.WriteLine("Digite o preço do produto: ");
                double preco = double.Parse(Console.ReadLine());

                quantidadeTotal += quantidade;
                precoTotal += quantidade * preco;
            }

            Console.WriteLine("Total de itens adquiridos: " + quantidadeTotal);
            Console.WriteLine("Valor total da compra: R$" + precoTotal.ToString("F2"));
            Console.ReadLine();

            //Exercico2

            {
                string nomeProdutoMaiorInvestimento = "";
                double maiorInvestimento = 0;
                string nomeProdutoMenorInvestimento = "";
                double menorInvestimento = double.MaxValue;

                while (true)
                {
                    Console.WriteLine("Digite o nome do produto (digite 'fim' para encerrar): ");
                    string nomeProduto = Console.ReadLine();

                    if (nomeProduto.ToLower() == "fim")
                    {
                        break;
                    }

                    Console.WriteLine("Digite o número de itens do produto: ");
                    int numeroItens = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o preço de compra do produto: ");
                    double precoCompra = double.Parse(Console.ReadLine());

                    double investimentoProduto = numeroItens * precoCompra;

                    if (investimentoProduto > maiorInvestimento)
                    {
                        maiorInvestimento = investimentoProduto;
                        nomeProdutoMaiorInvestimento = nomeProduto;
                    }

                    if (investimentoProduto < menorInvestimento)
                    {
                        menorInvestimento = investimentoProduto;
                        nomeProdutoMenorInvestimento = nomeProduto;
                    }
                }

                Console.WriteLine("Maior investimento: " + nomeProdutoMaiorInvestimento + " - R$" + maiorInvestimento.ToString("F2"));
                Console.WriteLine("Menor investimento: " + nomeProdutoMenorInvestimento + " - R$" + menorInvestimento.ToString("F2"));
                Console.ReadLine();
            }

            //Exercico3

            {
                int numAvaliacoes;
                double pesoTotal = 0;

                Console.Write("Digite o número de avaliações: ");
                numAvaliacoes = Convert.ToInt32(Console.ReadLine());

                int i = 1;
                while (i <= numAvaliacoes)
                {
                    Console.Write($"Digite o peso da avaliação {i}: ");
                    double peso = Convert.ToDouble(Console.ReadLine());
                    pesoTotal += peso;
                    i++;
                }

                Console.WriteLine($"Peso total das avaliações: {pesoTotal}");

                if (pesoTotal < 100)
                {
                    Console.WriteLine("Soma total dos pesos é insuficiente.");
                }
                else if (pesoTotal > 100)
                {
                    Console.WriteLine("Soma total dos pesos é excedente.");
                }
                else
                {
                    Console.WriteLine("Soma total dos pesos é adequada.");
                }
            }

            //Exercicio4

            {
                Console.Write("Digite a sigla do estado: ");
                string sigla = Console.ReadLine().ToUpper();

                switch (sigla)
                {
                    case "AC":
                        Console.WriteLine("Acre");
                        break;
                    case "AL":
                        Console.WriteLine("Alagoas");
                        break;
                    case "AP":
                        Console.WriteLine("Amapá");
                        break;
                    case "AM":
                        Console.WriteLine("Amazonas");
                        break;
                    case "BA":
                        Console.WriteLine("Bahia");
                        break;
                    case "CE":
                        Console.WriteLine("Ceará");
                        break;
                    case "DF":
                        Console.WriteLine("Distrito Federal");
                        break;
                    case "ES":
                        Console.WriteLine("Espírito Santo");
                        break;
                    case "GO":
                        Console.WriteLine("Goiás");
                        break;
                    case "MA":
                        Console.WriteLine("Maranhão");
                        break;
                    case "MT":
                        Console.WriteLine("Mato Grosso");
                        break;
                    case "MS":
                        Console.WriteLine("Mato Grosso do Sul");
                        break;
                    case "MG":
                        Console.WriteLine("Minas Gerais");
                        break;
                    case "PA":
                        Console.WriteLine("Pará");
                        break;
                    case "PB":
                        Console.WriteLine("Paraíba");
                        break;
                    case "PR":
                        Console.WriteLine("Paraná");
                        break;
                    case "PE":
                        Console.WriteLine("Pernambuco");
                        break;
                    case "PI":
                        Console.WriteLine("Piauí");
                        break;
                    case "RJ":
                        Console.WriteLine("Rio de Janeiro");
                        break;
                    case "RN":
                        Console.WriteLine("Rio Grande do Norte");
                        break;
                    case "RS":
                        Console.WriteLine("Rio Grande do Sul");
                        break;
                    case "RO":
                        Console.WriteLine("Rondônia");
                        break;
                    case "RR":
                        Console.WriteLine("Roraima");
                        break;
                    case "SC":
                        Console.WriteLine("Santa Catarina");
                        break;
                    case "SP":
                        Console.WriteLine("São Paulo");
                        break;
                    case "SE":
                        Console.WriteLine("Sergipe");
                        break;
                    case "TO":
                        Console.WriteLine("Tocantins");
                        break;
                    default:
                        Console.WriteLine("Sigla de estado inválida.");
                        break;
                }
            }

            //Exercicio5

            {
                int mes;
                string estacao;

                Console.WriteLine("Digite um número inteiro entre 1 e 12:");
                while (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12)
                {
                    Console.WriteLine("Entrada inválida. Digite um número inteiro entre 1 e 12:");
                }

                switch (mes)
                {
                    case 12:
                    case 1:
                    case 2:
                        estacao = "Inverno";
                        break;
                    case 3:
                    case 4:
                    case 5:
                        estacao = "Primavera";
                        break;
                    case 6:
                    case 7:
                    case 8:
                        estacao = "Verão";
                        break;
                    case 9:
                    case 10:
                    case 11:
                        estacao = "Outono";
                        break;
                    default:
                        Console.WriteLine("Mês inválido.");
                        return;
                }

                if ((mes == 3 && mes == 6) || mes == 9)
                {
                    Console.WriteLine("O mês escolhido pode ser tanto " + estacao + " quanto " + estacaoAnterior(mes) + ".");
                }
                else
                {
                    Console.WriteLine("O mês escolhido é " + estacao + ".");
                }
            }
            string estacaoAnterior(int mes)
            {
                switch (mes)
                {
                    case 3:
                        return "Inverno";
                    case 6:
                        return "Outono";
                    default:
                        return "Verão";
                }
            }

            //Exercicio6

            {
                double peso, altura, imc;

                Console.WriteLine("Digite o seu peso em kg: ");
                peso = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a sua altura em metros: ");
                altura = double.Parse(Console.ReadLine());

                imc = peso / (altura * altura);

                Console.Write("Seu IMC é: " + imc.ToString("F2") + " - ");

                while (true)
                {
                    if (imc < 18.5)
                    {
                        Console.WriteLine("Abaixo do peso");
                        break;
                    }
                    else if (imc < 25)
                    {
                        Console.WriteLine("Peso normal");
                        break;
                    }
                    else if (imc < 30)
                    {
                        Console.WriteLine("Sobrepeso");
                        break;
                    }
                    else if (imc < 35)
                    {
                        Console.WriteLine("Obesidade grau 1");
                        break;
                    }
                    else if (imc < 40)
                    {
                        Console.WriteLine("Obesidade grau 2");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Obesidade grau 3 (mórbida)");
                        break;
                    }
                }
            }

            //Exercicio7

            {
                int n;

                ///Solicita ao usuário um número N maior que zero
                do
                {
                    Console.Write("Digite um número inteiro maior que zero: ");
                } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

                Console.Write($"Divisores de {n}: ");

                ///Imprime todos os divisores de N
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.Write(i + " ");
                    }
                }

                Console.WriteLine(); ///Quebra de linha
            }
        }
    }
}
