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

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            List<Vagas> VgaInfo = new List<Vagas>();

            //mandando o request para achar os recursos de GetVaga usando HttpClient
            HttpResponseMessage Res = await GlobalVariables.WebApiClient.GetAsync("api/Vagas");

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

        public async Task<ActionResult<Vagas>> GetById(int id)
        {
            List<Vagas> VgaInfo = new List<Vagas>();

            Vagas vgEdit = new Vagas();

            HttpResponseMessage Res = await GlobalVariables.WebApiClient.GetAsync("api/Vagas");

            if (Res.IsSuccessStatusCode)
            {
                //Armazenando os detalhes da resposta recebidas pela API
                var VgaResponse = Res.Content.ReadAsStringAsync().Result;

                //Desserializando a resposta e a armazenando na lista de Vagas
                VgaInfo = JsonConvert.DeserializeObject<List<Vagas>>(VgaResponse);
            }
            foreach (Vagas item in VgaInfo)
            {
                if (id == item.id_vaga)
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
        public ActionResult Create(Vagas item)
        {
            var postTask = GlobalVariables.WebApiClient.PostAsJsonAsync("api/Vagas", item);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            return View(item);
        }

        public async Task<ActionResult<Vagas>> Edit(int id)
        {
            List<Vagas> VgaInfo = new List<Vagas>();

            Vagas vgEdit = new Vagas();

            HttpResponseMessage Res = await GlobalVariables.WebApiClient.GetAsync("api/Vagas");

            if (Res.IsSuccessStatusCode)
            {
                //Armazenando os detalhes da resposta recebidas pela API
                var VgaResponse = Res.Content.ReadAsStringAsync().Result;

                //Desserializando a resposta e a armazenando na lista de Vagas
                VgaInfo = JsonConvert.DeserializeObject<List<Vagas>>(VgaResponse);
            }
            foreach (Vagas item in VgaInfo)
            {
                if (id == item.id_vaga)
                {
                    vgEdit = item;
                    break;
                }
            }

            return View(vgEdit);
        }
       

        public async Task<ActionResult<Vagas>> Save(Vagas item)
        {
            var res = GlobalVariables.WebApiClient.PutAsJsonAsync("api/Vagas", item);
            res.Wait();

            var result = res.Result;

            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            return View(Edit(item.id_vaga));  
        }


        public async Task<ActionResult<Vagas>> Delete(int id) 
        {
            string urlDel = "api/Vagas/";
            urlDel = urlDel + id.ToString();
            var res = await GlobalVariables.WebApiClient.DeleteAsync(urlDel);


            return RedirectToAction("Index");
        }
        
        public async Task<ActionResult<Vagas>> Details(int id)
        {
            List<Vagas> VgaInfo = new List<Vagas>();

            Vagas vgView = new Vagas();

            HttpResponseMessage Res = await GlobalVariables.WebApiClient.GetAsync("api/Vagas");

            if (Res.IsSuccessStatusCode)
            {
                //Armazenando os detalhes da resposta recebidas pela API
                var VgaResponse = Res.Content.ReadAsStringAsync().Result;

                //Desserializando a resposta e a armazenando na lista de Vagas
                VgaInfo = JsonConvert.DeserializeObject<List<Vagas>>(VgaResponse);
            }
            foreach (Vagas item in VgaInfo)
            {
                if (id == item.id_vaga)
                {
                    vgView = item;
                }
            }

            return View(vgView);
        }


    }  
}

