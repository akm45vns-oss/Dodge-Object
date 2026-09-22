using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hit=0;
   private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag!="Hit")
        {
        hit++;
        Debug.Log("You Hit The Obstacle this many times : "+hit);
        }
    }

}
