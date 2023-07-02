using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float moveforce = 2000f;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void FixedUpdate() {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        if (Input.GetKey("d")) {
            rb.AddForce(moveforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")) {
            rb.AddForce(-moveforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //if (Input.GetKey("w")) {
        //    rb.AddForce(0, 0, moveforce * Time.deltaTime, ForceMode.VelocityChange);
        //}
        //if (Input.GetKey("s")) {
        //    rb.AddForce(0, 0, -moveforce * Time.deltaTime, ForceMode.VelocityChange);
        //}
        if (Input.GetKey("z")) {
            rb.AddForce(0, 1 * moveforce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
