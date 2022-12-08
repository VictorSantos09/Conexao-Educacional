using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexão_Educacional.Menus
{
    public class Visitas
    {
        public string Visit1 { get; set; } = "Local '1', Horário: 18h:30min";
        bool visitValidation = false;

        public void Menu()
        {
            Console.WriteLine("1- Visitas");
            Console.WriteLine("2- Inscrição");

            switch (Console.ReadLine())
            {
                case "1":
                    VerVisitas();
                    break;
                case "2":
                    Console.WriteLine("1- Inscrição\n2- Já inscrito");
                    var inputUser = Console.ReadLine();
                    if (inputUser == "1")
                    {
                        Candidatar();
                        break;
                    }
                    else if (inputUser == "2")
                    {
                        VerVisitas();
                        Candidatado();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Comando incorreto!");
                        break;
                    }
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
        public void VerVisitas()
        {
            Console.WriteLine($"{Visit1}");
        }

        public void Candidatar()
        {
            VerVisitas();
            Console.WriteLine("Deseja se inscrever para a visita?\n1- Sim\n2- Não");
            var userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                Console.WriteLine("Você está inscrito na visita!");
                visitValidation = true;
            }
            else if (userChoice == "2")
            {
                Console.WriteLine("Inscrição não aprovada");
            }
            else
            {
                Console.WriteLine("Comando incorreto");
            }

        }
        public bool Candidatado()
        {
            if (visitValidation = true)
            {
                Console.WriteLine($"Você está inscrito no visita {Visit1}");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
