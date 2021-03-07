using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private GameObject okButtonObj;
    public Question[] questions;
    public Animator animator;
    public int index;

    [SerializeField]
    private Text question;
    [SerializeField]
    private Text optionA;
    [SerializeField]
    private Text optionB;
    [SerializeField]
    private Text feedback;
    [SerializeField]
    private Text result;

    private string answer;

    void Start()
    {
        okButtonObj = GameObject.Find("Ok_Button");
        okButtonObj.SetActive(false);

        index = ItemCollision.index;

        question.text = questions[index].question;
        optionA.text = questions[index].optionA;
        optionB.text = questions[index].optionB;
    }

    public void GetAnswerA()
    {
        answer = "A";
        GetAnswer();
    }

    public void GetAnswerB()
    {
        answer = "B";
        GetAnswer();
    }

    void GetAnswer()
    {

        if (answer.Equals(questions[index].answer))
        {
            ScoreSystem.scorePoints++;
            result.text = "Correto!";
            animator.SetInteger("Result", 1);
        }
        else
        {
            ScoreSystem.playerLifes--;
            result.text = "Errado!";
            animator.SetInteger("Result", 2);
        }

        Destroy(GameObject.Find("Option_A"));
        Destroy(GameObject.Find("Option_B"));

        StopAllCoroutines();
        StartCoroutine(TypeSentence(questions[index].feedback));

    }

    IEnumerator TypeSentence(string sentence)
    {
        feedback.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            feedback.text += letter;
            yield return null;
        }
        okButtonObj.SetActive(true);
    }

    public void OkButton()
    {
        animator.SetInteger("Result", 0);
        SceneManager.LoadScene("Level" + MapManager.load);
    }
}
