/*
 * Objetivo: Praticar a utilização de múltiplas condições com if, else if e else.
 
 * Descrição: Desenvolva um programa que peça um número de 1 a 7 e exiba o dia da semana correspondente (1 para "Domingo", 2 para "Segunda-feira", etc.). Se o número estiver fora desse intervalo, exiba uma mensagem de erro.
 
 * Exemplo de Saída: "Domingo", "Segunda-feira", etc., ou "Número inválido. Digite um número de 1 a 7." 
 */
 

Console.WriteLine("Digite um numero de 1 a 7");
int numero = int.Parse(Console.ReadLine());

if (numero == 1)
{
    Console.WriteLine("Seu numero é Domingo");
}
else if (numero == 2)
{
    Console.WriteLine("Seu numero é Segunda-feira");
}
else if (numero == 3)
{
    Console.WriteLine("Seu numero é Terça-feira");
}
else if (numero == 4)
{
    Console.WriteLine("Seu numero é Quarta-feira");
}
else if (numero == 5)
{
    Console.WriteLine("Seu numero é Quinta-feira");
}
else if (numero == 6)
{
    Console.WriteLine("Seu numero é Sexta-feira");
}
else if (numero == 7)
{
    Console.WriteLine("Seu numero é Sabado");
}
else
{
    Console.WriteLine("Numero inalido. Digite um numero de 1 a 7");
}