using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitControl : MonoBehaviour
{
    public float doorPositionOpen = 3f;
    public float doorPositionClosed = 0f;
    public float doorSpeedOpen = 4f;

    private bool isOpen = false;
    private Vector3 positionInitial;
    private Collider2D exitCollider;
    private SpriteRenderer exitSpriteRenderer;

    private GameManager gameManager;


    private void Start()
    {
        positionInitial = transform.position;
        doorPositionClosed = positionInitial.y;
        exitCollider = GetComponent<Collider2D>();
        exitSpriteRenderer = GetComponent<SpriteRenderer>();
        gameManager = FindObjectOfType<GameManager>();
    }
    public void OpenDoor()
    {
        if (!isOpen)
        {
        isOpen = true;
        MoveDoor();
    }
    }

    public void CloseDoor()
    {
        if (isOpen)
        {
        isOpen = false;
        MoveDoor();
    }
    }

    // Update is called once per frame
    private void MoveDoor()
    {
        float targetY = isOpen ? doorPositionOpen : doorPositionClosed;
        Vector3 positionTarget = new Vector3(transform.position.x, targetY, positionInitial.z);
    
        if (Mathf.Approximately(transform.position.y, targetY))
        {
            transform.position = positionTarget;
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, positionTarget, doorSpeedOpen * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.CompleteLevel();
        }
    }
}
