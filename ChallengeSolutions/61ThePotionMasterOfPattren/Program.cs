using System.Reflection.Metadata.Ecma335;
using static _61ThePotionMasterOfPattren.Enums;

namespace _61ThePotionMasterOfPattren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Potion potion = new Potion();
            while (true)
            {
                Console.WriteLine($"Current potion: {potion.PotionType} Potion");
                Console.WriteLine("-------------------------------------------");
                potion.Ingredients.Add(ChooseIngredient());
                potion.PotionType = GetCurrentPotionType(potion);

                if (potion.PotionType == PotionType.Ruined)
                {
                    Console.WriteLine("You have ruined the potion, please start over...");
                    potion.PotionType = PotionType.Water;
                    potion.Ingredients.Clear();
                }

                Console.WriteLine("Press escape to end, or enter to continue...");
                ConsoleKey keyPress = Console.ReadKey().Key;
                if (keyPress == ConsoleKey.Escape)
                {
                    break;
                }
                else if (keyPress == ConsoleKey.Enter)
                {
                    Console.Clear();
                    continue;
                }

            }
        }

        static IngredientType ChooseIngredient()
        {
            while (true)
            {
                Console.WriteLine("Choose an ingredient to add:");
                Console.WriteLine("1) Snake Venom");
                Console.WriteLine("2) Dragon Breath");
                Console.WriteLine("3) Shadow Glass");
                Console.WriteLine("4) Eyeshine Gem");
                Console.WriteLine("5) Stardust");

                if (int.TryParse(Console.ReadLine(), out int userChoice))
                {
                    switch (userChoice)
                    {
                        case 1: return IngredientType.SnakeVenom;
                        case 2: return IngredientType.DragonBreath;
                        case 3: return IngredientType.ShadowGlass;
                        case 4: return IngredientType.EyeshineGem;
                        case 5: return IngredientType.Stardust;
                    }
                }

                Console.WriteLine("Invalid choice, try again.\n");
            }
        }

        static PotionType GetCurrentPotionType(Potion potion)
        {
            potion.PotionType = potion switch
            {
                { Ingredients: [IngredientType.Stardust] } when potion.PotionType != PotionType.CloudyBrew
                    => PotionType.Elixir,

                { PotionType: PotionType.Elixir, Ingredients: [IngredientType.Stardust, IngredientType.SnakeVenom] }
                    => PotionType.Poison,

                { PotionType: PotionType.Elixir, Ingredients: [IngredientType.Stardust, IngredientType.DragonBreath] }
                    => PotionType.Flying,

                { PotionType: PotionType.Elixir, Ingredients: [IngredientType.Stardust, IngredientType.ShadowGlass] }
                    => PotionType.Invisibility,

                { PotionType: PotionType.Elixir, Ingredients: [IngredientType.Stardust, IngredientType.EyeshineGem] }
                    => PotionType.NightSight,

                { PotionType: PotionType.NightSight,   Ingredients: [IngredientType.Stardust, IngredientType.EyeshineGem, IngredientType.ShadowGlass] }
                    => PotionType.CloudyBrew,

                { PotionType: PotionType.Invisibility, Ingredients: [IngredientType.Stardust, IngredientType.ShadowGlass, IngredientType.EyeshineGem] }
                    => PotionType.CloudyBrew,

                { PotionType: PotionType.CloudyBrew,   Ingredients: [IngredientType.Stardust, IngredientType.ShadowGlass, IngredientType.EyeshineGem, IngredientType.Stardust]}
                    => PotionType.Wraith,

                { PotionType: PotionType.CloudyBrew,   Ingredients: [IngredientType.Stardust, IngredientType.EyeshineGem, IngredientType.ShadowGlass, IngredientType.Stardust]}
                    => PotionType.Wraith,

                _ => PotionType.Ruined

            };

            return potion.PotionType;
        }
    }
}
