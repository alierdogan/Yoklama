using Microsoft.AspNetCore.Mvc;

namespace YoklamaWebApp.Classes
{
    
    public interface IBaseController
    {
        public Task<IActionResult> Search();
        public Task<IActionResult> Entry();
        public Task<IActionResult> Detail();
        public Task<IActionResult> Update(int id);
        public Task<IActionResult> Delete(int id);
    }
}
