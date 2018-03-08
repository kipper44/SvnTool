namespace SvnTool
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("11");
            this.lstGroup = new System.Windows.Forms.ListBox();
            this.GroupDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removegroupd = new System.Windows.Forms.ToolStripMenuItem();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.UserRemove = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.remove = new System.Windows.Forms.ToolStripMenuItem();
            this.lstGroupUsers = new System.Windows.Forms.ListBox();
            this.GroupUserRemove = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupremove = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.btnGroupAdd = new System.Windows.Forms.Button();
            this.lstAuth = new System.Windows.Forms.ListBox();
            this.AuthRemove = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeauthv = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGroupAuthAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstviewAuth = new System.Windows.Forms.ListView();
            this.그룹 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.권한 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemoveMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RemoveAuth = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAuthDirAdd = new System.Windows.Forms.Button();
            this.txtAuthDir = new System.Windows.Forms.TextBox();
            this.txtAuthGroupAuth = new System.Windows.Forms.TextBox();
            this.txtAuthGroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSvnGroupAdd = new System.Windows.Forms.Button();
            this.txtSvnGroupAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBoxServer = new System.Windows.Forms.ComboBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GroupDelete.SuspendLayout();
            this.UserRemove.SuspendLayout();
            this.GroupUserRemove.SuspendLayout();
            this.AuthRemove.SuspendLayout();
            this.RemoveMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstGroup
            // 
            this.lstGroup.ContextMenuStrip = this.GroupDelete;
            this.lstGroup.FormattingEnabled = true;
            this.lstGroup.HorizontalScrollbar = true;
            this.lstGroup.ItemHeight = 12;
            this.lstGroup.Location = new System.Drawing.Point(31, 62);
            this.lstGroup.Name = "lstGroup";
            this.lstGroup.Size = new System.Drawing.Size(157, 160);
            this.lstGroup.TabIndex = 0;
            this.lstGroup.SelectedIndexChanged += new System.EventHandler(this.lstGroup_SelectedIndexChanged);
            // 
            // GroupDelete
            // 
            this.GroupDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removegroupd});
            this.GroupDelete.Name = "contextMenuStrip1";
            this.GroupDelete.Size = new System.Drawing.Size(99, 26);
            this.GroupDelete.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.GroupDelete_ItemClicked);
            // 
            // removegroupd
            // 
            this.removegroupd.Name = "removegroupd";
            this.removegroupd.Size = new System.Drawing.Size(98, 22);
            this.removegroupd.Text = "삭제";
            // 
            // lstUsers
            // 
            this.lstUsers.ContextMenuStrip = this.UserRemove;
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 12;
            this.lstUsers.Location = new System.Drawing.Point(529, 62);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(175, 424);
            this.lstUsers.TabIndex = 1;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // UserRemove
            // 
            this.UserRemove.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remove});
            this.UserRemove.Name = "UserRemove";
            this.UserRemove.Size = new System.Drawing.Size(99, 26);
            this.UserRemove.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.UserRemove_ItemClicked);
            // 
            // remove
            // 
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(98, 22);
            this.remove.Text = "삭제";
            // 
            // lstGroupUsers
            // 
            this.lstGroupUsers.ContextMenuStrip = this.GroupUserRemove;
            this.lstGroupUsers.FormattingEnabled = true;
            this.lstGroupUsers.ItemHeight = 12;
            this.lstGroupUsers.Location = new System.Drawing.Point(205, 62);
            this.lstGroupUsers.Name = "lstGroupUsers";
            this.lstGroupUsers.Size = new System.Drawing.Size(157, 172);
            this.lstGroupUsers.TabIndex = 2;
            // 
            // GroupUserRemove
            // 
            this.GroupUserRemove.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupremove});
            this.GroupUserRemove.Name = "GroupUserRemove";
            this.GroupUserRemove.Size = new System.Drawing.Size(99, 26);
            this.GroupUserRemove.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.GroupUserRemove_ItemClicked);
            // 
            // groupremove
            // 
            this.groupremove.Name = "groupremove";
            this.groupremove.Size = new System.Drawing.Size(98, 22);
            this.groupremove.Text = "삭제";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(710, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "사용자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(710, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "비빌번호";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(772, 80);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 21);
            this.txtUser.TabIndex = 5;
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(772, 116);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(100, 21);
            this.txtPasswd.TabIndex = 6;
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Location = new System.Drawing.Point(787, 176);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(75, 23);
            this.btnUserAdd.TabIndex = 7;
            this.btnUserAdd.Text = "유저 저장";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // btnGroupAdd
            // 
            this.btnGroupAdd.Location = new System.Drawing.Point(368, 119);
            this.btnGroupAdd.Name = "btnGroupAdd";
            this.btnGroupAdd.Size = new System.Drawing.Size(155, 23);
            this.btnGroupAdd.TabIndex = 8;
            this.btnGroupAdd.Text = "<<(유저그룹에추가)";
            this.btnGroupAdd.UseVisualStyleBackColor = true;
            this.btnGroupAdd.Click += new System.EventHandler(this.btnGroupAdd_Click);
            // 
            // lstAuth
            // 
            this.lstAuth.ContextMenuStrip = this.AuthRemove;
            this.lstAuth.FormattingEnabled = true;
            this.lstAuth.HorizontalScrollbar = true;
            this.lstAuth.ItemHeight = 12;
            this.lstAuth.Location = new System.Drawing.Point(31, 290);
            this.lstAuth.Name = "lstAuth";
            this.lstAuth.Size = new System.Drawing.Size(157, 196);
            this.lstAuth.TabIndex = 11;
            this.lstAuth.SelectedIndexChanged += new System.EventHandler(this.lstAuth_SelectedIndexChanged);
            // 
            // AuthRemove
            // 
            this.AuthRemove.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeauthv});
            this.AuthRemove.Name = "AuthRemove";
            this.AuthRemove.Size = new System.Drawing.Size(99, 26);
            this.AuthRemove.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.AuthRemove_ItemClicked);
            // 
            // removeauthv
            // 
            this.removeauthv.Name = "removeauthv";
            this.removeauthv.Size = new System.Drawing.Size(98, 22);
            this.removeauthv.Text = "삭제";
            // 
            // btnGroupAuthAdd
            // 
            this.btnGroupAuthAdd.Location = new System.Drawing.Point(334, 564);
            this.btnGroupAuthAdd.Name = "btnGroupAuthAdd";
            this.btnGroupAuthAdd.Size = new System.Drawing.Size(114, 36);
            this.btnGroupAuthAdd.TabIndex = 12;
            this.btnGroupAuthAdd.Text = "그룹권한 추가";
            this.btnGroupAuthAdd.UseVisualStyleBackColor = true;
            this.btnGroupAuthAdd.Click += new System.EventHandler(this.btnGroupAuthDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(689, 508);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstviewAuth
            // 
            this.lstviewAuth.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.그룹,
            this.권한});
            this.lstviewAuth.ContextMenuStrip = this.RemoveMenu;
            this.lstviewAuth.FullRowSelect = true;
            this.lstviewAuth.GridLines = true;
            this.lstviewAuth.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstviewAuth.Location = new System.Drawing.Point(205, 290);
            this.lstviewAuth.Name = "lstviewAuth";
            this.lstviewAuth.Size = new System.Drawing.Size(243, 196);
            this.lstviewAuth.TabIndex = 14;
            this.lstviewAuth.UseCompatibleStateImageBehavior = false;
            this.lstviewAuth.View = System.Windows.Forms.View.Details;
            // 
            // 그룹
            // 
            this.그룹.Text = "그룹";
            this.그룹.Width = 102;
            // 
            // 권한
            // 
            this.권한.Text = "권한";
            this.권한.Width = 193;
            // 
            // RemoveMenu
            // 
            this.RemoveMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveAuth});
            this.RemoveMenu.Name = "RemoveMenu";
            this.RemoveMenu.Size = new System.Drawing.Size(99, 26);
            this.RemoveMenu.Text = "sdfasdfasdf";
            this.RemoveMenu.Click += new System.EventHandler(this.RemoveMenu_Click);
            // 
            // RemoveAuth
            // 
            this.RemoveAuth.Name = "RemoveAuth";
            this.RemoveAuth.Size = new System.Drawing.Size(98, 22);
            this.RemoveAuth.Text = "삭제";
            // 
            // btnAuthDirAdd
            // 
            this.btnAuthDirAdd.Location = new System.Drawing.Point(31, 536);
            this.btnAuthDirAdd.Name = "btnAuthDirAdd";
            this.btnAuthDirAdd.Size = new System.Drawing.Size(157, 23);
            this.btnAuthDirAdd.TabIndex = 19;
            this.btnAuthDirAdd.Text = "디렉토리추가";
            this.btnAuthDirAdd.UseVisualStyleBackColor = true;
            this.btnAuthDirAdd.Click += new System.EventHandler(this.btnAuthDirAdd_Click);
            // 
            // txtAuthDir
            // 
            this.txtAuthDir.Location = new System.Drawing.Point(31, 508);
            this.txtAuthDir.Name = "txtAuthDir";
            this.txtAuthDir.Size = new System.Drawing.Size(157, 21);
            this.txtAuthDir.TabIndex = 20;
            // 
            // txtAuthGroupAuth
            // 
            this.txtAuthGroupAuth.Location = new System.Drawing.Point(275, 534);
            this.txtAuthGroupAuth.Name = "txtAuthGroupAuth";
            this.txtAuthGroupAuth.Size = new System.Drawing.Size(163, 21);
            this.txtAuthGroupAuth.TabIndex = 24;
            // 
            // txtAuthGroup
            // 
            this.txtAuthGroup.Location = new System.Drawing.Point(275, 498);
            this.txtAuthGroup.Name = "txtAuthGroup";
            this.txtAuthGroup.Size = new System.Drawing.Size(163, 21);
            this.txtAuthGroup.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "권한";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "그룹";
            // 
            // btnSvnGroupAdd
            // 
            this.btnSvnGroupAdd.Location = new System.Drawing.Point(31, 248);
            this.btnSvnGroupAdd.Name = "btnSvnGroupAdd";
            this.btnSvnGroupAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSvnGroupAdd.TabIndex = 25;
            this.btnSvnGroupAdd.Text = "그룹추가";
            this.btnSvnGroupAdd.UseVisualStyleBackColor = true;
            this.btnSvnGroupAdd.Click += new System.EventHandler(this.btnSvnGroupAdd_Click);
            // 
            // txtSvnGroupAdd
            // 
            this.txtSvnGroupAdd.Location = new System.Drawing.Point(31, 228);
            this.txtSvnGroupAdd.Name = "txtSvnGroupAdd";
            this.txtSvnGroupAdd.Size = new System.Drawing.Size(157, 21);
            this.txtSvnGroupAdd.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 27;
            this.label5.Text = "선택서버";
            // 
            // cbBoxServer
            // 
            this.cbBoxServer.FormattingEnabled = true;
            this.cbBoxServer.Location = new System.Drawing.Point(99, 20);
            this.cbBoxServer.Name = "cbBoxServer";
            this.cbBoxServer.Size = new System.Drawing.Size(159, 20);
            this.cbBoxServer.TabIndex = 28;
            this.cbBoxServer.SelectedIndexChanged += new System.EventHandler(this.cbBoxServer_SelectedIndexChanged);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(772, 149);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(100, 21);
            this.txtComment.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(715, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "설명";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 619);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.cbBoxServer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSvnGroupAdd);
            this.Controls.Add(this.btnSvnGroupAdd);
            this.Controls.Add(this.txtAuthGroupAuth);
            this.Controls.Add(this.txtAuthGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAuthDir);
            this.Controls.Add(this.btnAuthDirAdd);
            this.Controls.Add(this.lstviewAuth);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGroupAuthAdd);
            this.Controls.Add(this.lstAuth);
            this.Controls.Add(this.btnGroupAdd);
            this.Controls.Add(this.btnUserAdd);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstGroupUsers);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.lstGroup);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.GroupDelete.ResumeLayout(false);
            this.UserRemove.ResumeLayout(false);
            this.GroupUserRemove.ResumeLayout(false);
            this.AuthRemove.ResumeLayout(false);
            this.RemoveMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGroup;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.ListBox lstGroupUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.Button btnGroupAdd;
        private System.Windows.Forms.ListBox lstAuth;
        private System.Windows.Forms.Button btnGroupAuthAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView lstviewAuth;
        private System.Windows.Forms.ColumnHeader 그룹;
        private System.Windows.Forms.ColumnHeader 권한;
        private System.Windows.Forms.ContextMenuStrip RemoveMenu;
        private System.Windows.Forms.ToolStripMenuItem RemoveAuth;
        private System.Windows.Forms.ContextMenuStrip UserRemove;
        private System.Windows.Forms.ToolStripMenuItem remove;
        private System.Windows.Forms.ContextMenuStrip GroupUserRemove;
        private System.Windows.Forms.ToolStripMenuItem groupremove;
        private System.Windows.Forms.ContextMenuStrip GroupDelete;
        private System.Windows.Forms.ToolStripMenuItem removegroupd;
        private System.Windows.Forms.ContextMenuStrip AuthRemove;
        private System.Windows.Forms.ToolStripMenuItem removeauthv;
        private System.Windows.Forms.Button btnAuthDirAdd;
        private System.Windows.Forms.TextBox txtAuthDir;
        private System.Windows.Forms.TextBox txtAuthGroupAuth;
        private System.Windows.Forms.TextBox txtAuthGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSvnGroupAdd;
        private System.Windows.Forms.TextBox txtSvnGroupAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBoxServer;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label6;
    }
}

