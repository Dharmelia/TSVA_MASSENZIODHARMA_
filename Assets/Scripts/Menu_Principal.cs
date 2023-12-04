using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{

    public void Mapa_Base()
    {
        SceneManager.LoadScene("Segunda_Escena");
    }

    public void Iniciar()
    {
        SceneManager.LoadScene("Tercera_Escena");
    }
    public void Exit()
    {
        Application.Quit();
    }
}