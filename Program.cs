﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Nokia n1 = new Nokia("");
// n1.Numero = "99887766";
// Console.WriteLine("");


// Nokia IMEI = new Nokia("55555");
// Nokia Modelo = new Nokia("");
// Nokia Memoria = new Nokia("");
// Console.WriteLine(n1.Numero);
// Iphone i1 = new Iphone("11223344");
// Console.WriteLine(i1.Numero);
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "99887766", modelo: "Modelo 1", imei:"2222222", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagtram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iPhone = new Iphone(numero: "11223344", modelo: "Modelo 2", imei:"333333", memoria:128);
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("X");