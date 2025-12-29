namespace HMS_Solution
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePatient = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePatient = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllPatients = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDoctor = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDoctor = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDoctor = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDoctor = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllDoctors = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllAppointments = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByDateRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBill = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBill = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllBills = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUser = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientsToolStripMenuItem,
            this.doctorToolStripMenuItem,
            this.appointmentToolStripMenuItem,
            this.billingToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.servicesToolStripMenuItem,
            this.dashboardToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPatient,
            this.updatePatient,
            this.deletePatient,
            this.viewPatient,
            this.viewAllPatients});
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            resources.ApplyResources(this.patientsToolStripMenuItem, "patientsToolStripMenuItem");
            // 
            // addPatient
            // 
            this.addPatient.Name = "addPatient";
            resources.ApplyResources(this.addPatient, "addPatient");
            this.addPatient.Click += new System.EventHandler(this.addPatient_Click);
            // 
            // updatePatient
            // 
            this.updatePatient.Name = "updatePatient";
            resources.ApplyResources(this.updatePatient, "updatePatient");
            this.updatePatient.Click += new System.EventHandler(this.updatePatient_Click);
            // 
            // deletePatient
            // 
            this.deletePatient.Name = "deletePatient";
            resources.ApplyResources(this.deletePatient, "deletePatient");
            this.deletePatient.Click += new System.EventHandler(this.deletePatient_Click);
            // 
            // viewPatient
            // 
            this.viewPatient.Name = "viewPatient";
            resources.ApplyResources(this.viewPatient, "viewPatient");
            this.viewPatient.Click += new System.EventHandler(this.viewPatient_Click);
            // 
            // viewAllPatients
            // 
            this.viewAllPatients.Name = "viewAllPatients";
            resources.ApplyResources(this.viewAllPatients, "viewAllPatients");
            this.viewAllPatients.Click += new System.EventHandler(this.viewAllPatients_Click);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDoctor,
            this.updateDoctor,
            this.deleteDoctor,
            this.viewDoctor,
            this.viewAllDoctors});
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            resources.ApplyResources(this.doctorToolStripMenuItem, "doctorToolStripMenuItem");
            // 
            // addDoctor
            // 
            this.addDoctor.Name = "addDoctor";
            resources.ApplyResources(this.addDoctor, "addDoctor");
            this.addDoctor.Click += new System.EventHandler(this.addDoctor_Click);
            // 
            // updateDoctor
            // 
            this.updateDoctor.Name = "updateDoctor";
            resources.ApplyResources(this.updateDoctor, "updateDoctor");
            this.updateDoctor.Click += new System.EventHandler(this.updateDoctor_Click);
            // 
            // deleteDoctor
            // 
            this.deleteDoctor.Name = "deleteDoctor";
            resources.ApplyResources(this.deleteDoctor, "deleteDoctor");
            this.deleteDoctor.Click += new System.EventHandler(this.deleteDoctor_Click);
            // 
            // viewDoctor
            // 
            this.viewDoctor.Name = "viewDoctor";
            resources.ApplyResources(this.viewDoctor, "viewDoctor");
            this.viewDoctor.Click += new System.EventHandler(this.viewDoctor_Click);
            // 
            // viewAllDoctors
            // 
            this.viewAllDoctors.Name = "viewAllDoctors";
            resources.ApplyResources(this.viewAllDoctors, "viewAllDoctors");
            this.viewAllDoctors.Click += new System.EventHandler(this.viewAllDoctors_Click);
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAppointment,
            this.updateAppointment,
            this.deleteAppointment,
            this.viewAppointment,
            this.viewAllAppointments,
            this.searchByDateRangeToolStripMenuItem});
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            resources.ApplyResources(this.appointmentToolStripMenuItem, "appointmentToolStripMenuItem");
            // 
            // addAppointment
            // 
            this.addAppointment.Name = "addAppointment";
            resources.ApplyResources(this.addAppointment, "addAppointment");
            this.addAppointment.Click += new System.EventHandler(this.addAppointment_Click);
            // 
            // updateAppointment
            // 
            this.updateAppointment.Name = "updateAppointment";
            resources.ApplyResources(this.updateAppointment, "updateAppointment");
            this.updateAppointment.Click += new System.EventHandler(this.updateAppointment_Click);
            // 
            // deleteAppointment
            // 
            this.deleteAppointment.Name = "deleteAppointment";
            resources.ApplyResources(this.deleteAppointment, "deleteAppointment");
            this.deleteAppointment.Click += new System.EventHandler(this.deleteAppointment_Click);
            // 
            // viewAppointment
            // 
            this.viewAppointment.Name = "viewAppointment";
            resources.ApplyResources(this.viewAppointment, "viewAppointment");
            this.viewAppointment.Click += new System.EventHandler(this.viewAppointment_Click);
            // 
            // viewAllAppointments
            // 
            this.viewAllAppointments.Name = "viewAllAppointments";
            resources.ApplyResources(this.viewAllAppointments, "viewAllAppointments");
            this.viewAllAppointments.Click += new System.EventHandler(this.viewAllAppointments_Click);
            // 
            // searchByDateRangeToolStripMenuItem
            // 
            this.searchByDateRangeToolStripMenuItem.Name = "searchByDateRangeToolStripMenuItem";
            resources.ApplyResources(this.searchByDateRangeToolStripMenuItem, "searchByDateRangeToolStripMenuItem");
            this.searchByDateRangeToolStripMenuItem.Click += new System.EventHandler(this.searchByDateRangeToolStripMenuItem_Click);
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBill,
            this.viewBill,
            this.viewAllBills});
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            resources.ApplyResources(this.billingToolStripMenuItem, "billingToolStripMenuItem");
            // 
            // addBill
            // 
            this.addBill.Name = "addBill";
            resources.ApplyResources(this.addBill, "addBill");
            this.addBill.Click += new System.EventHandler(this.addBill_Click);
            // 
            // viewBill
            // 
            this.viewBill.Name = "viewBill";
            resources.ApplyResources(this.viewBill, "viewBill");
            this.viewBill.Click += new System.EventHandler(this.viewBill_Click);
            // 
            // viewAllBills
            // 
            this.viewAllBills.Name = "viewAllBills";
            resources.ApplyResources(this.viewAllBills, "viewAllBills");
            this.viewAllBills.Click += new System.EventHandler(this.viewAllBills_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUser,
            this.updateUsers,
            this.deleteUsers,
            this.viewUsers,
            this.viewAllUsers});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            resources.ApplyResources(this.usersToolStripMenuItem, "usersToolStripMenuItem");
            // 
            // addUser
            // 
            this.addUser.Name = "addUser";
            resources.ApplyResources(this.addUser, "addUser");
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // updateUsers
            // 
            this.updateUsers.Name = "updateUsers";
            resources.ApplyResources(this.updateUsers, "updateUsers");
            this.updateUsers.Click += new System.EventHandler(this.updateUsers_Click);
            // 
            // deleteUsers
            // 
            this.deleteUsers.Name = "deleteUsers";
            resources.ApplyResources(this.deleteUsers, "deleteUsers");
            this.deleteUsers.Click += new System.EventHandler(this.deleteUsers_Click);
            // 
            // viewUsers
            // 
            this.viewUsers.Name = "viewUsers";
            resources.ApplyResources(this.viewUsers, "viewUsers");
            this.viewUsers.Click += new System.EventHandler(this.viewUsers_Click);
            // 
            // viewAllUsers
            // 
            this.viewAllUsers.Name = "viewAllUsers";
            resources.ApplyResources(this.viewAllUsers, "viewAllUsers");
            this.viewAllUsers.Click += new System.EventHandler(this.viewAllUsers_Click);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addServicesToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.allToolStripMenuItem});
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            resources.ApplyResources(this.servicesToolStripMenuItem, "servicesToolStripMenuItem");
            // 
            // addServicesToolStripMenuItem
            // 
            this.addServicesToolStripMenuItem.Name = "addServicesToolStripMenuItem";
            resources.ApplyResources(this.addServicesToolStripMenuItem, "addServicesToolStripMenuItem");
            this.addServicesToolStripMenuItem.Click += new System.EventHandler(this.addServicesToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            resources.ApplyResources(this.updateToolStripMenuItem, "updateToolStripMenuItem");
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            resources.ApplyResources(this.allToolStripMenuItem, "allToolStripMenuItem");
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            resources.ApplyResources(this.dashboardToolStripMenuItem, "dashboardToolStripMenuItem");
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::HMS_Solution.Properties.Resources.MainBackground1;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatient;
        private System.Windows.Forms.ToolStripMenuItem updatePatient;
        private System.Windows.Forms.ToolStripMenuItem deletePatient;
        private System.Windows.Forms.ToolStripMenuItem viewPatient;
        private System.Windows.Forms.ToolStripMenuItem viewAllPatients;
        private System.Windows.Forms.ToolStripMenuItem addDoctor;
        private System.Windows.Forms.ToolStripMenuItem updateDoctor;
        private System.Windows.Forms.ToolStripMenuItem deleteDoctor;
        private System.Windows.Forms.ToolStripMenuItem viewDoctor;
        private System.Windows.Forms.ToolStripMenuItem viewAllDoctors;
        private System.Windows.Forms.ToolStripMenuItem addAppointment;
        private System.Windows.Forms.ToolStripMenuItem updateAppointment;
        private System.Windows.Forms.ToolStripMenuItem deleteAppointment;
        private System.Windows.Forms.ToolStripMenuItem viewAppointment;
        private System.Windows.Forms.ToolStripMenuItem addBill;
        private System.Windows.Forms.ToolStripMenuItem viewBill;
        private System.Windows.Forms.ToolStripMenuItem viewAllBills;
        private System.Windows.Forms.ToolStripMenuItem addUser;
        private System.Windows.Forms.ToolStripMenuItem updateUsers;
        private System.Windows.Forms.ToolStripMenuItem deleteUsers;
        private System.Windows.Forms.ToolStripMenuItem viewUsers;
        private System.Windows.Forms.ToolStripMenuItem viewAllUsers;
        private System.Windows.Forms.ToolStripMenuItem viewAllAppointments;
        private System.Windows.Forms.ToolStripMenuItem searchByDateRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
    }
}

