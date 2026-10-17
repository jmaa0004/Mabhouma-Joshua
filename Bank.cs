using System;
using System.Collections.Generic;

namespace Namespace_ExercicePerson;

public class Bank
{
    public required string Name { get; set; }

    // Dictionnaire en lecture seule (Étape 3) adapté pour tous les comptes (Étape 8)
    public Dictionary<string, Account> Accounts { get; } = new Dictionary<string, Account>(); // J'ai modifié CurrentAccount -> Account selon les consignes


    public void AddAccount(Account account)
    {
        if (!Accounts.ContainsKey(account.Number))
        {
            Accounts.Add(account.Number, account);
        }
        else
        {
            Console.WriteLine($"Le compte {account.Number} existe déjà.");
        }
    }

    // Supprimer un compte (Étape 3)
    public void DeleteAccount(string number)
    {
        if (Accounts.ContainsKey(number))
        {
            Accounts.Remove(number);
        }
        else
        {
            Console.WriteLine($"Le compte {number} est introuvable.");
        }
    }

    // Étape 4 : Retourner le solde d'un compte via son numéro
    public double GetAccountBalance(string number)
    {
        if (Accounts.TryGetValue(number, out Account? account))
        {
            return account.Balance;
        }

        Console.WriteLine($"Le compte {number} est introuvable.");
        return 0;
    }

    // Étape 5 : Donner la somme de tous les comptes d'une personne
    public double GetTotalBalance(Person Owner)
    {
        double total = 0;

        foreach (Account account in Accounts.Values)
        {
            if (account.Owner == Owner)
            {
                total += account.Balance;
            }
        }

        return total;
    }
}