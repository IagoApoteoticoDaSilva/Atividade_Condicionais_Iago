/*
 * Verificação de Idade
 
 *Objetivo: Aplicar condições para classificar dados. 
 
 *Descrição: Desenvolva um programa que solicite a idade de uma pessoa e determine se ela é maior de idade (18 anos ou mais) ou menor de idade. Utilize if e else para mostra a mensagem apropriada. 
 
 *Exemplo de Saída: "Você é maior de idade." ou "Você é menor de idade." 
*/

Console.WriteLine("Digite uma idade");
int idade = int.Parse(Console.ReadLine());

if  (idade >= 18)
{
    Console.WriteLine("Esta pessoa é maior de idade");
}
else
{
    Console.WriteLine("Esta pessoa é menor de idade");
}