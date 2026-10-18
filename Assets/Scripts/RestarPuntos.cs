using UnityEngine;

public class PuntoObstaculo : MonoBehaviour
{
    public Puntuacion puntuacion;
    public int puntosRestar = 100;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bala"))
        {
            puntuacion.RestarPuntos(puntosRestar);
        }
    }
}