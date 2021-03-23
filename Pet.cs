namespace Animals
{
    public abstract class Pet
    {
        public string Name { get; }

        public Pet(string name)
        {
            Name = name;
        }
    }
}