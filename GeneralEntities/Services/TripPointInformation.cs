﻿using System.Runtime.Serialization;

namespace GeneralEntities.Services
{
	/// <summary>
	/// Содержит описание информации о точке путешествия
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class TripPointInformation
	{
		/// <summary>
		/// Код точки путешествия (аэропорт, вокзал, отель и т.д.)
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Code { get; set; }

		/// <summary>
		/// Код структурного элемента точки путешествия - терминал в аэропорту
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string SubPointCode { get; set; }

		/// <summary>
		/// Код города, в котором находится точка путешествия
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string CityCode { get; set; }

		/// <summary>
		/// Часовой пояс точки путешествия на момент путешествия
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public float? UTC { get; set; }

		public string GetCityCode()
		{
			return !string.IsNullOrWhiteSpace(CityCode) ? CityCode : Code;
		}
	}
}