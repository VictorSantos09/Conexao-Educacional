using Microsoft.Extensions.DependencyInjection;
using Conexão_Educacional.Entities;
using Conexão_Educacional.Services;
using Conexão_Educacional.Menus;

IServiceCollection services = new ServiceCollection();

services.AddSingleton<Vagas>();
services.AddSingleton<UserService>();
services.AddSingleton<CompanyService>();
services.AddSingleton<CompanyEntity>();

var user = new UserEntity{Name = "Victor", Age = 18};

services.AddSingleton(user);

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
            Vagas.Menu(user);
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