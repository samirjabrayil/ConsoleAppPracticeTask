using ConsoleAppTask.Models;
using ConsoleAppTask.Services;
using System;

namespace ConsoleAppTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Teacher/Student

            var groupManager = new GroupManager();
            var departmentManager = new DepartmentManager();
            var teacherManager = new TeacherManager();
            var StudentManager = new StudentManager();

            string command = "";

            do
            {
                Console.Write("Enter the command:");
                command = Console.ReadLine();

                #region Group Manager
                if (command.ToLower() == "add group")
                {
                    var group1 = new Group()
                    {
                        Id = 123,
                        Name = "P329",
                    };

                    var group2 = new Group()
                    {
                        Id = 211,
                        Name = "P231",
                    };

                    groupManager.Add(group1);

                    groupManager.Add(group2);

                }
                else if (command.ToLower() == "update group")
                {
                    Console.Write("Enter the ID :");
                    var id = int.Parse(Console.ReadLine());

                    var existGroup = groupManager.Get(id);

                    if (existGroup == null) continue;

                    Console.WriteLine(existGroup);

                    var group3 = new Group()
                    {
                        Id = 3,
                        Name = "100A3",
                    };

                    groupManager.Update(id, group3);

                }

                else if (command.ToLower().Equals("print groups"))
                {
                    groupManager.Print();
                }

                else if (command.ToLower().Equals("delete group"))
                {
                    Console.Write("Enter the ID :");
                    var id = int.Parse(Console.ReadLine());

                    groupManager.Delete(id);
                }

                #endregion

                #region Department Manager

                else if (command.ToLower() == "add department")
                {
                    var department1 = new Department()
                    {
                        Id = 1,
                        Name = "Neqliyyat ve Logistika",
                    };

                    var department2 = new Department()
                    {
                        Id = 2,
                        Name = "PAM",
                    };

                    departmentManager.Add(department1);

                    departmentManager.Add(department2);

                }
                else if (command.ToLower() == "update department")
                {
                    Console.Write("Enter the ID :");
                    var id = int.Parse(Console.ReadLine());

                    var existDepartment = departmentManager.Get(id);

                    if (existDepartment == null) continue;

                    Console.WriteLine(existDepartment);

                    var department3 = new Department()
                    {
                        Id = 3,
                        Name = "HFT",

                    };

                    departmentManager.Update(id, department3);

                }

                else if (command.ToLower().Equals("print departments"))
                {
                    departmentManager.Print();
                }

                else if (command.ToLower().Equals("delete department"))
                {
                    Console.Write("Enter the ID :");
                    var id = int.Parse(Console.ReadLine());

                    departmentManager.Delete(id);
                }

                #endregion

                #region Teacher Manager

                else if (command.ToLower() == "add teacher")
                {
                    var Teacher1 = new Teacher()
                    {
                        Id = 1,
                        FirstName = "Zakir",
                        LastName = "Cingizov",
                        FatherName = "Akif oglu",
                        Age = 28,
                        Department = new Department()
                        {
                            Id = 1,
                            Name = "Neqliyyat ve Logistika",

                        },
                        Group = new Group()
                        {
                            Id = 123,
                            Name = "P329",
                        },
                        Subject = "Lahiye menecmenti"

                    };

                    var Teacher2 = new Teacher()
                    {
                        Id = 2,
                        FirstName = "Royal",
                        LastName = "Allahverdiyev",
                        FatherName = "Qabil oglu",
                        Age = 29,
                        Department = new Department()
                        {
                            Id = 2,
                            Name = "Neqliyyat",

                        },
                        Group = new Group()
                        {
                            Id = 211,
                            Name = "P333",
                        },
                        Subject = "Texniki Ingilis dili"
                    };

                    teacherManager.Add(Teacher1);

                    teacherManager.Add(Teacher2);

                }
                else if (command.ToLower() == "update teacher")
                {
                    Console.Write("Enter the ID :");
                    var id = int.Parse(Console.ReadLine());

                    var existTeacher = teacherManager.Get(id);

                    if (existTeacher == null) continue;

                    Console.WriteLine(existTeacher);

                    var teacher3 = new Teacher()
                    {
                        Id = 3,
                        FirstName = "Turan",
                        LastName = "Memmedli",
                        FatherName = "Heyder oglu",
                        Age = 30,
                        Department = new Department()
                        {
                            Id = 3,
                            Name = "NHT",

                        },
                        Group = new Group()
                        {

                            Id = 3,
                            Name = "100A4",

                        },
                        Subject = "Tersimi Hendese"


                    };

                    teacherManager.Update(id, teacher3);

                }

                else if (command.ToLower().Equals("print teacher"))
                {
                    teacherManager.Print();
                }

                else if (command.ToLower().Equals("delete teacher"))
                {
                    Console.Write("Enter the ID :");
                    var id = int.Parse(Console.ReadLine());

                    teacherManager.Delete(id);
                }

                #endregion

                #region Student Manager 

                else if (command.ToLower() == "add student")
                {
                    var student1 = new Student()
                    {
                        Id = 1,
                        FirstName = "Samir",
                        LastName = "Cebrayilzade",
                        FatherName = "Elsen oglu",
                        Age = 20,

                        Group = "P329",
                        Course = "1",
                        EntryDate = DateTime.Now,

                    };

                    var student2 = new Student()
                    {
                        Id = 2,
                        FirstName = "Zamin",
                        LastName = "Nerimanov",
                        FatherName = "Ilqar oglu",
                        Age = 23,

                        Group = "P329",
                        Course = "1",
                        EntryDate = DateTime.Now,
                    };

                    StudentManager.Add(student1);

                    StudentManager.Add(student2);

                }
                else if (command.ToLower() == "update student")
                {
                    Console.Write("Enter the ID :");
                    var id = int.Parse(Console.ReadLine());

                    var existStudent = StudentManager.Get(id);

                    if (existStudent == null) continue;

                    Console.WriteLine(existStudent);

                    var student3 = new Student()
                    {
                        Id = 2,
                        FirstName = "Macidov",
                        LastName = "Abdullah",
                        FatherName = "Nadir oglu",
                        Age = 23,

                        Group = "P329",
                        Course = "1",
                        EntryDate = DateTime.Now,
                    };

                    StudentManager.Update(id, student3);

                }

                else if (command.ToLower().Equals("print student"))
                {
                    StudentManager.Print();
                }

                else if (command.ToLower().Equals("delete student"))
                {
                    Console.Write("Enter the ID :");
                    var id = int.Parse(Console.ReadLine());

                    StudentManager.Delete(id);
                }

                #endregion

            } while (command.ToLower() != "quit");


            #endregion



            #region Student(practice/main)

            //StudentManager studentManager = new StudentManager();
            //string command = "";
            //do
            //{
            //    Console.Write("Enter the Command: ");
            //    command = Console.ReadLine();
            //    Subject[] subjects =
            //    {
            //        new Subject
            //        {
            //            Id= 1,
            //            Name = "Biology"
            //        },
            //        new Subject
            //        {
            //            Id= 2,
            //            Name = "Mathematics"
            //        }

            //    };

            //    if (command.ToLower().Equals("add student"))
            //    {
            //        var student = new Student
            //        {
            //            Id = 1,
            //            Firstname = "Samir",
            //            Lastname = "Cebrayilzade",
            //            Age = 20,
            //            Course = 3,
            //            EntryDate = DateTime.Now,
            //            Group = new Group
            //            {
            //                Id = 1,
            //                Name = "P329",
            //            },
            //            Subjects = subjects
            //        };
            //        var student1 = new Student
            //        {
            //            Id = 2,
            //            Firstname = "Zamin",
            //            Lastname = "Nerimanov",
            //            Age = 19,
            //            Course = 3,
            //            EntryDate = DateTime.Now,
            //            Group = new Group
            //            {
            //                Id = 1,
            //                Name = "P329",
            //            },
            //        };

            //        studentManager.Add(student);
            //        studentManager.Add(student1);
            //    }
            //    else if (command.ToLower().Equals("print students"))
            //    {
            //        studentManager.Print();
            //    }
            //    else if (command.ToLower().Equals("delete student"))
            //    {
            //        Console.Write("Enter the ID: ");
            //        var id = int.Parse(Console.ReadLine());
            //        studentManager.Delete(id);
            //    }
            //    else if (command.ToLower().Equals("update student"))
            //    {
            //        Console.Write("Enter the ID: ");
            //        var id = int.Parse(Console.ReadLine());
            //        var existStudent = studentManager.Get(id);

            //        if (existStudent == null)
            //            continue;
            //        Console.WriteLine(existStudent);
            //        var student = new Student
            //        {
            //            Id = 1,
            //            Firstname = "Samir",
            //            Lastname = "Cebrayilzade",
            //            Age = 90,
            //            Course = 6,
            //            EntryDate = DateTime.Now,
            //            Group = new Group
            //            {
            //                Id = 1,
            //                Name = "P329",
            //            },
            //        };

            //        studentManager.Update(id, student);
            //        //13:55
            //    }
            //} while (command.ToLower() != "quit");
            #endregion

        }
    }
}