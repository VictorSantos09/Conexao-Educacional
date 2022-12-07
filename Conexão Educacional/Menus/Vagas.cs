    using Conexão_Educacional.Entities;

namespace Conexão_Educacional.Menus
{
    public class Vagas
    {
        public void Menu(UserEntity userEntity)
        {
            VerVagas();
            Candidatar(userEntity);

        }
        public void VerVagas()
        {
            Console.WriteLine("1 - Vaga 1");
            Console.WriteLine("1 - Vaga 2");
            Console.WriteLine("1 - Vaga 3");
            Console.WriteLine("1 - Vaga 4");
            Console.WriteLine("1 - Vaga 5");
        }
        public bool Candidatar(UserEntity userEntity)
        {
            VerVagas();
            Console.WriteLine("Qual vaga quer se candidatar?\n");
            var userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.WriteLine($"Você agora está participando do processo seletivo  de {"vaga de tal empresa"}");
                userEntity.SubscriptionsDone++;
                return true;
            }

            return false;
        }
    }
}