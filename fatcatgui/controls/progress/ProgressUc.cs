using System;
using System.Drawing;
//using System.Timers;
using System.Windows.Forms;

namespace fatcatgui.controls.progress
{
    public partial class ProgressUc : UserControl
    {


        private double valuemax;
        public Double Valuemax { get => valuemax; set => valuemax = value; }


        private double valuecur;
        public Double Valuecur { get => valuecur; set => valuecur = value; }

        private string prefixtext;
        public String Prefixtext { get => prefixtext; set => prefixtext = value; }


        //colors and pens
        private Pen pen = new Pen(basestyles.colorhigh, 1);
        private Rectangle rect = new Rectangle(0, 0, 10, 10);
        private TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;


        private SolidBrush drawBrush = new SolidBrush(basestyles.colortext);
        private SolidBrush brushfill = new SolidBrush(basestyles.colorhigh);



        //private int _theRefreshRate = 100;
        //private  System.Timers.Timer aTimer;

        public ProgressUc()
        {
            InitializeComponent();
          //  SetTimer();
            //this.SetStyle(ControlStyles.DoubleBuffer, true);
            //this.SetStyle(ControlStyles.ResizeRedraw, true);
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //this.SetStyle(ControlStyles.UserPaint, true);

        }


        private void ProgressUc_Load(object sender, EventArgs e)
        {
            this.BackColor = basestyles.colorback;
        }

        //private void SetTimer()
        //{
        //    aTimer = new System.Timers.Timer(_theRefreshRate);
        //    aTimer.Elapsed += OnTimedEvent;
        //    aTimer.AutoReset = true;
        //    aTimer.Enabled = true;
        //}

        //private void OnTimedEvent(Object source, ElapsedEventArgs e)
        //{
        //    this.Invalidate();
        //}

        private void ProgressUc_Paint(object sender, PaintEventArgs e)
        {
          

                e.Graphics.Clear(basestyles.colordim);

                pen.Color = basestyles.colorhigh;

                rect.Width = this.Width - 1;
                rect.Height = this.Height - 1;

                e.Graphics.DrawRectangle(pen, rect);

                brushfill.Color = basestyles.colorhigh;

                Font drawFont = new Font(basestyles.fonttext, this.Height / 2, GraphicsUnit.Pixel);



                if (valuecur < 0)
                {
                    TextRenderer.DrawText(e.Graphics, prefixtext, drawFont, rect, basestyles.colortext, flags);

                }
                else
                {
                    var percentused = valuecur * 100.0 / valuemax;

                  

                    if (!double.IsNaN(percentused))
                    {
                        Rectangle sizeRect = new Rectangle(0, 0, (int)(this.Width * percentused / 100.0), this.Height);

                        e.Graphics.FillRectangle(brushfill, sizeRect);

                        TextRenderer.DrawText(e.Graphics, prefixtext + " " + percentused.ToString("0.00") + "%", drawFont, rect, basestyles.colortext, flags);

                    }
                }
                drawFont.Dispose();
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
