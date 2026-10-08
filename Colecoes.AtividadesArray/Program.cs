var notas = new double [4]; // double informa que é um novo array de double

for (int contador = 0; contador < 4; contador++)
{
    Console.WriteLine($"Digite a nota {contador+1}: ");
    notas[contador] = Convert.ToDouble(Console.ReadLine());
}

var notasTotais = notas.Sum();
var media = notasTotais / 4;

Console.WriteLine($"A media de notas é {media}");