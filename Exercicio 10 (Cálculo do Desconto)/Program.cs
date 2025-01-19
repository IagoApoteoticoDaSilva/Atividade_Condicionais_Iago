/*
 * Objetivo: Aplicar condições para cálculos. 
 
 *Descrição: Escreva um programa que peça o valor de uma compra e verifique se o valor é maior que 100. Se sim, aplique um desconto de 10% no valor e mostre o valor final. Caso contrário, exiba o valor original.
 
 *Exemplo de Saída: "Valor com desconto: [valor final]." ou "Valor original: [valor] 
 */


Console.WriteLine("Digite o valor da compra: ");
float valorDaCompra = float.Parse(Console.ReadLine());

if (valorDaCompra > 100)
{
    float calculoDesconto = valorDaCompra / 10;
    float valorComDesconto = valorDaCompra - calculoDesconto;
    Console.WriteLine($"Total com desconto de 10% aplicado é: {valorComDesconto}R$");
}
else
{
    Console.WriteLine($"Total: {valorDaCompra}");
}


