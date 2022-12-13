using System.Collections.Generic;
using System.IO;
using PropriedadesMetodos.Models;
using System.Globalization;
using Newtonsoft.Json;


string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda =  JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}"+
                    $"Preço {venda.Preco}, Data {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}







/*
DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1,"Material de escritorio", 25.00M , dataAtual);
Venda v2 = new Venda(2,"Licença de Software", 110.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas,Formatting.Indented);
Console.WriteLine(serializado);
File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);*/


//If ternario






/*
int numero = 15;
bool ehPar = false;
ehPar = numero % 2 == 0;

Console.WriteLine($"O numero {numero} é " +(ehPar ? "par" : "impar"));*/




/*
if(numero % 2 == 0)
{
   Console.WriteLine($"O numero {numero} é par");
}
else
{
    Console.WriteLine($"O numero {numero} é impar");
}*/










/*
Pessoa p1 =  new Pessoa("Daniel","Oliveira");
(string nome ,string sobrenome) = p1;
Console.WriteLine($"{nome} {sobrenome}");*/















/*
LeituraArquivo arquivo =new LeituraArquivo();
var (sucesso,linhas , _) = arquivo.LerArquivo("Arquivos/ArquivoLeitura.txt");

if(sucesso)
{
    //Console.WriteLine("Quantidade linhas do Arquivos " + quantidadedeLinhas);
    foreach(string linha in linhas )
    {
        Console.WriteLine(linha);
    }

}
else
{
    Console.WriteLine("Não foi possivel ler o Arquivo");
}*/










/*
(int, string ,string, decimal) tupla = (1,"Daniel","Oliveira" , 10.5M);
//ValueTuple<int, string ,string, decimal> OutroExemploTupla =(2,"Carlos","Oliveira" , 12.5M);
//var ExemploCreate = Tuple.Create(1,"Carlos","Silva",12.4M);

Console.WriteLine($"Id: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");*/


/*
Dictionary<string , string> estados = new Dictionary<string, string>();


estados.Add("SP","São Paulo");
estados.Add("BA","Bahia");
estados["SP"] = "São Paulo - valor Alterado";

foreach(KeyValuePair<string ,string> item in estados)
{
    Console.WriteLine($" Chave:{item.Key}, Valor: {item.Value}");
}*/







/*
Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int  item in fila)
{
    Console.WriteLine(item);
}

fila.Dequeue();

Stack<int> pilha = new Stack<int>();

pilha.Push(1);
pilha.Push(10);

pilha.Pop();*/


//new ExemploExcecao().Metodo1();







/*
try
{
    string[] linhas =File.ReadAllLines("Arquivos/ArquivoLeitura.txt");
    foreach (string linha in linhas)
    {
    Console.WriteLine(linha);
    }

} catch(FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado.  {ex.Message}");
}catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"Caminho nao encontrdo.  {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma excessao generica.  {ex.Message}");
}
finally
{
     Console.WriteLine("Chegou até aqui");
}*/










//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

//decimal valorMonetario = 83.40M;

//Console.WriteLine($"{valorMonetario:C}");
//Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
//Console.WriteLine(valorMonetario.ToString("C4"));

/*double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));

int numero = 121122;
Console.WriteLine(numero.ToString("##-##-##"));


DateTime data = DateTime.Parse("17/04/2022 19:00");
Console.WriteLine(data);*/
/*Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());*/

/*string numero1 = "10";
int numero2 =20;

string resultado = numero1 + numero2;

Console.WriteLine(resultado);*/




/*Pessoa p1 = new Pessoa(nome: "Daniel",sobrenome: "Oliveira");
//p1.Idade = 31;
//p1.Apresentar();

Pessoa p2 = new Pessoa(nome: "Bruno",sobrenome: " Santos de Oliveira");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();*/




