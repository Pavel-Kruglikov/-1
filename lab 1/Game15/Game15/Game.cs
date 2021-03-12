using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Game15
{
    class Game
    {
        int size;
        int[,] map;
        int space_x, space_y;//  space location
        static Random rand = new Random();
        public Game(int size)// Field size
        {
            if (size < 2) size = 2;
            if (size > 5) size = 5;
            this.size = size;// the size as indicated
            map = new int[size, size];// map array
        }
        public void start()// preparation of the field for the game
        {
            for (int x = 0; x < size; x++)//fill the map matrix with values
                for (int y = 0; y < size; y++)
                    map[x, y] = coords_to_position(x, y) + 1;
            space_x = size - 1;
            space_y = size - 1;
            map[space_x, space_y] = 0;// free space of the plate (space)
        }
        public void shift (int position)// moving buttons
        {
            int x, y;
            position_to_coords(position, out x, out y);// we set the position and return the values
            if (Math.Abs(space_x - x) + Math.Abs(space_y - y) != 1)
                return;
            map[space_x, space_y] = map[x, y];
            map[x, y] = 0;
            space_x = x;
            space_y = y;
        }
        public void shift_random()// function for shuffling buttons
        {
            int a = rand.Next(0, 4);
            int x = space_x;
            int y = space_y;
            switch(a)
            {
                case 0:x--; break;
                case 1:x++; break;
                case 2:y--; break;
                case 3:y++; break;                    
            }
            shift(coords_to_position(x, y));
        }
        public bool check_numbers ()// determining whether the game is over or not
        {
            if (!(space_x == size - 1 &&
                space_y == size - 1))
                return false;
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    if (!(x == size - 1 && y == size - 1))
                        if (map[x, y] != coords_to_position(x, y) + 1)
                            return false;
            return true;
        }
          public int get_number (int position)// returning a number that is in the right place
        {
            int x, y;
            position_to_coords(position, out x, out  y);
            if (x < 0 || x >= size) return 0;
            if (y < 0 || y >= size) return 0;
            return map[x, y];
        } 
        private int coords_to_position (int x, int y)// function to translate from coordinates to position
        {
            if (x < 0) x = 0;
            if (x > size - 1) x = size - 1;
            if (y < 0) y = 0;
            if (y > size - 1)y= size - 1;
            return y * size + x;
        }
        private void position_to_coords (int position, out int x, out int y)// function to translate from position to coordinates  
        {
            if (position < 0) position = 0;
            if (position > size * size - 1) position = size * size - 1;
            x = position % size;
            y = position / size;
            }
    }
}
