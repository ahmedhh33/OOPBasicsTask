namespace OOPBsicsTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book("Olover Twist "," Charles Dickens",1985); //EX 1
            Console.WriteLine("Book1 Details ");
            Console.WriteLine("Titel : " + book1.title);//printing  objects
            Console.WriteLine("Author :" + book1.author);
            Console.WriteLine("year :" + book1.year);
            Console.WriteLine();
            Book book2 = new Book("The Alchemist ", " Ben Jonson", 1996);
            Console.WriteLine("Book1 Details ");
            Console.WriteLine("Titel : " + book2.title);//printing  objects
            Console.WriteLine("Author :" + book2.author);
            Console.WriteLine("year :" + book2.year);
            Console.WriteLine();

            Console.WriteLine("*******************************************************************************************");

            Circle circle1 = new Circle(3.3);// EX 2
            Console.WriteLine("The area of " + "circle1" + " = " + circle1.Area);
            //areaOfCircle();

            Circle circle2 = new Circle(5);// EX 2
            Console.WriteLine("The area of " + "circle2" + " = " + circle2.Area);

            Console.WriteLine();
            Console.WriteLine("*******************************************************************************************");

            BankAccount myAccount = new BankAccount("92544","Ahmed Humaid",100);// EX 3
            //myAccount.Disposit(50);
            Console.WriteLine("The amount after dispositing for " + myAccount.OwnertName + " = " + myAccount.Disposit(50));
            //myAccount.Withdraw(75);
            Console.WriteLine("The amount after dispositing for " + myAccount.OwnertName + " = " + myAccount.Withdraw(75));
            //myAccount.Withdraw(100);
            Console.WriteLine("The amount after dispositing for " + myAccount.OwnertName + " = " + myAccount.Withdraw(100));

            BankAccount myAccount2 = new BankAccount("7790", "Salim Humaid", 456);// EX 3
            //myAccount.Disposit(50);
            Console.WriteLine("The amount after dispositing for "+myAccount2.OwnertName+" = "+myAccount2.Disposit(140));
            //myAccount.Withdraw(75);
            Console.WriteLine("The amount after withdrowing = " + myAccount2.OwnertName + " = " + myAccount2.Withdraw(289));
            //myAccount.Withdraw(100);
            Console.WriteLine("The amount after withdrowing = " + myAccount2.OwnertName + " = " + myAccount2.Withdraw(10));

            Console.WriteLine();
            Console.WriteLine("*******************************************************************************************");

            Employee employee1 = new Employee("Mohammed Alsikiti ", " IT Head ", 1478); //EX4
            Console.WriteLine("the name is " + employee1.Name + " the position is " + employee1.position + " the salary is " + employee1.Salary);

            Employee employee2 = new Employee("Mohammed Alhabsi ", " CEO ", 4000); //EX4
            Console.WriteLine("the name is " + employee2.Name + " the position is " + employee2.position + " the salary is " + employee2.Salary);
        }
    }
}