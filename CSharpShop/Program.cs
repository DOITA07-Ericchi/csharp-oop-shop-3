using CSharpShop;

Prodotto raamen = new Prodotto();
raamen.setNome("ラーメン");
raamen.setDescrizione("Un delizioso pasto veloce a base di noodle cinesi.");
raamen.setPrezzo(150f);
raamen.setIva(22f);
raamen.StampaNomeEsteso();
raamen.StampaPrezzoBase();
raamen.StampaPrezzoIvato();

Prodotto omuraisu = new Prodotto();
omuraisu.setNome("オムライス");
omuraisu.setDescrizione("Una omelette di riso decorata con ketchup che forma un disegno.");
omuraisu.setPrezzo(1000f);
omuraisu.setIva(22f);
omuraisu.StampaNomeEsteso();
omuraisu.StampaPrezzoBase();
omuraisu.StampaPrezzoIvato();

Prodotto onigiri = new Prodotto();
onigiri.setNome("おにぎり");
onigiri.setDescrizione("Una polpetta di riso ripiena, con una sfiziosa alga Nori alla base.");
onigiri.setPrezzo(450f);
onigiri.setIva(22f);
onigiri.StampaNomeEsteso();
onigiri.StampaPrezzoBase();
onigiri.StampaPrezzoIvato();

// Simulazione d'errore
raamen.setCodice(12345678);