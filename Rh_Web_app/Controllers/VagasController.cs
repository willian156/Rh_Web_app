using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Rh_Web_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Rh_Web_app.Controllers
{
    public class VagasController : Controller
    {
        //Url inicial da API
        string Baseurl = "https://localhost:44305/";
        public async Task<ActionResult> Index()
        {
            List<Vagas> VgaInfo = new List<Vagas>();
            using (var client = new HttpClient())
            {
                //Passando a url base do serviço
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();

                //Definindo o data format do request
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //mandando o request para achar os recursos de GetVaga usando HttpClient
                HttpResponseMessage Res = await client.GetAsync("api/Vagas");

                //Checando a resposta se obteve sucesso ou não
                if (Res.IsSuccessStatusCode)
                {
                    //Armazenando os detalhes da resposta recebidas pela API
                    var VgaResponse = Res.Content.ReadAsStringAsync().Result;

                    //Desserializando a resposta e a armazenando na lista de Vagas
                    VgaInfo = JsonConvert.DeserializeObject<List<Vagas>>(VgaResponse);
                }

                //Retornando a lista de vagas para a view
                return View(VgaInfo);
            }
        }

        public ActionResult NovaVaga()
        {
            return View();
        }
        public async Task<ActionResult> NovaVaga()
        {
            List<Vagas> VgaInfo = new List<Vagas>();
            using (var client = new HttpClient())
            {
                //Passando a url base do serviço
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();

                //Definindo o data format do request
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //mandando o request para achar os recursos de GetVaga usando HttpClient
                HttpResponseMessage Res = await client.GetAsync("api/Vagas");

                //Checando a resposta se obteve sucesso ou não
                if (Res.IsSuccessStatusCode)
                {
                    //Armazenando os detalhes da resposta recebidas pela API
                    var VgaResponse = Res.Content.ReadAsStringAsync().Result;

                    //Desserializando a resposta e a armazenando na lista de Vagas
                    VgaInfo = JsonConvert.DeserializeObject<List<Vagas>>(VgaResponse);
                }
            }

            foreach( Vagas item in VgaInfo)
            {
                if(!item.id_vaga.Equals(VgaInfo.))
            }
        }
    }
}
