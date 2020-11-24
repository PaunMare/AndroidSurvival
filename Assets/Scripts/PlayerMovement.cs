using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    protected FixedJoystick joystick;
    protected Joybutton joybutton;
    public Rigidbody2D rb;
    public float moveSpeed;
    protected bool jump;
    public Transform shootingPosition;
    public GameObject bulletPrefab;
    private void Start()
    {
        joystick = FindObjectOfType<FixedJoystick>();
        joybutton = FindObjectOfType<Joybutton>();
    }
    private void Update()
    {
        rb.velocity = new Vector2(joystick.Horizontal * moveSpeed * Time.fixedDeltaTime, joystick.Vertical * moveSpeed * Time.fixedDeltaTime);
        Vector3 moveVector = (Vector3.up *joystick.Horizontal + Vector3.left * joystick.Vertical);
        if(!jump && joybutton.pressed)
        {
            jump = true;
            Shoot();
        }
        if(jump && !joybutton.pressed)
        {
            jump = false;
        }
        if(joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, moveVector);
        }
        void Shoot()
        {
            Instantiate(bulletPrefab, shootingPosition.position, shootingPosition.rotation);
        }
    }
}
