using System;

public class Major
{
    #region Properties
    int _MajorID;
    public int MajorID
    {
        set
        {
            if (value > 0)
                _MajorID = value;
        }
        get
        {
            return _MajorID;
        }
    }
    string? _MajorName;
    public string? MajorName
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Major Name is required");
            }
            else if (value.Length < 300)
            {
                _MajorName = value;
            }
        }
        get
        {
            return _MajorName;
        }
    }
    string? _DoctorName;
    public string? DrName
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Doctor Name is required");
            }
            else if (value.Length < 300)
            {
                _DoctorName = value;
            }
        }
        get
        {
            return _DoctorName;
        }
    }
    #endregion
    #region Constructors
    public Major(string MajorName, string DrName)
    {
        this._MajorName = MajorName;
        this._DoctorName = DrName;
    }
    public Major(Major CopyMajor)
    {
        _MajorName = CopyMajor.MajorName;
        _DoctorName = CopyMajor.DrName;
    }
    #endregion
}
