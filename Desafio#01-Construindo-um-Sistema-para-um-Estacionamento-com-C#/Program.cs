using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "987654321", modelo: "Nokia 3310", imei: "0800987654321", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");



Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "123456789", modelo: "iPhone 13", imei: "0800123456789", 64);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");