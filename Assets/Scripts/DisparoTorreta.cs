
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class DisparoTorreta : MonoBehaviour
{
    public GameObject prefabBala;
    public Transform Boquilla;
    public float fuerza = 20f;

    void Update()
    {
        // Detecta si se ha presionado la tecla de espacio para disparar
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // Instancia la bala en la posición de la boquilla y con la rotación de la boquilla
            GameObject bala = Instantiate(prefabBala, Boquilla.position, Quaternion.identity);
            bala.transform.localEulerAngles = new Vector3(bala.transform.localEulerAngles.x+90f, 0, 0);
            bala.GetComponent<Rigidbody>()?.AddForce(Boquilla.forward * fuerza, ForceMode.Impulse);

        }
    }

}
