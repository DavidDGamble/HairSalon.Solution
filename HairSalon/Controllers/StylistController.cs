using Microsoft.EntityFrameworkCore;
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

    public ActionResult Create()
    {
      return View();
    }

    public ActionResult Details(int id)
    {
      Stylist thisStylist = _db.Stylists
        .Include(stylist => stylist.Clients)
        .FirstOrDefault(stylist => stylist.StylistId == id);
// vvvvv----- Check to see if code can be refactored -----vvvvv      
      List<Client> dbClients = _db.Clients.ToList();
      thisStylist.Clients = new List<Client> { };
      foreach (Client client in dbClients)
      {
        if (client.StylistId == thisStylist.StylistId)
        {
          thisStylist.Clients.Add(client);
        }
      }
      return View(thisStylist);
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}