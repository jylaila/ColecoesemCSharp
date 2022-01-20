namespace Colecoes.Helper
{
    public class OperacoesLista
    {
        public void imprimirLista(List<String> lista)
        {
            foreach (var item in lista)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}