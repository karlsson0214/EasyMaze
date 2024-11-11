using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMaze;
using EasyMonoGame;
using WallsSolution;

namespace EasyStart
{
    internal class MazeWorld : World
    {
        public MazeWorld() : base(512, 512)
        {
            // Tile background with the file "bluerock" in the Content folder.
            BackgroundTileName = "sand_1";

            FileReader fileReader = new FileReader();
            String level = fileReader.ReadFile();
            int x = 16;
            int y = 16;
            foreach (char token in level)
            {
                if (token == 'x')
                {
                    Add(new Wall(), "brick_brown_0", x, y);
                }
                else if (token == 'b')
                {
                    // only one turtle
                    Add(new Boggart(), "boggart_new", x, y);
                }
                else if (token == 't')
                {
                    Add(new Troll(), "rock_troll", x, y);
                }
                else if (token == 'g')
                {                    // only one gold
                    Add(new Gold(), "gold_pile_8", x, y);
                }
                
                if (token == '\n')
                {
                    x = 16;
                    y += 32;
                }
                else
                {
                    x += 32;
                }
            }
        }  
    }
}
