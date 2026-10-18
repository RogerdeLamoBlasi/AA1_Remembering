
using UnityEngine;
using UnityEngine.InputSystem;

public class CamaraOrbital : MonoBehaviour
{
    public float sensibilidadVertical = 100f;
    public float sensibilidadHorizontal = 100f;

    private float rotacionX;
    private float rotacionY;

    void Update()
    {
        // Verifica si el teclado está disponible antes de acceder a él
        if (Keyboard.current == null)
        {
            return;
        }
        // Obtiene la entrada del teclado para rotar la cámara
        if (Keyboard.current.aKey.isPressed)
        {
            rotacionY -= sensibilidadHorizontal * Time.deltaTime;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            rotacionY += sensibilidadHorizontal * Time.deltaTime;
        }
        if (Keyboard.current.wKey.isPressed)
        {
            rotacionX -= sensibilidadVertical * Time.deltaTime;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            rotacionX += sensibilidadVertical * Time.deltaTime;
        }
        // Limita la rotación vertical para evitar que la cámara se voltee
        rotacionX = Mathf.Clamp(rotacionX, -80f, 80f);
        transform.rotation = Quaternion.Euler(
            rotacionX, rotacionY, 0f
        );
    }
}
