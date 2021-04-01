
using System.Windows.Forms;

namespace MecanumWheelsControl
{
    partial class MecanumControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MecanumControl));
            this.connect_btn = new System.Windows.Forms.Button();
            this.portsList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureConnect = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.speed_lbl = new System.Windows.Forms.Label();
            this.speedSlider = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bwr_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.right_btn = new System.Windows.Forms.Button();
            this.round_btn = new System.Windows.Forms.Button();
            this.fwr_btn = new System.Windows.Forms.Button();
            this.fwd_btn = new System.Windows.Forms.Button();
            this.bwl_btn = new System.Windows.Forms.Button();
            this.left_btn = new System.Windows.Forms.Button();
            this.fwl_btn = new System.Windows.Forms.Button();
            this.direction_btn = new System.Windows.Forms.Button();
            this.info_lbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.feedback_lbl = new System.Windows.Forms.Label();
            this.wf_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.pid_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kd_num = new System.Windows.Forms.NumericUpDown();
            this.ki_num = new System.Windows.Forms.NumericUpDown();
            this.kp_num = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedSlider)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kd_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ki_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kp_num)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // connect_btn
            // 
            this.connect_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_btn.Location = new System.Drawing.Point(24, 82);
            this.connect_btn.Margin = new System.Windows.Forms.Padding(4);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(237, 38);
            this.connect_btn.TabIndex = 0;
            this.connect_btn.Text = "Свържи се";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // portsList
            // 
            this.portsList.FormattingEnabled = true;
            this.portsList.Location = new System.Drawing.Point(91, 36);
            this.portsList.Margin = new System.Windows.Forms.Padding(4);
            this.portsList.Name = "portsList";
            this.portsList.Size = new System.Drawing.Size(169, 25);
            this.portsList.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pictureConnect);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.portsList);
            this.groupBox1.Controls.Add(this.connect_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(400, 139);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ВРЪЗКА С ПЛАТФОРМАТА";
            // 
            // pictureConnect
            // 
            this.pictureConnect.Image = global::MecanumWheelsControl.Properties.Resources.discon;
            this.pictureConnect.Location = new System.Drawing.Point(289, 82);
            this.pictureConnect.Margin = new System.Windows.Forms.Padding(4);
            this.pictureConnect.Name = "pictureConnect";
            this.pictureConnect.Size = new System.Drawing.Size(59, 38);
            this.pictureConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureConnect.TabIndex = 4;
            this.pictureConnect.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MecanumWheelsControl.Properties.Resources.bth;
            this.pictureBox1.Location = new System.Drawing.Point(298, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Порт:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.speed_lbl);
            this.groupBox2.Controls.Add(this.speedSlider);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 321);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(399, 83);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "СКОРОСТ";
            // 
            // speed_lbl
            // 
            this.speed_lbl.AutoSize = true;
            this.speed_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed_lbl.Location = new System.Drawing.Point(136, 55);
            this.speed_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.speed_lbl.Name = "speed_lbl";
            this.speed_lbl.Size = new System.Drawing.Size(92, 24);
            this.speed_lbl.TabIndex = 1;
            this.speed_lbl.Text = "speed_lbl";
            // 
            // speedSlider
            // 
            this.speedSlider.Location = new System.Drawing.Point(24, 16);
            this.speedSlider.Margin = new System.Windows.Forms.Padding(4);
            this.speedSlider.Maximum = 100;
            this.speedSlider.Name = "speedSlider";
            this.speedSlider.Size = new System.Drawing.Size(341, 56);
            this.speedSlider.TabIndex = 0;
            this.speedSlider.Value = 80;
            this.speedSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.speedSlider_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bwr_btn);
            this.panel1.Controls.Add(this.back_btn);
            this.panel1.Controls.Add(this.right_btn);
            this.panel1.Controls.Add(this.round_btn);
            this.panel1.Controls.Add(this.fwr_btn);
            this.panel1.Controls.Add(this.fwd_btn);
            this.panel1.Controls.Add(this.bwl_btn);
            this.panel1.Controls.Add(this.left_btn);
            this.panel1.Controls.Add(this.fwl_btn);
            this.panel1.Location = new System.Drawing.Point(30, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 449);
            this.panel1.TabIndex = 6;
            // 
            // bwr_btn
            // 
            this.bwr_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bwr_btn.Image = global::MecanumWheelsControl.Properties.Resources.bwl;
            this.bwr_btn.Location = new System.Drawing.Point(341, 295);
            this.bwr_btn.Margin = new System.Windows.Forms.Padding(4);
            this.bwr_btn.Name = "bwr_btn";
            this.bwr_btn.Size = new System.Drawing.Size(152, 132);
            this.bwr_btn.TabIndex = 8;
            this.bwr_btn.UseVisualStyleBackColor = true;
            this.bwr_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bwr_btn_MouseDown);
            this.bwr_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bwr_btn_MouseUp);
            // 
            // back_btn
            // 
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_btn.Image = global::MecanumWheelsControl.Properties.Resources.backward;
            this.back_btn.Location = new System.Drawing.Point(181, 295);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(152, 132);
            this.back_btn.TabIndex = 7;
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.back_btn_MouseDown);
            this.back_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.back_btn_MouseUp);
            // 
            // right_btn
            // 
            this.right_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.right_btn.Image = global::MecanumWheelsControl.Properties.Resources.right;
            this.right_btn.Location = new System.Drawing.Point(341, 155);
            this.right_btn.Margin = new System.Windows.Forms.Padding(4);
            this.right_btn.Name = "right_btn";
            this.right_btn.Size = new System.Drawing.Size(152, 132);
            this.right_btn.TabIndex = 6;
            this.right_btn.UseVisualStyleBackColor = true;
            this.right_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.right_btn_MouseDown);
            this.right_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.right_btn_MouseUp);
            // 
            // round_btn
            // 
            this.round_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.round_btn.Image = global::MecanumWheelsControl.Properties.Resources.roundabout;
            this.round_btn.Location = new System.Drawing.Point(181, 156);
            this.round_btn.Margin = new System.Windows.Forms.Padding(4);
            this.round_btn.Name = "round_btn";
            this.round_btn.Size = new System.Drawing.Size(152, 132);
            this.round_btn.TabIndex = 5;
            this.round_btn.UseVisualStyleBackColor = true;
            this.round_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.round_btn_MouseDown);
            this.round_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.round_btn_MouseUp);
            // 
            // fwr_btn
            // 
            this.fwr_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fwr_btn.Image = global::MecanumWheelsControl.Properties.Resources.fwr;
            this.fwr_btn.Location = new System.Drawing.Point(341, 16);
            this.fwr_btn.Margin = new System.Windows.Forms.Padding(4);
            this.fwr_btn.Name = "fwr_btn";
            this.fwr_btn.Size = new System.Drawing.Size(152, 132);
            this.fwr_btn.TabIndex = 4;
            this.fwr_btn.UseVisualStyleBackColor = true;
            this.fwr_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fwr_btn_MouseDown);
            this.fwr_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fwr_btn_MouseUp);
            // 
            // fwd_btn
            // 
            this.fwd_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fwd_btn.Image = global::MecanumWheelsControl.Properties.Resources.forward;
            this.fwd_btn.Location = new System.Drawing.Point(181, 16);
            this.fwd_btn.Margin = new System.Windows.Forms.Padding(4);
            this.fwd_btn.Name = "fwd_btn";
            this.fwd_btn.Size = new System.Drawing.Size(152, 132);
            this.fwd_btn.TabIndex = 3;
            this.fwd_btn.UseVisualStyleBackColor = true;
            this.fwd_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fwd_btn_MouseDown);
            this.fwd_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fwd_btn_MouseUp);
            // 
            // bwl_btn
            // 
            this.bwl_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bwl_btn.Image = global::MecanumWheelsControl.Properties.Resources.bwr;
            this.bwl_btn.Location = new System.Drawing.Point(21, 295);
            this.bwl_btn.Margin = new System.Windows.Forms.Padding(4);
            this.bwl_btn.Name = "bwl_btn";
            this.bwl_btn.Size = new System.Drawing.Size(152, 132);
            this.bwl_btn.TabIndex = 2;
            this.bwl_btn.UseVisualStyleBackColor = true;
            this.bwl_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bwl_btn_MouseDown);
            this.bwl_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bwl_btn_MouseUp);
            // 
            // left_btn
            // 
            this.left_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.left_btn.Image = global::MecanumWheelsControl.Properties.Resources.left;
            this.left_btn.Location = new System.Drawing.Point(21, 156);
            this.left_btn.Margin = new System.Windows.Forms.Padding(4);
            this.left_btn.Name = "left_btn";
            this.left_btn.Size = new System.Drawing.Size(152, 132);
            this.left_btn.TabIndex = 1;
            this.left_btn.UseVisualStyleBackColor = true;
            this.left_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.left_btn_MouseDown);
            this.left_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.left_btn_MouseUp);
            // 
            // fwl_btn
            // 
            this.fwl_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fwl_btn.FlatAppearance.BorderSize = 0;
            this.fwl_btn.Image = global::MecanumWheelsControl.Properties.Resources.fwl;
            this.fwl_btn.Location = new System.Drawing.Point(21, 16);
            this.fwl_btn.Margin = new System.Windows.Forms.Padding(4);
            this.fwl_btn.Name = "fwl_btn";
            this.fwl_btn.Size = new System.Drawing.Size(152, 132);
            this.fwl_btn.TabIndex = 0;
            this.fwl_btn.UseVisualStyleBackColor = true;
            this.fwl_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fwl_btn_MouseDown);
            this.fwl_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fwl_btn_MouseUp);
            // 
            // direction_btn
            // 
            this.direction_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direction_btn.Location = new System.Drawing.Point(16, 431);
            this.direction_btn.Name = "direction_btn";
            this.direction_btn.Size = new System.Drawing.Size(396, 40);
            this.direction_btn.TabIndex = 7;
            this.direction_btn.Text = "ПОСОКА НА ВЪРТЕНЕ";
            this.direction_btn.UseVisualStyleBackColor = true;
            this.direction_btn.Click += new System.EventHandler(this.direction_btn_Click);
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_lbl.Location = new System.Drawing.Point(300, 509);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(690, 25);
            this.info_lbl.TabIndex = 9;
            this.info_lbl.Text = " Дипломант: инж. Венцислав Начев, ръководител: проф. Георги Павлов";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.feedback_lbl);
            this.groupBox3.Controls.Add(this.wf_btn);
            this.groupBox3.Controls.Add(this.reset_btn);
            this.groupBox3.Controls.Add(this.pid_btn);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.kd_num);
            this.groupBox3.Controls.Add(this.ki_num);
            this.groupBox3.Controls.Add(this.kp_num);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1008, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 479);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PID НАСТРОЙКА";
            // 
            // feedback_lbl
            // 
            this.feedback_lbl.AutoSize = true;
            this.feedback_lbl.BackColor = System.Drawing.Color.Yellow;
            this.feedback_lbl.Location = new System.Drawing.Point(30, 377);
            this.feedback_lbl.Name = "feedback_lbl";
            this.feedback_lbl.Size = new System.Drawing.Size(183, 20);
            this.feedback_lbl.TabIndex = 15;
            this.feedback_lbl.Text = "Отворена система";
            // 
            // wf_btn
            // 
            this.wf_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.wf_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wf_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wf_btn.Location = new System.Drawing.Point(34, 283);
            this.wf_btn.Name = "wf_btn";
            this.wf_btn.Size = new System.Drawing.Size(172, 74);
            this.wf_btn.TabIndex = 14;
            this.wf_btn.Text = "БЕЗ ОБРАТНА ВРЪЗКА";
            this.wf_btn.UseVisualStyleBackColor = false;
            this.wf_btn.Click += new System.EventHandler(this.wf_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reset_btn.Location = new System.Drawing.Point(34, 220);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(172, 44);
            this.reset_btn.TabIndex = 13;
            this.reset_btn.Text = "RESET PID";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // pid_btn
            // 
            this.pid_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pid_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pid_btn.Location = new System.Drawing.Point(34, 161);
            this.pid_btn.Name = "pid_btn";
            this.pid_btn.Size = new System.Drawing.Size(172, 44);
            this.pid_btn.TabIndex = 6;
            this.pid_btn.Text = "НАСТРОЙ PID";
            this.pid_btn.UseVisualStyleBackColor = false;
            this.pid_btn.Click += new System.EventHandler(this.pid_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kд:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kи:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Кп:";
            // 
            // kd_num
            // 
            this.kd_num.DecimalPlaces = 2;
            this.kd_num.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.kd_num.Location = new System.Drawing.Point(93, 112);
            this.kd_num.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.kd_num.Name = "kd_num";
            this.kd_num.Size = new System.Drawing.Size(113, 27);
            this.kd_num.TabIndex = 2;
            this.kd_num.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // ki_num
            // 
            this.ki_num.DecimalPlaces = 2;
            this.ki_num.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ki_num.Location = new System.Drawing.Point(91, 73);
            this.ki_num.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ki_num.Name = "ki_num";
            this.ki_num.Size = new System.Drawing.Size(113, 27);
            this.ki_num.TabIndex = 1;
            this.ki_num.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // kp_num
            // 
            this.kp_num.DecimalPlaces = 2;
            this.kp_num.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.kp_num.Location = new System.Drawing.Point(91, 40);
            this.kp_num.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.kp_num.Name = "kp_num";
            this.kp_num.Size = new System.Drawing.Size(113, 27);
            this.kp_num.TabIndex = 0;
            this.kp_num.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(423, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(579, 479);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "УПРАВЛЕНИЕ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MecanumWheelsControl.Properties.Resources.logovtu;
            this.pictureBox2.Location = new System.Drawing.Point(12, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(405, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // MecanumControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1285, 554);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.direction_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MecanumControl";
            this.Text = "УПРАВЛЕНИЕ НА МОБИЛНА ПЛАТФОРМА С ВСЕПОСОЧНИ КОЛЕЛА";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedSlider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kd_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ki_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kp_num)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.ComboBox portsList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar speedSlider;
        private System.Windows.Forms.Label speed_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bwr_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button right_btn;
        private System.Windows.Forms.Button round_btn;
        private System.Windows.Forms.Button fwr_btn;
        private System.Windows.Forms.Button fwd_btn;
        private System.Windows.Forms.Button bwl_btn;
        private System.Windows.Forms.Button left_btn;
        private System.Windows.Forms.Button fwl_btn;
        private Button direction_btn;
        private Label info_lbl;
        private GroupBox groupBox3;
        private Button reset_btn;
        private Button pid_btn;
        private Label label3;
        private Label label2;
        private Label label4;
        private NumericUpDown kd_num;
        private NumericUpDown ki_num;
        private NumericUpDown kp_num;
        private Button wf_btn;
        private Label feedback_lbl;
        private GroupBox groupBox4;
        private PictureBox pictureBox2;
    }
}

