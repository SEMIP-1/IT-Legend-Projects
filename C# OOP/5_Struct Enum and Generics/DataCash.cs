namespace CashingServices
{
    public interface ICashing<t>
    {
        public void Add(string key, t value);
        
        public t Get(string key);
        

    }
    //*********************************************
    internal class DataCash<t>: ICashing<t>
    {
        Dictionary<string, t> _Cash;
        public DataCash()
        {
            new Dictionary<string, t>();
        }
        public void Add(string key, t value)
        {
            if(!string.IsNullOrEmpty(key))
            {
                _Cash[key]=value;
            }
        }
        public t Get(string key)
        {
            if(string.IsNullOrEmpty(key) || !_Cash.ContainsKey(key))
            new ArgumentNullException();
            
            return _Cash[key];
        }

    }
//*********************************************
    public class ImageCashing<t> : ICashing<t>
    {
        Dictionary<string, t> _Cash;
        public ImageCashing()
        {
            new Dictionary<string, t>();
        }
        public void Add(string key, t value)
        {
            if(!string.IsNullOrEmpty(key))
            {
                _Cash[key]=value;
            }
        }
        public t Get(string key)
        {
            if(string.IsNullOrEmpty(key) || !_Cash.ContainsKey(key))
            new ArgumentNullException();
            
            return _Cash[key];
        }
    }
}