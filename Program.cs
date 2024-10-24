using System;

class Program
{
    static void Main()
    {
        Library library = new Library();

        // Exemplo de adicionar livros
        library.AddBook(new Book("The Hobbit", "J.R.R. Tolkien", 1937));
        library.AddBook(new Book("1984", "George Orwell", 1949));
        library.AddBook(new Book("The Catcher in the Rye", "J.D. Salinger", 1951));

        // Listando livros
        Console.WriteLine("\nBooks in the Library:");
        library.ListBooks();

        // Emprestando um livro
        Console.WriteLine("\nBorrowing '1984':");
        library.BorrowBook("1984");

        // Tentando emprestar um livro já emprestado
        Console.WriteLine("\nTrying to borrow '1984' again:");
        library.BorrowBook("1984");

        // Listando livros após empréstimo
        Console.WriteLine("\nBooks in the Library after borrowing:");
        library.ListBooks();

        // Devolvendo um livro
        Console.WriteLine("\nReturning '1984':");
        library.ReturnBook("1984");

        // Removendo um livro
        Console.WriteLine("\nRemoving 'The Catcher in the Rye':");
        library.RemoveBook("The Catcher in the Rye");

        // Listando livros após remover
        Console.WriteLine("\nBooks in the Library after removal:");
        library.ListBooks();
    }
}
