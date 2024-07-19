using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppEmployee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }

        public DateTime DeptCreation { get; set; }


    }
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }

        public string gender { get; set; }
        public string city { get; set; }
        public string address { get; set; }

    }
    public class TestEmloyeeDBContext : DbContext
    {
        public TestEmloyeeDBContext() : base("name=EmployeeInfo")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
    public  class Program
    {
        static void Main(string[] args)
        {
            TestEmloyeeDBContext testempdb = new TestEmloyeeDBContext();

            List<Employee> employees = testempdb.Employees.ToList();

            List<Department> departments = testempdb.Departments.ToList();

            Employee emp = new Employee();
            emp.EmployeeId = 1;
            emp.EmployeeName = "harsh srivastava";
            emp.Age = 28;
            emp.gender = "male";
            emp.city = "agra";
            emp.address = "Uttar pradesh";

            Employee emp1 = new Employee();
            emp1.EmployeeId = 2;
            emp1.EmployeeName = "Garvit";
            emp1.Age = 17;
            emp1.gender = "male";
            emp1.city = "Gujrat";
            emp1.address = "City Market Phase no. 2";

            Employee emp3 = new Employee();
            emp3.EmployeeId = 3;
            emp3.EmployeeName = "Ritika";
            emp3.Age = 29;
            emp3.gender = "female";
            emp3.city = "Varnasi";
            emp3.address = "Uttar Pradesh";

            testempdb.Employees.Add(emp);
            testempdb.Employees.Add(emp1);
            testempdb.Employees.Add(emp3);

            Department dept = new Department();
            dept.DeptName = "IT";
            dept.DeptId = 1;
            dept.DeptCreation = DateTime.Today;

            Department dept1 = new Department();
            dept1.DeptName = "HR";
            dept1.DeptId = 2;
            dept1.DeptCreation = DateTime.Today;

            Department dept2 = new Department();
            dept2.DeptName = "Development";
            dept2.DeptId = 3;
            dept2.DeptCreation = DateTime.Today;

            testempdb.Departments.Add(dept);
            testempdb.Departments.Add(dept1);
            testempdb.Departments.Add(dept2);

            testempdb.SaveChanges();
        }
    }

}
