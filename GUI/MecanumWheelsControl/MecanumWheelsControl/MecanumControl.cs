using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MecanumWheelsControl
{
    public partial class MecanumControl : Form
    {
        public static SerialPort mobilePlatform;
        bool isConnected = false;
        List<Button> controls;
        bool clockDirection = true;
        bool isOpenLoop = true;
        public MecanumControl()
        {
            InitializeComponent();
            speed_lbl.Text = speedSlider.Value.ToString() + " %";
            speedSlider.Enabled = false;
            direction_btn.Enabled = false;
            wf_btn.Enabled = false;
            reset_btn.Enabled = false;
            pid_btn.Enabled = false;
            mobilePlatform = new SerialPort();
            portsList.Items.AddRange(SerialPort.GetPortNames().Distinct().ToArray());
            controls = new List<Button>();
            controls.Add(fwl_btn);
            controls.Add(fwd_btn);
            controls.Add(fwr_btn);
            controls.Add(left_btn);
            controls.Add(round_btn);
            controls.Add(right_btn);
            controls.Add(bwl_btn);
            controls.Add(back_btn);
            controls.Add(bwr_btn);
            foreach (var item in controls)
            {
                item.Enabled = false;
                item.FlatStyle = FlatStyle.Flat;
                item.FlatAppearance.BorderSize = 1;
            }
        }

        private void disconnect()
        {
            pictureConnect.Image = Properties.Resources.discon;
            connect_btn.Text = "Свържи се";
            speedSlider.Enabled = false;
            direction_btn.Enabled = false;
            isConnected = false;
            wf_btn.Enabled = false;
            reset_btn.Enabled = false;
            pid_btn.Enabled = false;
            feedback_lbl.Text = "Отворена система";
            isOpenLoop = true;
            foreach (var item in controls)
            {
                item.Enabled = false;
            }
        }
        private void connect_btn_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                if (portsList.Text.Length == 0)
                {
                    MessageBox.Show("Не си избрал сериен порт!", "Порт проблем", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                mobilePlatform.PortName = portsList.Text;
                mobilePlatform.BaudRate = 9600;
                try
                {
                    mobilePlatform.Open();
                    pictureConnect.Image = Properties.Resources.conn;
                    connect_btn.Text = "Прекрати връзката";
                    speedSlider.Enabled = true;
                    direction_btn.Enabled = true;
                    isConnected = true;
                    wf_btn.Enabled = true;
                    reset_btn.Enabled = true;
                    pid_btn.Enabled = true;
                    foreach (var item in controls)
                    {
                        item.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Проблем със серииния порт!", "Порт проблем", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                mobilePlatform.Close();
                pictureConnect.Image = Properties.Resources.discon;
                connect_btn.Text = "Свържи се";
                speedSlider.Enabled = false;
                direction_btn.Enabled = false;
                isConnected = false;
                wf_btn.Enabled = false;
                reset_btn.Enabled = false;
                pid_btn.Enabled = false;
                foreach (var item in controls)
                {
                    item.Enabled = false;
                }
            }    
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mobilePlatform.IsOpen)
            {
                mobilePlatform.Close();
            }
        }

        private void fwd_btn_MouseDown(object sender, MouseEventArgs e)
        {
            fwd_btn.FlatAppearance.BorderSize = 3;
            fwd_btn.FlatAppearance.BorderColor = Color.Blue;
            try
            {
                mobilePlatform.Write("fwd\n");
            }
            catch (Exception)
            {
                disconnect();
            }
        }

        private void fwd_btn_MouseUp(object sender, MouseEventArgs e)
        {
            fwd_btn.FlatAppearance.BorderSize = 1;
            fwd_btn.FlatAppearance.BorderColor = Color.Black;
            try
            { 
                mobilePlatform.Write("stop\n");
            }
            catch (Exception)
            {
                disconnect();
            }
        }


        private void fwl_btn_MouseDown(object sender, MouseEventArgs e)
        {
            fwl_btn.FlatAppearance.BorderSize = 3;
            fwl_btn.FlatAppearance.BorderColor = Color.Blue;
            try
            { 
                mobilePlatform.Write("fwl\n");
            }
            catch (Exception)
            {
                disconnect();
            }
        }

        private void fwl_btn_MouseUp(object sender, MouseEventArgs e)
        {
            fwl_btn.FlatAppearance.BorderSize = 1;
            fwl_btn.FlatAppearance.BorderColor = Color.Black;
            try
            { 
                mobilePlatform.Write("stop\n");
            }
            catch (Exception)
            {
                disconnect();
            }

        }

        private void fwr_btn_MouseDown(object sender, MouseEventArgs e)
        {
            fwr_btn.FlatAppearance.BorderSize = 3;
            fwr_btn.FlatAppearance.BorderColor = Color.Blue;
            try
            { 
                mobilePlatform.Write("fwr\n");
            }
            catch (Exception)
            {
                disconnect();
            }
        }

        private void fwr_btn_MouseUp(object sender, MouseEventArgs e)
        {
            fwr_btn.FlatAppearance.BorderSize = 1;
            fwr_btn.FlatAppearance.BorderColor = Color.Black;
            try
            { 
                mobilePlatform.Write("stop\n");
            }
            catch (Exception)
            {
                disconnect();
            }
        }

        private void left_btn_MouseDown(object sender, MouseEventArgs e)
        {
            left_btn.FlatAppearance.BorderSize = 3;
            left_btn.FlatAppearance.BorderColor = Color.Blue;
            try
            { 
                mobilePlatform.Write("left\n");
            }
            catch (Exception)
            {
                disconnect();
            }
        }

        private void left_btn_MouseUp(object sender, MouseEventArgs e)
        {
            left_btn.FlatAppearance.BorderSize = 1;
            left_btn.FlatAppearance.BorderColor = Color.Black;
            try
            { 
                mobilePlatform.Write("stop\n");
            }
            catch (Exception)
            {
                disconnect();
            }
        }
        private void right_btn_MouseDown(object sender, MouseEventArgs e)
        {
            right_btn.FlatAppearance.BorderSize = 3;
            right_btn.FlatAppearance.BorderColor = Color.Blue;
            try
            {
                mobilePlatform.Write("right\n");
            }
            catch (Exception)
            {
                disconnect();
            }
        }

        private void right_btn_MouseUp(object sender, MouseEventArgs e)
        {
            right_btn.FlatAppearance.BorderSize = 1;
            right_btn.FlatAppearance.BorderColor = Color.Black;
            try
            { 
                mobilePlatform.Write("stop\n");
            }
            catch (Exception)
            {
                disconnect();
            }
        }

        private void bwl_btn_MouseDown(object sender, MouseEventArgs e)
        {
            bwl_btn.FlatAppearance.BorderSize = 3;
            bwl_btn.FlatAppearance.BorderColor = Color.Blue;
            try
            { 
                mobilePlatform.Write("bwl\n");
            }
            catch (Exception)
            {
                disconnect();
            }
        }

        private void bwl_btn_MouseUp(object sender, MouseEventArgs e)
        {
            bwl_btn.FlatAppearance.BorderSize = 1;
            bwl_btn.FlatAppearance.BorderColor = Color.Black;
            try
            {
                mobilePlatform.Write("stop\n");
            }
            catch (Exception)
            {
                disconnect();
            }

        }

        private void back_btn_MouseDown(object sender, MouseEventArgs e)
        {
            back_btn.FlatAppearance.BorderSize = 3;
            back_btn.FlatAppearance.BorderColor = Color.Blue;
            try
            { 
                mobilePlatform.Write("back\n");
            }
            catch (Exception)
            {
                disconnect();
            }
        }

        private void back_btn_MouseUp(object sender, MouseEventArgs e)
        {
            back_btn.FlatAppearance.BorderSize = 1;
            back_btn.FlatAppearance.BorderColor = Color.Black;
            try
            { 
                mobilePlatform.Write("stop\n");
            }
            catch (Exception)
            {
                disconnect();
            }
        }

        private void bwr_btn_MouseDown(object sender, MouseEventArgs e)
        {
            bwr_btn.FlatAppearance.BorderSize = 3;
            bwr_btn.FlatAppearance.BorderColor = Color.Blue;
            try
            { 
                mobilePlatform.Write("bwr\n");
            }
            catch (Exception)
            {
                disconnect();
            }
        }

        private void bwr_btn_MouseUp(object sender, MouseEventArgs e)
        {
            bwr_btn.FlatAppearance.BorderSize = 1;
            bwr_btn.FlatAppearance.BorderColor = Color.Black;
            try
            { 
                mobilePlatform.Write("stop\n");
            }
            catch (Exception)
            {
                disconnect();
            }
        }

        private void round_btn_MouseDown(object sender, MouseEventArgs e)
        {
            round_btn.FlatAppearance.BorderSize = 3;
            round_btn.FlatAppearance.BorderColor = Color.Blue;
            if (clockDirection)
            {
                try
                {
                    mobilePlatform.Write("clockwise\n");
                }
                catch (Exception)
                {
                    disconnect();
                }
            }
            else
            {
                try
                { 
                    mobilePlatform.Write("anticlockwise\n");
                }
                catch (Exception)
                {
                    disconnect();
                }
            }
        }

        private void round_btn_MouseUp(object sender, MouseEventArgs e)
        {
            round_btn.FlatAppearance.BorderSize = 1;
            round_btn.FlatAppearance.BorderColor = Color.Black;
            try
            { 
                mobilePlatform.Write("stop\n");
            }
            catch (Exception)
            {
                disconnect();
            }
        }

        private void direction_btn_Click(object sender, EventArgs e)
        {
            if (clockDirection)
            {
                clockDirection = false;
                round_btn.Image = Properties.Resources.roundaboutanti;
            }
            else
            {
                clockDirection = true;
                round_btn.Image = Properties.Resources.roundabout;
            }
        }

        private void speedSlider_MouseUp(object sender, MouseEventArgs e)
        {
            string value = speedSlider.Value.ToString();
            speed_lbl.Text = value + " %";
            try
            {
                mobilePlatform.Write(value + '\n');
            }
            catch (Exception)
            {
                disconnect();
            }
        }

        private void pid_btn_Click(object sender, EventArgs e)
        {
            try
            {
                feedback_lbl.Text = $"Активирана ОВ: \r\n" +
                    $" Kп={kp_num.Value.ToString("0.00")}\r\n" +
                    $" Kи={ki_num.Value.ToString("0.00")}\r\n" +
                    $" Kд={kd_num.Value.ToString("0.00")} ";
                isOpenLoop = false;
                string command = "P";
                command += kp_num.Value.ToString("00.00");
                command += ki_num.Value.ToString("00.00");
                command += kd_num.Value.ToString("00.00");
                command += '\n';
                mobilePlatform.Write(command);
            }
            catch (Exception)
            {
                disconnect();
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            kp_num.Value = 1.0m;
            ki_num.Value = 1.5m;
            kd_num.Value = 0.05m;
        }

        private void wf_btn_Click(object sender, EventArgs e)
        {
            try
            {
                feedback_lbl.Text = "Отворена система";
                isOpenLoop = true;
                mobilePlatform.Write("open\n");
            }
            catch (Exception)
            {
                disconnect();
            }
        }
    }
}
