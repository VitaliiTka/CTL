namespace CTL
{
    public class Door(string title)
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = title;

        public bool Open(AccessCard card)
        {
            if (card == null) return false;
            if (!card.IsActivated() || !DateTime.Now.IsWorkTime()) return false;

            Console.WriteLine($"Door: ({Title}, {Id}) is opened by ({card.OwnerName}, {card.Id})");
            return true;
        }
    }
}
