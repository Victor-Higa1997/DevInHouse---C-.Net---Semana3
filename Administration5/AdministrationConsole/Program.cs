
using Administration.Core;

var pessoa = new Pessoa();
var pessoa2 = new Pessoa("Victor Higa", 25, "Masculino");

Console.WriteLine($"Nome: {pessoa2.Nome}, Idade: {pessoa2.Idade}, Sexo: {pessoa2.Sexo}");
Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Sexo: {pessoa.Sexo}");