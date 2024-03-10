using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerdialogue : MonoBehaviour
{
    public dialoguetrigger trigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
                trigger.StartDialogue();
                
        }
    }
}
