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
    private void Start()
    {
        joystick = FindObjectOfType<FixedJoystick>();
        joybutton = FindObjectOfType<Joybutton>();
    }
    private void Update()
    {
        rb.velocity = new Vector2(joystick.Horizontal * moveSpeed * Time.fixedDeltaTime, joystick.Vertical * moveSpeed * Time.fixedDeltaTime);
    }
}
