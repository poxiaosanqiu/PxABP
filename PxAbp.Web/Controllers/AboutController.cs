using System.Web.Mvc;

namespace PxAbp.Web.Controllers
{
    public class AboutController : PxAbpControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}