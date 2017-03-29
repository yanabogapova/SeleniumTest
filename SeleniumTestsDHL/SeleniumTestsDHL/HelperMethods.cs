using NUnit.Framework;
using System.Net;

namespace SeleniumTestsDHL
{
    public class HelperMethod : BaseClass
    {

        public static void VerifyResponseCode()
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(Driver.Url);
            HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
            StringAssert.Contains("OK", response.StatusCode.ToString());
        }
    }
}
