using System;
using System.Windows.Forms;

namespace RamayanaQuest1
{
    public partial class RamayanaQuest1Form : Form
    {
        private int currentQuestionIndex;

        private Question[] questions;

        public RamayanaQuest1Form()
        {
            InitializeComponent();
            InitializeQuestions();
            ShowQuestion(0);
        }

        private void InitializeQuestions()
        {
            // Инициализация вопросов
            questions = new Question[]
            {
                new Question("Кто является главным героем Рамаяны?",
                    new string[] {
                        "Арджуна",
                        "Рама",
                        "Кришна",
                        "Индра"
                    },
                    1),
                new Question("Какое оружие использовал Рама для уничтожения Раваны?",
                    new string[] {
                        "Лук",
                        "Меч",
                        "Копье",
                        "Топор"
                    },
                    0),
                new Question("Кто помог Раме в его походе на Ланку?",
                    new string[] {
                        "Хануман",
                        "Брахма",
                        "Гаруда",
                        "Ханумати"
                    },
                    0),
                new Question("Кто является воплощением богини Лакшми и женой Рамы?",
                    new string[] {
                        "Сита",
                        "Савитри",
                        "Драупади",
                        "Радха"
                    },
                    0),
                new Question("Какой символ является признаком Раваны?",
                    new string[] {
                        "Десять голов",
                        "Девять голов",
                        "Восемь голов",
                        "Семь голов"
                    },
                    2)
            };
        }

        private void ShowQuestion(int questionIndex)
        {
            // Отображение текущего вопроса
            currentQuestionIndex = questionIndex;

            Question currentQuestion = questions[currentQuestionIndex];

            questionLabel.Text = currentQuestion.Text;

            optionAButton.Text = currentQuestion.Options[0];
            optionBButton.Text = currentQuestion.Options[1];
            optionCButton.Text = currentQuestion.Options[2];
            optionCButton.Text = currentQuestion.Options[3];
        }

        private void CheckAnswer(int answerIndex)
        {
            // Проверка выбранного ответа
            Question currentQuestion = questions[currentQuestionIndex];

            if (answerIndex == currentQuestion.CorrectOption)
            {
                MessageBox.Show("Правильный ответ!");
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }

            // Переход к следующему вопросу
            if (currentQuestionIndex < questions.Length - 1)
            {
                ShowQuestion(currentQuestionIndex + 1);
            }
            else
            {
                MessageBox.Show("Квест завершен!");
                Application.Exit();
            }
        }

        private void optionAButton_Click(object sender, EventArgs e)
        {
            CheckAnswer(0);
        }

        private void optionBButton_Click(object sender, EventArgs e)
        {
            CheckAnswer(1);
        }

        private void optionCButton_Click(object sender, EventArgs e)
        {
            CheckAnswer(2);
        }

        private void optionDButton_Click(object sender, EventArgs e)
        {
            CheckAnswer(3);
        }
    }

    public class Question
    {
        public string Text { get; private set; }
        public string[] Options { get; private set; }
        public int CorrectOption { get; private set; }

        public Question(string text, string[] options, int correctOption)
        {
            Text = text;
            Options = options;
            CorrectOption = correctOption;
        }
    }
}