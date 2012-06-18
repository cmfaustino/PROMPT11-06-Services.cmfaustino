using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel; //System.ServiceModel - ServiceContract
using System.ServiceModel.Web; //System.ServiceModel.Web - WebGet
using System.Net.Http; //System.Net.Http - HttpResponseMessage ; HttpClient
using System.Threading.Tasks; //System.Threading.Tasks - Task
using System.IO; //System.IO - Stream
using System.Net.Http.Headers; //System.Net.Http.Headers - HttpContentHeaders
using System.Net; //System.Net - TransportContext
using System.Net.Http.Formatting; //System.Net.Http.Formatting - MediaTypeFormatter
using Microsoft.ApplicationServer.Http; //Microsoft.ApplicationServer.Http - HttpServiceHost ; HttpConfiguration

namespace GitHubWcfWebWpiHttp
{
    [ServiceContract]
    class Servico
    {
        [WebGet(UriTemplate = "commitslist")]
        protected HttpResponseMessage GetCommitsList()
        {
            const string urlDeListaDeCommitsDoGithub = "https://github.com/repos/nancyfx/nancy/commits";
            var client = new HttpClient();
            client.DefaultRequestHeaders.Remove("Accept");
            client.DefaultRequestHeaders.Add("Accept","application/json");
            Task<HttpResponseMessage> tres = client.GetAsync(urlDeListaDeCommitsDoGithub); //...GET para GITHUB...
            HttpResponseMessage res = tres.Result;
            //TODO : done 1 de 5 - fazer mais alguma coisa relacionada com JSON ?!
            return res;
        }
    }

    //TODO : 2 de 5 - definir class propria

    class Formatador : MediaTypeFormatter
    {
        public Formatador()
        {
            this.SupportedMediaTypes.Clear();
            this.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/atom+xml"));
        }

        protected override object OnReadFromStream(Type type, Stream stream, HttpContentHeaders contentHeaders)
        {
            throw new NotImplementedException();
        }

        protected override void OnWriteToStream(Type type, object value, Stream stream, HttpContentHeaders contentHeaders, TransportContext context)
        {
            throw new NotImplementedException();
            //TODO : 3 de 5 - utilizar SyndicationFeed.SaveAsAtom10
        }

        protected override bool CanReadType(Type type)
        {
            return false;
        }

        protected override bool CanWriteType(Type type)
        {
            //TODO : 4 de 5 - utilizar class propria
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //...repositorio NancyFx/Nancy... retornar coleccao de itens=commits em formato Atom, consultando GitHub
            //...efeito sera' o mesmo de https://github.com/nancyfx/nancy/commits.atom ...
            Console.WriteLine("Inicio do Programa...");
            var config = new HttpConfiguration();
            //TODO : 5 de 5 - utilizar MediaTypeFormatter Formatador
            var host = new HttpServiceHost(typeof(Servico), config, "http://localhost:8080");
            host.Open();
        }
    }
}
