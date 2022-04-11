using System;
/** 
*
* Classe para operações de vetor e matriz com tipagem no momento da inicialização.
* Abstração e encapsulamento para tratamento uniforme para ambos os tipos.
*
*/
namespace Coleções_e_LINQ.Coleçoes
{
    enum Array_Enum : int
    {
     
        Invalido = -1,
        Matriz = 0,
        Vetor = 1
    }

    public class Array_Colecoes
    {
         private int[,] array;

        public Array_Colecoes (int tamanho)
        {
            array = new int[1,tamanho];
        }

        public Array_Colecoes (int linha, int coluna)
        {
            array = new int[linha, coluna];
        }

        private bool conferir_intervalo(int linha, int coluna)
        {
            if(conferir_linha(linha) && conferir_indice(coluna)) 
                return true;

            System.Console.WriteLine("Parâmetros incorretos para conferência de matriz");
            return false;
        }
        
        private bool conferir (int valor, Array_Enum dimensao)
        {
            return valor >=0 && valor < array.GetLength((int)(dimensao));
        }

        private bool conferir_linha(int linha)
        {
            return conferir (linha, Array_Enum.Matriz);
        }

        private bool conferir_indice(int indice)
        {
            return conferir (indice, Array_Enum.Vetor);
        }

        //Pegar valor com conferência de índice
        private int pegar_valor (int linha, int indice)
        {
            int valor = 0;
            try
            {
                if (conferir_intervalo(linha, indice))
                   valor = array[linha, indice];
                else 
                    System.Console.WriteLine("Índice fora do vetor;");
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Erro genério");
                System.Console.WriteLine(e.Message);
            }
            return valor;
        }
        
        //Guardar valor com conferência de índice e tipo de dado
        private bool inserir_valor(int linha, int indice)
        {
            bool validade = false;
            string? entrada;
            try
            {
                if(conferir_intervalo(linha, indice))
                {
                    do
                    {
                        try
                        {
                            if((entrada = Console.ReadLine()) != null)
                            {
                                array[linha, indice] = int.Parse(entrada);
                                validade = true;
                            }
                            else
                            {
                                System.Console.WriteLine("Entrada vazia inválida");
                            }
                        }
                        catch(ArgumentNullException)
                        {
                            System.Console.WriteLine("Valor nulo inválido");
                        }
                        catch(FormatException)
                        {
                            System.Console.WriteLine("Insira apenas valores numéricos");
                        }
                    }while (!validade);
                }
            }
            catch(ArgumentOutOfRangeException e)
            {
                System.Console.WriteLine("Erro de range");
                System.Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Erro generico de Exception");
                System.Console.WriteLine(e.Message);
            }
            return validade;
        }
        
        public bool preencher_array ()
        {
            bool validade = true;
            for(int i = 0; i < array.GetLength(0) && validade; i++)
            {
                System.Console.WriteLine($"Linha {i+1}");
                for(int j = 0; j < array.GetLength(1) && validade; j++)
                    validade = inserir_valor(i, j);
            }
            return validade;
        }

        public void imprimir_array ()
        {
            for(var i = 0; i < array.GetLength(0); i++)
            {
                System.Console.WriteLine($"Linha {i+1}");
                for(var j = 0; j < array.GetLength(1); j++)
                    System.Console.Write($"<{array[i,j]}>");
                System.Console.WriteLine("");
            }
        }
    }
}