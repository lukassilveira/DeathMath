using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersManager : MonoBehaviour
{
    private NumberGenerator numberGenerator;

    private void Awake()
    {
        numberGenerator = new();
        numberGenerator.GenerateQuestion();
    }

    public void GenerateQuestion()
    {
        numberGenerator.GenerateQuestion();
    }
}
