namespace Calculadora;

public partial class MainPage : ContentPage
{
	bool punto_existe = false;

	public MainPage()
	{
		InitializeComponent();
		btn0.Clicked += Btn0_Clicked;
		btn1.Clicked += Btn1_Clicked;
		btn2.Clicked += Btn2_Clicked;
		btn3.Clicked += Btn3_Clicked;
		btn4.Clicked += Btn4_Clicked;
		btn5.Clicked += Btn5_Clicked;
		btn6.Clicked += Btn6_Clicked;
		btn7.Clicked += Btn7_Clicked;
		btn8.Clicked += Btn8_Clicked;
		btn9.Clicked += Btn9_Clicked;

		btnPunto.Clicked += BtnPunto_Clicked;
		btnAC.Clicked += BtnAC_Clicked;

	}

	private void BtnAC_Clicked(object sender, EventArgs e)
	{
		punto_existe = false;
		lblDisplay.Text = "0";
	}

	private void BtnPunto_Clicked(object sender, EventArgs e)
	{
		if(punto_existe == false)
		{
			punto_existe=true;
			lblDisplay.Text += ".";
		}
	}

	private void Btn9_Clicked(object sender, EventArgs e)
	{
        num_clickeado("9");
    }

	private void Btn8_Clicked(object sender, EventArgs e)
	{
        num_clickeado("8");
    }

    private void Btn7_Clicked(object sender, EventArgs e)
    {
        num_clickeado("7");
    }

    private void Btn6_Clicked(object sender, EventArgs e)
	{
        num_clickeado("6");
    }

	private void Btn5_Clicked(object sender, EventArgs e)
	{
        num_clickeado("5");
    }

	private void Btn4_Clicked(object sender, EventArgs e)
	{
        num_clickeado("4");
    }

	private void Btn3_Clicked(object sender, EventArgs e)
	{
        num_clickeado("3");
    }

	private void Btn2_Clicked(object sender, EventArgs e)
	{
        num_clickeado("2");
    }

	private void Btn1_Clicked(object sender, EventArgs e)
	{
        num_clickeado("1");
    }

	private void Btn0_Clicked(object sender, EventArgs e)
	{
		if(lblDisplay.Text != "0")
		{
			lblDisplay.Text += "0";
		}
	}

    private void num_clickeado(string num)
    {
        if (lblDisplay.Text == "0")
        {
            lblDisplay.Text = num;
        }
        else
        {
            lblDisplay.Text += num;
        }
    }


}

