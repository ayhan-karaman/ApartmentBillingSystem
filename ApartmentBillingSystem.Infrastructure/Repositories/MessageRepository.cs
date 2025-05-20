

using ApartmentBillingSystem.Domain.Entities;
using ApartmentBillingSystem.Infrastructure.Contexts;
using ApartmentBillingSystem.Infrastructure.Repositories.Interfaces;

namespace ApartmentBillingSystem.Infrastructure.Repositories
{
    public class MessageRepository : GenericRepository<Message>, IMessageRepository
    {
        public MessageRepository(AppDbContext context) : base(context)
        {
        }
    }

}