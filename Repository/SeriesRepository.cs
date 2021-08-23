using System.Collections.Generic;
using Interfaces;

namespace Repository
{
    public class SeriesRepository : IRepository<IEntitie>{
        public List<IEntitie> Series = new List<IEntitie>();
        public List<IEntitie> Table() =>  Series;
        public void Insert(IEntitie series) => Series.Add(series);
        public IEntitie Select(int id) => Series[id];
        public void Update(int id, IEntitie series) => Series[id] = series;
        public void Delete(int id) => Series[id].Exclude();
        public int Id() => Series.Count;
    }
}