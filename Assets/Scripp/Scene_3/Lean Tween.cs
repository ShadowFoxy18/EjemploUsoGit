using TMPro;
using UnityEngine;

public class ControladorLeanTween : MonoBehaviour
{
    [SerializeField]
    GameObject objeto;

    [SerializeField]
    Vector3 position = new Vector3(0, 4, 0);

    [SerializeField]
    Vector3 escalado = new Vector3(2, 2, 2);

    [SerializeField]
    TextMeshProUGUI textoEscalado;

    [SerializeField]
    float time = 2f;

    [SerializeField]
    LeanTweenType curva;

    public int numeroDeRepeticiones = 5;
    public float numeroRandomMax = 10f;

    Vector3 originalScale;

    private void Start()
    {
        originalScale = objeto.transform.localScale;
        textoEscalado.text = "Agrandar";
    }
    /// <summary>
    /// Mover objeto a posicion determinada
    /// </summary>
    public void AccionBoton()
    {
        if (objeto.transform.localPosition != Vector3.zero) {
            LeanTween.move(objeto, Vector2.zero, 0.5f);
        } else
        {
            LeanTween.move(objeto, position, time).setEase(curva);
        }  
    }


    /// <summary>
    /// Mover objeto a punto random 
    /// </summary>
    public void AccionRandomBoton()
    {
        float aleX = Random.Range(-numeroRandomMax, numeroRandomMax);
        float aleY = Random.Range(0, numeroRandomMax);
        float aleZ = Random.Range(-numeroRandomMax, numeroRandomMax);
        Vector3 randomPosition = new Vector3(aleX, aleY, aleZ);
        for (int i = 0; i < numeroDeRepeticiones; i++)
        {
            LeanTween.move(objeto, randomPosition, time).setEase(curva);
        }

    }

    /// <summary>
    /// Cambiar el tamaño
    /// </summary>
    public void CambioDeTamaño()
    {
        if (objeto.transform.localScale == originalScale)
        {
            LeanTween.scale(objeto, escalado, 1f).setEase(curva);
            textoEscalado.text = "Encoger";
        } else 
        { 
            LeanTween.scale(objeto, originalScale, 1f).setEase(curva);
            textoEscalado.text = "Agrandar";
        }
    }
}
