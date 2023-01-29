using ConsoleAppTask.Models;
using ConsoleAppTask.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask.Services
{
    internal class DepartmentManager : ICrudService, IPrintService
    {
        private Department[] _departments = new Department[10];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
            if (_currentIndex > 1)
            {
                Console.WriteLine("Limiti kecdiniz! Sadece 2 Fakulte elave etmek olar");
                return;
            }
            _departments[_currentIndex++] = (Department)entity;
            Console.WriteLine($"{entity.Id}-li Fakulte elave olundu");

        }

        public void Delete(int id)
        {
            bool found = false;
            for (int i = 0; i < _departments.LongLength; i++)
            {
                if (id == _departments[i].Id)
                    continue;

                if (id == _departments[i].Id)
                {
                    found = true;
                    for (int j = 0; j < _departments.Length; j++)
                    {
                        _departments[j] = _departments[j + 1];
                    }
                    
                    _currentIndex--;

                    Console.WriteLine($"{id}-li fakulte silindi");
                    return;

                }
            }

            if (!found)
            {
                Console.WriteLine($"{id}-li fakulte tapilmadi");
            }
        }

        public Entity Get(int id)
        {
            foreach (Department department in _departments)
            {
                if (department == null)
                {
                    continue;

                }

                if (department.Id == id)
                {
                    return department;
                }
            }

            Console.WriteLine("Not Found");
            return null;
        }

        public Entity[] GetAll()
        {
            return _departments;
        }

        public void Print()
        {
            foreach (Department department in _departments)
            {
                if (department == null)
                    continue;
                Console.WriteLine(department);

            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _departments.Length; i++)
            {
                if (_departments[i] == null)
                {
                    continue;
                }

                if (_departments[i].Id == id)
                {
                    _departments[i] = (Department)entity;
                    Console.WriteLine("It was successfully replaced");

                    return;
                }
            }

            Console.WriteLine("Not Found");
        }
    }
}
