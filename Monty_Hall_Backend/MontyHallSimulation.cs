namespace Monty_Hall
{
    public class MontyHallSimulation
    {
        private readonly Random _random;

        public MontyHallSimulation()
        {
            _random = new Random();
        }

        public int SimulateGames(int numSimulations, bool changeDoor)
        {
            int wins = 0;

            for (int i = 0; i < numSimulations; i++)
            {
                // Randomly choose the door with the car (1, 2, or 3)
                int carDoor = _random.Next(1, 4);

                // Randomly choose the door the player initially picks
                int initialChoice = _random.Next(1, 4);

                // Determine the door to be opened by the presenter (not the car door and not the player's choice)
                // Create a list of door numbers: [1, 2, 3]
                List<int> doors = new List<int> { 1, 2, 3 };

                // Remove the player's initial choice and the car door from the list
                doors.Remove(initialChoice);
                doors.Remove(carDoor);

                // The remaining door in the list is the one to be opened by the user
                int doorToOpen = doors.First();

                int finalChoice;

                if (changeDoor)
                {
                    // If the player chooses to change the door:
                    List<int> remainingDoors = new List<int> { 1, 2, 3 };
                    remainingDoors.Remove(initialChoice);
                    remainingDoors.Remove(doorToOpen);
                    finalChoice = remainingDoors.First();
                }
                else
                {
                    // If the player chooses not to change the door:
                    finalChoice = initialChoice;
                }

                // Check if the final choice was the car door
                if (finalChoice == carDoor)
                    wins++;
            }

            return wins;
        }
    }
}
