using System;
using UnityEngine;
using UnityEngine.UIElements;

public class cuboMovimiento : MonoBehaviour
{
    [SerializeField]
    Transform[] posicionesMovimiento;

    [SerializeField]
    GameObject objeto;

    public float timeMovimiento = 4f;

    [SerializeField]
    LeanTweenType[] curvasMovimiento;

    Vector3 originalPosicion;

    int posicionArray = 0;

    int oldRandomNumber;
    int randomNumber = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalPosicion = posicionesMovimiento[0].position;
        RandomMove();
    }

    void Move()
    {
        posicionArray++;
        if (posicionArray >= posicionesMovimiento.Length)
        {
            posicionArray = 1;
        }
        LeanTween.move(objeto, posicionesMovimiento[posicionArray], timeMovimiento).setEase(curvasMovimiento[0]).setOnComplete(Move);
    }


    void RandomMove()
    {
        
        randomNumber = NumAleatorio();
        LeanTween.move(objeto, posicionesMovimiento[randomNumber], timeMovimiento).setEase(curvasMovimiento[0]).setOnComplete(RandomMove);
    }


    int NumAleatorio()      
    {
        int numero = Random.Range(1, posicionesMovimiento.Length);

        while (numero == randomNumber || numero == oldRandomNumber)
        {
            numero = Random.Range(1, posicionesMovimiento.Length);
        }
        oldRandomNumber = randomNumber;
        return numero;
    }


    // Update is called once per frame
    void Update()
    {
        //Move();
        
    }
}
