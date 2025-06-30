namespace StructExample
{
    // Using Class
    internal class IPAddress1
    {
        #region Properties
        public int Part1 { get; set; }
        public int Part2 { get; set; }
        public int Part3 { get; set; }
        public int Part4 { get; set; }
        #endregion

        #region Constructors
        public IPAddress1(int part1, int part2, int part3, int part4)
        {
            Part1 = part1;
            Part2 = part2;
            Part3 = part3;
            Part4 = part4;
        }
        #endregion

        #region Indexers
        // Indexers allow you to use an object like an array
        public int this[int index]
        {
            set
            {
                switch (index)
                {
                    case 0:
                        Part1 = value;
                        break;
                    case 1:
                        Part2 = value;
                        break;
                    case 2:
                        Part3 = value;
                        break;
                    case 3:
                        Part4 = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException("Invalid index");
                }
            }
            get
            {
                switch (index)
                {
                    case 0:
                        return Part1;
                    case 1:
                        return Part2;
                    case 2:
                        return Part3;
                    case 3:
                        return Part4;
                    default:
                        return 0;
                }
            }
        }  
        public string this[bool isFullIP]
        {
            get
            {
                if (isFullIP)
                {
                    return $"{Part1}.{Part2}.{Part3}.{Part4}";
                }
                else
                {
                    return $"{Part1}.{Part2}";
                }
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Part1}.{Part2}.{Part3}.{Part4}";
        }
        #endregion
    }

}