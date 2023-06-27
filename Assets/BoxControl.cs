using UnityEngine;

public class BoxControl : MonoBehaviour
{
   /* public GameObject button;
    public Vector2 boxOffset = new Vector2(0f, 0.5f);

    private bool onButton = false; */
    
    private ButtonControl buttonControl;
    
    private Rigidbody2D rigbod;

    private void Start()
    {
        rigbod = GetComponent<Rigidbody2D>();
        buttonControl = FindObjectOfType<ButtonControl>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Button"))
        {
            buttonControl.PressButton();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Button"))
        {
            buttonControl.ReleaseButton();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Button") && buttonControl.IsBeingPressed())
        {
            buttonControl.PressButton();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Button"))
        {
            buttonControl.ReleaseButton();
        }
    }
   // {
     //   if (collision.gameObject == button)
      //  {
      //      onButton = true;
     //   }
  //  }

   /* private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject == button)
        {
            onButton = false;
        }
    }
  
    // Update is called once per frame
    void Update()
    {
        if (onButton)
        {
            transform.position = button.transform.position + (Vector3)boxOffset;
        }
    } */
}
 