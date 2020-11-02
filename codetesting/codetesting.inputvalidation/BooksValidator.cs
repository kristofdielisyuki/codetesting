using codetesting.inputvalidation.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace codetesting.inputvalidation
{
	 public class BooksValidator
	 {
		  public static string NULL_REFERENCE = "Null reference detected. An empty list of books was provided.";
		  public static string EMPTY_LIST = "Empty list";
		  public static string BOOKS_WITHOUT_TITLES_DETECTED = "Books without valid title detected";

		  public static BookValidationResult AreValid(IEnumerable<Book> books)
		  {
				if (books == null)
					 throw new InvalidDataException(NULL_REFERENCE);

				if (!books.Any())
					 return BookValidationResult.Failure(EMPTY_LIST);

				var anyEmptyTitles = books.Where(b => string.IsNullOrEmpty(b.Title)).Any();
				if (anyEmptyTitles)
					 return BookValidationResult.Failure(BOOKS_WITHOUT_TITLES_DETECTED);

				return BookValidationResult.Ok();
		  }
	 }
}
