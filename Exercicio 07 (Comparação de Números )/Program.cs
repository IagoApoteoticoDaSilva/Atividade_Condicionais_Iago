/*
 * Comparação de Números
 
 * Objetivo: Praticar a comparação entre variáveis. 

 * Descrição: Escreva um programa que solicita dois números ao usuário e determina qual deles é maior. Utilize if, else if e else para exibir a mensagem adequada. 
 
 * Exemplo de Saída: "O primeiro número é maior.", "O segundo número é maior." ou "Os números são iguais." 
 */

Console.WriteLine("Digite um numero ");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro numero ");
int numero2 = int.Parse(Console.ReadLine());

if (numero1 < numero2)
{
    Console.WriteLine("O segundo numero digitado é maior.");
}
else if (numero1 > numero2)
{    
    Console.WriteLine("O primeiro numero digitado é maior"); 
}
else if (numero1  == numero2)
{
    Console.WriteLine("Os dois numeros digitados são iguais");
}
