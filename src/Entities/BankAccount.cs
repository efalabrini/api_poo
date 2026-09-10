namespace api_poo.Entities;

// La entidad representa una cuenta bancaria y contiene las reglas de negocio
// relacionadas con depósitos, retiros y cálculo del saldo.
public class BankAccount
{
   
    public string Number { get; }

    
    public string Owner { get; set; }

    // El saldo se calcula a partir de todas las transacciones, en lugar de
    // almacenarse en una variable independiente que podría quedar desactualizada.
    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var item in _allTransactions)
            {
                balance += item.Amount;
            }

            return balance;
        }
    }


    private static int s_accountNumberSeed = 1234567890;


    private List<Transaction> _allTransactions = new List<Transaction>();


    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
        }
        var deposit = new Transaction(amount, date, note);
        _allTransactions.Add(deposit);
    }

   
    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
        }
        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        }
        var withdrawal = new Transaction(-amount, date, note);
        _allTransactions.Add(withdrawal);
    }

    // Este es el constructor de la clase. Se ejecuta al crear una cuenta con new.
    // Recibe los datos mínimos necesarios y deja el objeto en un estado válido.
    public BankAccount(string name, decimal initialBalance)
    {
        Owner = name;
        MakeDeposit(initialBalance, DateTime.Now, "Initial balance");

        Number = s_accountNumberSeed.ToString();
        s_accountNumberSeed++;
    }

    // virtual permite que tipos de cuenta derivados redefinan esta operación.
    public virtual void PerformMonthEndTransactions() {}

    // Construye un informe de texto recorriendo las transacciones en orden.
    public string GetAccountHistory()
    {
        var report = new System.Text.StringBuilder();

        decimal balance = 0;
        report.AppendLine("Date\t\tAmount\tBalance\tNote");
        foreach (var item in _allTransactions)
        {
            balance += item.Amount;
            report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
        }

        return report.ToString();
    }

    // Fin de la clase BankAccount.
}