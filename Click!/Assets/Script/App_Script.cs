using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App_Script : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 ScreenBounds;
    public float speed = 5.0f;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
        ScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }
    void Open_App()
    {
        if ((Input.GetMouseButtonDown(0) && (Pause_Menu_Script.GameIsPaused == false)))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject == gameObject)
                {
                    Destroy(gameObject);
                    Score_Script.scoreValue += 1;
                }

            }
        }
    }
    void Skipping_App()
    {
        if (transform.position.y < ScreenBounds.y * -1.2)
        {

            Time.timeScale = 0f;
            Destroy(this.gameObject);
            Pause_Menu_Script.GameIsLost = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        Open_App();
        Skipping_App();
    }
}
