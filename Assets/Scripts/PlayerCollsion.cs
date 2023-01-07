using UnityEngine;

public class PlayerCollsion : MonoBehaviour
{
    public PlayerMovement movement;
    //public GameManager gameManager;
    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag=="Obstacle") {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
