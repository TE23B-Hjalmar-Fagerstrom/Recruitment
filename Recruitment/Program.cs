
Console.WriteLine("välkommen till rekruterings hallen.");
Console.WriteLine("Din uppgift är att rekrytera tre kandidater in i armen.");

List<string> recruts = ["Kim", "Paulo", "Christer", "filip", "Marlon", "Anika", "Jenny"];

Console.WriteLine("Alla rekryter");
for (int all = 0; all < recruts.Count; all++)
{
    Console.WriteLine(recruts[all]);
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