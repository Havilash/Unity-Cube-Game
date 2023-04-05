using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerRB;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Forward-Movement
        playerRB.AddForce(0, 0, forwardForce * Time.deltaTime);

        //Sideways-Movement
        if (Input.GetKey(KeyCode.D))
        {
            playerRB.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerRB.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (playerRB.position.y < -1)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
