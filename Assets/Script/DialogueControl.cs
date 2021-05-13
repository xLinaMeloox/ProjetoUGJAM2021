using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 public class DialogueControl : MonoBehaviour
{
    [Header("Components")]
    public GameObject dialogieObj;
    public Image profile;
    public Text speechText;
    public Text actorNameText;

    [Header("Settings")]
    public float typingSpeed;
    private string[] sentenses;
    private int index;

    public GameObject vida;





    public void Speech(Sprite p, string[] txt, string actorName)
    {
        dialogieObj.SetActive(true);
        profile.sprite = p;
        sentenses = txt;
        actorNameText.text = actorName;
        StartCoroutine(TypeSentecence());
        
    }

    IEnumerator TypeSentecence()
    {
        foreach (var letter in sentenses[index].ToCharArray())
        {
            speechText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
         
        }
    }

    public void NextSentence()
    {
        if (speechText.text==sentenses[index])
        {
            if (index < sentenses.Length - 1)
            {
                index++;
                speechText.text = "";
                StartCoroutine(TypeSentecence());
                
                
            }
            else
            {
                speechText.text = "";
                index = 0;
                dialogieObj.SetActive(false);
                vida.gameObject.SetActive(true);

            }
        }
    }

}
