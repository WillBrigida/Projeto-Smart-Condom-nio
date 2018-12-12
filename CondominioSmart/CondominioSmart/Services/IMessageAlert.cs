using System;
using System.Collections.Generic;
using System.Text;

namespace CondominioSmart.Services
{
    public interface IMessageAlert
    {
        void LongAlert(string message);
        void ShortAlert(string message);
    }
}
