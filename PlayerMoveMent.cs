using UnityEngine;

public class PlayerMoveMent : MonoBehaviour
{
    // var
    public Rigidbody rb;


    // make a var for ForwardForce on line 23 using the command float for make var for specefic data type
    public float ForwardForce = 2000f;
    public float sidewayForce = 500f;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // forward force 
        //rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (Input.GetKey("w"))
        {
            //code
            rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            //code
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            //code
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("space"))
        {
            rb.AddForce(0, 300 * Time.deltaTime, 0);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManger>().EndGame();
        }
    }
}

