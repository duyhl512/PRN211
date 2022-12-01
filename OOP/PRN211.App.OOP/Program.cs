
/*
    Yêu cầu quản lý nhân viên gồm id, name, dob, workhourly, rate,. Thực hiện các chức năng sau
    + Nhập vào một hoặc nhiều nhân viên
    + Thay đổi thông tin nhân viên bất kì
    + Remove một nhân viên bất kì
    + Hiển thị toàn bộ nhân viên ra ngoài màn hình
    + Tính và hiển thị tổng lương ra màn hình của một nhân viên bất kỳ theo id
 */

/*
    - Tính trừu tượng ( Abstraction)
    - Tính đóng gói ( Encapsulation)
*/


using PRN211.Lib.OOP;

Employee e1 = new Employee(1, "Nguyen Van A", new DateOnly(1999, 12, 05), 8, 10);

Employee e2 = new Employee(2, "Nguyen Van B", new DateOnly(1999, 12, 06), 9, 10);

Employee e3 = new Employee(3, "Nguyen Van C", new DateOnly(1999, 12, 07), 8, 10);

ManageEmployee manage = new ManageEmployee();

manage.AddEmployee(e1);

manage.AddEmployee(e2);

manage.AddEmployee(e3);

manage.ShowAllEmployee();



