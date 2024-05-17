namespace AlarmProject
{
    partial class AlarmMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmMainForm));
            alarmsFlowLayoutPanel = new FlowLayoutPanel();
            addNewAlarmPcitureBox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)addNewAlarmPcitureBox).BeginInit();
            SuspendLayout();
            // 
            // alarmsFlowLayoutPanel
            // 
            alarmsFlowLayoutPanel.AutoScroll = true;
            alarmsFlowLayoutPanel.Dock = DockStyle.Bottom;
            alarmsFlowLayoutPanel.Location = new Point(0, 83);
            alarmsFlowLayoutPanel.Name = "alarmsFlowLayoutPanel";
            alarmsFlowLayoutPanel.Size = new Size(550, 360);
            alarmsFlowLayoutPanel.TabIndex = 0;
            // 
            // addNewAlarmPcitureBox
            // 
            addNewAlarmPcitureBox.Cursor = Cursors.Hand;
            addNewAlarmPcitureBox.Image = Properties.Resources.newalarm;
            addNewAlarmPcitureBox.Location = new Point(12, 12);
            addNewAlarmPcitureBox.Name = "addNewAlarmPcitureBox";
            addNewAlarmPcitureBox.Size = new Size(71, 61);
            addNewAlarmPcitureBox.SizeMode = PictureBoxSizeMode.Zoom;
            addNewAlarmPcitureBox.TabIndex = 1;
            addNewAlarmPcitureBox.TabStop = false;
            addNewAlarmPcitureBox.MouseDown += EditExistingAlarmPictureBoxClick;
            // 
            // AlarmMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(550, 443);
            Controls.Add(addNewAlarmPcitureBox);
            Controls.Add(alarmsFlowLayoutPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AlarmMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Будильник";
            ((System.ComponentModel.ISupportInitialize)addNewAlarmPcitureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public FlowLayoutPanel alarmsFlowLayoutPanel;
        private PictureBox addNewAlarmPcitureBox;
        private System.Windows.Forms.Timer timer1;
    }
}
