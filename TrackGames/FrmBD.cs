using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackGames
{
    public partial class FrmBD : MaterialForm
    {
        public FrmBD()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            tbDB.Text = StringDB.GetDB();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(tbDB.Text != null && tbDB.Text != "")
            {
                StringDB.SetDB(tbDB.Text);
            }
        }

        private void btnPadrao_Click(object sender, EventArgs e)
        {
            StringDB.SetDB(@"Data Source=CELESTIA\SQLEXPRESS;Initial Catalog = GameTracker; Integrated Security = True;");
            tbDB.Text = StringDB.GetDB();
        }
    }
}
