using UnityEngine;
using UnityEngine.InputSystem;

public class paddleMove : MonoBehaviour
{

    private float _direction;
    public float moveSpeed;
    public float minX, maxX;

    public void OnMove(InputValue value)
    {
        _direction = value.Get<float>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float newX = transform.position.x + (_direction * moveSpeed * Time.deltaTime);
        float clampedX = Mathf.Clamp(newX, minX, maxX);
        transform.position = new Vector3(clampedX, 0, 0);
    }
}
