namespace MIT
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picTop = new System.Windows.Forms.PictureBox();
            this.picBottom = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTotal = new System.Windows.Forms.Button();
            this.tbSection = new System.Windows.Forms.TableLayoutPanel();
            this.gbSection = new System.Windows.Forms.GroupBox();
            this.cbbSection = new System.Windows.Forms.ComboBox();
            this.gbGroup = new System.Windows.Forms.GroupBox();
            this.cbbGroup = new System.Windows.Forms.ComboBox();
            this.tbTeam = new System.Windows.Forms.TableLayoutPanel();
            this.gbTeam4 = new System.Windows.Forms.GroupBox();
            this.numTeam4 = new System.Windows.Forms.NumericUpDown();
            this.gbTeam3 = new System.Windows.Forms.GroupBox();
            this.numTeam3 = new System.Windows.Forms.NumericUpDown();
            this.gbTeam2 = new System.Windows.Forms.GroupBox();
            this.numTeam2 = new System.Windows.Forms.NumericUpDown();
            this.gbTeam1 = new System.Windows.Forms.GroupBox();
            this.numTeam1 = new System.Windows.Forms.NumericUpDown();
            this.tbWorkspace = new System.Windows.Forms.TableLayoutPanel();
            this.tbControl = new System.Windows.Forms.TableLayoutPanel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnSolution = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbTimer = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.picQuestion = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tbSection.SuspendLayout();
            this.gbSection.SuspendLayout();
            this.gbGroup.SuspendLayout();
            this.tbTeam.SuspendLayout();
            this.gbTeam4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTeam4)).BeginInit();
            this.gbTeam3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTeam3)).BeginInit();
            this.gbTeam2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTeam2)).BeginInit();
            this.gbTeam1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTeam1)).BeginInit();
            this.tbWorkspace.SuspendLayout();
            this.tbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.picTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.picBottom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1182, 953);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // picTop
            // 
            this.picTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTop.Image = global::MIT.Properties.Resources.logoct;
            this.picTop.Location = new System.Drawing.Point(3, 3);
            this.picTop.Name = "picTop";
            this.picTop.Size = new System.Drawing.Size(1176, 136);
            this.picTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTop.TabIndex = 0;
            this.picTop.TabStop = false;
            // 
            // picBottom
            // 
            this.picBottom.BackgroundImage = global::MIT.Properties.Resources.logoct;
            this.picBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBottom.Location = new System.Drawing.Point(3, 859);
            this.picBottom.Name = "picBottom";
            this.picBottom.Size = new System.Drawing.Size(1176, 91);
            this.picBottom.TabIndex = 1;
            this.picBottom.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 145);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.OldLace;
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Azure;
            this.splitContainer1.Panel2.Controls.Add(this.tbWorkspace);
            this.splitContainer1.Panel2MinSize = 550;
            this.splitContainer1.Size = new System.Drawing.Size(1176, 708);
            this.splitContainer1.SplitterDistance = 167;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnTotal, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbSection, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbTeam, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(167, 708);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.Bisque;
            this.btnTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotal.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnTotal.Location = new System.Drawing.Point(3, 654);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(161, 51);
            this.btnTotal.TabIndex = 0;
            this.btnTotal.TabStop = false;
            this.btnTotal.Text = "TOTAL";
            this.btnTotal.UseVisualStyleBackColor = false;
            // 
            // tbSection
            // 
            this.tbSection.ColumnCount = 1;
            this.tbSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbSection.Controls.Add(this.gbSection, 0, 1);
            this.tbSection.Controls.Add(this.gbGroup, 0, 0);
            this.tbSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSection.Location = new System.Drawing.Point(3, 3);
            this.tbSection.Name = "tbSection";
            this.tbSection.RowCount = 2;
            this.tbSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbSection.Size = new System.Drawing.Size(161, 171);
            this.tbSection.TabIndex = 1;
            // 
            // gbSection
            // 
            this.gbSection.Controls.Add(this.cbbSection);
            this.gbSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSection.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSection.Location = new System.Drawing.Point(3, 88);
            this.gbSection.Name = "gbSection";
            this.gbSection.Size = new System.Drawing.Size(155, 80);
            this.gbSection.TabIndex = 1;
            this.gbSection.TabStop = false;
            this.gbSection.Text = "Vòng thi";
            // 
            // cbbSection
            // 
            this.cbbSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbSection.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSection.FormattingEnabled = true;
            this.cbbSection.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbbSection.Location = new System.Drawing.Point(3, 32);
            this.cbbSection.Name = "cbbSection";
            this.cbbSection.Size = new System.Drawing.Size(149, 43);
            this.cbbSection.TabIndex = 0;
            // 
            // gbGroup
            // 
            this.gbGroup.Controls.Add(this.cbbGroup);
            this.gbGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbGroup.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGroup.Location = new System.Drawing.Point(3, 3);
            this.gbGroup.Name = "gbGroup";
            this.gbGroup.Size = new System.Drawing.Size(155, 79);
            this.gbGroup.TabIndex = 0;
            this.gbGroup.TabStop = false;
            this.gbGroup.Text = "Khối thi";
            // 
            // cbbGroup
            // 
            this.cbbGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbGroup.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGroup.FormattingEnabled = true;
            this.cbbGroup.Items.AddRange(new object[] {
            "CHUYÊN",
            "KHÔNG CHUYÊN"});
            this.cbbGroup.Location = new System.Drawing.Point(3, 32);
            this.cbbGroup.Name = "cbbGroup";
            this.cbbGroup.Size = new System.Drawing.Size(149, 43);
            this.cbbGroup.TabIndex = 0;
            // 
            // tbTeam
            // 
            this.tbTeam.BackColor = System.Drawing.Color.MistyRose;
            this.tbTeam.ColumnCount = 1;
            this.tbTeam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbTeam.Controls.Add(this.gbTeam4, 0, 3);
            this.tbTeam.Controls.Add(this.gbTeam3, 0, 2);
            this.tbTeam.Controls.Add(this.gbTeam2, 0, 1);
            this.tbTeam.Controls.Add(this.gbTeam1, 0, 0);
            this.tbTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTeam.Location = new System.Drawing.Point(3, 180);
            this.tbTeam.Name = "tbTeam";
            this.tbTeam.RowCount = 4;
            this.tbTeam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTeam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTeam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTeam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTeam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbTeam.Size = new System.Drawing.Size(161, 468);
            this.tbTeam.TabIndex = 2;
            // 
            // gbTeam4
            // 
            this.gbTeam4.AutoSize = true;
            this.gbTeam4.Controls.Add(this.numTeam4);
            this.gbTeam4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTeam4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTeam4.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTeam4.ForeColor = System.Drawing.Color.DarkBlue;
            this.gbTeam4.Location = new System.Drawing.Point(3, 354);
            this.gbTeam4.Name = "gbTeam4";
            this.gbTeam4.Size = new System.Drawing.Size(155, 111);
            this.gbTeam4.TabIndex = 5;
            this.gbTeam4.TabStop = false;
            this.gbTeam4.Text = "Team 4";
            // 
            // numTeam4
            // 
            this.numTeam4.BackColor = System.Drawing.Color.Plum;
            this.numTeam4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTeam4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numTeam4.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTeam4.ForeColor = System.Drawing.Color.DarkRed;
            this.numTeam4.Location = new System.Drawing.Point(3, 37);
            this.numTeam4.Name = "numTeam4";
            this.numTeam4.Size = new System.Drawing.Size(149, 70);
            this.numTeam4.TabIndex = 0;
            this.numTeam4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbTeam3
            // 
            this.gbTeam3.AutoSize = true;
            this.gbTeam3.Controls.Add(this.numTeam3);
            this.gbTeam3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTeam3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTeam3.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTeam3.ForeColor = System.Drawing.Color.DarkBlue;
            this.gbTeam3.Location = new System.Drawing.Point(3, 237);
            this.gbTeam3.Name = "gbTeam3";
            this.gbTeam3.Size = new System.Drawing.Size(155, 111);
            this.gbTeam3.TabIndex = 4;
            this.gbTeam3.TabStop = false;
            this.gbTeam3.Text = "Team 3";
            // 
            // numTeam3
            // 
            this.numTeam3.BackColor = System.Drawing.Color.Lavender;
            this.numTeam3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTeam3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numTeam3.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTeam3.ForeColor = System.Drawing.Color.DarkRed;
            this.numTeam3.Location = new System.Drawing.Point(3, 37);
            this.numTeam3.Name = "numTeam3";
            this.numTeam3.Size = new System.Drawing.Size(149, 70);
            this.numTeam3.TabIndex = 0;
            this.numTeam3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbTeam2
            // 
            this.gbTeam2.AutoSize = true;
            this.gbTeam2.Controls.Add(this.numTeam2);
            this.gbTeam2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTeam2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTeam2.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTeam2.ForeColor = System.Drawing.Color.DarkBlue;
            this.gbTeam2.Location = new System.Drawing.Point(3, 120);
            this.gbTeam2.Name = "gbTeam2";
            this.gbTeam2.Size = new System.Drawing.Size(155, 111);
            this.gbTeam2.TabIndex = 3;
            this.gbTeam2.TabStop = false;
            this.gbTeam2.Text = "Team 2";
            // 
            // numTeam2
            // 
            this.numTeam2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.numTeam2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTeam2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numTeam2.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTeam2.ForeColor = System.Drawing.Color.DarkRed;
            this.numTeam2.Location = new System.Drawing.Point(3, 37);
            this.numTeam2.Name = "numTeam2";
            this.numTeam2.Size = new System.Drawing.Size(149, 70);
            this.numTeam2.TabIndex = 0;
            this.numTeam2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbTeam1
            // 
            this.gbTeam1.AutoSize = true;
            this.gbTeam1.Controls.Add(this.numTeam1);
            this.gbTeam1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTeam1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTeam1.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTeam1.ForeColor = System.Drawing.Color.DarkBlue;
            this.gbTeam1.Location = new System.Drawing.Point(3, 3);
            this.gbTeam1.Name = "gbTeam1";
            this.gbTeam1.Size = new System.Drawing.Size(155, 111);
            this.gbTeam1.TabIndex = 2;
            this.gbTeam1.TabStop = false;
            this.gbTeam1.Text = "Team 1";
            // 
            // numTeam1
            // 
            this.numTeam1.BackColor = System.Drawing.Color.LightYellow;
            this.numTeam1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTeam1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numTeam1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTeam1.ForeColor = System.Drawing.Color.DarkRed;
            this.numTeam1.Location = new System.Drawing.Point(3, 37);
            this.numTeam1.Name = "numTeam1";
            this.numTeam1.Size = new System.Drawing.Size(149, 70);
            this.numTeam1.TabIndex = 0;
            this.numTeam1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbWorkspace
            // 
            this.tbWorkspace.ColumnCount = 1;
            this.tbWorkspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbWorkspace.Controls.Add(this.tbControl, 0, 1);
            this.tbWorkspace.Controls.Add(this.picQuestion, 0, 0);
            this.tbWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWorkspace.Location = new System.Drawing.Point(0, 0);
            this.tbWorkspace.MinimumSize = new System.Drawing.Size(550, 0);
            this.tbWorkspace.Name = "tbWorkspace";
            this.tbWorkspace.RowCount = 2;
            this.tbWorkspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tbWorkspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tbWorkspace.Size = new System.Drawing.Size(1003, 708);
            this.tbWorkspace.TabIndex = 0;
            // 
            // tbControl
            // 
            this.tbControl.ColumnCount = 6;
            this.tbControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tbControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tbControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tbControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tbControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tbControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tbControl.Controls.Add(this.btnNext, 5, 0);
            this.tbControl.Controls.Add(this.btnPrevious, 4, 0);
            this.tbControl.Controls.Add(this.btnSolution, 1, 0);
            this.tbControl.Controls.Add(this.btnStart, 0, 0);
            this.tbControl.Controls.Add(this.lbTimer, 3, 0);
            this.tbControl.Controls.Add(this.progressBar1, 2, 0);
            this.tbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControl.Location = new System.Drawing.Point(3, 654);
            this.tbControl.Name = "tbControl";
            this.tbControl.RowCount = 1;
            this.tbControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbControl.Size = new System.Drawing.Size(997, 51);
            this.tbControl.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnNext.Location = new System.Drawing.Point(818, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(176, 45);
            this.btnNext.TabIndex = 4;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "NEXT >>";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnPrevious.Location = new System.Drawing.Point(639, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(173, 45);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "<< PREVIOUS";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnSolution
            // 
            this.btnSolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolution.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolution.ForeColor = System.Drawing.Color.Crimson;
            this.btnSolution.Location = new System.Drawing.Point(162, 3);
            this.btnSolution.Name = "btnSolution";
            this.btnSolution.Size = new System.Drawing.Size(153, 45);
            this.btnSolution.TabIndex = 1;
            this.btnSolution.TabStop = false;
            this.btnSolution.Text = "SOLUTION";
            this.btnSolution.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(153, 45);
            this.btnStart.TabIndex = 0;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lbTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTimer.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbTimer.Location = new System.Drawing.Point(547, 0);
            this.lbTimer.Margin = new System.Windows.Forms.Padding(0);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(89, 51);
            this.lbTimer.TabIndex = 5;
            this.lbTimer.Text = "30";
            this.lbTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(321, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(223, 45);
            this.progressBar1.TabIndex = 6;
            // 
            // picQuestion
            // 
            this.picQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picQuestion.Image = global::MIT.Properties.Resources.LGCT;
            this.picQuestion.Location = new System.Drawing.Point(3, 3);
            this.picQuestion.Name = "picQuestion";
            this.picQuestion.Size = new System.Drawing.Size(997, 645);
            this.picQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQuestion.TabIndex = 1;
            this.picQuestion.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 953);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 1000);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mastering IT 2021";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottom)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tbSection.ResumeLayout(false);
            this.gbSection.ResumeLayout(false);
            this.gbGroup.ResumeLayout(false);
            this.tbTeam.ResumeLayout(false);
            this.tbTeam.PerformLayout();
            this.gbTeam4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTeam4)).EndInit();
            this.gbTeam3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTeam3)).EndInit();
            this.gbTeam2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTeam2)).EndInit();
            this.gbTeam1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTeam1)).EndInit();
            this.tbWorkspace.ResumeLayout(false);
            this.tbControl.ResumeLayout(false);
            this.tbControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picTop;
        private System.Windows.Forms.PictureBox picBottom;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tbWorkspace;
        private System.Windows.Forms.TableLayoutPanel tbControl;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnSolution;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.TableLayoutPanel tbSection;
        private System.Windows.Forms.TableLayoutPanel tbTeam;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.GroupBox gbGroup;
        private System.Windows.Forms.ComboBox cbbGroup;
        private System.Windows.Forms.GroupBox gbSection;
        private System.Windows.Forms.ComboBox cbbSection;
        private System.Windows.Forms.GroupBox gbTeam1;
        private System.Windows.Forms.NumericUpDown numTeam1;
        private System.Windows.Forms.GroupBox gbTeam4;
        private System.Windows.Forms.NumericUpDown numTeam4;
        private System.Windows.Forms.GroupBox gbTeam3;
        private System.Windows.Forms.NumericUpDown numTeam3;
        private System.Windows.Forms.GroupBox gbTeam2;
        private System.Windows.Forms.NumericUpDown numTeam2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picQuestion;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

