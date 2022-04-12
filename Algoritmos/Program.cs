using Algoritmos.Ordenador;

namespace Algoritmos
{
    class Program
    {
        public static void Main (string[] arg)
        {
            //System.Console.WriteLine("Hellow World!");
            IOrdenador ord = new Ordenador_BubbleSort ();

            int[] vec = {10,9,8,7,6,5,4,3,2,1};

            //imprimir array antes da ordenação
            System.Console.WriteLine("Array desordenado:");
            ord.imprimir_array(ref vec);

            ord.ordenar_array(ref vec);

            //imprimir array depois da ordenação
            System.Console.WriteLine("Array ordenado:");
            ord.imprimir_array(ref vec);
            System.Console.WriteLine("Contador: "+ord.obter_contador());
        }
    }
}