using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{

    //Ball speed
    public float ballSpeed = 5f;

    //Score text reference and score variables
    public Text playerOneScore_text;
    public Text playerTwoScore_text;
    public static int playerOneScore;
    public static int playerTwoScore;

    //Paddles References
    public GameObject playerOnePaddle;
    public GameObject playerTwoPaddle;


    // Use this for initialization
    void Start()
    {
        //initial velocity of ball
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * ballSpeed;

        //initialize score text to '0' (static)
        playerOneScore_text.text = playerOneScore.ToString();
        playerTwoScore_text.text = playerTwoScore.ToString();
    }


    //Scoring Goals
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //PlayerOne Scores
        if (collision.gameObject.tag == "Left Goal")
        {
            //Increment Score
            playerOneScore++;
            playerOneScore_text.text = playerOneScore.ToString();

            //reset ball position
            gameObject.transform.position = new Vector2(0, 0);
            GetComponent<Rigidbody2D>().velocity = Vector2.left * ballSpeed;

            //reset both paddle position
            playerOnePaddle.transform.position = new Vector2(7.0f, 0f);
            playerTwoPaddle.transform.position = new Vector2(-7.0f, 0f);
        }

        //PlayerTwo Scores
        if (collision.gameObject.tag == "Right Goal")
        {
            //increment score
            playerTwoScore++;
            playerTwoScore_text.text = playerTwoScore.ToString();

            //reset ball position
            gameObject.transform.position = new Vector2(0, 0);
            GetComponent<Rigidbody2D>().velocity = Vector2.right * ballSpeed;

            //reset both paddle position
            playerOnePaddle.transform.position = new Vector2(7.0f, 0f);
            playerTwoPaddle.transform.position = new Vector2(-7.0f, 0f);
        }
    }
}
