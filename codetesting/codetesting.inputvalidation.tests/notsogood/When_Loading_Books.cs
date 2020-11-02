using NUnit.Framework;
using Shouldly;
using System.Linq;

namespace codetesting.inputvalidation.tests.notsogood
{
    public class When_Loading_Books
    {
        [Test]
        public void Can_Fetch_All_Books()
        {
            var books = BooksApi.GetAll();

            books.ShouldNotBeNull();
            books.Any().ShouldBeTrue();
            books.Where(b => string.IsNullOrEmpty(b.Title)).Any().ShouldBeFalse();
        }
    }
}
