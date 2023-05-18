namespace ITCompanyUA
{
    partial class UserControl1
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.Name = new System.Windows.Forms.Label();
            this.Employees = new System.Windows.Forms.Label();
            this.Cities = new System.Windows.Forms.Label();
            this.Lider = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name
            // 
            resources.ApplyResources(this.Name, "Name");
            this.Name.Name = "Name";
            // 
            // Employees
            // 
            resources.ApplyResources(this.Employees, "Employees");
            this.Employees.Name = "Employees";
            // 
            // Cities
            // 
            this.Cities.AutoEllipsis = true;
            resources.ApplyResources(this.Cities, "Cities");
            this.Cities.Name = "Cities";
            // 
            // Lider
            // 
            resources.ApplyResources(this.Lider, "Lider");
            this.Lider.Name = "Lider";
            // 
            // UserControl1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lider);
            this.Controls.Add(this.Cities);
            this.Controls.Add(this.Employees);
            this.Controls.Add(this.Name);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Employees;
        private System.Windows.Forms.Label Cities;
        private System.Windows.Forms.Label Lider;
    }
}
