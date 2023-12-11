using UnityEngine;

public class Interactuar_Manzaanas : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Manzana"))
        {
            Manzana manzana = other.GetComponent<Manzana>();
            if (manzana != null)
            {
                manzana.RecolectarManzana();
            }
        }
    }
}

