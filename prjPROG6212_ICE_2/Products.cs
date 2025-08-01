namespace prjPROG6212_ICE_2
{
    public class Products
    {

        string name, brand;
        int inventory;
        double price;

        public Products(string name, string brand, int inventory, double price) 
        {
            this.name = name;
            this.brand = brand;    
            this.inventory = inventory;
            this.price = price;
        }

        public object this[int index]
        { 
            get
            {
                if (index == 0)
                    return this.name;
                else if (index == 1)
                    return this.brand;
                else if (index == 2)
                    return this.inventory;
                else if (index == 3)
                    return this.price;
                return null;
            }

            set
            {
                if (index == 0)
                    this.name = (string)value;
                else if (index == 1)
                    this.brand = (string)value;
                else if (index == 2)
                    this.inventory = (int)value;
                else if (index == 3)
                    this.price = (double)value;
            }
        }

        public object this[string index]
        {
            get
            {
                if (index.ToLower().Equals("name"))
                    return this.name;
                else if (index.ToLower().Equals("brand"))
                    return this.brand;
                else if (index.ToLower().Equals("inventory"))
                    return this.inventory;
                else if (index.ToLower().Equals("price"))
                    return this.price;
                return null;
            }

            set
            {
                if (index.ToLower().Equals("name"))
                    this.name = (string)value;
                else if (index.ToLower().Equals("brand"))
                    this.brand = (string)value;
                else if (index.ToLower().Equals("inventory"))
                    this.inventory = (int)value;
                else if (index.ToLower().Equals("price"))
                    this.price = (double)value;
            }
        }


    }   
}
