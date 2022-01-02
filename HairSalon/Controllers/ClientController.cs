using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {

    [HttpGet("/stylists/{stylistId}/client/new")]
    public ActionResult New(int stylistId)
    {
      Stylist stylist = Stylist.Find(stylistId);
      return View(stylist);
    }

    [HttpPost("/client/delete")]
    public ActionResult DeleteAll()
    {
      Client.ClearAll();
      return View();
    }

    [HttpGet("/stylists/{stylistId}/client/{clientId}")]
    public ActionResult Show(int stylistId, int clientId)
    {
      Client client = Client.Find(clientId);
      Stylist stylist = Stylist.Find(stylistId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("client", client);
      model.Add("stylist", stylist);
      return View(model);
    }
  }
}