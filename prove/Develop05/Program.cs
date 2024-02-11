using System;

class Program
{
    /** To exceed expectations, I created a leveling system. The system has no cap with the way I have designed it. The user's level is displayed anytime the score is displayed, along with the score they need to reach to level up. There is also a special level-up console event. I also added error handling for the main menu such as displaying a message when trying to display/complete goals when none are present or displaying a message when trying to record an already completed goal. */

    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}