using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreTextMesh;
    private int currentManzanas = 0;
    public int maxManzanas = 15;

    private void Start()
    {
        ActualizarPuntaje();
    }

    public void AumentarManzanas()
    {
        if (currentManzanas < maxManzanas)
        {
            currentManzanas++;
            ActualizarPuntaje();
            VerificarVictoria();
        }
    }

    private void VerificarVictoria()
    {
        if (currentManzanas == maxManzanas)
        {
            Debug.Log("¡Has recolectado todas las manzanas!");
            SceneManager.LoadScene("Victoria"); 
        }
    }

    private void ActualizarPuntaje()
    {
        if (scoreTextMesh != null)
        {
            scoreTextMesh.text = "Manzanas: " + currentManzanas + " / " + maxManzanas;
        }
        else
        {
            Debug.LogError("El componente TextMeshProUGUI no está asignado en el ScoreManager.");
        }
    }
}
