using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]float dropTime=3f;
    MeshRenderer Mesh;
    Rigidbody Rigid;
    void Start()
    {
        Mesh=GetComponent<MeshRenderer>();
        Rigid=GetComponent<Rigidbody>();
        Mesh.enabled=false;
        Rigid.useGravity=false;

    }

    void Update()
    {
        if (Time.time == 2.8f)
        {
            Debug.Log("Watch Above");
        }
        if (Time.time > dropTime)
        {
            Mesh.enabled=true;
            Rigid.useGravity=true;
        }   
    }
}
