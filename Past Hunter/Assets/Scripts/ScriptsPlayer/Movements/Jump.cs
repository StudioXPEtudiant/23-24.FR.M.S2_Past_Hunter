using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private float forceJump = 500f;
    private bool jumping = false;
    public Rigidbody rb;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumping == false)
        {
            rb.AddForce(Vector3.up * forceJump);

            jumping = true;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            jumping = false;
        }
    }
}