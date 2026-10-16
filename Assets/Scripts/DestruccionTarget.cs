
using UnityEngine;

public class DestruccionTarget : MonoBehaviour
{
    public GameObject modeloCompleto;
    public GameObject prefabRoto;

    private Collider colliderTarget;
    private float contador = 0f;
    private bool destruido = false;

    void Start()
    {
        colliderTarget = GetComponent<Collider>();
    }

    void Update()
    {
        if (destruido)
        {
            contador += Time.deltaTime;

            if (contador >= 3f)
            {
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
            colliderTarget.enabled = false;
            destruido = true;
            contador = 0f;
            Destroy(other.gameObject);
        }
    }
}
