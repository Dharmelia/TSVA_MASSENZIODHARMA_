using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

public class Temporizador : MonoBehaviour
{
    public float tiempoLimite = 180f; 
    private float tiempoRestante;
    private bool manzanasCompletas = false;
    public TMP_Text textoTiempo; 

    private void Start()
    {
        tiempoRestante = tiempoLimite;
        StartCoroutine(IniciarTemporizador());
    }

    private IEnumerator IniciarTemporizador()
    {
        while (tiempoRestante > 0f)
        {
            ActualizarTexto();
            yield return new WaitForSeconds(1f);
            tiempoRestante--;
        }

        if (!manzanasCompletas)
        {
            IrEscenaDerrota();
        }
    }

    private void ActualizarTexto()
    {
        int minutos = Mathf.FloorToInt(tiempoRestante / 60f);
        int segundos = Mathf.FloorToInt(tiempoRestante % 60f);
        textoTiempo.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }

    public void ManzanaRecolectada()
    {
        manzanasCompletas = true;
    }

    private void IrEscenaDerrota()
    {
        SceneManager.LoadScene("z_Derrota");
    }
}
