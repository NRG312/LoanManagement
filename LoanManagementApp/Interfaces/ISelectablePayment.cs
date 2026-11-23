using System;
using System.Collections.Generic;
using System.Text;

namespace LoanManagementApp.Interfaces
{
    internal interface ISelectablePayment
    {
        public void SetSelect(bool select);
        public void UnSubscribeEvents();
        public void RemoveFromLayout();
    }
}
