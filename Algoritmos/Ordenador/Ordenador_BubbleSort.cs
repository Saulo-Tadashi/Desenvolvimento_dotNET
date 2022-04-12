namespace Algoritmos.Ordenador
{
    public class Ordenador_BubbleSort : Ordenador_Geral, IOrdenador
    {
        public Ordenador_BubbleSort ()
        {
            this.meu_nome = "BubbleSort";
        }

        public override bool ordenar_array (ref int[] ar)
        {
            int temp;
            contador = 0;
            for(var i = 0; i < ar.Length - 1; i++)
            {
                for(var j = 0; j < ar.Length - 1 - i; j++)
                {
                    if(ar[j] > ar[j+1])
                    {
                        temp = ar[j];
                        ar[j] = ar[j+1];
                        ar[j+1] = temp;
                    }       
                    contador++;
                }
                //imprimir_array(ref ar);
            }
            return false;
        }   
    }
}