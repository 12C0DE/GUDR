using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GU_DR_CSHRP
{

    enum JobType
    {
        Patch, Partial, Full
    }
    public partial class Form1 : Form
    {
        dbConn cmd;
        const int catBoxWidth = 80;
        const int materialAmount = 12;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "";
            Dictionary<int, string> makeList = new Dictionary<int, string>();
            Dictionary<int, string> sideList = new Dictionary<int, string>();
            Dictionary<int, string> materialList = new Dictionary<int, string>();
            bool connSuccess;

            cmd = new dbConn();
            
            connSuccess = cmd.conn2DB();

            if (!connSuccess)
            {
                MessageBox.Show("Error accesing Database");
                return;
            }

            //creating the MAKE combobox ----------------
            sql = "SELECT make_key, make FROM tbl_make ORDER BY make";
            makeList = cmd.ReadAndReturnKeyVal(sql);

            cbMake.DataSource = new BindingSource(makeList, null);
            cbMake.DisplayMember = "Value";
            cbMake.ValueMember = "Key";
            cbMake.SelectedIndex = -1;
            // ----------------

            //creating the side list  ----------------
            sql = "SELECT side_key, side FROM tbl_categorysides ORDER BY side";
            sideList = cmd.ReadAndReturnKeyVal(sql);
            // ----------------

            //creating the material list  ----------------
            sql = "SELECT material_key, material_name FROM tbl_material ORDER BY material_name";
            materialList = cmd.ReadAndReturnKeyVal(sql);
            // ----------------

            //enter years for cbYear. From 1908 to current year (1908 was the year the Model T was made)
            for (int sYear = DateTime.Today.Year; sYear >= 1908; sYear--)
            {
                cbYear.Items.Add(sYear);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cmd.closeDB();
        }

        private void cbMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMake.SelectedIndex == -1 || cbMake.SelectedValue == null)
            {
                cbModel.DataSource = null;
                return;
            }

            string sql;
            KeyValuePair<int, string> make = new KeyValuePair<int, string>() ;

            cbModel.SelectedIndex = -1;
            cbModel.DataSource = null;

            make = (KeyValuePair<int, string>)cbMake.SelectedItem;
            Dictionary<int, string> modelList = new Dictionary<int, string>();

            sql = $"SELECT model_key, model_name FROM tbl_model WHERE make_key = {make.Key} ORDER BY model_name";
            modelList = cmd.ReadAndReturnKeyVal(sql);

            cbModel.DataSource = new BindingSource(modelList, null);
            cbModel.DisplayMember = "Value";
            cbModel.ValueMember = "Key";
            cbModel.SelectedIndex = -1;
        }

        private void cbMake_TextChanged(object sender, EventArgs e)
        {
            cbContains(cbMake, btnAddMake);
        }

        //this is where historical job data will begin. 
        private void cbModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cbModel_TextChanged(object sender, EventArgs e)
        {
            if (cbMake.SelectedIndex == -1)
            {
                return;
            }
            cbContains(cbModel, btnAddModel);
        }
        private void btnPatch_Click(object sender, EventArgs e)
        {
            BtnJobHiLite(JobType.Patch);
        }

        private void btnPartial_Click(object sender, EventArgs e)
        {
            BtnJobHiLite(JobType.Partial);
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            string sql;
            List<Category> listCategory = new List<Category>();

            BtnJobHiLite(JobType.Full);

            //remove all controls within this panel
            panelCategory.Controls.Clear();

            //reset category row count
            Category.resetCatRowCount();

            //display all categories
            sql = "SELECT DISTINCT a.category_key, a.category_name FROM tbl_category a INNER JOIN tbl_subcategory b ON a.category_key = b.category_key ORDER BY a.category_key";

            listCategory = cmd.ReadandReturnCat(sql);

            for (int cat = 0; cat < listCategory.Count; cat++)
            {
                List<SubCategory> listSubCat = new List<SubCategory>();

                //create category label
                sql = $"SELECT subCat_key, subcategory FROM tbl_subcategory WHERE category_key = {listCategory[cat].getCatKey()}";

                listSubCat = cmd.ReadAndReturnSubcat(sql, listCategory[cat]);

            }
        }

        private void cbContains(ComboBox cb, Button btn)
        {
            foreach (KeyValuePair<int, string> item in cb.Items)
            {
                if (item.Value.ToUpper().StartsWith(cb.Text.ToUpper()))
                {
                    btn.Visible = false;
                    return;
                }
            }
            btn.Visible = true;
        }

        private void InsertPanelCtrlHeading(Category category, int ctrlLoc)
        {
            //create category label
            Label lblCatName = new Label();

            lblCatName.Name = category.getCatKey().ToString();
            lblCatName.Text = category.getCatName();

            panelCategory.Controls.Add(lblCatName);
            lblCatName.Location = new Point(15, ctrlLoc);
        }

        private void InsertPanelCtrlSub(SubCategory subcat, int ctrlLoc)
        {
            Label lblSubCat = new Label();
            Label lblSide = new Label();
            Label lblDimensions = new Label();
            Label lblMaterial = new Label();
            Label lblCost = new Label();
            Label lblSubCost = new Label();
            ComboBox cbSide = new ComboBox();

        }

        private TextBox createTBDimW(string id)
        {
            TextBox tb = new TextBox();

            tb.Name = id;
            tb.Width = catBoxWidth / 2;

            
        }

        private void dimWtxtChanged(System.Object sender, EventArgs e)
        {
            TextBox tb;
            TextBox tbH;
            int subCatKey, curRow;
            string sql = "";
            Double matCost, subCost = 0.0;
            string widthTxt, heightTxt;
            int matKey;

            tb = (TextBox)sender;

            subCatKey = int.Parse(extractSubCatKey(tb.Name));
            curRow = int.Parse(extractRow(tb.Name));

            tbH = panelCategory.Controls.Find("tbH/" + subCatKey + "_" + curRow, true).FirstOrDefault() as TextBox;

            ComboBox cbMat = panelCategory.Controls.Find("lblSubCost/" + subCatKey + "_" + curRow, true).FirstOrDefault() as ComboBox;

            try
            {
                matKey = (int)cbMat.SelectedValue;
            }
            catch
            {
                matKey = 0;
            }

            //TODO: Figure material cost. Calculate cost of subcategory. Calculate total cost
            
        }

        private Double calcDimensionCost(Double matCost, string width, string height)
        {
            Double dimensions = 0.0;
            Double subCost = 0.0;
            Double W, H = 0.0;

            try
            {
                W = Double.Parse(width);
            } catch
            {
                W = 0.0;
            }

            try
            {
                H = Double.Parse(height);
            } catch
            {
                H = 0.0;
            }

            dimensions = W * H;

            subCost = (dimensions / materialAmount) * matCost;

            return subCost;
        }

        private string extractSubCatKey(string ID)
        {
            string subCat;

            subCat = ID.Substring(4, ID.IndexOf("_") - 5);

            return subCat;
        }

        private string extractRow(string ID)
        {
            string curRow;

            curRow = ID.Remove(0, ID.IndexOf("_"));

            return curRow;
        }

        private void BtnJobHiLite(JobType jType)
        {
            btnPatch.BackColor = DefaultBackColor;
            btnPatch.ForeColor = DefaultForeColor;
            btnPartial.BackColor = DefaultBackColor;
            btnPartial.ForeColor = DefaultForeColor;
            btnFull.BackColor = DefaultBackColor;
            btnFull.ForeColor = DefaultForeColor;

            switch (jType)
            {
                case JobType.Patch:
                    btnPatch.BackColor = Color.Green;
                    btnPatch.ForeColor = Color.White;
                    break;
                case JobType.Partial:
                    btnPartial.BackColor = Color.Green;
                    btnPartial.ForeColor = Color.White;
                    break;
                case JobType.Full:
                    btnFull.BackColor = Color.Green;
                    btnFull.ForeColor = Color.White;
                    break;
            }        
        }
    }
}


