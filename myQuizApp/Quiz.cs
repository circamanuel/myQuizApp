namespace myQuizApp;

public class Quiz
{
    private Question[] _questions;
    private int _score;

    public Quiz(Question[] questions)
    {
        this._questions = questions;
        _score = 0;
    }

    public void startQuiz()
    {
        Console.WriteLine("Welcome to the Quiz!");
        int questionNumber = 1; // to display question numbers

        foreach (Question question in _questions)
        {
            Console.WriteLine($"Question {questionNumber++}");
            DisplayQuestion(question);
            int userChoice = GetUserChoice();
            if (question.isCorrectAnswer(userChoice))
            {
                _score++;
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"Wrong! The correct answer was: {question.Answers[question.CorrectAnswerIndex]}");
            }
        }
        DisplayResults();
    }

    private void DisplayResults()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("╔════════════════╗\n║     Result!    ║\n╚════════════════╝\n");
        Console.ResetColor();

        Console.WriteLine($"Quiz finished. Your score is: {_score} out of {_questions.Length}");
        double percentage = (double)_score / _questions.Length;
        if (percentage >= 0.8)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Excellent Work!");
        } else if (percentage >= 0.5)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Good effort!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Keep practicing!");
        }
        Console.ResetColor();
    }

    private void DisplayQuestion(Question question)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("╔════════════════╗\n║  ❓ QUESTION ❓  ║\n╚════════════════╝\n");
        Console.ResetColor();
        Console.WriteLine(question.QuestionText);

        for (int i = 0; i < question.Answers.Length; i++)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("  ");
            Console.Write(i + 1);
            Console.ResetColor();
            Console.WriteLine($". {question.Answers[i]}");
        }
    }

    private int GetUserChoice()
    {
        Console.Write("Your answer (number): ");
        string input = Console.ReadLine();
        int choice = 0;
        while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
        { 
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 4: ");
            input = Console.ReadLine();
        }

        return choice - 1; // adjust to 0-index array
    }
}