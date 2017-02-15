using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
  //  A Form class to run the GUI of our program.
  public partial class form_pso : Form
  {
    //  form_pso Default Constructor
    //  Initializes fields, and particles label. Also enables and disables
    //  appropriate inputs and buttons as necessary.
    public form_pso()
    {
      InitializeComponent();
      this.PSO = new ParticleSwarmOptimization();
      this.PSO.C1 = 0.3;
      this.PSO.C2 = 1.0;
      this.PSO.DT = 0.01;
      this.label_particles.Text = "Particles (" + this.track_bar_particles.Value + "): ";

      this.button_start_stop.Enabled = false;
      this.button_clear.Enabled = false;
    }

    //  click_button_generate
    //  Generates a new list of particles based on the number of particles selected.
    //  Also draws particles to the panel, and enables and disables appropriate inputs
    //  and buttons as necessary.
    private void click_button_generate(object sender, EventArgs e)
    {
      this.PSO.GenerateParticles(this.track_bar_particles.Value, this.panel.Width, this.panel.Height);
      this.DrawParticles();
      this.button_start_stop.Enabled = true;
      this.button_clear.Enabled = true;
      this.button_generate.Enabled = false;
    }

    //  click_button_clear
    //  Controls the clear button. When clicked clears the panel. Enables
    //  and disables the appropriate inputs and buttons as necessary.
    private void click_button_clear(object sender, EventArgs e)
    {
      this.Clear();
      this.button_generate.Enabled = true;
      this.button_start_stop.Enabled = false;
      this.button_clear.Enabled = false;
    }

    //  button_click_start_stop
    //  Controls the start/stop button. Runs algorithm when start is clicked.
    //  Stops aglorithm when stop is clicked. Disables and Enables appropriate
    //  inputs and buttons as necessary.
    private void button_click_start_stop(object sender, EventArgs e)
    {
      String value = this.button_start_stop.Text;
      if (value == "Start")
      {
        this.button_start_stop.Text = "Stop";
        this.background_worker.RunWorkerAsync();
        this.button_clear.Enabled = false;
        this.button_generate.Enabled = false;
        this.text_box_c1.Enabled = false;
        this.text_box_c2.Enabled = false;
        this.text_box_dt.Enabled = false;
      }
      else
      {
        this.button_start_stop.Text = "Start";
        this.background_worker.CancelAsync();
        this.button_clear.Enabled = true;
        this.button_generate.Enabled = false;
        this.text_box_c1.Enabled = true;
        this.text_box_c2.Enabled = true;
        this.text_box_dt.Enabled = true;
      }
    }

    //  track_bar_scroll_particles
    //  Updates the label to display the current number of the particles track bar.
    private void track_bar_scroll_particles(object sender, EventArgs e)
    {
      this.label_particles.Text = "Particles (" + this.track_bar_particles.Value + "): ";
    }

    //  DrawParticles
    //  Iterates through list of particles and draws them to the panel.
    public void DrawParticles()
    {
      Graphics g = panel.CreateGraphics();
      SolidBrush sb = new SolidBrush(Color.Blue);
      foreach (Particle particle in this.PSO.Particles)
      {
        g.FillEllipse(sb, new Rectangle(Convert.ToInt32(particle.X), Convert.ToInt32(particle.Y), 4, 4));
      }

      sb.Color = Color.Green;
      g.FillEllipse(sb, new Rectangle(Convert.ToInt32(this.PSO.Best.X), Convert.ToInt32(this.PSO.Best.Y), 10, 10));
      sb.Dispose();
      g.Dispose();
    }

    //  background_worker1_do_work
    //  Runs the PSO aglorithm in a separate thread from the main thread.
    private void background_worker1_do_work(object sender, DoWorkEventArgs e)
    {
      while (this.background_worker.CancellationPending == false)
      {
        this.PSO.UpdateParticles(this.panel.Width, this.panel.Height);
        this.Clear();
        this.DrawParticles();
        GC.Collect();
        //Thread.Sleep(150);
      }
    }

    //  Clear
    //  Clears the panel of all graphics.
    private void Clear()
    {
      Graphics g = this.panel.CreateGraphics();
      g.Clear(this.panel.BackColor);
      g.Dispose();
    }

    //  text_box_changed_c1
    //  Updates the value for PSO global best acceleration when input is valid.
    private void text_box_changed_c1(object sender, EventArgs e)
    {
      //  if valid input update global best acceleration
      try
      {
        this.PSO.C1 = Convert.ToDouble(this.text_box_c1.Text);
      }
      catch
      {
        //  Do nothing;
      }
    }

    //  text_box_changed_c2
    //  Updates the value for PSO personal best acceleration when input is valid.
    private void text_box_changed_c2(object sender, EventArgs e)
    {
      //  if valid input update personal best acceleration
      try
      {
        this.PSO.C2 = Convert.ToDouble(this.text_box_c2.Text);
      }
      catch
      {
        //  Do nothing;
      }
    }

    //  text_box_changed_dt
    //  Updates the value for PSO time interval when input is valid.
    private void text_box_changed_dt(object sender, EventArgs e)
    {
      //  if valid input update DT
      try
      {
        this.PSO.DT = Convert.ToDouble(this.text_box_dt.Text);
      }
      catch
      {
        //  Do nothing;
      }
    }

    public ParticleSwarmOptimization PSO { get; set; }  //  A Particle Swarm Optimization object to run the PSO algoirthm
  }
}
