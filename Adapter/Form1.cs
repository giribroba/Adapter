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
            Aparelho_cbb.Items.Add(new Lavadora());
            Aparelho_cbb.Items.Add(new Fatiadora());
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

            #region Com Adapter;
            //IAparelho aparelho = new Adapter(Aparelho_cbb.SelectedItem);
            //acao_lbl.Text = aparelho.Ligar();
            #endregion
        }

    }

    #region Adapter
    interface IAparelho
    {
        string Ligar();
    }

    class Adapter : IAparelho
    {
        object aparelho;
        public Adapter(object aparelho)
        {
            this.aparelho = aparelho;
        }

        public string Ligar()
        {
            switch (aparelho.GetType().ToString())
            {
                case "Adapter.Fatiadora":
                    var fatia = (Fatiadora)aparelho;
                    return fatia.Fatiar();
                    break;
                case "Adapter.Lavadora":
                    var lava = (Lavadora)aparelho;
                    return lava.Lavar();
                    break;
            }

            return "Aparelho incompatível";

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
