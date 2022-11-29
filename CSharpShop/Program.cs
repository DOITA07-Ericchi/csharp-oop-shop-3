using CSharpShop;

Prodotto raamen = new Prodotto();
raamen.SetNome("ラーメン");
raamen.SetDescrizione("Un delizioso pasto veloce a base di noodle cinesi.");
raamen.SetPrezzo(150f);
raamen.SetIva(22f);
raamen.StampaNomeEsteso();
raamen.StampaPrezzoBase();
raamen.StampaPrezzoIvato();

Prodotto omuraisu = new Prodotto();
omuraisu.SetNome("オムライス");
omuraisu.SetDescrizione("Una omelette di riso decorata con ketchup che forma un disegno.");
omuraisu.SetPrezzo(1000f);
omuraisu.SetIva(22f);
omuraisu.StampaNomeEsteso();
omuraisu.StampaPrezzoBase();
omuraisu.StampaPrezzoIvato();

Prodotto onigiri = new Prodotto();
onigiri.SetNome("おにぎり");
onigiri.SetDescrizione("Una polpetta di riso ripiena, con una sfiziosa alga Nori alla base.");
onigiri.SetPrezzo(450f);
onigiri.SetIva(22f);
onigiri.StampaNomeEsteso();
onigiri.StampaPrezzoBase();
onigiri.StampaPrezzoIvato();

// Simulazione d'errore
raamen.SetCodice(12345678);