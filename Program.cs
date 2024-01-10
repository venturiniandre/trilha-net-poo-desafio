using DesafioPOO.Models;

Console.WriteLine("New Smartphone Nokia");
Smartphone nokia = new Nokia (numero: "827425493", modelo: "Modelo Nokia 5", imei: "846198689", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.DetalhesSmartphone();

Console.WriteLine("\n");
Console.WriteLine("---------------------");
Console.WriteLine("---------------------");
Console.WriteLine("\n");

Console.WriteLine("New Smartphone Iphone");
Smartphone iphone = new Iphone (numero: "639451856", modelo: "Modelo Iphone 12", imei: "256584443", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("XP Investimentos");
iphone.DetalhesSmartphone();