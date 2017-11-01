using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    Rigidbody2D rb2d;
    public float speed = 5f;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetAxisRaw("Vertical") != 0 || Input.GetAxisRaw("Horizontal") != 0)
        {
            DragControl(false);
            rb2d.AddForce(new Vector2(Input.GetAxisRaw("Horizontal") * speed, Input.GetAxisRaw("Vertical") * speed));
        }
        else
            DragControl(true);
    }

    void DragControl(bool wadup)
    {
        if (wadup)
            rb2d.drag = 10f;
        else
            rb2d.drag = 0f;
    }
}
