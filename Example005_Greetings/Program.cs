Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "юля")
{
    Console.WriteLine("Ура наконец-то ты вернулась!!");
}
else
{
    Console.Write("Привет ");
    Console.WriteLine(username);
}