using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainFormHR : Form
    {
        //biến form dùng để gọi lại loginform
        public Form loginForm;
        public MainFormHR()
        {
            InitializeComponent();
        }
        User HRuser = new User();
        Contact contact = new Contact();
        Group group = new Group();
        private void MainFormHR_Load(object sender, EventArgs e)
        {
            #region Load Form Hình ảnh và các dòng chữ welcome
            DataTable table = new DataTable();
            table = HRuser.GetHR(Global.GlobalUserID1);
            byte[] pic = (byte[])table.Rows[0]["fig"];
            MemoryStream ms = new MemoryStream(pic);
            pictureBox.Image = Image.FromStream(ms);

            lb_Welcome.Text = ("Welcome User (" + table.Rows[0]["ID"].ToString() + ")");
            lb_FnameLname.Text = (table.Rows[0]["f_name"].ToString() + " " + table.Rows[0]["l_name"].ToString());
            //Image x = (Bitmap)((new ImageConverter()).ConvertFrom(pic));
            //pictureBox.Image = x;
            #endregion

            #region Load Lại Combobox cho Group
            cbb_EditGroup.DataSource = group.GetUserGroups(Global.GlobalUserID1);
            cbb_EditGroup.DisplayMember = "Name";
            cbb_EditGroup.ValueMember = "id";
            cbb_DeleteGroup.DataSource = group.GetUserGroups(Global.GlobalUserID1);
            cbb_DeleteGroup.DisplayMember = "Name";
            cbb_DeleteGroup.ValueMember = "id";
            #endregion

        }
        private void lb_LogOut_Click(object sender, EventArgs e)
        {
            loginForm.Visible = true;
            this.Close();
        }
        private void lb_Edit_Click(object sender, EventArgs e)
        {
            EditHRForm EHRF = new EditHRForm();
            EHRF.Show(this);
            MainFormHR_Load(null, null);
        }
        private void lb_LogOut_MouseEnter(object sender, EventArgs e)
        {
            lb_LogOut.ForeColor = Color.Blue;
        }
        private void lb_LogOut_MouseLeave(object sender, EventArgs e)
        {
            lb_LogOut.ForeColor = Color.Black;
        }
        private void lb_Edit_MouseEnter(object sender, EventArgs e)
        {
            lb_Edit.ForeColor = Color.Blue;
        }
        private void lb_Edit_MouseLeave(object sender, EventArgs e)
        {
            lb_Edit.ForeColor = Color.Black;
        }
        private void bt_AddContact_Click(object sender, EventArgs e)
        {
            AddContactForm ACF = new AddContactForm();
            ACF.Show(this);
        }
        private void bt_EditContact_Click(object sender, EventArgs e)
        {
            EditContactForm ECF = new EditContactForm();
            ECF.Show(this);
        }
        private void bt_SelectContact_Click(object sender, EventArgs e)
        {
            Contact_sGroupForm CGF = new Contact_sGroupForm();
            CGF.Show(this);
        }
        private void bt_RemoveContact_Click(object sender, EventArgs e)
        {
            int num = -1; // checking input is interger or not
            if (txb_EnterContactID.Text.Trim() == "")
            {
                MessageBox.Show("Please Add An ID", "Select Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Int32.TryParse(txb_EnterContactID.Text, out num))
            {
                MessageBox.Show("Please Add An InterGer", "Select Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int ContactID = Convert.ToInt32(txb_EnterContactID.Text);
                if (!contact.CheckContactID(ContactID, Global.GlobalUserID1))
                {
                    if ((MessageBox.Show("Are you sure want to delete this Contact?", "Delete Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        if (contact.deleteContact(ContactID))
                        {
                            MessageBox.Show("Contact Deleted", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txb_EnterContactID.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Can Not Delete Contact", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ID Can Not Be Found!", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txb_EnterContactID.Text = "";
                }
            }
        }
        private void bt_AddGroup_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                int num = -1;
                if (txb_GroupID.Text.Trim() == "")
                {
                    MessageBox.Show("Please Add An ID", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Int32.TryParse(txb_GroupID.Text, out num))
                {
                    MessageBox.Show("Please Add An InterGer For Group's ID", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int GroupID = Convert.ToInt32(txb_GroupID.Text);
                    string GroupName = txb_GroupName.Text;
                    if (group.CheckGroupID(GroupID))
                    {
                        if (group.CheckGroupName(GroupName))
                        {
                            if (group.insertGroup(GroupID, GroupName, Global.GlobalUserID1))
                            {
                                MessageBox.Show("Group Added!", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txb_GroupID.Text = ""; txb_GroupName.Text = "";
                                MainFormHR_Load(null,null);
                            }
                            else
                            {
                                MessageBox.Show("Can Not Add Group!", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Group's Name Existed!", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txb_GroupName.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Group's ID Existed!", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txb_GroupID.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void bt_EditGroup_Click(object sender, EventArgs e)
        {

            if(txb_EditGroupName.Text.Trim() != "")
            {
                string GroupName = txb_EditGroupName.Text;
                int GroupID = (int)cbb_EditGroup.SelectedValue;
                if (group.CheckGroupName(GroupName))
                {
                    if (group.updateGroupName(GroupID, GroupName))
                    {
                        MessageBox.Show("Group's Name Edited", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txb_EditGroupName.Text = "";
                        MainFormHR_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Can Not Update Group's Name", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Group's Name Existed!", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txb_EditGroupName.Text = "";
                }
            }   
            else
            {
                MessageBox.Show("Empty Fields", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }    
        }
        private void bt_RemoveGroup_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure want to delete this Group?", "Delete Group", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                int GroupID = (int)cbb_DeleteGroup.SelectedValue;
                //int GroupID = (int)cbb_EditGroup.SelectedIndex;
                if (group.deleteGroup(GroupID))
                {
                    MessageBox.Show("Group Deleted", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainFormHR_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Can Not Delete Group!", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    

        }
        private void bt_ShowContact_Click(object sender, EventArgs e)
        {
            FullContactForm FCF = new FullContactForm();
            FCF.Show(this);
        }
        bool verif()
        {
            if (txb_GroupID.Text.Trim()=="" || txb_GroupName.Text.Trim() =="")
                return false;
            else
                return true;

        }

    }
    
}
