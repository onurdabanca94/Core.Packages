using Core.CrossCuttingConcerns.Exceptions.Types;

namespace Core.CrossCuttingConcerns.Exceptions.Handlers;

public abstract class ExceptionHandler
{
    public Task HandleExceptionAsync(Exception exception) =>
        exception switch
        {
            BusinessException businessException => HandleException(businessException), // Eğer exception tanımladığımız exception ise yani: businessException ise
            ValidationException validationException => HandleException(validationException),
            _ => HandleException(exception) // Tanımlanan exception haricinde bir exception gelirse yukarıdaki exception'ı handle et.
        };

    protected abstract Task HandleException(BusinessException businessException); //ExceptionHandler'ı inherit eden sınıf buradakini doldurmak zorunda olsun. Implement etsin.
    protected abstract Task HandleException(ValidationException validationException);
    protected abstract Task HandleException(Exception exception); //Eğer exception businessException değilse bu çalışacak.

}
