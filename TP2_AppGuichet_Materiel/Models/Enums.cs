namespace AppGuichet
{
    /// <summary>
    /// Énumérations utilisées dans l'application du guichet bancaire
    /// </summary>
    public enum SorteTransactions
    {
        Dépôt,
        Retrait
    }

    public enum Roles
    {
        Administrateur,
        Client 
    }

    public enum SorteComptes
    {
        Aucun ,
        Épargne,
        Chèque,
        Intérêt 
    }

    public enum FiltreOperation
    {
        Toutes ,
        Dépôt ,
        Retrait
    }
}