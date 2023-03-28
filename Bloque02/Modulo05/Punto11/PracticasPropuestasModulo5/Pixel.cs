namespace PracticasPropuestasModulo5;

public class Pixel
{
    public int X { get; set; }
    public int Y { get; set; }
    public Rgb Color { get; set; }

    public Pixel(int x, int y, Rgb color)
    {
        X = x;
        Y = y;
        Color = color;
    }

    public override string ToString()
    {
        return $"X={X}, Y={Y}, rgb({Color.R}, {Color.G}, {Color.B})";
    }

}


