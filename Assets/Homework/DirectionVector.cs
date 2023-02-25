using UnityEngine;

class DirectionVector : MonoBehaviour
{
    [SerializeField] Vector3 point1, point2;
    //van a �s b pont felvesz�nk egy vektort amely a pnt b�l b pontba mutat ebb�l egy normaliz�lt vektort k�sz�t�nk.
    Vector3 DirectionFromAToB (Vector3 a, Vector3 b)   //f�gv�ny bek�ri a k�t vektor param�tereit
    {
        return (b - a).normalized;   // a k�t vektor k�l�mds�ge normaliz�lva

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red; // A pont
        Gizmos.DrawSphere(point1, 0.1f);
        Gizmos.color = Color.green;  //B pont kirazol�sa
        Gizmos.DrawSphere(point2, 0.1f);
        Vector3 dir = DirectionFromAToB(point1, point2); 
        Vector3 c = point1 + dir;  //mehgat�rozza a C pont hely�t kisz�moltuk az 1 egys�g vektort amit ha hozz�adod a pont 1 kordin�t�hoz 
         Gizmos.DrawLine(point1, c); 
    }

}
