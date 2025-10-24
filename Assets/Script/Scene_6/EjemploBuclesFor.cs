using UnityEngine;
using UnityEngine.Rendering;

public class EjemploBuclesFor : MonoBehaviour
{
    [SerializeField]
    GameObject[] limitesEscenario;

    [SerializeField]
    GameObject[] prefabs;

    public int cantidadObjetos = 10;

    float minX, maxX, minZ, maxZ;
    float localX, localZ;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < limitesEscenario.Length; i++)
        {
            limitesEscenario[i].SetActive(false);
            localX = limitesEscenario[i].transform.position.x;
            localZ = limitesEscenario[i].transform.position.z;
            //leer X
            if (localX > maxX)
            {
                maxX = localX;
            } 
            else if (localX < minX)
            {
                minX = localX;
            }

            //leer Z
            if (localZ > maxZ)
            {
                maxZ = localZ;
            }
            else if (localZ < minZ)
            {
                minZ = localZ;
            }
            
        }
        Debug.Log("Min: (" + minX + ", " + minZ + ")");
        Debug.Log("Max: (" + maxX + ", " + maxZ + ")");

        for (int i = 0;i < cantidadObjetos;i++)
        {
            GenerateObject(prefabs);
        }

    }


    void GenerateObject(GameObject[] objects)
    {
        float randomX = Random.Range(minX - 1, maxX);
        float randomY = Random.Range(0.5f, 5f);
        float randomZ = Random.Range(minZ - 1, maxZ);
        Vector3 position = new Vector3(randomX, randomY, randomZ);
        Instantiate(objects[Random.Range(0, objects.Length)], position, Quaternion.identity);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
