using System.Collections.Generic;
using DCLogger.Models;

namespace DCLogger.Interfaces
{
    /// <summary>
    /// Interface to Interact with the DataCube Logger
    /// </summary>
    public interface IDcLogger
    {
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

        #endregion

        #region Logging

        /// <summary>
        /// Logs an Error
        /// </summary>
        /// <param name="eventId">The Id of the Error</param>
        /// <param name="appId">The Application Id</param>
        /// <param name="beatId">Hearthbeat id</param>
        /// <param name="languageEnum">The Language you want the errorMessage be in </param>
        /// <param name="AdditionalInfo">an Object with can contain any additionalinfo you might log with</param>
        /// <param name="errorMessage">The errorMessage in the Given languageEnum</param>
        /// <returns>if Error could be created it will be true</returns>
        public bool Log(int eventId, int appId, int beatId, LanguageEnum languageEnum,object AdditionalInfo ,out string errorMessage);


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
