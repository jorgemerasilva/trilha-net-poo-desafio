using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("75998338424", "Iphone 16 Pro Max", "ghh4f2yuio2yy2", 244221);
Nokia nokia = new Nokia("75994332985", "Nokia 3 Max", "1751213517353", 244221);

iphone.InstalarAplicativo("Facebook");
iphone.ReceberLigacao();


nokia.InstalarAplicativo("Instagram");
nokia.ReceberLigacao();
