namespace ConsoleAppTask.Models
{
    internal class Teacher : Person
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal string FatherName { get; set; }
        internal string Subject { get; set; }
        internal Group Group { get; set; }
        internal Department Department { get; set; }
        internal Group[] Groups { get; set; } = new Group[10];

        public override string ToString()
        {
            return $"{Id}\n {FirstName}\n {LastName}\n {FatherName}\n {Age}\n  Subject: {Subject}\n Group: {Group}\n Department:{Department}\n ";

        }
    }


}
