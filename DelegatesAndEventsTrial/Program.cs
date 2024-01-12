namespace DelegatesAndEventsTrial
{
    internal static class Program
    {
        static async Task Main(string[] args)
        {
            var player = new Player();
            var party = new Party();

            // Subscribe to AchievementUnlocked event
            player.AchievementUnlocked += OnAchievementUnlocked; 
            player.AchievementUnlocked += party.Cheering;

            await player.AddPoints(30);
            await player.AddPoints(40);
            await player.AddPoints(40);

            // Unsubscribe to AchievementUnlocked event
            player.AchievementUnlocked -= OnAchievementUnlocked;
            player.AchievementUnlocked -= party.Cheering;
        }

        static void OnAchievementUnlocked(int point)
        {
            Console.WriteLine($"Congratulations! Achievement unlocked after earn {point} points");
        }
    }
}
