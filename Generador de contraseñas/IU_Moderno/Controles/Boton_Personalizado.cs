using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace IU_Moderno.Controles
{
    public class Boton_Personalizado : Button
    {
        //CSS
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.RoyalBlue;

        // New properties for colors on mouse down
        private Color onPressBackColor = Color.FromArgb(40, 96, 144);
        private Color onPressForeColor = Color.White;

        private Color originalBackColor;
        private Color originalForeColor;

        [Category("Boton Personalizado")]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }

        [Category("Boton Personalizado")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); }
        }

        [Category("Boton Personalizado")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        [Category("Boton Personalizado")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("Boton Personalizado")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        [Category("Boton Personalizado")]
        public Color OnPressBackColor
        {
            get { return onPressBackColor; }
            set { onPressBackColor = value; }
        }

        [Category("Boton Personalizado")]
        public Color OnPressForeColor
        {
            get { return onPressForeColor; }
            set { onPressForeColor = value; }
        }

        // Constructor
        public Boton_Personalizado()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.RoyalBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);

            originalBackColor = this.BackColor;
            originalForeColor = this.ForeColor;

            // Add mouse events to handle the color changes on press
            this.MouseDown += new MouseEventHandler(Button_MouseDown);
            this.MouseUp += new MouseEventHandler(Button_MouseUp);
            this.MouseLeave += new EventHandler(Button_MouseLeave);
        }

        // Restricción para evitar que el radio del botón sobrepase la altura del botón
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
            {
                borderRadius = this.Height;
            }
        }

        // Handle the button press color change
        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            originalBackColor = this.BackColor;
            originalForeColor = this.ForeColor;
            this.BackColor = onPressBackColor;
            this.ForeColor = onPressForeColor;
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = originalBackColor;
            this.ForeColor = originalForeColor;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = originalBackColor;
            this.ForeColor = originalForeColor;
        }

        // Methods
        private GraphicsPath GetGraphicsPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);                   // Superior Izquierda
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);      // Superior Derecha
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);   // Inferior Derecha
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);      // Inferior Izquierda
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (borderRadius > 2) // Botones redondos
            {
                using (GraphicsPath pathSurface = GetGraphicsPath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetGraphicsPath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;

                    // Superficie del botón
                    this.Region = new Region(pathSurface);
                    // Dibujar la superficie para que se vea HD
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    // Borde del botón
                    if (borderSize >= 1)
                    {
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else // Botón normal
            {
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}
