using UnityEngine;

public class NumberGenerator
{
    enum Operation
    {
        SUM,
        DIFF,
    }

    struct AnswerModel
    {
        public int correctAnswer;
        public int wrongAnswer1;
        public int wrongAnswer2;
    }

    public void GenerateQuestion()
    {
        GenerateFirstQuestion();
    }

    private (int wrongAnswer1, int wrongAnswer2) GenerateWrongAnswers(int correctAnswer)
    {
        int wrongAnswer1 = correctAnswer + Random.Range(1, 5);
        int wrongAnswer2 = correctAnswer - Random.Range(1, 5);

        return (wrongAnswer1: wrongAnswer1, wrongAnswer2: wrongAnswer2);
    }

    private AnswerModel GenerateFirstQuestion()
    {
        AnswerModel answerModelValues = new();

        int firstNumber = Random.Range(1, 16);
        int secondNumber = Random.Range(1, 16);

        answerModelValues.correctAnswer = firstNumber + secondNumber;
        var wrongValues = GenerateWrongAnswers(answerModelValues.correctAnswer);
        (answerModelValues.wrongAnswer1, answerModelValues.wrongAnswer2) = wrongValues;

        LogAllQuestionValues(firstNumber, secondNumber, Operation.SUM, answerModelValues);

        return answerModelValues;
    }

    private void LogAllQuestionValues(int firstNumber, int secondNumber, Operation operation, AnswerModel answerModelValues)
    {
        Debug.Log(
            firstNumber.ToString() + OperationStringHandler(operation) + secondNumber.ToString() +
            "\nCorrect answer: " + answerModelValues.correctAnswer.ToString() + "\n" +
            "Wrong answer 1: " + answerModelValues.wrongAnswer1.ToString() + "\n" +
            "Wrong answer 2: " + answerModelValues.wrongAnswer2.ToString()
        );
    }

    /// <summary>
    /// Returns the operation equivalent string.
    /// </summary>
    /// <param name="operation"></param>
    /// <returns></returns>
    private string OperationStringHandler(Operation operation)
    {
        switch (operation)
        {
            case Operation.SUM:
                return " + ";
            case Operation.DIFF:
                return " - ";
            default:
                return " ";
        }
    }
}
