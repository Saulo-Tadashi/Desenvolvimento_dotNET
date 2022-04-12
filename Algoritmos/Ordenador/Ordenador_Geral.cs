namespace Algoritmos.Ordenador
{
    public abstract class Ordenador_Geral : IOrdenador
    {
        protected int contador;
        protected string meu_nome;

        public Ordenador_Geral ()
        {
            meu_nome = "Ordenador Geral";
        }

        public abstract bool ordenar_array (ref int[] ar);

        public void imprimir_array (ref int[] ar)
        {
            System.Console.WriteLine("Tipo de ordenação - "+meu_nome);
            foreach(var item in ar)
                System.Console.Write($"{item} ");
            System.Console.WriteLine();            
        }

        public int obter_contador()
        {
            return contador;
        }
    }
}