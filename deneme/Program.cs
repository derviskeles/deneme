using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("http://deneme.ticimax.com.tr/api/GetProduct");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{ \"TicimaxApiKey\" : \"34243241\", \"TicimaxApiSecret\" : \"24324324\" }", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

        }
    }
}
