using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On : MonoBehaviour
{
    public Animator animator;
    public Animator animator2;
    public Animator animator3;
    public Animator animator4;

    public GameObject BallPrefab;

    public float BallStartYPosition; //Height to spawn balls.
    public float BallStartXRange;   //Width of random ball spawn position.


    private List<GameObject> ballList = new List<GameObject>(); //List of all spawned balls.

    //This is called by the UI button.

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < 1f; i++)
            {
                //Instantiate at a random position, and set to temp variable for future use.
                GameObject newBall = Instantiate(BallPrefab, new Vector3(Random.Range(-BallStartXRange, BallStartXRange), BallStartYPosition, 0f), Quaternion.identity);
                ballList.Add(newBall); //Use temp varaible to add ball to list.
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy") // If colliding with enemy, execute this block
        {
            animator.SetTrigger("isTrigger");
           
            Debug.Log("ow");
        }

        if (collision.gameObject.tag == "Enemy2") // If colliding with enemy, execute this block
        {
            animator2.SetTrigger("isTrigger2");

            Debug.Log("ow2");
        }

        if (collision.gameObject.tag == "Enemy3") // If colliding with enemy, execute this block
        {
            animator3.SetTrigger("isTrigger3");

            Debug.Log("ow3");
        }

        if (collision.gameObject.tag == "Enemy4") // If colliding with enemy, execute this block
        {
            animator4.SetTrigger("isTrigger4");

            Debug.Log("ow3");
        }

    }
}
