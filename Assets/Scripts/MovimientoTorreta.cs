using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoTorreta : MonoBehaviour
{
    public Transform baseTorreta;
    public Transform torsoTorreta;

    public float sensibilidad = 1f;


    void Update()
    {
        Vector2 movimiento = Mouse.current.delta.ReadValue();

        float horizontal = movimiento.x * sensibilidad;
        float vertical = movimiento.y * sensibilidad;

        baseTorreta.Rotate(0, horizontal, 0);
        torsoTorreta.Rotate(-vertical, 0, 0);
    }
}