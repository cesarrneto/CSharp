using System;
using CalculadoraDeOrcamentos;
using Exames;


ExamesLaboratoriais betaHCG = new();
betaHCG.NomeExame = "Beta-HCG";
betaHCG.Valor = 24;

ExamesLaboratoriais hemograma = new();
hemograma.NomeExame = "Hemograma Completo";
hemograma.Valor = 10;

ExamesLaboratoriais vdrl= new();
vdrl.NomeExame = "V.D.R.L";
vdrl.Valor = 7.5;

ExamesLaboratoriais toxicologico = new();
toxicologico.NomeExame = "Toxicológico";
toxicologico.Valor = 120;

Registro orcamento = new();
orcamento.RegistrarValor(hemograma);
orcamento.RegistrarValor(betaHCG);
orcamento.RegistrarValor(vdrl);
orcamento.RegistrarValor(toxicologico);


//Console.WriteLine(orcamento.TotalDoOrcamento());




List<double> listaValores = new List<double> {};

listaValores.Add(20.50);
listaValores.Add(50);

Console.WriteLine($"Aqui está a sua lista: {listaValores}");
