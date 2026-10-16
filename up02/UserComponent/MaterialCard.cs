using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using up02.MyForms;

namespace up02.UserComponent
{
    public partial class MaterialCard : UserControl
    {
        public MaterialCard(DataRow material)
        {
            InitializeComponent();

            int materialId = Convert.ToInt32(material["КодМатериала"]);

            labelName.Text = $"{material["ТипМатериала"]} | {material["Наименование"]}";

            labelDetails.Text = $"Минимальное количество: {material["МинимальноеКоличество"]} {material["ЕдиницаИзмерения"]}\n" +
                                $"Количество на складе:   {material["КоличествоНаСкладе"]} {material["ЕдиницаИзмерения"]}\n" +
                                $"Количество в упаковке:  {material["КоличествоВУпаковке"]}\n" +
                                $"Цена: {Convert.ToDecimal(material["Цена"]):N2} р / Единица измерения: {material["ЕдиницаИзмерения"]}";

            labelType.Text = $"{material["ТипМатериала"]}";
            labelMinCol.Text = $"{material["МинимальноеКоличество"]}";
            labelCol.Text = $"{material["КоличествоНаСкладе"]}";
            labelUpokovka.Text = $"{material["КоличествоВУпаковке"]}";
            labelPrice.Text = $"{Convert.ToDecimal(material["Цена"]):N2}";
            labelShortage.Text = GetStockStatus(material);

            labelHiddenId.Text = materialId.ToString();

            LoadImage(pictureBoxImage, Convert.ToString(material["Фото"]));
        }

        private static string GetStockStatus(DataRow row)
        {
            int stock = Convert.ToInt32(row["КоличествоНаСкладе"]);
            int minimum = Convert.ToInt32(row["МинимальноеКоличество"]);
            int cena = Convert.ToInt32(row["Цена"]);

            if ((minimum - stock) < 0)
            {
                return $"Стоимость партии: {0 * cena} р";
            }
            return $"Стоимость партии: {(minimum - stock) * cena} р";
        }

        private void LoadImage(PictureBox target, string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                return;
            }

            using Image source = Image.FromFile(path);
            target.Image = new Bitmap(source);
        }

        private void labelShortage_Click(object sender, EventArgs e)
        {
            MyClass.Config.materialType = labelType.Text;
            EditMaterial editMaterial = new EditMaterial();
            editMaterial.ShowDialog();


        }
    }
}