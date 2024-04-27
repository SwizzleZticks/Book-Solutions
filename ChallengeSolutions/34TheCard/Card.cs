namespace TheCard
{
    public class Card
    {
        public CardColor Color { get; set; }
        public CardRank Rank { get; set; }

        public Card(CardColor color, CardRank rank)
        {
            this.Color = color;
            this.Rank = rank;
        }

        public bool IsCardNumber()
        {
            return this.Rank <= CardRank.Ten;
        }
    }
}
