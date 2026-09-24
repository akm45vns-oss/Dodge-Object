using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    void Start()
    {
        transform.Translate(0f, 0f, 0f);
        startMsg();
    }

    void Update()
    {
        movePlayer();
    }

    void movePlayer()
    {
        float xValue = -Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = -Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0f, zValue, Space.World);
    }

    void startMsg()
    {
        Debug.Log("Welcome To Obstacle-Dodge");
        Debug.Log("Avoid Wall And Obstacle");
    }
}