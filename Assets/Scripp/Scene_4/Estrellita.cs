using UnityEngine;

public class Estrellita : MonoBehaviour
{
    [SerializeField]
    GameObject estrellita;

    [SerializeField]
    float animationTime = 5f;

    public Vector3 newScale = Vector3.one;
    public float nuevaPosicion = 5f;

    Vector3 originalPosition;

    [SerializeField]
    LeanTweenType[] curva; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalPosition = estrellita.transform.localPosition;
        int curvaAleatoria = Random.Range(0, curva.Length);
    }

    void AnimacionFinal()
    {
        //LeanTween.rotateZ(estrellita, 180, 3f).setEase(curva[3]);
        LeanTween.scale(estrellita, new Vector3(3f, 3f, 3f), 2f).setEase(curva[2]);
    }

    // Update is called once per frame
    void Update()
    {
        LeanTween.moveLocalY(estrellita, nuevaPosicion, (animationTime - 2)).setEase(curva[1]);
        LeanTween.scale(estrellita, newScale, (animationTime + 2)).setEase(curva[0]).setOnComplete(AnimacionFinal);
    }
}
