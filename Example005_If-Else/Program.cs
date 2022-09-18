Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine() ?? "test";

if(username.ToLower() == "Маша")
{
    Console.WriteLine("Ура! Маша");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}
