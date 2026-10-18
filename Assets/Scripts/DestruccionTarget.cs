
using UnityEngine;

public class DestruccionTarget : MonoBehaviour
{
    public GameObject modeloCompleto;
    public GameObject prefabRoto;
    public Collider colliderDiana;
    public Puntuacion puntuacion;
    public int puntosDiana = 100;

    private bool destruido = false;
    private float contador = 0f;

    void Update()
    {
        if (destruido)
        {
            contador += Time.deltaTime;

            // Si han pasado 3 segundos, vuelve a activar el modelo completo y el collider
            if (contador >= 3f)
            {
                modeloCompleto.SetActive(true);
                colliderDiana.enabled = true;

                destruido = false;
                contador = 0f;
            }
        }
    }

    // Detecta la colisión con la bala y destruye el modelo completo, instanciando el prefab roto
    void OnTriggerEnter(Collider other)
    {
        if (destruido)
            return;

        // Comprueba si el objeto que colisiona tiene la etiqueta "Bala"
        if (other.CompareTag("Bala"))
        {
            // Suma los puntos al marcador
            puntuacion.SumarPuntos(puntosDiana);

            // Instancia el prefab roto en la posición y rotación del modelo completo
            GameObject roto = Instantiate(
                prefabRoto,
                modeloCompleto.transform.position,
                modeloCompleto.transform.rotation
            );
            Destroy(roto, 3f);

            modeloCompleto.SetActive(false);
            colliderDiana.enabled = false;
            destruido = true;
            contador = 0f;
        }
    }

}