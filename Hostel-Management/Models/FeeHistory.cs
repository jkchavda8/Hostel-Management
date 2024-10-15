using System;

namespace Hostel_Management.Models
{
    public class FeeHistory
    {
        public int FeeHistoryID { get; set; }     // Primary key
        public int StudentID { get; set; }        // Foreign key to the Student
        public decimal AmountPaid { get; set; }   // Amount paid by the student
        public DateTime DatePaid { get; set; }    // Date the fee was paid
        public string PaymentMethod { get; set; } // Payment method (e.g., cash, card)

        // Navigation property
        public Student Student { get; set; }
    }
}
