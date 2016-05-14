using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour 
{
    public GameObject map;
    float x = 100;
    float z = 50;
	
    void Start () 
    {      
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < z; j++)
            {
                Instantiate(map, new Vector3(1*i, 0, 1*j), Quaternion.identity);
            }
        }

        //map.transform.localScale = new Vector3(x, y, 0);
	}	
}
