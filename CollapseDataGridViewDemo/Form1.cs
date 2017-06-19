using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Add new namespace
using CollapseDataGridViewDemo.Model;
using CollapseDataGridViewDemo.Controls;

namespace CollapseDataGridViewDemo
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();

            this.Load += new EventHandler(DemoForm_Load);
            //注册行绑定事件 -- 可以去掉该行注释，使用自定义绑定行数据模式
            //this.cdgvAthleteInfo.OnBindDataDetail += new CollapseDataGridView.BindDataDetailHandler(cdgvAthleteInfo_OnBindDataDetail);
            //注册新增集合事件
            this.cdgvAthleteInfo.AddGroupCompleted += new CollapseDataGridView.AddGroupHandler(cdgvAthleteInfo_AddGroupCompleted);
            //注册删除集合事件
            this.cdgvAthleteInfo.RemoveGroupCompleted += new CollapseDataGridView.RemoveGroupHandler(cdgvAthleteInfo_RemoveGroupCompleted);
            //注册新增条目事件
            this.cdgvAthleteInfo.AddItemCompleted += new CollapseDataGridView.AddItemHandler(cdgvAthleteInfo_AddItemCompleted);
            //注册删除条目事件
            this.cdgvAthleteInfo.RemoveItemCompleted += new CollapseDataGridView.RemoveItemHandler(cdgvAthleteInfo_RemoveItemCompleted);
            //注册数据源数量变更事件
            this.cdgvAthleteInfo.OnDataCountChanged += new CollapseDataGridView.DataCountChangedHandler(cdgvAthleteInfo_OnDataCountChanged);
        }

        void DemoForm_Load(object sender, EventArgs e)
        {
            this.cbFreezeGroupHeader.Checked = this.cdgvAthleteInfo.IsFreezeGroupHeader;

            AthleteGroupList athleteGroupList = this.DataGenerator();
            this.cdgvAthleteInfo.BindDataSource<AthleteGroupList, Athlete>(athleteGroupList);
        }

        #region 委托处理事件

        //行绑定处理方法
        void cdgvAthleteInfo_OnBindDataDetail(object item, int rowIndex, bool isMainItem)
        {
            DataGridViewRow row = this.cdgvAthleteInfo.Rows[rowIndex];
            Athlete singleModel = item as Athlete;

            //Country
            if (isMainItem)
            {
                row.Cells[this.col_Country.Index].Value = singleModel.Country;
            }
            else
            {
                row.Cells[this.col_Country.Index].Value = "";
            }
            //Name
            row.Cells[this.col_Name.Index].Value = singleModel.Name;
            //Gender
            row.Cells[this.col_Gender.Index].Value = singleModel.Gender;
            //Height
            row.Cells[this.col_Height.Index].Value = singleModel.Height;
            //Weight
            row.Cells[this.col_Weight.Index].Value = singleModel.Weight;
            //Item
            row.Cells[this.col_Item.Index].Value = singleModel.Item;
        }

        //删除集合完成后
        void cdgvAthleteInfo_RemoveGroupCompleted(object group, CollapseDataGridViewEventArgs e)
        {
            if (e.Result)
            {
                //TODO:展示已删除的数据，或设置CollapseDataGirdView其他属性，如只读等
                AthleteItemList singleGroup = group as AthleteItemList;
                MessageBox.Show
                    (
                         this,
                        "已删除新增集合" +
                        "\r\n驻扎酒店：" + ((singleGroup.Hotel != null) ? singleGroup.Hotel : "暂无") +
                        "\r\n大巴车牌：" + ((singleGroup.BusNo != null) ? singleGroup.BusNo : "暂无") +
                        "\r\n休息室号：" + ((singleGroup.RestRoomNo != null) ? singleGroup.RestRoomNo : "暂无") +
                        "\r\n成员数：" + singleGroup.Count,
                        "删除集合提示信息"
                    );
            }
            else
            {
                MessageBox.Show(e.ErrorMessage);
            }
        }

        //新增集合完成后
        void cdgvAthleteInfo_AddGroupCompleted(object group, CollapseDataGridViewEventArgs e)
        {
            if (e.Result)
            {
                //TODO:展示已新增数据，或设置CollapseDataGirdView其他属性，如只读等
                AthleteItemList singleGroup = group as AthleteItemList;
                if (singleGroup != null)
                {
                    MessageBox.Show
                        (
                            this,
                            "已成功新增集合" +
                            "\r\n驻扎酒店：" + ((singleGroup.Hotel != null) ? singleGroup.Hotel : "暂无") +
                            "\r\n大巴车牌：" + ((singleGroup.BusNo != null) ? singleGroup.BusNo : "暂无") +
                            "\r\n休息室号：" + ((singleGroup.RestRoomNo != null) ? singleGroup.RestRoomNo : "暂无") +
                            "\r\n成员数：" + singleGroup.Count,
                            "新增集合提示信息"
                        );
                }
            }
            else
            {
                MessageBox.Show(e.ErrorMessage);
                //TODO: 出现错误后，可以清空CollapseDataGridView的DataSource后重新绑定
            }
        }

        //当新增条目完成时
        void cdgvAthleteInfo_AddItemCompleted(object item, CollapseDataGridViewEventArgs e)
        {
            if (e.Result)
            {
                Athlete singleItem = item as Athlete;
                if (singleItem != null)
                {
                    MessageBox.Show
                        (
                            this,
                            "已成功新增条目" +
                            "\r\n姓名：" + 
                            ((singleItem.Name != null && singleItem.Name != string.Empty) ? singleItem.Name : "暂无") +
                            "\r\n性别：" +
                            ((singleItem.Gender != null && singleItem.Gender != string.Empty) ? singleItem.Gender : "暂无") +
                            "\r\n国家：" +
                            ((singleItem.Country != null && singleItem.Country != string.Empty) ? singleItem.Country : "暂无"),
                            "新增条目提示信息"
                        );
                }
            }
            else
            {
                MessageBox.Show(e.ErrorMessage);
            }
        }

        /// <summary>
        /// 删除条目完成时
        /// </summary>
        /// <param name="item"></param>
        /// <param name="e"></param>
        void cdgvAthleteInfo_RemoveItemCompleted(object item, CollapseDataGridViewEventArgs e)
        {
            if (e.Result)
            {
                Athlete singleItem = item as Athlete;
                if (singleItem != null)
                {
                    MessageBox.Show
                        (
                            this,
                            "已成功删除条目" +
                            "\r\n姓名：" +
                            ((singleItem.Name != null && singleItem.Name != string.Empty) ? singleItem.Name : "暂无") +
                            "\r\n性别：" +
                            ((singleItem.Gender != null && singleItem.Gender != string.Empty) ? singleItem.Gender : "暂无") +
                            "\r\n国家：" +
                            ((singleItem.Country != null && singleItem.Country != string.Empty) ? singleItem.Country : "暂无"),
                            "删除条目提示信息"
                        );
                }
            }
            else
            {
                MessageBox.Show(e.ErrorMessage);
            }
        }

        //当数据源数量变化后
        void cdgvAthleteInfo_OnDataCountChanged()
        {
            this.lblGroupCount.Text = this.cdgvAthleteInfo.GroupCount.ToString();
            this.lblItemCount.Text = this.cdgvAthleteInfo.ItemCount.ToString();
        }

        #endregion

        #region 页面动作事件

        #region 条目操作区

        //新增一条数据
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //增加新行
            //如果列表不为空，则在最后一个集合中新增一条数据，
            //如果列表为空，说明需要新增一个组
            string strCurrentTime = DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
            Athlete testItem = new Athlete
            {
                Country = "TEST_" + strCurrentTime,
                Gender = "Male",
                Name = "TEST_" + strCurrentTime,
                Height = new Random(DateTime.Now.Minute).Next(150, 200),
                Weight = new Random(DateTime.Now.Minute).Next(45, 90),
                Item = "Certain item"
            };

            this.cdgvAthleteInfo.AddItem<AthleteItemList, Athlete>(testItem);
        }

        //新增空条目
        private void btnAddEmptyItem_Click(object sender, EventArgs e)
        {
            this.cdgvAthleteInfo.AddItem<AthleteItemList, Athlete>(null);
        }

        //向选中集合的选中条目上方插入一条数据
        private void btnInsertItem_Click(object sender, EventArgs e)
        {
            //插入新行
            //如果列表不为空，则在最后一个集合中新增一条数据，
            //如果列表为空，说明需要新增一个组
            string strCurrentTime = DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
            Athlete testItem = new Athlete
            {
                Country = "TEST_" + strCurrentTime,
                Gender = "Male",
                Name = "TEST_" + strCurrentTime,
                Height = new Random(DateTime.Now.Minute).Next(150, 200),
                Weight = new Random(DateTime.Now.Minute).Next(45, 90),
                Item = "Certain item"
            };

            //列表为空，不允许插入
            if (this.cdgvAthleteInfo.SelectedRows.Count > 0)
            {
                this.cdgvAthleteInfo.InsertItem<AthleteItemList, Athlete>(testItem);
            }
            else
            {
                //TODO：自定义的操作，比如插入新组或提示信息
                MessageBox.Show("列表为空或为选中要插入的位置！");
            }
        }

        //插入新的空条目
        private void btnInsertEmptyItem_Click(object sender, EventArgs e)
        {
            //列表为空，不允许插入
            if (this.cdgvAthleteInfo.SelectedRows.Count > 0)
            {
                this.cdgvAthleteInfo.InsertItem<AthleteItemList, Athlete>(null);
            }
            else
            {
                //TODO：自定义的操作，比如插入新组或提示信息
                MessageBox.Show("列表为空或未选中要插入的位置！");
            }
        }

        //删除选中的条目
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (this.cdgvAthleteInfo.SelectedRows.Count > 0)
            {
                this.cdgvAthleteInfo.RemoveItem<Athlete>(this.cdgvAthleteInfo.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("列表为空或未选中删除的条目！");
            }
        }

        #endregion

        #region 集合操作区

        //在最后一个集合之后新增一个集合
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            AthleteItemList testList = new AthleteItemList();
            testList.Hotel = "Marriott Hotel";
            testList.BusNo = "浙A 345678";
            testList.RestRoomNo = "1025";
            string strCurrentTime = DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
            testList.Add(new Athlete { Country = "TEST_" + strCurrentTime, Gender = "Male", Name = "TEST", Height = new Random(DateTime.Now.Minute).Next(150, 200), Weight = new Random(DateTime.Now.Minute).Next(45, 90), Item = "Certain item" });
            testList.Add(new Athlete { Country = "TEST_" + strCurrentTime, Gender = "Female", Name = "TEST", Height = new Random(DateTime.Now.Second).Next(150, 200), Weight = new Random(DateTime.Now.Second).Next(45, 90), Item = "Certain item" });
            testList.Add(new Athlete { Country = "TEST_" + strCurrentTime, Gender = "Female", Name = "TEST", Height = new Random(DateTime.Now.Millisecond).Next(150, 200), Weight = new Random(DateTime.Now.Millisecond).Next(45, 90), Item = "Certain item" });

            Athlete testModel = new Athlete { Country = "TEST_" + strCurrentTime, Gender = "Male", Name = "TEST_Double", Height = new Random(DateTime.Now.Minute).Next(150, 200), Weight = new Random(DateTime.Now.Minute).Next(45, 90), Item = "Certain item" };
            testList.Add(testModel);
            testList.Add(testModel);

            this.cdgvAthleteInfo.AddGroup<AthleteItemList, Athlete>(testList);
        }

        //新增空集合
        private void btnAddEmptyGroup_Click(object sender, EventArgs e)
        {
            this.cdgvAthleteInfo.AddGroup<AthleteItemList, Athlete>(null);
        }

        //插入空集合
        private void btnInsertEmptyGroup_Click(object sender, EventArgs e)
        {
            //列表为空，不允许插入
            if (this.cdgvAthleteInfo.SelectedRows.Count > 0)
            {
                this.cdgvAthleteInfo.InsertGroup<AthleteItemList ,Athlete>(null);
            }
            else
            {
                //TODO：自定义的操作，比如插入新组或提示信息
                MessageBox.Show("列表为空或未选中要插入的位置！");
            }
        }

        //向选中行所在的集合上方插入一个集合
        private void btnInsertGroup_Click(object sender, EventArgs e)
        {
            AthleteItemList testList = new AthleteItemList();
            testList.Hotel = "Marriott Hotel";
            testList.BusNo = "浙A 345678";
            testList.RestRoomNo = "1025";
            string strCurrentTime = DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
            testList.Add(new Athlete { Country = "TEST_" + strCurrentTime, Gender = "Male", Name = "TEST", Height = new Random(DateTime.Now.Minute).Next(150, 200), Weight = new Random(DateTime.Now.Minute).Next(45, 90), Item = "Certain item" });
            testList.Add(new Athlete { Country = "TEST_" + strCurrentTime, Gender = "Female", Name = "TEST", Height = new Random(DateTime.Now.Second).Next(150, 200), Weight = new Random(DateTime.Now.Second).Next(45, 90), Item = "Certain item" });
            testList.Add(new Athlete { Country = "TEST_" + strCurrentTime, Gender = "Female", Name = "TEST", Height = new Random(DateTime.Now.Millisecond).Next(150, 200), Weight = new Random(DateTime.Now.Millisecond).Next(45, 90), Item = "Certain item" });


            //列表为空，不允许插入
            if (this.cdgvAthleteInfo.SelectedRows.Count > 0)
            {
                this.cdgvAthleteInfo.InsertGroup<AthleteItemList ,Athlete>(testList);
            }
            else
            {
                //TODO：自定义的操作，比如插入新组或提示信息
                MessageBox.Show("列表为空或为选中要插入的位置！");
            }
        }

        //删除选中的集合
        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            if (this.cdgvAthleteInfo.SelectedRows.Count > 0)
            {
                this.cdgvAthleteInfo.RemoveGroup(this.cdgvAthleteInfo.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("列表为空或未选中删除的条目！");
            }
        }

        #endregion

        #region 信息区

        //显示DataGridView信息
        private void btnShowGridInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                (
                    this,
                    "　　　　　集合数：" +
                    this.cdgvAthleteInfo.GroupCount.ToString() +
                    "　　　　　\r\n" +
                    "　　　　　条目数：" +
                    this.cdgvAthleteInfo.ItemCount.ToString(),
                    "统计信息"
                );
        }

        //显示集合信息
        private void btnShowGroupInfo_Click(object sender, EventArgs e)
        {
            AthleteItemList groupInfo = this.cdgvAthleteInfo.GetGroupInfo<AthleteItemList>();

            if (groupInfo != null)
            {
                MessageBox.Show
                    (
                        this,
                        "驻扎酒店：" + ((groupInfo.Hotel != null) ? groupInfo.Hotel : "暂无") +
                        "\r\n" +
                        "大巴车牌：" + ((groupInfo.BusNo != null) ? groupInfo.BusNo : "暂无") +
                        "\r\n" +
                        "休息室号：" + ((groupInfo.RestRoomNo != null) ? groupInfo.RestRoomNo : "暂无"),
                        "集合信息"
                    );
            }
            else
            {
                MessageBox.Show(this, "没有找到相应的集合信息！", "提示信息");
            }
        }

        #endregion

        #endregion

        #region 其他方法

        //当选中状态发生变化时
        private void cbFreezeGroupHeader_CheckedChanged(object sender, EventArgs e)
        {
            this.cdgvAthleteInfo.IsFreezeGroupHeader = this.cbFreezeGroupHeader.Checked;
        }

        #endregion

        #region 获取模拟数据

        private AthleteGroupList DataGenerator()
        {
            AthleteGroupList athleteGroupList = new AthleteGroupList();

            AthleteItemList chinaList = new AthleteItemList();
            chinaList.Hotel = "Hilton Hotel";
            chinaList.BusNo = "浙A 123456";
            chinaList.RestRoomNo = "1021";
            chinaList.Add(new Athlete { Country = "China", Gender = "Male", Name = "Gang Li", Height = 182, Weight = 80, Item = "Swim" });
            chinaList.Add(new Athlete { Country = "China", Gender = "Female", Name = "Hong Wang", Height = 175, Weight = 65, Item = "Archery" });
            chinaList.Add(new Athlete { Country = "China", Gender = "Female", Name = "Ming Yao", Height = 175, Weight = 65, Item = "Basketball" });
            chinaList.Add(new Athlete { Country = "China", Gender = "Female", Name = "Peng Li", Height = 175, Weight = 65, Item = "KungFu" });
            chinaList.Add(new Athlete { Country = "China", Gender = "Female", Name = "Xu Zhang", Height = 175, Weight = 65, Item = "Cycling" });
            athleteGroupList.Add(chinaList);

            AthleteItemList usaList = new AthleteItemList();
            usaList.Hotel = "Intercontinental Hotel";
            usaList.BusNo = "浙A 234567";
            usaList.RestRoomNo = "1022";
            usaList.Add(new Athlete { Country = "United States", Gender = "Male", Name = "Jack", Height = 191, Weight = 80, Item = "Run" });
            usaList.Add(new Athlete { Country = "United States", Gender = "Male", Name = "Mike", Height = 183, Weight = 85, Item = "Diving" });
            usaList.Add(new Athlete { Country = "United States", Gender = "Male", Name = "John", Height = 199, Weight = 85, Item = "Basketball" });
            athleteGroupList.Add(usaList);

            AthleteItemList ukList = new AthleteItemList();
            ukList.Hotel = "Marriott Hotel";
            ukList.BusNo = "浙A 345678";
            ukList.RestRoomNo = "1023";
            ukList.Add(new Athlete { Country = "Britain", Gender = "Female", Name = "Elizabeth", Height = 160, Weight = 60, Item = "Golf" });
            athleteGroupList.Add(ukList);

            AthleteItemList jpList = new AthleteItemList();
            jpList.Hotel = "Sheraton Hotel";
            jpList.BusNo = "浙A 456789";
            jpList.RestRoomNo = "1024";
            jpList.Add(new Athlete { Country = "France", Gender = "Male", Name = "Jet", Height = 170, Weight = 60, Item = "Surfing" });
            jpList.Add(new Athlete { Country = "France", Gender = "Female", Name = "Lily", Height = 162, Weight = 60, Item = "Tennis" });
            jpList.Add(new Athlete { Country = "France", Gender = "Male", Name = "Lawson", Height = 181, Weight = 60, Item = "Judo" });
            jpList.Add(new Athlete { Country = "France", Gender = "Female", Name = "Linda", Height = 176, Weight = 60, Item = "Gym" });
            jpList.Add(new Athlete { Country = "France", Gender = "Male", Name = "Steve", Height = 167, Weight = 60, Item = "Chess" });
            athleteGroupList.Add(jpList);

            return athleteGroupList;
        }

        #endregion
    }
}
