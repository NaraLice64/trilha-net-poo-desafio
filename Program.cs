using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "NokiaG60", imei: "112233", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "789101", modelo: "Iphone14", imei: "445566", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");