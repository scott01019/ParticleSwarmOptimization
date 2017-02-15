using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
  //  A class to simulate the particle swarm optimization algorithm
  public class ParticleSwarmOptimization
  {
    //  Default Constructor
    public ParticleSwarmOptimization()
    {
      this.Particles = new List<Particle>();
      this.Best = new Particle();
      this.Best.Fitness = -9999999;
      this.DT = .1;
    }

    //  GenerateParticles
    //  int num_particles, int width, int height (number of particles, width of grid, height of grid)
    //  Generates the provided number of random particles and adds them to the Particles List, also
    //  tracks the best fit particle
    public void GenerateParticles(int num_particles, int width, int height)
    {
      this.Particles.Clear();
      this.Best = new Particle();

      Random random = new Random();
      for (int i = 0; i < num_particles; ++i)
      {
        this.Particles.Add(new Particle(random.Next(0, width), random.Next(0, height), random.NextDouble(), random.NextDouble()));
      }

      foreach (Particle particle in this.Particles)
      {
        particle.ComputeFitness(width, height);
        particle.BestX = particle.X;
        particle.BestY = particle.Y;
        if (particle.Fitness > this.Best.Fitness)
        {
          this.Best.Fitness = particle.Fitness;
          this.Best.X = particle.X;
          this.Best.Y = particle.Y;
        }
      }
    }

    //  UpdateParticles
    //  int width, int height (width and height of the grid)
    //  Preforms the Particle Swarm Optimization for each particle in the Particles List
    //  for the time interval and accelerations. Also records new global best if found.
    public void UpdateParticles(int width, int height)
    {
      Random random = new Random();
      foreach (Particle particle in this.Particles)
      {
        particle.X += particle.DX * this.DT;
        particle.Y += particle.DY * this.DT;
        particle.ComputeFitness(width, height);
        particle.DX += (this.C1 * random.NextDouble() * (this.Best.X - particle.X)) + (this.C2 * random.NextDouble() * (particle.BestX - particle.X));
        particle.DY += (this.C1 * random.NextDouble() * (this.Best.Y - particle.Y)) + (this.C2 * random.NextDouble() * (particle.BestY - particle.Y));
        if (particle.Fitness > particle.BestFitness)
        {
          particle.BestFitness = particle.Fitness;
          particle.BestX = particle.X;
          particle.BestY = particle.Y;
          if (particle.BestFitness > this.Best.Fitness)
          {
            this.Best.Fitness = particle.BestFitness;
            this.Best.X = particle.X;
            this.Best.Y = particle.Y;
          }
        }
      }
      GC.Collect();
    }

    public List<Particle> Particles { get; set; } //  A list of all particles
    public Particle Best { get; set; }            //  The global best particle
    public Double C1 { get; set; }                //  Acceleration for global best
    public Double C2 { get; set; }                //  Acceleration for personal best
    public Double DT { get; set; }                //  The time interval for updates
  }
}