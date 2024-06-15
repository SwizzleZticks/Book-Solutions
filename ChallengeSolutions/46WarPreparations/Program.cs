namespace _46WarPreparations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sword basicSword = new Sword(SwordMaterial.Iron, GemStone.None, 35, 10);

            Sword basicSword2 = basicSword with { Material = SwordMaterial.Wood, Stone = GemStone.Emerald };
            Sword basicSword3 = basicSword with { Material = SwordMaterial.Binarium, Stone = GemStone.BitStone };

            Console.WriteLine(basicSword);
            Console.WriteLine(basicSword2);
            Console.WriteLine(basicSword3);
        }
    }
    public record Sword //can define all the props in parens here and not use constructor
    {
        public SwordMaterial Material { get; set; }
        public GemStone Stone { get; set; }
        public int SwordLength { get; set; }
        public int HiltWidth { get; set; }

        public Sword(SwordMaterial material, GemStone stone, int swordLength, int hiltWidth) 
        {
            Material = material;
            Stone = stone;
            SwordLength = swordLength;
            HiltWidth = hiltWidth;
        }
    }
}
public enum SwordMaterial
{
    Wood,
    Bronze,
    Iron,
    Steel,
    Binarium
}
public enum GemStone
{
    None,
    Emerald,
    Amber,
    Sapphire,
    Diamond,
    BitStone
}
