using ConsoleAppTask.Models;

namespace ConsoleAppTask.Services.Contract
{
    internal interface ICrudService
    {
        void Add(Entity entity);
        void Update(int id, Entity entity);
        void Delete(int id);
        Entity Get(int id);
        Entity[] GetAll();
    }

}
