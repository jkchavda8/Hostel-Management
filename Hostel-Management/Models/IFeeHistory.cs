using System.Collections.Generic;

namespace Hostel_Management.Models
{
    public interface IFeeHistory
    {
        IEnumerable<FeeHistory> GetAllFeeHistories();      // Get all fee history records
        FeeHistory GetFeeHistoryById(int id);              // Get a specific fee history record by ID
        void AddFeeHistory(FeeHistory feeHistory);         // Add a new fee history record
        void UpdateFeeHistory(FeeHistory feeHistory);      // Update an existing fee history record
        void DeleteFeeHistory(int id);

    }
}
