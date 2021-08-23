using System.Collections.Generic;

namespace Interfaces
{
    public interface IRepository<T> where T: IEntitie{
        List<T> Table();
        void Insert(T entitie);
        T Select(int id);
        void Delete(int id);
        void Update(int id, T entitie);
        int Id();

    }
}