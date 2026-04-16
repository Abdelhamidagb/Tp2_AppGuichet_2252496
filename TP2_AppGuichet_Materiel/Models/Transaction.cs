using System;

namespace AppGuichet
{
    public class Transaction
    {
        //attribue

        private SorteTransactions m_sorteTransaction;
        private DateTime m_date;
        private string m_numClient;
        private int m_montant;

        // Propriétés 
        public SorteTransactions SorteTransaction { get { return m_sorteTransaction; } }
        public DateTime Date { get { return m_date; } }
        public string NumClient { get { return m_numClient; } }
        public int Montant { get { return m_montant; } }

        //Constructeur

        public Transaction(SorteTransactions pSorte, string pNumClient, DateTime pDate, int pMontant)
        {
            m_sorteTransaction = pSorte;

            
            if (pNumClient == null)
                throw new ArgumentNullException();

            if (pNumClient.Length != 6 || !int.TryParse(pNumClient, out _))
                throw new ArgumentException();

            m_numClient = pNumClient;

           
            if (pMontant <= 0)
                throw new ArgumentOutOfRangeException();

            m_montant = pMontant;

            m_date = pDate;
        }

        public string ToCsv()
        {
            return $"{(int)m_sorteTransaction},{m_numClient},{m_date:yyyy-MM-dd HH:mm:ss},{m_montant}";
        }
    }
}