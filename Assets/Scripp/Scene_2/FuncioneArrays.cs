using UnityEngine;

public class FuncioneArrays : MonoBehaviour
{
    [SerializeField]
    int[] notasAlumnoPrimerTrimestre;

    [SerializeField]
    int[] notasAlumnoSegundoTrimestre;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int longitud = notasAlumnoPrimerTrimestre.Length;
        Debug.Log("Has sacado: " + notasAlumnoPrimerTrimestre[0]);
        Debug.Log("Longitud: " + longitud);
        MostrarArrayNum(notasAlumnoPrimerTrimestre);
        MostrarArrayNum(notasAlumnoSegundoTrimestre);
        Debug.Log("Nota mas alta del primer trismetre: " + NotaMayor(notasAlumnoPrimerTrimestre));
        Debug.Log("Nota mas alta del segundo trismetre: " + NotaMayor(notasAlumnoSegundoTrimestre));
        Debug.Log("Nota mas baja del primer trismetre: " + NotaBaja(notasAlumnoPrimerTrimestre));
        Debug.Log("Nota mas baja del segundo trismetre: " + NotaBaja(notasAlumnoSegundoTrimestre));
        Debug.Log("Nota media del primer trimestre: " + NotaMedia(notasAlumnoPrimerTrimestre).ToString("F2"));
        Debug.Log("Nota media del segundo trimestre: " + NotaMedia(notasAlumnoSegundoTrimestre).ToString("F2"));
    }

    /// <summary>
    /// funcion que imprime un array numerico
    /// </summary>
    /// <param name="notasAlumno"></param>
    void MostrarArrayNum(int[] notasAlumno)
    {
        for (int i = 0; i < notasAlumno.Length; i++)
        {
            Debug.Log("Notas_1: " + notasAlumno[i]);
        }
        foreach (int notas in notasAlumno)
        {
            Debug.Log("Notas_2: " + notas);
        }
    }


    /// <summary>
    /// Da la nota más alta de un Array y lo devuelve en int
    /// </summary>
    /// <param name="notasAlumno"></param>
    /// <returns></returns>
    int NotaMayor(int[] notasAlumno)
    {
        int notasMasAlta = 0;
        for (int i = 0; i < notasAlumno.Length; i++)
        {
            if (notasMasAlta < notasAlumno[i])
            {
                notasMasAlta = notasAlumno[i];
            }
        }
        return notasMasAlta;
    }

    /// <summary>
    /// Da la nota más baja de un Array y lo devuelve en int
    /// </summary>
    /// <param name="notasAlumno"></param>
    /// <returns></returns>
    int NotaBaja(int[] notasAlumno)
    {
        int notaMasBaja = 10;

        for (int i = 0; i < notasAlumno.Length; i++ )
        {
            if (notaMasBaja > notasAlumno[i])
            {
                notaMasBaja = notasAlumno[i];
            }
        }
        return notaMasBaja;
    }

    /// <summary>
    /// Da la nota media de una Array y lo devuelve en float
    /// </summary>
    /// <param name="notasAlumno"></param>
    /// <returns></returns>
    float NotaMedia(int[] notasAlumno)
    {
        float notaTotal = 0;
        for (int i = 0; i < notasAlumno.Length; i++)
        {
            notaTotal += notasAlumno[i];
        }
        float calificacionMedia = (notaTotal) / notasAlumno.Length;
        return calificacionMedia;
    }
}
