// See https://aka.ms/new-console-template for more information


var p1 = new Pessoa("Marcus",new DateOnly(1982,05,07));
var p2 = new Pessoa("Yuri", new DateOnly(1997,12,14));
var p3 = new Pessoa("Manoel",new DateOnly(1987,05,11));

p1.AlterarNome("Marcus Souza");

var cachorrinho = new Cachorro() { Nome = "doguinho" };
var gatinho = new Gato() { Nome = "floquinho" };

p1.Pets.Add(cachorrinho);
p1.Pets.Add(gatinho);


Console.WriteLine($"Meu nome é {p1.Nome}");
Console.WriteLine($"Eu tenho {p1.Pets.Count} Pets");

foreach (var animal in p1.Pets)
{
    Console.WriteLine($"Meu {animal.GetType().Name} faz {animal.EmiteSom()}");
}

public class Pessoa
{

    public Pessoa(string nome, DateOnly idade)
    {
        this.Nome = nome;
        this.Idade = idade;
    }

    public string Nome { get; private set; }
	public DateOnly Idade;
    public List<Pet> Pets = new();

    public void AlterarNome(string nome) => Nome = nome;
}

public abstract class Pet
{
    public string Nome { get; set; }
    public abstract string EmiteSom();
}

public class Cachorro : Pet
{
	public override string EmiteSom()
	{
        return "Au Au";
	}
}

public class Gato : Pet
{
	public override string EmiteSom()
	{
		return "Miau";
	}
}