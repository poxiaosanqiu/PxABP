using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace PxAbp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : PxAbpControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}