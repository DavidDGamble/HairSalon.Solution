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

    [HttpGet("/stylist/{id}/edit")]
    public ActionResult Edit(int id)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }

    [HttpGet("/stylist/{id}/delete")]
    public ActionResult Delete(int id)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost("/stylist/{id}/delete/confirm")]
    public ActionResult DeleteConfirm(int id)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      List<Client> stylistClients = _db.Clients.ToList();
      foreach (Client client in stylistClients)
      {
        if (client.StylistId == id)
        {
          _db.Clients.Remove(client);
        }
      }
      _db.Stylists.Remove(thisStylist);
      _db.SaveChanges();
      return Redirect("/stylist");
    }

    [HttpPost("/stylist/{id}/edit")]
    public ActionResult EditConfirm(int id, Stylist stylist)
    {
      stylist.StylistId = id;
      _db.Stylists.Update(stylist);
      _db.SaveChanges();
      return Redirect($"/stylist/details/{id}");
    }
  }
}