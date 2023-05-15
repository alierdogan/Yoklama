using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using YoklamaWebApp.Classes;

namespace YoklamaWebApp.Controllers
{
    public class PersonController : Controller, IBaseController
    {
        private readonly HttpClient _httpClient;

        public PersonController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Search()
        {
            var persons = await _httpClient.GetFromJsonAsync<List<Person>>(YoklamaUtility.YoklamaApiUrl + "Person/All");
            if (persons != null)
            {
                return View(persons);
            }
            return View();
        }

        public async Task<IActionResult> Entry()
        {
            return View();
        }

        public async Task<IActionResult> Detail()
        {
            return View();
        }

        public async Task<IActionResult> Update(int id)
        {
            return View("Detail");
        }

        public async Task<IActionResult> Delete(int id)
        {
            return View("Search");
        }
    }
}
