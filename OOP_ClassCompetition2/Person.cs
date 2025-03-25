namespace OOP_ClassCompetition2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating Library
            Library library = new Library();

            // Adding Books
            library.AddBook(new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4));
            library.AddBook(new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3));
            library.AddBook(new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6));

            // Adding Patrons
            library.AddPatron(new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026));
            library.AddPatron(new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025));
            library.AddPatron(new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services"));

            // Display Initial Data
            library.DisplayBooks();
            library.DisplayPatrons();

            // Perform Borrowing
            Console.WriteLine("Borrowing Books...");
            library.BorrowBook("Sandeep", "Business Insights with AI");
            library.BorrowBook("Akhil", "Analytics in Action");

            // Display After Borrowing
            Console.WriteLine("\nBooks after borrowing:");
            library.DisplayBooks();
        }
    }
}

