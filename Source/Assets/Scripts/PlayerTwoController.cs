using UnityEngine;

public class PlayerTwoController : MonoBehaviour
{

    //player two axis w/s
    public string axis = "PlayerTwoAxis";

    //paddle speed
    public float speed = 7f;

    void FixedUpdate()
    {
        float verticalInput = Input.GetAxisRaw(axis);   //get input
        GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, verticalInput) * speed;     //calculate new velocity vector
    }


}
