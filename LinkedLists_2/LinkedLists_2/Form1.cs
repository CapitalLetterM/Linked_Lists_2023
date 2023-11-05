using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedLists_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class OneWayList
        {
            public OneWayListElement head;
            public int Count;

            public OneWayList()
            {
                Count = 0;
            }

            public void add(OneWayListElement el)
            {
                if(head == null)
                {
                    head = el;
                }
                else
                {
                    findLast().next = el;
                }
                Count++;
            }

            public void add(int value)
            {
                if (head == null)
                {
                    head = new OneWayListElement(value);
                }
                else
                {
                    findLast().next = new OneWayListElement(value);
                }
                Count++;
            }

            public void removeValue(OneWayListElement start, int value)
            {
                if(start.next == null)
                {
                    return;
                }
                if(start.next.value == value)
                {
                    start.next = start.next.next;
                    Count--;
                }
                if (start.next == null)
                {
                    return;
                }
                removeValue(start.next, value);
            }

            public OneWayListElement findLast()
            {
                return search(head, null);
            }

            private OneWayListElement search(OneWayListElement current, OneWayListElement param)
            {
                //if (position == Count)
                //{
                //    return null;
                //}
                if (current.next != param)
                {
                    return search(current.next, param);
                }
                else
                {
                    return current;
                }
            }

            public OneWayListElement findValue(OneWayListElement current, int target)
            {
                if(current == null)
                {
                    return null;
                }
                if(current.value == target)
                {
                    return current;
                }
                else
                {
                    return findValue(current.next, target);
                }
            }
        }

        public class OneWayListElement
        {
            public int value;
            public OneWayListElement next;

            public OneWayListElement(int val)
            {
                value = val;
                next = null;
            }

            public OneWayListElement()
            {

            }
        }

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            OneWayList list = fillList(textBoxList.Text);
            list = clearDoubles(list);
            textBoxResult.Text = show(list);
        }

        private OneWayList fillList(string text)
        {
            OneWayList list = new OneWayList();
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
                        list.add(Convert.ToInt32(temp));
                        temp = "";
                    }
                }
            }
            if (temp != "")
            {
                list.add(Convert.ToInt32(temp));
            }
            return list;
        }

        //потрібна функція
        private OneWayList clearDoubles(OneWayList list)
        {
            OneWayListElement current = list.head;
            
            while (current != null)
            {
                list.removeValue(current, current.value);
                current = current.next;
            }
            return list;
        }

        private string show(OneWayList list)
        {
            OneWayListElement current = list.head;
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
