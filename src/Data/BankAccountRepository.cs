using System.Reflection.Metadata;
using api_poo.Entities;
namespace api_poo.Data;

public class BankAccountRepository
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