using Conexão_Educacional.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexão_Educacional.Menus
{
    public class Eventos
    {
        public string Event1 { get; set; } = "Local '1', Horário: 18h:30min";
        bool eventValidation = false;

        public void Menu()
        {
            Console.WriteLine("1- Eventos");
            Console.WriteLine("2- Inscrição");

            switch (Console.ReadLine())
            {
                case "1":
                    VerEventos();
                    break;
                case "2":
                    Console.WriteLine("1- Inscrição\n2- Já inscrito");
                    var inputUser = Console.ReadLine();
                    if (inputUser == "1")
                    {
                        Candidatar();
                        break;
                    }
                    if (inputUser == "2")
                    {
                        VerEventos();
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
        public string VerEventos()
        {
            return Event1;
        }

        public void Candidatar()
        {
            VerEventos();
            Console.WriteLine("Deseja se inscrever para o evento?\n1- Sim\n2- Não");
            var userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                Console.WriteLine("Você se inscreveu no evento com sucesso!");
                eventValidation = true;
            }
            if (userChoice != "2")
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
            if (eventValidation = true)
            {
                Console.WriteLine($"Você está inscrito no evento {Event1}");
                return true;
            }
            else
            {
                return  false;
            }
        }
    }
}
