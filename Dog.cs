namespace Animals
{
    public class Dog : Pet, ITalkable
    {
        public bool Friendly { get; }

        public Dog(bool friendly, string name) : base(name)
        {
            Friendly = friendly;
        }

        public string Talk()
        {
            return "Bark";
        }

        public override string ToString()
        {
            return $"Dog: name = {Name} friendly = {Friendly}";
        }
    }
}