using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Conexão_Educacional.Entities;

namespace Conexão_Educacional.Menus
{
    public class Desempenho
    {

        public void Menu(ProjectEntity projectEntity)
        {
            
            while (true) { 

            Console.Clear();
            
            Console.WriteLine("MENU DESEMPENHO");
            
            Console.WriteLine("1 - Desempenho");
            Console.WriteLine("2 - Ver Projetos");
            Console.WriteLine("3 - Postar Projetos");
            Console.WriteLine("4 - Feedback");
            Console.WriteLine("5 - Contatos");
            Console.WriteLine("6 - Convites");

                switch (Console.ReadLine())
                {
                    case "1":
                        SeePerformance();
                        break;

                    case "2":
                        SeeProjects();
                        break;

                    case "3":
                        PostProjects(projectEntity);
                        break;

                    case "4":
                        SeeFeedback();
                        break;

                    case "5":
                        SeeContacts();
                        break;

                    case "6":
                        SeeInvitations();
                        break;

                    default:
                        Console.WriteLine("Entrada Inválida");
                        break;

                }

                    
            }


        }

        public void SeePerformance()
        {
            Console.WriteLine("Frenquência - 97% \n 2 Falta(s)");

            Console.WriteLine("Nota 1 - 10");
            Console.WriteLine("Nota 2 - 6");
            Console.WriteLine("Nota 3 - 8");
            Console.WriteLine("Nota 4 - 7.5");
        }
        
        public void SeeProjects()
        {
            Console.WriteLine("Projeto 1 - Projeto Integrador EazyBank");
            Console.WriteLine("Projeto 2 - Projeto Educação Hackaton");
            Console.WriteLine("Projeto 3 - Projeto Loja de Música");
        }
        
        public void PostProjects(ProjectEntity projectEntity)
        {
            Console.Write("Nome do Projeto:");
            projectEntity.Name = Convert.ToString(Console.Read());

            Console.WriteLine($"Projeto {projectEntity.Name} Cadastrado");

        }
        public void SeeFeedback()
        {
            Console.WriteLine("Feedback - Professor Régis \n Aluno apresenta ótima comunicação com os colegas" +
                "principalmente nas apresentações que se destaca pelo seu carisma.\n Há um pouco de dificuldade" +
                "na parte de análise de requisitos bem como na codificação. Entretanto demonstra um grande esforço\n");

            Console.WriteLine("FeedBack - Empresa TechData \n Gostamos bastante dos seus projetos principalmente" +
                "sobre o banco digital. Além disso sua aprensentação é muito clara e descontraída, transmitindo" +
                "confiança.");
        }

        public void SeeContacts()
        {
            Console.WriteLine("Contato Aluno \nTelefone - (47)98909-5115\nEmail - jackson@gmail.com");
        }
        public void SeeInvitations()
        {
            Console.WriteLine("Convite 1 - Visita TechData 18/12 19:00");
            Console.WriteLine("Convite 2 - Entrevista Técnica InfoTech 20/12 18:00");
        }

    }
}
