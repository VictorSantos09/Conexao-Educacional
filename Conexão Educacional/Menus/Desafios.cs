using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexão_Educacional.Entities;

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
                Console.Write("Digite: ");
                
                switch (Console.ReadLine())
                {
                    case "1":
                        SeeChallanges();
                        break;

                    case "2":
                        ApplyChallanges(userEntity);
                        break;

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
                return true;
            }
            else if (userChoice == "2")
            {
                Console.WriteLine($"Você respondeu o desafio de Front-End da empresa TechData");
                return true;
                userEntity.ChallangesDone++;
            }
            else if (userChoice == "3")
            {
                Console.WriteLine($"Você respondeu o desafio de Banco de Dados da empresa BluTech");
                userEntity.ChallangesDone++;
                return true;
            }
            return false;
        }
    }

}

