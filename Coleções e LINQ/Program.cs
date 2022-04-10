using System;
using Coleções_e_LINQ.Coleçoes;

namespace Colecoes_e_LINQ
{
    class Program
    {
        public static void Main ()
        {
            int tamanho = 0, linhas = 0;
            Array_Enum tipo = Array_Enum.Invalido;
            string entrada = "";

            do
            {
                System.Console.WriteLine("Escolha entre as opções abaixo:");
                System.Console.WriteLine("1 - Vetor");
                System.Console.WriteLine("2 - Matriz");
                try
                {
                    entrada = Console.ReadLine();
                    switch (entrada) {
                        case "1":    
                            System.Console.WriteLine("Digite o tamanho do vetor:");
                            tamanho = int.Parse(System.Console.ReadLine());
                            tipo = Array_Enum.Vetor;
                            break;
                        case "2":
                            System.Console.WriteLine("Digite a altura da matriz:");
                            linhas = int.Parse(System.Console.ReadLine());
                            System.Console.WriteLine("Digite a largura da matriz");
                            tamanho = int.Parse(System.Console.ReadLine());
                            tipo = Array_Enum.Matriz;
                            break;
                        case "0":
                            return;
                            break;
                        default:
                            System.Console.WriteLine("Escolha inválida");
                            break;
                    }

                }
                catch(ArgumentNullException)
                {
                    System.Console.WriteLine("Valor nulo inválido");
                }
                catch(FormatException)
                {
                    System.Console.WriteLine("Apenas valores numéricos");
                }
                catch(Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
            }while (tipo == Array_Enum.Invalido && entrada != "0");
            
            Array_Colecoes array;
            
            array = (tipo == Array_Enum.Vetor)
                ? new Array_Colecoes(tamanho) 
                : new Array_Colecoes(linhas, tamanho);
        
            array.preencher_array();

            array.imprimir_array();
        }
    }
}