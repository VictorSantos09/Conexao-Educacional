using Conexão_Educacional.Entities;
using Conexão_Educacional.Services;

namespace Conexão_Educacional.Menus
{
    public class Vagas
    {
        private readonly CompanyService _companyService;
        private readonly UserService _userService;
        private readonly UserEntity _user;
        private readonly List<string> _vacancies;

        public Vagas(CompanyService companyService, UserService userService, UserEntity user, List<string> vacancies)
        {
            _companyService = companyService;
            _userService = userService;
            _user = user;
            _vacancies = vacancies;
        }

        public void Menu()
        {
            VerVagas();
            Candidatar();
        }
        public void VerVagas()
        {
            foreach (var item in _vacancies)
            {
                var counter = 1;

                Console.WriteLine($"{counter++} - {item.ToUpper()}");
            }
        }
        public bool Candidatar()
        {
            VerVagas();

            Console.WriteLine("Qual vaga deseja se candidatar?\n");
            var userChoice =  Convert.ToInt32(Console.ReadLine());

            _vacancies.FindIndex(x => x.IndexOf(--userChoice));

            if (userChoice == "1")
            {
                Console.WriteLine($"Você agora está participando do processo seletivo  de {"vaga de tal empresa"}");
                _user.SubscriptionsDone++;
                return true;
            }

            return false;
        }
    }
}