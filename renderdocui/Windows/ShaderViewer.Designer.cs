﻿namespace renderdocui.Windows
{
    partial class ShaderViewer
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
            this.components = new System.ComponentModel.Container();
            TreelistView.TreeListColumn treeListColumn41 = new TreelistView.TreeListColumn("Name", "Name");
            TreelistView.TreeListColumn treeListColumn42 = new TreelistView.TreeListColumn("Type", "Type");
            TreelistView.TreeListColumn treeListColumn43 = new TreelistView.TreeListColumn("Value", "Value");
            TreelistView.TreeListColumn treeListColumn44 = new TreelistView.TreeListColumn("Name", "Name");
            TreelistView.TreeListColumn treeListColumn45 = new TreelistView.TreeListColumn("Type", "Type");
            TreelistView.TreeListColumn treeListColumn46 = new TreelistView.TreeListColumn("Value", "Value");
            WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin3 = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
            WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin3 = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient7 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient15 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin3 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient16 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient8 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient17 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient18 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient19 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient9 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient20 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient21 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShaderViewer));
            TreelistView.TreeListColumn treeListColumn47 = new TreelistView.TreeListColumn("Name", "Name");
            TreelistView.TreeListColumn treeListColumn48 = new TreelistView.TreeListColumn("Index", "Index");
            TreelistView.TreeListColumn treeListColumn49 = new TreelistView.TreeListColumn("Reg", "Reg");
            TreelistView.TreeListColumn treeListColumn50 = new TreelistView.TreeListColumn("Type", "Type");
            TreelistView.TreeListColumn treeListColumn51 = new TreelistView.TreeListColumn("SysValue", "SysValue");
            TreelistView.TreeListColumn treeListColumn52 = new TreelistView.TreeListColumn("Mask", "Mask");
            TreelistView.TreeListColumn treeListColumn53 = new TreelistView.TreeListColumn("Used", "Used");
            TreelistView.TreeListColumn treeListColumn54 = new TreelistView.TreeListColumn("Name", "Name");
            TreelistView.TreeListColumn treeListColumn55 = new TreelistView.TreeListColumn("Index", "Index");
            TreelistView.TreeListColumn treeListColumn56 = new TreelistView.TreeListColumn("Reg", "Reg");
            TreelistView.TreeListColumn treeListColumn57 = new TreelistView.TreeListColumn("Type", "Type");
            TreelistView.TreeListColumn treeListColumn58 = new TreelistView.TreeListColumn("SysValue", "SysValue");
            TreelistView.TreeListColumn treeListColumn59 = new TreelistView.TreeListColumn("Mask", "Mask");
            TreelistView.TreeListColumn treeListColumn60 = new TreelistView.TreeListColumn("Unused", "Unused");
            this.variableBox = new System.Windows.Forms.GroupBox();
            this.variableRegs = new TreelistView.TreeListView();
            this.constantBox = new System.Windows.Forms.GroupBox();
            this.constantRegs = new TreelistView.TreeListView();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.showWindows = new System.Windows.Forms.ToolStripDropDownButton();
            this.autosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debuggingStrip = new System.Windows.Forms.ToolStrip();
            this.stepBack = new System.Windows.Forms.ToolStripButton();
            this.stepNext = new System.Windows.Forms.ToolStripButton();
            this.runToCursor = new System.Windows.Forms.ToolStripButton();
            this.runBack = new System.Windows.Forms.ToolStripButton();
            this.run = new System.Windows.Forms.ToolStripButton();
            this.displayInts = new System.Windows.Forms.ToolStripButton();
            this.displayFloats = new System.Windows.Forms.ToolStripButton();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.editStrip = new System.Windows.Forms.ToolStrip();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.snippetDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.textureDimensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedMipGlobalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textureTypeGlobalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointLinearSamplersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textureResourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorsBox = new System.Windows.Forms.GroupBox();
            this.errors = new System.Windows.Forms.TextBox();
            this.inSigBox = new System.Windows.Forms.GroupBox();
            this.inSig = new TreelistView.TreeListView();
            this.outSigBox = new System.Windows.Forms.GroupBox();
            this.outSig = new TreelistView.TreeListView();
            this.watchBox = new System.Windows.Forms.GroupBox();
            this.watchRegs = new System.Windows.Forms.ListView();
            this.VarName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.variableHover = new System.Windows.Forms.ToolTip(this.components);
            this.hoverTimer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.mismatch = new System.Windows.Forms.Label();
            this.mismatchMoreInfo = new System.Windows.Forms.Button();
            this.variableBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variableRegs)).BeginInit();
            this.constantBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.constantRegs)).BeginInit();
            this.debuggingStrip.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.editStrip.SuspendLayout();
            this.errorsBox.SuspendLayout();
            this.inSigBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inSig)).BeginInit();
            this.outSigBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outSig)).BeginInit();
            this.watchBox.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // variableBox
            // 
            this.variableBox.Controls.Add(this.variableRegs);
            this.variableBox.Location = new System.Drawing.Point(241, 330);
            this.variableBox.Name = "variableBox";
            this.variableBox.Size = new System.Drawing.Size(189, 188);
            this.variableBox.TabIndex = 6;
            this.variableBox.TabStop = false;
            this.variableBox.Text = "Variable Registers";
            // 
            // variableRegs
            // 
            treeListColumn41.AutoSizeMinSize = 0;
            treeListColumn41.Width = 105;
            treeListColumn42.AutoSizeMinSize = 0;
            treeListColumn42.Width = 57;
            treeListColumn43.AutoSize = true;
            treeListColumn43.AutoSizeMinSize = 0;
            treeListColumn43.Width = 183;
            this.variableRegs.Columns.AddRange(new TreelistView.TreeListColumn[] {
            treeListColumn41,
            treeListColumn42,
            treeListColumn43});
            this.variableRegs.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.variableRegs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variableRegs.Location = new System.Drawing.Point(3, 16);
            this.variableRegs.MultiSelect = false;
            this.variableRegs.Name = "variableRegs";
            this.variableRegs.RowOptions.ShowHeader = false;
            this.variableRegs.Size = new System.Drawing.Size(183, 169);
            this.variableRegs.TabIndex = 1;
            this.variableRegs.Text = "treeListView1";
            this.variableRegs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DebugKeys_KeyDown);
            this.variableRegs.Leave += new System.EventHandler(this.regsList_Leave);
            this.variableRegs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.regsList_MouseMove);
            // 
            // constantBox
            // 
            this.constantBox.Controls.Add(this.constantRegs);
            this.constantBox.Location = new System.Drawing.Point(3, 330);
            this.constantBox.Name = "constantBox";
            this.constantBox.Size = new System.Drawing.Size(232, 190);
            this.constantBox.TabIndex = 7;
            this.constantBox.TabStop = false;
            this.constantBox.Text = "Constants && Resources";
            // 
            // constantRegs
            // 
            treeListColumn44.AutoSizeMinSize = 0;
            treeListColumn44.Width = 109;
            treeListColumn45.AutoSizeMinSize = 0;
            treeListColumn45.Width = 57;
            treeListColumn46.AutoSize = true;
            treeListColumn46.AutoSizeMinSize = 0;
            treeListColumn46.Width = 180;
            this.constantRegs.Columns.AddRange(new TreelistView.TreeListColumn[] {
            treeListColumn44,
            treeListColumn45,
            treeListColumn46});
            this.constantRegs.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.constantRegs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constantRegs.Location = new System.Drawing.Point(3, 16);
            this.constantRegs.MultiSelect = false;
            this.constantRegs.Name = "constantRegs";
            this.constantRegs.RowOptions.ShowHeader = false;
            this.constantRegs.Size = new System.Drawing.Size(226, 171);
            this.constantRegs.TabIndex = 0;
            this.constantRegs.Text = "treeListView1";
            this.constantRegs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DebugKeys_KeyDown);
            this.constantRegs.Leave += new System.EventHandler(this.regsList_Leave);
            this.constantRegs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.regsList_MouseMove);
            // 
            // dockPanel
            // 
            this.dockPanel.DefaultFloatWindowSize = new System.Drawing.Size(800, 500);
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.DockBackColor = System.Drawing.SystemColors.ControlDark;
            this.dockPanel.DockBottomPortion = 0.33D;
            this.dockPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dockPanel.Location = new System.Drawing.Point(3, 69);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(424, 250);
            dockPanelGradient7.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient7.StartColor = System.Drawing.SystemColors.ControlLight;
            autoHideStripSkin3.DockStripGradient = dockPanelGradient7;
            tabGradient15.EndColor = System.Drawing.SystemColors.Control;
            tabGradient15.StartColor = System.Drawing.SystemColors.Control;
            tabGradient15.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            autoHideStripSkin3.TabGradient = tabGradient15;
            autoHideStripSkin3.TextFont = new System.Drawing.Font("Tahoma", 8.25F);
            dockPanelSkin3.AutoHideStripSkin = autoHideStripSkin3;
            tabGradient16.EndColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient16.StartColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient16.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient3.ActiveTabGradient = tabGradient16;
            dockPanelGradient8.EndColor = System.Drawing.SystemColors.Control;
            dockPanelGradient8.StartColor = System.Drawing.SystemColors.Control;
            dockPaneStripGradient3.DockStripGradient = dockPanelGradient8;
            tabGradient17.EndColor = System.Drawing.SystemColors.ControlLight;
            tabGradient17.StartColor = System.Drawing.SystemColors.ControlLight;
            tabGradient17.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient3.InactiveTabGradient = tabGradient17;
            dockPaneStripSkin3.DocumentGradient = dockPaneStripGradient3;
            dockPaneStripSkin3.TextFont = new System.Drawing.Font("Tahoma", 8.25F);
            tabGradient18.EndColor = System.Drawing.SystemColors.ActiveCaption;
            tabGradient18.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient18.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
            tabGradient18.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            dockPaneStripToolWindowGradient3.ActiveCaptionGradient = tabGradient18;
            tabGradient19.EndColor = System.Drawing.SystemColors.Control;
            tabGradient19.StartColor = System.Drawing.SystemColors.Control;
            tabGradient19.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripToolWindowGradient3.ActiveTabGradient = tabGradient19;
            dockPanelGradient9.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient9.StartColor = System.Drawing.SystemColors.ControlLight;
            dockPaneStripToolWindowGradient3.DockStripGradient = dockPanelGradient9;
            tabGradient20.EndColor = System.Drawing.SystemColors.InactiveCaption;
            tabGradient20.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient20.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tabGradient20.TextColor = System.Drawing.SystemColors.InactiveCaptionText;
            dockPaneStripToolWindowGradient3.InactiveCaptionGradient = tabGradient20;
            tabGradient21.EndColor = System.Drawing.Color.Transparent;
            tabGradient21.StartColor = System.Drawing.Color.Transparent;
            tabGradient21.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            dockPaneStripToolWindowGradient3.InactiveTabGradient = tabGradient21;
            dockPaneStripSkin3.ToolWindowGradient = dockPaneStripToolWindowGradient3;
            dockPanelSkin3.DockPaneStripSkin = dockPaneStripSkin3;
            this.dockPanel.Skin = dockPanelSkin3;
            this.dockPanel.TabIndex = 2;
            // 
            // showWindows
            // 
            this.showWindows.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autosToolStripMenuItem,
            this.resourcesToolStripMenuItem,
            this.watchToolStripMenuItem});
            this.showWindows.Image = global::renderdocui.Properties.Resources.new_window;
            this.showWindows.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showWindows.Name = "showWindows";
            this.showWindows.Size = new System.Drawing.Size(29, 22);
            this.showWindows.Text = "Show Windows";
            this.showWindows.ToolTipText = "Show Window";
            // 
            // autosToolStripMenuItem
            // 
            this.autosToolStripMenuItem.Name = "autosToolStripMenuItem";
            this.autosToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.autosToolStripMenuItem.Text = "Autos";
            this.autosToolStripMenuItem.Click += new System.EventHandler(this.autosToolStripMenuItem_Click);
            // 
            // resourcesToolStripMenuItem
            // 
            this.resourcesToolStripMenuItem.Name = "resourcesToolStripMenuItem";
            this.resourcesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.resourcesToolStripMenuItem.Text = "Resources";
            // 
            // watchToolStripMenuItem
            // 
            this.watchToolStripMenuItem.Name = "watchToolStripMenuItem";
            this.watchToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.watchToolStripMenuItem.Text = "Watch";
            this.watchToolStripMenuItem.Click += new System.EventHandler(this.watchToolStripMenuItem_Click);
            // 
            // debuggingStrip
            // 
            this.debuggingStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.debuggingStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.debuggingStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stepBack,
            this.stepNext,
            this.runToCursor,
            this.runBack,
            this.run,
            this.showWindows,
            this.displayInts,
            this.displayFloats});
            this.debuggingStrip.Location = new System.Drawing.Point(0, 0);
            this.debuggingStrip.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.debuggingStrip.Name = "debuggingStrip";
            this.debuggingStrip.Size = new System.Drawing.Size(203, 25);
            this.debuggingStrip.TabIndex = 0;
            this.debuggingStrip.Text = "Debugging";
            // 
            // stepBack
            // 
            this.stepBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stepBack.Image = global::renderdocui.Properties.Resources.stepprev;
            this.stepBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stepBack.Name = "stepBack";
            this.stepBack.Size = new System.Drawing.Size(23, 22);
            this.stepBack.Text = "Step Back";
            this.stepBack.ToolTipText = "Step Back (Shift-F10)";
            this.stepBack.Click += new System.EventHandler(this.stepBack_Click);
            // 
            // stepNext
            // 
            this.stepNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stepNext.Image = global::renderdocui.Properties.Resources.stepnext;
            this.stepNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stepNext.Name = "stepNext";
            this.stepNext.Size = new System.Drawing.Size(23, 22);
            this.stepNext.Text = "Step Next";
            this.stepNext.ToolTipText = "Step Next (F10)";
            this.stepNext.Click += new System.EventHandler(this.stepNext_Click);
            // 
            // runToCursor
            // 
            this.runToCursor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runToCursor.Image = global::renderdocui.Properties.Resources.runcursor;
            this.runToCursor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runToCursor.Name = "runToCursor";
            this.runToCursor.Size = new System.Drawing.Size(23, 22);
            this.runToCursor.Text = "Run to Cursor";
            this.runToCursor.ToolTipText = "Run to Cursor (Ctrl-F10)";
            this.runToCursor.Click += new System.EventHandler(this.runToCursor_Click);
            // 
            // runBack
            // 
            this.runBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runBack.Image = global::renderdocui.Properties.Resources.runback;
            this.runBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runBack.Name = "runBack";
            this.runBack.Size = new System.Drawing.Size(23, 22);
            this.runBack.Text = "Run Backwards";
            this.runBack.ToolTipText = "Run Backwards";
            this.runBack.Click += new System.EventHandler(this.runBack_Click);
            // 
            // run
            // 
            this.run.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.run.Image = global::renderdocui.Properties.Resources.runfwd;
            this.run.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(23, 22);
            this.run.Text = "Run";
            this.run.ToolTipText = "Run (F5)";
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // displayInts
            // 
            this.displayInts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.displayInts.Image = ((System.Drawing.Image)(resources.GetObject("displayInts.Image")));
            this.displayInts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.displayInts.Name = "displayInts";
            this.displayInts.Size = new System.Drawing.Size(23, 22);
            this.displayInts.Text = "int";
            this.displayInts.Click += new System.EventHandler(this.displayInts_Click);
            // 
            // displayFloats
            // 
            this.displayFloats.Checked = true;
            this.displayFloats.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displayFloats.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.displayFloats.Image = ((System.Drawing.Image)(resources.GetObject("displayFloats.Image")));
            this.displayFloats.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.displayFloats.Name = "displayFloats";
            this.displayFloats.Size = new System.Drawing.Size(33, 22);
            this.displayFloats.Text = "float";
            this.displayFloats.Click += new System.EventHandler(this.displayFloats_Click);
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.mainLayout.Controls.Add(this.dockPanel, 0, 2);
            this.mainLayout.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.mainLayout.Location = new System.Drawing.Point(3, 2);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(430, 322);
            this.mainLayout.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.debuggingStrip);
            this.flowLayoutPanel1.Controls.Add(this.editStrip);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(424, 25);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // editStrip
            // 
            this.editStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.editStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveButton,
            this.snippetDropDown});
            this.editStrip.Location = new System.Drawing.Point(215, 0);
            this.editStrip.Name = "editStrip";
            this.editStrip.Size = new System.Drawing.Size(55, 25);
            this.editStrip.TabIndex = 2;
            this.editStrip.Text = "editStrip";
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = global::renderdocui.Properties.Resources.save;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(23, 22);
            this.saveButton.Text = "Save Changes";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // snippetDropDown
            // 
            this.snippetDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.snippetDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textureDimensionsToolStripMenuItem,
            this.selectedMipGlobalToolStripMenuItem,
            this.textureTypeGlobalToolStripMenuItem,
            this.pointLinearSamplersToolStripMenuItem,
            this.textureResourcesToolStripMenuItem});
            this.snippetDropDown.Image = global::renderdocui.Properties.Resources.plugin_add;
            this.snippetDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.snippetDropDown.Name = "snippetDropDown";
            this.snippetDropDown.Size = new System.Drawing.Size(29, 22);
            this.snippetDropDown.Text = "Insert Code Snippet";
            // 
            // textureDimensionsToolStripMenuItem
            // 
            this.textureDimensionsToolStripMenuItem.Name = "textureDimensionsToolStripMenuItem";
            this.textureDimensionsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.textureDimensionsToolStripMenuItem.Text = "Texture Dimensions Global";
            this.textureDimensionsToolStripMenuItem.Click += new System.EventHandler(this.textureDimensionsToolStripMenuItem_Click);
            // 
            // selectedMipGlobalToolStripMenuItem
            // 
            this.selectedMipGlobalToolStripMenuItem.Name = "selectedMipGlobalToolStripMenuItem";
            this.selectedMipGlobalToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.selectedMipGlobalToolStripMenuItem.Text = "Selected Mip Global";
            this.selectedMipGlobalToolStripMenuItem.Click += new System.EventHandler(this.selectedMipGlobalToolStripMenuItem_Click);
            // 
            // textureTypeGlobalToolStripMenuItem
            // 
            this.textureTypeGlobalToolStripMenuItem.Name = "textureTypeGlobalToolStripMenuItem";
            this.textureTypeGlobalToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.textureTypeGlobalToolStripMenuItem.Text = "Texture Type Global";
            this.textureTypeGlobalToolStripMenuItem.Click += new System.EventHandler(this.textureTypeGlobalToolStripMenuItem_Click);
            // 
            // pointLinearSamplersToolStripMenuItem
            // 
            this.pointLinearSamplersToolStripMenuItem.Name = "pointLinearSamplersToolStripMenuItem";
            this.pointLinearSamplersToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.pointLinearSamplersToolStripMenuItem.Text = "Point && Linear Samplers";
            this.pointLinearSamplersToolStripMenuItem.Click += new System.EventHandler(this.pointLinearSamplersToolStripMenuItem_Click);
            // 
            // textureResourcesToolStripMenuItem
            // 
            this.textureResourcesToolStripMenuItem.Name = "textureResourcesToolStripMenuItem";
            this.textureResourcesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.textureResourcesToolStripMenuItem.Text = "Texture Resources";
            this.textureResourcesToolStripMenuItem.Click += new System.EventHandler(this.textureResourcesToolStripMenuItem_Click);
            // 
            // errorsBox
            // 
            this.errorsBox.Controls.Add(this.errors);
            this.errorsBox.Location = new System.Drawing.Point(439, 5);
            this.errorsBox.Name = "errorsBox";
            this.errorsBox.Size = new System.Drawing.Size(202, 141);
            this.errorsBox.TabIndex = 9;
            this.errorsBox.TabStop = false;
            this.errorsBox.Text = "Errors && Warnings";
            // 
            // errors
            // 
            this.errors.BackColor = System.Drawing.SystemColors.Window;
            this.errors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errors.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errors.Location = new System.Drawing.Point(3, 16);
            this.errors.Multiline = true;
            this.errors.Name = "errors";
            this.errors.ReadOnly = true;
            this.errors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.errors.Size = new System.Drawing.Size(196, 122);
            this.errors.TabIndex = 0;
            // 
            // inSigBox
            // 
            this.inSigBox.Controls.Add(this.inSig);
            this.inSigBox.Location = new System.Drawing.Point(442, 152);
            this.inSigBox.Name = "inSigBox";
            this.inSigBox.Size = new System.Drawing.Size(458, 188);
            this.inSigBox.TabIndex = 7;
            this.inSigBox.TabStop = false;
            this.inSigBox.Text = "Input Signature";
            // 
            // inSig
            // 
            treeListColumn47.AutoSize = true;
            treeListColumn47.AutoSizeMinSize = 20;
            treeListColumn47.Width = 100;
            treeListColumn48.AutoSizeMinSize = 10;
            treeListColumn48.Width = 50;
            treeListColumn49.AutoSizeMinSize = 10;
            treeListColumn49.Width = 50;
            treeListColumn50.AutoSizeMinSize = 20;
            treeListColumn50.Width = 60;
            treeListColumn51.AutoSizeMinSize = 15;
            treeListColumn51.Width = 75;
            treeListColumn52.AutoSizeMinSize = 15;
            treeListColumn52.Width = 50;
            treeListColumn53.AutoSizeMinSize = 15;
            treeListColumn53.Width = 50;
            this.inSig.Columns.AddRange(new TreelistView.TreeListColumn[] {
            treeListColumn47,
            treeListColumn48,
            treeListColumn49,
            treeListColumn50,
            treeListColumn51,
            treeListColumn52,
            treeListColumn53});
            this.inSig.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.inSig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inSig.Location = new System.Drawing.Point(3, 16);
            this.inSig.MultiSelect = false;
            this.inSig.Name = "inSig";
            this.inSig.RowOptions.ShowHeader = false;
            this.inSig.Size = new System.Drawing.Size(452, 169);
            this.inSig.TabIndex = 1;
            this.inSig.Text = "Input Signature";
            this.inSig.ViewOptions.ShowLine = false;
            this.inSig.ViewOptions.ShowPlusMinus = false;
            // 
            // outSigBox
            // 
            this.outSigBox.Controls.Add(this.outSig);
            this.outSigBox.Location = new System.Drawing.Point(442, 346);
            this.outSigBox.Name = "outSigBox";
            this.outSigBox.Size = new System.Drawing.Size(458, 172);
            this.outSigBox.TabIndex = 8;
            this.outSigBox.TabStop = false;
            this.outSigBox.Text = "Output Signature";
            // 
            // outSig
            // 
            treeListColumn54.AutoSize = true;
            treeListColumn54.AutoSizeMinSize = 20;
            treeListColumn54.Width = 100;
            treeListColumn55.AutoSizeMinSize = 10;
            treeListColumn55.Width = 50;
            treeListColumn56.AutoSizeMinSize = 10;
            treeListColumn56.Width = 50;
            treeListColumn57.AutoSizeMinSize = 20;
            treeListColumn57.Width = 60;
            treeListColumn58.AutoSizeMinSize = 15;
            treeListColumn58.Width = 75;
            treeListColumn59.AutoSizeMinSize = 15;
            treeListColumn59.Width = 50;
            treeListColumn60.AutoSizeMinSize = 15;
            treeListColumn60.Width = 50;
            this.outSig.Columns.AddRange(new TreelistView.TreeListColumn[] {
            treeListColumn54,
            treeListColumn55,
            treeListColumn56,
            treeListColumn57,
            treeListColumn58,
            treeListColumn59,
            treeListColumn60});
            this.outSig.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.outSig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outSig.Location = new System.Drawing.Point(3, 16);
            this.outSig.MultiSelect = false;
            this.outSig.Name = "outSig";
            this.outSig.RowOptions.ShowHeader = false;
            this.outSig.Size = new System.Drawing.Size(452, 153);
            this.outSig.TabIndex = 1;
            this.outSig.Text = "Output Signature";
            this.outSig.ViewOptions.ShowLine = false;
            this.outSig.ViewOptions.ShowPlusMinus = false;
            // 
            // watchBox
            // 
            this.watchBox.Controls.Add(this.watchRegs);
            this.watchBox.Location = new System.Drawing.Point(647, 5);
            this.watchBox.Name = "watchBox";
            this.watchBox.Size = new System.Drawing.Size(250, 141);
            this.watchBox.TabIndex = 10;
            this.watchBox.TabStop = false;
            this.watchBox.Text = "Watch";
            // 
            // watchRegs
            // 
            this.watchRegs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.watchRegs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.VarName,
            this.Type,
            this.Value});
            this.watchRegs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watchRegs.FullRowSelect = true;
            this.watchRegs.GridLines = true;
            this.watchRegs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.watchRegs.LabelEdit = true;
            this.watchRegs.Location = new System.Drawing.Point(3, 16);
            this.watchRegs.MultiSelect = false;
            this.watchRegs.Name = "watchRegs";
            this.watchRegs.Size = new System.Drawing.Size(244, 122);
            this.watchRegs.TabIndex = 0;
            this.watchRegs.UseCompatibleStateImageBehavior = false;
            this.watchRegs.View = System.Windows.Forms.View.Details;
            this.watchRegs.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.watchRegs_AfterLabelEdit);
            this.watchRegs.Click += new System.EventHandler(this.watchRegs_Click);
            this.watchRegs.DoubleClick += new System.EventHandler(this.watchRegs_DoubleClick);
            this.watchRegs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DebugKeys_KeyDown);
            this.watchRegs.KeyUp += new System.Windows.Forms.KeyEventHandler(this.watchRegs_KeyUp);
            this.watchRegs.Layout += new System.Windows.Forms.LayoutEventHandler(this.watchRegs_Layout);
            this.watchRegs.Leave += new System.EventHandler(this.regsList_Leave);
            this.watchRegs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.regsList_MouseMove);
            // 
            // VarName
            // 
            this.VarName.Text = "Name";
            // 
            // Type
            // 
            this.Type.Text = "Type";
            // 
            // Value
            // 
            this.Value.Text = "Value";
            // 
            // variableHover
            // 
            this.variableHover.AutoPopDelay = 5000;
            this.variableHover.InitialDelay = 1000;
            this.variableHover.OwnerDraw = true;
            this.variableHover.ReshowDelay = 100;
            this.variableHover.UseAnimation = false;
            this.variableHover.UseFading = false;
            this.variableHover.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.variableHover_Draw);
            this.variableHover.Popup += new System.Windows.Forms.PopupEventHandler(this.variableHover_Popup);
            // 
            // hoverTimer
            // 
            this.hoverTimer.Interval = 500;
            this.hoverTimer.Tick += new System.EventHandler(this.hoverTimer_Tick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.mismatch);
            this.flowLayoutPanel2.Controls.Add(this.mismatchMoreInfo);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 34);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(328, 29);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // mismatch
            // 
            this.mismatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mismatch.AutoSize = true;
            this.mismatch.ForeColor = System.Drawing.Color.Red;
            this.mismatch.Location = new System.Drawing.Point(3, 0);
            this.mismatch.Name = "mismatch";
            this.mismatch.Size = new System.Drawing.Size(241, 29);
            this.mismatch.TabIndex = 0;
            this.mismatch.Text = "Warning: Mismatch between actual and debugged outputs!";
            this.mismatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mismatchMoreInfo
            // 
            this.mismatchMoreInfo.Location = new System.Drawing.Point(250, 3);
            this.mismatchMoreInfo.Name = "mismatchMoreInfo";
            this.mismatchMoreInfo.Size = new System.Drawing.Size(75, 23);
            this.mismatchMoreInfo.TabIndex = 1;
            this.mismatchMoreInfo.Text = "More Info";
            this.mismatchMoreInfo.UseVisualStyleBackColor = true;
            this.mismatchMoreInfo.Click += new System.EventHandler(this.mismatchMoreInfo_Click);
            // 
            // ShaderViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 521);
            this.Controls.Add(this.watchBox);
            this.Controls.Add(this.outSigBox);
            this.Controls.Add(this.inSigBox);
            this.Controls.Add(this.errorsBox);
            this.Controls.Add(this.mainLayout);
            this.Controls.Add(this.variableBox);
            this.Controls.Add(this.constantBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ShaderViewer";
            this.Text = "ShaderViewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShaderViewer_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShaderViewer_FormClosed);
            this.variableBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.variableRegs)).EndInit();
            this.constantBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.constantRegs)).EndInit();
            this.debuggingStrip.ResumeLayout(false);
            this.debuggingStrip.PerformLayout();
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.editStrip.ResumeLayout(false);
            this.editStrip.PerformLayout();
            this.errorsBox.ResumeLayout(false);
            this.errorsBox.PerformLayout();
            this.inSigBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inSig)).EndInit();
            this.outSigBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outSig)).EndInit();
            this.watchBox.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox variableBox;
        private System.Windows.Forms.GroupBox constantBox;
        private TreelistView.TreeListView constantRegs;
        private TreelistView.TreeListView variableRegs;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.ToolStrip debuggingStrip;
        private System.Windows.Forms.ToolStripButton stepBack;
        private System.Windows.Forms.ToolStripButton stepNext;
        private System.Windows.Forms.ToolStripButton runToCursor;
        private System.Windows.Forms.ToolStripButton runBack;
        private System.Windows.Forms.ToolStripButton run;
        private System.Windows.Forms.ToolStripDropDownButton showWindows;
        private System.Windows.Forms.ToolStripMenuItem autosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStrip editStrip;
        private System.Windows.Forms.ToolStripDropDownButton snippetDropDown;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripMenuItem textureDimensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedMipGlobalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textureTypeGlobalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointLinearSamplersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textureResourcesToolStripMenuItem;
        private System.Windows.Forms.GroupBox errorsBox;
        private System.Windows.Forms.TextBox errors;
        private TreelistView.TreeListView inSig;
        private TreelistView.TreeListView outSig;
        private System.Windows.Forms.GroupBox inSigBox;
        private System.Windows.Forms.GroupBox outSigBox;
        private System.Windows.Forms.ToolStripButton displayInts;
        private System.Windows.Forms.ToolStripButton displayFloats;
        private System.Windows.Forms.GroupBox watchBox;
        private System.Windows.Forms.ListView watchRegs;
        private System.Windows.Forms.ColumnHeader VarName;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ToolTip variableHover;
        private System.Windows.Forms.Timer hoverTimer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label mismatch;
        private System.Windows.Forms.Button mismatchMoreInfo;
    }
}
