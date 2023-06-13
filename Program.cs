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


           
            Circle circle1 = new Circle(3.3);
            Console.WriteLine("The area of " + circle1 + " = " + circle1.Area);
            //areaOfCircle();

        }
    }
}