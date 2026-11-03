using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision entered 2D!");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Trigger exited 2D!");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Collision stay 2D!");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered!");
    }
    */

    private bool isTouching;

    private void Update()
    {
        if (isTouching)
        {
            Debug.Log("The object is touching another collider.");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isTouching = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isTouching = false;
    }
}


/*

Old Video Time:

11:35

Current Video Time:

[ONGOING]

*/