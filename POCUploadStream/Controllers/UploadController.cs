using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using POCUploadStream.Filters;
using POCUploadStream.Helpers;
using System.Threading.Tasks;

namespace POCUploadStream.Controllers
{
    [Route("api/[controller]")]
    public class UploadController : Controller
    {
        private static readonly FormOptions DefaultFormOptions = new FormOptions();

        [DisableFormValueModelBinding]
        [HttpPost("[action]")]
        public async Task<IActionResult> Upload()
        {
            await UploadHelper.Process(Request);
            return Ok(new { Success = true });
        }
    }
}