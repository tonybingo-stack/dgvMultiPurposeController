﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MPCController
{
    public partial class DgvControl: UserControl
    {
        private int rowIndex;
        //private CheckBox checkbox_field;
        //private CheckBox[] checkbox_field = new CheckBox[100];
        private List<CheckBox> checkbox_field = new List<CheckBox>();
        //private TextBox[] ID_field = new TextBox[100];
        private List<TextBox> ID_field = new List<TextBox>();
        //private TextBox[] Name_field = new TextBox[100];
        private List<TextBox> Name_field = new List<TextBox>();
        //private String[] MPC_field = new String[100];
        private List<String> MPC_field = new List<String>();
        private List<Control> MPC_field_controller = new List<Control>();
        private List<ComboBox> Action_field= new List<ComboBox>();

        public DgvControl()
        {
            InitializeComponent();
            rowIndex = 1;

            // checkBox
            //checkbox_field[rowIndex] = CheckOnlyOneRow1;
            checkbox_field.Add(CheckOnlyOneRow1);

            //ID
            //ID_field[rowIndex] = ID1;
            ID_field.Add(ID1);

            //Name{rowIndex}
            //Name_field[rowIndex] = Name1;
            Name_field.Add(Name1);

            //MPC control
            //MPC_field[rowIndex] = "DateTimePicker";
            MPC_field.Add("DateTimePicker");
            //MPC_field_controller[rowIndex] = MPC1;
            MPC_field_controller.Add(MPC1);

            //Action
            Action1.SelectedIndexChanged += new EventHandler(ActionColumnSelected);
            //Action_field[rowIndex] = Action1;
            Action_field.Add(Action1);

        }

        private void CheckOnlyOneRow_CheckedChanged(object sender, EventArgs e)
        {
            RowControlAdd("ok1", "ok2", "ComboBox", "");
        }

        private void TableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

            //MessageBox.Show("ok");

        }
        public int RowControlAdd(string ID, string Name, string mpcControlType, string mpcControlSettings)
        {
            rowIndex = rowIndex + 1;
            DgvTableLayoutPanel.RowCount = rowIndex + 1;
            DgvTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());

            //
            // Check{rowIndex}
            //
            //checkbox_field[rowIndex] = new CheckBox();
            CheckBox chkBox = new CheckBox();

            //checkbox_field[rowIndex].Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            //checkbox_field[rowIndex].AutoSize = true;
            //checkbox_field[rowIndex].Location = new System.Drawing.Point(59, 39);
            //checkbox_field[rowIndex].Name = "checkonlyonerow" + rowIndex.ToString();
            //checkbox_field[rowIndex].Size = new System.Drawing.Size(15, 14);
            //checkbox_field[rowIndex].TabIndex = 2;
            //checkbox_field[rowIndex].UseVisualStyleBackColor = true;

            chkBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            chkBox.AutoSize = true;
            chkBox.Location = new System.Drawing.Point(59, 39);
            chkBox.Name = "checkonlyonerow" + rowIndex.ToString();
            chkBox.Size = new System.Drawing.Size(15, 14);
            chkBox.TabIndex = 2;
            chkBox.UseVisualStyleBackColor = true;

            DgvTableLayoutPanel.Controls.Add(chkBox, 0, rowIndex);
            checkbox_field.Add(chkBox);

            //ID{rowIndex}
            //ID_field[rowIndex] = new TextBox();
            TextBox txtBox = new TextBox();

            //ID_field[rowIndex].Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            //ID_field[rowIndex].Location = new System.Drawing.Point(135, 33);
            //ID_field[rowIndex].Name = "ID" + rowIndex.ToString();
            //ID_field[rowIndex].ReadOnly = true;
            //ID_field[rowIndex].Size = new System.Drawing.Size(100, 20);
            //ID_field[rowIndex].TabIndex = 2;
            //ID_field[rowIndex].Text = ID;
            //ID_field[rowIndex].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            txtBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            txtBox.Location = new System.Drawing.Point(135, 33);
            txtBox.Name = "ID" + rowIndex.ToString();
            txtBox.ReadOnly = true;
            txtBox.Size = new System.Drawing.Size(100, 20);
            txtBox.TabIndex = 2;
            txtBox.Text = ID;
            txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            DgvTableLayoutPanel.Controls.Add(txtBox, 1, rowIndex);
            ID_field.Add(txtBox);

            //Name{rowIndex}
            //Name_field[rowIndex] = new TextBox();
            txtBox = new TextBox();

            //Name_field[rowIndex].Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            //Name_field[rowIndex].Location = new System.Drawing.Point(243, 33);
            //Name_field[rowIndex].Name = "Name" + rowIndex.ToString();
            //Name_field[rowIndex].ReadOnly = true;
            //Name_field[rowIndex].Size = new System.Drawing.Size(100, 20);
            //Name_field[rowIndex].TabIndex = 1;
            //Name_field[rowIndex].Text = Name;
            //Name_field[rowIndex].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            txtBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            txtBox.Location = new System.Drawing.Point(243, 33);
            txtBox.Name = "Name" + rowIndex.ToString();
            txtBox.ReadOnly = true;
            txtBox.Size = new System.Drawing.Size(100, 20);
            txtBox.TabIndex = 1;
            txtBox.Text = Name;
            txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            DgvTableLayoutPanel.Controls.Add(txtBox, 2, rowIndex);
            Name_field.Add(txtBox);

            //MPC{rowIndex
            //MPC_field[rowIndex] = mpcControlType;
            MPC_field.Add(mpcControlType);

            if (string.Compare(mpcControlType, "DateTimePicker") == 0)
            {
                //MessageBox.Show("ok");
                DateTimePicker dtPicker = new DateTimePicker();

                dtPicker.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
                dtPicker.Location = new System.Drawing.Point(351, 33);
                dtPicker.Name = "MPC" + rowIndex.ToString();
                dtPicker.Size = new System.Drawing.Size(200, 20);
                dtPicker.TabIndex = 3;

                DgvTableLayoutPanel.Controls.Add(dtPicker, 3, rowIndex);
                MPC_field_controller.Add(dtPicker);
            }
            else if(string.Compare(mpcControlType, "ComboBox") == 0)
            {
                ComboBox cbBox = new ComboBox();

                cbBox.Dock = System.Windows.Forms.DockStyle.Fill;
                cbBox.FormattingEnabled = true;
                cbBox.Items.AddRange(new object[] {
                "Yes",
                "No"});
                cbBox.Name = "MPC" + rowIndex.ToString();
                cbBox.TabIndex = 7;
                cbBox.Text = "None";

                DgvTableLayoutPanel.Controls.Add(cbBox, 3, rowIndex);
                MPC_field_controller.Add(cbBox);

            }
            else
            {
                MessageBox.Show("UnSupported Controller");
            }


            //Action{rowIndex}
            //Action_field[rowIndex] = new ComboBox();
            ComboBox ActionComboBox = new ComboBox();

            ActionComboBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            ActionComboBox.FormattingEnabled = true;
            if (string.Compare(mpcControlType, "DateTimePicker") == 0)
            {
                ActionComboBox.Items.AddRange(new object[] {
                "Today",
                "Today+7d"});
            }
            else if (string.Compare(mpcControlType, "ComboBox") == 0)
            {
                ActionComboBox.Items.AddRange(new object[] {
                "Yes",
                "No"});
            }
            else
            {
                MessageBox.Show("UnSupported Controller");
            }

            ActionComboBox.Location = new System.Drawing.Point(559, 32);
            ActionComboBox.Name = "Action" + rowIndex.ToString();
            ActionComboBox.Size = new System.Drawing.Size(121, 21);
            ActionComboBox.TabIndex = rowIndex;
            ActionComboBox.Text = "None";
            ActionComboBox.SelectedIndexChanged += new EventHandler(ActionColumnSelected);

            DgvTableLayoutPanel.Controls.Add(ActionComboBox, 4, rowIndex);
            Action_field.Add(ActionComboBox);

            return rowIndex;
        }
        private void ActionColumnSelected(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            string action = cmb.Text;
            int rowIndex_cmb = cmb.TabIndex-1;
            //MessageBox.Show(rowIndex_cmb.ToString());

            string ID_cmb = ID_field[rowIndex_cmb].Text;
            string Name_cmb = Name_field[rowIndex_cmb].Text;
            string MPCType_cmb = MPC_field[rowIndex_cmb];
            Control MPC_cmb = MPC_field_controller[rowIndex_cmb];

            if (MPCType_cmb == "DateTimePicker")
            {
                if (action == "Today")
                {
                    ((DateTimePicker)MPC_cmb).Value = DateTime.Today.AddDays(0);
                }
                else if (action == "Today+7d")
                {
                    ((DateTimePicker)MPC_cmb).Value = DateTime.Today.AddDays(7);
                }
            }
            else if (MPCType_cmb == "ComboBox")
            {
                ((ComboBox)MPC_cmb).SelectedIndex = cmb.SelectedIndex;
            }

            //MessageBox.Show(ID_cmb + ":" + Name_cmb + ":" + MPCType_cmb + ":" + action + ":" + checkbox_field[rowIndex_cmb].Checked.ToString());
        }

        public List<Control> GetAllController()
        {
            return MPC_field_controller;
        }
        public int GetTotalRow()
        {
            return rowIndex;
        }
        public Control GetControllerByID(string id)
        {
            int index = -1;
            for(int i = 0; i < rowIndex; i++)
            {
                if(ID_field[i].Text == id)
                {
                    index = i;
                    break;
                }
            }

            return MPC_field_controller[index];
        }
        public Control GetControllerByIndex(int index)
        {
            return MPC_field_controller[index];
        }
        public List<Control> GetAllCheckedControllers()
        {
            List<Control> checkedControl = new List<Control>();

            for (int i = 0; i < rowIndex; i++)
            {
                if (checkbox_field[i].Checked)
                {
                    checkedControl.Add(MPC_field_controller[i]);
                }
            }

            return checkedControl;
        }
    }
}
