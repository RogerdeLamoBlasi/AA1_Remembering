using UnityEngine;

public class MovimientoDiana : MonoBehaviour
{
    public float distancia = 3f;
    public float velocidad = 1f;

    private Vector3 posicionInicial;

    void Start()
    {
        // Guarda la posición inicial de la diana
        posicionInicial = transform.position;
    }

    void Update()
    {
        // Movimiento horizontal de la diana
        float movimiento = Mathf.Sin(Time.time * velocidad) * distancia;
        transform.position = posicionInicial + Vector3.right * movimiento;
    }
}