using System;
    /*
     * Create Player class
     *      - name
     *      - points
     *      - constructor
     *          - name
     *          - points
     *      - Play(Player otherPlayer)
     *          - create instance of random
     *          - assigns one player as winner randomly
     *              - add point to winner
     *              - remove point from loser
     *      - ShowNameAndPoints()
     *          - console out name and points
     */
namespace Players
{
    internal class Player
    {
        private readonly string _name;
        private int _points;

        public Player(string name, int points)
        {
            _name = name;
            _points = points;
        }
        public void Play(Player otherPlayer)
        {
            Random random = new Random();
            int randomNumber = random.Next(2);

            if (randomNumber == 0)
            {
                _points++;
                if (otherPlayer._points > 0) otherPlayer._points--;
            }
            else
            {
                otherPlayer._points++;
                if (_points > 0) _points--;
            }
        }
        public void ShowNameAndPoints()
        {
            Console.WriteLine($"Name: {_name} Points: {_points}");
        }
    }
}