namespace War
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Battlefield battlefield = new Battlefield();

            battlefield.Fight();

            battlefield.ShowWinner();
        }
    }
}