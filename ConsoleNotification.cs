using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependendencyInjection
{    
    internal class ConsoleNotification : INotificationService
    {
        public void NotifyUsernameChanged(User user)
        {
            Console.WriteLine($"Username Changed to {user.Name}");
        }

    }
}
