using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class main_page : Form
    {
        query_change qc;
        query_select qs;
        string lastisbn,txt;
       

        public main_page()
        {
            InitializeComponent();
        }

        private void tab_ketab_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Name == "tab_gozareshgiri")
            {
                b_sabt.Hide();
                b_virayesh.Hide();
                b_hazf.Hide(); ;
                b_refresh.Hide(); ;
                b_print.Show();
                b_search.Show();
            }
            else if (e.TabPage.Name == "tab_sabt_ketab")
            {
                b_sabt.Show(); ;
                b_virayesh.Show();
                b_hazf.Show();
                b_refresh.Show();
                b_print.Hide();
                b_search.Hide();
            }

        }


        private void b_select_nevisande_1_Click(object sender, EventArgs e)
        {

        }





        private void b_select_entesharat_1_Click(object sender, EventArgs e)
        {

        }



        private void b_sabt_Click_1(object sender, EventArgs e)
        {
            string isbn = t_isbn_1.Text;
            string title = t_title_1.Text;
            string authorname = t_authors_1.Text;
            string publisher = t_publisher_1.Text;
            string copyright = t_copyright_1.Text;
            int count = Convert.ToInt32
                (t_count.Text);
            qc = new query_change();
            qc.Insertbook(isbn, title,
                authorname, publisher
                , copyright, count);
       
         //   if (t_isbn_1.Text == "")

         //{ MessageBox.Show("شماره کتاب را وارد کنید");
         //return false;
         //   }

            filldatagridview();
        }
        void filldatagridview()
        {
             qs = new query_select();
            dgv1_2.DataSource=qs.selectallbooks().
                Tables["book"];
            dgv1_2.Columns["isbn"].HeaderText = "شماره کتاب";
            dgv1_2.Columns["title"].HeaderText = "عنوان";
            dgv1_2.Columns["authorName"].HeaderText = "نام نویسنده";
            dgv1_2.Columns["publisher"].HeaderText = "انتشارات";
            dgv1_2.Columns["copy_right"].HeaderText = "سال انتشار";
            dgv1_2.Columns["count"].HeaderText = "تعداد";

        }

        private void r_onvane_ketab_2_CheckedChanged(object sender, EventArgs e)
        {
            if (r_onvane_ketab_2.Checked == true)
            {
                c_ketab_2.Enabled = true;
                t_ketab_2.Enabled = true;
                t_entesharat_2.Enabled = false;
                c_entesharat_2.Enabled = false;
                c_nevisande_2.Enabled = false;
                t_nevisande_2.Enabled = false;
            }
        }

        private void r_nevisande_2_CheckedChanged(object sender, EventArgs e)
        {
            if (r_nevisande_2.Checked == true)
            {
                c_ketab_2.Enabled = false;
                t_ketab_2.Enabled = false;
                t_entesharat_2.Enabled = false;
                c_entesharat_2.Enabled = false;
                c_nevisande_2.Enabled = true;
                t_nevisande_2.Enabled = true;
            }
        }

        private void r_entesharat_2_CheckedChanged(object sender, EventArgs e)
        {
            if (r_entesharat_2.Checked == true)
            {
                c_ketab_2.Enabled = false;
                t_ketab_2.Enabled = false;
                c_nevisande_2.Enabled = false;
                t_nevisande_2.Enabled = false;
                t_entesharat_2.Enabled = true;
                c_entesharat_2.Enabled = true;
            }
        }

        private void main_page_Load(object sender, EventArgs e)
        {
            c_ketab_2.SelectedIndex = 0;
            c_entesharat_2.SelectedIndex = 0;
            c_nevisande_2.SelectedIndex = 0;
            filldatagridview();
        }

        
        private void b_search_Click(object sender, EventArgs e)
        {
            string txt = t_ketab_2.Text;
            int combo = c_ketab_2.SelectedIndex;
            // qs.selectbook(combo,txt);
            qs = new query_select();
            dgv1_2.DataSource = qs.selectbook(combo, txt).
                Tables["book"];
            dgv1_2.Columns["isbn"].HeaderText = "شماره کتاب";
            dgv1_2.Columns["title"].HeaderText = "عنوان";
            dgv1_2.Columns["authorName"].HeaderText = "نام نویسنده";
            dgv1_2.Columns["publisher"].HeaderText = "انتشارات";
            dgv1_2.Columns["copy_right"].HeaderText = "سال انتشار";
            dgv1_2.Columns["count"].HeaderText = "تعداد";

        }

        private void dgv1_2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t_isbn_1.Text = 
                dgv1_2.Rows[e.RowIndex].Cells["isbn"].Value.ToString();
             t_count.Text =
                 dgv1_2.Rows[e.RowIndex].Cells["count"].Value.ToString();
            t_title_1.Text =
               dgv1_2.Rows[e.RowIndex].Cells["title"].Value.ToString();
             t_authors_1.Text =
                dgv1_2.Rows[e.RowIndex].Cells["authorName"].Value.ToString();
            t_publisher_1.Text =
               dgv1_2.Rows[e.RowIndex].Cells["publisher"].Value.ToString();
            t_copyright_1.Text =
               dgv1_2.Rows[e.RowIndex].Cells["copy_right"].Value.ToString();
            lastisbn = t_isbn_1.Text;
        }

        private void b_virayesh_Click(object sender, EventArgs e)
        {
            string isbn = t_isbn_1.Text;
            string title = t_title_1.Text;
            string authorname = t_authors_1.Text;
            string publisher = t_publisher_1.Text;
            string copyright = t_copyright_1.Text;
            int count = Convert.ToInt32
                (t_count.Text);
            qc = new query_change();
            qc.updatebook(lastisbn,isbn, title,
                authorname, publisher
                , copyright, count);
            filldatagridview();

        }

        private void b_hazf_Click(object sender, EventArgs e)
        {
            qc = new query_change();
            qc.deletebook(lastisbn);
            filldatagridview();
        }

        private void b_print_Click(object sender, EventArgs e)
        {

        }

       

        private void r_onvane_ketab_2_Click(object sender, EventArgs e)
        {

        }

        private void l_isbn_1_Click(object sender, EventArgs e)
        {

        }

        private void b_refresh_Click(object sender, EventArgs e)
        {
            t_authors_1.Text = null;
            t_copyright_1.Text = null;
            t_count.Text = null;
            t_isbn_1.Text = null;
            t_publisher_1.Text = null;
            t_title_1.Text = null;

        }
    }
}
