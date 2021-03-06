using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float speed = 5f;
    private int maxY = -5;

    // Update is called once per frame
    void Update()
    {
        MoveBadGuys();
    }

    public void MoveBadGuys()
    {
        transform.Translate(Vector3.up * Time.deltaTime); 

        if(transform.position.y < maxY) //If reaches end of the game screen
        {
            Destroy(gameObject);
        }
    }

    // OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider
    private void OnCollisionEnter(Collision collision)
    {
        //If enemies hit player ship then destroy the player ship
        if(collision.gameObject.GetComponent<Player>() != null) //if player ship exists
        {
            CrashteroidsMaster.GameOver();
            Destroy(gameObject);
        }
    }
}
