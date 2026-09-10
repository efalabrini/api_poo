using Microsoft.AspNetCore.Mvc;
using api_poo.Interfaces;
using System.Buffers;
using api_poo.Data;
using api_poo.Entities;
using api_poo.Models;
using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;

namespace api_poo.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{
    private IBankAccountRepository _bankAccountRepository;

    public AccountController(IBankAccountRepository bankAccountRepository)
    {
        _bankAccountRepository = bankAccountRepository;
    }

    [HttpPost]
    public ActionResult<BankAccountDto> Post([FromBody] PostAccountRequest prPostAccountRequest)
    {

        BankAccount new_bankAccount = new(prPostAccountRequest.Owner,prPostAccountRequest.InitialBalance);

        _bankAccountRepository.Add(new_bankAccount);

        return BankAccountDto.Create(new_bankAccount);
        
    }

    [HttpGet]
    public ActionResult<List<BankAccountDto>> Get()
    {
        var list = _bankAccountRepository.List();
        List<BankAccountDto> res = new();
        foreach (BankAccount acc in list)
        {
            res.Add(BankAccountDto.Create(acc));
        }
        return Ok(res);
    }
    public ActionResult<BankAccountDto> GetById([FromBody]int id)
    {
        BankAccount foundAccount = _bankAccountRepository.GetById(id);
        return Ok(BankAccountDto.Create(foundAccount));
    }
    [HttpPatch]
    public ActionResult<bool> Update([FromBody] BankAccount bankAccount)
    {
        _bankAccountRepository.Update(bankAccount);
        return Ok(true);
    }
    [HttpDelete]
    public ActionResult<bool> Delete([FromBody] BankAccount bankAccount)
    {
        _bankAccountRepository.Delete(bankAccount);
        return Ok(true);
    }
}
