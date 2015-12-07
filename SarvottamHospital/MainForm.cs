using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SarvottamHospital.Object;
using SarvottamHospital.Controls;

namespace SarvottamHospital
{
    public partial class MainForm : Form
    {
        //private int resize = 0;

        public MainForm()
        {
            InitializeComponent();
            this.Icon = Common.ApplicationIcon;
            this.Font = Common.ApplicationFont;
            this.lblTitle.Font = Common.ApplicationTitleFont;
            this.lblTitle.ForeColor = Common.LightTextColor;

            this.nicApp.Icon = Common.ApplicationIcon;
            this.nicApp.MouseDoubleClick += new MouseEventHandler(OnNotifyyDoubleClick);

            this.FormClosing += new FormClosingEventHandler(OnClosing);

            this.tsmMyProfile.Font = new Font(this.tsmMyProfile.Font, FontStyle.Bold);

            this.cmsEmp.Font = Common.ApplicationFont;
            this.Text = string.Format("{0} Ver.{1}", Application.ProductName, Application.ProductVersion);
            this.lblTitle.Text = string.Format("{0}\r\nVersion {1}", Application.ProductName, Application.ProductVersion);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.MinimumSize = this.Size;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            this.tabMain.Selected += new TabControlEventHandler(this.OnTabSelected);

            this.cmsEntities.Font = Common.ApplicationFont;
            this.picAppLogo.Cursor = Cursors.Hand;
            this.picAppLogo.MouseClick += new MouseEventHandler(this.OnAppIconMouseClick);
            this.cmsEntities.ItemClicked += new ToolStripItemClickedEventHandler(this.OnEntitesMenuClick);

            this.picUserPhoto.Cursor = Cursors.Hand;
            this.picUserPhoto.MouseClick += new MouseEventHandler(this.OnUserPhotoMouseClick);

            this.tsmMyProfile.Click += new EventHandler(this.OnMyProfileClick);
            this.tsmChangePassword.Click += new EventHandler(this.OnChangePasswordClick);
            this.tsmForgotMe.Click += new EventHandler(this.OnForgotMeClick);
            this.tsmLogout.Click += new EventHandler(this.OnLogOutClick);
            this.tsmExit.Click += new EventHandler(delegate(object sender, EventArgs e) { Application.Exit(); });
            this.lsvData.DoubleClick += new EventHandler(this.OnModuleDoubleClick);
            this.lsvData.KeyDown += new KeyEventHandler(this.OnModuleKeyDown);

            //this.lsvBottom.DoubleClick += new EventHandler(OnWorkspacePanelDoubleClick);
            //this.lsvBottom.KeyDown += new KeyEventHandler(OnWorkspacePanelKeyDown);

            //this.taskMail.SetBackgroundBitmap(new Bitmap(Properties.Resources.skin), Color.FromArgb(255, 0, 255));
            //this.taskMail.SetCloseBitmap(new Bitmap(Properties.Resources.popupClose), Color.FromArgb(255, 0, 255), new Point(127, 8));
            //this.taskMail.TitleRectangle = new Rectangle(40, 9, 70, 25);
            //this.taskMail.ContentRectangle = new Rectangle(8, 41, 133, 68);
            //this.taskMail.ContentClickable = true;
            //this.taskMail.ContentClick += new EventHandler(OnMailContentClick);
            //this.taskMail.CloseClick += new EventHandler(OnMailClose);

            //this.taskReminder.SetBackgroundBitmap(Properties.Resources.skin3, Color.FromArgb(255, 0, 255));
            //this.taskReminder.SetCloseBitmap(Properties.Resources.popupClose, Color.FromArgb(255, 0, 255), new Point(280, 57));
            //this.taskReminder.TitleRectangle = new Rectangle(150, 57, 125, 28);
            //this.taskReminder.ContentRectangle = new Rectangle(75, 92, 215, 55);
            //this.taskReminder.ContentClick += new EventHandler(OnReminderContentClick);
            //this.taskReminder.CloseClick += new EventHandler(OnReminderClose);
            //this.taskReminder.TitleClick += new EventHandler(OnReminderClose);
            //this.taskReminder.CloseClickable = true;
            //this.taskReminder.TitleClickable = true;

            //this.tmMail.Enabled = true;
            //this.tmReminder.Enabled = true;
        }
        private void OnClickSplitter(object sender, EventArgs e)
        {
            //if (this.scMainSplitter.SplitterDistance > 170)
            //{
            //    resize = this.scMainSplitter.SplitterDistance;
            //    this.scMainSplitter.SplitterDistance = 170;
            //}
            //else
            //    this.scMainSplitter.SplitterDistance = resize;
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    e.Cancel = true;
            //    this.Hide();
            //}
        }

