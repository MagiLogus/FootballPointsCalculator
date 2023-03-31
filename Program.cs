// Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

// Algoritimo 
// Entrada: gols time A / gols time B
// Proscessamento: 

//Entrada 

Console.WriteLine(@$"
--------------------------------
|        Programa para         |
|    calcular pontos de uma    |
|      partida de futebol      |
--------------------------------
");

Console.WriteLine($"Informe o placar do time A:");
int timeA = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o placar do time B:");
int timeB = int.Parse(Console.ReadLine());

// Processamento 


// Saida
if(timeA>timeB)
{
Console.WriteLine($"Vitória do time A !");
}
else if (timeB>timeA)
{
Console.WriteLine($"Vitória do time B !");   
}
else
{
Console.WriteLine($"Empate !");  
}
Console.WriteLine($"O placar do jogo foi de: time A {timeA} pontos X time B {timeB} pontos"); 