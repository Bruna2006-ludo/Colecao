// Criar um sistema que gerencie a quantidade de produtos em um estoque, identifique quais produtos estão acabando (estoque crítico)
// e permita buscar a quantidade de um item pelo seu código de identificação (índice).

Console.WriteLine("--- Controle de Estoque Crítico ---");
Console.WriteLine("Quantos produtos deseja cadastrar?  ");

int quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
int[] itens = new int [quantidadeProdutos];

for (var contador = 0; contador < quantidadeProdutos; contador++)
{
    Console.WriteLine($"Digite a quantidae em estoque do produto {contador + 1}: ");
    itens[contador] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("--- Alerta: Produtos com Estoque Crítico (< 5 unidades) ---");
for (var contador = 0; contador < quantidadeProdutos; contador++)
{
    if (itens[contador] < 5)
    {
        Console.WriteLine($"Produto {contador+1} está com estoque baixo: apenas {itens[contador]} unidades");
    }
}