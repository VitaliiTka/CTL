using CTL;

internal class Program
{
    private static void Main(string[] args)
    {
        var cardVitalii = new AccessCard("Vitalii");
        cardVitalii.Activate();
        var cardVlad = new AccessCard("Vlad");
        var door = new Door("Manager room");
        door.Open(cardVitalii);
        door.Open(cardVlad);
    }
}