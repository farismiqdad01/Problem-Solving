using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem6 : MonoBehaviour
{
    public float minX, maxX, minY, maxY;
    public GameObject kotakPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        int objectCount = Random.Range(5, 10);
        for(int i = 0; i < objectCount; i++)
        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            Instantiate(kotakPrefabs, new Vector2(randomX, randomY), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
