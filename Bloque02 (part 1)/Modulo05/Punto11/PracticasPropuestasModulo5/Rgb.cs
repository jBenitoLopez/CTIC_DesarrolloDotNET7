namespace PracticasPropuestasModulo5;
public class Rgb
{

    public byte R { get; set; } = 0;
    public byte G { get; set; } = 0;
    public byte B { get; set; } = 0;


    public Rgb() { }

    public Rgb(byte r = 0, byte g = 0, byte b = 0)
    {
        R = r;
        G = g;
        B = b;
    }

}