using System.Collections.Generic;
using System.Linq;
using testando.Models;

namespace testando.Repository
{
    public class PieRepository : IPieRepository
    {
        private readonly TestePosContext _context;

        public PieRepository(TestePosContext context)
        {
            this._context = context;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return this._context.Pies.ToList();
        }

        public Pie GetPieById(int pieId)
        {
            return this._context.Pies.Where(x => x.Id == pieId).FirstOrDefault();
        }

        public void Save(Pie model)
        {
            this._context.Pies.Add(model);
            this._context.SaveChanges();
        }
    }
}