using System;
using System.Collections.Generic;

namespace UTorri.Client
{
    /// <summary>
    /// Factory class responsible for parsing json strings into valid RequestResult objects.
    /// </summary>
    public class RequestResultFactory
    {
        private IDictionary<Type, Func<string, RequestResult>> _register;

        protected RequestResultFactory()
        {
            _register = new Dictionary<Type, Func<string, RequestResult>>();
        }

        /// <summary>
        /// Creates and initalizes new instance of RequestResultFactory.
        /// </summary>
        /// <returns></returns>
        public static RequestResultFactory Create()
        {
            var factory = new RequestResultFactory();
            factory.Initialize();
            return factory;
        }

        /// <summary>
        /// Parses target json string into object of specified class.
        /// </summary>
        /// <typeparam name="T">Desired class instance type.</typeparam>
        /// <param name="json">Input stringified json.</param>
        /// <returns></returns>
        public T Get<T>(string json) where T: RequestResult
        {
            return _register[typeof (T)](json) as T;
        }

        /// <summary>
        /// Register new creator function and binds it to specified class type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="creator"></param>
        public void Register<T>(Func<string,RequestResult> creator) where T: RequestResult
        {
            var type = typeof (T);

            if (_register.ContainsKey(type))
                _register[type] = creator;
            else
                _register.Add(type, creator);
        }

        /// <summary>
        /// Removes from register passed type binding.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void Unregister<T>()
        {
            var type = typeof (T);
            if (_register.ContainsKey(type))
                _register.Remove(type);
        }

        /// <summary>
        /// Initializes JsonResponseFactory with basic configuration.
        /// </summary>
        protected virtual void Initialize()
        {
            Register<FileList>(json => new FileList(json));
            Register<TaskProperties>(json=> new TaskProperties(json));
            Register<TorrentList>(json => new TorrentList(json));
        }
    }
}
