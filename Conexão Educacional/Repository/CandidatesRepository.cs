using Conexão_Educacional.Entities;

namespace Conexão_Educacional.Repository
{
    public class CandidatesRepository
    {
        private List<UserEntity> Candidates { get; set; }

        public CandidatesRepository(List<UserEntity> candidates)
        {
            Candidates = candidates;
        }

        public void AddCandidate(UserEntity item)
        {
            Candidates.Add(item);
        }

        public List<UserEntity> GetCandidates()
        {
            return Candidates;
        }

        public UserEntity? GetCandityByName(string name)
        {
            return Candidates.Find(x => x.Name == name);
        }
    }
}