namespace Cambio;
///<Summary>
///<Createddate>2023/06/30</Createddate>
///<company>SandBox</company>
///<lastmodificationdate>2023/07/01</lastmodificationdate>
///<lastmodificationdescription>
///Agregar la documentacion y la imagen
///</lastmodificationdescription>
///<lastmodifierautor>Lorena Vasquez</lastmodifierautor>
///</Summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// constructor de la clase
	/// </summary>
	
	public MainPage()
	{
		InitializeComponent();
	}
	/// <summary>
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>

	private void CounterBtn_Clicked(object sender, EventArgs e)
	{
		//agregamos las variables y luego de eso las convertimos, despues se hace la resta, 
		//la cual se mostrara en el vuelto. si un campo esta vacio entonces se enviara un mensaje de error
		if(!string.IsNullOrEmpty(Cost.Text) && !string.IsNullOrEmpty(Cant.Text))
		{
			double costo, money,Vuel;
			costo= Convert.ToDouble(Cost.Text);
			money = Convert.ToDouble(Cant.Text);

			Vuel = costo - money;
			Vuelto.Text = Vuel.ToString();
		}
		else
		{
			DisplayAlert("Error", "Ingresen todos los datos", "Oki Doki Yo");
		}

	}
}

