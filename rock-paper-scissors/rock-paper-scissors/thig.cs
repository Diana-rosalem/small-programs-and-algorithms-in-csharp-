using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    public class Thing
    {
       
        public bool winRock { get; set; }
        public bool winPaper { get; set; }
        public bool winScissors { get; set; }

        public bool loseRock { get; set; }
        public bool losePaper { get; set; }
        public bool loseScissors { get; set; }

    }
   
    public class Rock : Thing
    {
        public Rock()
        {
            
            winPaper = false;
            winRock = false;
            winScissors = true;

            losePaper = true;
            loseRock = false;
            loseScissors = false;


        }
    }

    public class Paper : Thing
    {
        public Paper()
        {

            winPaper = false;
            winRock = true;
            winScissors = false;

            losePaper = false;
            loseRock = false;
            loseScissors = true;


        }
    }

    public class Scissors : Thing
    {
        public Scissors()
        {

            winPaper = true;
            winRock = false;
            winScissors = false;

            losePaper = false;
            loseRock = true;
            loseScissors = false;


        }
    }


}
