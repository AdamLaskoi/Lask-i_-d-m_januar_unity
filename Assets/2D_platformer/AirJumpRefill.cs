
using UnityEngine;

class AirJumpRefill : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject go = collision.gameObject;

        Platformer_palyer player = go.GetComponent<Platformer_palyer>();

        if(player != null)
        {
          player.RefillAirJump();
        }

    }
}
