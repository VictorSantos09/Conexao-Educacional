namespace Conexão_Educacional.Entities
{
    public class CompanyEntity
    {
        public int Name { get; set; }
        public string Adress { get; set; }

        public void RegisterNewEvent()
        {
            Console.WriteLine("Digite o nome do evento: ");
        }
    }
}