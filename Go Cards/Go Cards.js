for (i = 1; i < 101; i++)
            {
                if (i % 4==0 && i % 7 == 0)
                {
                    console.log("Go Cards!");
                }
                else if (i % 7 == 0)
                {
                    console.log("Cards!");
                }
                else if (i % 4 == 0)
                {
                    console.log("Go ");
                }
                else
                {
                    console.log(i);
                }
            }
            console.log();