
using Administration.Core;

int somar = Calculadora.somar(5, 13);
int subtrair = Calculadora.subtrair(5, 13);
int multiplicar = Calculadora.multiplicar(5, 13);
int dividir = Calculadora.dividir(5, 13);

int somar2 = Calculadora.somar(5, 13, 4);
int subtrair2 = Calculadora.subtrair(5, 13, 5);
int multiplicar2 = Calculadora.multiplicar(5, 13, 2);

Console.WriteLine("------------- RESULTADO DAS OPERAÇÕES -------------");
Console.WriteLine($"A soma dos valores é: {somar2}");
Console.WriteLine($"A subtração dos valores é: {subtrair2}");
Console.WriteLine($"A multiplicação dos valores é: {multiplicar2}");
Console.WriteLine($"A divisão dos valores é: {dividir}");
