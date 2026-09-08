using Microsoft.AspNetCore.Mvc;
namespace api_poo.Controllers;

using System.Buffers;
using api_poo.Data;
using api_poo.Entities;
using api_poo.Models;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{

    [HttpPost]
    public ActionResult<BankAccountDto> Post([FromBody] PostAccountRequest prPostAccountRequest)
    {

        BankAccount new_bankAccount = new(prPostAccountRequest.Owner,prPostAccountRequest.InitialBalance);

        BankAccountRepository bankAccountRepository = new();
        bankAccountRepository.Add(new_bankAccount);

        return BankAccountDto.Create(new_bankAccount);
        
    }

}
