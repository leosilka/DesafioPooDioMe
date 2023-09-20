// TODO: Realizar os testes com as classes Nokia e Iphone

using ProjetoPooDioMe.Models;

Iphone iPhone = new Iphone("65849496", "iPhone 14 Pro Max", "15616161616", 128);
iPhone.InstalarAplicativo("Abracadabra");
iPhone.ReceberLigacao();
iPhone.Ligar();

Nokia celular = new Nokia("88hsay1", "Nokia Lumia", "5465465464", 64);
celular.InstalarAplicativo("Instagram");
celular.ReceberLigacao();
celular.Ligar();