using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    [SerializeField] private GameObject exit;

    private ExitControl exitControl;

   
    public bool beingPressed = false;
    private SpriteRenderer exitSpriteRenderer;
    private Collider2D exitCollider;



    public void Start()
    {
        exitSpriteRenderer = exit.GetComponent<SpriteRenderer>();
        exitCollider = exit.GetComponent<Collider2D>();
        exitControl = exit.GetComponent<ExitControl>();
    }
    /* public Collider2D exitDoorCollider;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Box"))
        {
            OpenExitDoor();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Box"))
        {
            CloseExitDoor();
        }
    }

    private void OpenExitDoor()
    {
        exitDoorCollider.enabled = false;
    }
    private void CloseExitDoor()
    {
        exitDoorCollider.enabled = true;
    } */

    public void PressButton()
    {
        beingPressed = true;
        exitControl.OpenDoor();
    }
    
    public void ReleaseButton()
    {
        beingPressed = false;
        exitControl.CloseDoor();
    }
    
    private void OpenExit()
    {
        exitSpriteRenderer.enabled = false;
        exitCollider.enabled = false;
    }

    private void CloseExit()
    {
        exitSpriteRenderer.enabled = true;
        exitCollider.enabled = true;
    }

 public bool IsBeingPressed()
 {
    return beingPressed;
 }
}