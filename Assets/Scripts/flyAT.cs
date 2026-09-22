using UnityEngine;

public class flyAT : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created47
   [SerializeField] float speed=5f;
   [SerializeField] Transform Player;
   Vector3 playerPosition;
    void Start()
    {
        playerPosition=Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        move2player();
        if (transform.position == playerPosition)
        {
            destroyWhenReached();
        }

    }
    void move2player()
    {
        transform.position = Vector3.MoveTowards(transform.position,playerPosition,speed*Time.deltaTime);
    }
    void destroyWhenReached()
    {
        Destroy(gameObject);
    }
}
