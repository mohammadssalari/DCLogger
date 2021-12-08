using System;
using System.Collections.Generic;
using DCLogger.Models;

namespace DCLogger.Interfaces
{
    public interface IDCLoggerApi
    {
        #region Api
        #region Managment
        /// <summary>
        /// Creates an Error if The Creation was successfull the function will return true
        /// </summary>
        /// <param name="languageEventMessageDictionary">A Dictionary of Languages and Error Messages like {"DE","The Getter konnte nicht erstellt werden"}</param>
        /// <param name="applicationId"></param>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public bool CreateEvent(Dictionary<LanguageEnum, string> languageEventMessageDictionary, int applicationId, out int eventId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appName">Application Name</param>
        /// <param name="description">A Description for the App</param>
        /// <param name="appId">Id of the App</param>
        /// <returns></returns>
        public bool CreateApp(string appName, string description, out int appId);

        /// <summary>
        /// Returns a String for a Known Error with der EventId 
        /// </summary>
        /// <param name="eventId">ID of a Knwon Error</param>
        /// <param name="languageEnum">Returnvalue Language. If the Language is not set the standard Language will be returned</param>
        /// <returns></returns>
        public string GetSpecificEventMessage(int eventId, LanguageEnum languageEnum);

        /// <summary>
        /// Get All Events for an Application with the Id od appId
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="languageEnum"></param>
        /// <returns></returns>
        public string[] GetEventMessagesForAnApp(int appId, LanguageEnum languageEnum);
        #endregion

        #region Debugging

        /// <summary>
        /// returns all Events and Events for the given hearthBeat
        /// </summary>
        /// <param name="hearthBeat"></param>
        /// <returns></returns>
        public Events[] GetProtocollForAHearthbeat(int hearthBeat);

        /// <summary>
        /// returns all Events and Events for the given Timespan
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public Events[] GetProtocollForaTimeSpan(DateTime start, DateTime end);

        #endregion


        #endregion

    }
}