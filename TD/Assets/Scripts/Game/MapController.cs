using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    [SerializeField] private GameObject prefabMapTile;

    private int sizeX = 10;
    private int sizeY = 8;

    void Start()
    {
        GenerateMAp();
    }

    private void GenerateMAp()
    {
        float stepX = 20f / (sizeX - 3f);
        float stepY = 20f / (sizeY - 1f);

        for (int i = 0; i < sizeX; i++)
        {
            for (int j = 0; j < sizeY; j++)
            {
                float posX = -12 + i * stepX;
                float posY = -10 + j * stepY;
                Vector3 position = new Vector3(posX, posY, 0);
                GameObject tile = Instantiate(prefabMapTile, position, Quaternion.identity);
            }
        }
    }
}
