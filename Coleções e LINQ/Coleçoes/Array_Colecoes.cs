namespace Coleções_e_LINQ.Coleçoes
{
    public class Array_Colecoes
    {
         private int[] array;

        public Array_Colecoes (int tamanho)
        {
            array = new int[tamanho];
        }

        public int pegar_valor(int indice)
        {
            int valor = 0;
            try
            {
                valor = array[indice];
            }
            catch(IndexOutOfRangeException)
            {
                System.Console.WriteLine("Índice fora do vetor");
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Erro genério");
                System.Console.WriteLine(e.Message);
            }
            return valor;
        }

        public bool inserir_valor(int indice)
        {
            bool validade = false;
            try
            {
                array [indice] = int.Parse(Console.ReadLine());
                validade = true;
            }
            catch(ArgumentNullException)
            {
                System.Console.WriteLine("Valor nulo inválido");
            }
            catch(ArgumentOutOfRangeException e)
            {
                System.Console.WriteLine("Erro de range");
                System.Console.WriteLine(e.Message);
            }
            catch(FormatException)
            {
                System.Console.WriteLine("Insira apenas valores numéricos");
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Erro generico de Exception");
                System.Console.WriteLine(e.Message);
            }
            return validade;
        }

        public void imprimir_array ()
        {
            foreach(var item in array)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}