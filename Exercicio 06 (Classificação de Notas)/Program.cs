/*
 * Classificação de Notas
 
 * Objetivo: Aprender a usar múltiplas condições em uma estrutura de decisão. 
 
 * Descrição: Crie um programa que peça a nota de um aluno e classifique a nota em categorias: "Excelente" (nota >= 9), "Boa" (7 <= nota < 9), "Regular" (5 <= nota < 7) e "Baixa" (nota < 5). Exiba a classificação na tela. 
 
 * Exemplo de Saída: "Excelente", "Boa", "Regular" ou "Baixa". 
 */

Console.WriteLine("Digite a nota do aluno(a)");
Double nota = Double.Parse(Console.ReadLine());

if (nota >= 9)
{
    Console.WriteLine("Avaliação: Excelente");
}
else if (nota < 9 && nota >= 7)
{
    Console.WriteLine("Avaliação: Boa");
}
else if (nota < 7 && nota >= 5)
{
    Console.WriteLine("Avaliação: Regular");
}
else if (nota < 5)
{
    Console.WriteLine("Avaliação: Reprovado");
}