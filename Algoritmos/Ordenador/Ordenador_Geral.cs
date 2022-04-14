namespace Algoritmos.Ordenador
{
    public abstract class Ordenador_Geral : IOrdenador
    {
        private int _contador;

        protected int contador
        {
            get => _contador;

            //apenas a classe mãe muda o contador
            private set => _contador = value < 0 ? 0 : value;
        }

        public int obter_contador() => contador;

        protected void reiniciar_contador() => contador = 0;

        protected void incrementar_contador() => contador++;

        protected string meu_nome;

        public Ordenador_Geral () =>meu_nome = "Ordenador Geral";

        public abstract bool ordenar_array (ref int[] ar);

        //forma única e uniforme de imprimir uma array de int
        public void imprimir_array (in int[] ar)
        {
            System.Console.WriteLine("Tipo de ordenação - "+meu_nome);
            
            //juntar os elementos em uma única linha
            var linha = string.Join(", ", ar);

            System.Console.Write($"{linha} ");
            System.Console.WriteLine();            
        }
    }
}