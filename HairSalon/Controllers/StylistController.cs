using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class StylistController : Controller 
  {
    private readonly HairSalonContext _db;

    public StylistController(HairSalonContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }
  }
}