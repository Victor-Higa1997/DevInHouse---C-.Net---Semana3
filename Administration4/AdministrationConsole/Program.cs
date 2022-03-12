
using Administration.Core;

int somar = Calculadora.somar(5, 13);
int subtrair = Calculadora.subtrair(5, 13);
int multiplicar = Calculadora.multiplicar(5, 13);
int dividir = Calculadora.dividir(5, 13);

Console.WriteLine("------------- RESULTADO DAS OPERAÇÕES -------------");
Console.WriteLine($"A soma dos valores é: {somar}");
Console.WriteLine($"A subtração dos valores é: {subtrair}");
Console.WriteLine($"A multiplicação dos valores é: {multiplicar}");
Console.WriteLine($"A divisão dos valores é: {dividir}");
