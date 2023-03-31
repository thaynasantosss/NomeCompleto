string Nome, Sobrenome;
Console.Write("Digite seu primeiro nome: ");
Nome = Console.ReadLine()!;

Console.Write("Digite seu sobrenome: ");
Sobrenome = Console.ReadLine()!;

string NomeCompleto = Nome + " " + Sobrenome;
string NomeCatálogo = Sobrenome.ToUpper() + ", " + Nome;

Console.WriteLine("Seu nome completo é:");
Console.WriteLine(NomeCompleto);


Console.WriteLine("Seu Nome de Catálogo é:"); 
Console.WriteLine(NomeCatálogo);