using System.Reflection.Metadata;
using api_poo.Interfaces;
using api_poo.Entities;
using System;

namespace api_poo.Data;

public class BankAccountRepository : IBankAccountRepository
{
    private static List<BankAccount> _accounts = [];

    public BankAccount GetById(int id)
    {
        BankAccount returnedBA = _accounts.FirstOrDefault(ba => ba.Number == id.ToString()) ?? throw new KeyNotFoundException($"No se encontró una cuenta con el número {id}.");
        return returnedBA;
    }

    public List<BankAccount> List()
    {
        List<BankAccount> accountList = _accounts ?? throw new Exception("No hay cuentas registradas.");
        return accountList;
    }

    public BankAccount Add(BankAccount entity)
    {
        _accounts.Add(entity);
        return entity;
    }

    public void Update(BankAccount entity)
    {
        int accountIndex = _accounts.FindIndex(acc => acc.Number == entity.Number);
        _accounts[accountIndex] = accountIndex == -1 
            ? throw new KeyNotFoundException($"No se encontró una cuenta con el número {entity.Number}.") 
            : entity;
    }

    public void Delete(BankAccount entity)
    {
        int accountIndex = _accounts.FindIndex(acc => acc.Number == entity.Number);
        if (accountIndex == -1)
        {
            throw new KeyNotFoundException($"No se encontró una cuenta con el número {entity.Number}.");
        }
        else
        {
            _accounts.RemoveAt(accountIndex);
        }
    }

}