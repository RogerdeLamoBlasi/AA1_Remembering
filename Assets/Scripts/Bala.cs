using UnityEngine;

public class Bala : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}