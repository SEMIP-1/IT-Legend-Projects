using System;

public class Developer
{
    #region Fields
    //Variables(State)
    string Name = " ";
    int Age;
    string Address = " ";
    string JobTitle = "Software Developer";
    #endregion

    #region Methods
    //Methods(Behavior)
    #region Business Logic
    void Hire()
    {
        Console.WriteLine("Hired");
    }
    void Evaluate()
    {
        Console.WriteLine("Evaluated");
    }
    void Promote()
    {
        Console.WriteLine("Promoted");
    }
    #endregion

    #region Setters and Getters
    public void SetAge(int PresonAge)
    {
        if (PresonAge > 20)
            Age = PresonAge;
    }

    public int GetAge()
    {
        return Age;
    }

    public string GetJobTitle()
    {
        return JobTitle;
    }

    public void SetName(string PersonName)
    {
        if (string.IsNullOrEmpty(PersonName))
        {
            Console.WriteLine("Name is required");
        }
        else if (PersonName.Length < 300)
        {
            Name = PersonName;
        }

    }

    public string GetName()
    {
        return Name;
    }

    public void SetAddress(string PersonAddress)
    {
        Address = PersonAddress;
    }

    public string GetAddress()
    {
        return Address;
    }
    #endregion

    #endregion
}
class Developer1
{
    #region Fields
    //Variables(State)
    string _Name = " ";
    int _Age;
    string _JobTitle = "Software Developer";
    decimal _RatePerHour;
    #endregion

    #region Methods
    //Methods(Behavior)
    #region Business Logic
    void Hire()
    {
        Console.WriteLine("Hired");
    }
    void Evaluate()
    {
        Console.WriteLine("Evaluated");
    }
    void Promote()
    {
        Console.WriteLine("Promoted");
    }
    #endregion

    #region Setters and Getters

    public int Age
    {//Read and write property
        set
        {
            if (value > 20)
                _Age = value;
        }
        get
        {
            return _Age;
        }

    }
    public string Name
    {//Read and write property
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Name is required");
            }
            else if (value.Length < 300)
            {
                _Name = value;
            }
        }

        get
        {
            return _Name;
        }
    }
    public string JobTitle
    {//Read only property
        get
        {
            return _JobTitle;
        }
    }
    public decimal RatePerHour
    {//Write only property
        set
        {
            _RatePerHour = value;
        }
    }
    public string? Address { get; set; }//Auto-implemented property it can be read only OR write and read
    #endregion
    #endregion

}
