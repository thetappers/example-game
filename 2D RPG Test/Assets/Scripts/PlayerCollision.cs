using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour {

    public DialogueTrigger horatio;
    public DialogueTrigger lola;
    public DialogueTrigger npcs;
    public QuestGiver questGiver;
    public Quest quest;
    public QuestGoal goal;
    //public GameObject[] npcs;

 

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "NPC-Horatio")
        {
            horatio.TriggerDialogue();
            Debug.Log(collision.collider.name);
        }
        if (collision.collider.name == "NPC-Lola")
        {
            //lola.TriggerDialogue();
            if (quest.isActive == false)
            {
                questGiver.OpenQuestWindow();
            }
            if (quest.isActive == false && goal.IsReached() == true)
            {
                //Open Dialogue and complete
            }
        }
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        FindObjectOfType<DialogueManager>().EndDialogue();
        FindObjectOfType<QuestGiver>().CloseQuestWindow();
    }
}
