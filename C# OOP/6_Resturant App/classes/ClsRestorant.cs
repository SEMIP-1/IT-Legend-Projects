using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_App.Classes
{
    public class ClsRestorant :ClsUser
    {
        #region Class Properites
        public string Logo {get;set;} = string.Empty;
        public int TaxCard {get;set;}
        public int Telephone {get;set;}
        #endregion
        
        #region Methods
        public void ApproveOrder(){}
        public void DeliverOrder(){}
        public override void ShowOrders(){}
        public override void DisplayInfo(){}
        #endregion
    }
}