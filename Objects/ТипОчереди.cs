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
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Тип очереди.
    /// </summary>
    //  *** Start programmer edit section *** (ТипОчереди CustomAttributes)

    //  *** End programmer edit section *** (ТипОчереди CustomAttributes)
    [AutoAltered()]
    [Caption("Тип очереди")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ТипОчередиL", new string[] {
            "Наименование",
            "Актуально"})]
    public class ТипОчереди : ICSSoft.STORMNET.DataObject
    {
        
        private string fНаименование;
        
        private bool fАктуально;
        
        //  *** Start programmer edit section *** (ТипОчереди CustomMembers)

        //  *** End programmer edit section *** (ТипОчереди CustomMembers)

        
        /// <summary>
        /// Наименование.
        /// </summary>
        //  *** Start programmer edit section *** (ТипОчереди.Наименование CustomAttributes)

        //  *** End programmer edit section *** (ТипОчереди.Наименование CustomAttributes)
        [StrLen(255)]
        public virtual string Наименование
        {
            get
            {
                //  *** Start programmer edit section *** (ТипОчереди.Наименование Get start)

                //  *** End programmer edit section *** (ТипОчереди.Наименование Get start)
                string result = this.fНаименование;
                //  *** Start programmer edit section *** (ТипОчереди.Наименование Get end)

                //  *** End programmer edit section *** (ТипОчереди.Наименование Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (ТипОчереди.Наименование Set start)

                //  *** End programmer edit section *** (ТипОчереди.Наименование Set start)
                this.fНаименование = value;
                //  *** Start programmer edit section *** (ТипОчереди.Наименование Set end)

                //  *** End programmer edit section *** (ТипОчереди.Наименование Set end)
            }
        }
        
        /// <summary>
        /// Актуально.
        /// </summary>
        //  *** Start programmer edit section *** (ТипОчереди.Актуально CustomAttributes)

        //  *** End programmer edit section *** (ТипОчереди.Актуально CustomAttributes)
        public virtual bool Актуально
        {
            get
            {
                //  *** Start programmer edit section *** (ТипОчереди.Актуально Get start)

                //  *** End programmer edit section *** (ТипОчереди.Актуально Get start)
                bool result = this.fАктуально;
                //  *** Start programmer edit section *** (ТипОчереди.Актуально Get end)

                //  *** End programmer edit section *** (ТипОчереди.Актуально Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (ТипОчереди.Актуально Set start)

                //  *** End programmer edit section *** (ТипОчереди.Актуально Set start)
                this.fАктуально = value;
                //  *** Start programmer edit section *** (ТипОчереди.Актуально Set end)

                //  *** End programmer edit section *** (ТипОчереди.Актуально Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ТипОчередиL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ТипОчередиL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ТипОчередиL", typeof(IIS.WebLearning2016.ТипОчереди));
                }
            }
        }
    }
}
