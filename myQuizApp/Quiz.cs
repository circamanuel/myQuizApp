namespace myQuizApp;

public class Quiz
{
    private Question[] questions;

    public Quiz(Question[] questions)
    {
        this.questions = questions;
    }

    public void DisplayQuestion(Question question)
    {
        Console.WriteLine(question.QuestionText);
    }
}
