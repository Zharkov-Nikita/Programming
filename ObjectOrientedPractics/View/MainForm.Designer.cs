﻿namespace ObjectOrientedPractics
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.ItemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.CustomersTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.CartsTabPage = new System.Windows.Forms.TabPage();
            this.CartsTab = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.MainTabControl.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.CustomersTabPage.SuspendLayout();
            this.CartsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.ItemsTabPage);
            this.MainTabControl.Controls.Add(this.CustomersTabPage);
            this.MainTabControl.Controls.Add(this.CartsTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(790, 450);
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.ItemsTab);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(782, 424);
            this.ItemsTabPage.TabIndex = 0;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            this.ItemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTab.Location = new System.Drawing.Point(3, 3);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Size = new System.Drawing.Size(776, 418);
            this.ItemsTab.TabIndex = 0;
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Controls.Add(this.CustomersTab);
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 22);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTabPage.Size = new System.Drawing.Size(782, 424);
            this.CustomersTabPage.TabIndex = 1;
            this.CustomersTabPage.Text = "Customers";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            this.CustomersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersTab.Location = new System.Drawing.Point(3, 3);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Size = new System.Drawing.Size(776, 418);
            this.CustomersTab.TabIndex = 0;
            // 
            // CartsTabPage
            // 
            this.CartsTabPage.Controls.Add(this.CartsTab);
            this.CartsTabPage.Location = new System.Drawing.Point(4, 22);
            this.CartsTabPage.Name = "CartsTabPage";
            this.CartsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CartsTabPage.Size = new System.Drawing.Size(782, 424);
            this.CartsTabPage.TabIndex = 2;
            this.CartsTabPage.Text = "Carts";
            this.CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // CartsTab
            // 
            this.CartsTab.Customers = null;
            this.CartsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartsTab.Items = null;
            this.CartsTab.Location = new System.Drawing.Point(3, 3);
            this.CartsTab.Name = "CartsTab";
            this.CartsTab.Size = new System.Drawing.Size(776, 418);
            this.CartsTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.MainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.MainTabControl.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.CustomersTabPage.ResumeLayout(false);
            this.CartsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage ItemsTabPage;
        private View.Tabs.ItemsTab ItemsTab;
        private System.Windows.Forms.TabPage CustomersTabPage;
        private View.Tabs.CustomersTab CustomersTab;
        private System.Windows.Forms.TabPage CartsTabPage;
        private View.Tabs.CartsTab CartsTab;
    }
}

