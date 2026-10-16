using System;
using System.Data;
using System.Windows.Forms;
using up02.MyClass;

namespace up02
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!DBConnection.ConnectDB())
            {
                Close();
                return;
            }

            //DataTable types = MyProd.GetMaterialTypes();
            //typeComboBox.DataSource = types;
            //typeComboBox.DisplayMember = "ТипМатериала";
            //typeComboBox.ValueMember = "КодТипа";
            //typeComboBox.SelectedIndex = -1;

            //if (sortComboBox.Items.Count > 0)
            //{
            //    sortComboBox.SelectedIndex = 0;
            //}

            RefreshMaterials();
        }

        //private void searchTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    RefreshMaterials();
        //}

        //private void buttonFilter_Click(object sender, EventArgs e)
        //{
        //    RefreshMaterials();
        //}

        //private void buttonResetFilter_Click(object sender, EventArgs e)
        //{
        //    searchTextBox.Text = "";
        //    typeComboBox.SelectedIndex = -1;
        //    if (sortComboBox.Items.Count > 0)
        //    {
        //        sortComboBox.SelectedIndex = 0;
        //    }

        //    RefreshMaterials();
        //}

        private void RefreshMaterials()
        {
            //int typeId = null;

            MyProd.ShowMaterials(materialsPanel, "", null, false);

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            DBConnection.CloseDB();
            base.OnFormClosed(e);
        }
    }
}