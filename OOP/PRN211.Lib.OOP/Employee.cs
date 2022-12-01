namespace PRN211.Lib.OOP
{
    public class Employee
    {
        /*
         Field - data
         */
        private int _id;

        public int Id { get => _id; set => _id = value; }

        public String Name { get; set; }

        public DateOnly Dob { get; set; }

        public int Workhourly { get; set; }
        
        public double Rate { get; set; }



        /*
         Contructor
         */

        public Employee()
        {
        }

        public Employee( int id, string name, DateOnly dob, int workhourly, double rate)
        {
            Id = id;
            Name = name;
            Dob = dob;
            Workhourly = workhourly;
            Rate = rate;
        }
        // Hàm tính lương

        public double GetSalary() => Workhourly * Rate;
        
        public override string? ToString() => Display();

        // Hiển thị thông tin

        public String Display() => $"Id: {Id}, Name: {Name}, Date of Birth: {Dob}, Salary: {GetSalary()}";
    }
}