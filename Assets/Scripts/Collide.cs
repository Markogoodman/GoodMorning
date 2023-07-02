using UnityEngine;

public class Collide : MonoBehaviour {

    public PlayerMovement movement;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision info) {
        //Debug.Log(info.collider.tag == "Obstacle");
        if (info.collider.tag == "Obstacle") {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame(); 
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
