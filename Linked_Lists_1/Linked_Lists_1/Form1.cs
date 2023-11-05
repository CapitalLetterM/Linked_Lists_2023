using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linked_Lists_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class OneWayList
        {
            public List<OneWayListElement> list;
            public int Count;

            public OneWayList()
            {
                list = new List<OneWayListElement>();
                Count = list.Count;
            }

            public void add(OneWayListElement el)
            {
                list.Add(el);
                if (list.Count > 1)
                {
                    list[list.Count - 2].next = list[list.Count - 1];
                }
                Count++;
            }

            public OneWayListElement findLast()
            {
                return search(0, null);
            }

            private OneWayListElement search(int position, OneWayListElement param)
            {
                if (position == list.Count)
                {
                    return null;
                }
                if (list[position].next != param)
                {
                    return search(position + 1, param);
                }
                else
                {
                    return list[position];
                }
            }

            public OneWayListElement findFirst()
            {
                return searchFirst(0);
            }

            private OneWayListElement searchFirst(int position)
            {
                if (search(0, list[position]) != null)
                {
                    return searchFirst(position + 1);
                }
                else
                {
                    return list[position];
                }
            }

            public OneWayListElement findPrevious(OneWayListElement param)
            {
                return search(0, param);
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
        }

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            OneWayListElement one = fillList(textBox1.Text);
            OneWayListElement two = fillList(textBox2.Text);
            merge(one, two);
        }

        private OneWayListElement fillList(string text)
        {
            OneWayListElement el = null;
            int counter = 1;
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
                        if(el == null)
                        {
                            el = new OneWayListElement(Convert.ToInt32(temp));
                        }
                        else
                        {
                            cycle(el, counter).next = new OneWayListElement(Convert.ToInt32(temp));
                            counter++;
                        }
                        temp = "";
                    }
                }
            }
            if (temp != "")
            {
                cycle(el, counter).next = new OneWayListElement(Convert.ToInt32(temp));
            }
            return el;
        }

        //потрібна функція
        private OneWayListElement merge(OneWayListElement one, OneWayListElement two)
        {
            OneWayListElement firstCurrent = one;
            OneWayListElement secondCurrent = two;
            OneWayListElement merged;
            int counter = 1;
            int fastFill = 0;
            if (firstCurrent.value > secondCurrent.value)
            {
                merged = secondCurrent;
                secondCurrent = secondCurrent.next;
            }
            else
            {
                merged = firstCurrent;
                firstCurrent = firstCurrent.next;
            }
            while (firstCurrent.next != null || secondCurrent.next != null)
            {
                if (firstCurrent.value > secondCurrent.value)
                {
                    cycle(merged, counter).next = secondCurrent;
                    counter++;
                    if (secondCurrent.next == null)
                    {
                        fastFill = 1;
                        break;
                    }
                    secondCurrent = secondCurrent.next;
                }
                else
                {
                    cycle(merged, counter).next = firstCurrent;
                    counter++;
                    if (secondCurrent.next == null)
                    {
                        fastFill = 2;
                        break;
                    }
                    firstCurrent = firstCurrent.next;
                }
            }

            bool last = false;
            if(fastFill == 1)
            {
                while (last == false)
                {
                    if(firstCurrent.next == null)
                    {
                        last = true;
                    }
                    cycle(merged, counter).next = firstCurrent;
                    counter++;
                    firstCurrent = firstCurrent.next;
                }
            }
            else if (fastFill == 2)
            {
                while (last == false)
                {
                    if (secondCurrent.next == null)
                    {
                        last = true;
                    }
                    cycle(merged, counter).next = secondCurrent;
                    counter++;
                    secondCurrent = secondCurrent.next;
                }
            }
            return merged;
        }

        private OneWayListElement cycle(OneWayListElement el, int depth, int currentDepth = 0)
        {
            currentDepth++;
            if(currentDepth == depth)
            {
                return el;
            }
            else
            {
                return cycle(el.next, depth, currentDepth);
            }
        }
    }
}
