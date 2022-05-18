namespace Day2
{
    public class Color
    {
        public Color(){}

        public Color(int red , int green , int blue , int alpha)
        {
            _red = (byte)red;
            _green = (byte)green;
            _blue = (byte)blue;
            _alpha = (byte)alpha;
        }
        
        public Color(int red , int green , int blue)
        {
            _red = (byte)red;
            _green = (byte)green;
            _blue = (byte)blue;
            _alpha = 255;
        }
        
        private byte _blue, _red, _green, _alpha;

        public int GetBlue() { return (int)_blue;}
        public int GetGreen() { return (int)_green;}
        public int GetRed() { return (int)_red; }
        public int GetAlpha() { return (int)_alpha; }

        public void SetBlue(int val) {
            if (val < 0){ val = 0; }
            else if (val > 255) { val = 255; }
            _blue = (byte)val;
        }
        public void SetRed(int val) {
            if (val < 0){ val = 0; }
            else if (val > 255) { val = 255; }
            _red = (byte)val;
        }
        public void SetGreen(int val) {
            if (val < 0){ val = 0; }
            else if (val > 255) { val = 255; }
            _green = (byte)val;
        }
        public void SetAlpha(int val) {
            if (val < 0){ val = 0; }
            else if (val > 255) { val = 255; }
            _alpha = (byte)val;
        }

        public int GetGrayscale() { return (int)(_blue + _red + _green)/3; }
    }

    public class Ball
    {
        public Ball()
        {
            timesThrown = 0;
        }

        public Ball(Color COLOR, int SIZE = 10)
        {
            color = COLOR;
            size = SIZE;
            timesThrown = 0;
        }

        public Ball(int SIZE)
        {
            size = SIZE;
            timesThrown = 0;
        }

        public Color color;
        public int size;
        public int timesThrown { private get; set; }

        public void Pop(){size=0;}
        
        public void Throw(){if(size > 0){timesThrown++;}}
        public int GetTimesThrown() { return (int)timesThrown; }
        
    }

    public class DO
    {
        static void Main(string[] args)
        {
            Color yellow = new Color(255, 255, 0);
            Color purple = new Color(255, 0, 255);
            Color white = new Color(255, 255, 255);
            Color cyan = new Color(0, 255, 255);
            Color red = new Color(255, 0, 0);
            Color green = new Color(0, 255, 255);
            Color blue = new Color(0, 0, 255);
            Ball ball1 = new Ball(white, 4);
            Ball ball2 = new Ball(yellow);
            Ball ball3 = new Ball(cyan, 9);
            
            ball1.Throw();
            ball2.Throw();
            ball3. Throw();
            Console.WriteLine(ball1.GetTimesThrown() + " " + ball2.GetTimesThrown() + " " + ball3.GetTimesThrown());
            
            ball3.Pop();
            ball1.Throw();
            ball2.Throw();
            ball3. Throw();
            Console.WriteLine(ball1.GetTimesThrown() + " " + ball2.GetTimesThrown() + " " + ball3.GetTimesThrown());
        }
    }
}
