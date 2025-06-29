namespace CursoCompletoCSharp.View;

using Android.App;
using CursoCompletoCSharp.Models;
using System.Collections.ObjectModel;


public partial class LIstaPessoas : ContentPage
{
	ObservableCollection<Persona> pessoas;
	
	public LIstaPessoas()
	{
		InitializeComponent();
		pessoas = new ObservableCollection<Persona>();
		ListaPessoas.ItemsSource = pessoas;
	}

	public void OnAddListaClick(object? sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(NameEntry.Text))
		{
			labelAviso.Text = "Digite o nome!";
			labelAviso.IsVisible = true;
			return;
		}	
		
		string radioGender = null;

		if (ManRadioButton.IsChecked)
			radioGender = ManRadioButton.Content.ToString();
		else if(WomanRadioButton.IsChecked)
            radioGender = WomanRadioButton.Content.ToString();
		else if(ChildRadioButton.IsChecked)
            radioGender = ChildRadioButton.Content.ToString();

		if (string.IsNullOrWhiteSpace(radioGender))
		{
            labelAviso.Text = "Selecione uma categoria!";
            labelAviso.IsVisible = true;
            return;

        }

		pessoas.Add(new Persona { name = NameEntry.Text, gender = radioGender });

		//Limpeza genérica
		NameEntry.Text = "";
		labelAviso.Text = "";
		labelAviso.IsVisible = false;

	}

	public void OnDeleteClicked(object? sender, EventArgs e)
	{
		var button = sender as Button;
		var persona = button?.CommandParameter as Persona;
		if (persona != null)
			pessoas.Remove(persona);
	}

	public void OnCalcularClicked(object? sender, EventArgs e)
	{ 
		//Calcular baseado na Collection.
		if(pessoas.Count == 0)
		{
            labelAviso.Text = "A lista está vazia! Inclua uma ou mais pessoas.";
            labelAviso.IsVisible = true;            
            return;

		}

        //Limpeza genérica        
        labelAviso.Text = "";
        labelAviso.IsVisible = false;

    }
}