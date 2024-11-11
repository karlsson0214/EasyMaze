using EasyMonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMaze
{
    internal class Boggart : Actor
    {
        private float speed = 100;

        public Boggart()
        {
            //ScaleRadius = 0.9f;
        }

        public override void Update(GameTime gameTime)
        {
            var keyboardState = Keyboard.GetState();
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (keyboardState.IsKeyDown(Keys.Left))
            {
                X -= speed * deltaTime;
                if (IsTouching(typeof(Wall)))
                {
                    // move back
                    X += speed * deltaTime;
                }
                // snapp to center in other direction
                Y = ((int)Y) / 32 * 32 + 16;
            }
            else if (keyboardState.IsKeyDown(Keys.Right))
            {
                X += speed * deltaTime;
                if (IsTouching(typeof(Wall)))
                {
                    // move back
                    X -= speed * deltaTime;
                }
                // snapp to center in other direction
                Y = ((int)Y) / 32 * 32 + 16;
            }
            else if (keyboardState.IsKeyDown(Keys.Up))
            {
                Y -= speed * deltaTime;
                if (IsTouching(typeof(Wall)))
                {
                    // move back
                    Y += speed * deltaTime;
                }
                // snapp to center in other direction
                X = ((int)X) / 32 * 32 + 16;
            }
            else if (keyboardState.IsKeyDown(Keys.Down))
            {
                Y += speed * deltaTime;
                if (IsTouching(typeof(Wall)))
                {
                    // move back
                    Y -= speed * deltaTime;
                }
                // snapp to center in other direction
                X = ((int)X) / 32 * 32 + 16;
            }
            /*
            if (IsTouching(typeof(Wall)))
            {
                RemoveTouching(typeof(Wall));
            }
            */
            
        }
    }
}
