namespace ConsoleAppTask.Models
{
    internal class Group : Entity
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal string FatherName { get; set; }
        internal int Age { get; set; }
        //public override string ToString()
        //{
        //    return $"{Id}\n {FirstName}\n {LastName}\n {FatherName}\n {Age}\n ";
        //}
        internal string Name { get; set; }
        internal Teacher[] Teachers { get; set; } = new Teacher[0];
        internal Student[] Students { get; set; } = new Student[0];

        public override string ToString()
        {
            return $"{Id} {Name} ";
        }

    }
}
