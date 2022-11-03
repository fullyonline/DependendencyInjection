using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependendencyInjection
{
    internal class User
    {
        private INotificationService notificationService;
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                if (notificationService != null)
                {
                    notificationService.NotifyUsernameChanged(this);
                }
            }
        }
        public User()
        {

        }
        public User(INotificationService service)
        {
            notificationService = service;
        }
    }
}
