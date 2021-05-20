using System;
using System.Data;
using System.Windows.Forms;

namespace CRUDElasticsearch
{
    public partial class Form1 : Form
    {
        string documentID = "";
        string id = "";
        string name = "";
        string originalVoiceActor = "";
        string animatedDebut = "";

        string[] arrCharacter = new string[4];
        ListViewItem itm;


        public Form1()
        {
            InitializeComponent();

            lvwDisneyCharacter.Items.Clear();

            DataTable dataTable = CRUD.getAllDocument();
            DataRow[] rulesRow = dataTable.Select();

            foreach (DataRow row in rulesRow)
            {
                id = row[0].ToString();
                name = row[1].ToString();
                originalVoiceActor = row[2].ToString();
                animatedDebut = row[3].ToString();

                //Add item to listview
                arrCharacter[0] = id;
                arrCharacter[1] = name;
                arrCharacter[2] = originalVoiceActor;
                arrCharacter[3] = animatedDebut;

                itm = new ListViewItem(arrCharacter);
                lvwDisneyCharacter.Items.Add(itm);

            }
        }
        #region Search Button

        private void btnSearch_Click(object sender, EventArgs e)
        {



            name = tbxName.Text;
            var disneyCharacter = CRUD.getDocument(name);

            tbxID.Text = disneyCharacter.Item1;
            tbxName.Text = disneyCharacter.Item2;
            tbxVoiceActor.Text = disneyCharacter.Item3;
            tbxDebut.Text = disneyCharacter.Item4;


        }

        #endregion Search Button

        #region Get All Button

        private void btnGetAllData_Click(object sender, EventArgs e)
        {
            //Clear ListView before loading new data
            lvwDisneyCharacter.Items.Clear();

            DataTable dataTable = CRUD.getAllDocument();
            DataRow[] rulesRow = dataTable.Select();

            foreach (DataRow row in rulesRow)
            {
                id = row[0].ToString();
                name = row[1].ToString();
                originalVoiceActor = row[2].ToString();
                animatedDebut = row[3].ToString();

                //Add item to listview
                arrCharacter[0] = id;
                arrCharacter[1] = name;
                arrCharacter[2] = originalVoiceActor;
                arrCharacter[3] = animatedDebut;

                itm = new ListViewItem(arrCharacter);
                lvwDisneyCharacter.Items.Add(itm);
            }
        }



        #endregion Get All Button

        #region Insert Button

        private void btnIndex_Click(object sender, EventArgs e)
        {
            bool status;

            id = tbxID.Text;
            name = tbxName.Text;
            originalVoiceActor = tbxVoiceActor.Text;
            animatedDebut = tbxDebut.Text;

            status = CRUD.insertDocument(id, name, originalVoiceActor, animatedDebut);

            lvwDisneyCharacter.Items.Clear();

            DataTable dataTable = CRUD.getAllDocument();
            DataRow[] rulesRow = dataTable.Select();

            foreach (DataRow row in rulesRow)
            {
                id = row[0].ToString();
                name = row[1].ToString();
                originalVoiceActor = row[2].ToString();
                animatedDebut = row[3].ToString();

                //Add item to listview
                arrCharacter[0] = id;
                arrCharacter[1] = name;
                arrCharacter[2] = originalVoiceActor;
                arrCharacter[3] = animatedDebut;

                itm = new ListViewItem(arrCharacter);
                lvwDisneyCharacter.Items.Add(itm);
            }
            if (status == true)
            {
                MessageBox.Show("Thêm dữ liệu thành công!");
            }
            else
            {
                MessageBox.Show("Thao tác sai! Đã có dữ liệu này rồi");
            }

        }

        #endregion Insert Button

        #region Update Button

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool status;

            id = tbxID.Text;
            name = tbxName.Text;
            originalVoiceActor = tbxVoiceActor.Text;
            animatedDebut = tbxDebut.Text;

            status = CRUD.updateDocument(id, name, originalVoiceActor, animatedDebut);

            if (status == true)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }
            else
            {
                MessageBox.Show("Thao tác sai! Dữ liệu không tồn tại");
            }
        }

        #endregion Update Button

        #region Delete Button

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool status;
            documentID = tbxID.Text;

            status = CRUD.deleteDocument(documentID);

            if (status == true)
            {
                MessageBox.Show("Xóa dữ liệu thành công");
            }
            else
            {
                MessageBox.Show("Thao tác sai!Dữ liệu không tồn tại!");
            }
        }

        #endregion Delete Button

        #region Reset all Flag

        private void tbxID_TextChanged(object sender, EventArgs e)
        {
            //Clear all Text when search for new ID
            tbxName.Text = "";
            tbxVoiceActor.Text = "";
            tbxDebut.Text = "";

        }

        #endregion Reset all Flag       

        private void lblVoiceActor_Click(object sender, EventArgs e)
        {

        }

        private void lvwDisneyCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDisneyCharacter.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwDisneyCharacter.SelectedItems[0];
                tbxID.Text = item.SubItems[0].Text;
                tbxName.Text = item.SubItems[1].Text;
                tbxVoiceActor.Text = item.SubItems[2].Text;
                tbxDebut.Text = item.SubItems[3].Text;
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbxDebut_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
