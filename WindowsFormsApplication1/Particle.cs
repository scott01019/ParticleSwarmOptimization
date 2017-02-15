using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
  //  A class to describe a particle
  public class Particle
  {
    //  Default Constructor
    public Particle()
    {
    }

    //  Particle Constructor
    //  Double x, Double y, Double dx, Double dy (x-coordinate, y-coordinate, x-velocity, y-velocity)
    public Particle(Double x, Double y, Double dx, Double dy)
    {
      this.X = x;
      this.Y = y;
      this.DX = dx;
      this.DY = dy;
    }

    //  ComputFitness
    //  Double width, Double height (the width and height of grid)
    //  Computes and sets the fitness of the particle from the sombrero function
    public void ComputeFitness(Double width, Double height)
    {
      if (this.X < 0.0 || this.X > width || this.Y < 0.0 || this.Y > height)
      {
        //  bad fitness if they are not on the panel
        this.Fitness = 0.0;
      }
      else
      {
        //  calculate the distance
        Double distance = Math.Sqrt((this.X - width / 2.0) * (this.X - width / 2.0) + (this.Y - height / 2.0) * (this.Y - height / 2.0));
        //  the sombrero function
        if (distance != 0.0)
          this.Fitness = Math.Sin(distance) / distance;
        else
          this.Fitness = 1.0;
      }
    }

    public Double X { get; set; }             //  x-coordinate
    public Double Y { get; set; }             //  y-coordinate
    public Double DX { get; set; }            //  x-velocity component
    public Double DY { get; set; }            //  y-velocity component
    public Double Fitness { get; set; }       //  fitness
    public Double BestX { get; set; }         //  personal best x
    public Double BestY { get; set; }         //  personal best y
    public Double BestFitness { get; set; }   //  personal best fitness
  }
}
