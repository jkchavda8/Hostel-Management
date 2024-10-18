using System.Collections.Generic;
using System.Linq;
using Hostel_Management.Models;  // Assuming this is where your DbContext is located

namespace Hostel_Management.Repositories
{
    public class FeeHistoryRepository : IFeeHistory
    {
        private readonly HostelContext _context;  // DbContext for the application

        public FeeHistoryRepository(HostelContext context)
        {
            _context = context;
        }

        public IEnumerable<FeeHistory> GetAllFeeHistories()
        {
            return _context.FeeHistories.ToList();  // Retrieve all fee history records
        }

        public FeeHistory GetFeeHistoryById(int id)
        {
            return _context.FeeHistories.Find(id);  // Retrieve a fee history by ID
        }

        public void AddFeeHistory(FeeHistory feeHistory)
        {
            _context.FeeHistories.Add(feeHistory);  // Add a new fee history record
            _context.SaveChanges();                 // Save the changes to the database
        }

        public void UpdateFeeHistory(FeeHistory feeHistory)
        {
            _context.FeeHistories.Update(feeHistory);  // Update an existing fee history record
            _context.SaveChanges();                    // Save the changes to the database
        }

        public void DeleteFeeHistory(int id)
        {
            var feeHistory = _context.FeeHistories.Find(id);  // Find the fee history by ID
            if (feeHistory != null)
            {
                _context.FeeHistories.Remove(feeHistory);  // Delete the fee history record
                _context.SaveChanges();                    // Save the changes to the database
            }
        }

    }
}
