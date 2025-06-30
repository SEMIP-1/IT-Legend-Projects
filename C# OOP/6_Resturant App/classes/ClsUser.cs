using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_App.Classes
{
    public class ClsUser: ClsReposotry<t>
    {
        #region Class Properites
        public int UserID {get;set;}
        public string UserName {get;set;} = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password {get;set;} = string.Empty;
        public string Phone {get;set;} = string.Empty;
        public string CityName {get;set;} = string.Empty;
        public double Location {get;set;}
        #endregion

        #region Constructor
        public ClsUser() { }
        public ClsUser(string _UserName, string _Email, string _Phone) 
        {
            this.UserName = _UserName;
            this.Email = _Email;
            this.Phone = _Phone;
        }
        #endregion

        #region Methods
        public void Login(){}
        public virtual void ShowOrders(){}
        public virtual void DisplayInfo(){}
        #endregion
       
        #region Interface
        public void Add<t>()
        {
            throw new NotImplementedException();
        }

        public void Delete<t>()
        {
            throw new NotImplementedException();
        }

        public void Edit<t>()
        {
            throw new NotImplementedException();
        }

        public void GetAll<t>()
        {
            throw new NotImplementedException();
        }
        #endregion
    
    }
}