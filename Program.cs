using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "99887766", modelo: "Modelo 1", imei:"2222222", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagtram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iPhone = new Iphone(numero: "11223344", modelo: "Modelo 2", imei:"333333", memoria:128);
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("X");