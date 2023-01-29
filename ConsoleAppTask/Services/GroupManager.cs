using ConsoleAppTask.Models;
using ConsoleAppTask.Services.Contract;
using ConsoleAppTask.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask.Services
{
    internal class GroupManager : ICrudService,IPrintService
    {
        private Group[] _groups = new Group[3];
        private int _currentGroup = 0;

        public void Add(Entity entity)
        {
            if (_currentGroup > 1)
            {
                Console.WriteLine("Limiti kecdiniz! Sadece 2 qrup elave etmek olar");

                return;
            }
            _groups[_currentGroup++] = (Group)entity;
            Console.WriteLine($"{entity.Id} ID-li qrup elave olundu");
        }

        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < _groups.Length; i++)
            {
                if (_groups[i] == null)
                    continue;

                if (id == _groups[i].Id)
                {
                    found = true;

                    for (int j = i; j < _groups.Length - 1; j++)
                    {

                        _groups[j] = _groups[j + 1];
                    }
                    _currentGroup--;

                    Console.WriteLine($"ID: {id}, ID-li Group silindi!");
                    return;
                }
            }

            if (!found)
                Console.WriteLine($"ID: {id}, Group tapilmadi");
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < _groups.Length; i++)
            {
                if (_groups[i] == null) continue;

                if (_groups[i].Id == id)
                {
                    return _groups[i];
                }
            }

            Console.WriteLine($"ID: {id}, grup yoxdur yoxdur!");

            return null;
        }

        public Entity[] GetAll()
        {
            return _groups;
        }

        public void Print()
        {
            foreach (var item in _groups)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _groups.Length; i++)
            {
                if (_groups[i] == null) continue;

                if (_groups[i].Id == id)
                {
                    _groups[i] = (Group)entity;
                    Console.WriteLine("Ugurla deyisdirildi!");

                    return;
                }
            }

            Console.WriteLine("Taplmadi!");
        }
    }
}
