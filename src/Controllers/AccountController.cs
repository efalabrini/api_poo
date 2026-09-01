using Microsoft.AspNetCore.Mvc;
namespace api_poo.Controllers;
using api_poo.Entities;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{

    [HttpGet]
    public string Get()
    {
        var account = new BankAccount("Emiliano", 1000);
        account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
        account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
        return $"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.";
    }
}
