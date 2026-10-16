using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using up02.MyClass;

namespace up02.MyForms
{
    public partial class EditMaterial : Form
    {
        public EditMaterial()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButtom_Click(object sender, EventArgs e)
        {

        }

        private void EditMaterial_Load(object sender, EventArgs e)
        {
            MyClass.MyProd.GetMaterialTypes();


            TypeMaterial.DataSource = MyClass.DBConnection.dtMaterialType;
            TypeMaterial.DisplayMember = "ТипМатериала";
            TypeMaterial.ValueMember = "КодТипа";
            TypeMaterial.SelectedIndex = -1;

            while (TypeMaterial.Text != MyClass.Config.materialType)
            {
                TypeMaterial.SelectedIndex += 1;
                System.Windows.Forms.MessageBox.Show($"'{TypeMaterial.Text}' и '{MyClass.Config.materialType}'");
            }

            MyClass.MyProd.GetMaterialUnits();

            TypeMaterial.DataSource = MyClass.DBConnection.dtUnit;
            TypeMaterial.DisplayMember = "Единица";
            TypeMaterial.ValueMember = "КодИзмерения";
            TypeMaterial.SelectedIndex = -1;
        }

        private void PriceMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ColMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void MinColMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
