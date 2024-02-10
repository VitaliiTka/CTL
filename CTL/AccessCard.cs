namespace CTL
{
    public class AccessCard(string ownerName)
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string OwnerName { get; set; } = ownerName;
        public bool Activated { get; set; } = false;

        public void Activate()
        {
            Activated = true;
        }

        public bool IsActivated()
        {
            return Activated;
        }
    }
}
