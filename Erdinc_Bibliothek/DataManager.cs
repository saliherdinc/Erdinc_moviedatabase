using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Erdinc_Bibliothek
{
	public static class DataManager
	{
		private const string ConnectionString = "server=127.0.0.1;uid=root;database=kerer_movie";
		public static List<Movie> GetAllMovies()
		{
			using (MySqlConnection connection = new MySqlConnection(ConnectionString))
			{
				connection.Open();
				// TODO: more code will go here
				connection.Close();

				return null;
			}
		}
		public static List<Movie> Search(string searchString) { return null; }
	}
}
