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
    /// Клиент.
    /// </summary>
    //  *** Start programmer edit section *** (Клиент CustomAttributes)

    //  *** End programmer edit section *** (Клиент CustomAttributes)
    [BusinessServer("IIS.WebLearning2016.КлиентBS, WebLearning2016.BusinessServers", ICSSoft.STORMNET.Business.DataServiceObjectEvents.OnAllEvents)]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("КлиентE", new string[] {
            "Наименование",
            "Тип",
            "Тип.Наименование",
            "Документ",
            "Фото",
            "КоличествоОбращений as \'Кол-во обращений\'",
            "ОбслуженоОбращений as \'Обслужено обращений\'",
            "Актуально",
            "ДатаРегистрации as \'Дата регистрации\'",
            "ДатаПоследнегоВизита as \'Дата последнего визита\'",
            "Email as \'Email\'",
            "МобильныйТелефон as \'Моб. телефон\'"}, Hidden=new string[] {
            "Тип.Наименование"})]
    [MasterViewDefineAttribute("КлиентE", "Тип", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    [View("КлиентL", new string[] {
            "Наименование",
            "Тип",
            "Тип.Наименование as \'Тип\'",
            "Документ",
            "Актуально"}, Hidden=new string[] {
            "Тип"})]
    public class Клиент : ICSSoft.STORMNET.DataObject
    {
        
        private string fНаименование;
        
        private ICSSoft.STORMNET.FileType.File fДокумент;
        
        private ICSSoft.STORMNET.UserDataTypes.WebFile fФото;
        
        private int fКоличествоОбращений;
        
        private double fОбслуженоОбращений;
        
        private System.DateTime fДатаРегистрации;
        
        private System.DateTime? fДатаПоследнегоВизита;
        
        private bool fАктуально;
        
        private string fEmail;
        
        private string fМобильныйТелефон;
        
        private IIS.WebLearning2016.ТипКлиента fТип;
        
        //  *** Start programmer edit section *** (Клиент CustomMembers)

        //  *** End programmer edit section *** (Клиент CustomMembers)

        
        /// <summary>
        /// Наименование.
        /// </summary>
        //  *** Start programmer edit section *** (Клиент.Наименование CustomAttributes)

        //  *** End programmer edit section *** (Клиент.Наименование CustomAttributes)
        [StrLen(255)]
        public virtual string Наименование
        {
            get
            {
                //  *** Start programmer edit section *** (Клиент.Наименование Get start)

                //  *** End programmer edit section *** (Клиент.Наименование Get start)
                string result = this.fНаименование;
                //  *** Start programmer edit section *** (Клиент.Наименование Get end)

                //  *** End programmer edit section *** (Клиент.Наименование Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Клиент.Наименование Set start)

                //  *** End programmer edit section *** (Клиент.Наименование Set start)
                this.fНаименование = value;
                //  *** Start programmer edit section *** (Клиент.Наименование Set end)

                //  *** End programmer edit section *** (Клиент.Наименование Set end)
            }
        }
        
        /// <summary>
        /// Документ.
        /// </summary>
        //  *** Start programmer edit section *** (Клиент.Документ CustomAttributes)

        //  *** End programmer edit section *** (Клиент.Документ CustomAttributes)
        public virtual ICSSoft.STORMNET.FileType.File Документ
        {
            get
            {
                //  *** Start programmer edit section *** (Клиент.Документ Get start)

                //  *** End programmer edit section *** (Клиент.Документ Get start)
                ICSSoft.STORMNET.FileType.File result = this.fДокумент;
                //  *** Start programmer edit section *** (Клиент.Документ Get end)

                //  *** End programmer edit section *** (Клиент.Документ Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Клиент.Документ Set start)

                //  *** End programmer edit section *** (Клиент.Документ Set start)
                this.fДокумент = value;
                //  *** Start programmer edit section *** (Клиент.Документ Set end)

                //  *** End programmer edit section *** (Клиент.Документ Set end)
            }
        }
        
        /// <summary>
        /// Фото.
        /// </summary>
        //  *** Start programmer edit section *** (Клиент.Фото CustomAttributes)

        //  *** End programmer edit section *** (Клиент.Фото CustomAttributes)
        public virtual ICSSoft.STORMNET.UserDataTypes.WebFile Фото
        {
            get
            {
                //  *** Start programmer edit section *** (Клиент.Фото Get start)

                //  *** End programmer edit section *** (Клиент.Фото Get start)
                ICSSoft.STORMNET.UserDataTypes.WebFile result = this.fФото;
                //  *** Start programmer edit section *** (Клиент.Фото Get end)

                //  *** End programmer edit section *** (Клиент.Фото Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Клиент.Фото Set start)

                //  *** End programmer edit section *** (Клиент.Фото Set start)
                this.fФото = value;
                //  *** Start programmer edit section *** (Клиент.Фото Set end)

                //  *** End programmer edit section *** (Клиент.Фото Set end)
            }
        }
        
        /// <summary>
        /// КоличествоОбращений.
        /// </summary>
        //  *** Start programmer edit section *** (Клиент.КоличествоОбращений CustomAttributes)

        //  *** End programmer edit section *** (Клиент.КоличествоОбращений CustomAttributes)
        public virtual int КоличествоОбращений
        {
            get
            {
                //  *** Start programmer edit section *** (Клиент.КоличествоОбращений Get start)

                //  *** End programmer edit section *** (Клиент.КоличествоОбращений Get start)
                int result = this.fКоличествоОбращений;
                //  *** Start programmer edit section *** (Клиент.КоличествоОбращений Get end)

                //  *** End programmer edit section *** (Клиент.КоличествоОбращений Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Клиент.КоличествоОбращений Set start)

                //  *** End programmer edit section *** (Клиент.КоличествоОбращений Set start)
                this.fКоличествоОбращений = value;
                //  *** Start programmer edit section *** (Клиент.КоличествоОбращений Set end)

                //  *** End programmer edit section *** (Клиент.КоличествоОбращений Set end)
            }
        }
        
        /// <summary>
        /// ОбслуженоОбращений.
        /// </summary>
        //  *** Start programmer edit section *** (Клиент.ОбслуженоОбращений CustomAttributes)

        //  *** End programmer edit section *** (Клиент.ОбслуженоОбращений CustomAttributes)
        public virtual double ОбслуженоОбращений
        {
            get
            {
                //  *** Start programmer edit section *** (Клиент.ОбслуженоОбращений Get start)

                //  *** End programmer edit section *** (Клиент.ОбслуженоОбращений Get start)
                double result = this.fОбслуженоОбращений;
                //  *** Start programmer edit section *** (Клиент.ОбслуженоОбращений Get end)

                //  *** End programmer edit section *** (Клиент.ОбслуженоОбращений Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Клиент.ОбслуженоОбращений Set start)

                //  *** End programmer edit section *** (Клиент.ОбслуженоОбращений Set start)
                this.fОбслуженоОбращений = value;
                //  *** Start programmer edit section *** (Клиент.ОбслуженоОбращений Set end)

                //  *** End programmer edit section *** (Клиент.ОбслуженоОбращений Set end)
            }
        }
        
        /// <summary>
        /// ДатаРегистрации.
        /// </summary>
        //  *** Start programmer edit section *** (Клиент.ДатаРегистрации CustomAttributes)

        //  *** End programmer edit section *** (Клиент.ДатаРегистрации CustomAttributes)
        public virtual System.DateTime ДатаРегистрации
        {
            get
            {
                //  *** Start programmer edit section *** (Клиент.ДатаРегистрации Get start)

                //  *** End programmer edit section *** (Клиент.ДатаРегистрации Get start)
                System.DateTime result = this.fДатаРегистрации;
                //  *** Start programmer edit section *** (Клиент.ДатаРегистрации Get end)

                //  *** End programmer edit section *** (Клиент.ДатаРегистрации Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Клиент.ДатаРегистрации Set start)

                //  *** End programmer edit section *** (Клиент.ДатаРегистрации Set start)
                this.fДатаРегистрации = value;
                //  *** Start programmer edit section *** (Клиент.ДатаРегистрации Set end)

                //  *** End programmer edit section *** (Клиент.ДатаРегистрации Set end)
            }
        }
        
        /// <summary>
        /// ДатаПоследнегоВизита.
        /// </summary>
        //  *** Start programmer edit section *** (Клиент.ДатаПоследнегоВизита CustomAttributes)

        //  *** End programmer edit section *** (Клиент.ДатаПоследнегоВизита CustomAttributes)
        public virtual System.DateTime? ДатаПоследнегоВизита
        {
            get
            {
                //  *** Start programmer edit section *** (Клиент.ДатаПоследнегоВизита Get start)

                //  *** End programmer edit section *** (Клиент.ДатаПоследнегоВизита Get start)
                System.DateTime? result = this.fДатаПоследнегоВизита;
                //  *** Start programmer edit section *** (Клиент.ДатаПоследнегоВизита Get end)

                //  *** End programmer edit section *** (Клиент.ДатаПоследнегоВизита Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Клиент.ДатаПоследнегоВизита Set start)

                //  *** End programmer edit section *** (Клиент.ДатаПоследнегоВизита Set start)
                this.fДатаПоследнегоВизита = value;
                //  *** Start programmer edit section *** (Клиент.ДатаПоследнегоВизита Set end)

                //  *** End programmer edit section *** (Клиент.ДатаПоследнегоВизита Set end)
            }
        }
        
        /// <summary>
        /// Актуально.
        /// </summary>
        //  *** Start programmer edit section *** (Клиент.Актуально CustomAttributes)

        //  *** End programmer edit section *** (Клиент.Актуально CustomAttributes)
        public virtual bool Актуально
        {
            get
            {
                //  *** Start programmer edit section *** (Клиент.Актуально Get start)

                //  *** End programmer edit section *** (Клиент.Актуально Get start)
                bool result = this.fАктуально;
                //  *** Start programmer edit section *** (Клиент.Актуально Get end)

                //  *** End programmer edit section *** (Клиент.Актуально Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Клиент.Актуально Set start)

                //  *** End programmer edit section *** (Клиент.Актуально Set start)
                this.fАктуально = value;
                //  *** Start programmer edit section *** (Клиент.Актуально Set end)

                //  *** End programmer edit section *** (Клиент.Актуально Set end)
            }
        }
        
        /// <summary>
        /// Email.
        /// </summary>
        //  *** Start programmer edit section *** (Клиент.Email CustomAttributes)

        //  *** End programmer edit section *** (Клиент.Email CustomAttributes)
        [StrLen(255)]
        public virtual string Email
        {
            get
            {
                //  *** Start programmer edit section *** (Клиент.Email Get start)

                //  *** End programmer edit section *** (Клиент.Email Get start)
                string result = this.fEmail;
                //  *** Start programmer edit section *** (Клиент.Email Get end)

                //  *** End programmer edit section *** (Клиент.Email Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Клиент.Email Set start)

                //  *** End programmer edit section *** (Клиент.Email Set start)
                this.fEmail = value;
                //  *** Start programmer edit section *** (Клиент.Email Set end)

                //  *** End programmer edit section *** (Клиент.Email Set end)
            }
        }
        
        /// <summary>
        /// МобильныйТелефон.
        /// </summary>
        //  *** Start programmer edit section *** (Клиент.МобильныйТелефон CustomAttributes)

        //  *** End programmer edit section *** (Клиент.МобильныйТелефон CustomAttributes)
        [StrLen(255)]
        public virtual string МобильныйТелефон
        {
            get
            {
                //  *** Start programmer edit section *** (Клиент.МобильныйТелефон Get start)

                //  *** End programmer edit section *** (Клиент.МобильныйТелефон Get start)
                string result = this.fМобильныйТелефон;
                //  *** Start programmer edit section *** (Клиент.МобильныйТелефон Get end)

                //  *** End programmer edit section *** (Клиент.МобильныйТелефон Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Клиент.МобильныйТелефон Set start)

                //  *** End programmer edit section *** (Клиент.МобильныйТелефон Set start)
                this.fМобильныйТелефон = value;
                //  *** Start programmer edit section *** (Клиент.МобильныйТелефон Set end)

                //  *** End programmer edit section *** (Клиент.МобильныйТелефон Set end)
            }
        }
        
        /// <summary>
        /// Клиент.
        /// </summary>
        //  *** Start programmer edit section *** (Клиент.Тип CustomAttributes)

        //  *** End programmer edit section *** (Клиент.Тип CustomAttributes)
        [PropertyStorage(new string[] {
                "Тип"})]
        [NotNull()]
        public virtual IIS.WebLearning2016.ТипКлиента Тип
        {
            get
            {
                //  *** Start programmer edit section *** (Клиент.Тип Get start)

                //  *** End programmer edit section *** (Клиент.Тип Get start)
                IIS.WebLearning2016.ТипКлиента result = this.fТип;
                //  *** Start programmer edit section *** (Клиент.Тип Get end)

                //  *** End programmer edit section *** (Клиент.Тип Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Клиент.Тип Set start)

                //  *** End programmer edit section *** (Клиент.Тип Set start)
                this.fТип = value;
                //  *** Start programmer edit section *** (Клиент.Тип Set end)

                //  *** End programmer edit section *** (Клиент.Тип Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "КлиентE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КлиентE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КлиентE", typeof(IIS.WebLearning2016.Клиент));
                }
            }
            
            /// <summary>
            /// "КлиентL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КлиентL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КлиентL", typeof(IIS.WebLearning2016.Клиент));
                }
            }
        }
    }
}
