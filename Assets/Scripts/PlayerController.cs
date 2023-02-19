using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private readonly float speed = 20.0f;
    private readonly float turnSpeed = 25;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.horizontalInput = Input.GetAxis("Horizontal");
        this.forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * this.speed * this.forwardInput);
        //transform.Translate(Vector3.right * Time.deltaTime * /*this.turnSpeed **/ this.horizontalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * this.turnSpeed * this.horizontalInput);
    }
}
