using System.Net;

class Box
{
    public double h
    {
        get { return h; }
        private set { if (value > 0) { h = value; } else { throw new Exception("Height cannot be 0 or less"); } }
    }
    public double w
    {
        get { return w; }
        private set { if (value > 0) { w = value; } else { throw new Exception("Width cannot be 0 or less"); } }
    }
    public double l
    {
        get { return l; }
        private set { if (value > 0) { l = value; } else { throw new Exception("Height cannot be 0 or less"); } }
    }

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
