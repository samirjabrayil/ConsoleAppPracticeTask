namespace ConsoleAppTask.Models
{
    internal class Department : Entity
    {
        internal string Name { get; set; }
        internal Teacher Leader { get; set; }
        internal Teacher[] Teaher { get; set; } = new Teacher[0];

        public override string ToString()
        {
            return $"{Id} {Name} ";
        }
    }


}
