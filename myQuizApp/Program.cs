namespace myQuizApp;

class Program
{
    static void Main(string[] args)
    {
        Question[] question = new Question[]
        {
            new Question("What is the capital of Germany",
                new string[] { "Paris", "Berlin", "London", "Madrid" },
                1)
        };

        Quiz myQuiz = new Quiz(question);
        myQuiz.DisplayQuestion(question[0]);
    }
}