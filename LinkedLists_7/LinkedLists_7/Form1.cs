using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedLists_7
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

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            OneWayListElement[] heads = new OneWayListElement[3];
            heads[0] = fillList(textBoxList1.Text);
            heads[1] = fillList(textBoxList2.Text);
            heads[2] = fillList(textBoxList3.Text);
            OneWayListElement sorted = sort(heads);
            textBoxResult.Text = show(sorted);
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
        private OneWayListElement sort(OneWayListElement[] heads)
        {
            OneWayListElement[] currents = new OneWayListElement[heads.Length];
            OneWayListElement sorted = null;
            for(int i = 0; i < currents.Length; i++)
            {
                currents[i] = heads[i];
            }
            OneWayListElement min;
            int length = 0;
            do
            {
                min = null;
                int? minList = null;
                for (int i = 0; i < currents.Length; i++)
                {
                    if (currents[i] != null)
                    {
                        if (min == null)
                        {
                            min = currents[i];
                            minList = i;
                        }
                        else
                        {
                            if (currents[i].value < min.value)
                            {
                                min = currents[i];
                                minList = i;
                            }
                        }
                    }
                }
                
                if (sorted == null)
                {
                    sorted = min;
                }
                else
                {
                    length++;
                    OneWayListElement temp = sorted;
                    for(int i = 0; i < length - 1; i++)
                    {
                        temp = temp.next;
                    }
                    temp.next = min;
                }
                if (currents[Convert.ToInt32(minList)] != null)
                {
                    currents[Convert.ToInt32(minList)] = currents[Convert.ToInt32(minList)].next;
                }
            } while (min != null);
            return sorted;
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
