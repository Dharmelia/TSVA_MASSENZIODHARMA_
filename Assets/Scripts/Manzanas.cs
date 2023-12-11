using UnityEngine;

public class Manzana : MonoBehaviour
{
    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        if (scoreManager == null)
        {
            Debug.LogError("ScoreManager no encontrado en la escena.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RecolectarManzana();
        }
    }

    public void RecolectarManzana()
    {
        if (scoreManager != null)
        {
            scoreManager.AumentarManzanas();
        }
        else
        {
            Debug.LogError("ScoreManager no asignado en el script Manzana.");
        }

        Destroy(gameObject);
    }
}
