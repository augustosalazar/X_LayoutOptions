using Xamarin.Forms;

namespace LayoutOptionsVideo
{
    public partial class LayoutOptionsVideoPage : ContentPage
    {
        int h = 0;
        int hb = 0;

		int v = 0;
		int vb = 0;

        int o = 1;
        public LayoutOptionsVideoPage()
        {
			switch (Device.RuntimePlatform)
			{
				case Device.iOS:
					Padding = new Thickness(0, 20, 0, 0);
					break;
				default:
					break;
			}

            InitializeComponent();
        }

  
        void Handle_Horizontal_Clicked(object sender, System.EventArgs e){
            switch(h){
                case 0:
                    targetL.HorizontalOptions = LayoutOptions.Start;
                    targetHL.Text = "Start";
                    break;

                case 1:
                    targetL.HorizontalOptions = LayoutOptions.Center;
					targetHL.Text = "Center";
					break;

                case 2:
					targetL.HorizontalOptions = LayoutOptions.End;
					targetHL.Text = "End";
					break;

                case 3:
                    targetL.HorizontalOptions = LayoutOptions.Fill;
					targetHL.Text = "Fill";
					break;

				case 4:
					targetL.HorizontalOptions = LayoutOptions.StartAndExpand;
					targetHL.Text = "StartAndExpand";
					break;

				case 5:
                    targetL.HorizontalOptions = LayoutOptions.CenterAndExpand;
					targetHL.Text = "CentertAndExpand";
					break;

				case 6:
                    targetL.HorizontalOptions = LayoutOptions.EndAndExpand;
					targetHL.Text = "EndAndExpand";
					break;

				case 7:
					targetL.HorizontalOptions = LayoutOptions.FillAndExpand;
					targetHL.Text = "FillAndExpand";
					break;
            }
            h = ++h%8;

        }

		void Handle_Vertical_Clicked(object sender, System.EventArgs e)
		{
			switch (v)
			{
				case 0:
                    targetL.VerticalOptions = LayoutOptions.Start;
					targetVL.Text = "Start";
					break;

				case 1:
					targetL.VerticalOptions = LayoutOptions.Center;
					targetVL.Text = "Center";
					break;

				case 2:
					targetL.VerticalOptions = LayoutOptions.End;
					targetVL.Text = "End";
					break;

				case 3:
					targetL.VerticalOptions = LayoutOptions.Fill;
					targetVL.Text = "Fill";
					break;



				case 4:
                    targetL.VerticalOptions = LayoutOptions.StartAndExpand;
					targetVL.Text = "StartAndExpand";
					break;

				case 5:
					targetL.VerticalOptions = LayoutOptions.CenterAndExpand;
					targetVL.Text = "CenterAndExpand";
					break;

				case 6:
					targetL.VerticalOptions = LayoutOptions.EndAndExpand;
					targetVL.Text = "EndAndExpand";
					break;

				case 7:
					targetL.VerticalOptions = LayoutOptions.FillAndExpand;
					targetVL.Text = "FillAndExpand";
					break;
			}
			v = ++v % 8;

		}

		void Handle_Horizontal_B_Clicked(object sender, System.EventArgs e)
		{

			switch (hb)
			{
				case 0:
					targetB.HorizontalOptions = LayoutOptions.Start;
					targetHB.Text = "Start";
					break;

				case 1:
					targetB.HorizontalOptions = LayoutOptions.Center;
					targetHB.Text = "Center";
					break;

				case 2:
					targetB.HorizontalOptions = LayoutOptions.End;
					targetHB.Text = "End";
					break;

				case 3:
                    targetB.HorizontalOptions = LayoutOptions.Fill;
					targetHB.Text = "Fill";
					break;

				case 4:
					targetB.HorizontalOptions = LayoutOptions.StartAndExpand;
					targetHB.Text = "StartAndExpand";
					break;

				case 5:
					targetB.HorizontalOptions = LayoutOptions.CenterAndExpand;
					targetHB.Text = "CenterAndExpand";
					break;

				case 6:
					targetB.HorizontalOptions = LayoutOptions.EndAndExpand;
					targetHB.Text = "EndAndExpand";
					break;

				case 7:
					targetB.HorizontalOptions = LayoutOptions.FillAndExpand;
					targetHB.Text = "FillAndExpand";
					break;
			}
			hb = ++hb % 8;

		}

		void Handle_Vertical_B_Clicked(object sender, System.EventArgs e)
		{

			switch (vb)
			{
				case 0:
					targetB.HorizontalOptions = LayoutOptions.Start;
					targetVB.Text = "Start";
					break;

				case 1:
					targetB.HorizontalOptions = LayoutOptions.Center;
					targetVB.Text = "Center";
					break;

				case 2:
					targetB.HorizontalOptions = LayoutOptions.End;
					targetVB.Text = "End";
					break;

				case 3:
					targetB.HorizontalOptions = LayoutOptions.Fill;
					targetVB.Text = "Fill";
					break;

				case 4:
                    targetB.HorizontalOptions = LayoutOptions.StartAndExpand;
					targetVB.Text = "StartAndExpand";
					break;

				case 5:
					targetB.HorizontalOptions = LayoutOptions.CenterAndExpand;
					targetVB.Text = "CenterAndExpand";
					break;

				case 6:
					targetB.HorizontalOptions = LayoutOptions.EndAndExpand;
					targetVB.Text = "EndAndExpand";
					break;

				case 7:
					targetB.HorizontalOptions = LayoutOptions.FillAndExpand;
					targetVB.Text = "FillAndExpand";
					break;
			}
			vb = ++vb % 8;

		}

		void Handle_Orienntation_Clicked(object sender, System.EventArgs e)
		{

			switch (o)
			{
				case 0:
                    targetL.Orientation = StackOrientation.Horizontal;
					targetO.Text = "Horizontal";
					break;

				case 1:
                    targetL.Orientation = StackOrientation.Vertical;
					targetO.Text = "Vertical";
					break;

			}
			o= ++o % 2;

		}


					
    }
}
