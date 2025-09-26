using UnityEngine;

public class Ejemplo_01 : MonoBehaviour
{
    public string nombreObjeto = "Texto complejo";
    public bool interruptorContador = false;
    int miVarableNumerica = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(nombreObjeto, gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        // Aumentar en una unidad
        if (miVarableNumerica != 10 && interruptorContador)
        {
            miVarableNumerica = miVarableNumerica + 1;
            Debug.Log(nombreObjeto + " en el Update " + miVarableNumerica);
        }
    }
}
