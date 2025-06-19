// the parent class showing the "virtual" keyword included
public abstract class Employee
{
  private string _employeeName;

  // Notice the abstract method doesn't have a body at all
  // (not even an empty one) and it is followed by a semicolon.
  public abstract float CalculatePay();
}


// a child class
public class SalaryEmployee : Employee
{
    private float salary = 100f;

    public override float CalculatePay()
    {
        return salary;
    }
}


// a child class
public class HourlyEmployee : Employee
{
    private float rate = 9f;
    private float hours = 100f;

    public override float CalculatePay()
    {
        return rate * hours; // pay is calculated differently
    }
}


public class Program
{
    // ...

    // static Employee GetManager()
    // {
    //     // ... code here to find the manager ...
    //     return theManager;
    // }

    // static void DisplayManagerPay()
    // {
    //     Employee manager = GetManager();
    //     float pay = manager.CalculatePay();
    //     // ...
    // }

    public static void Main(string[] args)
    {
        // Create a list of Employees
        List<Employee> employees = new List<Employee>();

        // Create different kinds of employees and add them to the same list
        employees.Add(new Employee());
        employees.Add(new HourlyEmployee());

        // Get a custom calculation for each one
        foreach (Employee employee in employees)
        {
            float pay = employee.CalculatePay();
            Console.WriteLine(pay);
        }
    }
}
