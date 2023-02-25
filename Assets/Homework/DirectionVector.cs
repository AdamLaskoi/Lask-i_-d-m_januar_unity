using UnityEngine;

class DirectionVector : MonoBehaviour
{
    [SerializeField] Vector3 point1, point2;
    //van a és b pont felveszünk egy vektort amely a pnt ból b pontba mutat ebbõl egy normalizált vektort készítünk.
    Vector3 DirectionFromAToB (Vector3 a, Vector3 b)   //fügvény bekéri a két vektor paramétereit
    {
        return (b - a).normalized;   // a két vektor külömdsége normalizálva

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red; // A pont
        Gizmos.DrawSphere(point1, 0.1f);
        Gizmos.color = Color.green;  //B pont kirazolása
        Gizmos.DrawSphere(point2, 0.1f);
        Vector3 dir = DirectionFromAToB(point1, point2); 
        Vector3 c = point1 + dir;  //mehgatározza a C pont helyét kiszámoltuk az 1 egység vektort amit ha hozzáadod a pont 1 kordinátához 
         Gizmos.DrawLine(point1, c); 
    }

}
