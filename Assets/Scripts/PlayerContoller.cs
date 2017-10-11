using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    private Rigidbody2D _playerRigidbody2D;
    public float Speed;
    // Use this for initialization
    void Awake()
    {
        _playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") > 0.1f)
        {
            _playerRigidbody2D.velocity = new Vector2(Speed, 0);
        }
        else if (Input.GetAxis("Horizontal") < -0.1f)
        {
            _playerRigidbody2D.velocity = new Vector2(-Speed, 0);
        }
        else if (Input.GetAxis("Vertical") > 0.1f)
        {
            _playerRigidbody2D.velocity = new Vector2(0, Speed);
        }
        else if (Input.GetAxis("Vertical") < -0.1f)
        {
            _playerRigidbody2D.velocity = new Vector2(0, -Speed);
        }

    }
}
