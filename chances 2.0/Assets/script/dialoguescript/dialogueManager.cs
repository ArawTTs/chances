using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class dialogueManager : MonoBehaviour
{
    public Text ActorName;
    public Text ActorMessage;
    public RectTransform backgroundbox;
    public Animator anim;

    Message[] currentMessages;
    Actor[] currentActors;
    int activeMessage = 0;
    public static bool IsActive = false;

    public void OpenDialogue(Message[] messages, Actor[] actors)
    {
        currentActors = actors;
        currentMessages = messages;
        activeMessage = 0;
        IsActive = true;
        Debug.Log("started a conversation loaded messages" + messages.Length);
        DisplayMessage();
        anim.SetBool("IsOpen", true);
    }

    void DisplayMessage()
    {
        Message messageToDisplay = currentMessages[activeMessage];
        ActorMessage.text = messageToDisplay.message;
        Actor actorToDipslay = currentActors[messageToDisplay.ActorID];
        ActorName.text = actorToDipslay.name;
    }

    public void NextMessage()
    {
        activeMessage++;
        if (activeMessage < currentMessages.Length)
        {
            DisplayMessage();
        }
        else
        {
            Debug.Log("conversation Ended");
            IsActive = false;
            anim.SetBool("IsOpen", false);
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && IsActive == true)
        {
            NextMessage();
        }
    }
}
