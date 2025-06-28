using System;

public class Rectangle
{
    double Height = 1;
    double Width = 1;
    public double Area()
    {
        return Height * Width;
    }
    public double Perimeter()
    {
        return 2 * (Height + Width);
    }
}
public class Rectangle1
{
    #region Properties
    double _Height;
    public double Height
    {
        set
        {
            if (value > 0)
                _Height = value;
        }
        get
        {
            return _Height;
        }
    }
    double _Width;
    public double Width
    {
        set
        {
            if (value > 0)
                _Width = value;
        }
        get
        {
            return _Width;
        }
    }
    #endregion

    #region Constructors
    // 9-Parameterized Constructor
    public Rectangle1(double height, double width)
    {
        Height = height;
        Width = width;
    }
    //10-Copy Constructor
    public Rectangle1(Rectangle1 rect)
    {
        Height = rect.Height;
        Width = rect.Width;
    }
    //12-Destructor
    ~Rectangle1()
    {
        Console.WriteLine("Rectangle object is destroyed");
    }
    #endregion

    #region Methods
    public double Area()
    {
        return Height * Width;
    }
    public double Perimeter()
    {
        return 2 * (Height + Width);
    }
    #endregion
}
