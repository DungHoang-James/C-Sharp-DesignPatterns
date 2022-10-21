public class RectangleAdapter : IShape
{
    private readonly LegacyRectangle _legacyLine;

    public RectangleAdapter(LegacyRectangle legacyLine)
    {
        this._legacyLine = legacyLine;
    }

    public void Draw(int x1, int x2, int y1, int y2)
    {
        int x = Math.Min(x1, x2);
        int y = Math.Min(y1, y2);
        int w = Math.Abs(x2 - x1);
        int h = Math.Abs(y2 - y1);
        _legacyLine.Draw(x, y, w, h);
    }
}