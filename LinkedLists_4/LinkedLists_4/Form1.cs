using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedLists_4
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

            public OneWayListElement findLast()
            {
                return findLast(this);
            }

            public OneWayListElement findLast(OneWayListElement el)
            {
                if(el.next == null)
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
                if(el.next.next == null)
                {
                    return el;
                }
                else
                {
                    return findPreLast(el.next);
                }
            }
        }

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            OneWayListElement head = fillList(textBoxList.Text);
            head = sort(head);
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
        private OneWayListElement sort(OneWayListElement head)
        {
            OneWayListElement current = head;
            if(current.next == current.findLast())
            {
                head = head.next;
                head.next = current;
                current.next = null;
            }
            else
            {
                while (current != null)
                {
                    if (current.next == null || current.next.next == null)
                    {
                        break;
                    }
                    OneWayListElement next = current.next;
                    OneWayListElement preLast = current.findPreLast();
                    OneWayListElement last = current.findLast();
                    current.next = last;
                    last.next = next;
                    preLast.next = null;
                    current = current.next.next;
                }
            }
            return head;
        }

        private string show(OneWayListElement head)
        {
            OneWayListElement current = head;
            string text = "";
            while(current != null)
            {
                text += current.value + ", ";
                current = current.next;
            }
            return text;
        }
    }
}
