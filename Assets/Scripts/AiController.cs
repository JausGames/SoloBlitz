using UnityEngine;

public class AiController : MonoBehaviour
{
    [SerializeField] float speed = 10.0f;
    private PlayerController player;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        Vector3 direction = Vector3.Normalize(player.transform.position - transform.position);
        direction.y = 0;
        rb.AddForce(direction * speed * Time.deltaTime);
    }
}
