using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NP_lab3
{
    public partial class Predictor : Form
    {
        public Predictor()
        {
            InitializeComponent();

           // PredictorLangs.Items.Add("ru");

            string[] kek;
            kek = Lang.GetLangs(PredictorKey.Text);

            PredictorLangs.BeginUpdate();

            for (int i = 0; i < kek.Length; i++)
            {
                PredictorLangs.Items.Add(kek[i].ToString());
            }

            PredictorLangs.EndUpdate();
        }

        private void Predict_Click(object sender, EventArgs e)
        {
            string key = PredictorKey.Text;
            string k = Lang.GetLangs(key).ToString();
            string[] b = Complete.CompleteWordAsync(PredictorInput.Text, key, PredictorLangs.Text, Convert.ToInt32(PredictorLimit.Text));

            for (int i = 0; i < b.Length; i++)
            {
                Hints.Items.Add(b[i].ToString());
            }
        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            Hints.Items.Clear();
            PredictorInput.Clear();
            PredictorLimit.Clear();
        }
    }
}