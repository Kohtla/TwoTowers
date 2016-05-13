using UnityEngine;
using System.Collections;

public class Space {
	bool isWall = false;
	bool isUnit = false;
	bool isBuild = false;
	//bool isInvisible = false;
	public void setUnit()
	{
		isUnit = true;
	}
	public void killUnit()
	{
		isUnit = false;
	}
	public void setBuild()
	{
		isBuild = true;
	}
	public void killBuild()
	{		
		isBuild = false;
	}
	public bool isEmpty()
	{
		return true;		
	}
}


