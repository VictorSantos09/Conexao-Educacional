using Conexão_Educacional.Entities;

namespace Conexão_Educacional.Repository
{
    public class VacanciesRepository
    {
        private List<VacanciesEntity> Vacancies { get; set; }

        public VacanciesRepository(List<VacanciesEntity> vacancies)
        {
            Vacancies = vacancies;
        }

        public void Add(VacanciesEntity item)
        {
            Vacancies.Add(item);

            var vacanciesPattern = new List<VacanciesEntity>
            {
                new VacanciesEntity {Name = "Assistente de Ti", CompanyOwner = "Havan Labs", Salary = 3000, Id = 1},
                new VacanciesEntity {Name = "Analista de Negocio", CompanyOwner = "Microsoft", Salary = 8500, Id = 2},
                new VacanciesEntity {Name = "Dev Pleno", CompanyOwner = "Senior", Salary = 2500, Id = 3}
            };

            Vacancies.AddRange(vacanciesPattern);
        }

        public void Remove(VacanciesEntity item)
        {
            Vacancies.Remove(item);
        }
        public List<VacanciesEntity> GetVacancies()
        {
            return Vacancies;
        }
    }
}
