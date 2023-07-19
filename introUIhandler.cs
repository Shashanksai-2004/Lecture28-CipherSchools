using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introUI : MonoBehaviour
{
   public GameObject instructionPanel;

   public void ToggleInstructionPanel(int toggle)
   {
        if(toggle == 1)
        {
            instructionPanel.SetActive(false);
        }
        else
        {
            instructionPanel.SetActive(true);
        }
   }
}
