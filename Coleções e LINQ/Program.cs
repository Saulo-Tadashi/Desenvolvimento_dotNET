using System;
using Coleções_e_LINQ.Coleçoes;

namespace Colecoes_e_LINQ
{
    class Program
    {
        public static void Main ()
        {
            int tamanho = 3;
            Array_Colecoes array = new Array_Colecoes(tamanho);
        
            for (int i = 0; i < tamanho; i++)
            {
               while(!array.inserir_valor(i));
            }

            array.imprimir_array();
        }
    }
}