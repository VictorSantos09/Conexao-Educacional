using Conexão_Educacional.Repository;
using static Conexão_Educacional.Crosscutting.Extensions;

namespace Conexão_Educacional.Services
{
    public class CompanyService
    {
        private readonly VacanciesRepository _vacanciesRepository;

        public CompanyService(VacanciesRepository vacanciesRepository)
        {
            _vacanciesRepository = vacanciesRepository;
        }

        public void CreateNewVacancie()
        {
            Console.WriteLine("Digite o nome da vaga");
            Type();
            var name = Console.ReadLine();

            Console.WriteLine("Digite o salario:");
            Type();
            var salary = Console.ReadLine();

            Console.WriteLine("Digite o local:");
            Type();
            var place = Console.ReadLine();

            var vacancie = $"{name} {salary} {place}".ToUpper();

            _vacanciesRepository.Add(vacancie);
        }
    }
}
