using ConsoleAppTask.Models;
using ConsoleAppTask.Services.Contract;

namespace ConsoleAppTask.Services
{
    internal class StudentManager : ICrudService, IPrintService
    {
        private Student[] _students = new Student[100]; //0-dan 99`dek 100 Student olur
        private int _currentIndex = 0;
        public void Add(Entity entity)
        {
            if (_currentIndex > 19)
            {
                Console.WriteLine("Limiti kecmisiniz! - Sadece 20 Telebe elave etmek olar");
                return;
            }
            _students[_currentIndex++] = (Student)entity;
            //Basqa proses olmadigi ucun (_currentIndex++ ifadesini daxilde yaza bilirik)
            //_currentIndex++
            Console.WriteLine($"{entity.Id}-li Telebe elave olundu");
            //Console.WriteLine("Student added successfully");
        }

        public void Delete(int id)
        {
            bool found = false;
            for (int i = 0; i < _students.Length; i++)
            {
                if (id == _students[i].Id)
                    continue;

                if (id == _students[i].Id)
                {
                    found = true;
                    for (int j = 0; j < _students.Length; j++)
                    {
                        _students[j] = _students[j + 1];
                    }
                    //_students[i] = null;
                    _currentIndex--;

                    Console.WriteLine($"{id}-li student deleted");
                    return;

                }
            }

            if (!found)
            {
                Console.WriteLine($"{id}-li student not found");
            }
        }

        public Entity Get(int id)
        {
            foreach (Student student in _students)
            {
                if (student == null)
                {
                    continue;

                }

                if (student.Id == id)
                {
                    return student;
                }
            }

            Console.WriteLine("Not Found");
            return null;
        }

        public Entity[] GetAll()
        {
            return _students;
        }

        public void Print()
        {
            foreach (Student student in _students)
            {
                if (student == null)
                    continue;
                Console.WriteLine(student);

            }

        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i] == null)
                {
                    continue;
                }

                if (_students[i].Id == id)
                {
                    _students[i] = (Student)entity;
                    Console.WriteLine("It was successfully replaced");

                    return;
                }
            }

            Console.WriteLine("Not Found");
        }
    }
}
