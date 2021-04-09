using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode jumpKey;

    public float speed = 10f;

    void Update()
    {
        Vector3 pos = transform.position;

        // "w" can be replaced with any key
        // this section moves the character up
        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }

        // "s" can be replaced with any key
        // this section moves the character down
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }

        // "d" can be replaced with any key
        // this section moves the character right
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }

        // "a" can be replaced with any key
        // this section moves the character left
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }

        // this section moves the character diagonally U+L/R
        if (Input.GetKey("q") || Input.GetKey("e"))
        {
            if (Input.GetKey("q"))
            {
                pos.x -= speed * Time.deltaTime;
            }
            else
            {
                pos.x += speed * Time.deltaTime;
            }
            pos.y += speed * Time.deltaTime;
        }

        // this section moves the character diagonally U+L/R
        if (Input.GetKey("z") || Input.GetKey("c"))
        {
            if (Input.GetKey("z"))
            {
                pos.x -= speed * Time.deltaTime;
            }
            else
            {
                pos.x += speed * Time.deltaTime;
            }
            pos.y -= speed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
