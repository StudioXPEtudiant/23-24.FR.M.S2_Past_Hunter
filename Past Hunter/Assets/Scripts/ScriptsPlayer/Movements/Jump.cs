using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private float forceJump = 500f;
    private bool Jumping = false;
    public Rigidbody rb;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Jumping == false)
        {
            rb.AddForce(Vector3.up * forceJump);

            Jumping = true;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            Jumping = false;
        }
    }
}