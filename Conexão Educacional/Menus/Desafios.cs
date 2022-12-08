using Conexão_Educacional.Entities;
using System.Runtime.CompilerServices;
using static Conexão_Educacional.Crosscutting.Extensions;

namespace Conexão_Educacional.Menus
{
    public class Desafios
    {
        public void Menu(UserEntity userEntity)
        {

            while (true)
            {
                Console.Clear();

                Console.WriteLine("MENU DESAFIOS");

                Console.WriteLine("1 - Ver Desafios");
                Console.WriteLine("2 - Participar de Desafios");
                Console.WriteLine("3 - Voltar ao menu principal");
                Console.Write("Digite: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        SeeChallanges();
                        break;

                    case "2":
                        ApplyChallanges(userEntity);
                        break;

                    case "3":
                        return;

                    default:
                        Console.WriteLine("Entrada Inválida");
                        break;
                }
            }
        }
        public void SeeChallanges()
        {
            Console.WriteLine("Desafio 1 - Lógica de Programação - InfoTech");
            Console.WriteLine("Desafio 2 - Front-End - TechData");
            Console.WriteLine("Desafio 3 - Banco de Dados - BluTech");

            Holder();
        }

        public bool ApplyChallanges(UserEntity userEntity)
        {
            SeeChallanges();

            Console.WriteLine("Qual desafio quer se candidatar?\n");
            var userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.WriteLine($"Você respondeu o desafio de Lógica de Programação da empresa InfoTech");
                userEntity.ChallangesDone++;
                Holder();
                return true;
            }
            else if (userChoice == "2")
            {
                Console.WriteLine($"Você respondeu o desafio de Front-End da empresa TechData");
                Holder();
                return true;
                userEntity.ChallangesDone++;
            }
            else if (userChoice == "3")
            {
                Console.WriteLine($"Você respondeu o desafio de Banco de Dados da empresa BluTech");
                userEntity.ChallangesDone++;
                Holder();
                return true;
            }
            return false;
        }
    }
}

