// les lignes de code qui vont être exécutées au lancement de l'application

using System.Net.Http.Headers;

Console.WriteLine("Cette ligne va s'éxécuter en premier");
Console.WriteLine("Cette ligne va s'éxécuter en deuxième");
Console.WriteLine("Cette ligne va s'éxécuter en troisième");



bool wantContinue = true;
while (wantContinue == true)
{
    //Generate random integer between 1 and 100
    Random random = new Random();
    int randomNumber = random.Next(1, 7);
    Console.WriteLine("Le dé vaut : " + randomNumber);

    Console.WriteLine("Voulez-vous rejouer ? (O/N)");
    string response = Console.ReadLine();

    switch (response)
    {
        case "N":
        case "n":
        case "non":
            wantContinue = false;
            break;
        case "O":
        case "o":
        case "oui":
            wantContinue = true;
            break;
        default:
            Console.WriteLine("Je n'ai pas compris votre demande, dans le doute, je relance le dé");
            wantContinue = true;
            break;
    }
}


Console.ReadLine();

//L'application se fermerra dès que l'utilisateur appuiera sur la touche entrée