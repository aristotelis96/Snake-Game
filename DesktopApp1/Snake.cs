using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    public class Snake
    {
        private static LinkedList<Rectangle> body = new LinkedList<Rectangle>();
        private static String direction;
        private static String last_direction;
        public bool lost = false;

        public Snake()
        {
            body.AddLast(new Rectangle(250, 250, 10, 10));
            body.AddLast(new Rectangle(240, 250, 10, 10));
            body.AddLast(new Rectangle(230, 250, 10, 10));
            body.AddLast(new Rectangle(220, 250, 10, 10));
            body.AddLast(new Rectangle(210, 250, 10, 10));

            direction = "UP";
            
        }
        internal void Draw(Graphics g)
        {
            foreach (var node in body)
            {
                g.FillRectangle(new SolidBrush(Color.LimeGreen), node);
            }
            g.FillRectangle(new SolidBrush(Color.DarkSlateGray), body.First());

        }

        internal void Move()
        {
            int x, y;
            var node = body.First();
            x = node.X;
            y = node.Y;

            if (Is_move_valid())
            {
                switch (direction)
                {
                    case "UP":
                        body.AddFirst(new Rectangle(x, y - 10, 10, 10));
                        break;
                    case "DOWN":
                        body.AddFirst(new Rectangle(x, y + 10, 10, 10));
                        break;
                    case "RIGHT":
                        body.AddFirst(new Rectangle(x + 10, y, 10, 10));
                        break;
                    case "LEFT":
                        body.AddFirst(new Rectangle(x - 10, y, 10, 10));
                        break;
                    default:
                        break;
                }
            }
            else
            {
                direction = last_direction;
                Move();
                return;
            }
            check_if_lost();
            
            body.RemoveLast();

        }

        internal void reset()
        {
            body.Clear();
            body.AddLast(new Rectangle(250, 250, 10, 10));
            body.AddLast(new Rectangle(240, 250, 10, 10));
            body.AddLast(new Rectangle(230, 250, 10, 10));
            body.AddLast(new Rectangle(220, 250, 10, 10));
            body.AddLast(new Rectangle(210, 250, 10, 10));

            direction = "UP";
        }

        internal void ate()
        {
            var last = body.Last();
            int x = last.X;
            int y = last.Y;
            
            body.AddLast(new Rectangle(x, y, 10, 10));
            body.AddLast(new Rectangle(x, y, 10, 10));
            body.AddLast(new Rectangle(x, y, 10, 10));
            body.AddLast(new Rectangle(x, y, 10, 10));
            body.AddLast(new Rectangle(x, y, 10, 10));

        }



        public bool check_if_eaten(int x , int y)
        {
            var head = body.First();
            if (head.X == x && head.Y == y)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void check_if_lost()
        {
            var head = body.First();
            foreach (var node in body.Skip(1))
            {
                if(head.X == node.X && head.Y == node.Y)
                {
                    lost = true;
                    return;
                }
            }
            if (head.X == -10 || head.X == 450 || head.Y == -10 || head.Y == 450)
            {
                lost = true;
                return;
            }
            
        }

        private bool Is_move_valid()
        {
            var node = body.First();
            var node2 = body.ElementAt(1);
            switch (direction)
            {
                case "UP":
                    if (node.Y - 10 == node2.Y)
                        return false;
                    break;
                case "DOWN":
                    if (node.Y + 10 == node2.Y)
                        return false;
                    break;
                case "RIGHT":
                    if (node.X + 10 == node2.X)
                        return false;
                    break;
                case "LEFT":
                    if (node.X - 10 == node2.X)
                        return false;
                    break;
                default:
                    break;
            }
            return true;
        }

        internal void changeDirection(string v)
        {
            if (!(String.Equals(v, direction)))
            {
                last_direction = direction;
            }

            direction = v;
     
        }
    }
}
