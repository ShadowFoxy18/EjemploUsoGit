using UnityEngine;

public class CreadorObjetos : MonoBehaviour
{
    [SerializeField]
    GameObject[] objetosACrear;

    public int cantidadObjetos = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //GameObject[] objetos = (objetosACrear1, objetosACrear2, objetosACrear3);
        for (int i = 0; i < cantidadObjetos; i++)
        {
            Vector3 posicion = new Vector3(Random.Range(-10, 11), Random.Range(-10, 11), Random.Range(-5, 6));
            Instantiate(objetosACrear[Random.Range(0, objetosACrear.Length)], posicion, Quaternion.identity);
        }
    }

}
