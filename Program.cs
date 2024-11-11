using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// IMPLEMENTADO!

Console.WriteLine("Smartphone Nokia: ");
Smartphone Nokia = new Nokia(numero: "87998750104", modelo: "Modelo 1", imei: "2343536373", memoria: 64);
Nokia.Ligar();
Nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone Iphone = new Iphone(numero: "87998750104", modelo: "Modelo 1", imei: "2343536373", memoria: 64);
Iphone.Ligar();
Iphone.InstalarAplicativo("Telegram");
Iphone.ReceberLigacao();

