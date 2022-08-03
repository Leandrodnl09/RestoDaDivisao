// Exercício do site URI "Resto da Divisão"
// Nesse programa o usuario irá digitar dois números "X" e "Y", iremos identificar qual deles e maior e realocar para ordem crescente.
// Depois o programa íra maostrar na tela quais os números são divisiveis por 5, o resoltado do resto da divisão tem que ser 3 ou 2.

int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());
int Troca;

if (X > Y)
{
    Troca = X;
    X = Y;
    Y = Troca;
}
for (int i = X + 1; i < Y; i ++)
{
    if (i % 5 == 2 || i % 5 == 3)
    {
        Console.WriteLine(i);
    }
}