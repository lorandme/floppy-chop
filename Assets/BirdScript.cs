using System.Net;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D mrb;
    public float flapStength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            mrb.linearVelocity = Vector2.up * flapStength;
        }
        if (transform.position.y <= -8.5 || transform.position.y >= 8.5)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
