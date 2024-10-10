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


            int hacker = int.Parse(hackerText.Text);
            int server = int.Parse(serverText.Text);
            float probablity = float.Parse(probText.Text);

            
            float lineWidth = pictureBox1.Width / (float)server;
            float lineHeight = pictureBox1.Height / (float)server;

            
            PointF point1 = new PointF(0.0f, 0.0f);


            List<int> scores = DrawGraph(graph, server, hacker, probablity, lineWidth, lineHeight);


            double averageScore = recursiveAverage(scores);
            averageBox.Text = averageScore.ToString("F2");

            DrawHistogram(histoGram, hacker, server, scores, lineHeight);
        }

        private List<int> DrawGraph(Graphics graph, int servers, int hackers, float prob, float width, float height)
        {
            List<int> totalscores = new List<int>();

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

                }
                totalscores.Add(score); //list of the hacker's score
            }

            return totalscores;
        }

        private void DrawHistogram(Graphics graph, int hackers, int servers, List<int> scores, float height)
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

    }
}
