using Conexão_Educacional.Entities;
using Conexão_Educacional.Services;
using Conexão_Educacional.Menus;

Vagas Vagas = new();
UserEntity UserEntity = new();

while (true)
{
    Console.Clear();

    Console.WriteLine("LOGIN ESTUDANTE");

    Console.WriteLine("1 - Vagas");
    Console.WriteLine("2 - Desempenho");
    Console.WriteLine("3 - Eventos");
    Console.WriteLine("4 - Desafios");
    Console.WriteLine("5 - Visitas");
    Console.Write("Digite: ");

    switch (Console.ReadLine())
    {
        case "1":
            Vagas.Menu(UserEntity);
            break;

        case "2":

            break;  

        case "3":

            break;

        case "4":

            break;

        case "5":

            break;

        default:
            Console.WriteLine("Opção indisponivel");
            break;
    }
}