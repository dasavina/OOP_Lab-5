using System.Net;

class Box
{
    double h { get; set; }
    double w { get; set; }
    double l { get; set; }

    public Box(double h, double w, double l)
    {
        this.h = h;
        this.w = w;
        this.l = l;
    }

    public double Volume()
    {
        return h * w * l;
    }

    public double Surface()
    {
        return 2 * (h * w + w * l + h * l);
    }

    public double LateralSurface()
    {
        return h * l + h * w;
    }
}
