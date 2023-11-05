using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedLists_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class OneWayListElement
        {
            public int value;
            public OneWayListElement next;

            public OneWayListElement(int number)
            {
                value = number;
                next = null;
            }

            public void add(int number)
            {
                findLast().next = new OneWayListElement(number);
            }

            public OneWayListElement findLast()
            {
                return findLast(this);
            }

            public OneWayListElement findLast(OneWayListElement el)
            {
                if (el.next == null)
                {
                    return el;
                }
                else
                {
                    return findLast(el.next);
                }
            }

            public OneWayListElement findPreLast()
            {
                return findPreLast(this);
            }

            public OneWayListElement findPreLast(OneWayListElement el)
            {
                if (el.next.next == null)
                {
                    return el;
                }
                else
                {
                    return findPreLast(el.next);
                }
            }

            public OneWayListElement find(int number)
            {
                if (value == number)
                {
                    return this;
                }
                else
                {
                    return next.find(number);
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            OneWayListElement head = fillList(textBoxList.Text);
            join(head, Convert.ToInt32(textBoxEl.Text));
            if(findCycle(head) == true)
            {
                textBoxResult.Text = "Цикл є";
            }
            else
            {
                textBoxResult.Text = "Циклу немає";
            }
        }

        private OneWayListElement fillList(string text)
        {
            OneWayListElement list = null;
            string temp = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsNumber(text, i) == true || text[i] == '-')
                {
                    temp += text[i];
                }
                else
                {
                    if (temp != "")
                    {
                        if (list == null)
                        {
                            list = new OneWayListElement(Convert.ToInt32(temp));
                        }
                        else
                        {
                            list.findLast().next = new OneWayListElement(Convert.ToInt32(temp));
                        }
                        temp = "";
                    }
                }
            }
            if (temp != "")
            {
                if (list == null)
                {
                    list = new OneWayListElement(Convert.ToInt32(temp));
                }
                else
                {
                    list.findLast().next = new OneWayListElement(Convert.ToInt32(temp));
                }
            }
            return list;
        }

        //потрібна функція
        private void join(OneWayListElement head, int position)
        {
            if(position >= 0)
            {
                OneWayListElement current = head;
                for(int i = 0; i < position; i++)
                {
                    if(current.next == null)
                    {
                        return;
                    }
                    current = current.next;
                }
                head.findLast().next = current;
            }
        }
        
        //потрібна функція
        private bool findCycle(OneWayListElement head)
        {
            OneWayListElement one = head;
            OneWayListElement two = head;
            while(one.next != null && two.next != null && two.next.next != null)
            {
                one = one.next;
                two = two.next.next;
                if(one == two)
                {
                    return true;
                }
            }
            return false;
        }
    }
}