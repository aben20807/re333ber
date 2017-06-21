using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RE333BER
{
    public partial class FormCard : System.Windows.Forms.Form
    {
        private List<string> cardquestion = new List<string>();
        private List<string> cardanswer = new List<string>();
        private List<int> cardindex = new List<int>();
        private int index = 0;
        public FormCard()
        {
            InitializeComponent();
        }

        public FormCard(List<string> question,List<string> answer)
        {
            index = 0;
            InitializeComponent();
            cardquestion.AddRange(question);
            cardanswer.AddRange(answer);
            btncheck.Visible = false;
            btnrem.Visible = false;
            ans.Visible = false;
            btnshow.Visible = true;
            for (int i = 0; i < cardquestion.Count; i++)
            {
                cardindex.Add(i);
            }
                ask.Text = cardquestion.ElementAt(cardindex.ElementAt(0));
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            ans.Text = cardanswer.ElementAt(cardindex.ElementAt(index));
            ans.Visible = true;
            btnshow.Visible = false;
            btnrem.Visible = true;
            btncheck.Visible = true;
        }

        private void btnrem_Click(object sender, EventArgs e)
        {
       //     index++;
            if (index < cardindex.Count-1)
            {
                index++;
                ans.Visible = false;
                ask.Text = cardquestion.ElementAt(cardindex.ElementAt(index));
                btnrem.Visible = false;
                btnshow.Visible = true;
                btncheck.Visible = false;
            }
            else
            {
                cardquestion.Clear();
                cardanswer.Clear();
                cardindex.Clear();
                this.Dispose();
            }
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            cardindex.Add(index);
            btncheck.Visible = false;
            btnrem.Visible = false;
            btnshow.Visible = true;
            index++;
            if (index < cardindex.Count -1)
            {
                ans.Visible = false;
                ask.Text = cardquestion.ElementAt(cardindex.ElementAt(index));   
            }
        }

    }
}
