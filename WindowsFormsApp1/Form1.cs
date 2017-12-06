using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfSeEvalService;
using WindowsFormsApp1.MyService;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MyService.EvalServiceClient evalsclient = new MyService.EvalServiceClient("BasicHttpBinding_IEvalService");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Eval evalss = new Eval();
            //evalss.Submiter = "atmar";
            //evalss.Comment = "fgsdjgfjsdhgf";

            //evalss.Timesumetted = DateTime.Now;
            //evalsclient.SubmitEval(evalss);
            Eval[] ivo = evalsclient.GetEval();
            foreach (Eval item in ivo)
            {

                listBox1.Items.Add(item.Comment.ToString() + "    --" + item.Submiter+"-   --"+item.Timesumetted +"----"+item.Id);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Eval evalst = new Eval();

            evalst.Submiter = textBox1.Text;
            evalst.Comment = textBox2.Text;
            evalst.Timesumetted = DateTime.Now;
            evalsclient.SubmitEval(evalst);
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {


            evalsclient.RemoveEval(Convert.ToInt32(textBox3.Text));
            
           
            
        }
    }
}
