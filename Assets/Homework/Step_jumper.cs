
using UnityEngine;

class Step_jumper : MonoBehaviour
{
    //l�p�s sz�ml�l�
    [SerializeField] Vector2 a, b;

    [SerializeField] int stepCount;
    [SerializeField] Vector2 step;


    private void OnValidate()  //csak akkor fut le ha editorban van ez egy fjeleszt�i eszk�z. editorban egyb�l lefut �s eredm�ynt ad.
    {
        Vector2 v = a - b;

        float lenght = v.magnitude;  //a vektor teljes hossz�t adja vissza
        stepCount = Mathf.CeilToInt(lenght); //kisz�moltuk a l�p�sek sz�m�t
        step = v / stepCount;   


    }



}
