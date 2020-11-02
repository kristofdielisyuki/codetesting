namespace codetesting.inputvalidation.Models
{
	 public class BookValidationResult
	 {
		  public string FailureReason { get; set; }
		  public bool Valid => string.IsNullOrEmpty(FailureReason);

		  public static BookValidationResult Ok()
		  {
				return new BookValidationResult();
		  }

		  public static BookValidationResult Failure(string failureReason)
		  {
				return new BookValidationResult
				{
					 FailureReason = failureReason
				};
		  }
	 }
}
