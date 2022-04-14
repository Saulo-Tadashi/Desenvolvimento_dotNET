namespace Algoritmos.Ordenador
{
    public interface IOrdenador
    {
        public bool ordenar_array (ref int[] ar);   

        public void imprimir_array (in int[] ar);

        public int obter_contador ();
    }
}