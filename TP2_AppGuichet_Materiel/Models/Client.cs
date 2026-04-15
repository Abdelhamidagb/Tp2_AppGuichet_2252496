using AppGuichet;
using System;
using System.Collections.Generic;

public class Client
{
    private string m_numClient;
    private string m_nom;
    private string m_motDePasse;
    private Roles m_role;
    private SorteComptes m_sorteCompte;
    private int m_solde;

    public const int MAX_SOLDE = 1000000;

    public List<Transaction> Transactions { get; set; } = new List<Transaction>();

    public string NumClient
    {
        get { return m_numClient; }
        set
        {
            if (value == null)
                throw new ArgumentNullException();

            if (value.Length != 6 || !int.TryParse(value, out _))
                throw new ArgumentException();

            m_numClient = value;
        }
    }

    public string Nom
    {
        get { return m_nom; }
        set
        {
            if (value == null)
                throw new ArgumentNullException();

            if (value.Length < 3)
                throw new ArgumentOutOfRangeException();

            m_nom = value;
        }
    }

    public string MotDePasse
    {
        get { return m_motDePasse; }
        set { m_motDePasse = value; }
    }

    public Roles Role
    {
        get { return m_role; }
        set { m_role = value; }
    }

    public SorteComptes SorteCompte
    {
        get { return m_sorteCompte; }
        set { m_sorteCompte = value; }
    }

    public int Solde
    {
        get { return m_solde; }
        set
        {
            if (value < 0 || value > MAX_SOLDE)
                throw new InvalidOperationException();

            m_solde = value;
        }
    }

    public bool IsAdmin => m_role == Roles.Administrateur;

    public Client(string pNumClient, string pNom, string pMotDePasse,
        Roles pRole, SorteComptes pSorte, int pSolde)
    {
        NumClient = pNumClient;
        Nom = pNom;
        MotDePasse = pMotDePasse;
        Role = pRole;
        SorteCompte = pSorte;
        Solde = pSolde;
    }

    public Client(string pChaineLue)
    {
        if (pChaineLue == null)
            throw new ArgumentNullException();

        var parts = pChaineLue.Split(',');

        if (parts.Length != 6)
            throw new ArgumentException();

        NumClient = parts[0];
        Nom = parts[1];
        MotDePasse = parts[2];
        Role = (Roles)int.Parse(parts[3]);
        SorteCompte = (SorteComptes)int.Parse(parts[4]);
        Solde = int.Parse(parts[5]);
    }

    public void Deposer(int pMontant)
    {
        if (pMontant <= 0)
            throw new ArgumentOutOfRangeException();

        if (m_solde + pMontant > MAX_SOLDE)
            throw new InvalidOperationException();

        m_solde += pMontant;
    }

    public void Retirer(int pMontant)
    {
        if (pMontant <= 0)
            throw new ArgumentOutOfRangeException();

        if (pMontant > m_solde)
            throw new InvalidOperationException();

        m_solde -= pMontant;
    }

    public bool PeutRetirer(int pMontant)
    {
        return pMontant > 0 && pMontant <= m_solde;
    }

    public void AjouterTransaction(Transaction pTransaction)
    {
        if (pTransaction == null)
            throw new ArgumentNullException();

        if (pTransaction.NumClient != m_numClient)
            throw new InvalidOperationException();

        if (Transactions.Contains(pTransaction))
            throw new InvalidOperationException();

        Transactions.Add(pTransaction);
    }

    public string ToCsv()
    {
        return $"{m_numClient},{m_nom},{m_motDePasse},{(int)m_role},{(int)m_sorteCompte},{m_solde}";
    }
}