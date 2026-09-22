using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField]float xRotate=0;
    [SerializeField]float yRotate=0;
    [SerializeField]float zRotate=4;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotate,yRotate,zRotate);
    }
}
