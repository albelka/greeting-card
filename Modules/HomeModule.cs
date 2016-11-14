using Nancy;
using FriendLetter.Objects;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      // Get["/"] = _ =>
      // {
      //   LetterVariables myLetterVariables = new LetterVariables();
      //   myLetterVariables.SetRecipient("Eric");
      //   myLetterVariables.SetSender("John");
      //   return View["letter.cshtml", myLetterVariables];
      // };
      Get["/"] = _ =>
      {
        return View["form.cshtml"];
      };
      Get["/greeting_card"] = _ =>
      {
        LetterVariables myLetterVariables = new LetterVariables();
        myLetterVariables.SetRecipient(Request.Query["recipient"]);
        myLetterVariables.SetSender(Request.Query["sender"]);
        return View["letter.cshtml", myLetterVariables];
      };

    }
  }
}
