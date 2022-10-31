using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetPurplePong
{
    public class Settings
    {
        // Player one controls
        public Keys PlayerOneUp;
        public Keys PlayerOneDown;

        // Player two controls
        public Keys PlayerTwoUp;
        public Keys PlayerTwoDown;

        // Match settings
        public int score;

        /// <summary>
        /// Saves the settings provided in the Configuration form
        /// </summary>
        /// <param name="score">Amount of points to win</param>
        /// <param name="oneUp">Player one move up key</param>
        /// <param name="oneDown">Player one move down key</param>
        /// <param name="twoUp">Player two move up key</param>
        /// <param name="twoDown">Player two move down key</param>
        public Settings(Int32 score, Keys oneUp, Keys oneDown, Keys twoUp, Keys twoDown)
        {
            // Controls
            this.PlayerOneUp = oneUp;
            this.PlayerOneDown = oneDown;
            this.PlayerTwoUp = twoUp;
            this.PlayerTwoDown = twoDown;

            // Match settings
            this.score = score;
        }
    }
}
