using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestComponent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LinkedList<SpectrumDraw.GAPoint> spList = new LinkedList<SpectrumDraw.GAPoint>();

            LinkedList<SpectrumDraw.GAPoint> spList2 = new LinkedList<SpectrumDraw.GAPoint>();

            float delta = 0.1f;

            for (int i = 0; i < 10; i++)
            {
                SpectrumDraw.GAPoint fakeSP = new SpectrumDraw.GAPoint(i, (int)(80 * Math.Abs(Math.Sin(i * delta))));

                SpectrumDraw.GAPoint fakeSP2 = new SpectrumDraw.GAPoint(i, 100 + (int)(80 * Math.Abs(Math.Sin(i * delta))));

                spList.AddLast(fakeSP);

                spList2.AddLast(fakeSP2);
            }

            Dictionary<String, LinkedList<SpectrumDraw.GAPoint>> dataMap = new Dictionary<string, LinkedList<SpectrumDraw.GAPoint>>();

            dataMap.Add("温度", spList);

            dataMap.Add("湿度", spList2);

            this.userControlDraw1.UpdateSpectrumWithDictionary(dataMap);

            //设置第二个组件

            LinkedList<SpectrumDraw.GAPoint> spList3 = new LinkedList<SpectrumDraw.GAPoint>();

            for (int i = 0; i < 1000; i++)
            {
                SpectrumDraw.GAPoint fakeSP3 = new SpectrumDraw.GAPoint(i, (int)(80 * Math.Abs(Math.Cos(i * delta))));

                spList3.AddLast(fakeSP3);
            }

            Dictionary<String, LinkedList<SpectrumDraw.GAPoint>> dataMap2 = new Dictionary<string, LinkedList<SpectrumDraw.GAPoint>>();

            dataMap2.Add("气压",spList3);

            this.userControlDraw2.UpdateSpectrumWithDictionary(dataMap2);
        }
    }
}
