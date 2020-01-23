using MetroFramework.Forms;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IdGenerator
{
    public partial class MainMenu : MetroForm
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        DataTable mainDt = new DataTable();
        String FrameShape = "boxed";
        String FrameColor = "blue";
        String TextColor = "blue";
        Boolean isdateShort = true;
        String imageFramePath = "boxedwhite.png";
        String imageAddNewPath = "";
        String themePath = "";
        private void imageName()
        {
            if (FrameShape.Equals("none"))
            {
                imageFramePath = "boxedwhite.png";
            }
            else
            {
                imageFramePath = FrameShape + FrameColor + ".png";
            }
        }

        public MainMenu()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            mainDt.Columns.Add("Full Name", typeof(string));
            mainDt.Columns.Add("Id", typeof(string));
            mainDt.Columns.Add("DOB", typeof(string));
            mainDt.Columns.Add("path", typeof(string));
            refreshDataGrid();
            setSettings();
            textRowNumber.Visible = false;
        }
        private void setSettings()
        {
            lblFrameColor.Text = "Frame Color :" + FrameColor;
            lblShape.Text = "Frame Color :" + FrameShape;
            lblTextColor.Text = "Frame Color :" + TextColor;
            if (isdateShort)
            {
                metroToggleDate.Checked = true;
            }
            lblShortDate.Text = "Is Date Short : " + isdateShort.ToString();
        }
        private void refreshDataGrid()
        {
            dataGridView1.DataSource = mainDt;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Refresh();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtUpdateFullName.Text = row.Cells[0].Value.ToString();
                txtUpdateNatId.Text = row.Cells[1].Value.ToString();
                updateDate.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
                if (File.Exists(row.Cells[3].Value.ToString()))
                {
                    this.pictureBox2.Image = Bitmap.FromFile(row.Cells[3].Value.ToString());
                }
                textRowNumber.Text = e.RowIndex.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string updateQuery = "update idcard.student set name='" + this.txtUpdateFullName.Text + "',DOB='" + this.updateDate.Text + "' where Srnno='" + this.txtUpdateNatId.Text + "';";   
           // string updateQuery = "UPDATE idcard.student SET name = '" + txtUpdateFullName.Text + "',  DOB = " + updateDate.Text +
              //  " WHERE Srnno=" + txtUpdateNatId.Text ;
            connection.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(updateQuery, connection);
                if (int.Parse(textRowNumber.Text) >= 0)
                {
                    Boolean state = true;
                    StringBuilder errors = new StringBuilder();
                    if (txtUpdateFullName.Text.Length < 3)
                    {
                        state = false;
                        errors.Append("Name should be greater than 3 characters").AppendLine();
                    }
                    if (txtUpdateFullName.Text.Length > 30)
                    {
                        state = false;
                        errors.Append("Name should be less than 30 characters").AppendLine();
                    }


                    if (txtUpdateNatId.Text.Length < 3)
                    {
                        state = false;
                        errors.Append("SRN id should be greater than 3 characters").AppendLine();
                    }
                    if (txtUpdateNatId.Text.Length > 30)
                    {
                        state = false;
                        errors.Append("SRN id should be less than 30 characters").AppendLine();
                    }

                    if (updateDate.Value.Year >= DateTime.Now.Year)
                    {
                        state = false;
                        errors.Append("Year should be less this year").AppendLine();
                    }

                    if (command.ExecuteNonQuery() == 1 && state)
                    {
                        mainDt.Rows[int.Parse(textRowNumber.Text)]["Full Name"] = txtUpdateFullName.Text;
                        mainDt.Rows[int.Parse(textRowNumber.Text)]["Id"] = txtUpdateNatId.Text;
                        mainDt.Rows[int.Parse(textRowNumber.Text)]["DOB"] = updateDate.Value.ToLongDateString();

                        txtUpdateFullName.Clear();
                        txtUpdateNatId.Clear();
                        textRowNumber.Clear();

                    }
                    else
                    {
                        MessageBox.Show(errors.ToString());
                    }
                }

                else
                {
                    MessageBox.Show("Select Row First");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();

        }

        private void metroLinkUpdate_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Title = "Select Student Image";
            openFD.FileName = "";
            openFD.Filter = "Image File|*.jpg;*.png;*.jpeg";

            if (openFD.ShowDialog() != DialogResult.Cancel)
            {

            }
            else
            {
                MessageBox.Show("Please select user image ");
                return;
            }
            try
            {
                if (int.Parse(textRowNumber.Text) >= 0)
                {
                    mainDt.Rows[int.Parse(textRowNumber.Text)]["path"] = openFD.FileName;
                    if (File.Exists(openFD.FileName))
                    {
                        this.pictureBox2.Image = Bitmap.FromFile(openFD.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteQuery = "delete from idcard.student where Srnno='" + this.txtUpdateNatId.Text + "';";

            //string deleteQuery = "DELETE FROM idcard.student WHERE Srnno = " + txtUpdateNatId.Text;
            connection.Open();
            MySqlCommand command = new MySqlCommand(deleteQuery, connection);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    foreach (DataRow dr in mainDt.Rows)
                    {
                        if (dr["Id"].ToString() == txtUpdateNatId.Text)
                        {
                            dr.Delete();
                        }
                    }
                    mainDt.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textRowNumber.Clear();
            refreshDataGrid();
        }


        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            imageName();

            if(themePath.Length <= 4 ){
                MessageBox.Show("Please select theme path");
                return;
            }
            if (!File.Exists(themePath))
            {
               MessageBox.Show("Theme Path Does not exist");
               return;
            }

            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created by Parth & Suhail";
            PdfPage page; 
            XGraphics gfx;

            page = document.AddPage();
            page.Orientation = PdfSharp.PageOrientation.Portrait;
            page.Width = XUnit.FromInch(8.5);
            page.Height = XUnit.FromInch(11);
            gfx = XGraphics.FromPdfPage(page); 
            int count = 0;
            foreach (DataRow dr in mainDt.Rows)
            {
                count++;
                if (count > 8)
                {
                    count = 0;
                    page = document.AddPage();
                    page.Orientation = PdfSharp.PageOrientation.Portrait;
                    page.Width = XUnit.FromInch(8.5);
                    page.Height = XUnit.FromInch(11);
                    gfx = XGraphics.FromPdfPage(page);
                }

                ModelStudent obj = new ModelStudent();
                obj.fullName = dr["Full Name"].ToString().ToUpper();
                obj.nationalId = dr["Id"].ToString().ToUpper();

                var mydate = Convert.ToDateTime(dr["DOB"].ToString());
                if (isdateShort)
                {
                    obj.DOB = mydate.ToShortDateString();
                }
                else
                {
                    obj.DOB = mydate.ToLongDateString();
                }
                obj.studentImagePath = dr["path"].ToString();
                Print.setCard(gfx, count, TextColor, imageFramePath, obj , themePath);
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pdf|*.pdf";
            saveFileDialog.Title = "Save Document As Pdf File";
            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;
            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {
                    if (saveFileDialog.CheckPathExists)
                    {

                        document.Save(saveFileDialog.FileName);

                        Process.Start(saveFileDialog.FileName);
                        MessageBox.Show("Document saved successfully");
                    }
                    else
                    {
                        MessageBox.Show("Given Path does not exist");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdateSettings_Click_1(object sender, EventArgs e)
        {
            if (metroToggleDate.Checked)
            {
                isdateShort = true;
            }
            else
            {
                isdateShort = false;
            }
            if (radioBoxed.Checked)
            {
                FrameShape = "boxed";
            }
            else if (radioRounded.Checked)
            {
                FrameShape = "round";
            }
            else
            {
                FrameShape = "none";
            }


            if (metroComboBoxTextColor.SelectedItem != null)
            {
                TextColor = metroComboBoxTextColor.Text;
            }

            if (metroComboBoxFrameColor.SelectedItem != null)
            {
                FrameColor = metroComboBoxFrameColor.Text;
            }
            setSettings();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

            string insertQuery = "INSERT INTO idcard.student(name,Srnno,DOB) VALUES('" + txtAddName.Text + "','" + txtAddNationalId.Text + "','" + AddDatePicker.Text.ToString() + "')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            Boolean state = true;
            StringBuilder errors = new StringBuilder();
            if (txtAddName.Text.Length < 3)
            {
                state = false;
                errors.Append("Name should be greater than 3 characters").AppendLine();
            }
            if (txtAddName.Text.Length > 30)
            {
                state = false;
                errors.Append("Name should be less than 30 characters").AppendLine();
            }


            if (txtAddNationalId.Text.Length < 3)
            {
                state = false;
                errors.Append("RSN id should be greater than 3 characters").AppendLine();
            }
            if (txtAddNationalId.Text.Length > 30)
            {
                state = false;
                errors.Append("SRN id should be less than 30 characters").AppendLine();
            }

            if (AddDatePicker.Value.Year >= DateTime.Now.Year)
            {

            }
            if (imageAddNewPath.Length <= 3)
            {
                state = false;
                errors.Append("Please Select Image").AppendLine();
            }

            try
            {
                if (command.ExecuteNonQuery() == 1 && state)
                {
                    

                        DataRow dr = mainDt.NewRow();
                        dr["Full Name"] = txtAddName.Text;
                        dr["Id"] = txtAddNationalId.Text;
                        dr["DOB"] = AddDatePicker.Value.ToLongDateString();
                        dr["path"] = imageAddNewPath;
                        mainDt.Rows.Add(dr);
                        txtAddName.Clear();
                        txtAddNationalId.Clear();
                        refreshDataGrid(); //
                        imageAddNewPath = "";
                        metroLink1.Text = "Click Here To Select User Image";
                    }
                    else
                    {
                        MessageBox.Show(errors.ToString());
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();

        
           
            

           
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Title = "Select Student Image";
            openFD.FileName = "";
            openFD.Filter = "Image File|*.jpg;*.png;*.jpeg";

            if (openFD.ShowDialog() != DialogResult.Cancel)
            {
                imageAddNewPath = openFD.FileName;
            }
            else
            {
                MessageBox.Show("Please select user image ");
                return;
            }
            metroLink1.Text = imageAddNewPath;
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png";
            saveFileDialog.Title = "Save Theme As Image File";
            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;
            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {
                    if (saveFileDialog.CheckPathExists)
                    {
                        pictureBoxTheme.Image.Save(saveFileDialog.FileName);
                        MessageBox.Show("Theme saved successfully . Please Edit Image to Suit your school");
                    }
                    else
                    {
                        MessageBox.Show("Given Path does not exist");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Title = "Select Theme Image";
            openFD.FileName = "";
            openFD.Filter = "Image File|*.png";

            if (openFD.ShowDialog() != DialogResult.Cancel)
            {
                themePath = openFD.FileName;
                XImage ximageTheme = XImage.FromFile(themePath);
                // assign new numbers based on card number
 
                if (ximageTheme.Size.Width < 340)
                {
                    MessageBox.Show("Theme image width  is too small :" + ximageTheme.Size.Width);
                    return;
                }
                else if (ximageTheme.Size.Width >= 360)
                {
                    MessageBox.Show("Theme image width is too much:" + ximageTheme.Size.Width);
                    return;
                }
                else if (ximageTheme.Size.Height < 220)
                {
                    MessageBox.Show("Theme image Height  is too small:" + ximageTheme.Size.Height);
                    return;
                }
                else if (ximageTheme.Size.Height >= 240)
                {
                    MessageBox.Show("Theme image Height is too much:" + ximageTheme.Size.Height);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select theme image ");
                return;
            }
            linkLabel1.Text = themePath;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Close();
        }

     

        private void metroButton1_Click(object sender, EventArgs e)
        {
            String querry = "select * from student";
            MySqlCommand command = new MySqlCommand(querry, connection);
        }
    }
}
