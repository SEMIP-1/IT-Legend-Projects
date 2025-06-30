using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_App.Classes
{
    public class ClsClient : ClsUser
    {
        #region Properites
        public int FlatNo {get;set;}
        public int FloorNo {get;set;}
        public string SecondPhone {get;set;} = string.Empty;
        public double DeliverLocation {get;set;}
        #endregion

        #region Constructor
        public ClsClient(int _FlatNo, int _FloorNo,string _SecondPhone, double _DeliverLocation) 
        {
            this.FlatNo = _FlatNo;
            this.FloorNo = _FloorNo;
            this.SecondPhone = _SecondPhone;
            this.DeliverLocation = _DeliverLocation;
        }
        #endregion

        #region Methods
        public void SendOrder(){}
        public void ReceiveOrder(){}
        public override void ShowOrders(){}
        public override void DisplayInfo(){}
        #endregion
       
        
    }
}