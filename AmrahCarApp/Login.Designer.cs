using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace AmrahCarApp
{
    public partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 422);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(45, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adventure Starts Here";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(5, 0);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(232, 247);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(420, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOGIN";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.guna2Button1.Location = new System.Drawing.Point(391, 316);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(123, 26);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "LOGIN";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(290, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(290, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "\r\n";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(415, 149);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(140, 19);
            this.guna2TextBox1.TabIndex = 6;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(415, 206);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(140, 19);
            this.guna2TextBox2.TabIndex = 7;
            // 
            // guna2Button5
            // 
            this.guna2Button5.BorderRadius = 15;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.guna2Button5.Location = new System.Drawing.Point(607, 12);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(48, 37);
            this.guna2Button5.TabIndex = 8;
            this.guna2Button5.Text = "X";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(667, 421);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return obj is Login login &&
                   CanRaiseEvents == login.CanRaiseEvents &&
                   EqualityComparer<EventHandlerList>.Default.Equals(Events, login.Events) &&
                   EqualityComparer<ISite>.Default.Equals(Site, login.Site) &&
                   EqualityComparer<IContainer>.Default.Equals(Container, login.Container) &&
                   DesignMode == login.DesignMode &&
                   EqualityComparer<AccessibleObject>.Default.Equals(AccessibilityObject, login.AccessibilityObject) &&
                   AccessibleDefaultActionDescription == login.AccessibleDefaultActionDescription &&
                   AccessibleDescription == login.AccessibleDescription &&
                   AccessibleName == login.AccessibleName &&
                   AccessibleRole == login.AccessibleRole &&
                   AllowDrop == login.AllowDrop &&
                   Anchor == login.Anchor &&
                   AutoSize == login.AutoSize &&
                   EqualityComparer<Point>.Default.Equals(AutoScrollOffset, login.AutoScrollOffset) &&
                   EqualityComparer<LayoutEngine>.Default.Equals(LayoutEngine, login.LayoutEngine) &&
                   EqualityComparer<Color>.Default.Equals(BackColor, login.BackColor) &&
                   EqualityComparer<Image>.Default.Equals(BackgroundImage, login.BackgroundImage) &&
                   BackgroundImageLayout == login.BackgroundImageLayout &&
                   EqualityComparer<BindingContext>.Default.Equals(BindingContext, login.BindingContext) &&
                   Bottom == login.Bottom &&
                   EqualityComparer<Rectangle>.Default.Equals(Bounds, login.Bounds) &&
                   CanFocus == login.CanFocus &&
                   CanRaiseEvents == login.CanRaiseEvents &&
                   CanSelect == login.CanSelect &&
                   Capture == login.Capture &&
                   CausesValidation == login.CausesValidation &&
                   EqualityComparer<Rectangle>.Default.Equals(ClientRectangle, login.ClientRectangle) &&
                   EqualityComparer<Size>.Default.Equals(ClientSize, login.ClientSize) &&
                   CompanyName == login.CompanyName &&
                   ContainsFocus == login.ContainsFocus &&
                   EqualityComparer<ContextMenu>.Default.Equals(ContextMenu, login.ContextMenu) &&
                   EqualityComparer<ContextMenuStrip>.Default.Equals(ContextMenuStrip, login.ContextMenuStrip) &&
                   EqualityComparer<Control.ControlCollection>.Default.Equals(Controls, login.Controls) &&
                   Created == login.Created &&
                   EqualityComparer<CreateParams>.Default.Equals(CreateParams, login.CreateParams) &&
                   EqualityComparer<Cursor>.Default.Equals(Cursor, login.Cursor) &&
                   EqualityComparer<ControlBindingsCollection>.Default.Equals(DataBindings, login.DataBindings) &&
                   EqualityComparer<Cursor>.Default.Equals(DefaultCursor, login.DefaultCursor) &&
                   EqualityComparer<Padding>.Default.Equals(DefaultMargin, login.DefaultMargin) &&
                   EqualityComparer<Size>.Default.Equals(DefaultMaximumSize, login.DefaultMaximumSize) &&
                   EqualityComparer<Size>.Default.Equals(DefaultMinimumSize, login.DefaultMinimumSize) &&
                   EqualityComparer<Padding>.Default.Equals(DefaultPadding, login.DefaultPadding) &&
                   EqualityComparer<Size>.Default.Equals(DefaultSize, login.DefaultSize) &&
                   DeviceDpi == login.DeviceDpi &&
                   EqualityComparer<Rectangle>.Default.Equals(DisplayRectangle, login.DisplayRectangle) &&
                   IsDisposed == login.IsDisposed &&
                   Disposing == login.Disposing &&
                   Dock == login.Dock &&
                   DoubleBuffered == login.DoubleBuffered &&
                   Enabled == login.Enabled &&
                   Focused == login.Focused &&
                   EqualityComparer<Font>.Default.Equals(Font, login.Font) &&
                   FontHeight == login.FontHeight &&
                   EqualityComparer<Color>.Default.Equals(ForeColor, login.ForeColor) &&
                   EqualityComparer<IntPtr>.Default.Equals(Handle, login.Handle) &&
                   HasChildren == login.HasChildren &&
                   Height == login.Height &&
                   IsHandleCreated == login.IsHandleCreated &&
                   InvokeRequired == login.InvokeRequired &&
                   IsAccessible == login.IsAccessible &&
                   IsMirrored == login.IsMirrored &&
                   Left == login.Left &&
                   EqualityComparer<Point>.Default.Equals(Location, login.Location) &&
                   EqualityComparer<Padding>.Default.Equals(Margin, login.Margin) &&
                   EqualityComparer<Size>.Default.Equals(MaximumSize, login.MaximumSize) &&
                   EqualityComparer<Size>.Default.Equals(MinimumSize, login.MinimumSize) &&
                   Name == login.Name &&
                   EqualityComparer<Control>.Default.Equals(Parent, login.Parent) &&
                   ProductName == login.ProductName &&
                   ProductVersion == login.ProductVersion &&
                   RecreatingHandle == login.RecreatingHandle &&
                   EqualityComparer<Region>.Default.Equals(Region, login.Region) &&
                   RenderRightToLeft == login.RenderRightToLeft &&
                   ResizeRedraw == login.ResizeRedraw &&
                   Right == login.Right &&
                   RightToLeft == login.RightToLeft &&
                   ScaleChildren == login.ScaleChildren &&
                   EqualityComparer<ISite>.Default.Equals(Site, login.Site) &&
                   EqualityComparer<Size>.Default.Equals(Size, login.Size) &&
                   TabIndex == login.TabIndex &&
                   TabStop == login.TabStop &&
                   EqualityComparer<object>.Default.Equals(Tag, login.Tag) &&
                   Text == login.Text &&
                   Top == login.Top &&
                   EqualityComparer<Control>.Default.Equals(TopLevelControl, login.TopLevelControl) &&
                   ShowKeyboardCues == login.ShowKeyboardCues &&
                   ShowFocusCues == login.ShowFocusCues &&
                   UseWaitCursor == login.UseWaitCursor &&
                   Visible == login.Visible &&
                   Width == login.Width &&
                   EqualityComparer<IWindowTarget>.Default.Equals(WindowTarget, login.WindowTarget) &&
                   EqualityComparer<Size>.Default.Equals(PreferredSize, login.PreferredSize) &&
                   EqualityComparer<Padding>.Default.Equals(Padding, login.Padding) &&
                   CanEnableIme == login.CanEnableIme &&
                   DefaultImeMode == login.DefaultImeMode &&
                   ImeMode == login.ImeMode &&
                   ImeModeBase == login.ImeModeBase &&
                   AutoScroll == login.AutoScroll &&
                   EqualityComparer<Size>.Default.Equals(AutoScrollMargin, login.AutoScrollMargin) &&
                   EqualityComparer<Point>.Default.Equals(AutoScrollPosition, login.AutoScrollPosition) &&
                   EqualityComparer<Size>.Default.Equals(AutoScrollMinSize, login.AutoScrollMinSize) &&
                   EqualityComparer<CreateParams>.Default.Equals(CreateParams, login.CreateParams) &&
                   EqualityComparer<Rectangle>.Default.Equals(DisplayRectangle, login.DisplayRectangle) &&
                   HScroll == login.HScroll &&
                   EqualityComparer<HScrollProperties>.Default.Equals(HorizontalScroll, login.HorizontalScroll) &&
                   VScroll == login.VScroll &&
                   EqualityComparer<VScrollProperties>.Default.Equals(VerticalScroll, login.VerticalScroll) &&
                   EqualityComparer<DockPaddingEdges>.Default.Equals(DockPadding, login.DockPadding) &&
                   EqualityComparer<SizeF>.Default.Equals(AutoScaleDimensions, login.AutoScaleDimensions) &&
                   EqualityComparer<SizeF>.Default.Equals(AutoScaleFactor, login.AutoScaleFactor) &&
                   AutoScaleMode == login.AutoScaleMode &&
                   AutoValidate == login.AutoValidate &&
                   EqualityComparer<BindingContext>.Default.Equals(BindingContext, login.BindingContext) &&
                   CanEnableIme == login.CanEnableIme &&
                   EqualityComparer<Control>.Default.Equals(ActiveControl, login.ActiveControl) &&
                   EqualityComparer<CreateParams>.Default.Equals(CreateParams, login.CreateParams) &&
                   EqualityComparer<SizeF>.Default.Equals(CurrentAutoScaleDimensions, login.CurrentAutoScaleDimensions) &&
                   EqualityComparer<Form>.Default.Equals(ParentForm, login.ParentForm) &&
                   EqualityComparer<IButtonControl>.Default.Equals(AcceptButton, login.AcceptButton) &&
                   EqualityComparer<Form>.Default.Equals(ActiveMdiChild, login.ActiveMdiChild) &&
                   AllowTransparency == login.AllowTransparency &&
                   AutoScale == login.AutoScale &&
                   EqualityComparer<Size>.Default.Equals(AutoScaleBaseSize, login.AutoScaleBaseSize) &&
                   AutoScroll == login.AutoScroll &&
                   AutoSize == login.AutoSize &&
                   AutoSizeMode == login.AutoSizeMode &&
                   AutoValidate == login.AutoValidate &&
                   EqualityComparer<Color>.Default.Equals(BackColor, login.BackColor) &&
                   FormBorderStyle == login.FormBorderStyle &&
                   EqualityComparer<IButtonControl>.Default.Equals(CancelButton, login.CancelButton) &&
                   EqualityComparer<Size>.Default.Equals(ClientSize, login.ClientSize) &&
                   ControlBox == login.ControlBox &&
                   EqualityComparer<CreateParams>.Default.Equals(CreateParams, login.CreateParams) &&
                   DefaultImeMode == login.DefaultImeMode &&
                   EqualityComparer<Size>.Default.Equals(DefaultSize, login.DefaultSize) &&
                   EqualityComparer<Rectangle>.Default.Equals(DesktopBounds, login.DesktopBounds) &&
                   EqualityComparer<Point>.Default.Equals(DesktopLocation, login.DesktopLocation) &&
                   DialogResult == login.DialogResult &&
                   HelpButton == login.HelpButton &&
                   EqualityComparer<Icon>.Default.Equals(Icon, login.Icon) &&
                   IsMdiChild == login.IsMdiChild &&
                   IsMdiContainer == login.IsMdiContainer &&
                   IsRestrictedWindow == login.IsRestrictedWindow &&
                   KeyPreview == login.KeyPreview &&
                   EqualityComparer<Point>.Default.Equals(Location, login.Location) &&
                   EqualityComparer<Rectangle>.Default.Equals(MaximizedBounds, login.MaximizedBounds) &&
                   EqualityComparer<Size>.Default.Equals(MaximumSize, login.MaximumSize) &&
                   EqualityComparer<MenuStrip>.Default.Equals(MainMenuStrip, login.MainMenuStrip) &&
                   EqualityComparer<Padding>.Default.Equals(Margin, login.Margin) &&
                   EqualityComparer<MainMenu>.Default.Equals(Menu, login.Menu) &&
                   EqualityComparer<Size>.Default.Equals(MinimumSize, login.MinimumSize) &&
                   MaximizeBox == login.MaximizeBox &&
                   EqualityComparer<Form[]>.Default.Equals(MdiChildren, login.MdiChildren) &&
                   EqualityComparer<Form>.Default.Equals(MdiParent, login.MdiParent) &&
                   EqualityComparer<MainMenu>.Default.Equals(MergedMenu, login.MergedMenu) &&
                   MinimizeBox == login.MinimizeBox &&
                   Modal == login.Modal &&
                   Opacity == login.Opacity &&
                   EqualityComparer<Form[]>.Default.Equals(OwnedForms, login.OwnedForms) &&
                   EqualityComparer<Form>.Default.Equals(Owner, login.Owner) &&
                   EqualityComparer<Rectangle>.Default.Equals(RestoreBounds, login.RestoreBounds) &&
                   RightToLeftLayout == login.RightToLeftLayout &&
                   ShowInTaskbar == login.ShowInTaskbar &&
                   ShowIcon == login.ShowIcon &&
                   ShowWithoutActivation == login.ShowWithoutActivation &&
                   EqualityComparer<Size>.Default.Equals(Size, login.Size) &&
                   SizeGripStyle == login.SizeGripStyle &&
                   StartPosition == login.StartPosition &&
                   TabIndex == login.TabIndex &&
                   TabStop == login.TabStop &&
                   Text == login.Text &&
                   TopLevel == login.TopLevel &&
                   TopMost == login.TopMost &&
                   EqualityComparer<Color>.Default.Equals(TransparencyKey, login.TransparencyKey) &&
                   WindowState == login.WindowState &&
                   EqualityComparer<IContainer>.Default.Equals(components, login.components) &&
                   EqualityComparer<Panel>.Default.Equals(panel1, login.panel1) &&
                   EqualityComparer<Guna2CirclePictureBox>.Default.Equals(guna2CirclePictureBox1, login.guna2CirclePictureBox1) &&
                   EqualityComparer<Label>.Default.Equals(label1, login.label1) &&
                   EqualityComparer<Label>.Default.Equals(label2, login.label2) &&
                   EqualityComparer<Guna2Button>.Default.Equals(guna2Button1, login.guna2Button1) &&
                   EqualityComparer<Label>.Default.Equals(label3, login.label3) &&
                   EqualityComparer<Label>.Default.Equals(label4, login.label4) &&
                   EqualityComparer<Guna2TextBox>.Default.Equals(guna2TextBox1, login.guna2TextBox1) &&
                   EqualityComparer<Guna2TextBox>.Default.Equals(guna2TextBox2, login.guna2TextBox2);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna2Button guna2Button5;
        private BackgroundWorker backgroundWorker1;
    }
}