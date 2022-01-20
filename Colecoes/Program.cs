using System.Collections.Generic;
using Colecoes.Helper;


/*Trabalhando com LINQ*/
int[] arrayNumeros = { 1, 4, 8, 15, 19, 19 };

//criar novo array somente com números pares
//sintaxe de consulta
var numerosParesConsulta = from numbers in arrayNumeros
                   where numbers % 2 == 0
                   orderby numbers
                   select numbers;
System.Console.WriteLine(string.Join("-",numerosParesConsulta));

//sintaxe de método
var numerosParesMetodo = arrayNumeros.Where(x=> x%2 == 0).OrderBy(x=>x).ToList();

//Min, Máximo e Média com Linq
var min = arrayNumeros.Min(); // retorna o valor mínimo
var max = arrayNumeros.Max(); //retorna o valor máximo
var media = arrayNumeros.Average(); //retorna a média dos valores

//sum, distinct
var soma = arrayNumeros.Sum(); //retorna a soma
var arrayUnico = arrayNumeros.Distinct().ToArray(); //retorna elementos distintos de uma sequencia, convertido em array
System.Console.WriteLine(string.Join(" - ", arrayUnico));


/*criando um dicionário*/
//Dictionary<tipo da chave, tipo do valor>
Dictionary<string, string> estado = new Dictionary<string, string>();

//add elementos, as chaves não podem ser repetidas
estado.Add("MG", "Minas-Gerais");
estado.Add("SP", "São Paulo");
estado.Add("BA", "Bahia");

//percorrendo dicionario
foreach (KeyValuePair<string, string> item in estado)
{
    System.Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
}

//Acessando valores
string busca = "BA";
// estado[busca]; acessa o elemento pelo índice
System.Console.WriteLine(estado[busca]);

//Alterando valores
estado[busca] = "Bahia Atualizado";

//Removendo valor pela chave
estado.Remove("BA");

//acessando de forma segura
if (estado.TryGetValue(busca, out string valorEncontrado))
{
    System.Console.WriteLine(valorEncontrado);
}
else
{
    System.Console.WriteLine("Não existe o estado procurado");
}

/*Criando uma pilha - LiFo - Last in first out*/
Stack<String> pilha = new Stack<string>();

//add elementos
pilha.Push(".NET");
pilha.Push("ODD");
pilha.Push("Código Limpo");

//percorrendo
System.Console.WriteLine($"Livros disponíveis para leitura: {pilha.Count}");
while (pilha.Count > 0)
{
    //ultimo elemento no topo
    System.Console.WriteLine($"Próximo livro para leitura {pilha.Peek()}");
    //remove elementos
    System.Console.WriteLine($"{pilha.Pop()} lido com sucesso!");

}
System.Console.WriteLine($"Livros disponíveis para leitura: {pilha.Count}");

/*criando uma fila - FiFo - First in First out*/
Queue<String> fila = new Queue<String>();

//add elementos
fila.Enqueue("Janaina");
fila.Enqueue("Taylor");
fila.Enqueue("Noah");

//percorrer fila
System.Console.WriteLine($"Pessoas na fila {fila.Count}");
while (fila.Count > 0)
{
    System.Console.WriteLine($"Vez de {fila.Peek()}");
    //remove o elemento e retorna
    System.Console.WriteLine($"{fila.Dequeue()} atendido");
}
System.Console.WriteLine($"Pessoas na fila {fila.Count}");


/*criando coleção genérica*/
List<String> estados = new List<string>();
// List<String> estados = new List<string>{"SP", "MG"};
//adicionando elementos
estados.Add("SP");
estados.Add("MG");
estados.Add("BA");
//acessando qt de elementos
System.Console.WriteLine("Quantidade de elementos " + estados.Count);

//acessando elementos
OperacoesLista ol = new OperacoesLista();
ol.imprimirLista(estados);

//removendo elementos
estados.Remove("MG");
ol.imprimirLista(estados);

//adicionando uma coleção a uma lista
string[] estadoArray = { "SC", "MG" };
estados.AddRange(estadoArray);
ol.imprimirLista(estados);

//adicionando em um índice específico
estados.Insert(1, "RJ");

/*Declarando um array de comprimento 3*/
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

/*Array Multidimensional*/
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
        System.Console.WriteLine(matriz2[i, j]);
    }

}

/*bubble sort*/
int[] array = { 3, 6, 8, 1, 9 };
OperacoesArray op = new OperacoesArray();

op.OrdenarBubbleSort(array);
op.ImprimirArray(array);

//sort da classe Array
op.Ordenar(array);
op.ImprimirArray(array);

//copiar array
int[] arrayOrigem = { 3, 4, 56, 7, 8 };
int[] arrayDestino = new int[10];
op.Copiar(arrayOrigem, arrayDestino);

//verificar se elemento existe no array
int x = 1;
bool existe = op.Existe(array, x);
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
op.RedimensionarArray(ref array, array.Length * 2);
System.Console.WriteLine("Capacidade redimensionada:{0} ", array.Length);

//converter array int para array string
string[] arrayString = op.ConverteArrayParaString(array);