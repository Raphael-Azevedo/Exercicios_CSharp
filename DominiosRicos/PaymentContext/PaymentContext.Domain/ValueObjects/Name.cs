using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract<Name>()
                .Requires()
                .IsNotEmpty(FirstName, "Name.FirstName", "Nome deve conter pelo menos 3 caracteres")
                .IsNotEmpty(LastName, "Name.LastName", "Nome deve conter pelo menos 3 caracteres"));

        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {  
            return $"{FirstName} {LastName}";
        }
    }
}