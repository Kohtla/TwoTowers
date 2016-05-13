using UnityEngine;
using System.Collections;

public class AttackType
{
    int cat;

    public AttackType(string k)
    {
        if (k == "meele")
            cat = 1;
        else if (k == "range")
            cat = 2;
    }
}
