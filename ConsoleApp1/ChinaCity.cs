namespace ConsoleApp1
{
    internal class ChinaCity : City.City
    {
        public uint Population 
        { 
            get => _population; 
            set 
            {
                if (value < 100000) return;
                _population = value;
            } 
        }
    }
}
