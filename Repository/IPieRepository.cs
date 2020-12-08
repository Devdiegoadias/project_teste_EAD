using System.Collections.Generic;
using testando.Models;

namespace testando.Repository
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int pieId);
        void Save(Pie model);
    }
}