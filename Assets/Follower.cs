
using UnityEditor.U2D;
using UnityEngine;

class Follower : MonoBehaviour
{
    [SerializeField] float speed = 3;
    [SerializeField] Transform target;
    [SerializeField] float sineAmp = 0.1f;
    [SerializeField] float sinfreqMultiplier = 5;



    void Update()
    {
        

        Vector3 selfposition = transform.position;
        Vector3 targetPosition = target.position;

        Vector3 direction = targetPosition - selfposition;
        //direction.Normalize();

        /*
        //sin
        float sine = Mathf.Sin(Time.time * sinfreqMultiplier);
        sine *= sineAmp;
        sine += 1;
        direction *= sine;
        */

        //Vector3 velocity = direction * speed;
        //transform.position += velocity * Time.deltaTime;
        //kisz�molja a pozicio v�ltoz�st a jelenlegi pozicio a c�lpozicio �s megteszi ezt a t�vols�got a sebes�g �s delta time szorzat�val
        transform.position = Vector3.MoveTowards(selfposition, targetPosition,speed*Time.deltaTime);

        if(direction != Vector3.zero)
        transform.rotation = Quaternion.LookRotation(direction);

    }
}
