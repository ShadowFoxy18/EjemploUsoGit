using UnityEngine;

public class ContadorDeEspacios : MonoBehaviour
{

    int vecesPulsado = 0;
    int galletitas = 0;
    int magdalenas = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Has utilizado el espacio: " + vecesPulsado);
        Debug.Log("{ pulse I para ver tus objetos}");
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyUp(KeyCode.Space)) == true)
        {
            vecesPulsado++;
            if (vecesPulsado % 10 == 0 && vecesPulsado != 0)
            {
                Debug.Log("Has pulsado " + vecesPulsado + " QUE LOCURA!!, toma una galletita");
                galletitas++;
                Debug.Log("Obtenida una galleta");
            } 
            else
            {
                Debug.Log("Has utilizado el espacio: " + vecesPulsado);
            }
            if (vecesPulsado == 50)
            {
                vecesPulsado = 0;
                Debug.Log("Has llegado a 50 toques, se reiniciara el contador y obtendras una magdalena");
                magdalenas++;
                Debug.Log("Obtenida una magdalena");
            } 
        }
        if ((Input.GetKeyUp(KeyCode.I)) == true)
        {
            if (galletitas == 0)
            {
                Debug.Log("Lo siento, no tienes galletitas");
            } if (galletitas == 1) {
                Debug.Log("Tienes tu primera galletita");
            } if (galletitas != 1) {
                Debug.Log("Tienes " + galletitas + " galletitas, FELICIDADES!!");
            }
            if (magdalenas != 0)
            {
                Debug.Log("Tienes" + magdalenas + "magdalenas");
            }
        }

    }
}
