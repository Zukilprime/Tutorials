using System;

public class XPBudgetter
{
    public static void Main()
    {
        int[] lvl00 = new int[] { 0, 0, 0, 0, 0 };
        int[] lvl01 = new int[] { 25, 50, 75, 100, 125 }; int[] lvl02 = new int[] { 50, 100, 150, 200, 250 };
        int[] lvl03 = new int[] { 100, 200, 300, 400, 500 }; int[] lvl04 = new int[] { 175, 350, 525, 700, 875 };
        int[] lvl05 = new int[] { 275, 550, 825, 1100, 1375 }; int[] lvl06 = new int[] { 400, 800, 1200, 1600, 2000 };
        int[] lvl07 = new int[] { 550, 1100, 1650, 2200, 2750 }; int[] lvl08 = new int[] { 750, 1500, 2250, 3000, 3750 };
        int[] lvl09 = new int[] { 850, 1700, 2550, 3400, 4250 }; int[] lvl10 = new int[] { 1100, 2200, 3300, 4400, 5500 };
        int[] lvl11 = new int[] { 1400, 2800, 4200, 5600, 7000 }; int[] lvl12 = new int[] { 1750, 3500, 5250, 7000, 8750 };
        int[] lvl13 = new int[] { 2200, 4400, 6600, 8800, 11000 }; int[] lvl14 = new int[] { 2700, 5400, 8100, 10800, 13500 };
        int[] lvl15 = new int[] { 3250, 6500, 9750, 13000, 16250 }; int[] lvl16 = new int[] { 3850, 7700, 11550, 15400, 19250 };
        int[] lvl17 = new int[] { 4500, 9000, 13500, 18000, 22500 }; int[] lvl18 = new int[] { 5200, 10400, 15600, 20800, 26000 };
        int[] lvl19 = new int[] { 5950, 11900, 17850, 23800, 29750 }; int[] lvl20 = new int[] { 6750, 13500, 20250, 27000, 33750 };

        int[][] levelList = new int[][]{lvl00,lvl01,lvl02,lvl03,lvl04,lvl05,lvl06,lvl07,lvl08,lvl09,lvl10,
                                      lvl11,lvl12,lvl13,lvl14,lvl15,lvl16,lvl17,lvl18,lvl19,lvl20};

        Console.WriteLine("Player character level: ");
        var pcLvlSelect = int.Parse(Console.ReadLine());
        Console.WriteLine("Player character number: ");
        var pcAmt = int.Parse(Console.ReadLine());

        int[] levelOutput = levelList[pcLvlSelect];

        Console.WriteLine("Henchman level (if any): ");
        var henchLvlSelect = int.Parse(Console.ReadLine());
        Console.WriteLine("Henchman number(if any): ");
        var henchAmt = int.Parse(Console.ReadLine());

        int[] henchLevelOutput = levelList[henchLvlSelect];

        //Output seperated by encounter challenge
        var xpOutputE = ((pcAmt) * (levelOutput[0])) + ((henchAmt) * (henchLevelOutput[0]));
        var xpOutputM = ((pcAmt) * (levelOutput[1])) + ((henchAmt) * (henchLevelOutput[1]));
        var xpOutputH = ((pcAmt) * (levelOutput[2])) + ((henchAmt) * (henchLevelOutput[2]));
        var xpOutputD = ((pcAmt) * (levelOutput[3])) + ((henchAmt) * (henchLevelOutput[3]));
        var xpOutputEx = ((pcAmt) * (levelOutput[4])) + ((henchAmt) * (henchLevelOutput[4]));

        Console.WriteLine("Solo Easy xp is:         " + xpOutputE);
        Console.WriteLine("Solo Medium xp is:       " + xpOutputM);
        Console.WriteLine("Solo Hard xp is:         " + xpOutputH);
        Console.WriteLine("Solo Deadly xp is:       " + xpOutputD);
        Console.WriteLine("Solo Extreme xp is:      " + xpOutputEx);

        Console.WriteLine("Pair Easy xp is:         " + xpOutputE / 1.5);
        Console.WriteLine("Pair Medium xp is:       " + xpOutputM / 1.5);
        Console.WriteLine("Pair Hard xp is:         " + xpOutputH / 1.5);
        Console.WriteLine("Pair Deadly xp is:       " + xpOutputD / 1.5);
        Console.WriteLine("Pair Extreme xp is:      " + xpOutputEx / 1.5);

        Console.WriteLine("3-6 Easy xp is:          " + xpOutputE / 2);
        Console.WriteLine("3-6 Medium xp is:        " + xpOutputM / 2);
        Console.WriteLine("3-6 Hard xp is:          " + xpOutputH / 2);
        Console.WriteLine("3-6 Deadly xp is:        " + xpOutputD / 2);
        Console.WriteLine("3-6 Extreme xp is:       " + xpOutputEx / 2);

        Console.WriteLine("7-10 Easy xp is:         " + xpOutputE / 2.5);
        Console.WriteLine("7-10 Medium xp is:       " + xpOutputM / 2.5);
        Console.WriteLine("7-10 Hard xp is:         " + xpOutputH / 2.5);
        Console.WriteLine("7-10 Deadly xp is:       " + xpOutputD / 2.5);
        Console.WriteLine("7-10 Extreme xp is:      " + xpOutputEx / 2.5);

        Console.WriteLine("11-14 Easy xp is:        " + xpOutputE / 3);
        Console.WriteLine("11-14 Medium xp is:      " + xpOutputM / 3);
        Console.WriteLine("11-14 Hard xp is:        " + xpOutputH / 3);
        Console.WriteLine("11-14 Deadly xp is:      " + xpOutputD / 3);
        Console.WriteLine("11-14 Extreme xp is:     " + xpOutputEx / 3);

        Console.ReadLine();
    }
}
