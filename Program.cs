using PropriedadesMetodos.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

//decimal valorMonetario = 83.40M;

//Console.WriteLine($"{valorMonetario:C}");
//Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
//Console.WriteLine(valorMonetario.ToString("C4"));

double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));

int numero = 121122;
Console.WriteLine(numero.ToString("##-##-##"));
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




