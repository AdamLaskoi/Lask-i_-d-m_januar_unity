
using UnityEngine;

class Step_jumper : MonoBehaviour
{
    //lépés számláló
    [SerializeField] Vector2 a, b;

    [SerializeField] int stepCount;
    [SerializeField] Vector2 step;


    private void OnValidate()  //csak akkor fut le ha editorban van ez egy fjelesztõi eszköz. editorban egybõl lefut és eredméynt ad.
    {
        Vector2 v = a - b;

        float lenght = v.magnitude;  //a vektor teljes hosszát adja vissza
        stepCount = Mathf.CeilToInt(lenght); //kiszámoltuk a lépések számát
        step = v / stepCount;   


    }



}
