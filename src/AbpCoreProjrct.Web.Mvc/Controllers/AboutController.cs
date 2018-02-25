using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AbpCoreProjrct.Controllers;

namespace AbpCoreProjrct.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : AbpCoreProjrctControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
