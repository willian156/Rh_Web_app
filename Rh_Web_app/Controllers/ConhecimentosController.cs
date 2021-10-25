using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Rh_Web_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Rh_Web_app.Controllers
{
    public class ConhecimentosController : Controller
    {
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            List<Conhecimentos> VgaInfo = new List<Conhecimentos>();

            //mandando o request para achar os recursos de GetCurriculos usando HttpClient
            HttpResponseMessage Res = await GlobalVariables.WebApiClient.GetAsync("api/Conhecimentos");

            //Checando a resposta se obteve sucesso ou não
            if (Res.IsSuccessStatusCode)
            {
                //Armazenando os detalhes da resposta recebidas pela API
                var VgaResponse = Res.Content.ReadAsStringAsync().Result;

                //Desserializando a resposta e a armazenando na lista de Vagas
                VgaInfo = JsonConvert.DeserializeObject<List<Conhecimentos>>(VgaResponse);
            }

            //Retornando a lista de vagas para a view
            return View(VgaInfo);
        }

        public async Task<ActionResult<Conhecimentos>> GetById(int id)
        {
            List<Conhecimentos> VgaInfo = new List<Conhecimentos>();

            Conhecimentos vgEdit = new Conhecimentos();

            HttpResponseMessage Res = await GlobalVariables.WebApiClient.GetAsync("api/Conhecimentos");

            if (Res.IsSuccessStatusCode)
            {
                //Armazenando os detalhes da resposta recebidas pela API
                var VgaResponse = Res.Content.ReadAsStringAsync().Result;

                //Desserializando a resposta e a armazenando na lista de Vagas
                VgaInfo = JsonConvert.DeserializeObject<List<Conhecimentos>>(VgaResponse);
            }
            foreach (Conhecimentos item in VgaInfo)
            {
                if (id == item.id_Conhecimentos)
                {
                    vgEdit = item;
                }
            }

            return vgEdit;

        }


        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Conhecimentos item)
        {
            var postTask = GlobalVariables.WebApiClient.PostAsJsonAsync("api/Conhecimentos", item);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            return View(item);
        }

        public async Task<ActionResult<Conhecimentos>> Edit(int id)
        {
            List<Conhecimentos> VgaInfo = new List<Conhecimentos>();

            Conhecimentos vgEdit = new Conhecimentos();

            HttpResponseMessage Res = await GlobalVariables.WebApiClient.GetAsync("api/Conhecimentos");

            if (Res.IsSuccessStatusCode)
            {
                //Armazenando os detalhes da resposta recebidas pela API
                var VgaResponse = Res.Content.ReadAsStringAsync().Result;

                //Desserializando a resposta e a armazenando na lista de Vagas
                VgaInfo = JsonConvert.DeserializeObject<List<Conhecimentos>>(VgaResponse);
            }
            foreach (Conhecimentos item in VgaInfo)
            {
                if (id == item.id_Conhecimentos)
                {
                    vgEdit = item;
                    break;
                }
            }

            return View(vgEdit);
        }


        public async Task<ActionResult<Conhecimentos>> Save(Conhecimentos item)
        {
            var res = GlobalVariables.WebApiClient.PutAsJsonAsync("api/Conhecimentos", item);
            res.Wait();

            var result = res.Result;

            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            return View(Edit(item.id_Conhecimentos));
        }


        public async Task<ActionResult<Conhecimentos>> Delete(int id)
        {
            string urlDel = "api/Conhecimentos/";
            urlDel = urlDel + id.ToString();
            var res = await GlobalVariables.WebApiClient.DeleteAsync(urlDel);


            return RedirectToAction("Index");
        }

        public async Task<ActionResult<Conhecimentos>> Details(int id)
        {
            List<Conhecimentos> VgaInfo = new List<Conhecimentos>();

            Conhecimentos vgView = new Conhecimentos();

            HttpResponseMessage Res = await GlobalVariables.WebApiClient.GetAsync("api/Curriculos");

            if (Res.IsSuccessStatusCode)
            {
                //Armazenando os detalhes da resposta recebidas pela API
                var VgaResponse = Res.Content.ReadAsStringAsync().Result;

                //Desserializando a resposta e a armazenando na lista de Vagas
                VgaInfo = JsonConvert.DeserializeObject<List<Conhecimentos>>(VgaResponse);
            }
            foreach (Conhecimentos item in VgaInfo)
            {
                if (id == item.id_Conhecimentos)
                {
                    vgView = item;
                }
            }

            return View(vgView);
        }
    }
}
