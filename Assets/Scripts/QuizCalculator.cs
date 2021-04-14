using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    public float quiz1, quiz2, quiz3, quiz4, quiz5;
    public float quizSum;
    public float nQuizes = 5;
    public float quizAverage;
           
    // Start is called before the first frame update
    void Start()
    {
        quiz1 = Random.Range(0f, 100f);
        quiz1 = Random.Range(0f, 100f);
        quiz1 = Random.Range(0f, 100f);
        quiz1 = Random.Range(0f, 100f);
        quiz1 = Random.Range(0f, 100f);

        quizSum = (quiz1 + quiz2 + quiz3 + quiz4 + quiz5) * 100;
        quizAverage = (quizSum / nQuizes);

        Debug.Log("The average score of five quiz results is " + quizAverage.ToString("#.00") + "%.");
        Debug.Log("The average score of five quiz results is " + quizAverage.ToString("F2") + "%.");
        Debug.Log("The average score of five quiz results is " + quizAverage + "%.");
    }

}
