using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("123456", "Modelo 1", "1111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone iPhone");
Smartphone iphone = new Iphone("654321", "Modelo 2", "2222222", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");