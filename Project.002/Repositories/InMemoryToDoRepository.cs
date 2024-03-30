using System.Collections.Generic;

using Project._002.Models;
using Project._002.Repositories.IRepositories;

namespace Project._002.Repositories;

public class InMemoryToDosRepository : IGenericRepository<ToDo>
{
    private int _nextId = 3;

    private readonly List<ToDo> _toDos = new List<ToDo>()
    {
        new ToDo() { Id = 1, Title = "SOLID Principles", IsDone = false },
        new ToDo() { Id = 2, Title = "Design Patterns", IsDone = false }
    };

    private int _Index(int id)
    {
        return _toDos.FindIndex(obj => obj.Id == id);
    }

    public bool Exists(int id)
    {
        ToDo? obj = _toDos.Find(obj => obj.Id == id);
        if (obj is null)
            return false;
        return true;
    }

    public IEnumerable<ToDo> Get()
    {
        return _toDos;
    }

    public ToDo Get(int id)
    {
        int index = _Index(id);
        return _toDos[index];
    }

    public ToDo Add(ToDo obj)
    {
        obj.Id = _nextId++;
        _toDos.Add(obj);
        return obj;
    }

    public void Delete(int id)
    {
        int index = _Index(id);
        _toDos.RemoveAt(index);
    }

    public void Update(int id, ToDo obj)
    {
        int index = _Index(id);
        _toDos[index] = obj;
    }
}
