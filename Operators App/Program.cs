using System; // Required to use Console and other system functions

namespace EmployeeComparisonApp
{
    // Define the Employee class with three public properties
    public class Employee
    {
        // Property to store the employee's unique ID
        public int Id { get; set; }

        // Property to store the employee's first name
        public string FirstName { get; set; }

        // Property to store the employee's last name
        public string LastName { get; set; }

        // Overload the '==' operator to compare Employee objects by their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check for null on left side
            if (ReferenceEquals(emp1, null))
            {
                return ReferenceEquals(emp2, null);
            }

            // Check for null on right side
            if (ReferenceEquals(emp2, null))
            {
                return false;
            }

            // Return true if both Employee objects have the same Id
            return emp1.Id == emp2.Id;
        }

        // Overload the '!=' operator, which must be overloaded in tandem with '=='
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Use the already defined '==' operator to determine inequality
            return !(emp1 == emp2);
        }

        // Override Equals() method to be consistent with '==' operator
        public override bool Equals(object obj)
        {
            // Return false if the other object is null or not an Employee
            var other = obj as Employee;
            if (other == null) return false;

            // Use the overloaded '==' for equality check
            return this == other;
        }

        // Override GetHashCode() when overriding Equals()
        public override int GetHashCode()
        {
            // Use Id as hash code basis since equality is based on Id
            return Id.GetHashCode();
        }
    }

    // Main program class
    class Program
    {
        // Entry point of the console application
        static void Main(string[] args)
        {
            // Instantiate the first Employee object and assign values
            Employee emp1 = new Employee();
            emp1.Id = 101;
            emp1.FirstName = "Salwa";
            emp1.LastName = "AlAjwa";

            // Instantiate the second Employee object and assign values
            Employee emp2 = new Employee();
            emp2.Id = 101; // Same Id as emp1 to test equality
            emp2.FirstName = "AlAjwa";
            emp2.LastName = "Ajwa";

            // Compare the two Employee objects using overloaded '==' operator
            bool areEqual = emp1 == emp2;

            // Display the result of the equality check
            Console.WriteLine("Are emp1 and emp2 equal? " + areEqual); // Expected: True

            // Use the overloaded '!=' operator to check inequality
            bool areNotEqual = emp1 != emp2;

            // Display the result of the inequality check
            Console.WriteLine("Are emp1 and emp2 not equal? " + areNotEqual); // Expected: False

            // Keep the console window open until a key is pressed
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
