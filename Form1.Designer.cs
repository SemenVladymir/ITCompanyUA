using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ITCompanyUA
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lName = new System.Windows.Forms.Label();
            this.lEmployees = new System.Windows.Forms.Label();
            this.lCities = new System.Windows.Forms.Label();
            this.lLider = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lName
            // 
            resources.ApplyResources(this.lName, "lName");
            this.lName.Name = "lName";
            // 
            // lEmployees
            // 
            resources.ApplyResources(this.lEmployees, "lEmployees");
            this.lEmployees.Name = "lEmployees";
            // 
            // lCities
            // 
            resources.ApplyResources(this.lCities, "lCities");
            this.lCities.Name = "lCities";
            // 
            // lLider
            // 
            resources.ApplyResources(this.lLider, "lLider");
            this.lLider.Name = "lLider";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.lLider);
            this.Controls.Add(this.lCities);
            this.Controls.Add(this.lEmployees);
            this.Controls.Add(this.lName);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lName;
        private Label lEmployees;
        private Label lCities;
        private Label lLider;
    }
}

