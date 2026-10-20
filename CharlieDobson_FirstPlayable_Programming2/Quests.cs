using System;

//My script for the Legacy Project - Zander
namespace CharlieDobson_FirstPlayable_Programming2
{
    internal class Quests
    {
        public int totalGoldCollected = 0;
        public string[] questList = { "Collect 100 total gold", "Buy something at the shop", "Complete the game" };
        
        bool[] questsCompleted = { false, false, false };
        int xOffset;
        int yOffset = 15;

        public void DisplayQuests()//Call after displaying HUD
        {
            xOffset = GameManager.Instance._gameMap._mapWidth + 10;

            for (int i = 0; i < questList.Length; i++)
            {
                Console.SetCursorPosition(xOffset, yOffset + i);
                Console.WriteLine($"Quest {i + 1}: {questList[i]}"); //+1 to account for 0 index
            }
        }

        public void QuestCompleted(int questIndex)//Call when conditions met
        {
            questsCompleted[questIndex] = true;
            questList[questIndex] = "Completed!                        ";
        }

        public int AmountOfQuestsCompleted()//Use for Game Over Screen
        {
            int completedCount = 0;

            for (int i = 0; i < questsCompleted.Length; i++)
            {
                if(questsCompleted[i] == true) completedCount++;
            }

            return completedCount;
        }
    }
}