using CSharpShop;
using CSharpShop2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Prodotto raamen = new Prodotto();
raamen.SetNome("ラーメン");
raamen.SetDescrizione("Un delizioso pasto veloce a base di noodle cinesi.");
raamen.SetPrezzo(150f);
raamen.SetIva(22f);

Prodotto omuraisu = new Prodotto();
omuraisu.SetNome("オムライス");
omuraisu.SetDescrizione("Una omelette di riso decorata con ketchup che forma un disegno.");
omuraisu.SetPrezzo(1000f);
omuraisu.SetIva(22f);

Prodotto onigiri = new Prodotto();
onigiri.SetNome("おにぎり");
onigiri.SetDescrizione("Una polpetta di riso ripiena, con una sfiziosa alga Nori alla base.");
onigiri.SetPrezzo(450f);
onigiri.SetIva(22f);

Acqua mizu = new Acqua();

List<Prodotto> cibi = new List<Prodotto>();
cibi.Add(raamen);
cibi.Add(omuraisu);
cibi.Add(onigiri);

foreach(Prodotto prodotto in cibi) {
    prodotto.StampaProdotto();
    Console.WriteLine("～　∥　～　∥　～　∥　～　∥　～　∥　～");
    Console.WriteLine("Premi Invio per continuare.");
    Console.ReadLine();
}
mizu.Riempi(1.2);
Console.WriteLine("Il contenuto in galloni è: " + Acqua.convertiInGalloni(mizu.Litri));
mizu.StampaContatore();
mizu.StampaProdotto();

Console.WriteLine("Premi Invio per uscire.");
Console.ReadLine();

// Simulazione d'errore
// raamen.SetCodice(12345678);