using Skill_CodeFirstEntity.Models.siniflar;
using System.Web.Mvc;
namespace Skill_CodeFirstEntity.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            CONTEXT c = new CONTEXT();
            var degerler = c.YETENEKLERs.ToString();
            return View (degerler);
        }
    }
}