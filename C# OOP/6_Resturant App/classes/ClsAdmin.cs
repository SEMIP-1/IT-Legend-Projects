using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_App.Classes
{
    public class ClsAdmin:ClsUser
    {
        #region Class Properites
        public string JobName {get;set;} = string.Empty;
        #endregion
        
        #region Methods
        public void CancelOrder(){}
        public void ContactUser(){}
        public override void ShowOrders(){}
        public override void DisplayInfo(){}
        #endregion
        
    }
}