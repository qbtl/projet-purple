using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjetPurplePong
{
    public partial class Pong : Form
    {

        // Init players and ball
        Player joueur1;
        Player joueur2;
        Ball balle;

        // init score to check if a player has won
        int score;

        public Pong(Settings settings)
        {
            InitializeComponent();

            // Init players with their controls as selected in the settings window at the beginning of the game.
            joueur1 = new Player(settings.PlayerOneUp, settings.PlayerOneDown, Joueur1);
            joueur2 = new Player(settings.PlayerTwoUp, settings.PlayerTwoDown, Joueur2);

            // Init the ball and match score
            balle = new Ball(Ball, Ball.Left, Ball.Top);
            score = settings.score;

            // Center the ball to the center of the screen
            Ball.Left = (this.Width / 2) - (Ball.Width / 2);

        }

        // make sure the player 2 is always on the right side
        private void ResponsiveInterface_Tick(object sender, EventArgs e)
        {
            // Adjust interface according to the window size
            Joueur2.Left = this.Size.Width - 44;
        }

        private void KeyPressed(object sender, KeyEventArgs keyPressed)
        {
            joueur1.Move(keyPressed);
            joueur2.Move(keyPressed);
        }

        private void UpdateScore_Tick(object sender, EventArgs e)
        {
            // Update scoreboard text
            Scoreboard.Text = $"{joueur1.Score} | {joueur2.Score}";

            // Check for player one victory
            if(joueur1.Score >= score)
            {
                BallMovement.Stop();
                btnRestart.Visible = true;
                labelVictory.Visible = true;
                labelVictory.Text = "Joueur 1 a gagné !";
            }

            if (joueur2.Score >= score)
            {
                BallMovement.Stop();
                btnRestart.Visible = true;
                labelVictory.Visible = true;
                labelVictory.Text = "Joueur 2 a gagné !";
            }

        }

        private void BallMovement_Tick(object sender, EventArgs e)
        {
            balle.Move();
            balle.IsOutOfBounds(joueur1, joueur2);
            balle.OnCollision(joueur1, joueur2);
        }

        private void Pong_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            // Hide victory text and button
            labelVictory.Visible = false;
            btnRestart.Visible = false;
            Pong.ActiveForm.Focus();

            // Revert the scores back to 0
            joueur1.RestartScore();
            joueur2.RestartScore();

            // Start balle movemenet and restart its position
            balle.Reset();
            BallMovement.Start();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            balle.Move();
            balle.IsOutOfBounds(joueur1, joueur2);
            balle.OnCollision(joueur1, joueur2);
        }

        private void labelVictory_Click(object sender, EventArgs e)
        {

        }
    }
}
