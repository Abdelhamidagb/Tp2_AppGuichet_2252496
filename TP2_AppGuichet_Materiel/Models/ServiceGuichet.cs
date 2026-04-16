using AppGuichet;
using System;
using System.Collections.Generic;
using System.IO;

public class ServiceGuichet
{
    //Attribue

    private string m_cheminFichierClients;
    private string m_cheminFichierTransactions;
    private List<Client> m_clients;
    private List<Transaction> m_transactions;


    //Propriétés 

    public List<Client> Clients
    {
        get { return m_clients; }
    }

    public List<Transaction> Transactions
    {
        get { return m_transactions; }
    }

    public Client ClientCourant { get; private set; }

    //Propriétés 


    public ServiceGuichet(string pCheminFichierClients, string pCheminFichierTransactions)
    {
        if (!File.Exists(pCheminFichierClients))
            throw new ArgumentException();

        if (!File.Exists(pCheminFichierTransactions))
            throw new ArgumentException();

        m_cheminFichierClients = pCheminFichierClients;
        m_cheminFichierTransactions = pCheminFichierTransactions;

        m_clients = new List<Client>();
        m_transactions = new List<Transaction>();
    }

    public int ChargerClients()
    {
        int erreurs = 0;

        foreach (string ligne in File.ReadAllLines(m_cheminFichierClients))
        {
            try
            {
                Client c = new Client(ligne);
                m_clients.Add(c);
            }
            catch
            {
                erreurs++;
            }
        }

        return erreurs;
    }

    public int ChargerTransactions()
    {
        int erreurs = 0;

        foreach (string ligne in File.ReadAllLines(m_cheminFichierTransactions))
        {
            try
            {
                string[] parts = ligne.Split(',');

                SorteTransactions sorte = (SorteTransactions)int.Parse(parts[0]);
                string numClient = parts[1];
                DateTime date = DateTime.Parse(parts[2]);
                int montant = int.Parse(parts[3]);

                CreerTransaction(sorte, numClient, date, montant);
            }
            catch
            {
                erreurs++;
            }
        }

        return erreurs;
    }

    public void CreerTransaction(SorteTransactions pSorte, string pNumClient, DateTime pDate, int pMontant)
    {
        Client client = TrouverClient(pNumClient);

        if (client == null)
            throw new ArgumentException();

        Transaction t = new Transaction(pSorte, pNumClient, pDate, pMontant);

        if (pSorte == SorteTransactions.Dépôt)
            client.Deposer(pMontant);
        else
            client.Retirer(pMontant);

        client.AjouterTransaction(t);
        m_transactions.Add(t);
    }

    public bool Sauvegarde()
    {
        SauvegarderClients(m_cheminFichierClients);
        SauvegarderTransactions(m_cheminFichierTransactions);
        return true;
    }

    public void SauvegarderTransactions(string pFichier)
    {
        using (StreamWriter sw = new StreamWriter(pFichier))
        {
            foreach (Transaction t in m_transactions)
            {
                sw.WriteLine(t.ToCsv());
            }
        }
    }

    public void SauvegarderClients(string pFichier)
    {
        using (StreamWriter sw = new StreamWriter(pFichier))
        {
            foreach (Client c in m_clients)
            {
                sw.WriteLine(c.ToCsv());
            }
        }
    }

    public bool Connexion(string numClient, string motDePasse)
    {
        Client client = TrouverClient(numClient);

        if (client == null)
            return false;

        if (client.MotDePasse == motDePasse)
        {
            ClientCourant = client;
            return true;
        }

        return false;
    }

    public bool Deconnexion()
    {
        ClientCourant = null;
        return true;
    }

    public Client TrouverClient(string pNumClient)
    {
        foreach (Client c in m_clients)
        {
            if (c.NumClient == pNumClient)
                return c;
        }

        return null;
    }
}