using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [Header("Batas Mouse")]
    public float speed = 5;
    public float minX, maxX, minY, maxY;
    private Vector2 mosPos;
    public Text scoreText;
    private int score;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score :" + score.ToString();
    }   
    private void FixedUpdate()
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "kotak")
        {
            score++;
        }
    }
}
