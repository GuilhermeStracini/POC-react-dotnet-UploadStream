using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Net.Http.Headers;
using POCUploadStream.Helpers;
using System.Threading.Tasks;

namespace POCUploadStream.Controllers
{
    [Route("api/[controller]")]
    public class UploadController : Controller
    {
        private static readonly FormOptions DefaultFormOptions = new FormOptions();

        [HttpPost("[action]")]
        public async Task<IActionResult> Index()
        {
            if (!MultipartRequestHelper.IsMultipartContentType(Request.ContentType))
                return BadRequest($"Expected a multipart request, but got {Request.ContentType}");
            var boundary = MultipartRequestHelper.GetBoundary(
                MediaTypeHeaderValue.Parse(Request.ContentType),
                DefaultFormOptions.MultipartBoundaryLengthLimit);
            var reader = new MultipartReader(boundary, HttpContext.Request.Body);
            var section = await reader.ReadNextSectionAsync();
            while (section != null)
            {
                await MultipartRequestHelper.Upload(section);
                section = await reader.ReadNextSectionAsync();
            }

            return Ok(new { Success = true, boundary.Length });
        }
    }
}