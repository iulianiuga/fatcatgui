using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;


namespace fatcatgui
{
    public partial class Form1 : Form
    {

//        static readonly log4net.ILog log =
//     log4net.LogManager.GetLogger
//(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            


            //read ini
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(Application.StartupPath + "/configuration.ini");

            this.Width =int.Parse( data["dimensions"]["width"]);
            this.Height = int.Parse(data["dimensions"]["height"]);

            this.Top = int.Parse(data["dimensions"]["top"]);
            this.Left = int.Parse(data["dimensions"]["left"]);

            basestyles.colorback = ColorTranslator.FromHtml(data["styles"]["colorback"]);
            basestyles.colordim = ColorTranslator.FromHtml(data["styles"]["colordim"]);
            basestyles.colorhigh = ColorTranslator.FromHtml(data["styles"]["colorhigh"]);
            basestyles.colortext =  ColorTranslator.FromHtml(data["styles"]["colortext"]);
            basestyles.fonttext = data["styles"]["fonttext"];
            basestyles.datestart = DateTime.Now;



            this.BackColor = basestyles.colorback;

            MainPanel.Dock = DockStyle.Fill;




        }
        
       
    }
}
