using Microsoft.Extensions.DependencyInjection;
using Conexão_Educacional.Entities;
using Conexão_Educacional.Services;
using Conexão_Educacional.Menus;
using Conexão_Educacional.Repository;

IServiceCollection services = new ServiceCollection();

services.AddSingleton<UserService>();
services.AddSingleton<CompanyService>();
services.AddSingleton<CandidatesRepository>();
services.AddSingleton<VacanciesRepository>();

var user = new UserEntity { Name = "Victor", Age = 18 };
services.AddSingleton(user);

var company = new CompanyEntity { Name = "Amazon", Adress = "Ponta Aguda, 155, SC, Blumenau" };
services.AddSingleton(company);


var vacanciesPattern = new List<VacanciesEntity>
            {
                new VacanciesEntity {Name = "Assistente de Ti", CompanyOwner = "Havan Labs", Salary = 3000, Id = 0},
                new VacanciesEntity {Name = "Analista de Negocio", CompanyOwner = "Microsoft", Salary = 8500, Id = 1},
                new VacanciesEntity {Name = "Dev Pleno", CompanyOwner = "Senior", Salary = 2500, Id = 2}
            };

Vagas vagas = new(user, vacanciesPattern);


var project = new ProjectEntity { Name = "Solução de Loja" };

while (true)
{
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
            vagas.Menu();
            break;

        case "2":
            Desempenho desempenho = new();
            desempenho.Menu(project);
            break;

        case "3":
            break;

        case "4":
            Desafios desafios = new();
            desafios.Menu(user);
            break;

        case "5":

            break;

        default:
            Console.WriteLine("Opção indisponivel");
            break;
    }
}