using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

public class RoundButton : Button
{
    private int cornerRadius = 10;

    // Property to set the custom roundness of the button
    public int CornerRadius
    {
        get { return cornerRadius; }
        set
        {
            cornerRadius = value;
            Invalidate(); // Invalidate the control to trigger a repaint
        }
    }

    public RoundButton()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        BackColor = Color.LightGray;
        ForeColor = Color.Black;
        TextAlign = ContentAlignment.MiddleCenter;
        Paint += RoundButton_Paint;
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);

        // Draw the rounded border
        using (GraphicsPath path = GetRoundRectanglePath(ClientRectangle, cornerRadius))
        {
            pevent.Graphics.DrawPath(new Pen(ForeColor), path);
        }
    }

    private void RoundButton_Paint(object sender, PaintEventArgs e)
    {
        // Draw the text in the center of the button
        SizeF textSize = e.Graphics.MeasureString(Text, Font);
        PointF textLocation = new PointF((Width - textSize.Width) / 2, (Height - textSize.Height) / 2);
        e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), textLocation);
    }

    private GraphicsPath GetRoundRectanglePath(Rectangle rectangle, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        path.AddArc(rectangle.X, rectangle.Y, radius * 2, radius * 2, 180, 90);
        path.AddArc(rectangle.Right - radius * 2, rectangle.Y, radius * 2, radius * 2, 270, 90);
        path.AddArc(rectangle.Right - radius * 2, rectangle.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
        path.AddArc(rectangle.X, rectangle.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
        path.CloseFigure();
        return path;
    }
}
