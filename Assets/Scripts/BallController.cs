using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;
    private Rigidbody2D rig;
    public Collider2D LeftPaddle;
    public Collider2D RightPaddle;
    public int LastHitPaddle;


    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    private void Update()
    {
        // transform.position = transform.position + (new Vector3(1f, 0, 0) * Time.deltaTime);
        // transform.Translate((new Vector3(1f, 0, 0) * Time.deltaTime));
        //transform.Translate(speed * Time.deltaTime);
    
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);

    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider == LeftPaddle)
        {
            LastHitPaddle = 0;
        }

        if (collision.collider == RightPaddle)
        {
            LastHitPaddle = 1;
        }
    }
}
