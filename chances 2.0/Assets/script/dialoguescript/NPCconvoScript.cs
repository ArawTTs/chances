using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCconvoScript : MonoBehaviour
{
    public dialoguetrigger trigger;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Check if the specified key is pressed
            if (Input.GetKeyDown(KeyCode.E) == true)
            {
                trigger.StartDialogue();
                
                
            }
        }
    }
}
