using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Modelo Pro", imei: "1111111111",memoria: 265);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "123456789", modelo: "Modelo Pro 14", imei: "2222222222",memoria: 265);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
