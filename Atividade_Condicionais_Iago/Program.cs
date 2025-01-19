/*
 * Verificação de Paridade 
 
 * Objetivo: Praticar o uso do operador % (módulo) e estruturas condicionais simples. 
 
 * Descrição: Crie um programa que peça ao usuário para digitar um número inteiro. O programa deve verificar se o número é par ou ímpar. Utilize a condição if para determinar o resultado e exiba uma mensagem apropriada. 

 * Exemplo de Saída: "O número é par." ou "O número é ímpar."
*/

Console.WriteLine("Digite um numero ");
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("Seu numero é par");
}
else
{
    Console.WriteLine("Seu numero é impar");
}

