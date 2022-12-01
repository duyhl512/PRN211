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

    }
}