Console.Write("Как вас завут? : ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура этоже машаа");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
