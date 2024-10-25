//Script to make the camera follow the player//

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 5, -10);

    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
