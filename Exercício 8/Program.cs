using System;

class Program
{
    static void Main(string[] args)
    {
        Controle controle = new Controle();

        // Adicionando funcionários
        controle.AdicionarFuncionario("João", 30);
        controle.AdicionarFuncionario("Maria", 35);

        // Adicionando dependentes
        controle.AdicionarDependente(0, "Pedro", 5);
        controle.AdicionarDependente(0, "Paula", 3);
        controle.AdicionarDependente(1, "Carlos", 10);
        controle.AdicionarDependente(1, "Ana", 7);

        // Listando dependentes
        controle.ListarDependentes(0);
        Console.WriteLine();
        controle.ListarDependentes(1);
    }
}


public class Dependente
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Dependente(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

public class Funcionario
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<Dependente> Dependentes { get; set; }

    public Funcionario(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        Dependentes = new List<Dependente>();
    }

    public void AdicionarDependente(string nome, int idade)
    {
        Dependente dependente = new Dependente(nome, idade);
        Dependentes.Add(dependente);
    }

    public void ListarDependentes()
    {
        Console.WriteLine("Dependentes do funcionário " + Nome + ":");
        foreach (Dependente dependente in Dependentes)
        {
            Console.WriteLine(dependente.Nome + " - " + dependente.Idade + " anos");
        }
    }
}

public class Controle
{
    public List<Funcionario> Funcionarios { get; set; }

    public Controle()
    {
        Funcionarios = new List<Funcionario>();
    }

    public void AdicionarFuncionario(string nome, int idade)
    {
        Funcionario funcionario = new Funcionario(nome, idade);
        Funcionarios.Add(funcionario);
    }

    public void AdicionarDependente(int indiceFuncionario, string nome, int idade)
    {
        Funcionario funcionario = Funcionarios[indiceFuncionario];
        funcionario.AdicionarDependente(nome, idade);
    }

    public void ListarDependentes(int indiceFuncionario)
    {
        Funcionario funcionario = Funcionarios[indiceFuncionario];
        funcionario.ListarDependentes();
    }
}
