using System.Reflection.Metadata;
using api_poo.Entities;
using api_poo.Interfaces;
namespace api_poo.Data;

public class BankAccountRepository : IBankAccountRepository
{
    private static List<BankAccount> _accounts = [];

    public BankAccount GetById(int id)
    {
        throw new Exception("Not implemented");
    }

    public List<BankAccount> List()
    {
        throw new Exception("Not implemented");
    }

    public BankAccount Add(BankAccount entity)
    {
        _accounts.Add(entity);
        return entity;
    }

    public void Update(BankAccount entity)
    {
        throw new Exception("Not implemented");
    }

    public void Detele(BankAccount entity)
    {
        throw new Exception("Not implemented");
    }

}