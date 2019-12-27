using UnityEngine;

public class Chaincollision : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        Chain.IsFired = false;
        
        if(col.tag == "ball")
        {
            col.GetComponent<Ball>().split();
        }
    }


}
