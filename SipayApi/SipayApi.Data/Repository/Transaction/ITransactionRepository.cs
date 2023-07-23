using SipayApi.Data.Domain;

namespace SipayApi.Data.Repository;

public interface ITransactionRepository : IGenericRepository<Transaction>
{
    // Required properties for GetByParameter
    List<Transaction> GetByParameter(int accountNumber, string? referenceNumber, decimal? minAmountCredit, decimal? maxAmountCredit, decimal? minAmountDebit, decimal? maxAmountDebit, string? description, DateTime? beginDate, DateTime? endDate);
    List<Transaction> GetByReference(string reference);
}