        private void OnNotifyyDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void OnAppIconMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right && AppContext.IsUserLoggedIn)
            {
                this.cmsEntities.Show(this.picAppLogo, new Point(0, this.picUserPhoto.Height), ToolStripDropDownDirection.BelowRight);
            }
        }

        private void OnUserPhotoMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right /*&& AppContext.IsUserLoggedIn*/)
            {
                this.cmsEmp.Show(this.picUserPhoto, new Point(this.picUserPhoto.Width, this.picUserPhoto.Height), ToolStripDropDownDirection.BelowLeft);
            }
        }

        private void RemoveEmp()
        {
            if (AppContext.IsMainUser)
            {
                this.cmsEmp.Items.Remove(this.tsmMyProfile);
                this.cmsEmp.Items.Remove(this.tsmChangePassword);
            }
            else
            {
                this.cmsEmp.Items.Clear();
                this.cmsEmp.Items.Add(this.tsmMyProfile);
                this.cmsEmp.Items.Add(this.tsmChangePassword);
                this.cmsEmp.Items.Add(this.tsmForgotMe);
                this.cmsEmp.Items.Add(this.tsmLogout);
                this.cmsEmp.Items.Add(this.tsmExit);
            }
        }

        private void OnMyProfileClick(object sender, EventArgs e)
        {
            if (UserForm.ShowForm(AppContext.LoggedUser))
                this.RefreshUserData();
        }

        private void OnChangePasswordClick(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            using (ChangePasswordForm form = new ChangePasswordForm(AppContext.LoggedUser))
            {
                form.ShowDialog();
            }
        }

        private void OnLogOutClick(object sender, EventArgs e)
        {
            //this.scMainSplitter.Panel2Collapsed = true;
            //this.OnReminderClose(sender, null);
            //this.OnMailClose(sender, null);
            this.lsvData.Items.Clear();
            //this.lsvBottom.Items.Clear();
            foreach (TabPage tp in this.tabMain.TabPages)
            {
                if (tp is EntityTabPage)
                {
                    this.tabMain.TabPages.Remove(tp);
                    tp.Dispose();
                }
            }

            AppContext.Logout();
            this.RefreshUserData();
            if (!AppContext.IsUserLoggedIn)
            {
                this.OnShown(EventArgs.Empty);
            }
        }

        private void OnForgotMeClick(object sender, EventArgs e)
        {
            AppContext.ForgotMe();
        }

        private void OnTabSelected(object sender, TabControlEventArgs e)
        {
            if (null != e)
            {
                EntityTabPage tab = e.TabPage as EntityTabPage;
                if (null != tab)
                    tab.RefreshData();
            }
        }

        private bool isFirstTime = true;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (!AppContext.IsUserLoggedIn)
            {
                if (!LoginForm.ShowForm())
                    Application.Exit();
                else
                {
                    if (string.IsNullOrEmpty(AppContext.LoggedUser.Password))
                        ChangePasswordForm.ShowForm();

                    this.RefreshUserData();
                    this.LoadEntities(null);
                    //this.scMainSplitter.Panel2Collapsed = false;
                    //this.LoadWorkspace();
                    this.nicApp.Visible = true;
                }
                if (AppContext.IsMainUser)
                {
                    this.LoadEntities(null);
                }
            }
            else if (isFirstTime)
            {
                this.RefreshUserData();
                this.LoadEntities(null);
                //this.scMainSplitter.Panel2Collapsed = false;
                // this.LoadWorkspace();
                this.nicApp.Visible = true;
            }
            isFirstTime = false;
        }

        private void OnModuleKeyDown(object sender, KeyEventArgs e)
        {
            if (e != null && e.KeyCode == Keys.Enter)
            {
                this.OnModuleDoubleClick(this.lsvData, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }

        private void OnModuleDoubleClick(object sender, EventArgs e)
        {
            if (this.lsvData.SelectedItems != null && this.lsvData.SelectedItems.Count > 0)
            {
                ShowEntityTab(this.lsvData.SelectedItems[0].Tag as Entity);
            }
        }

        public void LoadEntities(Entity selected)
        {
            this.RemoveEmp();
            this.lsvData.Items.Clear();
            this.lsvData.Groups.Clear();
            this.cmsEntities.Items.Clear();

            EntityCollection list = null;

            if (AppContext.IsAdministrator || AppContext.IsMainUser)
                list = new EntityCollection();
            else
                list = new EntityCollection(AppContext.UserRoleGuid);

            if (list == null)
                return;

            ListViewItem selectedItem = null;
            int count = 0;
            for (int i = 0, j = list.Count; i < j; i++)
            {
                Entity obj = list[i];
                if (!Objectbase.IsNullOrEmpty(obj) && (AppContext.IsMainUser || (string.Compare(obj.Name, "Entities") != 0)))
                {
                    if (obj.IsViewable)
                    {
                        count++;
                        string itemKey = obj.ObjectGuid.ToString();
                        string imageKey = "default";
                        if (obj.IconSmall != null && obj.IconLarge != null && obj.IconLarge.Length > 0 && obj.IconSmall.Length > 0)
                        {
                            imageKey = itemKey;
                            if (!imlSmall.Images.ContainsKey(itemKey))
                                imlSmall.Images.Add(imageKey, Common.ImageFromBytes(obj.IconSmall));

                            if (!imlLarge.Images.ContainsKey(itemKey))
                                imlLarge.Images.Add(imageKey, Common.ImageFromBytes(obj.IconLarge));
                        }

                        ToolStripMenuItem menu = new ToolStripMenuItem(obj.Name, imlSmall.Images[imageKey]);
                        menu.Tag = obj;
                        menu.ToolTipText = obj.Description;
                        this.cmsEntities.Items.Add(menu);

                        ListViewItem item = this.lsvData.Items.Add(itemKey, obj.Name, imageKey);

                        if (null != item)
                        {
                            item.Tag = obj;
                            item.SubItems.Add(obj.Description);
                            item.ToolTipText = (string.IsNullOrEmpty(obj.Description) ? obj.Name : obj.Description);

                            string groupName = obj.GroupName;
                            ListViewGroup itemGroup = null;
                            if (!string.IsNullOrEmpty(groupName))
                            {
                                string groupKey = groupName;
                                itemGroup = this.lsvData.Groups[groupKey];
                                if (itemGroup == null)
                                {
                                    itemGroup = new ListViewGroup(groupKey, groupName);
                                    this.lsvData.Groups.Add(itemGroup);
                                }

                                if (itemGroup != null)
                                    item.Group = itemGroup;
                            }

                            if (obj.Equals(selected))
                                selectedItem = item;
                        }
                    }
                }
            }

            if (null == selectedItem && this.lsvData.Items.Count > 0)
                selectedItem = this.lsvData.Items[0];

            if (null != selectedItem)
                selectedItem.Selected = true;

        }

        private void RefreshUserData()
        {
            User obj = AppContext.LoggedUser;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                obj.RefershData();
                this.picUserPhoto.Image = (null == AppContext.UserPhoto ? Common.ResizeBitmap(Properties.Resources.NoPhoto, 40, 40) : Common.ResizeBitmap(Common.ImageFromBytes(AppContext.UserPhoto), 40, 40));
                this.tsmMyProfile.Text = obj.Name + "'s &Profile";
            }
            else
            {
                this.picUserPhoto.Image = null;
                this.tsmMyProfile.Text = "My Profile";
            }
        }

        private void OnDataKeyDown(object sender, KeyEventArgs e)
        {
            if (e != null && e.KeyCode == Keys.Enter)
            {
                this.OnDataItemDoubleClick(this.lsvData, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }

        private void OnDataItemDoubleClick(object sender, EventArgs e)
        {
            if (this.lsvData.SelectedItems != null && this.lsvData.SelectedItems.Count > 0)
                this.ShowEntityTab(this.lsvData.SelectedItems[0].Tag as Entity);
        }

        private void ShowEntityTab(Entity entity)
        {
            if (!Objectbase.IsNullOrEmpty(entity))
            {
                Type listType = Type.GetType(entity.ListTypeName, false);
                if (listType != null && listType.IsSubclassOf(typeof(ObjectListControl)))
                {
                    string entityKey = entity.ObjectGuid.ToString();
                    EntityTabPage entityPage = null;
                    if (this.tabMain.TabPages.ContainsKey(entityKey))
                    {
                        entityPage = this.tabMain.TabPages[entityKey] as EntityTabPage;
                    }
                    else
                    {
                        try
                        {
                            ObjectListControl listControl = Activator.CreateInstance(listType) as ObjectListControl;
                            if (listControl != null)
                            {
                                entityPage = new EntityTabPage(listControl, entity.ListCaption);
                                entityPage.Name = entityKey;
                                this.tabMain.TabPages.Add(entityPage);
                                entityPage.Text = entity.ListCaption;
                            }
                        }
                        catch (Exception) { }
                    }

                    if (null != entityPage)
                        this.tabMain.SelectedTab = entityPage;
                }

            }
        }

        private void OnEntitesMenuClick(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripMenuItem menu = e.ClickedItem as ToolStripMenuItem;

            if (menu != null)
            {
                ShowEntityTab(menu.Tag as Entity);
            }
        }

        //#region Workspace

        //private void OnRefresh(object sender, EventArgs e)
        //{
        //    this.LoadWorkspace();
        //}

        //private void OnWorkspacePanelKeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e != null && e.KeyCode == Keys.Enter)
        //    {
        //        this.OnWorkspacePanelDoubleClick(this.lsvBottom, EventArgs.Empty);
        //        e.SuppressKeyPress = true;
        //    }
        //}

        //private void OnWorkspacePanelDoubleClick(object sender, EventArgs e)
        //{
        //    if (this.lsvBottom.SelectedItems != null && this.lsvBottom.SelectedItems.Count > 0)
        //    {
        //        WorkspaceItems obj = this.lsvBottom.SelectedItems[0].Tag as WorkspaceItems;
        //        if (obj != null)
        //        {
        //            if (obj.Type == WorkItemType.Mail)
        //            {
        //                Mail mail = new Mail(obj.Key);
        //                if (!Objectbase.IsNullOrEmpty(mail))
        //                {
        //                    MailForm.ShowForm(mail);
        //                    if (!mail.IsRead)
        //                        mail.MailReadUnreadUpdate(true);
        //                }
        //            }
        //            else if (obj.Type == WorkItemType.Task)
        //            {
        //                Task task = new Task(obj.Key);
        //                if (!Objectbase.IsNullOrEmpty(task))
        //                    TaskForm.ShowForm(task);
        //            }
        //            else if (obj.Type == WorkItemType.Reminder)
        //            {
        //                Reminder reminder = new Reminder(obj.Key);
        //                if (!Objectbase.IsNullOrEmpty(reminder))
        //                    ReminderForm.ShowForm(reminder);
        //            }
        //        }
        //    }
        //}

        //public void LoadWorkspace()
        //{
        //    this.LoadImagesToImageList();
        //    this.lblWorkSpace.Text = AppContext.Fullname + "'s Workspace";
        //    this.lblWorkSpace.Font = Common.ApplicationTitleFont;
        //    this.lsvBottom.Groups.Clear();
        //    if (AppContext.IsUserLoggedIn)
        //    {
        //        this.lsvBottom.SmallImageList = this.imMailSmall;
        //        ListViewGroup mailGroup = new ListViewGroup("Mails", "My Current Mails");
        //        ListViewGroup taskGroup = new ListViewGroup("Tasks", "My Current Tasks");
        //        ListViewGroup reminderGroup = new ListViewGroup("Remiders", "My Current Remiders");
        //        //List<WorkspaceItems> items = WorkspaceItems.LoadList(AppContext.UserGuid);
        //        //foreach (WorkspaceItems item in items)
        //        //{
        //        //    if (item.Type == WorkItemType.Mail)
        //        //        this.LoadData(mailGroup, item);
        //        //    else if (item.Type == WorkItemType.Task)
        //        //        this.LoadData(taskGroup, item);
        //        //    else if (item.Type == WorkItemType.Reminder)
        //        //        this.LoadData(reminderGroup, item);
        //        //}
        //    }
        //}

        //private void LoadImagesToImageList()
        //{
        //    imMailSmall.Images.Clear();
        //    string readedMailKey = "Unread_Mail";
        //    string unreadMailKey = "Readed_Mail";
        //    string mainTaskKey = "MainTask";
        //    string childTaskKey = "ChildTask";
        //    string reminderKey = "Reminder";
        //    imMailSmall.Images.Add(unreadMailKey, Properties.Resources.unread_mail);
        //    imMailSmall.Images.Add(readedMailKey, Properties.Resources.readed_mail);
        //    imMailSmall.Images.Add(mainTaskKey, Properties.Resources.maintask);
        //    imMailSmall.Images.Add(childTaskKey, Properties.Resources.childtask);
        //    imMailSmall.Images.Add(reminderKey, Properties.Resources.reminder);

        //}

        ////public void LoadData(ListViewGroup group, WorkspaceItems obj)
        ////{
        ////    //if (group != null && obj != null)
        ////    //{
        ////    //    string imageKey = string.Empty;
        ////    //    imageKey = this.GetImageKey(obj.Type, obj.Notification);
        ////    //    ListViewItem item = new ListViewItem(obj.From, imageKey);
        ////    //    item.Tag = obj;
        ////    //    item.SubItems.Add(obj.Title);
        ////    //    item.SubItems.Add(obj.Date.ToString(Common.DATE_FORMAT));
        ////    //    item.Group = group;
        ////    //    this.lsvBottom.Items.Add(item);
        ////    //    this.lsvBottom.Groups.Add(group);
        ////    //}
        ////}

        //public string GetImageKey(WorkItemType type, bool notification)
        //{
        //    string imageKey = string.Empty;

        //    switch (type)
        //    {
        //        case WorkItemType.Mail:
        //            if (notification)
        //                imageKey = "Unread_Mail";
        //            else
        //                imageKey = "Readed_Mail";

        //            break;
        //        case WorkItemType.Task:
        //            if (!notification)
        //                imageKey = "MainTask";
        //            else
        //                imageKey = "ChildTask";
        //            break;
        //        case WorkItemType.Reminder:
        //            imageKey = "Reminder";
        //            break;
        //        default:
        //            break;
        //    }
        //    return imageKey;
        //}

        //#endregion

        //#region Notification

        //private void tmrReminder_Tick(object sender, EventArgs e)
        //{
        //    if (AppContext.IsUserLoggedIn)
        //    {
        //        //Reminder obj = Reminder.GetCurrentReminder(AppContext.UserGuid);
        //        //if (!Objectbase.IsNullOrEmpty(obj))
        //        //{
        //        //    this.SetReminderNotification(obj);
        //        //}
        //    }
        //}

        //private void tmMail_Tick(object sender, EventArgs e)
        //{
        //    if (AppContext.IsUserLoggedIn)
        //    {
        //        //Mail obj = Mail.GetCurrentMail(AppContext.UserGuid);
        //        //if (!Objectbase.IsNullOrEmpty(obj))
        //        //{
        //        //    this.SetMailNotification(obj);
        //        //}
        //    }
        //}

        ////private void SetMailNotification(Mail obj)
        ////{
        ////    //obj.MailNotificationUpdate();
        ////    //taskMail.Tag = obj;
        ////    //this.tmMail.Stop();
        ////    //this.taskMail.Show("New Mail", "From " + obj.CreatedBy + Environment.NewLine + "Subject " + obj.Subject, 600);

        ////}

        ////private void SetReminderNotification(Reminder obj)
        ////{

        ////    obj.ReminderFiredOnUpdate();
        ////    taskReminder.Tag = obj;
        ////    this.tmReminder.Stop();
        ////    taskReminder.Show("Remind Me Later", "Reminder From :" + obj.CreatedBy + Environment.NewLine + obj.Name, 300);

        ////}

        //private void OnMailContentClick(object sender, EventArgs e)
        //{
        //    //taskMail.Close();
        //    //Mail mail = taskMail.Tag as Mail;
        //    //if (!Objectbase.IsNullOrEmpty(mail))
        //    //{
        //    //    MailForm.ShowForm(mail);
        //    //    mail.MailReadUnreadUpdate(true);
        //    //}
        //}

        //private void OnMailClose(object sender, EventArgs e)
        //{
        //    //this.tmMail.Start();
        //    //this.taskMail.Hide();
        //}

        //private void OnReminderContentClick(object sender, EventArgs e)
        //{
        //    //TaskbarNotifier taskReminder = sender as TaskbarNotifier;
        //    //Reminder obj = (sender as Control).Tag as Reminder;
        //    //if (!Objectbase.IsNullOrEmpty(obj))
        //    //{
        //    //    if (ReminderForm.ShowForm(obj, true))
        //    //    {
        //    //        if (this.tabMain.SelectedTab.Text == "Reminders")
        //    //        {
        //    //            EntityTabPage tab = this.tabMain.SelectedTab as EntityTabPage;
        //    //            if (tab != null)
        //    //                tab.RefreshData();
        //    //        }
        //    //    }
        //    //}
        //    //this.tmReminder.Start();
        //    //this.taskReminder.Hide();
        //}

        //private void OnReminderClose(object sender, EventArgs e)
        //{
        //    //this.tmReminder.Start();
        //    //this.taskReminder.Hide();
        //}

        //#endregion

    }
}
