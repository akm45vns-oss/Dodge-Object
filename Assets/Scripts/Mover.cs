using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float moveSpeed = 10f;
    
    void Start()
    {
        transform.Translate(0f,0f,-2f);
        startMsg();

    }

    void Update()
    {
       movePlayer();
    }
    void movePlayer()
    {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
        transform.Translate(xValue,yValue,zValue);
    }
    void startMsg()
    {
        Debug.Log("Welcome To Obstacle-Dodge");
        Debug.Log("Avoid Wall And Obstalce");
    }
}
