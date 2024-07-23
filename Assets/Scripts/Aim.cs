using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static UnityEngine.Rendering.DebugUI;

public class Aim : MonoBehaviour
{

    [SerializeField] GameObject bullet;
    [SerializeField] private float bulletInterval = 1f;

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);
        transform.up = direction;
    }

}
