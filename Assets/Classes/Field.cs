using UnityEngine;
using System.Collections;

public class Field 
{
	int x;
	int y;
	Space[,] f;
    int[,] goodMap;

	public Field(int x, int y)
	{
		this.x = x;
		this.y = y;
        f = new Space[y,x];
        goodMap = new int[y, x];
	}


}
