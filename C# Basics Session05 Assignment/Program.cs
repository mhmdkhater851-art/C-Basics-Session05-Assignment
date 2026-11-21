namespace C__Basics_Session05_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book01 = new Book();
            #region Q01
            //Add a private string password = "secret"; field to a Book class. Try to print it from Main
            //(outside the class). What happens, and why?
            //Console.WriteLine(book01.password);
            // Password will be inaccessible due to its protiction level (Access Modifire)
            // Because its Access Modifire is Private : it is accessible only within the contaning class
            #endregion

            #region Q02
            //Add an internal int copiesInStock = 5; field to Book.Print it from Main.Does it compile?
            //Why?

            Console.WriteLine(book01.copiesInStock);
            // Yes, it will compile.
            // "copiesInStock" has the "internal" access modifier,
            // which allows access from any class within the same project.
            #endregion
        }
    }
}
