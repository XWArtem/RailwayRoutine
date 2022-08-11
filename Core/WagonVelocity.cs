using UnityEngine;

public class WagonVelocity : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] Vector2 _wagonVelocity;

    private void Awake()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        _rb.velocity = _wagonVelocity;
    }
}
