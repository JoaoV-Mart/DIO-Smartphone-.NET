using DesafioProjetoSmartphone.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456", "Modelo1", "11111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("4987", "Modelo2", "22222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");