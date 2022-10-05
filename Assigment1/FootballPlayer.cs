using System.Reflection.Emit;

namespace Assigment1
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }

      
        public void ValidateName()
        {
            if(Name == null) 
                throw new ArgumentNullException(nameof(Name));

            if(Name.Length < 2)
                throw new ArgumentException(nameof(Name));
        }
        
        public void ValidateAge()
        {
            if(Age < 1)
                throw new ArgumentOutOfRangeException(nameof(Age));
        }
        public void ValidateShirtNumber()
        {
            if(ShirtNumber <1)
                throw new ArgumentOutOfRangeException(nameof(ShirtNumber));
            if (ShirtNumber > 99)
                throw new ArgumentOutOfRangeException(nameof(ShirtNumber));
        }
        
    }
}