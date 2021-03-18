using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogManager : MonoBehaviour
{
    public Text dialogText;
    public GameObject dialogPanel;
    public GameObject nextButtonObj;
    private Queue<string> sentences;
    
    void Start()
    {
        
        sentences = new Queue<string>();
        FindObjectOfType<DialogTrigger>().TriggerDialog();

    }

    public void StartDialog(Dialog dialog)
    {

        dialogPanel.SetActive(true);

        sentences.Clear();

        foreach (string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        nextButtonObj = GameObject.Find("Next");
        nextButtonObj.SetActive(false);

        if (sentences.Count == 0)
        {
            EndDialog();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogText.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            dialogText.text += letter;
            yield return null;
        }
        nextButtonObj.SetActive(true);
    }

    void EndDialog()
    {
        SceneManager.LoadScene("Map");
    }
}
