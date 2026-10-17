using System;
using System.Globalization;
using Namespace_ExercicePerson;

class CurrentAccount
{
    public string Number {get; set;}
    public double Balance {get; private set;}

    public double CreditLine {get; set;}
 
    public Namespace_ExercicePerson.Person Owner {get; set;}

    protected void Withdraw( double amount) {Balance -= amount;}
        
    protected void Deposit( double amount) {Balance += amount;}

}
