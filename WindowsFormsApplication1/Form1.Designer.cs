namespace WindowsFormsApplication1
{
  partial class form_pso
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
      this.button_generate = new System.Windows.Forms.Button();
      this.button_start_stop = new System.Windows.Forms.Button();
      this.button_clear = new System.Windows.Forms.Button();
      this.track_bar_particles = new System.Windows.Forms.TrackBar();
      this.panel = new System.Windows.Forms.Panel();
      this.label_particles = new System.Windows.Forms.Label();
      this.background_worker = new System.ComponentModel.BackgroundWorker();
      this.text_box_c1 = new System.Windows.Forms.TextBox();
      this.text_box_c2 = new System.Windows.Forms.TextBox();
      this.label_c1 = new System.Windows.Forms.Label();
      this.label_c2 = new System.Windows.Forms.Label();
      this.text_box_dt = new System.Windows.Forms.TextBox();
      this.label_dt = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.track_bar_particles)).BeginInit();
      this.SuspendLayout();
      // 
      // button_generate
      // 
      this.button_generate.Location = new System.Drawing.Point(13, 13);
      this.button_generate.Name = "button_generate";
      this.button_generate.Size = new System.Drawing.Size(75, 23);
      this.button_generate.TabIndex = 0;
      this.button_generate.Text = "Generate";
      this.button_generate.UseVisualStyleBackColor = true;
      this.button_generate.Click += new System.EventHandler(this.click_button_generate);
      // 
      // button_start_stop
      // 
      this.button_start_stop.Location = new System.Drawing.Point(94, 12);
      this.button_start_stop.Name = "button_start_stop";
      this.button_start_stop.Size = new System.Drawing.Size(75, 23);
      this.button_start_stop.TabIndex = 1;
      this.button_start_stop.Text = "Start";
      this.button_start_stop.UseVisualStyleBackColor = true;
      this.button_start_stop.Click += new System.EventHandler(this.button_click_start_stop);
      // 
      // button_clear
      // 
      this.button_clear.Location = new System.Drawing.Point(176, 11);
      this.button_clear.Name = "button_clear";
      this.button_clear.Size = new System.Drawing.Size(75, 23);
      this.button_clear.TabIndex = 2;
      this.button_clear.Text = "Clear";
      this.button_clear.UseVisualStyleBackColor = true;
      this.button_clear.Click += new System.EventHandler(this.click_button_clear);
      // 
      // track_bar_particles
      // 
      this.track_bar_particles.Location = new System.Drawing.Point(370, 11);
      this.track_bar_particles.Maximum = 5000;
      this.track_bar_particles.Minimum = 10;
      this.track_bar_particles.Name = "track_bar_particles";
      this.track_bar_particles.Size = new System.Drawing.Size(365, 45);
      this.track_bar_particles.TabIndex = 3;
      this.track_bar_particles.Value = 10;
      this.track_bar_particles.Scroll += new System.EventHandler(this.track_bar_scroll_particles);
      // 
      // panel
      // 
      this.panel.BackColor = System.Drawing.SystemColors.ButtonShadow;
      this.panel.Location = new System.Drawing.Point(12, 62);
      this.panel.Name = "panel";
      this.panel.Size = new System.Drawing.Size(1257, 634);
      this.panel.TabIndex = 5;
      // 
      // label_particles
      // 
      this.label_particles.Location = new System.Drawing.Point(277, 14);
      this.label_particles.Name = "label_particles";
      this.label_particles.Size = new System.Drawing.Size(87, 21);
      this.label_particles.TabIndex = 0;
      // 
      // background_worker
      // 
      this.background_worker.WorkerSupportsCancellation = true;
      this.background_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.background_worker1_do_work);
      // 
      // text_box_c1
      // 
      this.text_box_c1.Location = new System.Drawing.Point(885, 17);
      this.text_box_c1.Name = "text_box_c1";
      this.text_box_c1.Size = new System.Drawing.Size(49, 20);
      this.text_box_c1.TabIndex = 6;
      this.text_box_c1.Text = "1.0";
      this.text_box_c1.TextChanged += new System.EventHandler(this.text_box_changed_c1);
      // 
      // text_box_c2
      // 
      this.text_box_c2.Location = new System.Drawing.Point(1113, 16);
      this.text_box_c2.Name = "text_box_c2";
      this.text_box_c2.Size = new System.Drawing.Size(49, 20);
      this.text_box_c2.TabIndex = 7;
      this.text_box_c2.Text = "1.0";
      this.text_box_c2.TextChanged += new System.EventHandler(this.text_box_changed_c2);
      // 
      // label_c1
      // 
      this.label_c1.AutoSize = true;
      this.label_c1.Location = new System.Drawing.Point(777, 19);
      this.label_c1.Name = "label_c1";
      this.label_c1.Size = new System.Drawing.Size(102, 13);
      this.label_c1.TabIndex = 8;
      this.label_c1.Text = "Global Acceleration:";
      // 
      // label_c2
      // 
      this.label_c2.AutoSize = true;
      this.label_c2.Location = new System.Drawing.Point(970, 18);
      this.label_c2.Name = "label_c2";
      this.label_c2.Size = new System.Drawing.Size(137, 13);
      this.label_c2.TabIndex = 9;
      this.label_c2.Text = "Personal Best Acceleration:";
      // 
      // text_box_dt
      // 
      this.text_box_dt.Location = new System.Drawing.Point(1220, 16);
      this.text_box_dt.Name = "text_box_dt";
      this.text_box_dt.Size = new System.Drawing.Size(49, 20);
      this.text_box_dt.TabIndex = 10;
      this.text_box_dt.Text = "0.1";
      this.text_box_dt.TextChanged += new System.EventHandler(this.text_box_changed_dt);
      // 
      // label_dt
      // 
      this.label_dt.AutoSize = true;
      this.label_dt.Location = new System.Drawing.Point(1195, 19);
      this.label_dt.Name = "label_dt";
      this.label_dt.Size = new System.Drawing.Size(19, 13);
      this.label_dt.TabIndex = 11;
      this.label_dt.Text = "dt:";
      // 
      // form_pso
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1281, 708);
      this.Controls.Add(this.label_dt);
      this.Controls.Add(this.text_box_dt);
      this.Controls.Add(this.label_c1);
      this.Controls.Add(this.text_box_c2);
      this.Controls.Add(this.label_c2);
      this.Controls.Add(this.text_box_c1);
      this.Controls.Add(this.label_particles);
      this.Controls.Add(this.panel);
      this.Controls.Add(this.track_bar_particles);
      this.Controls.Add(this.button_clear);
      this.Controls.Add(this.button_start_stop);
      this.Controls.Add(this.button_generate);
      this.DoubleBuffered = true;
      this.Name = "form_pso";
      this.Text = "PSO";
      ((System.ComponentModel.ISupportInitialize)(this.track_bar_particles)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button_generate;
    private System.Windows.Forms.Button button_start_stop;
    private System.Windows.Forms.Button button_clear;
    private System.Windows.Forms.TrackBar track_bar_particles;
    private System.Windows.Forms.Panel panel;
    private System.Windows.Forms.Label label_particles;
    private System.ComponentModel.BackgroundWorker background_worker;
    private System.Windows.Forms.TextBox text_box_c1;
    private System.Windows.Forms.TextBox text_box_c2;
    private System.Windows.Forms.Label label_c1;
    private System.Windows.Forms.Label label_c2;
    private System.Windows.Forms.TextBox text_box_dt;
    private System.Windows.Forms.Label label_dt;
  }
}

