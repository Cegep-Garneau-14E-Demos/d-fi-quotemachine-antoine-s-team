using QuoteMachine_ExerciceGit;

Console.WriteLine("Bienvenue dans QuoteMachine!");
Console.WriteLine("Ce projet est collaboratif et utilise le GitHub Flow.");
Console.WriteLine("Développez une application console pour gérer et afficher des citations inspirantes.\n");
Console.WriteLine("Prochaines étapes : implémentez les fonctionnalités dans des branches distinctes.\n");
Console.WriteLine("\nPesez sur Entrer pour continuer...");
Console.ReadKey(true);
var manager = new QuoteManager();
string path = "citations.csv";
AfficherMenu(manager);

static void AfficherMenu(QuoteManager manager)
{
    int choix = -1;
    while (choix != 0)
    {
        Console.Clear();
        Console.WriteLine("Que voulez-vous faire? (choisir un nombre)");
        Console.WriteLine("0) Quiter le programme");
        Console.WriteLine("1) Afficher une citation aléatoire");
        Console.WriteLine("2) Ajouter une nouvelle citation");
        Console.WriteLine("3) Sauvegarder une citation au fichier");
        Console.WriteLine("4) Charger une citation au fichier");

        try
        {
            choix = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            choix = -1;
        }

        switch (choix)
        {
            case 0:
                break;
            case 1:
                ShowRandomQuote(manager);
                break;
            case 2:
                AddNewQuote(manager);
                break;
            case 3:
                SaveQuotesToFile(manager);
                break;
            case 4:
                LoadQuotesFromFile(manager); 
                break;
            default:
                Console.WriteLine("Votre option n'est pas valide...");
                break;
        }

        Console.WriteLine("\nPesez sur Entrer pour continuer...");
        Console.ReadKey();
    }
}

static void ShowRandomQuote(QuoteManager manager)
{
    Console.WriteLine("[Simulation] Une citation aléatoire s’afficherait ici.");
    // Exemple futur : Console.WriteLine(manager.GetRandomQuote());
}

static void AddNewQuote(QuoteManager manager)
{
    Console.WriteLine("[Simulation] On ajouterait une nouvelle citation ici.");
    Console.Write("Texte : ");
    string texte = Console.ReadLine();
    Console.Write("Auteur : ");
    string auteur = Console.ReadLine();
    manager.AddQuote(texte, auteur);
    Console.WriteLine("Citation ajoutée !");
}

static void SaveQuotesToFile(QuoteManager manager)
{
    try
    {
        Console.WriteLine("[Simulation] On sauvegarderait les citations ici.");
        // Exemple futur :
        // manager.SaveToFile("citations.txt");
        //Console.WriteLine("Citations sauvegardées !");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erreur : {ex.Message}");
    }
}

static void LoadQuotesFromFile(QuoteManager manager)
{
    try
    {
        Console.WriteLine("[Simulation] On chargerait les citations ici.");
        // Exemple futur :
        // manager.LoadFromFile("citations.txt");
        //Console.WriteLine("Citations chargées !");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erreur : {ex.Message}");
    }
}

