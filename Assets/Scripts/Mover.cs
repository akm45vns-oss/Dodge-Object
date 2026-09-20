using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float moveSpeed = 10f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.Translate(-18.81f,1f,0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        float xValue=Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue=0f;
        float zValue=Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
       transform.Translate(xValue,yValue,zValue); 
    }
}
