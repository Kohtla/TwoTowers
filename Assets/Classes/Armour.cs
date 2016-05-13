using UnityEngine;
using System.Collections;

public class Armour
{
    int cat;

    public Armour(string k)
    {
        if(k == "flesh") cat = 1;
        else if (k == "light") cat = 2;
        else if (k == "medium") cat = 3;
        else if (k == "heavy") cat = 4;
        else if (k == "building") cat = 5;
    }
	
}
