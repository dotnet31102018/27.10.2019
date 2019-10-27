using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebWithFofmrs.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form()
        {
            return new FilePathResult("~/Views/Page/index.html", "text/html");
        }

        
        public ActionResult Here()
        {
            var x = Request.Form;
            /*
                 <p>
      <br>
      <div class="tooltip">ID
        <span class="tooltiptext">Your ID please ...</span>
      </div> <input name="idtxt" type="number" tooltip="id number" required />
    </p>
    <p>NAME <input name="nametxt" type="text" placeholder="YOUR NAME" required /></p>
    <p>EMAIL <input name="emailtxt" type="email" required /></p>
    <p>PASSWORD <input name="pwd" type="password" /></p>
    <p>BIRTH DATE <input name="bdate" type="date"></p>
    <p>
      GENDER: <br>
      <input type="radio" name="gender" value="male"> Male<br>
      <input type="radio" name="gender" value="female"> Female<br>
      <input type="radio" name="gender" value="other"> Other<br>
      <br>Country: <select name="country">
        <option value="Israel">Israel</option>
        <option value="USA">USA</option>
        <option value="Canada">Canada</option>
        <option value="France">France</option>
      </select><br><br>
      <input type="checkbox" name="vegetarian" value="veggy">Vegetarian?<br>
      */
            if (Request.Form["idtxt"] == "0")
                return new FilePathResult("~/Views/Page/index.html", "text/html");
            else
                return Content($"<hr><br><br>Hello {Request.Form["nametxt"]} id {Request.Form["idtxt"]}<br>" +
                    $"email: {Request.Form["emailtxt"]} password: {Request.Form["pwd"]} " +
                    $"bdate: {Request.Form["bdate"]} GENDER: {Request.Form["gender"]} " +
                    $"country: {Request.Form["country"]}");

        }
    }
}