using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    class Question
    {
        public string question { get; set; }
        public bool answer { get; set; }
        public Question(string q, bool a)
        {
            this.question = q;
            this.answer = a;
        }
    }

    class Quiz
    {
        public List<Question> questions;
        public int count { get; set; }
        public Quiz()
        {
            this.questions = new List<Question>
                {
                    new Question("Best computer Language - 'c++'",true),
                    new Question("Sharps - 'top'?",true),
                    new Question("It - step is the worst?",false),
                    new Question("Kostia toxic?",true),
                    new Question("Ia molodec?",false),
                };
        }
        public void AddQuestion(Question q)
        {
            this.questions.Add(q);
        }

        public void Run()
        {
            foreach (var item in questions)
            {
                DialogResult res = MessageBox.Show(item.question, "Question", MessageBoxButtons.YesNo);
                switch (res)
                {
                    case DialogResult.Yes:
                        if (item.answer)
                            this.count++;
                        break;
                    case DialogResult.No:
                        if (!item.answer)
                            this.count += 0;
                        break;
                }
            }
            DialogResult window = MessageBox.Show($"You have true ansvers: {this.count} form {questions.Count} questions" + MessageBoxButtons.RetryCancel);
            switch (window)
            {
                case DialogResult.Retry:
                    this.Run();
                    break;
                case DialogResult.Abort:
                    break;
            }


        }

    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            q.Run();
        }
        Quiz q = new Quiz();

    }
}
