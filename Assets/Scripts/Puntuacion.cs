using UnityEngine;
using TMPro;

public class Puntuacion : MonoBehaviour
{
    public TMP_Text textoPuntuacion;
    private int puntos = 0;

    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
        textoPuntuacion.text = "Puntuacion: " + puntos;
    }
    public void RestarPuntos(int cantidad)
    {
        puntos -= cantidad;
        textoPuntuacion.text = "Puntuacion: " + puntos;
    }
}