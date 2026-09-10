namespace api_poo.Models;

// Modelo usado únicamente para recibir los datos del cuerpo de una petición POST.
// No es la entidad BankAccount: representa la información que el cliente puede
// enviar para solicitar la creación de una cuenta.
public record PostAccountRequest(string Owner, decimal InitialBalance);

// Fin del record PostAccountRequest.