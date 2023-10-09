
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] public Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * Time.fixedDeltaTime * 50,0, Input.GetAxis("Vertical") * 50 * Time.fixedDeltaTime);

    }
}
