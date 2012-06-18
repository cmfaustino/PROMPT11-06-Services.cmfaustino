using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel; // adicionado
using System.Runtime.Serialization; // adicionado
using System.ServiceModel.Description; // adicionado
using FirstSOAPservice.HolidayService2Reference; // adicionado para tipos serem utilizados no cliente

namespace FirstSOAPservice
{
    [DataContract]
    class WordLookUpReq
    {
        [DataMember]
        public string Palavra;
    }

    [DataContract]
    class WordLookUpResp
    {
        [DataMember]
        public bool Existe;

        [DataMember(EmitDefaultValue = false)]
        public string Palavra;
    }

    [ServiceContract]
    internal interface IDictService
    {
        [OperationContract]
        WordLookUpResp WordLookUp(WordLookUpReq req);
    }

    class MeuServico : IDictService
    {
        private readonly Dictionary<string, string> _dictionary;
        MeuServico()
        {
            _dictionary = new Dictionary<string, string>
                              {
                                  {
                                      "professor",
                                      "Aquele que ensina uma arte, uma actividade, uma ciencia, uma lingua, etc."
                                      },
                                  {"aluno", "aprende"}
                              };
        }

        public WordLookUpResp WordLookUp(WordLookUpReq req)
        {
            var palavra = req.Palavra;
            var resposta = new WordLookUpResp { Existe = _dictionary.ContainsKey(palavra) };
            if (resposta.Existe)
            {
                resposta.Palavra = _dictionary[palavra];
            }
            return resposta;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(MeuServico), new Uri("http://localhost:8080/")); // classe que implementa o servico
            host.AddServiceEndpoint(typeof(IDictService), new BasicHttpBinding(), "ep1"); // novo endereco relativo do endpoint
            host.AddServiceEndpoint(typeof(IDictService), new BasicHttpBinding(), "ep2"); // novo endereco relativo do endpoint
            host.Description.Behaviors.Add(
                new ServiceMetadataBehavior { HttpGetEnabled = true, HttpGetUrl = new Uri("http://localhost:8080/metadata") }
            ); // expor a metadata
            host.Open(); // abrir o servico ... necessita de permissoes de administracao, devido 'a componente httpsys
            Console.WriteLine("Service is open...");
            //UseServiceHolidays1();
            //Console.WriteLine("Service 1 ends...");
            UseServiceTranslatorEdictExercicio();
            Console.WriteLine("Service Translator e Dict ends...");
            Console.ReadKey();
        }

        // add service reference - http://www.holidaywebservice.com/HolidayService_v2/HolidayService2.asmx
        // add service reference - http://services.aonaware.com/DictService/DictService.asmx
        // add service reference - http://api.microsofttranslator.com/V2/Soap.svc

        static void UseServiceHolidays1()
        {
            var clnt = new HolidayService2Reference.HolidayService2SoapClient("HolidayService2Soap12"); // indicar endpoint name
            var paises = clnt.GetCountriesAvailable();
            paises.ToList().ForEach(p => Console.WriteLine("Code: {0} = {1} - hash {2}", p.Code, p.Description, p.GetHashCode()));
            var feriadosCanadianos = clnt.GetHolidaysAvailable(Country.Canada);
            feriadosCanadianos.ToList().ForEach(
                f =>
                Console.WriteLine("Feriado Canadiano: {0} = {1} - hash {2} - data {3}", f.Code, f.Description,
                                  f.GetHashCode(), clnt.GetHolidayDate(Country.Canada, f.Code, 2011)));
        }

        static void UseServiceTranslatorEdictExercicio()
        {
            var clnt = new MStranslatorSoapServiceReference.LanguageServiceClient("BasicHttpBinding_LanguageService");
            const string appIdent = "C1E6D88CE2967328BBA9BC6C932B9D177247CAE5";
            var idiomas = clnt.GetLanguagesForTranslate(appIdent);
            idiomas.ToList().ForEach(i => Console.WriteLine("Idioma: {0}", i));
            Console.Write("Escreva a palavra: ");
            var palavra = Console.ReadLine();
            Console.Write("Escreva o idioma de origem: ");
            var idiomaDe = Console.ReadLine();
            Console.Write("Escreva o idioma de destino: ");
            var idiomaPara = Console.ReadLine();
            // contentType = null ou "text/html" ; category = null ou "general"
            var traducao = clnt.Translate(appIdent, palavra, idiomaDe, idiomaPara, "text/html", null);
            Console.WriteLine("Palavra {0} , de {1} para {2}, e' {3} .", palavra, idiomaDe, idiomaPara, traducao);

            var clntdictfact = new ChannelFactory<IDictService>(new BasicHttpBinding(), new EndpointAddress(url));
        }
    }
}
