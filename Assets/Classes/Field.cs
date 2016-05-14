using UnityEngine;
using System.Collections;

public class Field 
{
	int x;
	int y;
	Space[,] f;
    public int[,] goodMap;

	public Field(int x, int y)
	{
		this.x = y;
		this.y = x;
        f = new Space[x,y];
        goodMap = new int[x, y];
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                f[i, j] = new Space();
                goodMap[i, j] = 0;
                if (i == 0 || j == 0 || i == x - 1 || j == y - 1)
                {
                    f[i, j].setWall();
                    goodMap[i, j] = -1;
                }
                if (i > 40 && i < 59)
                {
                    if (j < 15 || j >34)
                    {
                        f[i, j].setWall();
                        goodMap[i, j] = -1;
                    }
                }
            }
        }
	}


}
