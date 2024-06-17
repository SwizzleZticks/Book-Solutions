
namespace _48FountainofObjects
{
    public class Player
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public ICommand? Command { get; set; }

        public void Move()
        {
            Command?.ICommand(this);
        }
        public void Interact()
        {
            Command?.Interact();//gonna have to use a method to get that cells state of object
        }
    }
}