using System.Collections.Generic;

namespace Project._002.Repositories.IRepositories;

public interface IGenericRepository<T>
{
    bool Exists(int id);
    IEnumerable<T> Get();
    T Get(int id);
    T Add(T obj);
    void Delete(int id);
    void Update(int id, T obj);
}
