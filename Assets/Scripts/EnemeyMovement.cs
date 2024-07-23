using UnityEngine;

public class EnemeyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Rigidbody2D enemyRigidBody;

    private GameObject target;

    private void Start()
    {
        target = GameObject.Find("Player");
    }

    void FixedUpdate()
    {
        Chase();
    }
    
    private void Chase() 
    {
        var direction = (target.transform.position - transform.position).normalized;
        enemyRigidBody.MovePosition(transform.position + direction * Time.deltaTime * moveSpeed);
    }

}
