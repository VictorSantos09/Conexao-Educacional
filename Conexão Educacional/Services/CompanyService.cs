using Conexão_Educacional.Entities;
using Conexão_Educacional.Repository;
using static Conexão_Educacional.Crosscutting.Extensions;

namespace Conexão_Educacional.Services
{
    public class CompanyService
    {
        private readonly VacanciesRepository _vacanciesRepository;
        private readonly CandidatesRepository _candidatesRepository;

        public CompanyService(VacanciesRepository vacanciesRepository, CandidatesRepository candidatesRepository)
        {
            _vacanciesRepository = vacanciesRepository;
            _candidatesRepository = candidatesRepository;
        }

        public void CreateNewVacancie()
        {
            Console.WriteLine("Digite o nome da vaga");
            Type();
            var name = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite o salario:");
            Type();
            var salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o local:");
            Type();
            var place = Console.ReadLine().ToUpper();

            var vacancie = new VacanciesEntity { Name = name, Salary = salary, Place = place };

            _vacanciesRepository.Add(vacancie);
        }

        public void ViewCandidates()
        {
            var counter = 1;
            Console.WriteLine($"{counter++} - Carlos Alberto de Araujo");
            Console.WriteLine($"{counter++} - Maria Fernandes de Souza");
            Console.WriteLine($"{counter++} - Patricia Cristiane de Jesus");

            foreach (var item in _candidatesRepository.GetCandidates())
            {
                Console.WriteLine($"{counter++} - {item.Name}");
            }
        }

        public void FinishSeletiveProcess()
        {
            ViewCandidates();

            Console.WriteLine("Digite o nome do candidato:");

            Type();

            var candidateName = Console.ReadLine().ToUpper();

            var candidate = _candidatesRepository.GetCandityByName(candidateName);

            if (candidate is null)
                Console.WriteLine("Candidato não encontrado");

            Console.WriteLine($"Nome: {candidate.Name}");
            Console.WriteLine($"Idade: {candidate.Age}");
            Console.WriteLine($"Email: {candidate.Email}");
            Console.WriteLine($"Telefone: {candidate.PhoneNumber}");
        }
    }
}
