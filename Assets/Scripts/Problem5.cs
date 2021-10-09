using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem5 : MonoBehaviour
{
    [Header("Batas Mouse")]
    public float speed=5;
    public float minX, maxX, minY, maxY;
    private Vector2 mosPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mosPos = Input.mousePosition;
        mosPos = Camera.main.ScreenToWorldPoint(mosPos);

        if (mosPos.x > minX && mosPos.x < maxX && mosPos.y > minY && mosPos.y < maxY)
        {
            transform.position = Vector2.MoveTowards(transform.position, mosPos, speed * Time.deltaTime);
        }
        else
        {
            return;
        }

    }
}
