using System; // Includes basic system functionality like Console

namespace EmployeeQuitApp
{
    // Define an interface called IQuittable
    public interface IQuittable
    {
        // Declare a method signature that all implementing classes must define
        void Quit();
    }

    // Define the Employee class and implement the IQuittable interface
    public class Employee : IQuittable
    {
        // Public property for the employee's unique ID
        public int Id { get; set; }

        // Public property for the employee's first name
        public string FirstName { get; set; }

        // Public property for the employee's last name
        public string LastName { get; set; }

        // Implement the Quit() method from the IQuittable interface
        public void Quit()
        {
            // You can define the quit behavior in any way you choose
            Console.WriteLine($"{FirstName} {LastName} (ID: {Id}) has quit the company.");
        }

        // Overload the '==' operator to compare Employee objects based on Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (ReferenceEquals(emp1, null))
                return ReferenceEquals(emp2, null);

            if (ReferenceEquals(emp2, null))
                return false;

            return emp1.Id == emp2.Id;
        }

        // Overload the '!=' operator as required when '==' is overloaded
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals() to be consistent with the overloaded '==' operator
        public override bool Equals(object obj)
        {
            var other = obj as Employee;
            if (other == null) return false;

            return this == other;
        }

        // Override GetHashCode() to be consistent with Equals()
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    // Program class contains the application's entry point
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object and assign values
            Employee emp = new Employee
            {
                Id = 200,
                FirstName = "Salwa",
                LastName = "AlAjwa"
            };

            // Use polymorphism: assign the Employee object to a variable of type IQuittable
            IQuittable quittableEmp = emp;

            // Call the Quit method using the IQuittable interface reference
            quittableEmp.Quit(); // Output: Salwa AlAjwa (ID: 200) has quit the company.

            // Keep the console window open until the user presses a key
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
