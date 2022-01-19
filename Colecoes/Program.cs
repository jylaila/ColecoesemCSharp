using Colecoes.Helper;

//declarando um array de comprimento 3
int[] arrayInteiros = new int[3];

//atribuição
arrayInteiros[0] = 4;

//percorrendo array
for (int i = 0; i < arrayInteiros.Length; i++)
{
    System.Console.WriteLine(arrayInteiros[i]);
}

foreach (var item in arrayInteiros)
{
    System.Console.WriteLine(item);
}

//Array Multidimensional
int[,] matriz = new int[4, 2];

//atribuição
matriz[0, 0] = 14;
//ou
int[,] matriz2 = new int[4, 2]{
    {3,8}, //1 linha com 2 colunas
    {7,10},
    {14,16},
    {18,20}
};
//getLenght(0) comprimento Linhas
//getLenght(1) comprimento colunas
for (int i = 0; i < matriz2.GetLength(0); i++)
{
    for (int j = 0; j < matriz2.GetLength(1); j++)
    {
        System.Console.WriteLine(matriz2[i,j]);
    }

}

//bubble sort
int[] array = {3,6,8,1,9};
OperacoesArray op = new OperacoesArray();

op.OrdenarBubbleSort(array);
op.ImprimirArray(array);

//sort da classe Array
op.Ordenar(array);
op.ImprimirArray(array);


//copiar array
int[] arrayOrigem = {3,4,56,7,8};
int[] arrayDestino = new int[10];
op.Copiar(arrayOrigem, arrayDestino);

//verificar se elemento existe no array
int x = 1;
bool existe = op.Existe(array,x);
System.Console.WriteLine(existe);

//verificar se todos elementos são maior que o valor
int y = 10;
bool todosMaiorque = op.TodosMaiorque(array, y);
System.Console.WriteLine(todosMaiorque);

//retornar elemento do array, retorna 0 se não encontrar
int valorProcurado = 7;
int achou = op.ObterValor(array, valorProcurado);
System.Console.WriteLine(todosMaiorque);

//retornar indice do elemento do array, retorna -1 se não encontrar
int indice = op.ObterIndice(array, valorProcurado);
System.Console.WriteLine(indice);

//redimensionar array
System.Console.WriteLine("Capacidade atual:{0} ", array.Length);
op.RedimensionarArray(ref array, array.Length*2);
System.Console.WriteLine("Capacidade redimensionada:{0} ", array.Length);

//converter array int para array string
string[] arrayString = op.ConverteArrayParaString(array);