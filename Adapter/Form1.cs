using System;
using System.Windows.Forms;

namespace Adapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PreencherCbb();
        }

        public void PreencherCbb()
        {
            #region Sem Adapter
            Aparelho_cbb.Items.Add(new Lavadora());
            Aparelho_cbb.Items.Add(new Fatiadora());
            #endregion

            #region Com Adapter
            //Aparelho_cbb.Items.Add(new AdaptLavadora());
            //Aparelho_cbb.Items.Add(new AdaptFatiadora());
            #endregion
        }
        private void Ligar_btn_Click(object sender, EventArgs e)
        {
            #region Sem Adapter
            switch (Aparelho_cbb.SelectedItem.GetType().ToString())
            {
                case "Adapter.Fatiadora":
                    var fatiadora = (Fatiadora)Aparelho_cbb.SelectedItem;
                    acao_lbl.Text = fatiadora.Fatiar();
                    break;
                case "Adapter.Lavadora":
                    var lavadora = (Lavadora)Aparelho_cbb.SelectedItem;
                    acao_lbl.Text = lavadora.Lavar();
                    break;
            }
            #endregion

            #region Com Adapter
            //var aparelho = (IAparelho)Aparelho_cbb.SelectedItem;
            //acao_lbl.Text = aparelho.Ligar();
            #endregion
        }

    }

    #region Adapter
    interface IAparelho
    {
        string Ligar();
    }

    class AdaptFatiadora : Fatiadora , IAparelho
    {
        public string Ligar()
        {
            return this.Fatiar();
        }
    }

    class AdaptLavadora : Lavadora , IAparelho
    {
        public string Ligar()
        {
            return this.Lavar();
        }
    }
    #endregion

    class Fatiadora
    {
        public string Fatiar()
        {
            return "fatiando...";
        }
    }

    class Lavadora
    {
        public string Lavar()
        {
            return "lavando...";
        }
    }
}
