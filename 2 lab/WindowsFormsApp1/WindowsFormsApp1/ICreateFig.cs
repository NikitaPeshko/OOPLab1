using System;
using System.Drawing;

namespace WindowsFormsApp1
{
    interface ICreateFig
    {
        Figure Create(int x0, int y0, Graphics gr, Pen pen, Color Fc);

        string Name { get; }
        bool TopsNeeded { get; }
    }
}
