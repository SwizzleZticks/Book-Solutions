
int number;
do
{
    Console.WriteLine("Enter a integer: ");
}
while (!int.TryParse(Console.ReadLine(), out number));

double number2;
do
{
    Console.WriteLine("Enter a double: ");
}
while (!double.TryParse(Console.ReadLine(),out number2));


bool truthValue;
do
{
    Console.WriteLine("Enter a boolean");
}
while(!bool.TryParse(Console.ReadLine(),out  truthValue));