namespace myQuizApp;

class Program
{
    static void Main(string[] args)
    {
Question[] question = new Question[]
    {
        new Question("What is the capital of Germany",
            new string[] { "Paris", "Berlin", "London", "Madrid" },
            1),
        new Question("What is 2 + 2", 
            new string[] { "3", "4", "5", "6" },
            1),
        new Question("Who wrote 'Hamlet'", 
            new string[] {"Goethe", "Austen", "Shakespear", "Dickens"},
            2)
    };

        Quiz myQuiz = new Quiz(question);
        myQuiz.startQuiz();
    }
}