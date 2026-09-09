
using api_poo.Entities;
namespace api_poo.Interfaces;
public interface IBankAccountRepository
{
    public BankAccount GetById(int id);

    public List<BankAccount> List();

    public BankAccount Add(BankAccount entity);

    public void Update(BankAccount entity);

    public void Detele(BankAccount entity);
}