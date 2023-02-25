using UnityEngine;

class auto_rotater : MonoBehaviour
{
    [SerializeField] float angularSpeed = 180;


    void Update()
    {
        transform.Rotate(0,angularSpeed * Time.deltaTime,0);    
    }
}
