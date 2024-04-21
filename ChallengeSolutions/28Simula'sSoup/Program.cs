//Make a tuple variable to represent a soup composed of the three above enumeration types.

(FoodType type, MainIngredient mainIngredient, FoodSeasoning seasoning) userMeal = GetSoup();

Console.WriteLine($"{userMeal.seasoning} {userMeal.mainIngredient} {userMeal.type}");


// Methods
(FoodType,MainIngredient,FoodSeasoning) GetSoup()
{
    FoodType type = GetSoupType();
    MainIngredient mainIngredient = GetMainIngredient();
    FoodSeasoning seasoning = GetSeasoning();

    return (type, mainIngredient, seasoning);   
}


FoodType GetSoupType ()
{
    Console.Write("What food type would you like(soup,stew,gumbo): ");
    string userInput = Console.ReadLine();

     return userInput switch
    {
        "soup"  => FoodType.soup,
        "stew"  => FoodType.stew,
        "gumbo" => FoodType.gumbo
    };
}

MainIngredient GetMainIngredient()
{
    Console.Write("What main ingredient would you like(mushrooms,chicken,carrots,potatoes): ");
    string userInput = Console.ReadLine();

    return userInput switch
    {
        "mushrooms" => MainIngredient.mushrooms,
        "chicken" => MainIngredient.chicken,
        "carrots" => MainIngredient.carrots,
        "potatoes" => MainIngredient.potatoes
    };
}

FoodSeasoning GetSeasoning()
{
    Console.Write("What seasoning would you like(spicy, salty, sweet): ");
    string userInput = Console.ReadLine();

    return userInput switch
    {
        "spicy" => FoodSeasoning.spicy,
        "salty" => FoodSeasoning.salty,
        "sweet" => FoodSeasoning.sweet
    };
}
//Define enumerations for the three variations on food: type (soup, stew, gumbo), main ingredient 
//(mushrooms, chicken, carrots, potatoes), and seasoning(spicy, salty, sweet).
enum FoodType
{
    soup,
    stew,
    gumbo
}

enum MainIngredient
{
    mushrooms,
    chicken,
    carrots,
    potatoes
}

enum FoodSeasoning
{
    spicy,
    salty,
    sweet
}