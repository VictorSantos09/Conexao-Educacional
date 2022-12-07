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
            VerDesempenho();
            VerProjetos();
            PostarProjetos(projectEntity);
            VerFeedback();
            VerContato();
        }

        public void VerDesempenho()
        {
            Console.WriteLine("Frenquência - 97% \n 2 Falta(s)");

            Console.WriteLine("Nota 1 - 10");
            Console.WriteLine("Nota 2 - 6");
            Console.WriteLine("Nota 1 - 8");
            Console.WriteLine("Nota 1 - 7.5");
        }
        
        public void VerProjetos()
        {
            Console.WriteLine("Projeto 1 - Projeto Integrador EazyBank");
            Console.WriteLine("Projeto 2 - Projeto Educação Hackaton");
            Console.WriteLine("Projeto 3 - Projeto Loja de Música");
        }
        
        public void PostarProjetos(ProjectEntity projectEntity)
        {
            Console.Write("Nome do Projeto:");
            projectEntity.Name = Console.Read();

            Console.WriteLine($"Projeto {projectEntity.Name} Cadastrado");

        }
        public void VerFeedback()
        {
            Console.WriteLine("Feedback - Professor Régis \n Aluno apresenta ótima comunicação com os colegas" +
                "principalmente nas apresentações que se destaca pelo seu carisma.\n Há um pouco de dificuldade" +
                "na parte de análise de requisitos bem como na codificação. Entretanto demonstra um grande esforço\n");

            Console.WriteLine("FeedBack - Empresa TechData \n Gostamos bastante dos seus projetos principalmente" +
                "sobre o banco digital. Além disso sua aprensentação é muito clara e descontraída, transmitindo" +
                "confiança.");
        }

        public void VerContato()
        {
            Console.WriteLine("Contato Aluno \nTelefone - (47)98921-6116\nEmail - jackson@gmail.com");
        }
        public void VerConvites()
        {
            Console.WriteLine("Convite 1 - Visita TechData 18/12 19:00");
            Console.WriteLine("Convite 2 - Entrevista Técnica InfoTech 20/12 18:00");
        }

    }
}
