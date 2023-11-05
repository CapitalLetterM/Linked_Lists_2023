using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedLists_8
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

        private void buttonSort_Click(object sender, EventArgs e)
        {
            OneWayListElement head = fillList(textBoxList.Text);
            head = shuffle(head, Convert.ToInt32(textBoxPeriod.Text));
            textBoxResult.Text = show(head);
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
        private OneWayListElement shuffle(OneWayListElement head, int period)
        {
            OneWayListElement sorted = null;
            OneWayListElement current = head;

            while(checkLength(current, period) == false)
            {
                //OneWayListElement temp = current;
                OneWayListElement[] subList = new OneWayListElement[period];
                for(int i = period - 1; i >= 0; i--)
                {
                    subList[i] = current;
                    current = current.next;
                }
                //OneWayListElement next = current;

                for(int i = 0; i < period - 1; i++)
                {
                    subList[i].next = subList[i + 1];
                }
                subList[period - 1].next = null;
                if (sorted == null)
                {
                    sorted = subList[0];
                }
                else
                {
                    sorted.findLast().next = subList[0];
                }
            }
            sorted.findLast().next = current;
            return sorted;
        }

        private bool checkLength(OneWayListElement current, int period)
        {
            OneWayListElement temp = current;
            for (int i = 0; i < period; i++)
            {
                if (temp == null)
                {
                    return true;
                }
                else
                {
                    temp = temp.next;
                }
            }
            return false;
        }

        private string show(OneWayListElement head)
        {
            OneWayListElement current = head;
            string text = "";
            while (current != null)
            {
                text += current.value + ", ";
                current = current.next;
            }
            return text;
        }
    }
}
