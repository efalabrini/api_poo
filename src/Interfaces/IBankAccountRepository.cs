using api_poo.Entities;

namespace api_poo.Interfaces;

public interface IBankAccountRepository
{
    BankAccount GetById(int id);
    List<BankAccount> List();
    BankAccount Add(BankAccount entity);
    void Update(BankAccount entity);
    void Delete(BankAccount entity);
}