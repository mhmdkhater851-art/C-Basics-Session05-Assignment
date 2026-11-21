using static System.Runtime.InteropServices.JavaScript.JSType;

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

            //Console.WriteLine(book01.copiesInStock);
            // Yes, it will compile.
            // "copiesInStock" has the "internal" access modifier,
            // which allows access from any class within the same project.
            #endregion

            #region Q03
            //Add a public string Title; field to Book.Set it and print it from Main.

            //book01.Title = "Programming Book";
            //Console.WriteLine(book01.Title);
            #endregion

            #region Q04
            //Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book,
            //assign it Genre.Science, and print it.
            //book01.BookGenre = Genre.Science;
            //Console.WriteLine(book01.BookGenre);
            #endregion

            #region Q05
            //Using the Genre enum above, print the underlying int value of
            //Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.

            //Console.WriteLine((int)Genre.Fiction);    // 0
            //Console.WriteLine((int)Genre.NonFiction); // 1
            //Console.WriteLine((int)Genre.Science);    // 2
            #endregion

            #region Q06
            //Given int genreNumber = 1;, cast it into a Genre value and print the result

            //int genreNumber = 1;
            //Genre result = (Genre)genreNumber;
            //Console.WriteLine(result);
            #endregion

            #region Q07
            //Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.
            //Genre genre = Genre.Fiction;
            //string genreAsString = genre.ToString();
            //Console.WriteLine(genreAsString);
            #endregion

            #region Q08
            //Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and
            //print the result.

            string genreText = "Science";
            Genre genreValue = (Genre) Enum.Parse(typeof(Genre), genreText);
            Console.WriteLine(genreValue);
            #endregion
        }
    }
}
