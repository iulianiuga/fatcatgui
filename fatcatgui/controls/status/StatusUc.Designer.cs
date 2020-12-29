
namespace fatcatgui.controls.status
{
    partial class StatusUc
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.timer100 = new System.Windows.Forms.Timer(this.components);
            this.timer20000 = new System.Windows.Forms.Timer(this.components);
            this.progressUcMem = new fatcatgui.controls.progress.ProgressUc();
            this.progressUcLoad = new fatcatgui.controls.progress.ProgressUc();
            this.progressUcDrive = new fatcatgui.controls.progress.ProgressUc();
            this.progressUcAppInfo = new fatcatgui.controls.progress.ProgressUc();
            this.progressUcOSinfo = new fatcatgui.controls.progress.ProgressUc();
            this.progressUcOwnMem = new fatcatgui.controls.progress.ProgressUc();
            this.progressUcUptime = new fatcatgui.controls.progress.ProgressUc();
            this.imageUCLogo = new fatcatgui.controls.image.ImageUC();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.progressUcMem, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.progressUcLoad, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.progressUcDrive, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.progressUcAppInfo, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.progressUcOSinfo, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.progressUcOwnMem, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.progressUcUptime, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.imageUCLogo, 0, 7);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 10;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(640, 404);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // timer100
            // 
            this.timer100.Enabled = true;
            this.timer100.Interval = 200;
            this.timer100.Tick += new System.EventHandler(this.timer100_Tick);
            // 
            // timer20000
            // 
            this.timer20000.Enabled = true;
            this.timer20000.Interval = 20000;
            this.timer20000.Tick += new System.EventHandler(this.timer20000_Tick);
            // 
            // progressUcMem
            // 
            this.progressUcMem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressUcMem.Location = new System.Drawing.Point(3, 83);
            this.progressUcMem.Name = "progressUcMem";
            this.progressUcMem.Prefixtext = null;
            this.progressUcMem.Size = new System.Drawing.Size(634, 34);
            this.progressUcMem.TabIndex = 0;
            this.progressUcMem.Valuecur = 0D;
            this.progressUcMem.Valuemax = 0D;
            // 
            // progressUcLoad
            // 
            this.progressUcLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressUcLoad.Location = new System.Drawing.Point(3, 123);
            this.progressUcLoad.Name = "progressUcLoad";
            this.progressUcLoad.Prefixtext = null;
            this.progressUcLoad.Size = new System.Drawing.Size(634, 34);
            this.progressUcLoad.TabIndex = 1;
            this.progressUcLoad.Valuecur = 0D;
            this.progressUcLoad.Valuemax = 0D;
            // 
            // progressUcDrive
            // 
            this.progressUcDrive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressUcDrive.Location = new System.Drawing.Point(3, 163);
            this.progressUcDrive.Name = "progressUcDrive";
            this.progressUcDrive.Prefixtext = null;
            this.progressUcDrive.Size = new System.Drawing.Size(634, 34);
            this.progressUcDrive.TabIndex = 2;
            this.progressUcDrive.Valuecur = 0D;
            this.progressUcDrive.Valuemax = 0D;
            // 
            // progressUcAppInfo
            // 
            this.progressUcAppInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressUcAppInfo.Location = new System.Drawing.Point(3, 3);
            this.progressUcAppInfo.Name = "progressUcAppInfo";
            this.progressUcAppInfo.Prefixtext = null;
            this.progressUcAppInfo.Size = new System.Drawing.Size(634, 34);
            this.progressUcAppInfo.TabIndex = 3;
            this.progressUcAppInfo.Valuecur = 0D;
            this.progressUcAppInfo.Valuemax = 0D;
            // 
            // progressUcOSinfo
            // 
            this.progressUcOSinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressUcOSinfo.Location = new System.Drawing.Point(3, 43);
            this.progressUcOSinfo.Name = "progressUcOSinfo";
            this.progressUcOSinfo.Prefixtext = null;
            this.progressUcOSinfo.Size = new System.Drawing.Size(634, 34);
            this.progressUcOSinfo.TabIndex = 4;
            this.progressUcOSinfo.Valuecur = 0D;
            this.progressUcOSinfo.Valuemax = 0D;
            // 
            // progressUcOwnMem
            // 
            this.progressUcOwnMem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressUcOwnMem.Location = new System.Drawing.Point(3, 203);
            this.progressUcOwnMem.Name = "progressUcOwnMem";
            this.progressUcOwnMem.Prefixtext = null;
            this.progressUcOwnMem.Size = new System.Drawing.Size(634, 34);
            this.progressUcOwnMem.TabIndex = 5;
            this.progressUcOwnMem.Valuecur = 0D;
            this.progressUcOwnMem.Valuemax = 0D;
            // 
            // progressUcUptime
            // 
            this.progressUcUptime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressUcUptime.Location = new System.Drawing.Point(3, 243);
            this.progressUcUptime.Name = "progressUcUptime";
            this.progressUcUptime.Prefixtext = null;
            this.progressUcUptime.Size = new System.Drawing.Size(634, 34);
            this.progressUcUptime.TabIndex = 6;
            this.progressUcUptime.Valuecur = 0D;
            this.progressUcUptime.Valuemax = 0D;
            // 
            // imageUCLogo
            // 
            this.imageUCLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageUCLogo.Location = new System.Drawing.Point(3, 283);
            this.imageUCLogo.Name = "imageUCLogo";
            this.tableLayoutPanel.SetRowSpan(this.imageUCLogo, 3);
            this.imageUCLogo.Size = new System.Drawing.Size(634, 118);
            this.imageUCLogo.TabIndex = 7;
            // 
            // StatusUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.DoubleBuffered = true;
            this.Name = "StatusUc";
            this.Size = new System.Drawing.Size(640, 404);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private progress.ProgressUc progressUcMem;
        private progress.ProgressUc progressUcLoad;
        private progress.ProgressUc progressUcDrive;
        private progress.ProgressUc progressUcAppInfo;
        private progress.ProgressUc progressUcOSinfo;
        private progress.ProgressUc progressUcOwnMem;
        private progress.ProgressUc progressUcUptime;
        private System.Windows.Forms.Timer timer100;
        private System.Windows.Forms.Timer timer20000;
        private image.ImageUC imageUCLogo;
    }
}
