namespace Core.CrossCuttingConcerns.Logging;

public class LogDetail
{
    public string Fullname { get; set; }
    public string MethodName { get; set; }
    public string User { get; set; }
    public List<LogParameter> Parameters { get; set; }

    public LogDetail()
    {
        Fullname = string.Empty;
        MethodName = string.Empty;
        User = string.Empty;
        Parameters = new List<LogParameter>();
    }

    public LogDetail(string fullName, string methodName, string user, List<LogParameter> parameters)
    {
        fullName = fullName;
        MethodName = methodName;
        User = user;
        Parameters = parameters;
    }
}
