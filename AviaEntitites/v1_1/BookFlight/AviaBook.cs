﻿using AviaEntities.BookFlight.RequestElements;
using AviaEntities.v1_1.BookFlight.ResponseElements;
using AviaEntities.v1_1.FlightSearch.ResponseElements;
using GeneralEntities;
using GeneralEntities.PNRDataContent;
using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.BookFlight
{
	/// <summary>
	/// Тело ответа на запрос создания брони, содержит всю информацию о брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "AviaBook_1_1")]
	public class AviaBook : ItemIdentification<long>
	{
		/// <summary>
		/// Статус брони
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public BookStatus Status { get; set; }

		/// <summary>
		/// Код брони в конкретной ГДС
		/// </summary>
		[DataMember(IsRequired = true, Order = 2, EmitDefaultValue = false)]
		public string Code { get; set; }

		/// <summary>
		/// Тип оплаты из ПНРа
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public PaymentType? StoredPaymentType { get; set; }

		/// <summary>
		/// Положение брони в очереди
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public int? QueryPlace { get; set; }

		/// <summary>
		/// Перелёт, по которому создана бронь
		/// </summary>
		[DataMember(IsRequired = true, Order = 5, EmitDefaultValue = false)]
		public Flight Flight { get; set; }

		/// <summary>
		/// Пассажиры
		/// </summary>
		[DataMember(IsRequired = true, Order = 6, EmitDefaultValue = false)]
		public BookedTravellerList Travellers { get; set; }

		/// <summary>
		/// Информация об агенстве
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public AgencyInfo Agency { get; set; }

		/// <summary>
		/// Список маршрутных квитанций
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public ItinReceiptList Receipts { get; set; }

		/// <summary>
		/// Индикатор успешности установки цены в Галилео
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public bool FareStored { get; set; }

		[DataMember(Order = 10, EmitDefaultValue = false)]
		public PNRDataItemList DataItems { get; set; }


		/// <summary>
		/// Создаёт экземпляр класса с инициализацией полей
		/// </summary>
		public AviaBook()
		{
			Travellers = new BookedTravellerList();
			FareStored = true;
		}
	}
}