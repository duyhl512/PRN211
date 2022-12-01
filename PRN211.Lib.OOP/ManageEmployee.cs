using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211.Lib.OOP
{
    public class ManageEmployee
    {
        private List<Employee> _employees;
        public List<Employee> Employees { get => _employees;  }



        public void AddEmployee(Employee e)
        {
            if(!Check(e)) _employees.Add(e);
        }


        public void UpdateEmployee(Employee e)
        {
            int index = GetIndexEmployee(e);
            // Lấy vị trí trong list mà e tồn tại
            if(index != -1) _employees[index] = e;
            
        }


        public void ShowAllEmployee()
        {
            foreach(Employee e in _employees)
            {
                Console.WriteLine(e);
            }
        }



        private int GetIndexEmployee(Employee e)
        {
            for(int i = 0; i < _employees.Count; i++)
            {
                if (_employees[i].Id == e.Id) return i;
            }
            return -1;
        }


        private bool Check(Employee e)
        {
            for (int i = 0; i < _employees.Count; i++)
            {
                if (_employees[i].Id == e.Id)
                {
                    return true;
                }
            }
            return false;

        }

    }
}
