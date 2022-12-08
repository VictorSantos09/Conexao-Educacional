    using Conexão_Educacional.Entities;

namespace Conexão_Educacional.Menus
{
    public class Vagas
    {
        private readonly UserEntity _user;
        private readonly List<VacanciesEntity> _vacancies;

        public Vagas(UserEntity user, List<VacanciesEntity> vacancies)
        {
            _user = user;
            _vacancies = vacancies;
        }

        public void Menu()
        {
            Console.Clear();

            Console.WriteLine("1 - Ver Vagas");
            Console.WriteLine("2 - Candidatar");

            switch (Console.ReadLine())
            {
                case "1":
                    ViewVacancies();
                    break;

                case "2":
                    RegisterToVacancie();
                    break;

                default:
                    Console.WriteLine("Opção Indisponivel");
                    break;
            }
        }

        public bool ViewVacancies()
        {
            if (_vacancies.Count is 0)
            {
                Console.WriteLine("Não há vagas registradas");
                Thread.Sleep(1300);
                return false;
            }

            var counter = 1;
            foreach (var item in _vacancies)
            {

                Console.WriteLine($"{counter++} - {item.Name}");
            }

            return true;
        }

        public bool RegisterToVacancie()
        {
            if (ViewVacancies())
            {
                Console.WriteLine("Qual vaga deseja se candidatar?\n");
                var userChoice = Convert.ToInt32(Console.ReadLine());

                userChoice--;

                var vacancieId = _vacancies.FindIndex(x => x.Id == userChoice);

                var vacancie = _vacancies.Find(x => x.Id == vacancieId);

                if (vacancie != null)
                {
                    Console.WriteLine($"Você agora está participando do processo seletivo da vaga {vacancie.Name} de {vacancie.CompanyOwner}");
                    _user.SubscriptionsDone++;
                    return true;
                }

                Console.WriteLine("Vaga não encontrada");
            }

            return false;
        }
    }
}