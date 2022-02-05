using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class PaymentContext : DbContext
    {
        public PaymentContext(DbContextOptions<PaymentContext> options) : base(options)
        {

        }

        public DbSet<Payment>? Payments { get; set; }

    }
}