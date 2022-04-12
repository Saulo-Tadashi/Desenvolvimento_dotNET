using System;
using Colecoes_e_LINQ.Colecoes;

namespace Colecoes_e_LINQ
{
    class Program
    {
        public static void Main ()
        {
            int tamanho = 0, linhas = 0;
            Array_Enum tipo = Array_Enum.Invalido;
            string? entrada = "";

            do
            {
                System.Console.WriteLine("Escolha entre as opções abaixo:");
                System.Console.WriteLine("1 - Vetor");
                System.Console.WriteLine("2 - Matriz");
                try
                {
                    string? temp;
                    switch ((entrada = Console.ReadLine())) {
                        case "1":    
                            System.Console.WriteLine("Digite o tamanho do vetor:");
                            if((temp = System.Console.ReadLine())!= null)
                            {
                                tamanho = int.Parse(temp);
                                tipo = Array_Enum.Vetor;
                            }
                            break;
                        case "2":
                            System.Console.WriteLine("Digite a altura da matriz:");
                            if((temp = System.Console.ReadLine()) != null)
                            {
                                linhas = int.Parse(temp);
                                System.Console.WriteLine("Digite a largura da matriz");

                                if((temp = System.Console.ReadLine()) != null)
                                {
                                    tamanho = int.Parse(temp);
                                    tipo = Array_Enum.Matriz;
                                }
                            }
                            break;
                        case "0":
                            return;
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