using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mbr = "ตัวเลือกของคุณคือ : " + Environment.NewLine;

            //คุณอัฟเดทบล็อคของคุณบ่อยไหม
            if (radioButton1.Checked == true)
            {
                mbr = mbr + "คูณอัฟเดทบล็อกของคุณบ่อยไหม ? : ทุกวัน" + Environment.NewLine;
            }
            else if (radioButton2.Checked == true)
            {
                mbr = mbr + "คูณอัฟเดทบล็อกของคุณบ่อยไหม ? : 2 ครั้งต่อสัปดาห์" + Environment.NewLine;
            }
            else if (radioButton3.Checked == true)
            {
                mbr = mbr + "คูณอัฟเดทบล็อกของคุณบ่อยไหม ? : 3 ครั้งต่อสัปดาห์" + Environment.NewLine;
            }
            else if (radioButton4.Checked == true)
            {
                mbr = mbr + "คูณอัฟเดทบล็อกของคุณบ่อยไหม ? : ทุกสัปดาห์" + Environment.NewLine;
            }
            else
                
                {
                    mbr = mbr + "คุณอัฟเดทบล็อกของคุณบ่อยไหม : ทุกปักษ์" + Environment.NewLine;
                }
            //คุณทำงานในกลุ่มอาชีพใด
            
                if (radioButton6.Checked == true)
                {

                    mbr = mbr + "คุณทำงานในกลุ่มอาชีพใด : นักเรียน/นักศึกษา " + Environment.NewLine;
                }
                else if (radioButton7.Checked == true)
                {
                    mbr = mbr + "คุณทำงานในกลุ่มอาชีพใด : ผู้ประกอบวิชาชีพ" + Environment.NewLine;
                }
                else if (radioButton8.Checked == true)
                {
                    mbr = mbr + "คุณทำงานในกลุ่มอาชีพใด : พนักงาน" + Environment.NewLine;
                }
                else if (radioButton9.Checked == true)
                {
                    mbr = mbr + "คุณทำงานในกลุ่มอาชีพใด : ผู้จัดการ" + Environment.NewLine;
                }
                else if (radioButton10.Checked == true)
                {
                    mbr = mbr + "คุณทำงานในกลุ่มอาชีพใด : ไม่แน่ใจ" + Environment.NewLine;

                }
                else
                {
                    mbr = mbr + "คุณทำงานในกลุ่มอาชีพใด : ธุรกิจส่วนตัว" + Environment.NewLine;
                }
            //รายได้ของคุณอยู่ในช่วงใด ?
            if (radioButton12.Checked == true)
            {
                mbr = mbr + "รายได้ของคุณอยู่ในช่วงใด ? : นักเรียน/นักศึกษา/ว่างงาน" + Environment.NewLine;
            }
            else if (radioButton13.Checked == true)
            {
                mbr = mbr + "รายได้ของคุณอยู่ในช่วงใด ? : 5,000 หรือ ต่ำกว่า" + Environment.NewLine;

            }
            else if (radioButton14.Checked == true)
            {
                mbr = mbr + "รายได้ของคุณอยู่ในช่วงใด ? : 5,000 - 10,000" + Environment.NewLine;
            }
            else if (radioButton15.Checked == true)
            {
                mbr = mbr + "รายได้ของคุณอยู่ในช่วงใด ? : 10,000 กว่า - 20,000 " + Environment.NewLine;

            }
            else if  (radioButton16 .Checked == true )
            {
                mbr = mbr + "รายได้ของคุณอยู่ในช่วงใด ? : 30,000 กว่า - 40,000" + Environment.NewLine;
            }
            else if (radioButton17 .Checked == true )
            {

                if (textBox1.Text == "")
                {
                    mbr = mbr + "รายได้ของคุณอยู่ในช่วงใด ? : ยังไม่ได้กรอกข้อมูล"+ Environment .NewLine ;
                }
                else 
                {

                    mbr = mbr + "รายได้ของคุณอยู่ในช่วงใด ? : อื่น ๆ : " + textBox1.Text + Environment.NewLine;
                }
            }
            else 
            {
                
                mbr =mbr + "รายได้ของคุณอยู่ในช่วงใด ? : นักเรียน/นักศึกษา/ว่างงาน"+Environment .NewLine ;
                }
            //ระดับการศึกษาของคุณ
            if (radioButton18.Checked == true)
            {
                mbr = mbr + "ระดับการศึกษาของคุณ : โรงเรียนมัธยม"+ Environment .NewLine ;
            }
            else if (radioButton19.Checked == true)
            {
                mbr = mbr + "ระดับการศึกษาของคุณ : อนุปริญญา"+Environment .NewLine ;            
            }
            else if (radioButton20.Checked == true)
            {
                mbr = mbr + "ระดับการศึกษาของคุณ : ปริญญาตรี" + Environment.NewLine;
            }
            else if (radioButton21.Checked == true)
            {
                mbr = mbr + "ระดับการศึกษาของคุณ : ปริญญาโท" + Environment.NewLine;

            }
            else if (radioButton22 .Checked == true )
            {
                mbr = mbr +"ระดับการศึกษาของคุณ : ปริญญาเอก" + Environment.NewLine;
            }
            //กลุ่มประเภทของบล็อคคุณ
            if (radioButton24.Checked == true)
            {
                mbr = mbr + "กลุ่มประเภทของบล็อคคุณ : ยานยนต์"+Environment .NewLine ;

            }
            else if (radioButton25.Checked == true)
            {
                mbr = mbr + "กลุ่มประเภทของบล็อคคุณ : บล็อคร้านค้า"+Environment .NewLine ;
            }
            else if (radioButton26.Checked == true  )
            {
            mbr = mbr + "กลุ่มประเภทของบล็อคคุณ : บล็อคแบบ Social"+ Environment .NewLine ;
                
            }
            else if (radioButton27 .Checked == true )

            {
                mbr = mbr + "กลุ่มประเภทของบล็อคคุณ : ธุรกิจ" + Environment.NewLine;
            }
            else if (radioButton28.Checked == true)
            {
                mbr = mbr + "กลุ่มประเภทของบล็อคคุณ : บันเทิง " + Environment.NewLine;
            }
            else
            {
                mbr = mbr + "กลุ่มประเภทของบล็อคคุณ : แฟชั่น" + Environment.NewLine;
            }
            MessageBox.Show(mbr, "คำตอบของคุณคือ ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
