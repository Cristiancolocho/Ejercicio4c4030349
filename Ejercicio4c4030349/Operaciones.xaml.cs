namespace Ejercicio4c4030349;

public partial class Operaciones : ContentPage
{
	public Operaciones()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if (!string.IsNullOrEmpty(Op1.Text))
		{
			double resultado, resultado2, d1;
			d1 = Convert.ToDouble(Op1.Text);
			resultado= d1*d1;
			resultado2 = d1 * d1 * d1;
			OPP.Text = resultado.ToString();
            OPP2.Text = resultado2.ToString();
		}
		else
		{
			DisplayAlert("Error", "Introduce todos los numeros", "OK");
		}
    }
}