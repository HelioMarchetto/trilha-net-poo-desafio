using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia("123", "G21", "NO188753", 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("");

Console.WriteLine("Smartphone iPhone: ");
Iphone iphone = new Iphone(numero: "1254", modelo: "Iphone 13", iMEI: "IP1228869", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");