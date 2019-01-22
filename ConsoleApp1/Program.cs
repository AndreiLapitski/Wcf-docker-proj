using Newtonsoft.Json;
using System;
using System.Collections;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var client = new HttpClient())
            {              
                client.BaseAddress = new Uri("http://localhost:51477");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //method environment-variables
                //var variables = client.GetAsync("environment-variables").Result;
                //var deserVariables = JsonConvert.DeserializeObject<IDictionary>(variables.Content.ReadAsStringAsync().Result);

                //foreach (var item in deserVariables.Keys)
                //{
                //    Console.WriteLine($"{item} -- {deserVariables[item]}");
                //}

                //method environment-variable/key
                //HttpResponseMessage response = client.GetAsync("environment-variable/" + "USERNAME").Result;
                //string value = response.Content.ReadAsStringAsync().Result;
                //Console.WriteLine(value);
            }

            Console.Read();
        }
    }
}
//FPS_BROWSER_USER_PROFILE_STRING -- Default
//LOGONSERVER -- \\EVBYGOMSA0003
//USERNAME -- Andrei_Lapitski2
//SystemRoot -- C:\WINDOWS
//VSSKUEDITION -- Professional
//MSMPI_BIN -- C:\Program Files\Microsoft MPI\Bin\
//OneDrive -- C:\Users\Andrei_Lapitski2\OneDrive - EPAM
//CommonProgramFiles(x86) -- C:\Program Files(x86)\Common Files
//VSLANG -- 1033
//UATDATA -- C:\Windows\CCM\UATData\D9F8C395-CAB8-491d-B8AC-179A1FE1BE77
//IISEXPRESS_SITENAME -- WebApi
//ProgramData -- C:\ProgramData
//VSAPPIDDIR -- C:\Program Files(x86)\Microsoft Visual Studio\2017\Professional\Common7\IDE\
//HOMEPATH -- \Users\Andrei_Lapitski2
//_NO_DEBUG_HEAP -- 1
//COMPUTERNAME -- EPBYGOMW0025
//ALLUSERSPROFILE -- C:\ProgramData
//DEV_ENVIRONMENT -- 1
//IN_DEBUG_MODE -- 1