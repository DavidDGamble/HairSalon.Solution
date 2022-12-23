using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class ClientController : Controller 
  {
    private readonly HairSalonContext _db;

    public ClientController(HairSalonContext db)
    {
      _db = db;
    }

    [HttpGet("/client/{id}/delete")]
    public ActionResult Delete(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }

    [HttpPost("client/{id}/create")]
    public ActionResult Create(int id, Client client)
    {
      client.StylistId = id;
      _db.Clients.Add(client);
      _db.SaveChanges();
      return Redirect($"/stylist/details/{id}");
    }

    [HttpPost("/client/{id}/delete/confirm")]
    public ActionResult DeleteConfirm(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      _db.Clients.Remove(thisClient);
      _db.SaveChanges();
      return Redirect($"/stylist/details/{thisClient.StylistId}");
    }
  }
}