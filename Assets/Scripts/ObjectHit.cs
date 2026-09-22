using UnityEngine;

public class ObjectHit : MonoBehaviour
{
   void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
          GetComponent<MeshRenderer>().material.color=Color.pink;
          gameObject.tag="Hit";  
        }
        
    }
}
