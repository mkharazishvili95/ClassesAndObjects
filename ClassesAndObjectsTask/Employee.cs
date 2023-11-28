namespace ClassesAndObjectsTask
{
    public class employee
    {
        public string Surname { get; set; }
        public int Age { get; set; }

        public employee()
        {
            Age = 28;
            Surname = "Kharazishvili";
        }

        public employee(string surname, int age)
        {
            this.Surname = surname;
            this.Age = age;
        }

        private string PrivateMethod()
        {
            return "Unknown Result";
        }

        public void SetSurname(string newSurname)
        {
            this.Surname = newSurname;
        }

        public string GetEmployeeInfo()
        {
            return $"Surname: {Surname}, Age: {Age}";
        }
    }
}
