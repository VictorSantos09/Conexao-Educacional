namespace Conexão_Educacional.Repository
{
    public class VacanciesRepository
    {
        private readonly List<string> Vacancies;

        public VacanciesRepository()
        {
            Vacancies = new List<string>();
        }
        
        public void Add(string item)
        {
            Vacancies.Add(item);
        }
        
        public void Remove(string item)
        {
            Vacancies.Remove(item);
        }
    }
}
