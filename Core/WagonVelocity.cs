using UnityEngine;

public class WagonVelocity : MonoBehaviour
{
    private Rigidbody2D _rb;
    
    [SerializeField] private static float _wagonXVelocity = -1f;
    public float WagonXVelocity
    {
        get
        {
            return _wagonXVelocity;
        }
        set
        {
            if (value <= -1f && value >= -3f)
            {
                _wagonXVelocity = value;
                _rb.velocity = new Vector2(_wagonXVelocity, 0);
            }
        }
    }

    private void Awake()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        _rb.velocity = new Vector2(_wagonXVelocity, 0);
    }
    private void OnEnable()
    {
        SceneConfig.WagonSpeedUp += () => WagonXVelocity -= 0.2f;
    }
    private void OnDisable()
    {
        SceneConfig.WagonSpeedUp -= () => WagonXVelocity -= 0.2f;
    }
}
