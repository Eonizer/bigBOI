using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public int width = 100;
    public int height = 100;

    public GameObject Tile;

    private int[,] coord;

    // Start is called before the first frame update
    void Start()
    {
        coord = new int[width,height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {   
                //why is this perlin guy gay? always same value = 0,47.. 
                float fValue = Mathf.PerlinNoise(x,y);

                if(fValue > 0.5f){
                    coord[x,y] = 1;        
                    Instantiate(Tile,new Vector3(x,y,0),Quaternion.identity,transform);                
                }
            }
        }
    }
}
