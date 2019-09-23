using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using OpenTK.Graphics.ES30;

namespace XFSampleApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
       

        private void Button_Clicked(object sender, EventArgs e)
        {
            openGLView.Display();
        }

        public MainPage()
        {
            InitializeComponent();

            float red = 0, green = 0, blue = 0;

            openGLView.OnDisplay = (r) =>
            {

                GL.ClearColor(red, green, blue, 1.0f);
                GL.Clear((ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit));
                
                red += 0.01f;
                if (red >= 1.0f)
                    red -= 1.0f;
                green += 0.02f;
                if (green >= 1.0f)
                    green -= 1.0f;
                blue += 0.03f;
                if (blue >= 1.0f)
                    blue -= 1.0f;
            };

        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            openGLView.HasRenderLoop = e.Value;
        }
    }
}
