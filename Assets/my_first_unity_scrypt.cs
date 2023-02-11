
using UnityEngine;
using UnityEngine.UI;

class my_first_unity_scrypt : MonoBehaviour
{
 
    void Start()
    {
        Vector2 v1;
        v1 = new Vector2(2, 4);

        float x = v1.x;
        Debug.Log(x); //x2

        v1 = v1 * 3;

        Debug.Log(v1.x); //x6
        Debug.Log(v1.y); //y6

        Vector2 v2 = new Vector2(3, 1);

        Vector2 v3 = v1 + v2; // (9,13)  //összeadás

        Debug.Log(v3.x); //9
        Debug.Log(v3.y); //13

        Vector3 va = new Vector3(1.234f, 2.456f,3);

        va *= 5; 

        Vector3 zero1 = new Vector3 (0,0,0);
        Vector3 zero2 = Vector3.zero;

        Vector3 up2 = Vector3.up;
        

        Vector3 forward = Vector3.forward; //(0,0,1)
        Vector3 back = Vector3.back; // (0,0, -1)
        Vector3 left = Vector3.left; //(-1, 0, 0)

        up2 /= 2;

        float mag = va.magnitude;

        Vector3 vaNorm = va.normalized; // lekérem a normalizált verziót.
        va.Normalize(); // va innentõl 1 hosszú; mert ez a mentodus normalizálta

        float distance = (v1 - v2).magnitude;
        float distanc2 = Vector3.Distance(v1, v2);

    }
    
    void Update()
    {
        
    }

}
