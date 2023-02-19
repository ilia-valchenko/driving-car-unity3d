using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 4.6f, -10.3f);

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset the camera behind the player.
        transform.position = this.player.transform.position + this.offset;
    }
}
