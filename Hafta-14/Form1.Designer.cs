namespace Hafta_14
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detayliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kucukSimgelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyukSimgelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.ımageList2;
            this.listView1.Location = new System.Drawing.Point(170, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(630, 450);
            this.listView1.SmallImageList = this.ımageList1;
            this.listView1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.listView1, "buraya sağ tıklayabilirsin.");
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 450);
            this.textBox1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detayliToolStripMenuItem,
            this.kucukSimgelerToolStripMenuItem,
            this.buyukSimgelerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 70);
            // 
            // detayliToolStripMenuItem
            // 
            this.detayliToolStripMenuItem.Name = "detayliToolStripMenuItem";
            this.detayliToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.detayliToolStripMenuItem.Text = "Detayli";
            this.detayliToolStripMenuItem.Click += new System.EventHandler(this.detayliToolStripMenuItem_Click);
            // 
            // kucukSimgelerToolStripMenuItem
            // 
            this.kucukSimgelerToolStripMenuItem.Name = "kucukSimgelerToolStripMenuItem";
            this.kucukSimgelerToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.kucukSimgelerToolStripMenuItem.Text = "Kucuk Simgeler";
            this.kucukSimgelerToolStripMenuItem.Click += new System.EventHandler(this.kucukSimgelerToolStripMenuItem_Click);
            // 
            // buyukSimgelerToolStripMenuItem
            // 
            this.buyukSimgelerToolStripMenuItem.Name = "buyukSimgelerToolStripMenuItem";
            this.buyukSimgelerToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.buyukSimgelerToolStripMenuItem.Text = "Buyuk Simgeler";
            this.buyukSimgelerToolStripMenuItem.Click += new System.EventHandler(this.buyukSimgelerToolStripMenuItem_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "AQUA ICONS FOLDER (NO WRITE).png");
            this.ımageList1.Images.SetKeyName(1, "AQUA ICONS FOLDER (PRIVATE).png");
            this.ımageList1.Images.SetKeyName(2, "AQUA ICONS FOLDER ADD.png");
            this.ımageList1.Images.SetKeyName(3, "AQUA ICONS FOLDER APPLE.png");
            this.ımageList1.Images.SetKeyName(4, "AQUA ICONS FOLDER APPS.png");
            this.ımageList1.Images.SetKeyName(5, "AQUA ICONS FOLDER CLASSIC.png");
            this.ımageList1.Images.SetKeyName(6, "AQUA ICONS FOLDER CLASSIC_OLD.png");
            this.ımageList1.Images.SetKeyName(7, "AQUA ICONS FOLDER CLOSED.png");
            this.ımageList1.Images.SetKeyName(8, "AQUA ICONS FOLDER DIALUP.png");
            this.ımageList1.Images.SetKeyName(9, "AQUA ICONS FOLDER DOCUMENTS.png");
            this.ımageList1.Images.SetKeyName(10, "AQUA ICONS FOLDER EXPLORER.png");
            this.ımageList1.Images.SetKeyName(11, "AQUA ICONS FOLDER FAVORITES.png");
            this.ımageList1.Images.SetKeyName(12, "AQUA ICONS FOLDER FILE SHARING.png");
            this.ımageList1.Images.SetKeyName(13, "AQUA ICONS FOLDER FONTS.png");
            this.ımageList1.Images.SetKeyName(14, "AQUA ICONS FOLDER INTERNATIONAL.png");
            this.ımageList1.Images.SetKeyName(15, "AQUA ICONS FOLDER INTERNET.png");
            this.ımageList1.Images.SetKeyName(16, "AQUA ICONS FOLDER LIBRARY.png");
            this.ımageList1.Images.SetKeyName(17, "AQUA ICONS FOLDER MOVIES.png");
            this.ımageList1.Images.SetKeyName(18, "AQUA ICONS FOLDER MUSIC.png");
            this.ımageList1.Images.SetKeyName(19, "AQUA ICONS FOLDER OPENED.png");
            this.ımageList1.Images.SetKeyName(20, "AQUA ICONS FOLDER OSX.png");
            this.ımageList1.Images.SetKeyName(21, "AQUA ICONS FOLDER PICTURES.png");
            this.ımageList1.Images.SetKeyName(22, "AQUA ICONS FOLDER PREFERENCES.png");
            this.ımageList1.Images.SetKeyName(23, "AQUA ICONS FOLDER PRINTERS.png");
            this.ımageList1.Images.SetKeyName(24, "AQUA ICONS FOLDER SCHEDULED TASKS.png");
            this.ımageList1.Images.SetKeyName(25, "AQUA ICONS FOLDER SHARING.png");
            this.ımageList1.Images.SetKeyName(26, "AQUA ICONS FOLDER SHUTDOWNITEMS.png");
            this.ımageList1.Images.SetKeyName(27, "AQUA ICONS FOLDER SONGS.png");
            this.ımageList1.Images.SetKeyName(28, "AQUA ICONS FOLDER STARTUP ITEMS.png");
            this.ımageList1.Images.SetKeyName(29, "AQUA ICONS FOLDER STARTUP-SHUTDOWN IT.png");
            this.ımageList1.Images.SetKeyName(30, "AQUA ICONS FOLDER SYSTEM.png");
            this.ımageList1.Images.SetKeyName(31, "AQUA ICONS FOLDER USER GROUPS.png");
            this.ımageList1.Images.SetKeyName(32, "AQUA ICONS FOLDER UTILITIES.png");
            this.ımageList1.Images.SetKeyName(33, "AQUA ICONS FOLDER WEB DOWNLOADS.png");
            this.ımageList1.Images.SetKeyName(34, "AQUA ICONS MSN MESSENGER X.png");
            this.ımageList1.Images.SetKeyName(35, "BACKUP FOLDER.png");
            this.ımageList1.Images.SetKeyName(36, "BLUE.png");
            this.ımageList1.Images.SetKeyName(37, "clanbomber.png");
            this.ımageList1.Images.SetKeyName(38, "CLASSIC.png");
            this.ımageList1.Images.SetKeyName(39, "clean.png");
            this.ımageList1.Images.SetKeyName(40, "CRISTAL CRYSTAL FOLDER.png");
            this.ımageList1.Images.SetKeyName(41, "CRISTAL GRAPHITE FOLDER.png");
            this.ımageList1.Images.SetKeyName(42, "CRISTAL LIME FOLDER.png");
            this.ımageList1.Images.SetKeyName(43, "CRISTAL MIDI.png");
            this.ımageList1.Images.SetKeyName(44, "CRISTAL MUSIC FOLDER.png");
            this.ımageList1.Images.SetKeyName(45, "CRISTAL RUBY FOLDER.png");
            this.ımageList1.Images.SetKeyName(46, "CRISTAL STRAWBERRY FOLDER.png");
            this.ımageList1.Images.SetKeyName(47, "CRISTAL TANGERINE FOLDER.png");
            this.ımageList1.Images.SetKeyName(48, "Document and Big Bug.png");
            this.ımageList1.Images.SetKeyName(49, "Document and Bug.png");
            this.ımageList1.Images.SetKeyName(50, "Document, Bug and Photo.png");
            this.ımageList1.Images.SetKeyName(51, "Documents.png");
            this.ımageList1.Images.SetKeyName(52, "Dossier-vierge.png");
            this.ımageList1.Images.SetKeyName(53, "down.png");
            this.ımageList1.Images.SetKeyName(54, "Download.png");
            this.ımageList1.Images.SetKeyName(55, "dreamweaver.png");
            this.ımageList1.Images.SetKeyName(56, "DUOTANG ESSENTIALS ICON PP02.png");
            this.ımageList1.Images.SetKeyName(57, "DUOTANG ESSENTIALS ICON PP03.png");
            this.ımageList1.Images.SetKeyName(58, "DUOTANG ESSENTIALS ICON PP05.png");
            this.ımageList1.Images.SetKeyName(59, "DUOTANG ESSENTIALS ICON PP07.png");
            this.ımageList1.Images.SetKeyName(60, "DUOTANG ESSENTIALS ICON PP08.png");
            this.ımageList1.Images.SetKeyName(61, "DUOTANG ESSENTIALS ICON PP09.png");
            this.ımageList1.Images.SetKeyName(62, "DUOTANG ESSENTIALS ICON PP10.png");
            this.ımageList1.Images.SetKeyName(63, "DUOTANG ESSENTIALS ICON PP11.png");
            this.ımageList1.Images.SetKeyName(64, "DUOTANG ESSENTIALS ICON PP12.png");
            this.ımageList1.Images.SetKeyName(65, "DUOTANG ESSENTIALS ICON PP13.png");
            this.ımageList1.Images.SetKeyName(66, "DUOTANG ESSENTIALS ICON PP14.png");
            this.ımageList1.Images.SetKeyName(67, "DUOTANG ESSENTIALS ICON PP15.png");
            this.ımageList1.Images.SetKeyName(68, "DUOTANG ESSENTIALS ICON PP16.png");
            this.ımageList1.Images.SetKeyName(69, "DUOTANG ESSENTIALS ICON PP17.png");
            this.ımageList1.Images.SetKeyName(70, "DUOTANG ESSENTIALS ICON PP18.png");
            this.ımageList1.Images.SetKeyName(71, "DUOTANG ESSENTIALS ICON PP19.png");
            this.ımageList1.Images.SetKeyName(72, "DUOTANG ESSENTIALS ICON PP20.png");
            this.ımageList1.Images.SetKeyName(73, "DURANIUM FOLDER APPLE BLACK.png");
            this.ımageList1.Images.SetKeyName(74, "DURANIUM FOLDER APPLE RED.png");
            this.ımageList1.Images.SetKeyName(75, "DURANIUM FOLDER APPLE WHITE.png");
            this.ımageList1.Images.SetKeyName(76, "DURANIUM FOLDER APPLICATIONS 2.png");
            this.ımageList1.Images.SetKeyName(77, "DURANIUM FOLDER APPLICATIONS.png");
            this.ımageList1.Images.SetKeyName(78, "DURANIUM FOLDER CD-DVD.png");
            this.ımageList1.Images.SetKeyName(79, "DURANIUM FOLDER CLASSIC SYSTEM.png");
            this.ımageList1.Images.SetKeyName(80, "DURANIUM FOLDER DOCUMENTS.png");
            this.ımageList1.Images.SetKeyName(81, "DURANIUM FOLDER DOWNLOAD BLUE.png");
            this.ımageList1.Images.SetKeyName(82, "DURANIUM FOLDER DOWNLOAD.png");
            this.ımageList1.Images.SetKeyName(83, "DURANIUM FOLDER EXCLAMATION.png");
            this.ımageList1.Images.SetKeyName(84, "DURANIUM FOLDER FIREWIRE BLACK.png");
            this.ımageList1.Images.SetKeyName(85, "DURANIUM FOLDER FIREWIRE WHITE.png");
            this.ımageList1.Images.SetKeyName(86, "DURANIUM FOLDER GLASS BLUE.png");
            this.ımageList1.Images.SetKeyName(87, "DURANIUM FOLDER INTERNET 2.png");
            this.ımageList1.Images.SetKeyName(88, "DURANIUM FOLDER INTERNET.png");
            this.ımageList1.Images.SetKeyName(89, "DURANIUM FOLDER LEAF.png");
            this.ımageList1.Images.SetKeyName(90, "DURANIUM FOLDER LIBRARY.png");
            this.ımageList1.Images.SetKeyName(91, "DURANIUM FOLDER MENU ITEMS BLUE.png");
            this.ımageList1.Images.SetKeyName(92, "DURANIUM FOLDER MENU ITEMS GRAPHITE.png");
            this.ımageList1.Images.SetKeyName(93, "DURANIUM FOLDER MOVIES 2.png");
            this.ımageList1.Images.SetKeyName(94, "DURANIUM FOLDER MUSIC BLACK.png");
            this.ımageList1.Images.SetKeyName(95, "DURANIUM FOLDER MUSIC LIME.png");
            this.ımageList1.Images.SetKeyName(96, "DURANIUM FOLDER NEWTON.png");
            this.ımageList1.Images.SetKeyName(97, "DURANIUM FOLDER PICTURES 2.png");
            this.ımageList1.Images.SetKeyName(98, "DURANIUM FOLDER PICTURES.png");
            this.ımageList1.Images.SetKeyName(99, "DURANIUM FOLDER PLAIN.png");
            this.ımageList1.Images.SetKeyName(100, "DURANIUM FOLDER SYSTEM.png");
            this.ımageList1.Images.SetKeyName(101, "DURANIUM FOLDER TENNIS.png");
            this.ımageList1.Images.SetKeyName(102, "DURANIUM FOLDER UTILITIES 2.png");
            this.ımageList1.Images.SetKeyName(103, "DURANIUM ICON_.png");
            this.ımageList1.Images.SetKeyName(104, "DVD - Media.png");
            this.ımageList1.Images.SetKeyName(105, "DVD.png");
            this.ımageList1.Images.SetKeyName(106, "dvd_unmount.png");
            this.ımageList1.Images.SetKeyName(107, "dvd9.png");
            this.ımageList1.Images.SetKeyName(108, "easymoblog.png");
            this.ımageList1.Images.SetKeyName(109, "edit.png");
            this.ımageList1.Images.SetKeyName(110, "edit_add.png");
            this.ımageList1.Images.SetKeyName(111, "edit_remove.png");
            this.ımageList1.Images.SetKeyName(112, "editcopy.png");
            this.ımageList1.Images.SetKeyName(113, "editcut.png");
            this.ımageList1.Images.SetKeyName(114, "editdelete.png");
            this.ımageList1.Images.SetKeyName(115, "editpaste.png");
            this.ımageList1.Images.SetKeyName(116, "eeeee.png");
            this.ımageList1.Images.SetKeyName(117, "Eternal Blue direcciones.png");
            this.ımageList1.Images.SetKeyName(118, "exit.png");
            this.ımageList1.Images.SetKeyName(119, "Floppy Drive 3.png");
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dosya Adi";
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "AQUA ICONS FOLDER (NO WRITE).png");
            this.ımageList2.Images.SetKeyName(1, "AQUA ICONS FOLDER (PRIVATE).png");
            this.ımageList2.Images.SetKeyName(2, "AQUA ICONS FOLDER ADD.png");
            this.ımageList2.Images.SetKeyName(3, "AQUA ICONS FOLDER APPLE.png");
            this.ımageList2.Images.SetKeyName(4, "AQUA ICONS FOLDER APPS.png");
            this.ımageList2.Images.SetKeyName(5, "AQUA ICONS FOLDER CLASSIC.png");
            this.ımageList2.Images.SetKeyName(6, "AQUA ICONS FOLDER CLASSIC_OLD.png");
            this.ımageList2.Images.SetKeyName(7, "AQUA ICONS FOLDER CLOSED.png");
            this.ımageList2.Images.SetKeyName(8, "AQUA ICONS FOLDER DIALUP.png");
            this.ımageList2.Images.SetKeyName(9, "AQUA ICONS FOLDER DOCUMENTS.png");
            this.ımageList2.Images.SetKeyName(10, "AQUA ICONS FOLDER EXPLORER.png");
            this.ımageList2.Images.SetKeyName(11, "AQUA ICONS FOLDER FAVORITES.png");
            this.ımageList2.Images.SetKeyName(12, "AQUA ICONS FOLDER FILE SHARING.png");
            this.ımageList2.Images.SetKeyName(13, "AQUA ICONS FOLDER FONTS.png");
            this.ımageList2.Images.SetKeyName(14, "AQUA ICONS FOLDER INTERNATIONAL.png");
            this.ımageList2.Images.SetKeyName(15, "AQUA ICONS FOLDER INTERNET.png");
            this.ımageList2.Images.SetKeyName(16, "AQUA ICONS FOLDER LIBRARY.png");
            this.ımageList2.Images.SetKeyName(17, "AQUA ICONS FOLDER MOVIES.png");
            this.ımageList2.Images.SetKeyName(18, "AQUA ICONS FOLDER MUSIC.png");
            this.ımageList2.Images.SetKeyName(19, "AQUA ICONS FOLDER OPENED.png");
            this.ımageList2.Images.SetKeyName(20, "AQUA ICONS FOLDER OSX.png");
            this.ımageList2.Images.SetKeyName(21, "AQUA ICONS FOLDER PICTURES.png");
            this.ımageList2.Images.SetKeyName(22, "AQUA ICONS FOLDER PREFERENCES.png");
            this.ımageList2.Images.SetKeyName(23, "AQUA ICONS FOLDER PRINTERS.png");
            this.ımageList2.Images.SetKeyName(24, "AQUA ICONS FOLDER SCHEDULED TASKS.png");
            this.ımageList2.Images.SetKeyName(25, "AQUA ICONS FOLDER SHARING.png");
            this.ımageList2.Images.SetKeyName(26, "AQUA ICONS FOLDER SHUTDOWNITEMS.png");
            this.ımageList2.Images.SetKeyName(27, "AQUA ICONS FOLDER SONGS.png");
            this.ımageList2.Images.SetKeyName(28, "AQUA ICONS FOLDER STARTUP ITEMS.png");
            this.ımageList2.Images.SetKeyName(29, "AQUA ICONS FOLDER STARTUP-SHUTDOWN IT.png");
            this.ımageList2.Images.SetKeyName(30, "AQUA ICONS FOLDER SYSTEM.png");
            this.ımageList2.Images.SetKeyName(31, "AQUA ICONS FOLDER USER GROUPS.png");
            this.ımageList2.Images.SetKeyName(32, "AQUA ICONS FOLDER UTILITIES.png");
            this.ımageList2.Images.SetKeyName(33, "AQUA ICONS FOLDER WEB DOWNLOADS.png");
            this.ımageList2.Images.SetKeyName(34, "AQUA ICONS MSN MESSENGER X.png");
            this.ımageList2.Images.SetKeyName(35, "BACKUP FOLDER.png");
            this.ımageList2.Images.SetKeyName(36, "BLUE.png");
            this.ımageList2.Images.SetKeyName(37, "clanbomber.png");
            this.ımageList2.Images.SetKeyName(38, "CLASSIC.png");
            this.ımageList2.Images.SetKeyName(39, "clean.png");
            this.ımageList2.Images.SetKeyName(40, "CRISTAL CRYSTAL FOLDER.png");
            this.ımageList2.Images.SetKeyName(41, "CRISTAL GRAPHITE FOLDER.png");
            this.ımageList2.Images.SetKeyName(42, "CRISTAL LIME FOLDER.png");
            this.ımageList2.Images.SetKeyName(43, "CRISTAL MIDI.png");
            this.ımageList2.Images.SetKeyName(44, "CRISTAL MUSIC FOLDER.png");
            this.ımageList2.Images.SetKeyName(45, "CRISTAL RUBY FOLDER.png");
            this.ımageList2.Images.SetKeyName(46, "CRISTAL STRAWBERRY FOLDER.png");
            this.ımageList2.Images.SetKeyName(47, "CRISTAL TANGERINE FOLDER.png");
            this.ımageList2.Images.SetKeyName(48, "Document and Big Bug.png");
            this.ımageList2.Images.SetKeyName(49, "Document and Bug.png");
            this.ımageList2.Images.SetKeyName(50, "Document, Bug and Photo.png");
            this.ımageList2.Images.SetKeyName(51, "Documents.png");
            this.ımageList2.Images.SetKeyName(52, "Dossier-vierge.png");
            this.ımageList2.Images.SetKeyName(53, "down.png");
            this.ımageList2.Images.SetKeyName(54, "Download.png");
            this.ımageList2.Images.SetKeyName(55, "dreamweaver.png");
            this.ımageList2.Images.SetKeyName(56, "DUOTANG ESSENTIALS ICON PP02.png");
            this.ımageList2.Images.SetKeyName(57, "DUOTANG ESSENTIALS ICON PP03.png");
            this.ımageList2.Images.SetKeyName(58, "DUOTANG ESSENTIALS ICON PP05.png");
            this.ımageList2.Images.SetKeyName(59, "DUOTANG ESSENTIALS ICON PP07.png");
            this.ımageList2.Images.SetKeyName(60, "DUOTANG ESSENTIALS ICON PP08.png");
            this.ımageList2.Images.SetKeyName(61, "DUOTANG ESSENTIALS ICON PP09.png");
            this.ımageList2.Images.SetKeyName(62, "DUOTANG ESSENTIALS ICON PP10.png");
            this.ımageList2.Images.SetKeyName(63, "DUOTANG ESSENTIALS ICON PP11.png");
            this.ımageList2.Images.SetKeyName(64, "DUOTANG ESSENTIALS ICON PP12.png");
            this.ımageList2.Images.SetKeyName(65, "DUOTANG ESSENTIALS ICON PP13.png");
            this.ımageList2.Images.SetKeyName(66, "DUOTANG ESSENTIALS ICON PP14.png");
            this.ımageList2.Images.SetKeyName(67, "DUOTANG ESSENTIALS ICON PP15.png");
            this.ımageList2.Images.SetKeyName(68, "DUOTANG ESSENTIALS ICON PP16.png");
            this.ımageList2.Images.SetKeyName(69, "DUOTANG ESSENTIALS ICON PP17.png");
            this.ımageList2.Images.SetKeyName(70, "DUOTANG ESSENTIALS ICON PP18.png");
            this.ımageList2.Images.SetKeyName(71, "DUOTANG ESSENTIALS ICON PP19.png");
            this.ımageList2.Images.SetKeyName(72, "DUOTANG ESSENTIALS ICON PP20.png");
            this.ımageList2.Images.SetKeyName(73, "DURANIUM FOLDER APPLE BLACK.png");
            this.ımageList2.Images.SetKeyName(74, "DURANIUM FOLDER APPLE RED.png");
            this.ımageList2.Images.SetKeyName(75, "DURANIUM FOLDER APPLE WHITE.png");
            this.ımageList2.Images.SetKeyName(76, "DURANIUM FOLDER APPLICATIONS 2.png");
            this.ımageList2.Images.SetKeyName(77, "DURANIUM FOLDER APPLICATIONS.png");
            this.ımageList2.Images.SetKeyName(78, "DURANIUM FOLDER CD-DVD.png");
            this.ımageList2.Images.SetKeyName(79, "DURANIUM FOLDER CLASSIC SYSTEM.png");
            this.ımageList2.Images.SetKeyName(80, "DURANIUM FOLDER DOCUMENTS.png");
            this.ımageList2.Images.SetKeyName(81, "DURANIUM FOLDER DOWNLOAD BLUE.png");
            this.ımageList2.Images.SetKeyName(82, "DURANIUM FOLDER DOWNLOAD.png");
            this.ımageList2.Images.SetKeyName(83, "DURANIUM FOLDER EXCLAMATION.png");
            this.ımageList2.Images.SetKeyName(84, "DURANIUM FOLDER FIREWIRE BLACK.png");
            this.ımageList2.Images.SetKeyName(85, "DURANIUM FOLDER FIREWIRE WHITE.png");
            this.ımageList2.Images.SetKeyName(86, "DURANIUM FOLDER GLASS BLUE.png");
            this.ımageList2.Images.SetKeyName(87, "DURANIUM FOLDER INTERNET 2.png");
            this.ımageList2.Images.SetKeyName(88, "DURANIUM FOLDER INTERNET.png");
            this.ımageList2.Images.SetKeyName(89, "DURANIUM FOLDER LEAF.png");
            this.ımageList2.Images.SetKeyName(90, "DURANIUM FOLDER LIBRARY.png");
            this.ımageList2.Images.SetKeyName(91, "DURANIUM FOLDER MENU ITEMS BLUE.png");
            this.ımageList2.Images.SetKeyName(92, "DURANIUM FOLDER MENU ITEMS GRAPHITE.png");
            this.ımageList2.Images.SetKeyName(93, "DURANIUM FOLDER MOVIES 2.png");
            this.ımageList2.Images.SetKeyName(94, "DURANIUM FOLDER MUSIC BLACK.png");
            this.ımageList2.Images.SetKeyName(95, "DURANIUM FOLDER MUSIC LIME.png");
            this.ımageList2.Images.SetKeyName(96, "DURANIUM FOLDER NEWTON.png");
            this.ımageList2.Images.SetKeyName(97, "DURANIUM FOLDER PICTURES 2.png");
            this.ımageList2.Images.SetKeyName(98, "DURANIUM FOLDER PICTURES.png");
            this.ımageList2.Images.SetKeyName(99, "DURANIUM FOLDER PLAIN.png");
            this.ımageList2.Images.SetKeyName(100, "DURANIUM FOLDER SYSTEM.png");
            this.ımageList2.Images.SetKeyName(101, "DURANIUM FOLDER TENNIS.png");
            this.ımageList2.Images.SetKeyName(102, "DURANIUM FOLDER UTILITIES 2.png");
            this.ımageList2.Images.SetKeyName(103, "DURANIUM ICON_.png");
            this.ımageList2.Images.SetKeyName(104, "DVD - Media.png");
            this.ımageList2.Images.SetKeyName(105, "DVD.png");
            this.ımageList2.Images.SetKeyName(106, "dvd_unmount.png");
            this.ımageList2.Images.SetKeyName(107, "dvd9.png");
            this.ımageList2.Images.SetKeyName(108, "easymoblog.png");
            this.ımageList2.Images.SetKeyName(109, "edit.png");
            this.ımageList2.Images.SetKeyName(110, "edit_add.png");
            this.ımageList2.Images.SetKeyName(111, "edit_remove.png");
            this.ımageList2.Images.SetKeyName(112, "editcopy.png");
            this.ımageList2.Images.SetKeyName(113, "editcut.png");
            this.ımageList2.Images.SetKeyName(114, "editdelete.png");
            this.ımageList2.Images.SetKeyName(115, "editpaste.png");
            this.ımageList2.Images.SetKeyName(116, "eeeee.png");
            this.ımageList2.Images.SetKeyName(117, "Eternal Blue direcciones.png");
            this.ımageList2.Images.SetKeyName(118, "exit.png");
            this.ımageList2.Images.SetKeyName(119, "Floppy Drive 3.png");
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 430);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detayliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kucukSimgelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyukSimgelerToolStripMenuItem;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

