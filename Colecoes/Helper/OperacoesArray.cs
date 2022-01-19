namespace Colecoes.Helper
{
    public class OperacoesArray
    {
        public void ImprimirArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine(array[i]);
            }
        }

        public void OrdenarBubbleSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }

            }
        }

        public void Ordenar(int[] array)
        {
            Array.Sort(array);
        }

        public void Copiar(int[] arrayOrigem, int[] arrayDestino)
        {
            Array.Copy(arrayOrigem, arrayDestino, arrayOrigem.Length);
        }

        public bool Existe(int[] array, int valor)
        {
            return Array.Exists(array, elemento => elemento == valor);
        }

        public bool TodosMaiorque(int[] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor);

        }

        public int ObterValor(int[] array, int valor)
        {//retorna primeira ocorrencia
            return Array.Find(array, elemento => elemento == valor);
        }

        public int ObterIndice(int[] array, int valor)
        {
            //return Array.FindIndex(array, elemento => elemento == valor);
            return Array.IndexOf(array, valor);
        }

        public void RedimensionarArray(ref int[] array, int novoTamanho){
            Array.Resize(ref array, novoTamanho);
        }

        public string[] ConverteArrayParaString(int[] array){
            return Array.ConvertAll(array, elemento=>elemento.ToString());
        }
    }
}