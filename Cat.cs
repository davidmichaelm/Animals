namespace Animals
{
    public class Cat : Pet, ITalkable
    {
        public int MousesKilled { get; private set; }

        public Cat(int mousesKilled, string name) : base(name)
        {
            MousesKilled = mousesKilled;
        }

        public void AddMouse()
        {
            MousesKilled++;
        }

        public string Talk()
        {
            return "Meow";
        }

        public override string ToString()
        {
            return $"Cat: name = {Name} mousesKilled = {MousesKilled}";
        }
    }
}