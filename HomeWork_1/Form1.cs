using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace HomeWork_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Graphics graph = pictureBox1.CreateGraphics();
            graph.Clear(Color.White);

            Graphics histoGram = pictureBox2.CreateGraphics();
            histoGram.Clear(Color.White);


            Graphics randomWalk = pictureBox3.CreateGraphics();
            randomWalk.Clear(Color.White);

            Graphics relativeWalk = pictureBox4.CreateGraphics();
            relativeWalk.Clear(Color.White);


            int hacker = int.Parse(hackerText.Text);
            int server = int.Parse(serverText.Text);
            float probability = float.Parse(probText.Text);

            int timeStamp = int.Parse(time.Text);
            
            float lineWidth = pictureBox1.Width / (float)server;
            float lineHeight = pictureBox1.Height / (float)server;

            
            PointF point1 = new PointF(0.0f, 0.0f);


            List<int> scores = DrawGraph(graph, server, hacker, probability, lineWidth, lineHeight, timeStamp);

            //score +1/-1
            List<int> realistic = realisticWalk(randomWalk, server, hacker, probability, lineWidth, lineHeight);

            List<int> relative = relativisticWalk(relativeWalk, server, hacker, probability, lineWidth, lineHeight);


            double averageScore = recursiveAverage(scores);
            averageBox.Text = averageScore.ToString("F2");

            DrawHistogram1(histoGram, hacker, server, scores, lineHeight);

            double variance = CalculateVariance(realistic);
            varianceBox.Text = variance.ToString("F2");
        }

        private List<int> DrawGraph(Graphics graph, int servers, int hackers, float prob, float width, float height, int timeStamp)
        {
            List<int> totalscores = new List<int>();
            List<int> partialScores = new List<int>();


            float lineWidth = pictureBox1.Width / (float)servers;
            float lineHeight = pictureBox1.Height / (float)servers;

            Random rnd = new Random();


            for (int i = 0; i < hackers; i++)
            {

                Pen p = new Pen(Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)));

                int score = 0;


                PointF start = new PointF(0.0f, pictureBox1.Height);


                for (int j = 0; j < servers; j++)
                {

                    if (rnd.NextDouble() <= prob)
                    {

                        PointF end = new PointF(start.X, start.Y - lineHeight);
                        graph.DrawLine(p, start, end);
                        start = end;
                        score++;
                    }

                    PointF next = new PointF(start.X + lineWidth, start.Y);
                    graph.DrawLine(p, start, next);
                    start = next;


                    if (j == timeStamp - 1)
                    {
                        partialScores.Add(score);
                    }
                }

                totalscores.Add(score);
            }
            float xOffset = lineWidth * timeStamp;   
            float yOffset = pictureBox1.Height;      

            DrawHistogram2(graph, hackers, servers, partialScores, height, xOffset, yOffset);

            return totalscores; 
        }

        private List<int> realisticWalk(Graphics randomWalk, int hackers, int servers, float prob, float width, float height)
        {
            List<int> totalScores = new List<int>();

            float lineWidth = pictureBox3.Width / (float)servers;
            float lineHeight = pictureBox3.Height / (float)servers;

            Random rnd = new Random();
            for (int i = 0; i < hackers; i++)
            {
                Pen p = new Pen(Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)));

                int score = 0;

                PointF start = new PointF(0.0f, pictureBox3.Height / 2);

                for (int j = 0; j < servers; j++)
                {
                    // Check if the hacker penetrates the server
                    if (rnd.NextDouble() <= prob)
                    {
                        // Move the line upwards (success) and increase the score
                        PointF end = new PointF(start.X, start.Y - lineHeight); // Go up one step
                        randomWalk.DrawLine(p, start, end);
                        start = end;
                        score++;
                    }

                    else
                    {
                        // Move the line downwards (failure) and decrease the score
                        PointF end = new PointF(start.X, start.Y + lineHeight); // Go down one step
                        randomWalk.DrawLine(p, start, end);
                        start = end;
                        score--;  // Decrease the score
                    }

                    // Move horizontally to the next server
                    PointF next = new PointF(start.X + lineWidth, start.Y);
                    randomWalk.DrawLine(p, start, next);
                    start = next;
                }
                totalScores.Add(score); //list of the hacker's score
            }

            return totalScores;

        }


        private void DrawHistogram1(Graphics graph, int hackers, int servers, List<int> scores, float height)
        {
            Pen p = new Pen(Color.White);

            Pen penna = new Pen(Color.Black);
            
            var g = scores.GroupBy(i => i).OrderBy(group => group.Key);


            var m1 = scores.GroupBy(i => i).OrderByDescending(group => group.Count()).First().Count();

            int diffScores = scores.Distinct().Count();

            float scoreHeigth = (pictureBox2.Width * 0.9f) / (float)m1;
            float scoreWidth = (pictureBox2.Height * 0.6f) / (float)diffScores;

            float startPoint = pictureBox2.Height * 0.9f;

            foreach (var grp in g)
            {

                SolidBrush brush = new SolidBrush(Color.Coral);


                RectangleF rect = new RectangleF(0, pictureBox1.Height - height * grp.Key - height / 2, scoreHeigth * grp.Count(), height);
                
                graph.FillRectangle(brush, rect);
                graph.DrawRectangle(p, 0f,  pictureBox1.Height - height*grp.Key - height/2, scoreHeigth * grp.Count(), height);
                
            }
        }

        private void DrawHistogram2(Graphics graph, int hackers, int servers, List<int> scores, float height, float xOffset, float yOffset)
        {
            Pen p = new Pen(Color.White);
            Pen penna = new Pen(Color.Black);

            var g = scores.GroupBy(i => i).OrderBy(group => group.Key);

            var m1 = scores.GroupBy(i => i).OrderByDescending(group => group.Count()).First().Count();

            
            int diffScores = scores.Distinct().Count();

           
            float scoreHeigth = (pictureBox2.Width * 0.9f) / (float)m1 * 0.3f; 
            float scoreWidth = (pictureBox2.Height * 0.6f) / (float)diffScores * 0.3f;

            
            foreach (var grp in g)
            {
                SolidBrush brush = new SolidBrush(Color.Aquamarine);

                
                float rectX = xOffset;  
                float rectY = yOffset - (height * grp.Key); 

                RectangleF rect = new RectangleF(rectX, rectY, scoreHeigth * grp.Count(), height);

                graph.FillRectangle(brush, rect);
                graph.DrawRectangle(p, rectX, rectY, scoreHeigth * grp.Count(), height);
            }
        }

        private List<int> relativisticWalk(Graphics relativeWalk, int servers, int hackers, float probability, float lineWidth, float lineHeight)
        {
            Random rnd = new Random();
            List<int> totalScores = new List<int>();  // Lista per contenere gli score di tutti gli hacker

            // Itera su ogni hacker
            for (int i = 0; i < hackers; i++)
            {
                // Inizializza score per l'hacker corrente
                int jump = 0;
                int attempts = 0;

                // Punto di partenza in basso a sinistra
                PointF start = new PointF(0.0f, pictureBox4.Height / 2);

                
                Pen p = new Pen(Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)));

                for (int j = 0; j < servers; j++)
                {
                    attempts++;  

                    
                    bool penetrationSuccess = rnd.NextDouble() <= probability;

                    
                    if (penetrationSuccess)
                    {
                        jump++;  
                    }

                    float stepSize = lineHeight * (float)jump / attempts; // Movimento proporzionale

                    // Determina la direzione del passo
                    PointF end;
                    if (penetrationSuccess)
                    {
                        end = new PointF(start.X, start.Y - stepSize); // Salita
                    }
                    else
                    {
                        end = new PointF(start.X, start.Y + stepSize); // Discesa
                    }

                    relativeWalk.DrawLine(p, start, end);
                    start = end;
                   
                    PointF next = new PointF(start.X + lineWidth, start.Y);
                    relativeWalk.DrawLine(p, start, next);
                    start = next;
                }

                
                totalScores.Add(jump);
            }

            return totalScores;
        }



        private double recursiveAverage(List<int> scores)
        {    
            double recursiveSum(List<int> list)
            {
                if (list.Count == 1) 
                {
                    return list[0];
                }
                else
                { 
                    return list[0] + recursiveSum(list.GetRange(1, list.Count - 1));
                }
            }
            if (scores.Count == 0) 
            {
                return 0;
            }
            return recursiveSum(scores) / scores.Count; 
        }

        public static double CalculateVariance(List<int> data)
        {
            if (data.Count == 0)
            {
                throw new ArgumentException("The data list cannot be empty.");
            }

            // Calculate the mean
            double mean = 0;
            foreach (var number in data)
            {
                mean += number;
            }
            mean /= data.Count;

            // Calculate the variance
            double variance = 0;
            foreach (var number in data)
            {
                variance += Math.Pow(number - mean, 2);
            }
            variance /= (data.Count - 1); // Sample variance

            return variance;
        }

    }
}
