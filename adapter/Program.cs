using adapter;

ServeurWeb serveur = new();

Document document1 = new DocumentHtml();
serveur.traiter(document1, "Hello HTML");

Console.WriteLine();

Document document2 = new DocumentPdf();
serveur.traiter(document2, "Bonjour PDF");
