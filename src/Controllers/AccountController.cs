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
        var lineOfCredit = new LineOfCreditAccount("line of credit", 100);
        // How much is too much to borrow?
        lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
        lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
        lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
        lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
        lineOfCredit.PerformMonthEndTransactions();
        return lineOfCredit.GetAccountHistory();

    }
}
