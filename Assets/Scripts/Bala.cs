using UnityEngine;

public class Bala : MonoBehaviour
{




    private void OnCollisionEnter(Collision collision)
    {
        DestroyImmediate(gameObject);


    }
    private void OnTriggerEnter(Collider other)
    {
        DestroyImmediate(gameObject);
        
    }
}