using System.Collections.Generic;

namespace SSE550.ElectronicInventory
{
    class Electronics
    {
        decimal price;
        int power_consumption;
        float 
            weight, 
            screen_size;
        string            
            brand,
            model,
            condition;
        List<string> features = new List<string>();
        List<string> inputs = new List<string>();
        List<string> outputs = new List<string>();
            
            

        public decimal Price
        {
            get
            { return price; }
            set
            { price = value; }
        }
        public int Power_consumption
        {
            get
            { return power_consumption; }
            set
            { power_consumption = value; }
        }

        public float Weight
        {
            get
            { return weight; }
            set
            { weight = value; }
        }

        public float Screen_size
        {
            get
            { return screen_size; }
            set
            { screen_size = value; }
        }

        public string Brand
        {
            get
            { return brand; }
            set
            { brand = value; }
        }

        public string Model
        {
            get
            { return model; }
            set
            { model = value; }
        }

        public string Condition
        {
            get
            { return condition; }
            set
            { condition = value; }
        }

        public void addFeature(string feature)
        {
            features.Add(feature);
        }

        public bool findFeature(string feature)
        {
            if (features.Contains(feature))
                return true;
            else
                return false;            
        }

        public void addInput(string input)
        {
            inputs.Add(input);
        }

        public bool findInput(string input)
        {
            if (inputs.Contains(input))
                return true;
            else
                return false;
        }

        public void addOutput(string output)
        {
            outputs.Add(output);
        }

        public bool findOutput(string output)
        {
            if (outputs.Contains(output))
                return true;
            else
                return false;
        }
        

    }
}
