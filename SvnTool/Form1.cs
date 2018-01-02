using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SvnTool
{
    public struct GroupInfo
    {
        public string strName { get; set; }
        public List<string> lstUsers { get; set; }
    }

    public struct SvnUserInfo
    {
        public string strName { get; set; }
        public string strPasswd { get; set; }
        public override string ToString()
        {
            return strName;
        }
    }

    public struct SVNAuthValue
    {
        public string strgroup { get; set; }
        public string strAuth { get; set; }
    }

    public struct SVNAuthInfo
    {
        public string strDir { get; set; }
        public List<SVNAuthValue> lstAuth { get; set; }
    }

    public struct SVNConfig
    {
        public string strName { get; set; }
        public string strPath { get; set; }
    }

    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void LoadConfig()
        {
            string[] lines = System.IO.File.ReadAllLines(@".\Config.txt", Encoding.Default);
            foreach (var line in lines)
            {
                if (0 >= line.Length) continue;
                if ('#' == line[0]) continue; //주석 
                var values = line.Split('=');
                var cAdd = new SVNConfig();
                cAdd.strName = values[0].Trim();
                cAdd.strPath = values[1].Trim();

                cbBoxServer.Items.Add(cAdd);
            }

            cbBoxServer.SelectedIndex = 0;
            cbBoxServer.DisplayMember = "strName";

        }

        private void SelectGroup()
        {
            lstGroupUsers.Items.Clear();
            if (-1 == lstGroup.SelectedIndex) return;
            var cGroup = (GroupInfo)lstGroup.SelectedItem;
            foreach(var cUser in cGroup.lstUsers){
                lstGroupUsers.Items.Add(cUser);
            }
            
        }

        private void SetGroupFile(string strGroupFile)
        {
            string[] lines = System.IO.File.ReadAllLines(strGroupFile, Encoding.Default);
            //List<string> lstGroup = new List<string>();
            string strAuthDir = "";
            bool bStartGroup = false;
            bool bAuth = false;
            foreach (var line in lines)
            {
                if (0 >= line.Length) continue;
                if ('#' == line[0]) continue; //주석 

                if ('[' == line[0])
                {
                    if (-1 != line.IndexOf("[groups]")) //그룹셋팅
                    {
                        bStartGroup = true;
                    }
                    if ('/' == line[1])
                    {
                        bAuth = true;
                        bStartGroup = false;
                        strAuthDir = line.Trim();
                        continue;
                    }

                }
                if (bStartGroup)
                {
                    var cGroup =  new GroupInfo();
                    cGroup.lstUsers = new List<string>();
                    var iIndex = line.IndexOf('=');
                    if (-1 == iIndex) continue;
                    cGroup.strName = line.Substring(0, iIndex);
                    lstGroup.Items.Add(cGroup);
                    var struser = line.Substring(iIndex +1, line.Length - (iIndex + 1));
                    string[] values = struser.Split(',');
                    foreach(var cuser in values)
                    {
                        var idx = lstUsers.FindString(cuser.Trim());
                        if ( -1 != idx)
                        {
                            cGroup.lstUsers.Add(cuser.Trim());
                        }
                        else
                            MessageBox.Show("NOT FOUND USER : " + cuser);
                    }

                    continue;
                }
                if (bAuth)
                {
                    var iIndex = line.IndexOf('=');
                    if (-1 == iIndex) continue;
                    iIndex =  lstAuth.FindString(strAuthDir);
                    if (-1 == iIndex)
                    {
                        var cAddAuth = new SVNAuthInfo();
                        cAddAuth.lstAuth = new List<SVNAuthValue>();
                        cAddAuth.strDir = strAuthDir;
                        lstAuth.Items.Add(cAddAuth);
                        var cAddAuthValue = new SVNAuthValue();

                        string[] values = line.Split('=');
                        cAddAuthValue.strgroup = values[0].Trim();
                        cAddAuthValue.strAuth = values[1].Trim() ;

                        cAddAuth.lstAuth.Add(cAddAuthValue);
                        lstAuth.DisplayMember = "strDir";
                    }
                    else
                    {
                        var cAddAuth = (SVNAuthInfo)(lstAuth.Items[iIndex]);
                        var cAddAuthValue = new SVNAuthValue();
                        string[] values = line.Split('=');
                        cAddAuthValue.strgroup = values[0].Trim();
                        cAddAuthValue.strAuth = values[1].Trim();
                        cAddAuth.lstAuth.Add(cAddAuthValue);
                    }
                    continue;
                }
            }
            lstGroup.DisplayMember = "strName";
            lstGroup.SelectedIndex = 0;
            SelectGroup();

            lstAuth.SelectedIndex = 0;
            SelectAuthList();
        }

        private void SelectAuthList()
        {
            lstviewAuth.BeginUpdate();
            lstviewAuth.Items.Clear();
            if (-1 == lstAuth.SelectedIndex) return;
            var cAuth = (SVNAuthInfo)lstAuth.SelectedItem;
            foreach (var cAuthValue in cAuth.lstAuth)
            {
                ListViewItem cAdd = new ListViewItem();
                cAdd.Text = cAuthValue.strgroup;
                cAdd.SubItems.Add(cAuthValue.strAuth);
                lstviewAuth.Items.Add(cAdd);
                
                //lstGroupUsers.Items.Add(cUser);
            }
            lstviewAuth.EndUpdate();


        }

        private void SetUserFile(string strUserFileName)
        {
            string[] lines = System.IO.File.ReadAllLines(strUserFileName, Encoding.Default);
            foreach (var line in lines)
            {
                if (0 >= line.Length) continue;
                if ('#' == line[0]) continue; //주석 
                var iIndex = line.IndexOf("[users]");
                if (-1 != iIndex) continue;

                var cUser = new SvnUserInfo();
                string[] values = line.Split('=');
                cUser.strName = values[0];
                cUser.strPasswd = values[1];

                lstUsers.Items.Add(cUser);
            }

            lstUsers.DisplayMember = "strName";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
            lstviewAuth.Items.Clear();
            LoadConfig();
        }

        private void lstGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectGroup();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            var cUser = new SvnUserInfo();
            cUser.strName = txtUser.Text;
            cUser.strPasswd = txtPasswd.Text;

            var iIndex = lstUsers.Items.IndexOf(cUser.strName);
            if (-1 == iIndex) {
                MessageBox.Show("중복 계정");
                return;
            }

            lstUsers.Items.Add(cUser);
            
            
        }

        private void btnUserDel_Click(object sender, EventArgs e)
        {
            if ( -1 != lstUsers.SelectedIndex) 
                lstUsers.Items.RemoveAt(lstUsers.SelectedIndex);
        }

        private void btnGroupAdd_Click(object sender, EventArgs e)
        {
            if (-1 == lstUsers.SelectedIndex)
            {
                MessageBox.Show("유저 선택 안함");
                return;
            }

            if (-1 == lstGroup.SelectedIndex)
            {
                MessageBox.Show("그룹 선택 안함");
                return;
            }

            var cGroup = (GroupInfo)lstGroup.SelectedItem;
            var iIndex = cGroup.lstUsers.IndexOf(((SvnUserInfo)lstUsers.SelectedItem).strName);
            if (-1 != iIndex)
            {
                MessageBox.Show("이미 그룹에 포함됨");
                return;
            }
            cGroup.lstUsers.Add( ((SvnUserInfo)lstUsers.SelectedItem).strName);

            SelectGroup(); 

        }

        private void btnGroupUserDel_Click(object sender, EventArgs e)
        {
            if (-1 == lstGroupUsers.SelectedIndex)
            {
                MessageBox.Show("그룹유저 선택 안함");
                return;
            }
            if (-1 == lstGroup.SelectedIndex)
            {
                MessageBox.Show("그룹 선택 안함");
                return;
            }

            var cGroup = (GroupInfo)lstGroup.SelectedItem;
            var user = lstGroupUsers.SelectedItem.ToString();
            var iIndex = cGroup.lstUsers.IndexOf(user);
            if (-1 == iIndex)
            {
                MessageBox.Show("그룹에 없는 유저");
                return;
            }
            cGroup.lstUsers.Remove(user);
            SelectGroup();
        }

        private void btnGroupAuthDel_Click(object sender, EventArgs e)
        {
            ListViewItem cAdd = new ListViewItem();
            cAdd.Text = txtAuthGroup.Text.Trim();
            cAdd.SubItems.Add(txtAuthGroupAuth.Text.Trim());
            lstviewAuth.Items.Add(cAdd);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var idx = cbBoxServer.SelectedIndex;
            var cConfig = (SVNConfig)cbBoxServer.Items[idx];

            SaveSvnAuthConfig (cConfig.strPath + @"\Conf\authz1");
            SaveSvnPasswdConfig(cConfig.strPath + @"\Conf\passwd");
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (-1 == lstUsers.SelectedIndex) return;
            var cUserInfo = (SvnUserInfo)lstUsers.SelectedItem;
            txtUser.Text = cUserInfo.strName;
            txtPasswd.Text = cUserInfo.strPasswd;
        }


        private void RemoveMenu_Click(object sender, EventArgs e)
        {
            var cSelected = lstviewAuth.SelectedItems[0];
            
            lstviewAuth.Items.RemoveAt(cSelected.Index);
        }

        private void UserRemove_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (-1 != lstUsers.SelectedIndex)
                lstUsers.Items.RemoveAt(lstUsers.SelectedIndex);

        }

        private void GroupUserRemove_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (-1 == lstGroupUsers.SelectedIndex)
            {
                MessageBox.Show("그룹유저 선택 안함");
                return;
            }
            if (-1 == lstGroup.SelectedIndex)
            {
                MessageBox.Show("그룹 선택 안함");
                return;
            }

            var cGroup = (GroupInfo)lstGroup.SelectedItem;
            var user = lstGroupUsers.SelectedItem.ToString();
            var iIndex = cGroup.lstUsers.IndexOf(user);
            if (-1 == iIndex)
            {
                MessageBox.Show("그룹에 없는 유저");
                return;
            }
            cGroup.lstUsers.Remove(user);
            SelectGroup();
        }

        private void AuthRemove_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (-1 == lstAuth.SelectedIndex)
            {
                return;
            }

            lstAuth.Items.RemoveAt(lstAuth.SelectedIndex);

        }

        private void GroupDelete_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (-1 == lstGroup.SelectedIndex)
            {
                return;
            }

            lstGroup.Items.RemoveAt(lstGroup.SelectedIndex);

        }

        private void lstAuth_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectAuthList();
        }

        private void btnAuthDirAdd_Click(object sender, EventArgs e)
        {
            if ( "" != txtAuthDir.Text.Trim() )
            {
                var cAddAuth = new SVNAuthInfo();
                cAddAuth.lstAuth = new List<SVNAuthValue>();
                cAddAuth.strDir = txtAuthDir.Text.Trim();
                lstAuth.Items.Add(cAddAuth);
            }
        }

        private void btnSvnGroupAdd_Click(object sender, EventArgs e)
        {
            if ("" == txtSvnGroupAdd.Text.Trim()) return;
            if (-1 != lstGroup.FindString(txtSvnGroupAdd.Text.Trim()))
            {
                MessageBox.Show("중복");
                return;
            }
            var cGroup = new GroupInfo();
            cGroup.lstUsers = new List<string>();
            cGroup.strName = txtSvnGroupAdd.Text.Trim();
            lstGroup.Items.Add(cGroup);
        }

        private void cbBoxServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAuth.Items.Clear();
            lstGroup.Items.Clear();
            lstGroupUsers.Items.Clear();
            lstviewAuth.Items.Clear();
            lstUsers.Items.Clear();

            var idx = cbBoxServer.SelectedIndex;
            var cConfig = (SVNConfig)cbBoxServer.Items[idx];

            //string basedir = @"C:\Users\kyd\Documents\visual studio 2017\Projects\SvnTool\SvnTool\testRoot\Program";
            SetUserFile(cConfig.strPath + @"\Conf\passwd");
            SetGroupFile(cConfig.strPath + @"\Conf\authz");
        }

        private void SaveSvnAuthConfig(string strSavePath)
        {
            string strText = "# svn auth info save\n\n\n";
            strText += "[groups]\n";

            foreach(var item in lstGroup.Items)
            {
                var cGroupInfo = (GroupInfo)item;
                strText += cGroupInfo.strName;
                strText += "=";
                foreach(var cUser in cGroupInfo.lstUsers)
                {
                    strText += cUser + ",";
                }

                strText = strText.Substring(0,strText.Length - 1);
                strText += "\n\n";
            }
            strText += "#auth start" + Environment.NewLine;
            foreach (var item in lstAuth.Items)
            {
                var cAuthInfo = (SVNAuthInfo)item;
                strText += cAuthInfo.strDir + Environment.NewLine ;
                foreach (var cAuth in cAuthInfo.lstAuth)
                {
                    strText +=  cAuth.strgroup + "=";
                    strText += cAuth.strAuth + Environment.NewLine;
                }
                strText += Environment.NewLine;
            }

            using (StreamWriter outputFile = new StreamWriter(strSavePath,false, Encoding.Default))
            {
                outputFile.WriteLine(strText);
            }
        }

        private void SaveSvnPasswdConfig(string strSavePath)
        {
            string strText = "# svn user info save\n\n\n";
            strText += "[users]\n";

            foreach (var item in lstUsers.Items)
            {
                var cUserInfo = (SvnUserInfo)item;
                strText += cUserInfo.strName;
                strText += "=";
                strText += cUserInfo.strPasswd;
                strText += Environment.NewLine;
            }

            using (StreamWriter outputFile = new StreamWriter(strSavePath,false, Encoding.Default))
            {
                outputFile.WriteLine(strText);
            }
        }
    }
}
