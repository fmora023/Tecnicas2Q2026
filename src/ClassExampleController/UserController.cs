using ClassExampleController.Abstractions;
using ClassExampleModels;
using System.Collections.Generic;

namespace ClassExampleController
{
    /// <summary>
    /// Class in charge of the User operations.
    /// </summary>
    public class UserController
    {
        private IDataHandler<User> DataHandler { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserController"/> class.
        /// </summary>
        /// <param name="dataHandler">The data handler.</param>
        public UserController(IDataHandler<User> dataHandler)
        {
            DataHandler = dataHandler;
        }

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        /// <value>
        /// The users.
        /// </value>
        public List<User> Users { get; private set; }

        /// <summary>
        /// Loads this instance.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns></returns>
        public List<User> Load(string fileName)
        {
            var users = this.DataHandler.Load(fileName);

            if (users != null && users.Count > 0)
            {
                this.Users = users;
                return users;
            }

            return new List<User>();
        }

        /// <summary>
        /// Saves the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        public bool SaveUser(User user)
        {
            return true;
        }

        /// <summary>
        /// Deletes the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        public bool DeleteUser(User user)
        {
            return true;
        }
    }
}
