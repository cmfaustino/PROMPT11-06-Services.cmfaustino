using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHubApiHttpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //...repositorio NancyFx/Nancy... contar commits por user ; contar issues por user
/*
exemplo de uso de API's: Felix, criar 40 repositorios GITHUB e associar teams a cada repositorio, programa que usa API

var client = new HttpClient();
Task<HttpResponseMessage> tres = client.Async(url_de_exemplo_do_github);
HttpResponseMessage res = tres.Result;

res tem:
- StatusCode
- ReasonPhrase
- Headers
- Content (que tem, por exemplo, outros .Headers ._ , e metodo .ReadAsAsync<> com IEnumerable<Issue> por exemplo)
*/
            Console.WriteLine("Inicio do Programa...");
        }
    }
}
