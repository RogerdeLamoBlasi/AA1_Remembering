using UnityEngine;

public class Bala : MonoBehaviour
{

    //Simplemente destruye la bala después de 5 segundos o al colisionar con otro objeto.
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