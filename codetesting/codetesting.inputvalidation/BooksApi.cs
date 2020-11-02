using codetesting.inputvalidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codetesting.inputvalidation
{
	 public class BooksApi
	 {
		  public static IEnumerable<Book> GetAll()
		  {
				return new List<Book> 
				{ 
					 new Book
					 {
						  Id = Guid.NewGuid(),
						  Title = "The Lord of the Rings",
						  Author = "J.R.R Tolkien"
					 },
					 new Book
					 {
						  Id = Guid.NewGuid(),
						  Title = "Dune",
						  Author = "Frank Herbert"
					 },
					 new Book
					 {
						  Id = Guid.NewGuid(),
						  Title = "The Name of the Rose",
						  Author = "Umberto Eco"
					 },
					 new Book
					 {
						  Id = Guid.NewGuid(),
						  Title = "The Da Vinci Code",
						  Author = "Dan Brown"
					 }
				};
		  }
	 }
}
