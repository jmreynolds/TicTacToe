using System.Diagnostics;

/*
 * ProfReynolds CoreLibrary Project written over 2010 through 2024
 * last review 2024-01-28
 */

namespace ProfReynolds.CoreLibrary;

public class ResponseClass
{
    public bool Success { get; set; }

    public string ImplementedInModule { get; set; }
        = ((new StackFrame(3, false)).GetMethod()?.Name ?? "") + "\r\n" +
          ((new StackFrame(2, false)).GetMethod()?.Name ?? "") + "\r\n" +
          ((new StackFrame(1, false)).GetMethod()?.Name ?? "");

    public string FailureInformation { get; set; }

    public ResponseClass() {
        FailureInformation = string.Empty;
    }

    public ResponseClass(bool success)
    {
        Success = success;
        FailureInformation = string.Empty;
    }

    public ResponseClass(string failureInformation)
    {
        FailureInformation = failureInformation;
    }

    public ResponseClass(Exception ex)
    {
        FailureInformation = ex.Message;
        if (ex.InnerException != null)
            FailureInformation += "\r\n" + ex.InnerException.Message;
    }

}