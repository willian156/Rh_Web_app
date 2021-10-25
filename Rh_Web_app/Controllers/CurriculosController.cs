using Microsoft.AspNetCore.Http;
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
    public class CurriculosController : Controller
    {
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            List<Curriculos> VgaInfo = new List<Curriculos>();

            //mandando o request para achar os recursos de GetCurriculos usando HttpClient
            HttpResponseMessage Res = await GlobalVariables.WebApiClient.GetAsync("api/Curriculos");

            //Checando a resposta se obteve sucesso ou não
            if (Res.IsSuccessStatusCode)
            {
                //Armazenando os detalhes da resposta recebidas pela API
                var VgaResponse = Res.Content.ReadAsStringAsync().Result;

                //Desserializando a resposta e a armazenando na lista de Vagas
                VgaInfo = JsonConvert.DeserializeObject<List<Curriculos>>(VgaResponse);
            }

            //Retornando a lista de vagas para a view
            return View(VgaInfo);
        }

        public async Task<ActionResult<Curriculos>> GetById(int id)
        {
            List<Curriculos> VgaInfo = new List<Curriculos>();

            Curriculos vgEdit = new Curriculos();

            HttpResponseMessage Res = await GlobalVariables.WebApiClient.GetAsync("api/Curriculos");

            if (Res.IsSuccessStatusCode)
            {
                //Armazenando os detalhes da resposta recebidas pela API
                var VgaResponse = Res.Content.ReadAsStringAsync().Result;

                //Desserializando a resposta e a armazenando na lista de Vagas
                VgaInfo = JsonConvert.DeserializeObject<List<Curriculos>>(VgaResponse);
            }
            foreach (Curriculos item in VgaInfo)
            {
                if (id == item.id_curriculo)
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
        public ActionResult Create(Curriculos item)
        {
            var postTask = GlobalVariables.WebApiClient.PostAsJsonAsync("api/Curriculos", item);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            return View(item);
        }

        public async Task<ActionResult<Curriculos>> Edit(int id)
        {
            List<Curriculos> VgaInfo = new List<Curriculos>();

            Curriculos vgEdit = new Curriculos();

            HttpResponseMessage Res = await GlobalVariables.WebApiClient.GetAsync("api/Curriculos");

            if (Res.IsSuccessStatusCode)
            {
                //Armazenando os detalhes da resposta recebidas pela API
                var VgaResponse = Res.Content.ReadAsStringAsync().Result;

                //Desserializando a resposta e a armazenando na lista de Vagas
                VgaInfo = JsonConvert.DeserializeObject<List<Curriculos>>(VgaResponse);
            }
            foreach (Curriculos item in VgaInfo)
            {
                if (id == item.id_curriculo)
                {
                    vgEdit = item;
                    break;
                }
            }

            return View(vgEdit);
        }


        public async Task<ActionResult<Curriculos>> Save(Curriculos item)
        {
            var res = GlobalVariables.WebApiClient.PutAsJsonAsync("api/Curriculos", item);
            res.Wait();

            var result = res.Result;

            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            return View(Edit(item.id_curriculo));
        }


        public async Task<ActionResult<Curriculos>> Delete(int id)
        {
            string urlDel = "api/Curriculos/";
            urlDel = urlDel + id.ToString();
            var res = await GlobalVariables.WebApiClient.DeleteAsync(urlDel);


            return RedirectToAction("Index");
        }

        public async Task<ActionResult<Curriculos>> Details(int id)
        {
            List<Curriculos> VgaInfo = new List<Curriculos>();

            Curriculos vgView = new Curriculos();

            HttpResponseMessage Res = await GlobalVariables.WebApiClient.GetAsync("api/Curriculos");

            if (Res.IsSuccessStatusCode)
            {
                //Armazenando os detalhes da resposta recebidas pela API
                var VgaResponse = Res.Content.ReadAsStringAsync().Result;

                //Desserializando a resposta e a armazenando na lista de Vagas
                VgaInfo = JsonConvert.DeserializeObject<List<Curriculos>>(VgaResponse);
            }
            foreach (Curriculos item in VgaInfo)
            {
                if (id == item.id_curriculo)
                {
                    vgView = item;
                }
            }

            return View(vgView);
        }
    }
}
