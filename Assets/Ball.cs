using UnityEngine;

public class Ball : MonoBehaviour
{

    public Vector2 startforce;

    public Rigidbody2D rb;

    public GameObject nextball;


    void Start()
    {
        rb.AddForce(startforce, ForceMode2D.Impulse);
    }

    public void split()
    {
        if(nextball != null)
        {
           GameObject ball1 = Instantiate(nextball, rb.position + Vector2.right / 4f, Quaternion.identity);
           GameObject ball2 = Instantiate(nextball, rb.position + Vector2.left / 4f, Quaternion.identity);

            ball1.GetComponent<Ball>().startforce = new Vector2(2f, 5f);
            ball2.GetComponent<Ball>().startforce = new Vector2(-2f, 5f);
        }
        Destroy(gameObject);
    }
}	
