using PropriedadesMetodos.Models;

Pessoa p1 = new Pessoa(nome: "Daniel",sobrenome: "Oliveira");
//p1.Idade = 31;
//p1.Apresentar();

Pessoa p2 = new Pessoa(nome: "Bruno",sobrenome: " Santos de Oliveira");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();



