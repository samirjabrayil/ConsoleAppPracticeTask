

namespace ConsoleAppTask.Models
{
    internal class Person : Entity
    {

        internal string Firstname { get; set; }
        internal string Lastname { get; set; }
        internal string Fathername { get; set; }
        internal int Age { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} Ad: {Firstname} Soyad: {Lastname} Ata ad: {Fathername} {Age} ";
        }




    }


}
