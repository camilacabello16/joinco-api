using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Entities;
using Service.Models.ReponseModel;
using Service.Service;

namespace JoincoAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WorkspaceController : ControllerBase
    {
        private readonly WorkspaceService service;

        public WorkspaceController(WorkspaceService service)
        {
            this.service = service;
        }

        [HttpPost]
        public async Task<Response> Insert(Workspace input)
        {
            return await service.Insert(input, HttpContext);
        }
    }
}
