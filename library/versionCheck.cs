namespace VersionCheck;

using System;
using System.Net;
using System.IO;

public class version
{
    System.Diagnostics.FileVersionInfo thisSystemVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(
        System.Reflection.Assembly.GetExecutingAssembly().Location);

        public check()
        {
        
        }
        internal string getLatestVersion(string endpointURL)
        {
            string latestVersion = "";
            isURL
            using (var webClient = new System.Net.webClient())
            {
                
            }
            return latestVersion;
        }

        internal bool isURLExists(string URL)
        {
            using (var httpClient = new HttpClient())
            {
                response = httpClient.GetAsync(URL).Result;
            }

            switch (response.StatusCode)
            {
                case "OK":
                    return true;
                
                default:
                    return false;
            }
        }
}