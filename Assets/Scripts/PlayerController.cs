using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 10.0f;
    public Vector2 move;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.AddForce(new Vector3(move.x, 0, move.y) * speed * Time.deltaTime);
    }


    public void Juke()
    {
        // code to implement the juke move
    }

    public void Spin()
    {
        // code to implement the spin move
    }

    public void StiffArm()
    {
        // code to implement the stiff arm move
    }

    public void Dive()
    {
        // code to implement the dive move
    }

    public void Fake()
    {
        // code to implement the fake move
    }

    public void CutBack()
    {
        // code to implement the cutback move
    }

    public void Hurdle()
    {
        // code to implement the hurdle move
    }
}
