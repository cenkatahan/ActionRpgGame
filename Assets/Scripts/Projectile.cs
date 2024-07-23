using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private Rigidbody2D rigidbody2D;


    private void Update()
    {
        rigidbody2D.velocity = new Vector2(0f, speed);
    }
}
