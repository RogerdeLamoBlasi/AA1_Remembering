
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class DisparoTorreta : MonoBehaviour
{
    public GameObject prefabBala;
    public Transform Boquilla;
    public float fuerza = 20f;

    

    private void Start()
    {
        

    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            GameObject bala = Instantiate(prefabBala, Boquilla.position, Quaternion.identity);

            bala.transform.localEulerAngles = new Vector3(bala.transform.localEulerAngles.x+90f, 0, 0);

            // SALE DISPARADO
            bala.GetComponent<Rigidbody>()?.AddForce(Boquilla.forward * fuerza, ForceMode.Impulse);

        }
    }

}
