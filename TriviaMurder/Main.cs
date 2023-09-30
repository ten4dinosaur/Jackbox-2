using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TriviaMurder
{
    public partial class Main : Form
    {
        private List<TriviaAnswers.TriviaQuestion> _currentQuestions;

        public Main()
        {
            InitializeComponent();
            _typeComboBox.SelectedIndex = 0;
        }

        private bool _ignoreUpdate = false;

        private void _searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                var allQuestions = (_typeComboBox.SelectedIndex == 0)
                    ? TriviaAnswers.Questions
                    : TriviaAnswers.FinalQuestions;

                var searchQuestions = new List<TriviaAnswers.TriviaQuestion>();
                var criteria = _searchTextBox.Text.Trim().ToLower();
                foreach (var question in allQuestions)
                {
                    if (question.Text.ToLower().Contains(criteria))
                        searchQuestions.Add(question);
                }
                _currentQuestions = searchQuestions;

                _questionComboBox.SuspendLayout();
                _ignoreUpdate = true;
                _questionComboBox.Items.Clear();
                foreach (var question in searchQuestions)
                    _questionComboBox.Items.Add(question.Text);
                if (searchQuestions.Count > 0)
                {
                    _questionComboBox.Enabled = true;
                    _questionComboBox.SelectedIndex = 0;
                }
                else
                {
                    _questionComboBox.Enabled = false;
                }

                _ignoreUpdate = false;
                _questionComboBox.PerformLayout();

                if (_questionComboBox.Enabled)
                    _questionComboBox_SelectedIndexChanged(null, null);
            }
        }

        private void _questionComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (_ignoreUpdate) 
                _answersTextBox.Clear();
            else
                _answersTextBox.Lines = _currentQuestions[_questionComboBox.SelectedIndex].Answers;
        }
    }
}
