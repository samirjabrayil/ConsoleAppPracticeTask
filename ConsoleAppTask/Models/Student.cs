namespace ConsoleAppTask.Models
{
    internal class Student : Person
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal string FatherName { get; set; }
        internal string Course { get; set; }
        internal DateTime EntryDate { get; set; }
        internal string Group { get; set; }
        internal Subject[] Subjects { get; set; }

        public override string ToString()
        {
            return $"{Id}\n {FirstName}\n {LastName}\n {FatherName}\n {Age}\n Course: {Course}\n EntryDate: {EntryDate}\n Group:{Group}\n ";
        }
    }
   
    internal class Subject : Entity
    {
        internal string Name { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }




}
