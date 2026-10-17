using System;

namespace Namespace_ExercicePerson;

public abstract class Account
{
    public required string Number { get; set; }
    
    
    public double Balance { get; private set; } // (lecture seule ?)
    
    public required Person Owner { get; set; }


    public virtual void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Le montant du retrait doit être supérieur à 0.");
            return;
        }

        Balance -= amount;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Le montant du dépôt doit être supérieur à 0.");
            return;
        }

        Balance += amount;
    }

    

}