using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCompanyUA
{
    public partial class Form1 : Form
    {
        Panel Panel;
        Button btnEn;
        Button btnGe;
        Button btnFr;
        Button btnUkr;
        SQLAdapter adapter = new SQLAdapter("Server=DESKTOP-MV43C0T;Database=ITCompanyUA;Trusted_Connection=True;TrustServerCertificate=True;");
        List <ITCompanies> companies = new List <ITCompanies>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode =AutoScaleMode.Font;
            ClientSize = new Size(950, 450);


            Panel = new Panel();
            Panel.Location = new Point(0, 40);
            Panel.Size = new Size(this.Width, this.Height - 40);
            Panel.AutoScroll = true;



            btnEn = new Button();
            btnEn.Size = new Size(50, 25);
            btnEn.Location = new Point(this.Width - 250, 10);
            btnEn.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Documents\\GitHub\\ITCompanyUA\\obj\\Debug\\eng1.png");
            btnEn.ImageAlign = ContentAlignment.MiddleCenter;
            btnEn.BackgroundImageLayout = ImageLayout.Center;
            btnEn.Click += BtnEn_Click1;

            btnGe = new Button();
            btnGe.Size = new Size(50, 25);
            btnGe.Location = new Point(this.Width - 200, 10);
            btnGe.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Documents\\GitHub\\ITCompanyUA\\obj\\Debug\\germ1.png");
            btnGe.ImageAlign = ContentAlignment.MiddleCenter;
            btnGe.BackgroundImageLayout = ImageLayout.Center;
            btnGe.Click += BtnGe_Click1;

            btnFr = new Button();
            btnFr.Size = new Size(50, 25);
            btnFr.Location = new Point(this.Width - 150, 10);
            btnFr.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Documents\\GitHub\\ITCompanyUA\\obj\\Debug\\fran.png");
            btnFr.ImageAlign = ContentAlignment.MiddleCenter;
            btnFr.BackgroundImageLayout = ImageLayout.Center;
            btnFr.Click += BtnFr_Click1;

            btnUkr = new Button();
            btnUkr.Size = new Size(50, 25);
            btnUkr.Location = new Point(this.Width - 100, 10);
            btnUkr.Image = Image.FromFile("C:\\Users\\User\\OneDrive\\Documents\\GitHub\\ITCompanyUA\\obj\\Debug\\ukr1.png");
            btnUkr.ImageAlign = ContentAlignment.MiddleCenter;
            btnUkr.BackgroundImageLayout = ImageLayout.Center;
            btnUkr.Click += BtnUkr_Click1;

            this.Controls.Add(Panel);
            this.Controls.Add(btnEn);
            this.Controls.Add(btnGe);
            this.Controls.Add(btnFr);
            this.Controls.Add(btnUkr);
            this.SizeChanged += Form1_SizeChanged;

            ShowContact(adapter.GetITCompanies());

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //Panel.Size = new Size(this.Width, this.Height - 40);
            btnEn.Location = new Point(this.Width - 250, 10);
            btnGe.Location = new Point(this.Width - 200, 10);
            btnFr.Location = new Point(this.Width - 150, 10);
            btnUkr.Location = new Point(this.Width - 100, 10);
        }

        private void BtnUkr_Click1(object sender, EventArgs e)
        {
            ChangeLang("uk-UK");
            ShowContact(adapter.GetITCompanies());
        }

        private void BtnFr_Click1(object sender, EventArgs e)
        {
            ChangeLang("fr-FR");
            ShowContact(adapter.GetITCompanies());
        }

        private void BtnGe_Click1(object sender, EventArgs e)
        {
            ChangeLang("de-DE");
            ShowContact(adapter.GetITCompanies());
        }

        private void BtnEn_Click1(object sender, EventArgs e)
        {
            ChangeLang("");
            ShowContact(adapter.GetITCompanies());
        }

        private void ChangeLang(string lang)
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form1));
            CultureInfo culture = new CultureInfo(lang);
            foreach (Control item in this.Controls)
            {
               manager.ApplyResources(item, item.Name, culture);
            }
        }

        private void ShowContact(List <ITCompanies> companies)
        {
            Panel.Controls.Clear();
            List <ITCompanies> list = new List<ITCompanies>();
            list = companies;
            int y = 0;
            for (int i = 0; i < companies.Count; i++)
            {
                var item = new UserControl1(companies[i]);
                item.Location = new Point(30, (y * item.Height) + 30);
                //item.BackColor = Color.White;
                //item.BorderStyle = BorderStyle.FixedSingle;
                y++;
                Panel.Controls.Add(item);
            }
        }
    }
}
