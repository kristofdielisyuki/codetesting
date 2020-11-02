using codetesting.inputvalidation.Models;
using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.IO;

namespace codetesting.inputvalidation.tests.recommended
{
    public class When_Loading_Books
    {
        [Test]
        public void Can_Fetch_All_Books()
        {
            var books = BooksApi.GetAll();

            BooksValidator.AreValid(books).Valid.ShouldBeTrue();
        }

        [Test]
        public void Exception_Thrown_When_Empty_List_Provided()
        {
            var msg = Should.Throw<InvalidDataException>(() => {
                BooksValidator.AreValid(null);
            }).Message;

            msg.Equals(BooksValidator.NULL_REFERENCE, StringComparison.InvariantCultureIgnoreCase)
                .ShouldBeTrue();

            var validationResult = BooksValidator.AreValid(new List<Book>());
            validationResult.Valid.ShouldBeFalse();
            validationResult.FailureReason.ShouldBe(BooksValidator.EMPTY_LIST);
        }

        [Test]
        public void Can_Detect_Invalid_Books()
        {
            var books = new List<Book>
            {
                new Book{ Id = Guid.NewGuid(), Title = "A valid book", Author = "Valid Author" },
                new Book{ Id = Guid.NewGuid(), Author = "Not Valid" }
            };

            var validationResult = BooksValidator.AreValid(books);
            validationResult.Valid.ShouldBeFalse();
            validationResult.FailureReason.ShouldBe(BooksValidator.BOOKS_WITHOUT_TITLES_DETECTED);
        }
    }
}