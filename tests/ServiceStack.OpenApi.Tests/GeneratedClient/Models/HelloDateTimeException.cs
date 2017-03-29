// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace AutorestClient.Models
{
    using Microsoft.Rest;

    /// <summary>
    /// Exception thrown for an invalid response with HelloDateTime
    /// information.
    /// </summary>
#if LEGACY
    [System.Serializable]
#endif
    public class HelloDateTimeException : RestException
    {
        /// <summary>
        /// Gets information about the associated HTTP request.
        /// </summary>
        public HttpRequestMessageWrapper Request { get; set; }

        /// <summary>
        /// Gets information about the associated HTTP response.
        /// </summary>
        public HttpResponseMessageWrapper Response { get; set; }

        /// <summary>
        /// Gets or sets the body object.
        /// </summary>
        public HelloDateTime Body { get; set; }

        /// <summary>
        /// Initializes a new instance of the HelloDateTimeException class.
        /// </summary>
        public HelloDateTimeException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HelloDateTimeException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public HelloDateTimeException(string message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HelloDateTimeException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public HelloDateTimeException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }

#if LEGACY
        /// <summary>
        /// Initializes a new instance of the HelloDateTimeException class.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        protected HelloDateTimeException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Serializes content of the exception.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
            if (info == null)
            {
                throw new System.ArgumentNullException("info");
            }

            info.AddValue("Request", Request);
            info.AddValue("Response", Response);
            info.AddValue("Body", Body);
        }
#endif
    }
}