using System.Runtime.CompilerServices;

int recruted = 0;


Console.WriteLine("välkommen till rekruterings hallen.");
Console.WriteLine("Din uppgift är att rekrytera tre kandidater in i armen.");

List<string> recruts = ["kim", "paulo", "christer", "filip", "marlon", "anika", "jenny", ];



while (recruted != 3)
{
    Console.WriteLine(""); // så det blir ett mellan rum
    Console.WriteLine("Alla rekryter:");
    for (int all = 0; all < recruts.Count; all++)
    {
        Console.WriteLine(recruts[all]);
    }

    string recruiting = Console.ReadLine();
    recruiting.ToLower();

    while (recruts.Contains(recruiting) == false)
    {
        Console.WriteLine("sktrv ett av rekryternas namn");
        recruiting = Console.ReadLine().ToLower();
    }

    recruts.Remove($"{recruiting}");


    List<string> isRecruted = [""];

    isRecruted.Add($"{recruiting}");

    Console.WriteLine("Rekryterade");
    for (int allRecruted = 0; allRecruted < isRecruted.Count; allRecruted++)
    {
        Console.WriteLine(isRecruted[allRecruted]);
    }

    recruted++;
}

// LISTOR

//string enemyName = "";

//List<string> names = ["micke", "martin", "lena", "karim",];  där micke = 0

//for (int i = 0; i < names.Count; i++)
//{
//Console.WriteLine(names[i]);
//}

//names.Add("nicholas");
//names.Remove("lena");
//names.RemoveAt(3);
//names[0] = "mikael";

//int i = Random.Shared.Next(names.Count);
//Console.WriteLine(names[i]);

Console.ReadLine();