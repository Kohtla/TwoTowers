using UnityEngine;
using System.Collections;
using UnityEditor;
 

public class GameStart : MonoBehaviour 
{
    public GameObject map;
    public float x = 100;
    public float z = 50;
    Field cashMap;

	
    void Start () 
    { 
        cashMap = new Field((int)x, (int)z);
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < z; j++)
            {

                if(cashMap.goodMap[i,j]==0)
                    Instantiate(map, new Vector3(1*i, 0, 1*j), Quaternion.identity);
                else
                    Instantiate(map, new Vector3(1*i, 1, 1*j), Quaternion.identity);
            }
        }

        //map.transform.localScale = new Vector3(x, y, 0);
	}	
}
