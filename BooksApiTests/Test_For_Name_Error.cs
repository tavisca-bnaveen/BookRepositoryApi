﻿using Xunit;
using DAL;
using DAL.Model;
using ServiceLayer;

namespace BooksApiTests
{
    public class Test_For_Name_Error
    {
        [Fact]
        public void Name_Error_Test()
        {
            Book book = new Book { Id = 1, Name = "Naveen2", Price = 1000, Author = "Harikrishna", Category = "Joke" };
            BookRepository bookRepository = new BookRepository();
            Services services = new Services(bookRepository);
            var result = services.AddBook(book);
            Assert.Equal("Name, Category and Author: should contain only alphabets.", result.ErrorMessage);
            Assert.Equal(400, result.StatusCode);
        }
    }

}
