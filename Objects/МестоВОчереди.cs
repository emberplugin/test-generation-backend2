﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.WebLearning2016
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Место в очереди.
    /// </summary>
    //  *** Start programmer edit section *** (МестоВОчереди CustomAttributes)

    //  *** End programmer edit section *** (МестоВОчереди CustomAttributes)
    [BusinessServer("IIS.WebLearning2016.МестоВОчередиBS, WebLearning2016.BusinessServers", ICSSoft.STORMNET.Business.DataServiceObjectEvents.OnAllEvents)]
    [AutoAltered()]
    [Caption("Место в очереди")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("МестоВОчередиD", new string[] {
            "Номер",
            "Клиент",
            "Клиент.Наименование",
            "КлиентСтр",
            "Очередь",
            "ДатаВыдачи as \'Дата выдачи\'",
            "ДатаОбслуживания as \'Дата обслуживания\'"}, Hidden=new string[] {
            "Клиент.Наименование",
            "КлиентСтр",
            "Очередь"})]
    [MasterViewDefineAttribute("МестоВОчередиD", "Клиент", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    [View("МестоВОчередиL", new string[] {
            "Очередь",
            "Очередь.Наименование as \'Очередь\'",
            "Номер as \'Номер\'",
            "КлиентСтр as \'Клиент\'",
            "Клиент",
            "Клиент.Наименование as \'Клиент\'",
            "Клиент.Тип",
            "Клиент.Тип.Наименование as \'Тип клиента\'",
            "ОчередьСтр"}, Hidden=new string[] {
            "Очередь",
            "Клиент",
            "Клиент.Наименование",
            "Клиент.Тип",
            "ОчередьСтр"})]
    [View("МестоВОчередиПредикт", new string[] {
            "Очередь",
            "Очередь.Наименование as \'Очередь\'",
            "Номер as \'Номер\'",
            "КлиентСтр as \'Клиент\'",
            "Клиент",
            "Клиент.Тип",
            "Клиент.Тип.Наименование as \'Тип клиента\'",
            "ОчередьПредикт"}, Hidden=new string[] {
            "Очередь",
            "Очередь.Наименование",
            "Номер",
            "КлиентСтр",
            "Клиент",
            "Клиент.Тип",
            "Клиент.Тип.Наименование"})]
    public class МестоВОчереди : ICSSoft.STORMNET.DataObject
    {
        
        private int fНомер;
        
        private System.DateTime fДатаВыдачи;
        
        private System.DateTime? fДатаОбслуживания;
        
        private bool fОбслужено;
        
        private string fКлиентСтр;
        
        private IIS.WebLearning2016.Клиент fКлиент;
        
        private IIS.WebLearning2016.Очередь fОчередь;
        
        //  *** Start programmer edit section *** (МестоВОчереди CustomMembers)

        //  *** End programmer edit section *** (МестоВОчереди CustomMembers)

        
        /// <summary>
        /// Номер.
        /// </summary>
        //  *** Start programmer edit section *** (МестоВОчереди.Номер CustomAttributes)

        //  *** End programmer edit section *** (МестоВОчереди.Номер CustomAttributes)
        public virtual int Номер
        {
            get
            {
                //  *** Start programmer edit section *** (МестоВОчереди.Номер Get start)

                //  *** End programmer edit section *** (МестоВОчереди.Номер Get start)
                int result = this.fНомер;
                //  *** Start programmer edit section *** (МестоВОчереди.Номер Get end)

                //  *** End programmer edit section *** (МестоВОчереди.Номер Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (МестоВОчереди.Номер Set start)

                //  *** End programmer edit section *** (МестоВОчереди.Номер Set start)
                this.fНомер = value;
                //  *** Start programmer edit section *** (МестоВОчереди.Номер Set end)

                //  *** End programmer edit section *** (МестоВОчереди.Номер Set end)
            }
        }
        
        /// <summary>
        /// ДатаВыдачи.
        /// </summary>
        //  *** Start programmer edit section *** (МестоВОчереди.ДатаВыдачи CustomAttributes)

        //  *** End programmer edit section *** (МестоВОчереди.ДатаВыдачи CustomAttributes)
        public virtual System.DateTime ДатаВыдачи
        {
            get
            {
                //  *** Start programmer edit section *** (МестоВОчереди.ДатаВыдачи Get start)

                //  *** End programmer edit section *** (МестоВОчереди.ДатаВыдачи Get start)
                System.DateTime result = this.fДатаВыдачи;
                //  *** Start programmer edit section *** (МестоВОчереди.ДатаВыдачи Get end)

                //  *** End programmer edit section *** (МестоВОчереди.ДатаВыдачи Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (МестоВОчереди.ДатаВыдачи Set start)

                //  *** End programmer edit section *** (МестоВОчереди.ДатаВыдачи Set start)
                this.fДатаВыдачи = value;
                //  *** Start programmer edit section *** (МестоВОчереди.ДатаВыдачи Set end)

                //  *** End programmer edit section *** (МестоВОчереди.ДатаВыдачи Set end)
            }
        }
        
        /// <summary>
        /// ДатаОбслуживания.
        /// </summary>
        //  *** Start programmer edit section *** (МестоВОчереди.ДатаОбслуживания CustomAttributes)

        //  *** End programmer edit section *** (МестоВОчереди.ДатаОбслуживания CustomAttributes)
        public virtual System.DateTime? ДатаОбслуживания
        {
            get
            {
                //  *** Start programmer edit section *** (МестоВОчереди.ДатаОбслуживания Get start)

                //  *** End programmer edit section *** (МестоВОчереди.ДатаОбслуживания Get start)
                System.DateTime? result = this.fДатаОбслуживания;
                //  *** Start programmer edit section *** (МестоВОчереди.ДатаОбслуживания Get end)

                //  *** End programmer edit section *** (МестоВОчереди.ДатаОбслуживания Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (МестоВОчереди.ДатаОбслуживания Set start)

                //  *** End programmer edit section *** (МестоВОчереди.ДатаОбслуживания Set start)
                this.fДатаОбслуживания = value;
                //  *** Start programmer edit section *** (МестоВОчереди.ДатаОбслуживания Set end)

                //  *** End programmer edit section *** (МестоВОчереди.ДатаОбслуживания Set end)
            }
        }
        
        /// <summary>
        /// Обслужено.
        /// </summary>
        //  *** Start programmer edit section *** (МестоВОчереди.Обслужено CustomAttributes)

        //  *** End programmer edit section *** (МестоВОчереди.Обслужено CustomAttributes)
        public virtual bool Обслужено
        {
            get
            {
                //  *** Start programmer edit section *** (МестоВОчереди.Обслужено Get start)

                //  *** End programmer edit section *** (МестоВОчереди.Обслужено Get start)
                bool result = this.fОбслужено;
                //  *** Start programmer edit section *** (МестоВОчереди.Обслужено Get end)

                //  *** End programmer edit section *** (МестоВОчереди.Обслужено Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (МестоВОчереди.Обслужено Set start)

                //  *** End programmer edit section *** (МестоВОчереди.Обслужено Set start)
                this.fОбслужено = value;
                //  *** Start programmer edit section *** (МестоВОчереди.Обслужено Set end)

                //  *** End programmer edit section *** (МестоВОчереди.Обслужено Set end)
            }
        }
        
        /// <summary>
        /// КлиентСтр.
        /// </summary>
        //  *** Start programmer edit section *** (МестоВОчереди.КлиентСтр CustomAttributes)

        //  *** End programmer edit section *** (МестоВОчереди.КлиентСтр CustomAttributes)
        [StrLen(255)]
        public virtual string КлиентСтр
        {
            get
            {
                //  *** Start programmer edit section *** (МестоВОчереди.КлиентСтр Get start)

                //  *** End programmer edit section *** (МестоВОчереди.КлиентСтр Get start)
                string result = this.fКлиентСтр;
                //  *** Start programmer edit section *** (МестоВОчереди.КлиентСтр Get end)

                //  *** End programmer edit section *** (МестоВОчереди.КлиентСтр Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (МестоВОчереди.КлиентСтр Set start)

                //  *** End programmer edit section *** (МестоВОчереди.КлиентСтр Set start)
                this.fКлиентСтр = value;
                //  *** Start programmer edit section *** (МестоВОчереди.КлиентСтр Set end)

                //  *** End programmer edit section *** (МестоВОчереди.КлиентСтр Set end)
            }
        }
        
        /// <summary>
        /// ОчередьСтр.
        /// </summary>
        //  *** Start programmer edit section *** (МестоВОчереди.ОчередьСтр CustomAttributes)

        //  *** End programmer edit section *** (МестоВОчереди.ОчередьСтр CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        [StrLen(255)]
        [DataServiceExpression(typeof(ICSSoft.STORMNET.Business.MSSQLDataService), "@Очередь.Наименование@ + \' №\' + convert(varchar(10), @Номер@)")]
        public virtual string ОчередьСтр
        {
            get
            {
                //  *** Start programmer edit section *** (МестоВОчереди.ОчередьСтр Get)

                return null;
                //  *** End programmer edit section *** (МестоВОчереди.ОчередьСтр Get)
            }
            set
            {
                //  *** Start programmer edit section *** (МестоВОчереди.ОчередьСтр Set)

                //  *** End programmer edit section *** (МестоВОчереди.ОчередьСтр Set)
            }
        }
        
        /// <summary>
        /// ОчередьПредикт.
        /// </summary>
        //  *** Start programmer edit section *** (МестоВОчереди.ОчередьПредикт CustomAttributes)

        //  *** End programmer edit section *** (МестоВОчереди.ОчередьПредикт CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        [StrLen(255)]
        [DataServiceExpression(typeof(ICSSoft.STORMNET.Business.MSSQLDataService), "@Очередь.Наименование@ + \' №\' + convert(varchar(10), @Номер@) + \' (\' + @КлиентСтр" +
            "@ + \')\'")]
        public virtual string ОчередьПредикт
        {
            get
            {
                //  *** Start programmer edit section *** (МестоВОчереди.ОчередьПредикт Get)

                return null;
                //  *** End programmer edit section *** (МестоВОчереди.ОчередьПредикт Get)
            }
            set
            {
                //  *** Start programmer edit section *** (МестоВОчереди.ОчередьПредикт Set)

                //  *** End programmer edit section *** (МестоВОчереди.ОчередьПредикт Set)
            }
        }
        
        /// <summary>
        /// Место в очереди.
        /// </summary>
        //  *** Start programmer edit section *** (МестоВОчереди.Клиент CustomAttributes)

        //  *** End programmer edit section *** (МестоВОчереди.Клиент CustomAttributes)
        [PropertyStorage(new string[] {
                "Клиент"})]
        public virtual IIS.WebLearning2016.Клиент Клиент
        {
            get
            {
                //  *** Start programmer edit section *** (МестоВОчереди.Клиент Get start)

                //  *** End programmer edit section *** (МестоВОчереди.Клиент Get start)
                IIS.WebLearning2016.Клиент result = this.fКлиент;
                //  *** Start programmer edit section *** (МестоВОчереди.Клиент Get end)

                //  *** End programmer edit section *** (МестоВОчереди.Клиент Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (МестоВОчереди.Клиент Set start)

                //  *** End programmer edit section *** (МестоВОчереди.Клиент Set start)
                this.fКлиент = value;
                //  *** Start programmer edit section *** (МестоВОчереди.Клиент Set end)

                //  *** End programmer edit section *** (МестоВОчереди.Клиент Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.WebLearning2016.Очередь.
        /// </summary>
        //  *** Start programmer edit section *** (МестоВОчереди.Очередь CustomAttributes)

        //  *** End programmer edit section *** (МестоВОчереди.Очередь CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "Очередь"})]
        public virtual IIS.WebLearning2016.Очередь Очередь
        {
            get
            {
                //  *** Start programmer edit section *** (МестоВОчереди.Очередь Get start)

                //  *** End programmer edit section *** (МестоВОчереди.Очередь Get start)
                IIS.WebLearning2016.Очередь result = this.fОчередь;
                //  *** Start programmer edit section *** (МестоВОчереди.Очередь Get end)

                //  *** End programmer edit section *** (МестоВОчереди.Очередь Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (МестоВОчереди.Очередь Set start)

                //  *** End programmer edit section *** (МестоВОчереди.Очередь Set start)
                this.fОчередь = value;
                //  *** Start programmer edit section *** (МестоВОчереди.Очередь Set end)

                //  *** End programmer edit section *** (МестоВОчереди.Очередь Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "МестоВОчередиD" view.
            /// </summary>
            public static ICSSoft.STORMNET.View МестоВОчередиD
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("МестоВОчередиD", typeof(IIS.WebLearning2016.МестоВОчереди));
                }
            }
            
            /// <summary>
            /// "МестоВОчередиL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View МестоВОчередиL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("МестоВОчередиL", typeof(IIS.WebLearning2016.МестоВОчереди));
                }
            }
            
            /// <summary>
            /// "МестоВОчередиПредикт" view.
            /// </summary>
            public static ICSSoft.STORMNET.View МестоВОчередиПредикт
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("МестоВОчередиПредикт", typeof(IIS.WebLearning2016.МестоВОчереди));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of МестоВОчереди.
    /// </summary>
    //  *** Start programmer edit section *** (DetailArrayDetailArrayOfМестоВОчереди CustomAttributes)

    //  *** End programmer edit section *** (DetailArrayDetailArrayOfМестоВОчереди CustomAttributes)
    public class DetailArrayOfМестоВОчереди : ICSSoft.STORMNET.DetailArray
    {
        
        //  *** Start programmer edit section *** (IIS.WebLearning2016.DetailArrayOfМестоВОчереди members)

        //  *** End programmer edit section *** (IIS.WebLearning2016.DetailArrayOfМестоВОчереди members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type МестоВОчереди by index.
        /// </summary>
        /// <summary>
        /// Adds object with type МестоВОчереди.
        /// </summary>
        public DetailArrayOfМестоВОчереди(IIS.WebLearning2016.Очередь fОчередь) : 
                base(typeof(МестоВОчереди), ((ICSSoft.STORMNET.DataObject)(fОчередь)))
        {
        }
        
        public IIS.WebLearning2016.МестоВОчереди this[int index]
        {
            get
            {
                return ((IIS.WebLearning2016.МестоВОчереди)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.WebLearning2016.МестоВОчереди dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
