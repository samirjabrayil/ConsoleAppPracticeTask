using ConsoleAppTask.Models;
using ConsoleAppTask.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask.Services
{
    internal class TeacherManager : ICrudService, IPrintService
    {
        private Teacher[] _teachers = new Teacher[5];
        private int _currentTeacher = 0;

        public void Add(Entity entity)
        {
            if (_currentTeacher > 3)
            {
                Console.WriteLine("Limiti kecdiniz! Sadece 4 Muellim elave etmek olar");

                return;
            }
            _teachers[_currentTeacher++] = (Teacher)entity;
            Console.WriteLine($"{entity.Id} Id li Muellim elave olundu");
        }

        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < _teachers.Length; i++)
            {
                if (_teachers[i] == null)
                    continue;

                if (id == _teachers[i].Id)
                {
                    found = true;

                    for (int j = i; j < _teachers.Length - 1; j++)
                    {

                        _teachers[j] = _teachers[j + 1];
                    }
                    _currentTeacher--;

                    Console.WriteLine($"ID: {id}-li Muellim silindi!");
                    return;
                }
            }

            if (!found)
                Console.WriteLine($"ID: {id}-li Muellim tapilmadi");
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < _teachers.Length; i++)
            {
                if (_teachers[i] == null) continue;

                if (_teachers[i].Id == id)
                {
                    return _teachers[i];
                }
            }

            Console.WriteLine($"ID: {id}-li Muellim yoxdur!");

            return null;
        }

        public Entity[] GetAll()
        {
            return _teachers;
        }

        public void Print()
        {
            foreach (var item in _teachers)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _teachers.Length; i++)
            {
                if (_teachers[i] == null) continue;

                if (_teachers[i].Id == id)
                {
                    _teachers[i] = (Teacher)entity;
                    Console.WriteLine("Ugurla deyisdirildi!");

                    return;
                }
            }

            Console.WriteLine("Taplmadi!");
        }
    }
}
