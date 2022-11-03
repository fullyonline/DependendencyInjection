using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependendencyInjection
{
    internal interface INotificationService
    {
        public void NotifyUsernameChanged(User user);
    }
}
