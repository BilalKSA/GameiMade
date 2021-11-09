using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMoveMent movement;

    void OnCollisionEnter (Collision collisioninfo) {
        // you can use tag or name 
        if ( collisioninfo.collider.tag == "Colls") {
            movement.enabled = false;
            FindObjectOfType<GameManger>().EndGame();
            
        }
    }

}
