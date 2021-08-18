using System;
namespace Properties
{
    public class Box
    {
        // member variable
        private int length = 3;
        private int height;
        //public int width;
        public int volume;

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }
        public int Width { get; set; } // prop + TAB -> property syntax
                                       // Same as:

        //    public int Width
        //{
        //    get
        //    {
        //        return this.width;
        //    }
        //    set
        //    {
        //        this.width = value;
        //    }
        //}

        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }
            set
            {
                this.volume = value;
            }
        }

        public int Height // prperty for getters an setters
        {
            get
            {
                return height;
            }
            set
            {
                if(value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
                
            }
        }


        public void SetLength(int length)
        {
            if (length < 0)
            {
                throw new Exception("Length should bne higher than 0");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        //public int GetVolume()
        //{
        //    return this.length * this.height * this.width;
        //}

        public int FrontSurface
        {
            get { return height * length; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, heigtht is {1} and width is {2}, so the volume is {3}", length, height, Width, volume = length * height * Width);
        }
    }
}
