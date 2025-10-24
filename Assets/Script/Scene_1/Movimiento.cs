using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float CapacidadDeSalto = 2;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Saltar en Space
        if ((Input.GetKeyUp(KeyCode.Space)) == true)
        {
            rb.AddForce(Vector3.up * CapacidadDeSalto, ForceMode.Impulse);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Me la pegue");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Deje de pegarmela");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Me la estoy pegando");
    }
}
