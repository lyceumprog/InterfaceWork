using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace InterfaceWork
{
	[Activity (Label = "InterfaceWork", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton); // Получение ссылки на элемент кнопки на интерфейсе Main.axml
			EditText number = FindViewById<EditText> (Resource.Id.editText1); // Получение ссылки на элемент поля ввода на интерфейсе Main.axml
			TextView output = FindViewById<TextView> (Resource.Id.textView1); // Получение ссылки на элемент тексктового поля на интерфейсе Main.axml
			
			button.Click += delegate { // Обработка нажатия на кнопку
				int num = int.Parse(number.Text); // Получение введенного числа на элемент поля ввода и перевод полученной строки в тип целых чисел

				output.Text = (num + 5).ToString(); // Увеличение введенного числа на 5 и я
			};
		}
	}
}


