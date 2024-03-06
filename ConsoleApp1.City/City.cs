namespace ConsoleApp1.City
{
    public class City
    {
        protected string _name;
        protected uint _population;
        public uint Population { 
            get => _population; 
            set 
            {
                if (value < 0) return;
                _population = value;
            } 
        }

        public string Name 
        { 
            get => _name; 
            set 
            {
                if (value.Length < 3 || value.Length > 20 || !ContainsLetter(value)) return;
                _name = value;
            } 
        }

        private bool ContainsLetter(string input)
        {
            foreach (char c in input)
            {
                if (char.IsLetter(c)) return true;
            }
            return false;
        }

    }
}
