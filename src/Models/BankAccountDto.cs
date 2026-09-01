using api_poo.Entities;

namespace api_poo.Models;

public record BankAccountDto(string Number, string Owner)
{
public static BankAccountDto Create(BankAccount entity)
    {
        var dto = new BankAccountDto(
                    entity.Number,
                    entity.Owner
                );

        return dto;
    }

}