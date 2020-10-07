using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorrowAndRepay
{
    class Person
    {
        public String Name;
        public int Money;
        //以下是constructor，在程式執行時建立
        public Person(String name, int money)
        {
            this.Name = name;
            this.Money = money;
        }
        //借錢的method
        public void borrow(Person lender, int money)
        {
            if (lender.Money >= 0)
            {
                lender.Money -= money;
                this.Money += money;
            }
            else
            {
                MessageBox.Show("沒錢可以借!!", "錢不夠!");
            }

        }
        //還錢的method
        public void repay(Person lender, int money)
        {
            if (this.Money <= 0)
            {
                MessageBox.Show("沒錢可以還!!","錢不夠!");
            }
            else {
                lender.Money += money;
                this.Money -= money;
            }

        }
    }
}
