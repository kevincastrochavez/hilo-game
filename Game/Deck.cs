public class Deck {
    public int card;
    
    public Deck() {
    }

    public int GetRandomNumber() {
        Random random = new Random();
        card = random.Next(0, 14);

        return card;
    }
}