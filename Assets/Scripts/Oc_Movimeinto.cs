using UnityEngine;

public class MovimientoUpDown : MonoBehaviour
{
    public float velocidad = 2.0f;
    public float amplitud = 1.0f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float movimientoVertical = Mathf.Sin(Time.time * velocidad) * amplitud;
        transform.position = startPosition + new Vector3(0f, movimientoVertical, 0f);
    }
}
