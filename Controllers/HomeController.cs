using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() {return "Hello Friend!";}

    [Route("/goodbye")]
    public string GoodBye() {return "GoodBye friend.";}

    [Route("/")]
      public ActionResult Letter() {
        LetterVariable myLetterVariable = new LetterVariable();
        myLetterVariable.SetRecipient("Jessica");
        myLetterVariable.SetSender("John");
        return View(myLetterVariable);
      }

      [Route("/form")]
      public ActionResult Form()
      {
        return View();
      }

      [Route("/postcard")]
      public ActionResult Postcard(string recipient, string sender)
      {
        LetterVariable myLetterVariable = new LetterVariable();
        myLetterVariable.SetRecipient(recipient);
        myLetterVariable.SetSender(sender);
        return View(myLetterVariable);
      }

    [Route("/journal")]
    public ActionResult Journal() {return View();}
  }
}
