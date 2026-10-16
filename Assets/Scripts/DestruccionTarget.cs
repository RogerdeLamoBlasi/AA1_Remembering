
using UnityEngine;

public class DestruccionTarget : MonoBehaviour
{
    public GameObject modeloCompleto;
    public GameObject prefabRoto;

    private Collider colliderDiana;
    private bool destruido = false;
    private float contador = 0f;

    void Start()
    {
        colliderDiana = GetComponent<Collider>();
    }

    void Update()
    {
        if (destruido)
        {
            contador += Time.deltaTime;

            if (contador >= 3f)
            {
                modeloCompleto.SetActive(true);
                colliderDiana.enabled = true;

                destruido = false;
                contador = 0f;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (destruido)
            return;

        if (other.CompareTag("Bala"))
        {
            Instantiate(
                prefabRoto,
                modeloCompleto.transform.position,
                modeloCompleto.transform.rotation
            );

            modeloCompleto.SetActive(false);
            colliderDiana.enabled = false;

            destruido = true;
            contador = 0f;
        }
    }

}