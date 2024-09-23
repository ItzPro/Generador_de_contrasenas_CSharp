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
    public class Checkbox_Personalizado : CheckBox
    {
        // Variables
        private Color onBackColor = Color.RoyalBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private bool solidStyle = true;

        private System.Windows.Forms.Timer animationTimer;
        private int togglePosition;
        private const int animationInterval = 1;
        private const int toggleSpeed = 4;

        // Propiedades
        [Category("Checkbox Atributos")]
        public Color OnBackColor
        {
            get { return onBackColor; }
            set { onBackColor = value; this.Invalidate(); }
        }

        [Category("Checkbox Atributos")]
        public Color OnToggleColor
        {
            get { return onToggleColor; }
            set { onToggleColor = value; this.Invalidate(); }
        }

        [Category("Checkbox Atributos")]
        public Color OffBackColor
        {
            get { return offBackColor; }
            set { offBackColor = value; this.Invalidate(); }
        }

        [Category("Checkbox Atributos")]
        public Color OffToggleColor
        {
            get { return offToggleColor; }
            set { offToggleColor = value; this.Invalidate(); }
        }

        [Browsable(false)]
        public override string Text
        {
            get { return base.Text; }
            set { }
        }

        [Category("Checkbox Atributos")]
        [DefaultValue(true)]
        public bool SolidStyle
        {
            get { return solidStyle; }
            set { solidStyle = value; this.Invalidate(); }
        }

        // Constructor
        public Checkbox_Personalizado()
        {
            this.MinimumSize = new Size(45, 22);
            togglePosition = this.Checked ? this.Width - this.Height + 1 : 2;

            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = animationInterval;
            animationTimer.Tick += new EventHandler(AnimationTimer_Tick);
        }

        // Métodos
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.FillRectangle(new SolidBrush(this.Parent.BackColor), this.ClientRectangle);

            if (this.Checked) // ON
            {
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                else
                    pevent.Graphics.DrawPath(new Pen(onBackColor, 2), GetFigurePath());
            }
            else // OFF
            {
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                else
                    pevent.Graphics.DrawPath(new Pen(offBackColor, 2), GetFigurePath());
            }

            pevent.Graphics.FillEllipse(new SolidBrush(this.Checked ? onToggleColor : offToggleColor),
                new Rectangle(togglePosition, 2, toggleSize, toggleSize));
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);
            StartToggleAnimation();
        }

        private void StartToggleAnimation()
        {
            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            int targetPosition = this.Checked ? this.Width - this.Height + 1 : 2;

            if (togglePosition < targetPosition)
            {
                togglePosition += toggleSpeed;
                if (togglePosition >= targetPosition)
                {
                    togglePosition = targetPosition;
                    animationTimer.Stop();
                }
            }
            else if (togglePosition > targetPosition)
            {
                togglePosition -= toggleSpeed;
                if (togglePosition <= targetPosition)
                {
                    togglePosition = targetPosition;
                    animationTimer.Stop();
                }
            }

            this.Invalidate();
        }
    }
}
