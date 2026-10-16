
using UnityEngine;
using UnityEngine.InputSystem;

public class DisparoTorreta : MonoBehaviour
{
    public GameObject prefabBala;
    public Transform Boquilla;
    public float fuerza = 20f;
    
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            GameObject bala = Instantiate(
                prefabBala,
                Boquilla.position,
                Boquilla.rotation * Quaternion.Euler(90, 0, 0)
            );
            Destroy(bala, 2);

            Rigidbody rb = bala.GetComponent<Rigidbody>();
            rb.AddForce(Boquilla.forward * fuerza, ForceMode.Impulse);
        }
    }
}
