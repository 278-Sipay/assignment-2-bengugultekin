using SipayApi.Data.Domain;

namespace SipayApi.Data.Repository;

public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
{
    private readonly SimDbContext dbContext;
    public TransactionRepository(SimDbContext dbContext) : base(dbContext)
    {
        this.dbContext = dbContext;
    }

    // GetByParameter Implementation
    public List<Transaction> GetByParameter(int accountNumber, string? referenceNumber, decimal? minAmountCredit, decimal? maxAmountCredit, decimal? minAmountDebit, decimal? maxAmountDebit, string? description, DateTime? beginDate, DateTime? endDate)
    {
        var query = dbContext.Transactions.AsQueryable();

        if (!string.IsNullOrEmpty(accountNumber.ToString()))
            query = query.Where(x => x.AccountNumber == accountNumber);

        if (!string.IsNullOrEmpty(referenceNumber))
            query = query.Where(x => x.ReferenceNumber == referenceNumber);

        if (minAmountCredit.HasValue)
            query = query.Where(x => x.CreditAmount >= minAmountCredit.Value);

        if (maxAmountCredit.HasValue)
            query = query.Where(x => x.CreditAmount <= maxAmountCredit.Value);

        if (minAmountDebit.HasValue)
            query = query.Where(x => x.DebitAmount >= minAmountDebit.Value);

        if (maxAmountDebit.HasValue)
            query = query.Where(x => x.DebitAmount <= maxAmountDebit.Value);

        if (!string.IsNullOrEmpty(description))
            query = query.Where(x => x.Description.Contains(description) || t.Description == null);

        if (beginDate.HasValue)
            query = query.Where(x => x.TransactionDate >= beginDate.Value);

        if (endDate.HasValue)
            query = query.Where(x => x.TransactionDate <= endDate.Value);

        return query.ToList();
    }

    public List<Transaction> GetByReference(string reference)
    {
        return dbContext.Set<Transaction>().Where(x => x.ReferenceNumber == reference).ToList();
    }

}
