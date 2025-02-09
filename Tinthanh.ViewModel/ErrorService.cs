
using Microsoft.Extensions.Configuration;
 
using System.IO;


namespace Tinthanh.ViewModel
{

    public static class ErrorService
    {
        public static Action<string> ShowError { get; set; }

        public static void ReportError(string errorMessage)
        {
            ShowError?.Invoke(errorMessage);
        }
    }


}
