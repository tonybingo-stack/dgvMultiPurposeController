namespace MPCController
{
    partial class DgvControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ID1 = new System.Windows.Forms.TextBox();
            this.MPC1 = new System.Windows.Forms.DateTimePicker();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.CheckOnlyOneRow1 = new System.Windows.Forms.CheckBox();
            this.label_Action = new System.Windows.Forms.Label();
            this.CheckOnlyOneRow = new System.Windows.Forms.CheckBox();
            this.label_MPC = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.Action1 = new System.Windows.Forms.ComboBox();
            this.DgvTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvTableLayoutPanel
            // 
            this.DgvTableLayoutPanel.AutoScroll = true;
            this.DgvTableLayoutPanel.AutoSize = true;
            this.DgvTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.DgvTableLayoutPanel.ColumnCount = 5;
            this.DgvTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.DgvTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.DgvTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.DgvTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.DgvTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.DgvTableLayoutPanel.Controls.Add(this.ID1, 1, 1);
            this.DgvTableLayoutPanel.Controls.Add(this.MPC1, 3, 1);
            this.DgvTableLayoutPanel.Controls.Add(this.Name1, 2, 1);
            this.DgvTableLayoutPanel.Controls.Add(this.CheckOnlyOneRow1, 0, 1);
            this.DgvTableLayoutPanel.Controls.Add(this.label_Action, 4, 0);
            this.DgvTableLayoutPanel.Controls.Add(this.CheckOnlyOneRow, 0, 0);
            this.DgvTableLayoutPanel.Controls.Add(this.label_MPC, 3, 0);
            this.DgvTableLayoutPanel.Controls.Add(this.label_ID, 1, 0);
            this.DgvTableLayoutPanel.Controls.Add(this.label_Name, 2, 0);
            this.DgvTableLayoutPanel.Controls.Add(this.Action1, 4, 1);
            this.DgvTableLayoutPanel.Location = new System.Drawing.Point(24, 45);
            this.DgvTableLayoutPanel.Name = "DgvTableLayoutPanel";
            this.DgvTableLayoutPanel.Padding = new System.Windows.Forms.Padding(2);
            this.DgvTableLayoutPanel.RowCount = 2;
            this.DgvTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DgvTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DgvTableLayoutPanel.Size = new System.Drawing.Size(687, 60);
            this.DgvTableLayoutPanel.TabIndex = 0;
            this.DgvTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel_Paint);
            // 
            // ID1
            // 
            this.ID1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ID1.Location = new System.Drawing.Point(135, 33);
            this.ID1.Name = "ID1";
            this.ID1.ReadOnly = true;
            this.ID1.Size = new System.Drawing.Size(100, 20);
            this.ID1.TabIndex = 2;
            this.ID1.Text = "ID1";
            this.ID1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MPC1
            // 
            this.MPC1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MPC1.Location = new System.Drawing.Point(351, 33);
            this.MPC1.Name = "MPC1";
            this.MPC1.Size = new System.Drawing.Size(200, 20);
            this.MPC1.TabIndex = 3;
            // 
            // Name1
            // 
            this.Name1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Name1.Location = new System.Drawing.Point(243, 33);
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            this.Name1.Size = new System.Drawing.Size(100, 20);
            this.Name1.TabIndex = 1;
            this.Name1.Text = "Name1";
            this.Name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckOnlyOneRow1
            // 
            this.CheckOnlyOneRow1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CheckOnlyOneRow1.AutoSize = true;
            this.CheckOnlyOneRow1.Location = new System.Drawing.Point(59, 39);
            this.CheckOnlyOneRow1.Name = "CheckOnlyOneRow1";
            this.CheckOnlyOneRow1.Size = new System.Drawing.Size(15, 14);
            this.CheckOnlyOneRow1.TabIndex = 2;
            this.CheckOnlyOneRow1.UseVisualStyleBackColor = true;
            // 
            // label_Action
            // 
            this.label_Action.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_Action.AutoSize = true;
            this.label_Action.Location = new System.Drawing.Point(601, 14);
            this.label_Action.Name = "label_Action";
            this.label_Action.Size = new System.Drawing.Size(37, 13);
            this.label_Action.TabIndex = 6;
            this.label_Action.Text = "Action";
            // 
            // CheckOnlyOneRow
            // 
            this.CheckOnlyOneRow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CheckOnlyOneRow.AutoSize = true;
            this.CheckOnlyOneRow.Location = new System.Drawing.Point(7, 7);
            this.CheckOnlyOneRow.Name = "CheckOnlyOneRow";
            this.CheckOnlyOneRow.Size = new System.Drawing.Size(120, 17);
            this.CheckOnlyOneRow.TabIndex = 1;
            this.CheckOnlyOneRow.Text = "CheckOnlyOneRow";
            this.CheckOnlyOneRow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckOnlyOneRow.UseVisualStyleBackColor = true;
            this.CheckOnlyOneRow.CheckedChanged += new System.EventHandler(this.CheckOnlyOneRow_CheckedChanged);
            // 
            // label_MPC
            // 
            this.label_MPC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_MPC.AutoSize = true;
            this.label_MPC.Location = new System.Drawing.Point(436, 14);
            this.label_MPC.Name = "label_MPC";
            this.label_MPC.Size = new System.Drawing.Size(30, 13);
            this.label_MPC.TabIndex = 5;
            this.label_MPC.Text = "MPC";
            // 
            // label_ID
            // 
            this.label_ID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(176, 14);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(18, 13);
            this.label_ID.TabIndex = 3;
            this.label_ID.Text = "ID";
            // 
            // label_Name
            // 
            this.label_Name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(275, 14);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(35, 13);
            this.label_Name.TabIndex = 4;
            this.label_Name.Text = "Name";
            // 
            // Action1
            // 
            this.Action1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Action1.FormattingEnabled = true;
            this.Action1.Items.AddRange(new object[] {
            "Today",
            "Today+7d"});
            this.Action1.Location = new System.Drawing.Point(559, 32);
            this.Action1.Name = "Action1";
            this.Action1.Size = new System.Drawing.Size(121, 21);
            this.Action1.TabIndex = 1;
            this.Action1.Text = "None";
            // 
            // DgvControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DgvTableLayoutPanel);
            this.Name = "DgvControl";
            this.Size = new System.Drawing.Size(725, 312);
            this.DgvTableLayoutPanel.ResumeLayout(false);
            this.DgvTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel DgvTableLayoutPanel;
        private System.Windows.Forms.CheckBox CheckOnlyOneRow;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_MPC;
        private System.Windows.Forms.Label label_Action;
        private System.Windows.Forms.TextBox ID1;
        private System.Windows.Forms.DateTimePicker MPC1;
        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.CheckBox CheckOnlyOneRow1;
        private System.Windows.Forms.ComboBox Action1;
    }
}
