using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketApi.DAL
{
    public class TicketInitializer
    {
        public static void Initialize(TicketContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
