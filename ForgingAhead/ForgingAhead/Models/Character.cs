namespace ForgingAhead.Models
{
    public class Character : Person
    {

        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsNotActive { get { retur !IsActive; } }
        public int Level { get; set; }
        public int StrengthOrForce { get; set; }
        public int Dexteriry { get; set; }
        public int Intelligence { get; set; }

    }
}
