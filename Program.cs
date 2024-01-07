using DesafioPOO.Models;

Nokia nokia1 = new Nokia("123456789", "Nokia 3310", "123456789", 16);
Iphone iphone1 = new Iphone("987654321", "iPhone 11", "987654321", 64);

nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Colossatron");

iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Minecraft");