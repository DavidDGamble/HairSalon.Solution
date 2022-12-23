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

    [HttpPost("client/{id}/create")]
    public ActionResult Create(int id, Client client)
    {
      return Redirect($"/stylist/details/{id}");
    }
  }
}