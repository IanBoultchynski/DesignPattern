using Bridge;

FormulaireImmatriculation formulaireFrance = new FormImmatriculationFrance(new FormHtmlImpl());
formulaireFrance.affiche();
formulaireFrance.génèreDocument();

Console.WriteLine();

FormulaireImmatriculation formulaireLuxembourg = new FormImmatriculationLuxembourg(new FormAppletImpl());
formulaireLuxembourg.affiche();
formulaireLuxembourg.génèreDocument();
