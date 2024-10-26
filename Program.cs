using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia n1 = new Nokia("2799991111", "Lumia", "123456789", 128);
n1.InstalarAplicativo("WhatsApp");
n1.ReceberLigacao();

Iphone i1 = new Iphone("2798989870", "MAX", "23146587", 256);
i1.ReceberLigacao();
i1.InstalarAplicativo("Facebook");