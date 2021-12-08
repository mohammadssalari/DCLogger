using System;
using System.Collections.Generic;
using System.Globalization;
using DCLogger.Models;

namespace DCLogger.Interfaces
{
    /// <summary>
    /// Interface to Interact with the DataCube Logger
    /// </summary>
    public interface IDcLoggerNuget
    {
        #region Nuget

        /// <summary>
        /// Logs an Error
        /// </summary>
        /// <param name="eventId">The Id of the Error</param>
        /// <param name="appId">The Application Id</param>
        /// <param name="beatId">Hearthbeat id</param>
        /// <param name="languageEnum">The Language you want the errorMessage be in </param>
        /// <param name="additionalInfo">an Object with can contain any additionalinfo you might log with</param>
        /// <param name="eventLevel">The Level of event</param>
        /// <param name="errorMessage">The errorMessage in the Given languageEnum</param>
        /// <returns>if Error could be created it will be true</returns>
        public bool Log(int eventId, int appId, int beatId, LanguageEnum languageEnum, object additionalInfo, EventLevel eventLevel,out string errorMessage);


        /// <summary>
        /// Logs an Exception wich has not a eventId
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="appId"></param>
        /// <param name="beatId"></param>
        /// <returns></returns>
        public bool Log(System.Runtime.Serialization.ISerializable exception, int appId, int beatId);

        #endregion




    }
}
