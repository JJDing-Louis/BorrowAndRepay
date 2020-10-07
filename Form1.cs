using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorrowAndRepay
{
    public partial class Form1 : Form
    {
        Person i, friend;

        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            i = new Person(myNameInput.Text, 0);
            friend = new Person(friendNameInput.Text, 200000);
            //下面關閉輸入的功能
            myNameInput.Enabled = false;
            friendNameInput.Enabled = false;
            submitButton.Enabled = false;
            //下面開啟借還錢的功能
            borrowButton.Enabled = true;
            repayButton.Enabled = true;
            //修改按鈕文字
            borrowButton.Text = "跟" + friend.Name + "借1000 $";
            repayButton.Text = "還給" + friend.Name + "1000 $";
            //以下更新名字
            myNameLabel.Text = i.Name;
            friendNameLabel.Text = friend.Name;
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            i.borrow(friend, 1000); //呼叫借錢的Method
            updateMoney();
        }

        private void repayButton_Click(object sender, EventArgs e)
        {
            i.repay(friend, 1000);
            updateMoney();
        }
        //更新錢的狀態
        private void updateMoney() 
        {
            myMoneyLabel.Text = ""+i.Money;
            friendMoneyLabel.Text = "" + friend.Money;
        }
    }
}
