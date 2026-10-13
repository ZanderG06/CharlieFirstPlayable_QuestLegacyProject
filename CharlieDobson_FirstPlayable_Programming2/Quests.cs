using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//My script for the Legacy Project - Zander
namespace CharlieDobson_FirstPlayable_Programming2
{
    internal class Quests
    {
        public int totalGoldCollected = 0;

        string[] questList = { "Collect 300 total gold", "Buy something at the shop", "Complete the game" };
        bool[] questsCompleted = { false, false, false };

        public void QuestCompleted(int questIndex)
        {
            questsCompleted[questIndex] = true;
        }
    }
}